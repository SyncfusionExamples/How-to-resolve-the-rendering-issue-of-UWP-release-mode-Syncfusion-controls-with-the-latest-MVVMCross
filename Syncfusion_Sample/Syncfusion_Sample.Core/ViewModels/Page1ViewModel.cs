using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using Syncfusion.SfChart.XForms;
using Syncfusion_Sample.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Syncfusion_Sample.Core.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        private string _title = "NewsReader";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(() => Title); }
        }

        private ObservableCollection<ChartDataPoint> _newsCollection;
        public ObservableCollection<ChartDataPoint> NewsCollection
        {
            get { return _newsCollection; }
            set { _newsCollection = value; RaisePropertyChanged(() => NewsCollection); }
        }


        public Page1ViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService,
                                        IMvxMessenger messenger) : base(logProvider, navigationService, messenger)
        {
            LoadData();
        }

        private void LoadData()
        {
            NewsCollection = new ObservableCollection<ChartDataPoint>()

            {
                new ChartDataPoint("John",12000),
                new ChartDataPoint("James",11000),
                new ChartDataPoint("Mary",15000),
                new ChartDataPoint("Peter",1000),
                new ChartDataPoint("Rohan",16000),
            };
              
        }
    }
}
