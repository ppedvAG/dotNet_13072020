﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HalloWCF.Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pizza", Namespace="http://schemas.datacontract.org/2004/07/HalloWCF.Host")]
    [System.SerializableAttribute()]
    public partial class Pizza : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PreisField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Preis {
            get {
                return this.PreisField;
            }
            set {
                if ((this.PreisField.Equals(value) != true)) {
                    this.PreisField = value;
                    this.RaisePropertyChanged("Preis");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPizzaService")]
    public interface IPizzaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetPizzaListe", ReplyAction="http://tempuri.org/IPizzaService/GetPizzaListeResponse")]
        HalloWCF.Client.ServiceReference1.Pizza[] GetPizzaListe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/GetPizzaListe", ReplyAction="http://tempuri.org/IPizzaService/GetPizzaListeResponse")]
        System.Threading.Tasks.Task<HalloWCF.Client.ServiceReference1.Pizza[]> GetPizzaListeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaServiceChannel : HalloWCF.Client.ServiceReference1.IPizzaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaServiceClient : System.ServiceModel.ClientBase<HalloWCF.Client.ServiceReference1.IPizzaService>, HalloWCF.Client.ServiceReference1.IPizzaService {
        
        public PizzaServiceClient() {
        }
        
        public PizzaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HalloWCF.Client.ServiceReference1.Pizza[] GetPizzaListe() {
            return base.Channel.GetPizzaListe();
        }
        
        public System.Threading.Tasks.Task<HalloWCF.Client.ServiceReference1.Pizza[]> GetPizzaListeAsync() {
            return base.Channel.GetPizzaListeAsync();
        }
    }
}
