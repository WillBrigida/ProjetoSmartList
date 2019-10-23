using ProjetoSmartList.Models;
using System;

namespace ProjetoSmartList.Services
{
    public interface IFacebookService
    {
        void Login(Action<UsuarioRedeSocial, string> onLoginComplete);
        void Logout();
    }
}
