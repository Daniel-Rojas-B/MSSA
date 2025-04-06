using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MonkeyFinder.ViewModel
{
    public partial class BaseViewModel:ObservableObject
    {
        public BaseViewModel() { }

        [ObservableProperty] // automatically creat a get and set property 
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(isNotBusy))]
        bool isBusy;

        public bool isNotBusy=>!isBusy;
    }
}
