using Abp.Web.Mvc.Views;

namespace Jgp.Issues.Web.Views
{
    public abstract class IssuesWebViewPageBase : IssuesWebViewPageBase<dynamic>
    {

    }

    public abstract class IssuesWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected IssuesWebViewPageBase()
        {
            LocalizationSourceName = IssuesConsts.LocalizationSourceName;
        }
    }
}