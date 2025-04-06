using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Model;

namespace MonkeyFinder.ViewModel
{
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeyDetailsViewModel: BaseViewModel
    {
        IMap map;
        public MonkeyDetailsViewModel(IMap map)
        {
            this.map = map;
        }
        [ObservableProperty]
        Monkey monkey;

        [RelayCommand]
        async Task OpenMapAsync()
        {
            try
            {
                await map.TryOpenAsync(Monkey.Latitude, Monkey.Longitude,
                    new MapLaunchOptions { Name = Monkey.Name, NavigationMode = NavigationMode.Driving }
                    );
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error", "Unable to open the map", "Ok");
            }
        }

        
    }
}
