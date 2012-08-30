using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class SiteInfo
    {
        public int SiteID { get; set; }
        public Guid SiteGUID { get; set; }
        public string SiteName { get; set; }
        public int PrimarySiteManagerID { get; set; }
        public bool Disabled { get; set; }
        public bool ShowSiteReferral { get; set; }
        public int AuditStaffID { get; set; }
        public DateTime AuditDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string GuestAccessPassword { get; set; }
        public short? GuestAccessProgramID { get; set; }
        public string TimeZone { get; set; }
        public bool CheckEnterpriseDuplicates { get; set; }
        public short? LowestRoleToAutoSwitchSites { get; set; }
        public int LowestRoleToEditEntities { get; set; }
        public string ParticipantLabel { get; set; }
        public bool ShowFamilyMembers { get; set; }
        public short? StorageQuotaInMb { get; set; }
        public string StoragePath { get; set; }
        public int? TimeSpendOnContact { get; set; }
        public byte[] SiteLogo { get; set; }
        public string SiteLogoContentType { get; set; }
        public bool? DemoLayout { get; set; }
        public bool SiteSwitchingProgramGroupMember { get; set; }
        public bool SiteSwitchingSiteHierachy { get; set; }
        public int? IdleTimeout_ThresholdInMinutes { get; set; }
        public short? EnterpriseEntitySearch { get; set; }
        public int? EnterpriseEntityRoleID { get; set; }
        public bool AutoGenerateHouseholdName { get; set; }
        public int? SecurityTokenRecycleIntervalInMinutes { get; set; }
        public int? SecurityTokenPreviousTokenExpirationInSeconds { get; set; }
        public bool PasswordExpires { get; set; }
        public int PasswordExpiresDays { get; set; }
        public int PasswordLengthMin { get; set; }
        public int PasswordLengthMax { get; set; }
        public int PasswordNumeric { get; set; }
        public int PasswordNonAlphaNumeric { get; set; }
        public bool PasswordCaseSensitive { get; set; }
        public int PasswordResetAttempts { get; set; }
        public bool SSNMask { get; set; }
        public bool CollapseAssessResponses { get; set; }
        public bool HouseholdContacts { get; set; }
    }
}