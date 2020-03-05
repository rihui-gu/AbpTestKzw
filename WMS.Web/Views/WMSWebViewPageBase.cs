using Abp.Web.Mvc.Views;

namespace WMS.Web.Views
{
    public abstract class WMSWebViewPageBase : WMSWebViewPageBase<dynamic>
    {

    }

    public abstract class WMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WMSWebViewPageBase()
        {
            LocalizationSourceName = WMSConsts.LocalizationSourceName;
        }
    }
}