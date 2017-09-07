using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;

namespace Jgp.Issues.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(IssuesApplicationModule))]
    public class IssuesWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(IssuesApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
            //配置SwaggerUi
            ConfigureSwaggerUi();
        }
        /// <summary>
        /// 配置SwaggerUi
        /// </summary>
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Issues文档");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

                    //将application层中的注释添加到SwaggerUI中
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    var commentsFileName = "bin//Jgp.Issues.Application.XML";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    //将注释的XML文档添加到SwaggerUI中
                    c.IncludeXmlComments(commentsFile);
                })
                .EnableSwaggerUi("apis/{*assetPath}", b =>
                {
                    //对js进行了拓展
                    b.InjectJavaScript(Assembly.GetExecutingAssembly(), "Jgp.Issues.SwaggerUi.scripts.swagger.js");
                });
           
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWeb().AntiForgery.IsEnabled = false;
            base.PreInitialize();
        }
    }
}
