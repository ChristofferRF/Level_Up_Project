﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RESTService.LevelUpServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LevelUpServiceRef.ILog")]
    public interface ILog {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/AddEntry", ReplyAction="http://tempuri.org/ILog/AddEntryResponse")]
        DataAccess.LogEntry AddEntry(string Distance, string LogEntryId, string Hours, string Minutes, string Seconds, string TypeOfExcercise);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILog/AddEntry", ReplyAction="http://tempuri.org/ILog/AddEntryResponse")]
        System.Threading.Tasks.Task<DataAccess.LogEntry> AddEntryAsync(string Distance, string LogEntryId, string Hours, string Minutes, string Seconds, string TypeOfExcercise);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogChannel : RESTService.LevelUpServiceRef.ILog, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogClient : System.ServiceModel.ClientBase<RESTService.LevelUpServiceRef.ILog>, RESTService.LevelUpServiceRef.ILog {
        
        public LogClient() {
        }
        
        public LogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DataAccess.LogEntry AddEntry(string Distance, string LogEntryId, string Hours, string Minutes, string Seconds, string TypeOfExcercise) {
            return base.Channel.AddEntry(Distance, LogEntryId, Hours, Minutes, Seconds, TypeOfExcercise);
        }
        
        public System.Threading.Tasks.Task<DataAccess.LogEntry> AddEntryAsync(string Distance, string LogEntryId, string Hours, string Minutes, string Seconds, string TypeOfExcercise) {
            return base.Channel.AddEntryAsync(Distance, LogEntryId, Hours, Minutes, Seconds, TypeOfExcercise);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LevelUpServiceRef.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/AddUser", ReplyAction="http://tempuri.org/IUser/AddUserResponse")]
        DataAccess.User AddUser(string Age, string Height, string Name, string Password, string UserId, string Username, string Weight, string XP, string Level);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/AddUser", ReplyAction="http://tempuri.org/IUser/AddUserResponse")]
        System.Threading.Tasks.Task<DataAccess.User> AddUserAsync(string Age, string Height, string Name, string Password, string UserId, string Username, string Weight, string XP, string Level);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        DataAccess.User GetUser(string UserName, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        System.Threading.Tasks.Task<DataAccess.User> GetUserAsync(string UserName, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserChannel : RESTService.LevelUpServiceRef.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<RESTService.LevelUpServiceRef.IUser>, RESTService.LevelUpServiceRef.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DataAccess.User AddUser(string Age, string Height, string Name, string Password, string UserId, string Username, string Weight, string XP, string Level) {
            return base.Channel.AddUser(Age, Height, Name, Password, UserId, Username, Weight, XP, Level);
        }
        
        public System.Threading.Tasks.Task<DataAccess.User> AddUserAsync(string Age, string Height, string Name, string Password, string UserId, string Username, string Weight, string XP, string Level) {
            return base.Channel.AddUserAsync(Age, Height, Name, Password, UserId, Username, Weight, XP, Level);
        }
        
        public DataAccess.User GetUser(string UserName, string Password) {
            return base.Channel.GetUser(UserName, Password);
        }
        
        public System.Threading.Tasks.Task<DataAccess.User> GetUserAsync(string UserName, string Password) {
            return base.Channel.GetUserAsync(UserName, Password);
        }
    }
}
