using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sol_Demo.Models
{
    [DataContract]
    public class DemoModel
    {
        [DataMember(EmitDefaultValue = false)]
        public double Cost { get; set; }
    }
}