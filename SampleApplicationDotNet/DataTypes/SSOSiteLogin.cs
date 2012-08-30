using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; // added

namespace SampleApplicationDotNet.DataTypes
{
    public class SSOSiteLoginResponseObject
    {
        public Guid SecurityToken { get; set; }
    }

}