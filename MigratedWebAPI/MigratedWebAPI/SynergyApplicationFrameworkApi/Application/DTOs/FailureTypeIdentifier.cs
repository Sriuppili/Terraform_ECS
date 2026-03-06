using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    public enum FailureTypeIdentifier
    {
        [EnumMember]
        [Description("Missing Item")]
        MissingItem = 1,

        [EnumMember]
        [Description("Damaged Wraps")]
        DamagedWraps = 2,

        [EnumMember]
        [Description("Incorrect Assembly")]
        IncorrectAssembly = 3,

        [EnumMember]
        [Description("Late Supply")]
        LateSupply = 4,

        [EnumMember]
        [Description("Extra Item on Tray")]
        ExtraItemonTray = 5,

        [EnumMember]
        [Description("Dirty Item")]
        DirtyItem = 6,

        [EnumMember]
        [Description("Incorrect Packing Specification")]
        IncorrectPackingSpecification = 7,

        [EnumMember]
        [Description("Other")]
        Other = 8,

        [EnumMember]
        [Description("Wrong Item on Tray")]
        WrongItemonTray = 9,

        [EnumMember]
        [Description("Wet Pack/Tray")]
        WetPackOrTray = 10,

        [EnumMember]
        [Description("Incorrect Labelling")]
        IncorrectLabelling = 11,

        [EnumMember]
        [Description("Damaged Item")]
        DamagedItem = 12,

        [EnumMember]
        [Description("Worn Item")]
        WornItem = 13,

        [EnumMember]
        [Description("Poststeam Failure")]
        PoststeamFailure = 14,

        [EnumMember]
        [Description("Presteam Failure")]
        PresteamFailure = 15,

        [EnumMember]
        [Description("Item requires repair")]
        Itemrequiresrepair = 16,

        [EnumMember]
        [Description("Alternative Item")]
        AlternativeItem = 17,

        [EnumMember]
        [Description("Item Returned From Repair")]
        ItemReturnedFromRepair = 18,

        [EnumMember]
        [Description("Item Sent To Repair")]
        ItemSentToRepair = 19,

        [EnumMember]
        [Description("Gross Debris")]
        GrossDebris = 20,

        [EnumMember]
        [Description("Repatriation")]
        Repatriation = 21,

        [EnumMember]
        [Description("CCN Change To Tray")]
        CCNChangeToTray = 22,

        [EnumMember]
        [Description("Technician Error")]
        TechnicianError = 23,

        [EnumMember]
        [Description("No Issues With Tray")]
        NoIssuesWithTray = 24,

        [EnumMember]
        [Description("Unknown (different technician)")]
        UnknownDifferentTechnician = 25,

        [EnumMember]
        [Description("AER Disinfection Failure")]
        AerDisinfectionFailure = 50,

        [EnumMember]
        [Description("AER Test Failure")]
        AerTestFailure = 51,

        [EnumMember]
        [Description("AER Error")]
        AerError = 52,

        [EnumMember]
        [Description("Blockage In Scope")]
        BlockageInScope = 53,

        [EnumMember]
        [Description("Leak Test")]
        LeakTest = 54,

        [EnumMember]
        [Description("Out Of Detergent")]
        OutOfDetergent = 55,

        [EnumMember]
        [Description("Scope Connection Error")]
        ScopeConnectionError = 56,

        [EnumMember]
        [Description("Missing Button")]
        MissingButton = 57,

        [EnumMember]
        [Description("Damaged Button")]
        DamagedButton = 58,

        [EnumMember]
        [Description("Damaged Scope")]
        DamagedScope = 59,

        [EnumMember]
        [Description("Leak Test Failed")]
        LeakTestFailed = 60,

        [EnumMember]
        [Description("Unable To Clean")]
        UnableToClean = 61,

        [EnumMember]
        [Description("Clean Failed")]
        CleanFailed = 62,

        [EnumMember]
        [Description("Post Non Steam Failure")]
        PostNonSteamFailure = 63,

        [EnumMember]
        [Description("Pre Non Steam Failure")]
        PreNonSteamFailure = 64
    }
}
