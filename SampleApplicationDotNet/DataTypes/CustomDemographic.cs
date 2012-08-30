using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleApplicationDotNet.DataTypes
{
    public class CustomDemographic
    {
        public int ByteSize { get; set; }
        public string IncludeInFamilyCopy { get; set; }
        public bool UIEnabled { get; set; }
        public Int16? EntityTypeID { get; set; }
        public Int16? EntitySubTypeID { get; set; }

        public string CustomSettings { get; set; }
        string Name { get; set; }
        CharacteristicTypes CharacteristicType { get; set; }
        object value { get; set; }
        bool Required { get; set; }
        int Sequence { get; set; }
        int CDID { get; set; }
        bool IsDirty { get; set; }
        string ShortDescription { get; set; }
        int? ProgramID { get; set; }
        int? SiteID { get; set; }
    }

    public enum CharacteristicTypes
    {
        StandardDemographic = 0,
        Boolean = 1,
        Numeric = 2,
        ArbitraryText = 3,
        DefinedTextValues = 4,
        NonExclusiveChoices = 5,
        Date = 6,
        ArbitraryTextArea = 7,
        EntityCrossReference = 8,
        ParticipantCrossReference = 9,
        Header = 10,
        FileAttachment = 11,
        PlaceHolder = 12,
        PhoneNumber = 13,
        Email = 14,
        ZipCode = 15,
        AssignedStaff = 16
    }
}