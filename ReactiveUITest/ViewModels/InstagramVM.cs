using System;
using ReactiveUI;
using Geolocator.Plugin.Abstractions;

namespace ReactiveUITest
{
    public class InstagramVM : ReactiveObject
    {
        private DateTime _earliestPost;
        private DateTime _latestPost;

        public InstagramVM(IGeolocator locationProvider)
        {
            locationProvider.Locations.Subscribe((loc) => )
        }


    }
}

