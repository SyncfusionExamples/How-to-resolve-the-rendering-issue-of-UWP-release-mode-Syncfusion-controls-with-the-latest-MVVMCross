using System;
using MvvmCross;
using MvvmCross.Plugin.Messenger;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Syncfusion_Sample.FormsUI
{
    public partial class App : Application
    {
        IMvxMessenger _messenger;

        public App()
        {
            InitializeComponent();

        }

        protected override void OnStart()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("REMOVED_LICENSE");

            base.OnStart();

        }

    }
}