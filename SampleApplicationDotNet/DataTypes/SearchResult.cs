using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class SearchResult
    {
        public Int32 CLID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? ProgramStartDate { get; set; }
        public Int32 DaysInProgram { get; set; }
        public string SearchType { get; set; }
        public List<string> CustomFields { get; set; }
        public List<string> FamilyNames { get; set; }
        public List<HouseholdMember> HouseholdMembers { get; set; }
    }

    public class HouseholdMember : Participant
    {
        public string Relationship { get; set; }
        public string HouseholdName { get; set; }
        public bool IsHeadOfHousehold { get; set; }
    }
}