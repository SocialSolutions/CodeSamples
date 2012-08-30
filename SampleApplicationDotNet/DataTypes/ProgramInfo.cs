using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class ProgramInfo
    {
        public short ID { get; set; }
        public string Name { get; set; }
        public bool Confidential { get; set; }
        public bool Disabled { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public bool AutoDismiss { get; set; }
        public int? AutoDismissAfterDays { get; set; }
        public int? AutoDismissReasonID { get; set; }
        public short AuditStaffID;
        public DateTime AuditDate;
        public bool AcceptsReferrals { get; set; }
        public string PhoneNumber { get; set; }
        public string AutoDismissAfterTime { get; set; }
        public short? AutoDismissAfterHours { get; set; }
        public bool AcceptEnterprise { get; set; }
        public bool AcceptSite { get; set; }
        public string Description { get; set; }
        public bool Administrative { get; set; }
        public bool AutoAccept { get; set; }
        public Guid GUID { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public bool Billable { get; set; }
        public bool KioskMode { get; set; }
        public string RedirectURLorFile { get; set; }
        public string WorkFlowType { get; set; }
        public bool ReturnToKioskStartPage { get; set; }
        public short? ProgramTypeID { get; set; }
        public bool ConfirmReferralByEmail { get; set; }
        public bool ShowDisabledAssessments { get; set; }
        public bool IncludeAllInHousingCheckIn { get; set; }
    }
}