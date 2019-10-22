using Prism;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;

namespace ProjetoCondominioSmart.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IDestructible, IActiveAware
    {
        protected INavigationService NavigationService { get; set; }
        protected IPageDialogService PageDialogService { get; set; }

        protected bool HasInitialized { get; set; }

        public event EventHandler IsActiveChanged;

        string title = string.Empty;

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

      
        string subtitle = string.Empty;

        public string Subtitle
        {
            get => subtitle;
            set => SetProperty(ref subtitle, value);
        }

        string icon = string.Empty;

        public string Icon
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }

   

        private string _buttonColorCaixa;
        public string ButtonColorCaixa
        {
            get { return _buttonColorCaixa; }
            set { SetProperty(ref _buttonColorCaixa, value); }
        }



      

        bool isBusy;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (SetProperty(ref isBusy, value))
                    IsNotBusy = !isBusy;
            }
        }


        private bool _isBusyVenda;

        public bool IsBusyVenda
        {
            get { return _isBusyVenda; }
            set { SetProperty(ref _isBusyVenda, value); }
        }


        bool isNotBusy = true;

        public bool IsNotBusy
        {
            get => isNotBusy;
            set
            {
                if (SetProperty(ref isNotBusy, value))
                    IsBusy = !isNotBusy;
            }
        }

        bool _checkBox = true;

        public bool CheckBox
        {
            get => _checkBox;
            set => SetProperty(ref _checkBox, value);
        }

        bool canLoadMore = true;

        public bool CanLoadMore
        {
            get => canLoadMore;
            set => SetProperty(ref canLoadMore, value);
        }

        private bool _status;
        public bool Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }



        string header = string.Empty;

        public string Header
        {
            get => header;
            set => SetProperty(ref header, value);
        }

        string footer = string.Empty;

        public string Footer
        {
            get => footer;
            set => SetProperty(ref footer, value);
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value, RaiseIsActiveChanged);
        }

        private string _enderecoIp;
        public string EnderecoIp
        {
            get { return _enderecoIp; }
            set { SetProperty(ref _enderecoIp, value); }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }

        protected BaseViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            NavigationService = navigationService;
            PageDialogService = pageDialogService;

            this.Title = $"Default";
        }

        #region ATRIBUTOS MENU
        string _descricaoCaixa = string.Empty;
        public string DescricaoCaixa
        {
            get => _descricaoCaixa;
            set => SetProperty(ref _descricaoCaixa, value);
        }

        string _descricaoCaixa2 = string.Empty;
        public string DescricaoCaixa2
        {
            get => _descricaoCaixa2;
            set => SetProperty(ref _descricaoCaixa2, value);
        }

        private string _buttonColorConfiguracao = string.Empty;
        public string ButtonColorConfiguracao
        {
            get => _buttonColorConfiguracao;
            set => SetProperty(ref _buttonColorConfiguracao, value);
        }

        #endregion

        public BaseViewModel()
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }


        public virtual void Destroy()
        {

        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

    }

}