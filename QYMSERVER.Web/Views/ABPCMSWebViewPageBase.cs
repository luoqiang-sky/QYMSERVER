using Abp.Web.Mvc.Views;

namespace QYMSERVER.Web.Views
{
    public abstract class QYMSERVERWebViewPageBase : QYMSERVERWebViewPageBase<dynamic>
    {

    }

    public abstract class QYMSERVERWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected QYMSERVERWebViewPageBase()
        {
            LocalizationSourceName = QYMSERVERConsts.LocalizationSourceName;
        }
    }
}