using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; // added

namespace SampleApplicationDotNet.DataTypes
{
    public class SSOAuthenticateResults
    {
        public Guid AccessKey { get; set; }
        public int AuthStatusCode { get; set; }
        public string Email { get; set; }
        public int MarketplaceId { get; set; }
        public string Password { get; set; }
        public Guid SSOAuthToken { get; set; }
        public int? TimeZoneOffset { get; set; }
    }
    public class SSOAuthenticateResponseObject
    {
        public SSOAuthenticateResults SSOAuthenticateResult { get; set; }
    }

}