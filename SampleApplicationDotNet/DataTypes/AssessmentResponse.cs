using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class AssessmentResponse
    {
        public int? SurveyResponseID { get; set; }
        public int? SurveyID { get; set; }
        public string SurveyName { get; set; }
        public DateTime? SurveyDate { get; set; }
        public SurveyResponderType SurveyResponderType { get; set; }
        public int CL_EN_GEN_ID { get; set; }
        public string Password { get; set; }
        public int AuditStaffID { get; set; }
        public bool? Confidential { get; set; }
        public DateTime? AuditDate { get; set; }
        public DateTime ResponseCreationDate { get; set; }
        public string Identifier { get; set; }
        public string ClCaseID { get; set; }
        public int? ProgramID { get; set; }
        public DateTime? DraftSavedOn { get; set; }
        public string Disabled { get; set; }
        public int? SurveyVersion { get; set; }
        public string SurveyTaker { get; set; }
        public int? SecuredProgramID { get; set; }
    }

    public enum SurveyResponderType
    {
        Client = 0,
        Public = 1,
        Family = 2,
        General = 3,
        Staff = 4,
        Entity = 5
    }
}