using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTGarmentAdmin.Models
{
    public class VehicleDetail
    {
        public string Id { get; set; }
        public string Name{ get; set; }
        public string MobileNo{ get; set; }
        public string Address{ get; set; }
        public string ProfilePictureUrl{ get; set; }
        public int CItyId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string PinCode { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string AutoVehicleNo { get; set; }
        public double BalancePoints { get; set; }
        public string NfcCardNo { get; set; }
    }
}