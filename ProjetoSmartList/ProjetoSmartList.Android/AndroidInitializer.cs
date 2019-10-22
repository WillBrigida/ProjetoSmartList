using Prism;
using Prism.Ioc;
using Prism.Plugin.Popups;
using ProjetoSmartList.Droid;
using ProjetoSmartList.Services;

namespace ProjetoCondominioSmart.Droid
{
    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterPopupNavigationService();
            {
                containerRegistry.RegisterPopupNavigationService();
                containerRegistry.Register<ITesteService, TesteService>();
                //containerRegistry.Register<IFacebookService, FacebookService>();
            }
        }
    }
}