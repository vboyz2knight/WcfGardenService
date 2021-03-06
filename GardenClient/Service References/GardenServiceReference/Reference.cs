﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GardenClient.GardenServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Plant", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    [System.SerializableAttribute()]
    public partial class Plant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GardenClient.GardenServiceReference.hardinessZone coldestHardinessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GardenClient.GardenServiceReference.hardinessZone hottestHardinessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GardenClient.GardenServiceReference.sunExposure lightExposureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string maintenanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GardenClient.GardenServiceReference.Month[] seedStartMonthsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GardenClient.GardenServiceReference.plantType typeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GardenClient.GardenServiceReference.hardinessZone coldestHardiness {
            get {
                return this.coldestHardinessField;
            }
            set {
                if ((this.coldestHardinessField.Equals(value) != true)) {
                    this.coldestHardinessField = value;
                    this.RaisePropertyChanged("coldestHardiness");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GardenClient.GardenServiceReference.hardinessZone hottestHardiness {
            get {
                return this.hottestHardinessField;
            }
            set {
                if ((this.hottestHardinessField.Equals(value) != true)) {
                    this.hottestHardinessField = value;
                    this.RaisePropertyChanged("hottestHardiness");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GardenClient.GardenServiceReference.sunExposure lightExposure {
            get {
                return this.lightExposureField;
            }
            set {
                if ((this.lightExposureField.Equals(value) != true)) {
                    this.lightExposureField = value;
                    this.RaisePropertyChanged("lightExposure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string maintenance {
            get {
                return this.maintenanceField;
            }
            set {
                if ((object.ReferenceEquals(this.maintenanceField, value) != true)) {
                    this.maintenanceField = value;
                    this.RaisePropertyChanged("maintenance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GardenClient.GardenServiceReference.Month[] seedStartMonths {
            get {
                return this.seedStartMonthsField;
            }
            set {
                if ((object.ReferenceEquals(this.seedStartMonthsField, value) != true)) {
                    this.seedStartMonthsField = value;
                    this.RaisePropertyChanged("seedStartMonths");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GardenClient.GardenServiceReference.plantType type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="hardinessZone", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    public enum hardinessZone : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        zero = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        one = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        two = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        three = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        four = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        five = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        six = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        seven = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        eight = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        nine = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ten = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        eleven = 11,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="sunExposure", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    public enum sunExposure : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        full_shade = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        partial_shade = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        full_sun = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Month", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    public enum Month : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Undefined = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        January = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        February = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        March = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        April = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        May = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        June = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        July = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        August = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        September = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        October = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        November = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        December = 12,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="plantType", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    public enum plantType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        annual = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        perenial = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
    [System.SerializableAttribute()]
    public partial class GardenFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaultMessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FaultMessage {
            get {
                return this.FaultMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FaultMessageField, value) != true)) {
                    this.FaultMessageField = value;
                    this.RaisePropertyChanged("FaultMessage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GardenServiceReference.IGardenService")]
    public interface IGardenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/ViewAllPlantsInGarden", ReplyAction="http://tempuri.org/IGardenService/ViewAllPlantsInGardenResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/ViewAllPlantsInGardenGardenFaultFault", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] ViewAllPlantsInGarden();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/ListAnnual", ReplyAction="http://tempuri.org/IGardenService/ListAnnualResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/ListAnnualGardenFaultFault", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] ListAnnual();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/ListPerenial", ReplyAction="http://tempuri.org/IGardenService/ListPerenialResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/ListPerenialGardenFaultFault", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] ListPerenial();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/ListPlantsInZone", ReplyAction="http://tempuri.org/IGardenService/ListPlantsInZoneResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/ListPlantsInZoneGardenFaultFault", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] ListPlantsInZone(GardenClient.GardenServiceReference.hardinessZone myZone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/ListPlantsRequireThisSunExposure", ReplyAction="http://tempuri.org/IGardenService/ListPlantsRequireThisSunExposureResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/ListPlantsRequireThisSunExposureGardenFaultFaul" +
            "t", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] ListPlantsRequireThisSunExposure(GardenClient.GardenServiceReference.sunExposure mySun);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGardenService/PlantsToPlantInThisMonth", ReplyAction="http://tempuri.org/IGardenService/PlantsToPlantInThisMonthResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(GardenClient.GardenServiceReference.GardenFault), Action="http://tempuri.org/IGardenService/PlantsToPlantInThisMonthGardenFaultFault", Name="GardenFault", Namespace="http://schemas.datacontract.org/2004/07/WcfGardenService")]
        GardenClient.GardenServiceReference.Plant[] PlantsToPlantInThisMonth(GardenClient.GardenServiceReference.Month thisMonth);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGardenServiceChannel : GardenClient.GardenServiceReference.IGardenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GardenServiceClient : System.ServiceModel.ClientBase<GardenClient.GardenServiceReference.IGardenService>, GardenClient.GardenServiceReference.IGardenService {
        
        public GardenServiceClient() {
        }
        
        public GardenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GardenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GardenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GardenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GardenClient.GardenServiceReference.Plant[] ViewAllPlantsInGarden() {
            return base.Channel.ViewAllPlantsInGarden();
        }
        
        public GardenClient.GardenServiceReference.Plant[] ListAnnual() {
            return base.Channel.ListAnnual();
        }
        
        public GardenClient.GardenServiceReference.Plant[] ListPerenial() {
            return base.Channel.ListPerenial();
        }
        
        public GardenClient.GardenServiceReference.Plant[] ListPlantsInZone(GardenClient.GardenServiceReference.hardinessZone myZone) {
            return base.Channel.ListPlantsInZone(myZone);
        }
        
        public GardenClient.GardenServiceReference.Plant[] ListPlantsRequireThisSunExposure(GardenClient.GardenServiceReference.sunExposure mySun) {
            return base.Channel.ListPlantsRequireThisSunExposure(mySun);
        }
        
        public GardenClient.GardenServiceReference.Plant[] PlantsToPlantInThisMonth(GardenClient.GardenServiceReference.Month thisMonth) {
            return base.Channel.PlantsToPlantInThisMonth(thisMonth);
        }
    }
}
