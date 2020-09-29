using Module04_TP1.CustomRenderer;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Module04_TP1.UWP.CustomRenderer;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(BorderlessEditor), typeof(BorderlessEditorRenderer))]

namespace Module04_TP1.UWP.CustomRenderer
{
    public class BorderlessEditorRenderer : EditorRenderer
    {
        public static void Init() { }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
                Control.Margin = new Windows.UI.Xaml.Thickness(0);
                Control.Padding = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}
