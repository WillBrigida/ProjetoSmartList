using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using ProjetoCondominioSmart.Droid;
using ProjetoSmartList.Droid.Services;
using ProjetoSmartList.Services;
using Xamarin.Facebook;
using Xamarin.Forms;

namespace ProjetoSmartList.Droid
{
    [Activity(Label = "ProjetoSmartList", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            LoadApplication(new App(new AndroidInitializer()));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            #region FacebookService
            var manager = DependencyService.Get<IFacebookService>();
            if (manager != null)
            {
                (manager as FacebookService).CallbackManager.OnActivityResult(requestCode, (int)resultCode, data);
            }
            #endregion

            //if (requestCode == 1)
            //{
            //    GoogleSignInResult result = Auth.GoogleSignInApi.GetSignInResultFromIntent(data);
            //    GoogleService.Instance.OnAuthCompleted(result);
            //}
        }
    }
}