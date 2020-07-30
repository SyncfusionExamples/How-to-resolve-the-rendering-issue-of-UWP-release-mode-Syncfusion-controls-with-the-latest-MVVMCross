using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncfusion_Sample.Core
{
    public class App : MvxApplication
    {

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            Mvx.IoCProvider.RegisterType<IMvxCommandHelper, MvxStrongCommandHelper>();

            RegisterCustomAppStart<AppStart>();
        }

    }
}
