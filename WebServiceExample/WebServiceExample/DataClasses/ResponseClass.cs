using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WebServiceExample.DataClasses
{
    [DataContract]
    public class ResponseClass
    {
        [DataMember]
        public string response;
    }
}
