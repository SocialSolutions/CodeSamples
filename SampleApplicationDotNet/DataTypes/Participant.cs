using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class Participant
    {
        public int ID { get; set; }
        public ActorType Type { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string CaseNumber { get; set; }
        public string FirstName { get; set; }
        public char? MiddleInitial { get; set; }
        public string LastName { get; set; }
        public bool Disabled { get; set; }
        public short? PrefixID { get; set; }
        public short? SuffixID { get; set; }
        public short? EthnicityID { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExtension { get; set; }
        public string Pager { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public short? MaritalStatusID { get; set; }
        public int? FundingEntityID { get; set; }
        public int? ReferralEntityID { get; set; }
        public short AuditStaffID { get; set; }
        public DateTime AuditDate { get; set; }
        public short? AssignedStaffID { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Alert { get; set; }
        public Guid GUID { get; set; }
        public List<CustomDemographic> CustomDemoData { get; set; }
    }

    public enum ActorType
    {
        Participant = 'C',
        Entity = 'E'
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}