﻿using SoccerBettingApp.View;
using SoccerBettingApp.Services;

namespace SoccerBettingApp
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        public App(IServiceProvider services)
        {
            InitializeComponent();

            Services = services;

            
            MainPage = new NavigationPage(App.Services.GetRequiredService<LoginPage>());

        }
    }
}


