using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CardReader.Styles;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CardReader.iOS.Renderer.PageRenderer))]
namespace CardReader.iOS.Renderer
{
    public class PageRenderer : Xamarin.Forms.Platform.iOS.PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
                return;

            try
            {
                SetTheme();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public override void TraitCollectionDidChange(UITraitCollection previousTraitCollection)
        {
            base.TraitCollectionDidChange(previousTraitCollection);

            if(TraitCollection.UserInterfaceStyle != previousTraitCollection.UserInterfaceStyle)
            {
                SetTheme();
            }
        }

        private void SetTheme()
        {
            if(TraitCollection.UserInterfaceStyle == UIUserInterfaceStyle.Dark)            
                App.Current.Resources = new DarkTheme();
            else
                App.Current.Resources = new LightTheme();
        }
    }
}
