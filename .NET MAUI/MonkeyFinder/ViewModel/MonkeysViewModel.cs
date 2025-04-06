using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Model;
using MonkeyFinder.Services;
using MonkeyFinder.View;

namespace MonkeyFinder.ViewModel
{
    public partial class MonkeysViewModel:BaseViewModel
    {
        MonkeyService monkeyService;
        IConnectivity connectivity;
        IGeolocation geolocation;
        public ObservableCollection<Monkey> Monkeys { get; } = new();
        public MonkeysViewModel (MonkeyService monkeyService, IConnectivity connectivity, IGeolocation geolocation)
        {
            this.monkeyService = monkeyService;
            this.connectivity = connectivity;
            this.geolocation = geolocation;

            Title = "Monkey Finder App";
        }
        [RelayCommand]
        async Task GetMonkeysAsync()
        {
            if(IsBusy) return;
            try
            {
                if(connectivity.NetworkAccess!=NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("Internet issue!", "Check your intertnet connection", "Ok");
                    return;
                }
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();
                if (Monkeys.Count != 0)
                    Monkeys.Clear();
                foreach (var monkey in monkeys)
                {
                    Monkeys.Add(monkey);
                }
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message); // debug does not execute in release
                await Shell.Current.DisplayAlert("Error", "Unable to get monkeys at this time", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
        [RelayCommand]
        async Task GetClosestMonkey()
        {
            if (IsBusy || Monkeys.Count == 0) return;
            try
            {
                var location = await geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await geolocation.GetLocationAsync(
                        new GeolocationRequest
                        {
                            DesiredAccuracy = GeolocationAccuracy.Medium,
                            Timeout = TimeSpan.FromSeconds(30)
                        }
                        );
                }
                if (location==null)
                {
                    return;
                }
                var first = Monkeys.OrderBy(x=>location.CalculateDistance(x.Latitude,x.Longitude,DistanceUnits.Miles)).FirstOrDefault();
                if (first == null) return;
                await Shell.Current.DisplayAlert("Closest monkey", $"{first.Name} at {first.Location}", "Ok");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                await Shell.Current.DisplayAlert("Error", "Unable to get closest monkey!", "Ok");
            }
        }
        [RelayCommand]
        async Task GoToDetailsAsync(Monkey monkey)
        {
            if(monkey==null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<string, object>
            {
                {"Monkey", monkey}
            });
        }
    }
}
