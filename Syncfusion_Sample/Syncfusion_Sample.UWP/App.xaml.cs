using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Syncfusion_Sample.UWP
{
    
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs activationArgs)
        {
            base.OnLaunched(activationArgs);

            List<Assembly> assembliesToInclude = new List<Assembly>();
            assembliesToInclude.Add(typeof(Syncfusion.SfChart.XForms.UWP.SfChartRenderer).GetTypeInfo().Assembly);
            Xamarin.Forms.Forms.Init(activationArgs, assembliesToInclude);
        }
    }
}
