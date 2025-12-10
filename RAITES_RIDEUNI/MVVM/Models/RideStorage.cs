using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RAITES_RIDEUNI.MVVM.Models
{
    internal class RideStorage
    {
        public static ObservableCollection<RideModel> Rides { get; set; }
          = new ObservableCollection<RideModel>();
    }
}
