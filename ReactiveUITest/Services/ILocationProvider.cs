using System;

namespace ReactiveUITest
{
    public interface ILocationProvider
    {
        int MinTime { get; set;} // milliseconds
        int MinDistance {get; set; } // meters
        IObservable<GeoPosition> Locations { get; private set; }
        void StartMonitoringLocation();
        void StopMonitoringLocation();
    }
}

