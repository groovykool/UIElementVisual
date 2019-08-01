using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Capture;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UIElementVisual
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Getvisual();
            
        }

        
        private void Getvisual()
        {

            string logtext = "";

            Visual Vis = ElementCompositionPreview.GetElementVisual(pp);
            logtext += $"[Page pp] Visual Size{Vis.Size.ToString()}" + "\n";
            tt.Text = logtext;
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {

            string logtext = "";

            Visual Vis = ElementCompositionPreview.GetElementVisual(pp);
            logtext += $"[Page pp] Visual Size{Vis.Size.ToString()}" + "\n";
           
            Vis = ElementCompositionPreview.GetElementVisual(cc);
            logtext += $"[Canvas cc] Visual Size{Vis.Size.ToString()}" + "\n";
            
            Vis = ElementCompositionPreview.GetElementVisual(rr);
            logtext += $"[Rectangle rr] Visual Size{Vis.Size.ToString()}" + "\n";
            tt.Text = logtext +"From bb Click Event.";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            string logtext = "";

            Visual Vis = ElementCompositionPreview.GetElementVisual(pp);
            logtext += $"[Page pp] Visual Size{Vis.Size.ToString()}" + "\n";
            Vis = ElementCompositionPreview.GetElementVisual(cc);
            logtext += $"[Canvas cc] Visual Size{Vis.Size.ToString()}" + "\n";
            Vis = ElementCompositionPreview.GetElementVisual(rr);
            logtext += $"[Rectangle rr] Visual Size{Vis.Size.ToString()}" + "\n";

            tt.Text = logtext + "From b2 Click Event.";
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            string logtext = "";
            Visual Vis = ElementCompositionPreview.GetElementVisual(pp);
            logtext += $"[Page pp] Visual Size{Vis.Size.ToString()}" + "\n";

            tt.Text = logtext+"From b3 Click Event.";
        }

        private void Pp_Loaded(object sender, RoutedEventArgs e)
        {
            Getvisual();
            tt.Text += "   From Page loaded Event";
        }

        
    }
}
