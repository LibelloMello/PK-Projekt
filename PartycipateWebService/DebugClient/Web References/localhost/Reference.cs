﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace DebugClient.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServicePartycipateDBSoap", Namespace="http://grupp11.ics.lu.se/")]
    public partial class WebServicePartycipateDB : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetEventsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSingleUserListOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUsersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebServicePartycipateDB() {
            this.Url = global::DebugClient.Properties.Settings.Default.DebugClient_localhost_WebServicePartycipateDB;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetEventsCompletedEventHandler GetEventsCompleted;
        
        /// <remarks/>
        public event GetSingleUserListCompletedEventHandler GetSingleUserListCompleted;
        
        /// <remarks/>
        public event GetUsersCompletedEventHandler GetUsersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp11.ics.lu.se/GetEvents", RequestNamespace="http://grupp11.ics.lu.se/", ResponseNamespace="http://grupp11.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Event[] GetEvents() {
            object[] results = this.Invoke("GetEvents", new object[0]);
            return ((Event[])(results[0]));
        }
        
        /// <remarks/>
        public void GetEventsAsync() {
            this.GetEventsAsync(null);
        }
        
        /// <remarks/>
        public void GetEventsAsync(object userState) {
            if ((this.GetEventsOperationCompleted == null)) {
                this.GetEventsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEventsOperationCompleted);
            }
            this.InvokeAsync("GetEvents", new object[0], this.GetEventsOperationCompleted, userState);
        }
        
        private void OnGetEventsOperationCompleted(object arg) {
            if ((this.GetEventsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEventsCompleted(this, new GetEventsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp11.ics.lu.se/GetSingleUserList", RequestNamespace="http://grupp11.ics.lu.se/", ResponseNamespace="http://grupp11.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User[] GetSingleUserList() {
            object[] results = this.Invoke("GetSingleUserList", new object[0]);
            return ((User[])(results[0]));
        }
        
        /// <remarks/>
        public void GetSingleUserListAsync() {
            this.GetSingleUserListAsync(null);
        }
        
        /// <remarks/>
        public void GetSingleUserListAsync(object userState) {
            if ((this.GetSingleUserListOperationCompleted == null)) {
                this.GetSingleUserListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSingleUserListOperationCompleted);
            }
            this.InvokeAsync("GetSingleUserList", new object[0], this.GetSingleUserListOperationCompleted, userState);
        }
        
        private void OnGetSingleUserListOperationCompleted(object arg) {
            if ((this.GetSingleUserListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSingleUserListCompleted(this, new GetSingleUserListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupp11.ics.lu.se/GetUsers", RequestNamespace="http://grupp11.ics.lu.se/", ResponseNamespace="http://grupp11.ics.lu.se/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User[] GetUsers() {
            object[] results = this.Invoke("GetUsers", new object[0]);
            return ((User[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUsersAsync() {
            this.GetUsersAsync(null);
        }
        
        /// <remarks/>
        public void GetUsersAsync(object userState) {
            if ((this.GetUsersOperationCompleted == null)) {
                this.GetUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsersOperationCompleted);
            }
            this.InvokeAsync("GetUsers", new object[0], this.GetUsersOperationCompleted, userState);
        }
        
        private void OnGetUsersOperationCompleted(object arg) {
            if ((this.GetUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsersCompleted(this, new GetUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp11.ics.lu.se/")]
    public partial class Event {
        
        private int eventIdField;
        
        private string locationField;
        
        private string eventTimeField;
        
        private int openSlotsField;
        
        private string noteField;
        
        private User ownerField;
        
        private string eventNameField;
        
        /// <remarks/>
        public int EventId {
            get {
                return this.eventIdField;
            }
            set {
                this.eventIdField = value;
            }
        }
        
        /// <remarks/>
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        public string EventTime {
            get {
                return this.eventTimeField;
            }
            set {
                this.eventTimeField = value;
            }
        }
        
        /// <remarks/>
        public int OpenSlots {
            get {
                return this.openSlotsField;
            }
            set {
                this.openSlotsField = value;
            }
        }
        
        /// <remarks/>
        public string Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        public User Owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
        
        /// <remarks/>
        public string EventName {
            get {
                return this.eventNameField;
            }
            set {
                this.eventNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupp11.ics.lu.se/")]
    public partial class User {
        
        private string userNameField;
        
        private string phoneNumberField;
        
        private string nameField;
        
        private string emailField;
        
        private string passwordField;
        
        private string sexField;
        
        private int ageField;
        
        private Event[] eventsField;
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
            }
        }
        
        /// <remarks/>
        public int Age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        public Event[] Events {
            get {
                return this.eventsField;
            }
            set {
                this.eventsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetEventsCompletedEventHandler(object sender, GetEventsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Event[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Event[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetSingleUserListCompletedEventHandler(object sender, GetSingleUserListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSingleUserListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSingleUserListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetUsersCompletedEventHandler(object sender, GetUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591