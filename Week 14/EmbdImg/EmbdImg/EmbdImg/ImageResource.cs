using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmbdImg
{
    [ContentProperty(nameof(Source))]
    class ImageResource : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (!string.IsNullOrEmpty(Source))
            {
                return ImageSource.FromResource(Source, typeof(ImageResource).GetTypeInfo().Assembly);
            }

            return null;
        }
    }
}
