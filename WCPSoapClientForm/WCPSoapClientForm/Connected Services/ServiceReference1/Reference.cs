﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCPSoapClientForm.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    using System.Xml.Serialization;
    using System.ServiceModel;

    [DataContract(Name = "CheckRequestData ", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    [Serializable()]
    [XmlRoot("CheckRequestData", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7", IsNullable = false)]
    public partial class CheckRequestData : object {
 
        
        [DataMember(IsRequired=true)]
        [XmlElement("CheckDate", DataType = "date", Type = typeof(DateTime))]
        public DateTime CheckDate {get;set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("CheckPointCode", DataType = "string", Type = typeof(string))]
        public string CheckPointCode { get;set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("VehicleRegNumber", DataType = "string", Type = typeof(string))]
        public string VehicleRegNumber {get;set;}
        
        [DataMember(IsRequired=true)]
        [XmlElement("Direction", DataType = "int", Type = typeof(int))]
        public int Direction {get;set;}
        
        [DataMember(IsRequired = true)]
        [XmlElement("Latitude", DataType = "decimal", Type = typeof(decimal))]
        public decimal Latitude { get; set; }
        
        [DataMember(IsRequired=true)]
        [XmlElement("Longitude", DataType = "decimal", Type = typeof(decimal))]
        public decimal Longitude { get; set; }
        
        [DataMember(IsRequired=true)]
        [XmlElement("TotalWeight", DataType = "decimal", Type = typeof(decimal))]
        public decimal TotalWeight { get; set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("AxlesCount")]
        public int[] AxlesCount { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        [XmlElement("AxlesLoads")]
        public decimal[] AxlesLoads { get; set; }
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("AxlesInvervals")]
        public decimal[] AxlesInvervals {get;set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("TotalSize")]
        public CheckRequestDataTotalSize TotalSize {get;set;}
        
    }
    
    [DataContract(Name="CheckRequestDataTotalSize")]
    [Serializable()]
    public partial class CheckRequestDataTotalSize : object {
        
        [DataMember(IsRequired=true)]
        [XmlElement("Length", DataType = "decimal", Type = typeof(decimal))]
        public decimal Length {get;set;}
        
        [DataMember(IsRequired=true)]
        [XmlElement("Width", DataType = "decimal", Type = typeof(decimal))]
        public decimal Width {get;set;}
        
        [DataMember(IsRequired=true)]
        [XmlElement("Height", DataType = "decimal", Type = typeof(decimal))]
        public decimal Height { get;set;}
        
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt32", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt32 : System.Collections.Generic.List<System.Nullable<int>> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfDecimal", Namespace="http://tempuri.org/", ItemName="decimal")]
    [System.SerializableAttribute()]
    public class ArrayOfDecimal : System.Collections.Generic.List<System.Nullable<decimal>> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CheckResultDataList", Namespace="http://tempuri.org/", ItemName="CheckResultData")]
    [System.SerializableAttribute()]
    public class CheckResultDataList : System.Collections.Generic.List<WCPSoapClientForm.ServiceReference1.CheckResultData> {
    }

    [DataContract(Name = "CheckResultData", Namespace = "http://tempuri.org/")]
    [Serializable()]
    [XmlRoot("CheckResultData", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7", IsNullable = false)]

    public partial class CheckResultData : object {

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("Resolution")]
        public CheckResultDataCheckResultDataItemResolution Resolution { get; set; }

        [DataMember(IsRequired = true)]
        [XmlElement("TripCount")]
        public int TripCount { get; set; }

        [DataMember(IsRequired = true)]
        [XmlElement("LeftTripCount")]
        public int LeftTripCount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("Route")]
        public string Route { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("RouteCheck", Type = typeof(CheckResultDataCheckResultDataItemRouteCheck))]
        public CheckResultDataCheckResultDataItemRouteCheck RouteCheck { get; set; }

        [DataMember(IsRequired = true)]
        [XmlElement("DateFrom")]
        public DateTime DateFrom { get; set; }

        [DataMember(IsRequired = true)]
        [XmlElement("DateTo")]
        public DateTime DateTo { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("VehicleRegNumber")]
        public string VehicleRegNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("Transporter")]
        public string Transporter { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("TransporterAddress")]
        public string TransporterAddress { get; set; }

        [DataMember(IsRequired = true)]
        [XmlElement("TotalWeight", DataType = "decimal", Type = typeof(decimal))]
        public decimal FullWeight { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("Dimensions")]
        public CheckResultDataCheckResultDataItemDimensions Dimensions { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("AxlesLoads")]
        public decimal[] AxlesLoads { get; set; }
        public override string ToString()
        { string DD="";
            foreach (var p in AxlesLoads)
            {
                DD+= p.ToString()+ " ";
            }
            return DD.TrimEnd();
        }

        [DataMember(Name = "AxlesWheels", IsRequired = true)]
        [XmlElement("AxlesWheels")]
        public int[] AxlesWheels { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("AxlesInvervals")]
        public decimal[] AxlesInvervals { get; set; }

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("AxlesWeelsEx")]
        public int[] AxlesWeelsEx { get; set; }
        
        [DataMember(IsRequired=true)]
        [XmlElement("ShippingType", Type = typeof(CheckResultDataCheckResultDataItemShippingType))]
        public CheckResultDataCheckResultDataItemShippingType ShippingType {get;set;}
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    public partial class CheckResultDataCheckResultDataItemResolution : object {
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("DocumentNumber")]
        public string DocumentNumber { get;set;}
        
        [DataMember(IsRequired=true)]
        [XmlElement("DocumentDate", DataType = "date", Type = typeof(DateTime))]
        public DateTime DocumentDateSign { get; set;}
        
    }

    //[Serializable]
    //[XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    //public partial class CheckResultDataCheckResultDataItemRouteCheck  {

    //    [DataMember(IsRequired = true)]
    //    [XmlElement("Code")]
    //    public int Code { get; set; }

    //    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
    //    [XmlElement("Message")]
    //    public string Message {get;set;}

    //}

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    public partial class CheckResultDataCheckResultDataItemRouteCheck
    {
        [XmlIgnore]
        public EnumResolutionAnswer Code;

        [DataMember(Name = "Code", IsRequired = true)]
        [XmlElement("Code", DataType = "int", Type = typeof(int))]
        public int CodeToInt
        {
            get
            {
                return (int)Code;
            }
            set
            {
                Code = (EnumResolutionAnswer)value;
            }
        }

        [DataMember(Name = "Message", IsRequired = true)]
        [XmlElement("Message", DataType = "string", Type = typeof(string))]
        public string Message { get; set; }

        public override string ToString()
        {
            return CodeToInt.ToString() + ":" + Message;
        }
    }

    public enum EnumResolutionAnswer
    {
        CheckOkRouteTrue = 1,
        CheckOkRouteFalse = 2,
        CheckFalseRouteNotGis = 3,
        CheckFalse = 4,
        CheckOkButRequestNotAgree = 5
    }



    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    public partial class CheckResultDataCheckResultDataItemDimensions {
        
        [DataMember(IsRequired=true)]
        [XmlElement("Length")]
        public decimal Length { get; set;}
        
        [DataMemberAttribute(IsRequired=true)]
        [XmlElement("Width")]
        public decimal Width { get; set;
        }
        
        [DataMember(IsRequired=true)]
        [XmlElement("Height")]
        public decimal Height { get;set; }

        public override string ToString()
        {
            return Length.ToString() + "*" + Width.ToString() + "*" + Height.ToString() + " м.";

        }
    }
    
    [DataContractAttribute(Name="CheckResultDataCheckResultDataItemShippingType", Namespace="http://tempuri.org/")]

    public enum CheckResultDataCheckResultDataItemShippingType : int {
        
        [EnumMember()]
        International = 1,
        
        [EnumMember()]
        Interregional = 2,
        
        [EnumMember()]
        Local = 3,
    }
    
    [DataContract(Name="WriteOfTripDataRequest", Namespace="http://tempuri.org/")]
    [Serializable()]
    [XmlRoot("WriteOfTripDataRequest", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7", IsNullable = false)]
    public partial class WriteOfTripDataRequest {

        [DataMember(EmitDefaultValue = false)]
        [XmlElement("IdTrip", DataType = "string", Type = typeof(string))]
        public string IdTrip { get; set; }

        [DataMember(Name = "RequestID", IsRequired = true)]
        [XmlElement("RequestID", DataType = "string", Type = typeof(string))]
        public string RequestID { get; set; }

        [DataMember(EmitDefaultValue=false)]
        [XmlElement("DocumentNumber", DataType = "string", Type = typeof(string))]
        public string DocumentNumber { get; set;}
        
        [DataMember(IsRequired=true, Order=1)]
        [XmlElement("DocumentDate", DataType = "date", Type = typeof(DateTime))]
        public DateTime DocumentDateSign { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        [XmlElement("CheckPointCode", DataType = "string", Type = typeof(string))]
        public string CheckPointCode { get; set; }
        
        [DataMember(IsRequired=true, Order=3)]
        [XmlElement("Direction", DataType = "int", Type = typeof(int))]
        public int Direction {get; set;}
        
        [DataMember(IsRequired=true, Order=4)]
        [XmlElement("TotalWeight", DataType = "decimal", Type = typeof(decimal))]
        public decimal TotalWeight {get; set;}
        
        [DataMemberAttribute(EmitDefaultValue=false)]
        [XmlElement("AxlesCount")]
        public int[] AxlesCount { get;set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("AxlesLoads")]
        public decimal[] AxlesLoads { get; set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("AxlesInvervals")]
        public decimal[] AxlesInvervals { get; set;}
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("TotalSize")]
        public CheckRequestDataTotalSize TotalSize { get;set;}

        [DataMember(IsRequired = true)]
        [XmlElement("TripDate", DataType = "dateTime", Type = typeof(DateTime))]
        public System.DateTime TripDate { get; set; }      


    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "WriteOffAnswerData ", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    [Serializable]
    //[XmlType(AnonymousType = true, Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7")]
    [XmlRoot("WriteOffAnswerData", Namespace = "http://gucmp.ru/services/smev/pvk/resolutions/1.0.7", IsNullable = false)]
    public partial class WriteOffAnswerData : object {
        
        [DataMember(EmitDefaultValue=false)]
        [XmlElement("DocumentNumber", DataType = "string", Type = typeof(string))]
        public string DocumentNumber { get;set; }
        
        [DataMember(IsRequired=true, Order=1)]
        [XmlElement("DocumentDate", DataType = "date", Type = typeof(DateTime))]
        public System.DateTime DocumentDateSign {get;set;}

        [XmlIgnore]
        [IgnoreDataMember]
        public EnumWriteOffResolution WriteOffResolution { get; set; }

        [DataMember(Name = "WriteOffResolution", IsRequired = true)]
        [XmlElement("WriteOffResolution", DataType = "int", Type = typeof(int))]
        public int WriteOffResolutionToInt
        {
            get
            {
                return (int)WriteOffResolution;
            }
            set
            {
                WriteOffResolution = (EnumWriteOffResolution)value;
            }
        }

    }
    
    [DataContract(Name="EnumWriteOffResolution", Namespace="http://tempuri.org/")]
    public enum EnumWriteOffResolution : int {
        
        [EnumMember()]
        WriteOffSuccessful = 1,
        
        [EnumMember()]
        WriteOffNotSuccessfulTrippOver = 2,
        
        [EnumMember()]
        WriteOffNotSuccessfulDocumentNotFound = 3,
        
        [EnumMember()]
        WriteOffNotSuccessfulWimNotFound = 4,
        
        [EnumMemberAttribute()]
        WriteOffNotSuccessfulUnknownError = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.RASVSR")]
    public interface RASVSR {
        
        // CODEGEN: Контракт генерации сообщений с именем request из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [OperationContract(Action="http://tempuri.org/RASVSR/Check", ReplyAction="*")]
        [XmlSerializerFormat]
        WCPSoapClientForm.ServiceReference1.CheckResponse Check(WCPSoapClientForm.ServiceReference1.CheckRequest request);
        
        [OperationContract(Action="http://tempuri.org/RASVSR/Check", ReplyAction="*")]
        [XmlSerializerFormat]
        System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.CheckResponse> CheckAsync(WCPSoapClientForm.ServiceReference1.CheckRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем WriteOff из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [OperationContract(Action="http://tempuri.org/RASVSR/WriteOfTrip", ReplyAction="*")]
        [XmlSerializerFormat]
        WCPSoapClientForm.ServiceReference1.WriteOfTripResponse WriteOfTrip(WCPSoapClientForm.ServiceReference1.WriteOfTripRequest request);
        
        [OperationContract(Action="http://tempuri.org/RASVSR/WriteOfTrip", ReplyAction="*")]
        [XmlSerializerFormat]
        System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.WriteOfTripResponse> WriteOfTripAsync(WCPSoapClientForm.ServiceReference1.WriteOfTripRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Check", Namespace="http://tempuri.org/", Order=0)]
        public WCPSoapClientForm.ServiceReference1.CheckRequestBody Body;
        
        public CheckRequest() {
        }
        
        public CheckRequest(WCPSoapClientForm.ServiceReference1.CheckRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WCPSoapClientForm.ServiceReference1.CheckRequestData request;
        
        public CheckRequestBody() {
        }
        
        public CheckRequestBody(WCPSoapClientForm.ServiceReference1.CheckRequestData request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCPSoapClientForm.ServiceReference1.CheckResponseBody Body;
        
        public CheckResponse() {
        }
        
        public CheckResponse(WCPSoapClientForm.ServiceReference1.CheckResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WCPSoapClientForm.ServiceReference1.CheckResultDataList CheckResult;
        
        public CheckResponseBody() {
        }
        
        public CheckResponseBody(WCPSoapClientForm.ServiceReference1.CheckResultDataList CheckResult) {
            this.CheckResult = CheckResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WriteOfTripRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WriteOfTrip", Namespace="http://tempuri.org/", Order=0)]
        public WCPSoapClientForm.ServiceReference1.WriteOfTripRequestBody Body;
        
        public WriteOfTripRequest() {
        }
        
        public WriteOfTripRequest(WCPSoapClientForm.ServiceReference1.WriteOfTripRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WriteOfTripRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WCPSoapClientForm.ServiceReference1.WriteOfTripDataRequest WriteOff;
        
        public WriteOfTripRequestBody() {
        }
        
        public WriteOfTripRequestBody(WCPSoapClientForm.ServiceReference1.WriteOfTripDataRequest WriteOff) {
            this.WriteOff = WriteOff;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WriteOfTripResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WriteOfTripResponse", Namespace="http://tempuri.org/", Order=0)]
        public WCPSoapClientForm.ServiceReference1.WriteOfTripResponseBody Body;
        
        public WriteOfTripResponse() {
        }
        
        public WriteOfTripResponse(WCPSoapClientForm.ServiceReference1.WriteOfTripResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WriteOfTripResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WCPSoapClientForm.ServiceReference1.WriteOffAnswerData WriteOfTripResult;
        
        public WriteOfTripResponseBody() {
        }
        
        public WriteOfTripResponseBody(WCPSoapClientForm.ServiceReference1.WriteOffAnswerData WriteOfTripResult) {
            this.WriteOfTripResult = WriteOfTripResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RASVSRChannel : WCPSoapClientForm.ServiceReference1.RASVSR, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RASVSRClient : System.ServiceModel.ClientBase<WCPSoapClientForm.ServiceReference1.RASVSR>, WCPSoapClientForm.ServiceReference1.RASVSR {
        
        public RASVSRClient() {
        }
        
        public RASVSRClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RASVSRClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RASVSRClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RASVSRClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCPSoapClientForm.ServiceReference1.CheckResponse WCPSoapClientForm.ServiceReference1.RASVSR.Check(WCPSoapClientForm.ServiceReference1.CheckRequest request) {
            return base.Channel.Check(request);
        }
        
        public WCPSoapClientForm.ServiceReference1.CheckResultDataList Check(WCPSoapClientForm.ServiceReference1.CheckRequestData request) {
            WCPSoapClientForm.ServiceReference1.CheckRequest inValue = new WCPSoapClientForm.ServiceReference1.CheckRequest();
            inValue.Body = new WCPSoapClientForm.ServiceReference1.CheckRequestBody();
            inValue.Body.request = request;
            WCPSoapClientForm.ServiceReference1.CheckResponse retVal = ((WCPSoapClientForm.ServiceReference1.RASVSR)(this)).Check(inValue);
            return retVal.Body.CheckResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.CheckResponse> WCPSoapClientForm.ServiceReference1.RASVSR.CheckAsync(WCPSoapClientForm.ServiceReference1.CheckRequest request) {
            return base.Channel.CheckAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.CheckResponse> CheckAsync(WCPSoapClientForm.ServiceReference1.CheckRequestData request) {
            WCPSoapClientForm.ServiceReference1.CheckRequest inValue = new WCPSoapClientForm.ServiceReference1.CheckRequest();
            inValue.Body = new WCPSoapClientForm.ServiceReference1.CheckRequestBody();
            inValue.Body.request = request;
            return ((WCPSoapClientForm.ServiceReference1.RASVSR)(this)).CheckAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCPSoapClientForm.ServiceReference1.WriteOfTripResponse WCPSoapClientForm.ServiceReference1.RASVSR.WriteOfTrip(WCPSoapClientForm.ServiceReference1.WriteOfTripRequest request) {
            return base.Channel.WriteOfTrip(request);
        }
        
        public WCPSoapClientForm.ServiceReference1.WriteOffAnswerData WriteOfTrip(WCPSoapClientForm.ServiceReference1.WriteOfTripDataRequest WriteOff) {
            WCPSoapClientForm.ServiceReference1.WriteOfTripRequest inValue = new WCPSoapClientForm.ServiceReference1.WriteOfTripRequest();
            inValue.Body = new WCPSoapClientForm.ServiceReference1.WriteOfTripRequestBody();
            inValue.Body.WriteOff = WriteOff;
            WCPSoapClientForm.ServiceReference1.WriteOfTripResponse retVal = ((WCPSoapClientForm.ServiceReference1.RASVSR)(this)).WriteOfTrip(inValue);
            return retVal.Body.WriteOfTripResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.WriteOfTripResponse> WCPSoapClientForm.ServiceReference1.RASVSR.WriteOfTripAsync(WCPSoapClientForm.ServiceReference1.WriteOfTripRequest request) {
            return base.Channel.WriteOfTripAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCPSoapClientForm.ServiceReference1.WriteOfTripResponse> WriteOfTripAsync(WCPSoapClientForm.ServiceReference1.WriteOfTripDataRequest WriteOff) {
            WCPSoapClientForm.ServiceReference1.WriteOfTripRequest inValue = new WCPSoapClientForm.ServiceReference1.WriteOfTripRequest();
            inValue.Body = new WCPSoapClientForm.ServiceReference1.WriteOfTripRequestBody();
            inValue.Body.WriteOff = WriteOff;
            return ((WCPSoapClientForm.ServiceReference1.RASVSR)(this)).WriteOfTripAsync(inValue);
        }
    }
}
