using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Syncfusion_Sample.UWP
{
    public abstract class UWPApplication : MvxWindowsApplication<MVVMCrossSetup, Core.App, FormsUI.App, MainPage>
    {

    }

    public class MVVMCrossSetup : MvxFormsWindowsSetup<Core.App, FormsUI.App>
    {
        public override IEnumerable<Assembly> GetViewAssemblies()
        {
            var syncfusionChartRendererAssembly = new List<Assembly>()
                {
                    typeof(Syncfusion.SfChart.XForms.UWP.SfChartRenderer).GetTypeInfo().Assembly
                };
            syncfusionChartRendererAssembly.AddRange(base.GetViewAssemblies());
            return syncfusionChartRendererAssembly;
        }
    }
}
