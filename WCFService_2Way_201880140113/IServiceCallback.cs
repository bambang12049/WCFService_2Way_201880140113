using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_2Way_201880140113
{
   
    [ServiceContract(CallbackContract = typeof(IClientCallback))]
    public interface IServiceCallback
    {

        [OperationContract(IsOneWay = true)]
        void gabung(string username);

        [OperationContract(IsOneWay = true)]
        void kirimPesan(string pesan);
    }
    [ServiceContract]
    interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void pesanKirim(string user, string pesan);
    }

    
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
