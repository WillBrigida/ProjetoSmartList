using ProjetoSmartList.Droid;
using ProjetoSmartList.Services;
using System.Diagnostics;
using Xamarin.Forms;

[assembly: Dependency(typeof(TesteService))]

namespace ProjetoSmartList.Droid
{
    public class TesteService : ITesteService
    {
        public void TesteMetodo(string teste)
        {
            Debug.WriteLine(teste);
        }
    }
}
