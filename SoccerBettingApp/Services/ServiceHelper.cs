using System;
using Microsoft.Maui.Controls; // ✅ this is for Application
using Microsoft.Extensions.DependencyInjection; // ✅ this is needed for GetService<T>()

namespace SoccerBettingApp
{
    public static class ServiceHelper
    {
        public static IServiceProvider Current =>
            (Application.Current as IApplication)?.Handler?.MauiContext?.Services;

        public static T GetService<T>() =>
            Current.GetService<T>();
    }
}


