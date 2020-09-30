
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Plugin.PayCards;
using Android.Content;
using CardReader.Styles;
using Android.Content.Res;
using Android.Support.V7.App;
using Xamarin.Forms;

namespace CardReader.Droid
{
    [Activity(Label = "CardReader", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            PayCardsRecognizerService.Initialize(this);

            LoadApplication(new App());
            SetAppTheme();
            MessagingCenter.Subscribe<Page, Theme>(this, "ModeChanged", callback: OnModeChanged);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            PayCardsRecognizerService.OnActivityResult(requestCode, resultCode, data);
        }


        private void OnModeChanged(Page arg1, Theme theme)
        {
            if (theme == CardReader.Theme.Light)
            {
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightNo);
            }
            else
            {
                Delegate.SetLocalNightMode(AppCompatDelegate.ModeNightYes);
            }
            SetTheme(theme);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        }

        void SetAppTheme()
        {
            if (Resources.Configuration.UiMode.HasFlag(UiMode.NightYes))
                SetTheme(CardReader.Theme.Dark);
            else
                SetTheme(CardReader.Theme.Light);
        }

        void SetTheme(Theme mode)
        {
            if (mode == CardReader.Theme.Dark)
            {
                if (App.AppTheme == CardReader.Theme.Dark)
                    return;
                App.Current.Resources = new DarkTheme();
            }
            else
            {
                if (App.AppTheme != CardReader.Theme.Dark)
                    return;
                App.Current.Resources = new LightTheme();
            }
            App.AppTheme = mode;
        }

    }
}