using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yad2_clone_server.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumOfRooms { get; set; }
        public int Floor { get; set; }
        public int Area { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string Description { get; set; }
        public string PropertyState { get; set; }
        public int YardArea { get; set; }
        public int BuiltArea { get; set; }
        public int FloorsInTheBuilding { get; set; }
        public int NumOfParkingSpots { get; set; }
        public int NumOfBalconies { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasBars { get; set; }
        public bool HasElevator { get; set; }
        public bool HasKosherKitchen { get; set; }
        public bool HasWaterHeater { get; set; }
        public bool HasDisabledAccess { get; set; }
        public bool IsRenovated { get; set; }
        public bool HasMamad { get; set; }
        public bool HasStorage { get; set; }
        public bool HasTadiranAC { get; set; }
        public bool HasFurniture { get; set; }
        public bool IsPriceFlexible { get; set; }
    }
}
