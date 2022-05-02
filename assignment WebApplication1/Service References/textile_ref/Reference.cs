﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace assignment_WebApplication1.textile_ref {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="textile_ref.textileserviceSoap")]
    public interface textileserviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string addItems(string Item_ID, string Item_name, string Item_color, string Item_price, string Item_quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addItems", ReplyAction="*")]
        System.Threading.Tasks.Task<string> addItemsAsync(string Item_ID, string Item_name, string Item_color, string Item_price, string Item_quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/register", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string register(string First_name, string Last_name, string Email, string User_name, string Password, string Confirm_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/register", ReplyAction="*")]
        System.Threading.Tasks.Task<string> registerAsync(string First_name, string Last_name, string Email, string User_name, string Password, string Confirm_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updatestock", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool updatestock(string Item_ID, int newquantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updatestock", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> updatestockAsync(string Item_ID, int newquantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet SearchItems(string Item_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchItems", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchItemsAsync(string Item_ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool placeOrder(string Item_name, int newquantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/placeOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> placeOrderAsync(string Item_name, int newquantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OrderItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string OrderItem(string Order_ID, string Order_Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OrderItem", ReplyAction="*")]
        System.Threading.Tasks.Task<string> OrderItemAsync(string Order_ID, string Order_Quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ViewList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ViewList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ViewListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet CustomerSearch(string Item_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CustomerSearch", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> CustomerSearchAsync(string Item_Name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface textileserviceSoapChannel : assignment_WebApplication1.textile_ref.textileserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class textileserviceSoapClient : System.ServiceModel.ClientBase<assignment_WebApplication1.textile_ref.textileserviceSoap>, assignment_WebApplication1.textile_ref.textileserviceSoap {
        
        public textileserviceSoapClient() {
        }
        
        public textileserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public textileserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public textileserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public textileserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string addItems(string Item_ID, string Item_name, string Item_color, string Item_price, string Item_quantity) {
            return base.Channel.addItems(Item_ID, Item_name, Item_color, Item_price, Item_quantity);
        }
        
        public System.Threading.Tasks.Task<string> addItemsAsync(string Item_ID, string Item_name, string Item_color, string Item_price, string Item_quantity) {
            return base.Channel.addItemsAsync(Item_ID, Item_name, Item_color, Item_price, Item_quantity);
        }
        
        public string register(string First_name, string Last_name, string Email, string User_name, string Password, string Confirm_password) {
            return base.Channel.register(First_name, Last_name, Email, User_name, Password, Confirm_password);
        }
        
        public System.Threading.Tasks.Task<string> registerAsync(string First_name, string Last_name, string Email, string User_name, string Password, string Confirm_password) {
            return base.Channel.registerAsync(First_name, Last_name, Email, User_name, Password, Confirm_password);
        }
        
        public bool updatestock(string Item_ID, int newquantity) {
            return base.Channel.updatestock(Item_ID, newquantity);
        }
        
        public System.Threading.Tasks.Task<bool> updatestockAsync(string Item_ID, int newquantity) {
            return base.Channel.updatestockAsync(Item_ID, newquantity);
        }
        
        public System.Data.DataSet SearchItems(string Item_ID) {
            return base.Channel.SearchItems(Item_ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchItemsAsync(string Item_ID) {
            return base.Channel.SearchItemsAsync(Item_ID);
        }
        
        public bool placeOrder(string Item_name, int newquantity) {
            return base.Channel.placeOrder(Item_name, newquantity);
        }
        
        public System.Threading.Tasks.Task<bool> placeOrderAsync(string Item_name, int newquantity) {
            return base.Channel.placeOrderAsync(Item_name, newquantity);
        }
        
        public string OrderItem(string Order_ID, string Order_Quantity) {
            return base.Channel.OrderItem(Order_ID, Order_Quantity);
        }
        
        public System.Threading.Tasks.Task<string> OrderItemAsync(string Order_ID, string Order_Quantity) {
            return base.Channel.OrderItemAsync(Order_ID, Order_Quantity);
        }
        
        public System.Data.DataSet ViewList() {
            return base.Channel.ViewList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ViewListAsync() {
            return base.Channel.ViewListAsync();
        }
        
        public System.Data.DataSet CustomerSearch(string Item_Name) {
            return base.Channel.CustomerSearch(Item_Name);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> CustomerSearchAsync(string Item_Name) {
            return base.Channel.CustomerSearchAsync(Item_Name);
        }
    }
}
