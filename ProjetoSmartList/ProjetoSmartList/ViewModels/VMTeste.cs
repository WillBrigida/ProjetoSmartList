using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using ProjetoCondominioSmart.ViewModels;
using ProjetoSmartList.Services;

namespace ProjetoSmartList.ViewModels
{
    public class VMTeste : BaseViewModel
    {
        readonly ITesteService _testeService;
        protected VMTeste(INavigationService navigationService, IPageDialogService pageDialogService, ITesteService testeService) 
            : base(navigationService, pageDialogService)
        {
            _testeService = testeService;
        }

        public DelegateCommand TesteCommand => new DelegateCommand(async () => await OnTeste());

        private async Task OnTeste()
        {
            _testeService?.TesteMetodo("Teste");
        }
    }
}
