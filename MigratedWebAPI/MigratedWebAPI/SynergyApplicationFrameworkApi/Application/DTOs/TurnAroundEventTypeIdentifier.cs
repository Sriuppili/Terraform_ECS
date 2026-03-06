using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public enum TurnAroundEventTypeIdentifier
    {
        [EnumMember]
        Unknown = 0,

        [Description("Inbound")]
        [EnumMember]
        Inbound = 1,

        [Description("Wash")]
        [EnumMember]
        Wash = 2,

        [Description("Tray Prioritisation")]
        [EnumMember]
        TrayPrioritisation = 3,

        [Description("Quality Assurance")]
        [EnumMember]
        QualityAssurance = 5,

        [Description("Into Autoclave")]
        [EnumMember]
        IntoAutoclave = 6,

        [Description("Out of Autoclave")]
        [EnumMember]
        OutofAutoclave = 7,

        [Description("Dispatch")]
        [EnumMember]
        Dispatch = 8,

        [Description("Delivery Note Print")]
        [EnumMember]
        DeliveryNotePrint = 9,

        [Description("Reprint Tray List")]
        [EnumMember]
        ReprintTrayList = 10,

        [Description("Failed Autoclave")]
        [EnumMember]
        FailedAutoclave = 11,

        [Description("Removed From Delivery Note")]
        [EnumMember]
        RemovedFromDeliveryNote = 13,

        [Description("Into Stock")]
        [EnumMember]
        IntoStock = 14,

        [Description("Out Of Stock")]
        [EnumMember]
        OutOfStock = 15,

        [Description("Inbound With Incorrect Specification")]
        [EnumMember]
        InboundWithIncorrectSpecification = 16,

        [Description("Into Quarantine")]
        [EnumMember]
        IntoQuarantine = 17,

        [Description("Pass Warning")]
        [EnumMember]
        PassWarning = 18,

        [Description("Out Of Quarantine")]
        [EnumMember]
        OutOfQuarantine = 19,

        [Description("Archived")]
        [EnumMember]
        Archived = 20,

        [Description("Added to summary")]
        [EnumMember]
        Addedtosummary = 21,

        [Description("Failed Wash")]
        [EnumMember]
        FailedWash = 22,

        [Description("Failed Quality Assurance")]
        [EnumMember]
        FailedQualityAssurance = 23,

        [Description("Override Cooldown")]
        [EnumMember]
        OverrideCooldown = 24,

        [Description("Facility Open")]
        [EnumMember]
        FacilityOpen = 25,

        [Description("Facility Close")]
        [EnumMember]
        FacilityClose = 26,

        [Description("Delivered")]
        [EnumMember]
        Delivered = 27,

        [Description("Available For Collection")]
        [EnumMember]
        AvailableForCollection = 28,

        [Description("Collected")]
        [EnumMember]
        Collected = 29,

        [Description("Manual Proof of Delivery")]
        [EnumMember]
        ManualProofofDelivery = 30,

        [Description("Inspection")]
        [EnumMember]
        Inspection = 31,

        [Description("Into Pigeon Hole/Stock")]
        [EnumMember]
        IntoPigeonHoleStock = 32,

        [Description("Rewash")]
        [EnumMember]
        Rewash = 33,

        [Description("Repair")]
        [EnumMember]
        Repair = 34,

        [Description("To Be Condemned")]
        [EnumMember]
        ToBeCondemned = 35,

        [Description("Send For Reinspection")]
        [EnumMember]
        SendForReinspection = 36,

        [Description("Assisted Inspection")]
        [EnumMember]
        AssistedInspection = 37,

        [Description("Respot")]
        [EnumMember]
        Respot = 38,

        [Description("On Order")]
        [EnumMember]
        OnOrder = 39,

        [Description("Non Steam Sterilisation")]
        [EnumMember]
        NonSteamSterilisation = 40,

        [Description("Load Trolley")]
        [EnumMember]
        LoadTrolleyEPOC = 41,

        [Description("Return From Quarantine")]
        [EnumMember]
        ReturnFromQuarantine = 42,

        [Description("Automatic Delivery")]
        [EnumMember]
        AutomaticDelivery = 43,

        [Description("Transfer")]
        [EnumMember]
        Transfer = 44,

        [Description("Service Requirement Change")]
        [EnumMember]
        ServiceRequirementChange = 45,

        [Description("Reprint Label")]
        [EnumMember]
        ReprintLabel = 46,

        [Description("End Packing")]
        [EnumMember]
        EndPacking = 47,

        [Description("Cancel Packing")]
        [EnumMember]
        PackingCancelled = 48,

        [Description("Quarantine Override")]
        [EnumMember]
        QuarantineOverride = 49,

        [Description("Into Wash")]
        [EnumMember]
        IntoWash = 50,

        [Description("Wet Pack")]
        [EnumMember]
        WetPack = 51,

        [Description("Broken Pack")]
        [EnumMember]
        BrokenPack = 52,

        [Description("Item Exception Updated")]
        [EnumMember]
        ItemExceptionUpdated = 53,

        [Description("Receive Stock")]
        [EnumMember]
        ReceiveStock = 54,

        [Description("Issued to End User")]
        [EnumMember]
        IssuedtoEndUser = 55,

        [Description("Returned from End User")]
        [EnumMember]
        ReturnedfromEndUser = 56,

        [Description("Un Pack")]
        [EnumMember]
        UNPack = 57,

        [Description("Print Decontamination Certificate")]
        [EnumMember]
        PrintDecontaminationCertificate = 58,

        [Description("Customer Defect Raised")]
        [EnumMember]
        CustomerDefectRaised = 59,

        [Description("Customer Defect Responded")]
        [EnumMember]
        CustomerDefectResponded = 60,

        [Description("Customer Defect Closed")]
        [EnumMember]
        CustomerDefectClosed = 61,

        [Description("Customer Defect Reopen")]
        [EnumMember]
        CustomerDefectReopen = 62,

        [Description("Confirmed As Sterile")]
        [EnumMember]
        ConfirmedAsSterile = 63,

        [Description("Acknowledged Note")]
        [EnumMember]
        AcknowledgeNote = 64,

        [Description("Independent Second Check Required")]
        [EnumMember]
        IndependentSecondCheckRequired = 66,

        [Description("Removed From Batch")]
        [EnumMember]
        RemovedFromBatch = 67,

        [Description("Fail Batch Pre-Steam Injection")]
        [EnumMember]
        FailBatchPreSteamInjectionWithReassign = 68,

        [Description("Fail Batch Post-Steam Injection")]
        [EnumMember]
        FailBatchPostSteamInjection = 69,

        [Description("Fail Presteam Batch -  Without Reassign")]
        [EnumMember]
        FailBatchPreSteamInjectionWithoutReassign = 70,

        [Description("Batch Reassigned")]
        [EnumMember]
        ReassignBatch = 71,

        [Description("Wash Process Created")]
        [EnumMember]
        WashProcessCreated = 72,

        [Description("Assign to Wash Process Tag")]
        [EnumMember]
        AssigntoWashProcessTag = 73,

        [Description("Wash - Release Required")]
        [EnumMember]
        WashRequireRelease = 74,

        [Description("Wash Released")]
        [EnumMember]
        WashRelease = 75,

        [Description("Legacy Instance Barcode Replaced")]
        [EnumMember]
        LegacyInstanceBarcodeReplaced = 76,

        [Description("Failed Wash(Release Required)")]
        [EnumMember]
        FailedWashReleaseRequired = 77,

        [Description("Failed Packing")]
        [EnumMember]
        FailedPacking = 78,

        [Description("Reprint Instance Barcode")]
        [EnumMember]
        ReprintInstanceBarcode = 79,

        [Description("Part Wash")]
        [EnumMember]
        PartWash = 80,

        [Description("Reprinted Delivery Note")]
        [EnumMember]
        ReprintedDeliveryNote = 81,

        [Description("Assigned to Batch Tag")]
        [EnumMember]
        AssignToBatchTag = 82,

        [Description("Removed From Batch Tag")]
        [EnumMember]
        RemoveFromBatchTag = 83,

        [Description("Removed from Invoice")]
        [EnumMember]
        RemovedFromInvoice = 84,

        [Description("Load Trolley EPOD")]
        [EnumMember]
        LoadTrolleyEPOD = 85,

        [Description("Batch Tag Created")]
        [EnumMember]
        BatchTagCreated = 86,

        [Description("Removed From Wash Process Tag")]
        [EnumMember]
        RemoveFromWashProcessTag = 87,

        [Description("Automatic Collection")]
        [EnumMember]
        AutomaticCollection = 88,

        [Description("Automatic Inbound")]
        [EnumMember]
        AutomaticInbound = 89,

        [Description("Into Autoclave (Added in error)")]
        [EnumMember]
        IntoAutoclaveAddedInError = 90,

        [Description("Tray Prioritisation End")]
        [EnumMember]
        TrayPrioritisationEnd = 100,

        [Description("Wash Start")]
        [EnumMember]
        WashStart = 101,

        [Description("QA Start")]
        [EnumMember]
        QAStart = 102,

        [Description("Carriage Created")]
        [EnumMember]
        CarriageCreated = 103,

        [Description("Assigned to Carriage")]
        [EnumMember]
        AssignedToCarriage = 104,

        [Description("Removed from Carriage")]
        [EnumMember]
        RemovedFromCarriage = 105,

        [Description("Wash In")]
        [EnumMember]
        WashIn = 106,

        [Description("Packing Started")]
        [EnumMember]
        StartPacking = 107,

        [Description("Packing Finished")]
        [EnumMember]
        FinishPacking = 108,

        [Description("Packing Cancelled")]
        [EnumMember]
        CancelPacking = 109,

        [Description("Packing Failed")]
        [EnumMember]
        FailPacking = 110,

        [Description("Changed Batch")]
        [EnumMember]
        ChangedBatch = 111,

        [Description("Biological Indicator Failed")]
        [EnumMember]
        BiologicalIndicatorFailed = 112,

        [Description("Planned Maintenance Check")]
        [EnumMember]
        PlannedMaintenanceChecked = 113,

        [Description("Planned Maintenance Warning")]
        [EnumMember]
        PlannedMaintenanceWarned = 114,

        [Description("Order Shipped")]
        [EnumMember]
        OrderShipped = 115,

        [Description("Removed From Order")]
        [EnumMember]
        RemovedFromOrder = 116,

        [Description("Added To Order")]
        [EnumMember]
        AddedToOrder = 117,

        [Description("Packing Process Ended")]
        [EnumMember]
        PackingProcessEnded = 118,

        [Description("Review Needed")]
        [EnumMember]
        ReviewNeeded = 119,

        [Description("Reviewed")]
        [EnumMember]
        Reviewed = 120,

        [Description("Review Cancelled")]
        [EnumMember]
        ReviewCancelled = 121,

        [Description("Retrospective out of Autoclave Approval")]
        [EnumMember]
        RetrospectiveOutOfAutoclaveApproval = 122,

        [Description("Turnaround Ended Early")]
        [EnumMember]
        TurnaroundEndedEarly = 123,

        [Description("Facility Changed")]
        [EnumMember]
        ChangedFacility = 124,

        [Description("Decontamination Start")]
        [EnumMember]
        DeconStart = 130,

        [Description("Decontamination End")]
        [EnumMember]
        DeconEnd = 131,

        [Description("Decontamination Cancel")]
        [EnumMember]
        DeconCancel = 132,

        [Description("Out of Pigeon Hole/Stock")]
        [EnumMember]
        OutOfPigeonHoleStock = 140,

        [Description("Automatic Dispatch")]
        [EnumMember]
        AutomaticDispatch = 141,

        #region New Quarantine Event Types
        [Description("Reroute to Wash")]
        [EnumMember]
        RerouteToWash = 150,

        [Description("Reroute to Inspection, Assembly and Packing")]
        [EnumMember]
        RerouteToInspectionAssemblyPacking = 152,

        [Description("Reroute to Quality Assurance")]
        [EnumMember]
        RerouteToQualityAssurance = 153,

        [Description("Reroute to Into Autoclave")]
        [EnumMember]
        RerouteToIntoAutoclave = 154,

        [Description("Reroute to Dispatch")]
        [EnumMember]
        RerouteToDispatch = 155,

        [Description("Packing Resumed")]
        [EnumMember]
        PackingResumed = 156,

        [Description("Packing Paused")]
        [EnumMember]
        PackingPaused = 157,
        #endregion

        [Description("Added to Transfer Note")]
        [EnumMember]
        AddedToTransferNote = 200,

        [Description("Removed from Transfer Note")]
        [EnumMember]
        RemovedFromTransferNote = 201,

        [Description("Facility Transfer - Outbound")]
        [EnumMember]
        FacilityTransferOutbound = 202,

        [Description("Facility Transfer - Inbound")]
        [EnumMember]
        FacilityTransferInbound = 203,

        [Description("Retrospective added to batch tag")]
        [EnumMember]
        RetrospectiveAddedToBatchTag = 210,

        [Description("Retrospective added to wash batch")]
        [EnumMember]
        RetrospectiveAddedToWashBatch = 211,

        [Description("Added to Surgical Procedure")]
        [EnumMember]
        AddToSurgicalProcedure = 212,

        [Description("Removed from Surgical Procedure")]
        [EnumMember]
        RemovedFromSurgicalProcedure = 213,

        [Description("Automatic Start")]
        [EnumMember]
        AutomaticStart = 214,

        [Description("Weighed (Using Pre-Wash Tolerances)")]
        [EnumMember]
        WeighedUsingPreWashTolerances = 215,

        [Description("Weighed (Using Post-Wash Tolerances)")]
        [EnumMember]
        WeighedUsingPostWashTolerances = 216,

        [Description("Specification Updated")]
        [EnumMember]
        SpecificationChanged = 217,

        [Description("Biological Indicator Incubation Failure")]
        [EnumMember]
        BiologicalIndicatorIncubationFailure = 220,

        [Description("Audit Started")]
        [EnumMember]
        AuditStarted = 230,

        [Description("Audit Finished")]
        [EnumMember]
        AuditFinished = 231,

        [Description("Audit Failed")]
        [EnumMember]
        AuditFailed = 232,

        [Description("Audit Cancelled")]
        [EnumMember]
        AuditCancelled = 233,

        [Description("Reprint")]
        [EnumMember]
        Reprint = 263,

        [Description("Fail Wash In")]
        [EnumMember]
        FailWashIn = 264,

        [Description("Restart Wash")]
        [EnumMember]
        RestartWash = 265,

        [EnumMember]
        FailedWashPrintReport = 266,

        #region Mobile Offline Events

        [Description("Offline - Collected")]
        [EnumMember]
        OfflineCollected = 261,

        [Description("Offline - Delivered")]
        [EnumMember]
        OfflineDelivered = 262,

        [Description("Offline - Into Pigeon Hole/Stock")]
        [EnumMember]
        OfflineIntoPigeonHoleStock = 267,

        [Description("Offline - Out of Pigeon Hole/Stock")]
        [EnumMember]
        OfflineOutOfPigeonHoleStock = 268,

        [Description("Offline - Available For Collection")]
        [EnumMember]
        OfflineAvailableForCollection = 269,

        [Description("Offline - Load Trolley")]
        [EnumMember]
        OfflineLoadTrolley = 270,

        [Description("Offline - Load Trolley EPOD")]
        [EnumMember]
        OfflineLoadTrolleyEPOD = 271,

        #endregion

        #region Endoscopy

        [Description("Into Drying Cabinet")]
        [EnumMember]
        IntoDryingCabinet = 250,

        [Description("Dispatch - Immediate Use")]
        [EnumMember]
        DispatchImmediateUse = 253,

        [Description("Removed from Drying Cabinet - Wet")]
        [EnumMember]
        RemovedFromDryingCabinetWet = 255,

        [Description("Removed from Drying Cabinet - Dry")]
        [EnumMember]
        RemovedFromDryingCabinetDry = 256,

        [Description("Removed from Drying Cabinet - Expired")]
        [EnumMember]
        RemovedFromDryingCabinetExpired = 257,

        [Description("Vacuum Packed")]
        [EnumMember]
        VacuumPacked = 260,
        [Description("Billing Point")]
        [EnumMember]
        BillingPoint = 500,

        [Description("Print Label")]
        [EnumMember]
        PrintLabel = 560,

        [Description("Pre-AER decon task success")]
        [EnumMember]
        PreAerDeconTaskSuccess = 561,

        [Description("Pre-AER decon task failure")]
        [EnumMember]
        PreAerDeconTaskFailure = 562,

        [Description("Assigned to AER")]
        [EnumMember]
        AssignedToAer = 563,

        [Description("Removed from AER")]
        [EnumMember]
        RemovedFromAer = 564,

        [Description("AER start")]
        [EnumMember]
        AerStart = 565,

        [Description("AER passed")]
        [EnumMember]
        AerPassed = 566,

        [Description("AER failed")]
        [EnumMember]
        AerFailed = 567,

        [Description("Vacuum Packed - Wet")]
        [EnumMember]
        VacuumPackedWet = 568,

        [Description("Vacuum Packed - Dry")]
        [EnumMember]
        VacuumPackedDry = 569,

        [Description("Removed from Drying Cabinet - Automatic")]
        [EnumMember]
        RemovedFromDryingCabinetAutomatic = 570,

        [Description("Endoscopy Dispatch")]
        [EnumMember]
        EndoscopyDispatch = 595,

        #endregion

        #region Non Steam Autoclaves

        [Description("Fail Batch Pre-Non-Steam Injection")]
        [EnumMember]
        FailBatchPreNonSteamInjectionWithReassign = 571,

        [Description("Fail Batch Post-Non-Steam Injection")]
        [EnumMember]
        FailBatchPostNonSteamInjection = 572,

        [Description("Fail PreNonSteam Batch - Without Reassign")]
        [EnumMember]
        FailBatchPreNonSteamInjectionWithoutReassign = 573,

        #endregion

        #region TrolleyDispatch
        [Description("Trolley Started")]
        [EnumMember]
        TrolleyStarted = 574,

        [Description("Trolley Stopped")]
        [EnumMember]
        TrolleyStopped = 575,

        [Description("Added To Trolley")]
        [EnumMember]
        AddedToTrolley = 576,

        [Description("Removed From Trolley")]
        [EnumMember]
        RemovedFromTrolley = 577,

        [Description("Trolley Dispatched")]
        [EnumMember]
        TrolleyDispatched = 578,

        [Description("Turnaround can now be added to any customer trolley")]
        [EnumMember]
        TrolleyCustomerRestrictionDisabled = 579,

        [Description("Turnaround can no longer be added to any customer trolley")]
        [EnumMember]
        TrolleyCustomerRestrictionEnabled = 580,

        #endregion

        [Description("PM skipped: Customer settings")]
        [EnumMember]
        PmSkippedCustomerSettings = 590,

        [Description("PM skipped: Maintenance Report Type settings")]
        [EnumMember]
        PmSkippedMaintenanceReportTypeSettings = 591,

        [Description("PM skipped: Container minimum capacity")]
        [EnumMember]
        PmSkippedContainerMinimumCapacity = 592,

        [Description("PM skipped: Container maximum capacity")]
        [EnumMember]
        PmSkippedContainerMaximumCapacity = 593,

        [Description("Unassigned from batch tag")]
        [EnumMember]
        UnassignedFromBatchTag = 594,

        [Description("Supervisor Approval")]
        [EnumMember]
        SupervisorApproval = 596,

        [Description("Autoclave Cooldown Override")]
        [EnumMember]
        AutoclaveCooldownOverride = 597,

        [Description("Received For Another Loan Kit")]
        [EnumMember]
        ReceivedForAnotherLoanKit = 598,

        #region Transit
        [Description("In Transit")]
        [EnumMember]
        InTransit = 700,

        [Description("Transit Cancelled")]
        [EnumMember]
        CancelTransit = 701,

        [Description("Offline - In Transit")]
        [EnumMember]
        OfflineTransit = 702,

        [Description("Offline - Transit Cancelled")]
        [EnumMember]
        OfflineTransitCancelled = 703,

        #endregion

    }
}
