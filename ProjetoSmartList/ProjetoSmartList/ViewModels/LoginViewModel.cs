using Prism.Commands;
using ProjetoCondominioSmart.ViewModels;
using ProjetoSmartList.Models;
using ProjetoSmartList.Services;

namespace ProjetoSmartList.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        readonly IFacebookService _facebookService;
        protected LoginViewModel()
        {
            _facebookService = Xamarin.Forms.DependencyService.Get<IFacebookService>();
        }

        public DelegateCommand FacebookLoginCommand => new DelegateCommand(FacebookLogin);


        private void FacebookLogin()
        {
            _facebookService?.Login(OnLoginComplete);
        }

        private void OnLoginComplete(UsuarioRedeSocial usuario, string exception)
        {
            if (string.IsNullOrEmpty(exception))
            {
                //TODO
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"====={exception}=====");
            }
        }
    }
}
