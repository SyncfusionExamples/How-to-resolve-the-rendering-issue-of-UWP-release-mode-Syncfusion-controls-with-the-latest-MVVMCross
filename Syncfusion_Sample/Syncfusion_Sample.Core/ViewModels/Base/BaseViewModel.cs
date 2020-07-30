using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.Plugin.Messenger;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncfusion_Sample.Core.ViewModels
{
    public abstract class BaseViewModel : MvxNavigationViewModel
    {
        #region Private fields:

        protected readonly IMvxNavigationService _navigationService;

        protected IMvxMessenger _messenger;
        #endregion


        #region Constructor:
        protected BaseViewModel(IMvxLogProvider logProvider,
                                IMvxNavigationService navigationService,
                                IMvxMessenger messenger) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            _messenger = messenger;
            InitializeCommands();
        }


        protected virtual void InitializeCommands()
        {

        }

        #endregion

        protected virtual void UpdateCanExecute()
        {

        }
    }

    public class Model
    {
        public string Name { get; set; }

        public int  Income { get; set; }
    }

    public abstract class BaseViewModel<TParameter, TResult> : MvxNavigationViewModel<TParameter, TResult>
        where TParameter : class
        where TResult : class
    {
        #region Private fields:

        protected readonly IMvxNavigationService _navigationService;
        protected IMvxMessenger _messenger;

        #endregion

        #region Constructor:
        protected BaseViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService,
                                IMvxMessenger messenger) : base(logProvider, navigationService)
        {
            _navigationService = navigationService;
            _messenger = messenger;
            InitializeCommands();
        }

        public virtual void InitializeCommands()
        {

        }
        #endregion

        protected virtual void UpdateCanExecute()
        {

        }
    }
}
