using System.Web.Mvc;

namespace CustomValueProvider.CustomValueProvider
{
    public class CustomValueProviderFactoty : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new CustomValueProvider();
        }
    }
}