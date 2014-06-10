using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfGardenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGardenService
    {
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> ViewAllPlantsInGarden();
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> ListAnnual();
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> ListPerenial();
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> ListPlantsInZone(hardinessZone myZone);
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> ListPlantsRequireThisSunExposure(sunExposure mySun);
        [OperationContract]
        [FaultContract(typeof(GardenFault))]
        List<Plant> PlantsToPlantInThisMonth(Month thisMonth);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class Plant
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string maintenance { get; set; }
        [DataMember]
        public plantType type { get; set; }
        [DataMember]
        public sunExposure lightExposure { get; set; }
        [DataMember]
        public hardinessZone coldestHardiness { get; set; }
        [DataMember]
        public hardinessZone hottestHardiness { get; set; }
        [DataMember]
        public List<Month> seedStartMonths { get; set; }
    }

    [DataContract]
    public class GardenFault
    {
        [DataMember]
        public string FaultMessage;
        public GardenFault(string msg)
        {
            FaultMessage = msg;
        }
    }

    [DataContract]
    public enum plantType { [EnumMember]annual, [EnumMember] perenial }
    [DataContract]
    public enum sunExposure { [EnumMember]full_shade, [EnumMember] partial_shade, [EnumMember] full_sun }
    [DataContract]
    public enum hardinessZone
    { [EnumMember]zero, [EnumMember] one, [EnumMember] two, [EnumMember] three, [EnumMember] four, [EnumMember] five, [EnumMember] six, [EnumMember] seven, [EnumMember] eight, [EnumMember] nine, [EnumMember] ten, [EnumMember] eleven }
    [DataContract]
    public enum Month
    {
        [EnumMember]
        Undefined = 0,
        [EnumMember]
        January = 1,
        [EnumMember]
        February = 2,
        [EnumMember]
        March = 3,
        [EnumMember]
        April = 4,
        [EnumMember]
        May = 5,
        [EnumMember]
        June = 6,
        [EnumMember]
        July = 7,
        [EnumMember]
        August = 8,
        [EnumMember]
        September = 9,
        [EnumMember]
        October = 10,
        [EnumMember]
        November = 11,
        [EnumMember]
        December = 12
    }
}
