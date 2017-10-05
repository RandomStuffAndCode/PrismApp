using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase, IApplicationLifecycle
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public void OnResume()
        {
            var debug = 42;
        }

        public void OnSleep()
        {
            var debug = 42;
        }
    }
}
