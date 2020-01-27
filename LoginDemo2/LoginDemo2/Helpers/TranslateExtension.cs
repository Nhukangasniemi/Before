using LoginDemo2.Resources;
using System;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginDemo2.Helpers
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;

            return AppResources.ResourceManager.GetString(Text, AppResources.Culture);
        }
    }
}
