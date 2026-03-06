# Code Cleanup & Refactoring Report
## WCF to .NET 8 Web API Migration

**Generated:** absolute_migrator.py
**Migration Date:** 2026-03-05 12:28:52

---

## Summary Statistics

| Category | Count |
|----------|-------|
| **Total Files Cleaned** | 3455 |
| **WCF Attributes Removed** | 6698 |
| **Commented Code Lines Removed** | 6955 |
| **Obsolete Using Statements Removed** | 15600 |

---

## Code Cleanup Categories

### 1. WCF Artifacts Removed
- `[ServiceContract]` attributes
- `[OperationContract]` attributes
- `[DataContract]` attributes
- `[DataMember]` attributes
- `[FaultContract]` attributes
- `[ServiceBehavior]` attributes
- `using System.ServiceModel.*` statements
- `using System.Runtime.Serialization.*` statements

### 2. Dead Code Removed
- Single-line commented code (`//` comments)
- Multi-line commented blocks (`/* */` comments)
- Obsolete code patterns

### 3. Namespace Modernization
- Transformed `Pathway.*` to `SynergyApplicationFrameworkApi.*`
- Removed unused project-specific using statements
- Deduplicated using statements

---

## Detailed File Cleanup

| File | Type | Items Cleaned |
|------|------|---------------|
| AbandonReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| AbandonReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AbandonReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AbandonReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AbandonReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| AccessDeniedModel.cs | DTO | 3 unused using statements |
| AddNoteDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AddToBatchTagDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AddToWashBatchDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| Address.cs | DTO | 7 commented code lines, 3 unused using statements |
| Address.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AddressContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AddressData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AdministrationEventHandler.cs | Service | 32 unused using statements |
| AerCycleRequest.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AerDataContract.cs | DTO | 13 WCF attributes, 1 WCF using statements, 7 unused using statements |
| AerDetergentDetails.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AerHelper.cs | Helper | 30 commented code lines, 14 unused using statements |
| AerShelfLocationDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| AerStatus.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Alert.cs | DTO | 7 commented code lines, 2 unused using statements |
| Alert.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AlertContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AlertData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AlertType.cs | DTO | 7 commented code lines, 2 unused using statements |
| AlertType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AlertTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AlertTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AliasTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| AllDefectData.cs | DTO | 12 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ApiBaseController.cs | Service | 6 commented code lines, 14 unused using statements |
| ApiControllerExtensions.cs | Helper | 1 commented code lines, 12 unused using statements |
| ApiDescriptionExtensions.cs | Helper | 8 unused using statements |
| ApiTypeApiModel.cs | DTO | 5 unused using statements |
| AppType.cs | DTO | 7 commented code lines, 2 unused using statements |
| AppType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AppTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AppTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ApplicationType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ApplyEvent.cs | Service | 54 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| ApplyEventDetails.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ApplyTurnaroundEventDetails.cs | DTO | 4 unused using statements |
| ArrivalStatus.cs | Enum | 6 commented code lines, 4 unused using statements |
| ArrivalsModel.cs | DTO | 3 unused using statements |
| AssemblyInfo.cs | DTO | 15 commented code lines, 6 unused using statements |
| AssemblyInfo.cs | DTO | 15 commented code lines, 5 unused using statements |
| AssemblyInfo.cs | Service | 15 commented code lines, 8 unused using statements |
| AssetDetailsDataContract.cs | DTO | 52 WCF attributes, 1 WCF using statements, 7 unused using statements |
| AssetInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AssetSpecificationInfo.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AssetUsageRequest.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AssetUsageResponse.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AssignEndoscopeToAerRequestDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AssociatedObjectType.cs | Enum | 3 unused using statements |
| AssociatedStation.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AuditDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AuditExceptionReasonDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AuditLineDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AuditLineExceptionReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| AuditLineExceptionReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditLineExceptionReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditLineExceptionReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditLineExceptionReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| AuditLineStatusType.cs | DTO | 7 commented code lines, 2 unused using statements |
| AuditLineStatusType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditLineStatusTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditLineStatusTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditLineStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| AuditProcessFaultContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AuditProcessFaultReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| AuditProcessFaultReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditProcessFaultReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditProcessFaultReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditProcessFaultReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| AuditResultType.cs | DTO | 7 commented code lines, 2 unused using statements |
| AuditResultType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditResultTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditResultTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditResultTypeIdentifier.cs | DTO | 2 WCF attributes, 3 unused using statements |
| AuditRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| AuditRule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditRuleContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AuditRuleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditType.cs | DTO | 7 commented code lines, 2 unused using statements |
| AuditType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| AuditTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| AuditTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Auditing.cs | Service | 15 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 16 unused using statements |
| AuthenticationFailureResult.cs | Service | 1 interface inheritances removed, 9 unused using statements |
| AuthenticationResultHelper.cs | Helper | 6 unused using statements |
| AutoLoginModel.cs | DTO | 4 unused using statements |
| Autoclave.cs | Service | 7 commented code lines, 7 unused using statements |
| AutoclaveInStationData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AutoclaveOutStationData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| AutomaticEventDetailsDataContract.cs | DTO | 14 WCF attributes, 1 WCF using statements, 2 unused using statements |
| AutomaticQuarantinedItem.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| AvailableForCollectionModel.cs | DTO | 3 unused using statements |
| BadRequestOnModelInvalidAttribute.cs | DTO | 2 commented code lines, 7 unused using statements |
| BadgeInfo.cs | DTO | 3 unused using statements |
| Barcode.cs | DTO | 3 unused using statements |
| BarcodeSearchArgs.cs | DTO | 5 unused using statements |
| BaseHelper.cs | Helper | 6 unused using statements |
| BaseModel.cs | DTO | 3 unused using statements |
| BaseReplyDataContract.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| BaseRequestDataContract.cs | DTO | 12 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| BaseTypeIdentifier.cs | DTO | 1 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BasicChallengeResult.cs | Service | 1 interface inheritances removed, 9 unused using statements |
| BasicContainerInstanceDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BasicCustomerData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicDeliveryPointData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicDeliveryPointData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicFacilityData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicFaultContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BasicInvoiceScheduleData.cs | DTO | 6 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicInvoiceStatusData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 2 unused using statements |
| BasicTurnaroundData.cs | DTO | 20 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BasicTurnaroundDataContract.cs | DTO | 15 WCF attributes, 1 WCF using statements, 4 unused using statements |
| BasicTurnaroundEvents.cs | Service | 20 commented code lines, 8 unused using statements |
| Batch.cs | DTO | 7 commented code lines, 3 unused using statements |
| Batch.cs | DTO | 6 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchArchiveReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| BatchArchiveReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchArchiveReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchArchiveReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchArchivedReasonIdentifier.cs | DTO | 1 WCF attributes, 4 unused using statements |
| BatchByIdRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchByIdResponseDataContract.cs | DTO | 15 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchByTurnaroundRequestDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchByTurnaroundResponseDataContract.cs | DTO | 33 WCF attributes, 1 WCF using statements, 6 unused using statements |
| BatchContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchCreatedDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchCycle.cs | DTO | 7 commented code lines, 2 unused using statements |
| BatchCycle.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchCycleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchCycleData.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| BatchCycleDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BatchCycleExtendedError.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BatchCycleTypeIdentifier.cs | DTO | 1 WCF attributes, 4 unused using statements |
| BatchCyclesDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchCyclesRequestDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchData.cs | DTO | 25 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| BatchDecontaminationTask.cs | DTO | 7 commented code lines, 3 unused using statements |
| BatchDecontaminationTask.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchDecontaminationTaskContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchDecontaminationTaskData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchDetailsRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchDetailsResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BatchFailureReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| BatchFailureReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchFailureReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchFailureReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchFailureReasonIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| BatchHelper.cs | Helper | 4 commented code lines, 8 unused using statements |
| BatchHelpers.cs | Helper | 8 commented code lines, 10 unused using statements |
| BatchName.cs | Helper | 2 commented code lines, 5 unused using statements |
| BatchRepository.cs | Repository | 11 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| BatchResultData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| BatchScanDetails.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BatchStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| BatchStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchStatusIdentifier.cs | Enum | 3 unused using statements |
| BatchSterilisationTestReport.cs | DTO | 7 commented code lines, 3 unused using statements |
| BatchSterilisationTestReport.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BatchSterilisationTestReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BatchSterilisationTestReportData.cs | DTO | 7 WCF attributes, 1 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| BatchSterilisationTestReportRepository.cs | Repository | 6 unused using statements |
| BatchTag.cs | Service | 12 commented code lines, 6 unused using statements |
| BatchTurnaroundDataContract.cs | DTO | 20 WCF attributes, 1 commented code lines, 1 WCF using statements, 3 unused using statements |
| BatchWithTurnaroundData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| BatchWithTurnaroundDetails.cs | DTO | 1 interface inheritances removed, 5 unused using statements |
| BeepType.cs | Enum | 3 unused using statements |
| BiRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| BinaryDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 5 unused using statements |
| BiologicalIndicatorTestContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BiologicalIndicatorTestData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| BiologicalIndicatorTestDataContract.cs | DTO | 25 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BiologicalIndicatorTestRepository.cs | Repository | 6 unused using statements |
| BiologicalIndicatorTestRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BiologicalIndicatorTestResponseDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| BiologicalIndicatorTestStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| BiologicalIndicatorTestStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| BiologicalIndicatorTestStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BiologicalIndicatorTestStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| BiologicalIndicatorTestStatusIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| BlobResultsDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BlobTransferLogEntry.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| BootstrapExtensions.cs | Helper | 7 unused using statements |
| BulkOperationResponseContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CacheHelper.cs | Helper | 9 unused using statements |
| CacheKey.cs | Service | 6 unused using statements |
| CameraDeviceDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Carriage.cs | Service | 6 commented code lines, 7 unused using statements |
| CarriageBatchData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CarriageData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CatalogueEditor.cs | DTO | 7 commented code lines, 3 unused using statements |
| CatalogueEditor.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CatalogueEditorContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CatalogueEditorData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CatalogueLoanSetEmailModel.cs | DTO | 4 unused using statements |
| CatalogueLoanSetValidationResult.cs | DTO | 4 unused using statements |
| CatalogueLoansetCase.cs | DTO | 14 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueLoansetPhysician.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueLoansetProcedure.cs | DTO | 7 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueLoansetProduct.cs | DTO | 9 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueLoansetRequest.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueLoansetVendorRep.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CatalogueProductBatchCycleInfo.cs | DTO | 4 unused using statements |
| CatalogueProductDeconTaskInfo.cs | DTO | 4 unused using statements |
| CatalogueProductInfo.cs | DTO | 3 unused using statements |
| CatalogueProductRequest.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CatalogueVendorInfo.cs | DTO | 3 unused using statements |
| CatalogueVendorRequest.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Category.cs | DTO | 7 commented code lines, 2 unused using statements |
| Category.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CategoryDataAdapter.cs | Service | 7 unused using statements |
| CategoryIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CategoryRepository.cs | Repository | 6 unused using statements |
| Ccn.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CcnData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChangeControlDetailsModel.cs | DTO | 4 unused using statements |
| ChangeControlNote.cs | DTO | 7 commented code lines, 3 unused using statements |
| ChangeControlNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ChangeControlNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChangeControlNoteData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ChangeCycleNumberRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ChangeDetergentResultIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ChangePasswordDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ChangePasswordModel.cs | DTO | 4 unused using statements |
| ChangePasswordResult.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ChangeRequestCommentEmailModel.cs | DTO | 3 unused using statements |
| ChangeRequestEmailModel.cs | DTO | 3 unused using statements |
| ChangeRequestModel.cs | DTO | 1 commented code lines, 3 unused using statements |
| ChangeRequestSummary.cs | DTO | 3 unused using statements |
| Charge.cs | DTO | 7 commented code lines, 3 unused using statements |
| Charge.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ChargeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeList.cs | DTO | 7 commented code lines, 2 unused using statements |
| ChargeList.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ChargeListCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| ChargeListCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ChargeListCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeListCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeListCategoryIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ChargeListContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeListData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeListSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeListSummaryData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ChargeReoccurring.cs | DTO | 7 commented code lines, 3 unused using statements |
| ChargeReoccurring.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ChargeReoccurringContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ChargeReoccurringData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Charges.cs | Helper | 10 unused using statements |
| ChildTurnaroundDataContract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ClientSettings.cs | DTO | 7 commented code lines, 3 unused using statements |
| ClientSettings.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ClientSettingsContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClientSettingsData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClientSettingsDataContract.cs | DTO | 17 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ClientSettingsKeyDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ClientSettingsSaveRequestDataContract.cs | DTO | 15 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ClockingConfigurationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ClockingConfigurationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ClockingConfigurationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClockingConfigurationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClockingConfigurationTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ClockingEventReplyDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ClockingEventRequestDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ClockingEventRequestDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ClockingEventType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ClockingEventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ClockingEventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClockingEventTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ClockingEventTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ClockingOverviewData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ClockingStatus.cs | Enum | 3 unused using statements |
| CollectedModel.cs | DTO | 1 commented code lines, 4 unused using statements |
| CollectionModelDescription.cs | DTO | 3 unused using statements |
| ColumnRowModel.cs | DTO | 3 unused using statements |
| CombinedBarcodeInstanceLabel.cs | Service | 6 commented code lines, 8 unused using statements |
| Comment.cs | DTO | 7 WCF attributes, 1 WCF using statements, 2 unused using statements |
| Comment.cs | DTO | 7 commented code lines, 2 unused using statements |
| Comment.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CommentContext.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CommentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CommentData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CommentViewModel.cs | DTO | 3 unused using statements |
| CommunicationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| CommunicationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CommunicationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CommunicationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CommunicationTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CompletedPartWashReplyDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ComplexTypeModelDescription.cs | DTO | 4 unused using statements |
| Complexity.cs | DTO | 7 commented code lines, 2 unused using statements |
| Complexity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ComplexityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ComplexityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ComplexityTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ComponentData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ComponentDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ComponentDetailData.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ComponentInfo.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ComponentItem.cs | DTO | 28 WCF attributes, 1 WCF using statements, 2 unused using statements |
| ComponentItem.cs | DTO | 25 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ComponentItemException.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ComponentItemHelper.cs | Helper | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 7 unused using statements |
| ComponentListData.cs | DTO | 16 WCF attributes, 1 WCF using statements, 2 unused using statements |
| ComponentNoteData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| ConfigurableListBasicValidationResult.cs | DTO | 3 unused using statements |
| ConfigurableListCustomValue.cs | DTO | 3 unused using statements |
| ConfigurableListDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ConfigurableListHelper.cs | Helper | 19 commented code lines, 11 unused using statements |
| ConfigurableListType.cs | DTO | 7 commented code lines, 3 unused using statements |
| ConfigurableListType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListTypeIdentifier.cs | Enum | 3 unused using statements |
| ConfigurableListValidationResult.cs | DTO | 3 unused using statements |
| ConfigurableListValue.cs | DTO | 7 commented code lines, 3 unused using statements |
| ConfigurableListValue.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListValueContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListValueData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ConfigurableListValueDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 2 unused using statements |
| ConfigurableStaticDataValue.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ConfigurationViewModel.cs | DTO | 3 unused using statements |
| ConfirmDeliveryModel.cs | DTO | 3 unused using statements |
| ConfirmVerifyProcessingParametersContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ConstantResources.cs | Enum | 3 unused using statements |
| Constants.cs | Enum | 3 unused using statements |
| Constants.cs | Enum | 1 commented code lines, 2 unused using statements |
| Contact.cs | DTO | 7 commented code lines, 3 unused using statements |
| Contact.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContactContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContactData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerAndContentsReplyDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ContainerContent.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerContent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerContentActionType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ContainerContentContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerContentData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerContentDataAdapter.cs | Service | 23 commented code lines, 9 unused using statements |
| ContainerContentNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerContentNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerContentNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerContentNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerContentRepository.cs | Repository | 5 unused using statements |
| ContainerContentsDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ContainerCooldownHelper.cs | Helper | 3 commented code lines, 8 unused using statements |
| ContainerDetailsDataContract.cs | DTO | 17 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ContainerInstance.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerInstance.cs | DTO | 2 WCF attributes, 4 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| ContainerInstance.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceAction.cs | Enum | 3 unused using statements |
| ContainerInstanceAsset.cs | DTO | 3 unused using statements |
| ContainerInstanceAutomaticEventService.cs | Service | 1 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 7 unused using statements |
| ContainerInstanceContract.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerInstanceData.cs | DTO | 34 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerInstanceDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceDetailsModel.cs | DTO | 3 unused using statements |
| ContainerInstanceHelpers.cs | Helper | 3 commented code lines, 16 unused using statements |
| ContainerInstanceIdTypeInfoDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceIdTypesOverviewDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceIdentifier.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerInstanceIdentifier.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceIdentifierContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceIdentifierData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerInstanceIdentifierDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceIdentifierType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerInstanceIdentifierType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceIdentifierTypeConfiguration.cs | DTO | 4 unused using statements |
| ContainerInstanceIdentifierTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceIdentifierTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceIdentifierTypeDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| ContainerInstanceInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerInstanceLabelAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerInstanceLabelAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceLabelAuditContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceLabelAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceQuarantineModel.cs | DTO | 4 unused using statements |
| ContainerInstanceRepository.cs | Repository | 27 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 11 unused using statements |
| ContainerInstanceSummary.cs | DTO | 3 unused using statements |
| ContainerInstanceWeight.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerInstanceWeight.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceWeightContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstanceWeightData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerInstances.cs | Helper | 6 unused using statements |
| ContainerMaster.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMaster.cs | DTO | 33 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMaster.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerMasterBlueprint.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterBlueprint.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterBlueprintContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterBlueprintData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterContract.cs | DTO | 1 interface inheritances removed, 5 unused using statements |
| ContainerMasterData.cs | DTO | 37 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| ContainerMasterDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerMasterDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionAuditRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterDefinitionAuditRule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionAuditRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionAuditRuleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacity.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterDefinitionMaintenanceCapacityTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ContainerMasterDefinitionRepository.cs | Repository | 5 commented code lines, 5 unused using statements |
| ContainerMasterDefinitionTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ContainerMasterDetailsModel.cs | DTO | 3 unused using statements |
| ContainerMasterHelpers.cs | Helper | 4 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| ContainerMasterInfo.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ContainerMasterNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMasterNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterNoteAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteAuditContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteData.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| ContainerMasterNoteRepository.cs | Repository | 1 commented code lines, 5 unused using statements |
| ContainerMasterNoteStationType.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterNoteStationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteStationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteStationTypeData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerMasterNoteType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMasterNoteType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterNoteTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ContainerMasterPrice.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterPrice.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceAdjustment.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMasterPriceAdjustment.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceAdjustmentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceAdjustmentData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContainerMasterPriceAdjustmentType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContainerMasterPriceAdjustmentType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceAdjustmentTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceAdjustmentTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceFull.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContainerMasterPriceFull.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| ContainerMasterPriceFullContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterPriceFullData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContainerMasterRepository.cs | Repository | 2 commented code lines, 6 unused using statements |
| ContainerMasterSearchArgs.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ContainerMasterSearchResult.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ContainerSpecificationData.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ContainerSummaryDatacontract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 5 unused using statements |
| Contract.cs | DTO | 7 commented code lines, 2 unused using statements |
| Contract.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Contract.cs | DTO | 7 commented code lines, 2 unused using statements |
| ContractContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContractData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContractDataAdapter.cs | DTO | 4 unused using statements |
| ContractRepository.cs | DTO | 3 unused using statements |
| ContractVendorMaintenance.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContractVendorMaintenance.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContractVendorMaintenance.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContractVendorMaintenanceContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContractVendorMaintenanceData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ContractVendorMaintenanceDataAdapter.cs | DTO | 4 unused using statements |
| ContractVendorMaintenanceRepository.cs | DTO | 3 unused using statements |
| ContractedHours.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContractedHours.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ContractedHours.cs | DTO | 7 commented code lines, 3 unused using statements |
| ContractedHoursContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContractedHoursData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ContractedHoursDataAdapter.cs | DTO | 9 unused using statements |
| ContractedHoursRepository.cs | DTO | 1 commented code lines, 3 unused using statements |
| ControllerExtensions.cs | Helper | 7 unused using statements |
| ControllerExtensions.cs | Helper | 8 unused using statements |
| ConversionHelper.cs | Helper | 6 unused using statements |
| CostDisplayMode.cs | DTO | 4 unused using statements |
| CostRollup.cs | DTO | 4 unused using statements |
| CostingModel.cs | DTO | 7 commented code lines, 3 unused using statements |
| CostingModel.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CostingModel.cs | DTO | 7 commented code lines, 3 unused using statements |
| CostingModel.cs | DTO | 4 unused using statements |
| CostingModelContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelDataAdapter.cs | DTO | 9 unused using statements |
| CostingModelItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| CostingModelItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CostingModelItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| CostingModelItemType.cs | DTO | 4 unused using statements |
| CostingModelItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelItemTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelItemTypeDataAdapter.cs | DTO | 8 unused using statements |
| CostingModelItemTypeRepository.cs | DTO | 1 commented code lines, 3 unused using statements |
| CostingModelRepository.cs | DTO | 3 unused using statements |
| CostingModelType.cs | DTO | 7 commented code lines, 2 unused using statements |
| CostingModelType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CostingModelType.cs | DTO | 7 commented code lines, 2 unused using statements |
| CostingModelType.cs | DTO | 4 unused using statements |
| CostingModelTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CostingModelTypeDataAdapter.cs | DTO | 4 unused using statements |
| CostingModelTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CostingModelTypeRepository.cs | DTO | 3 unused using statements |
| Courier.cs | DTO | 7 commented code lines, 2 unused using statements |
| Courier.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CourierContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CourierData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CreateBatchRequestDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 6 unused using statements |
| CreateContainerInstanceDataContract.cs | DTO | 19 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CreateContainerInstanceResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| CreateEventErrorIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| CreateEventFaultContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CreateExtraDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 5 unused using statements |
| CreateExtraResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| CreateTenancyModel.cs | DTO | 4 unused using statements |
| CreateTurnaroundEventResultData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Credentials.cs | DTO | 3 unused using statements |
| Culture.cs | DTO | 7 commented code lines, 2 unused using statements |
| Culture.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CultureContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CultureData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CultureHelper.cs | Helper | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| CultureIdentifier.cs | Enum | 3 unused using statements |
| CurrentTurnaroundEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| CurrentTurnaroundEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CurrentTurnaroundEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CurrentTurnaroundEventData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustSetting.cs | DTO | 3 unused using statements |
| CustSettingInfo.cs | DTO | 3 unused using statements |
| CustSettingsDetail.cs | DTO | 3 unused using statements |
| CustSettingsIndex.cs | DTO | 3 unused using statements |
| CustomLinqExpressions.cs | Helper | 7 unused using statements |
| CustomReportCredentials.cs | DTO | 3 commented code lines, 1 interface inheritances removed, 6 unused using statements |
| CustomStationery.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomStationery.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryLogic.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomStationeryLogic.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryLogicContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryLogicData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomStationeryLogicRepository.cs | Repository | 6 unused using statements |
| CustomStationeryRepository.cs | Repository | 6 unused using statements |
| CustomStationeryResultData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomValue.cs | DTO | 3 unused using statements |
| Customer.cs | DTO | 7 commented code lines, 2 unused using statements |
| Customer.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerAssetResponse.cs | DTO | 16 WCF attributes, 1 WCF using statements, 2 unused using statements |
| CustomerChargeCategories.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CustomerChargeCategoryIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| CustomerContract.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerCostData.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerCostingModelFinancialComponentItemTypeRepository.cs | DTO | 2 commented code lines, 3 unused using statements |
| CustomerCostingModelRepository.cs | DTO | 3 unused using statements |
| CustomerCostingModelTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| CustomerCostingModelTypeRepository.cs | DTO | 2 commented code lines, 3 unused using statements |
| CustomerCostingModelTypes.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CustomerData.cs | DTO | 23 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerDataContract.cs | DTO | 16 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerDefect.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerDefect.cs | DTO | 3 WCF attributes, 4 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerDefectAssociationType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CustomerDefectContract.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerDefectCustomerDefectReasonsDataAdapter.cs | Service | 9 unused using statements |
| CustomerDefectCustomerDefectReasonsRepository.cs | Repository | 5 unused using statements |
| CustomerDefectData.cs | DTO | 19 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerDefectDataContract.cs | DTO | 17 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CustomerDefectDetailData.cs | DTO | 12 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerDefectEmailDataContract.cs | DTO | 22 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerDefectEmailItemExceptionsDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerDefectEmailModel.cs | DTO | 3 unused using statements |
| CustomerDefectInformation.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerDefectInformation.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectInformationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectInformationData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectModel.cs | DTO | 3 unused using statements |
| CustomerDefectReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| CustomerDefectReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectReasonDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| CustomerDefectReasonTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CustomerDefectRepository.cs | Repository | 3 commented code lines, 6 unused using statements |
| CustomerDefectResponseModel.cs | DTO | 3 unused using statements |
| CustomerDefectStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| CustomerDefectStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectStatusIdentifier.cs | DTO | 1 WCF attributes, 2 commented code lines, 3 unused using statements |
| CustomerDefectStatusWorkflow.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerDefectStatusWorkflow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectStatusWorkflowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectStatusWorkflowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefectSummary.cs | DTO | 2 unused using statements |
| CustomerDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionGS1.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerDefinitionGS1.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionGS1Contract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionGS1Data.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerDefinitionRepository.cs | Repository | 6 unused using statements |
| CustomerDefinitionType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CustomerDetailDataAdapter.cs | Service | 8 unused using statements |
| CustomerDetailRepository.cs | Repository | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| CustomerFacilityDefinition.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CustomerGroup.cs | DTO | 7 commented code lines, 2 unused using statements |
| CustomerGroup.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerGroupContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerGroupData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerIndexationDetailSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerIndexationDetailSummaryData.cs | DTO | 7 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerIndexationSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerIndexationSummaryData.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerInfo.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerItemType.cs | DTO | 7 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerItemTypeData.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| CustomerItemsSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerItemsSummaryData.cs | DTO | 14 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CustomerRepository.cs | Repository | 6 unused using statements |
| CustomerSetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerSetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerSettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerSettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerSettingRepository.cs | Repository | 1 commented code lines, 6 unused using statements |
| CustomerSettings.cs | Helper | 1 commented code lines, 6 unused using statements |
| CustomerSettingsData.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| CustomerStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| CustomerStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| CustomerWithName.cs | DTO | 4 unused using statements |
| CustomerWorkflow.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomerWorkflow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomerWorkflowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomerWorkflowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomisableBatchCycleValue.cs | DTO | 3 unused using statements |
| CustomisableList.cs | DTO | 3 unused using statements |
| CustomisableListSaveResult.cs | DTO | 4 unused using statements |
| CustomisableListValidationHelper.cs | Helper | 5 commented code lines, 6 unused using statements |
| CustomisableTable.cs | DTO | 7 commented code lines, 3 unused using statements |
| CustomisableTable.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CustomisableTableContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomisableTableData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CustomisableValue.cs | DTO | 2 unused using statements |
| CycleParameter.cs | DTO | 7 commented code lines, 3 unused using statements |
| CycleParameter.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CycleParameterActivityType.cs | DTO | 7 commented code lines, 2 unused using statements |
| CycleParameterActivityType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CycleParameterActivityTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterActivityTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterActivityTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CycleParameterAirRemoval.cs | DTO | 7 commented code lines, 3 unused using statements |
| CycleParameterAirRemoval.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CycleParameterAirRemovalContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterAirRemovalData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterChamber.cs | DTO | 7 commented code lines, 2 unused using statements |
| CycleParameterChamber.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CycleParameterChamberContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterChamberData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterChamberIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| CycleParameterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| CycleParameterDetail.cs | DTO | 7 commented code lines, 3 unused using statements |
| CycleParameterDetail.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| CycleParameterDetailContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| CycleParameterDetailData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DOCINFOA.cs | Service | 7 unused using statements |
| DashboardItem.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DashboardModel.cs | DTO | 4 unused using statements |
| DashboardSummaryItem.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DataAdapterBase.cs | Service | 6 unused using statements |
| DataAdapterFactory.cs | Service | 7 unused using statements |
| DataCommand.cs | Service | 1 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| DataCommandFactory.cs | Service | 9 unused using statements |
| DataContractBase.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| DataContractData.cs | DTO | 3 unused using statements |
| DataContracts.cs | DTO | 3 unused using statements |
| DataFilter.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DataManager.cs | Service | 2 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| DataTimeFormatSourceIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DataValueDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Database.cs | Service | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 7 unused using statements |
| DatabaseOverview.cs | DTO | 3 unused using statements |
| DateTimeConversionHelper.cs | Helper | 6 unused using statements |
| DateTimeExtensions.cs | Helper | 7 unused using statements |
| DateTimeExtensions.cs | Helper | 5 unused using statements |
| DateTimeFormat.cs | DTO | 7 commented code lines, 3 unused using statements |
| DateTimeFormat.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DateTimeFormatContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DateTimeFormatData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DateTimeFormatDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DateTimeFormatHelper.cs | Enum | 3 commented code lines, 4 unused using statements |
| DateTimeFormatIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DateTimeFormatRepository.cs | Repository | 6 unused using statements |
| DateTimeFormatResources.cs | Service | 6 unused using statements |
| DbContextExtensions.cs | Helper | 10 unused using statements |
| DbSetExtensions.cs | Helper | 7 unused using statements |
| DecontaminationTask.cs | DTO | 7 commented code lines, 2 unused using statements |
| DecontaminationTask.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| DecontaminationTaskItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| DecontaminationTaskItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskItemTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskTime.cs | DTO | 7 commented code lines, 3 unused using statements |
| DecontaminationTaskTime.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskTimeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DecontaminationTaskTimeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Defect.cs | DTO | 7 commented code lines, 3 unused using statements |
| Defect.cs | DTO | 1 WCF attributes, 4 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DefectActionEmailModel.cs | DTO | 3 unused using statements |
| DefectActionModel.cs | DTO | 2 unused using statements |
| DefectAuditHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| DefectAuditHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectAuditHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectAuditHistoryData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DefectAuditHistoryRepository.cs | Repository | 7 unused using statements |
| DefectClassification.cs | DTO | 7 commented code lines, 2 unused using statements |
| DefectClassification.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectClassificationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectClassificationData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectClassificationDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DefectCloseOutModel.cs | DTO | 4 unused using statements |
| DefectCommentEmailModel.cs | DTO | 3 unused using statements |
| DefectContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DefectData.cs | DTO | 21 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DefectDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 4 unused using statements |
| DefectDetailsModel.cs | DTO | 24 commented code lines, 3 unused using statements |
| DefectDetailsModel.cs | DTO | 3 unused using statements |
| DefectEditModel.cs | DTO | 4 unused using statements |
| DefectEmailModel.cs | DTO | 3 unused using statements |
| DefectEmailModel.cs | DTO | 3 unused using statements |
| DefectModel.cs | DTO | 1 commented code lines, 5 unused using statements |
| DefectModel.cs | DTO | 4 unused using statements |
| DefectRepository.cs | Repository | 1 commented code lines, 8 unused using statements |
| DefectResponsibility.cs | DTO | 7 commented code lines, 2 unused using statements |
| DefectResponsibility.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectResponsibilityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectResponsibilityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectResponsibilityIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DefectSeverity.cs | DTO | 7 commented code lines, 2 unused using statements |
| DefectSeverity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectSeverityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectSeverityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectSeverityIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DefectStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| DefectStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectStatusIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DefectSummary.cs | DTO | 3 unused using statements |
| DefectTurnaroundEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| DefectTurnaroundEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefectTurnaroundEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectTurnaroundEventData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefectType.cs | Enum | 3 unused using statements |
| DefinitionType.cs | DTO | 7 commented code lines, 2 unused using statements |
| DefinitionType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DefinitionTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DefinitionTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DelayedBiTestType.cs | DTO | 7 commented code lines, 2 unused using statements |
| DelayedBiTestType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DelayedBiTestTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DelayedBiTestTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DelayedBiTestTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DeleteModelState.cs | DTO | 3 unused using statements |
| DeliveryNote.cs | DTO | 7 commented code lines, 3 unused using statements |
| DeliveryNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DeliveryNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeliveryNoteData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DeliveryNoteDataContract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DeliveryNoteInfo.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryNoteItemType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DeliveryNoteModel.cs | DTO | 3 unused using statements |
| DeliveryNotePrintData.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryNotePrintDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DeliveryNoteRepository.cs | Repository | 9 commented code lines, 4 unused using statements |
| DeliveryNoteRequestDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DeliveryNoteScanDetails.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryNoteSummary.cs | DTO | 3 unused using statements |
| DeliveryNoteTurnaroundDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryNotes.cs | Service | 9 unused using statements |
| DeliveryNotesDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DeliveryNotes_LoadDeliveryNoteListByFacility_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| DeliveryNotes_LoadDeliveryNotesListByFacility_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| DeliveryPoint.cs | DTO | 7 commented code lines, 2 unused using statements |
| DeliveryPoint.cs | DTO | 1 WCF attributes, 5 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DeliveryPointBatchTagSetting.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DeliveryPointContract.cs | DTO | 1 interface inheritances removed, 5 unused using statements |
| DeliveryPointData.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DeliveryPointDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryPointInfo.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DeliveryPointInfo.cs | DTO | 3 unused using statements |
| DeliveryPointMatchingResult.cs | DTO | 3 unused using statements |
| DeliveryPointRepository.cs | Repository | 2 commented code lines, 6 unused using statements |
| DeliveryPointSettingInfo.cs | DTO | 4 unused using statements |
| DeliveryPointSettingModel.cs | DTO | 4 unused using statements |
| DeliveryPointSettingsDetail.cs | DTO | 3 unused using statements |
| DeliveryPointSettingsIndex.cs | DTO | 4 unused using statements |
| DeliveryPointTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DeliveryType.cs | DTO | 7 commented code lines, 2 unused using statements |
| DeliveryType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DeliveryTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeliveryTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeniedEventDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 4 unused using statements |
| DeniedTurnaroundEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| DeniedTurnaroundEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| DeniedTurnaroundEventReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DeniedTurnaroundEventReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DespatchStationData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DestinationEvent.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Details.cs | DTO | 3 unused using statements |
| DialogButtons.cs | Enum | 3 unused using statements |
| DialogLayoutModel.cs | DTO | 2 unused using statements |
| DictionaryModelDescription.cs | DTO | 3 unused using statements |
| Directorate.cs | DTO | 7 commented code lines, 2 unused using statements |
| Directorate.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DirectorateContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DirectorateData.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| DirtyInstrument.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Dispatch.cs | Service | 7 commented code lines, 7 unused using statements |
| DisplayColorAttribute.cs | Service | 6 unused using statements |
| Document.cs | DTO | 7 commented code lines, 3 unused using statements |
| Document.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DocumentActivityTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DocumentAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| DocumentAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| DocumentAuditContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DocumentAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DocumentAuditDataContract.cs | DTO | 14 WCF attributes, 1 WCF using statements, 3 unused using statements |
| DocumentAuditHelper.cs | Helper | 9 commented code lines, 11 unused using statements |
| DocumentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DocumentData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| DocumentDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DocumentDialogModel.cs | DTO | 3 unused using statements |
| DocumentGalleryModel.cs | DTO | 3 unused using statements |
| DocumentRequestDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 4 unused using statements |
| DocumentSourceIdentifier.cs | Enum | 3 unused using statements |
| DocumentTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| DryingCabinetLocationDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DynamicDataDataContract.cs | DTO | 16 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DynamicReply.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DynamicRequest.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| DynamicResult.cs | DTO | 3 unused using statements |
| EPOCHelper.cs | Helper | 4 commented code lines, 6 unused using statements |
| EmailAddressData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| EmailDeliveryReportIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| EmailHelper.cs | Helper | 2 commented code lines, 10 unused using statements |
| EndoscopeDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 5 unused using statements |
| EndoscopeHelper.cs | Helper | 10 commented code lines, 11 unused using statements |
| EndoscopeStatus.cs | DTO | 1 WCF attributes, 3 unused using statements |
| EndoscopeStorageScanDetails.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| Endoscopy.cs | Service | 28 commented code lines, 10 unused using statements |
| EndoscopyChangeDetergentDetails.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EndoscopyChangeDetergentRequest.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| EndoscopyDeconTaskRequest.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| EndoscopyDeconTaskResult.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EndoscopyDeconTasks.cs | Helper | 7 commented code lines, 9 unused using statements |
| EndoscopyDryingCabinetDataContract.cs | DTO | 5 unused using statements |
| EndoscopyDryingCabinetHelper.cs | Helper | 17 commented code lines, 8 unused using statements |
| EndoscopyLocationDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| EndoscopyLocationHelper.cs | Helper | 10 commented code lines, 11 unused using statements |
| EndoscopyLocationScanAssetDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| EndoscopyScanDataContract.cs | DTO | 1 WCF attributes, 1 WCF using statements, 4 unused using statements |
| EndoscopyStationDataContract.cs | DTO | 4 unused using statements |
| EndoscopyVacPackHelper.cs | Helper | 5 commented code lines, 8 unused using statements |
| EngineExceptionHandler.cs | Service | 4 commented code lines, 1 interface inheritances removed, 7 unused using statements |
| EngineOperativeHelpers.cs | Helper | 6 unused using statements |
| Enquiry.cs | DTO | 3 unused using statements |
| Enquiry.cs | DTO | 7 commented code lines, 3 unused using statements |
| Enquiry.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EnquiryComment.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EnquiryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EnquiryData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| EnquiryData.cs | DTO | 3 unused using statements |
| EnquiryDetailsModel.cs | DTO | 4 unused using statements |
| EnquiryEmailDetails.cs | DTO | 5 WCF attributes, 8 commented code lines, 1 WCF using statements, 2 unused using statements |
| EnquiryEmailModel.cs | DTO | 3 unused using statements |
| EnquiryEmailType.cs | DTO | 3 unused using statements |
| EnquiryListData.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EnquiryModel.cs | DTO | 3 unused using statements |
| EnquiryStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| EnquiryStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EnquiryStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EnquiryStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EnquiryStatusData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EnquirySummary.cs | DTO | 2 unused using statements |
| EnquiryTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| EnquiryTypes.cs | Enum | 3 unused using statements |
| EntLibWrapper.cs | Service | 2 commented code lines, 1 interface inheritances removed, 9 unused using statements |
| EntityType.cs | DTO | 3 unused using statements |
| EnumExtensions.cs | Enum | 5 unused using statements |
| EnumHelper.cs | Enum | 4 unused using statements |
| EnumTypeModelDescription.cs | DTO | 4 unused using statements |
| EnumValueDescription.cs | DTO | 3 unused using statements |
| Enums.cs | DTO | 4 WCF attributes, 3 unused using statements |
| Enums.cs | Enum | 3 unused using statements |
| EnvironmentModel.cs | DTO | 1 commented code lines, 5 unused using statements |
| EpocEpodProcessingMode.cs | DTO | 1 WCF attributes, 3 unused using statements |
| EpocTrolleyModel.cs | DTO | 3 unused using statements |
| ErrorCodes.cs | Enum | 1 commented code lines, 3 unused using statements |
| ErrorEventHandler.cs | Service | 8 commented code lines, 7 unused using statements |
| ErrorModel.cs | DTO | 4 unused using statements |
| EventHandlerBase.cs | Service | 6 unused using statements |
| EventHandlerFactory.cs | Service | 9 unused using statements |
| EventHandlerHelper.cs | Helper | 8 unused using statements |
| EventType.cs | DTO | 7 commented code lines, 2 unused using statements |
| EventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EventTypeCategory.cs | DTO | 7 commented code lines, 3 unused using statements |
| EventTypeCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EventTypeCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeCategoryIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| EventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| EventTypeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EventTypeDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 2 unused using statements |
| EventTypeExtensions.cs | Enum | 3 unused using statements |
| EventTypeGroup.cs | DTO | 7 commented code lines, 3 unused using statements |
| EventTypeGroup.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EventTypeGroupContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeGroupData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| EventTypeInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EventTypeListDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| EventTypeStationType.cs | DTO | 7 commented code lines, 3 unused using statements |
| EventTypeStationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| EventTypeStationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeStationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| EventTypeStationTypeRepository.cs | Repository | 6 unused using statements |
| EventtypeRepository.cs | Repository | 7 commented code lines, 6 unused using statements |
| ExcludeHelpAttribute.cs | Service | 6 unused using statements |
| ExpiryCalculationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ExpiryCalculationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ExpiryCalculationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ExpiryCalculationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ExpressionHelper.cs | Helper | 3 commented code lines, 9 unused using statements |
| ExtendedError.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ExternalReferenceTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ExtrasDataContract.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| FDAPinRequestReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| FacSetting.cs | DTO | 3 unused using statements |
| FacilitiesDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| Facility.cs | DTO | 7 commented code lines, 2 unused using statements |
| Facility.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityArchivedData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| FacilityAuditRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| FacilityAuditRule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityAuditRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityAuditRuleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityAuditRuleRepository.cs | Repository | 6 unused using statements |
| FacilityBatchDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilityBatchRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| FacilityBatchResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| FacilityContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FacilityData.cs | DTO | 20 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FacilityDataContract.cs | DTO | 19 WCF attributes, 1 WCF using statements, 4 unused using statements |
| FacilityDetailsModel.cs | DTO | 3 unused using statements |
| FacilityDirectorateDataContract.cs | DTO | 13 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilityHelper.cs | Helper | 6 unused using statements |
| FacilityInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilityInfoDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 2 unused using statements |
| FacilityItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| FacilityItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityItemTypeContract.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FacilityItemTypeData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FacilityLocationsContract.cs | DTO | 9 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityLocationsData.cs | DTO | 9 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| FacilityNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityNoteDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilityNotesDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| FacilityRepository.cs | Repository | 1 commented code lines, 9 unused using statements |
| FacilityRestriction.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilitySetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| FacilitySetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilitySettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilitySettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilitySettingDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FacilitySettingInfo.cs | DTO | 3 unused using statements |
| FacilitySettingRepository.cs | Repository | 7 unused using statements |
| FacilitySettings.cs | Helper | 4 commented code lines, 6 unused using statements |
| FacilitySettingsDetail.cs | DTO | 3 unused using statements |
| FacilitySettingsIndex.cs | DTO | 3 unused using statements |
| FacilityType.cs | DTO | 7 commented code lines, 2 unused using statements |
| FacilityType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FacilityType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| FacilityTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FacilityWorkflowModel.cs | DTO | 4 unused using statements |
| Factory.cs | DTO | 3 unused using statements |
| FailedBatch.cs | DTO | 7 commented code lines, 2 unused using statements |
| FailedBatch.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailedBatchContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedBatchData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FailedBatchRepository.cs | Repository | 6 unused using statements |
| FailedScan.cs | DTO | 7 commented code lines, 3 unused using statements |
| FailedScan.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailedScan.cs | Helper | 2 commented code lines, 7 unused using statements |
| FailedScanContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedScanData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedScanDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| FailedScansDataContract.cs | DTO | 4 unused using statements |
| FailedWash.cs | DTO | 7 commented code lines, 3 unused using statements |
| FailedWash.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailedWashContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedWashData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedWashHelper.cs | Helper | 5 commented code lines, 7 unused using statements |
| FailedWashHelper.cs | Helper | 8 unused using statements |
| FailedWashInstrument.cs | DTO | 7 commented code lines, 3 unused using statements |
| FailedWashInstrument.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailedWashInstrumentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedWashInstrumentData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailedWashRepository.cs | Repository | 6 unused using statements |
| FailureType.cs | DTO | 7 commented code lines, 2 unused using statements |
| FailureType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailureTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailureTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailureTypeEventType.cs | DTO | 7 commented code lines, 3 unused using statements |
| FailureTypeEventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FailureTypeEventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailureTypeEventTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FailureTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| FailureTypeItem.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| FastTrack.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackDetailsModel.cs | DTO | 2 unused using statements |
| FastTrackEmailModel.cs | DTO | 3 unused using statements |
| FastTrackItemModel.cs | DTO | 3 unused using statements |
| FastTrackModel.cs | DTO | 3 unused using statements |
| FastTrackRequest.cs | DTO | 7 commented code lines, 2 unused using statements |
| FastTrackRequest.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestData.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FastTrackRequestLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| FastTrackRequestLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestLineData.cs | DTO | 6 WCF attributes, 1 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| FastTrackRequestStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| FastTrackRequestStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FastTrackRequestsData.cs | DTO | 18 WCF attributes, 1 WCF using statements, 4 unused using statements |
| FastTrackSummary.cs | DTO | 2 unused using statements |
| FastTrackTargetModel.cs | DTO | 3 unused using statements |
| FavouriteReport.cs | DTO | 7 commented code lines, 3 unused using statements |
| FavouriteReport.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportContract.cs | DTO | 18 WCF attributes, 1 WCF using statements, 3 unused using statements |
| FavouriteReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameter.cs | DTO | 7 commented code lines, 3 unused using statements |
| FavouriteReportParameter.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameterData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameterValue.cs | DTO | 7 commented code lines, 3 unused using statements |
| FavouriteReportParameterValue.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameterValueContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportParameterValueData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FavouriteReportRepository.cs | Repository | 6 unused using statements |
| FdaComplianceReasons.cs | DTO | 1 WCF attributes, 3 unused using statements |
| FeedbackData.cs | DTO | 18 WCF attributes, 3 unused using statements |
| FileContract.cs | DTO | 9 WCF attributes, 2 commented code lines, 1 WCF using statements, 3 unused using statements |
| FileExtensions.cs | Helper | 1 commented code lines, 8 unused using statements |
| FileMetaData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FileMetaDataContract.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FileModel.cs | DTO | 22 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| FileModel.cs | DTO | 6 unused using statements |
| FileModelDataContract.cs | DTO | 28 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| FilterOption.cs | DTO | 3 unused using statements |
| FilterOptionGroup.cs | DTO | 4 unused using statements |
| FilterState.cs | Enum | 3 unused using statements |
| Finance_CommonResources.cs | Service | 6 unused using statements |
| FinancialCalendar.cs | DTO | 7 commented code lines, 3 unused using statements |
| FinancialCalendar.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FinancialCalendarContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FinancialCalendarData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FindStockViewModel.cs | DTO | 3 unused using statements |
| ForgottenPasswordModel.cs | DTO | 3 unused using statements |
| Format.cs | DTO | 7 commented code lines, 2 unused using statements |
| Format.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FormatContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FormatData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FormatRepository.cs | Repository | 6 unused using statements |
| FormatType.cs | DTO | 7 commented code lines, 2 unused using statements |
| FormatType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| FormatTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FormatTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| FormatTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| FormattingExtensions.cs | Helper | 6 unused using statements |
| GenericKeyValue.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| GenericKeyValueAssociated.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| GenericKeyValueAssociatedData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| GenericKeyValueAssociatedData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| GenericKeyValueData.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| GenericKeyValueData.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| GetAllOrdersByAlternateIdOrOrderNumber_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetAllProductionManagerFilterForUserAndFacilityDetails_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetAllProductionManagerFilterForUserAndFacility_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetClockingActionsResultData.cs | DTO | 4 unused using statements |
| GetComponentsRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 5 unused using statements |
| GetListRequest.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| GetNotificationRuleOutcome_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetOrderNotesResponseContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| GetPriorityListItemsForOrdering_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetReply.cs | DTO | 7 WCF attributes, 1 WCF using statements, 4 unused using statements |
| GetRequest.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| GetStationeryVersion_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GetStockLevelsByContainerMasterDefinition_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| GettingStartedModel.cs | DTO | 3 unused using statements |
| GlobalCache.cs | Service | 6 unused using statements |
| GlobalCacheKey.cs | Enum | 1 commented code lines, 3 unused using statements |
| GlobalHandler.cs | Service | 1 interface inheritances removed, 6 unused using statements |
| GlobalManager.cs | Service | 1 interface inheritances removed, 6 unused using statements |
| GroupTurnaroundsBy.cs | DTO | 1 WCF attributes, 3 unused using statements |
| GroupedListItem.cs | Service | 5 unused using statements |
| GroupedRowTableModel.cs | DTO | 3 unused using statements |
| HISOrderCancellationRequest.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HISOrderRequest.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HISOrderRequestLine.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HaveIBeenPwned.cs | Helper | 9 commented code lines, 10 unused using statements |
| HelpPageApiModel.cs | DTO | 7 unused using statements |
| HelpPageConfigurationExtensions.cs | Helper | 23 commented code lines, 13 unused using statements |
| HelpPageSampleGenerator.cs | Service | 15 commented code lines, 14 unused using statements |
| HelpPageSampleKey.cs | Service | 7 unused using statements |
| HelpPartialAttribute.cs | Service | 6 unused using statements |
| HelpPartialInfo.cs | Enum | 3 unused using statements |
| HisDataCrossMatchCommonSearchParameters.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisDataCrossMatchType.cs | DTO | 7 commented code lines, 2 unused using statements |
| HisDataCrossMatchType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| HisDataCrossMatching.cs | DTO | 7 commented code lines, 3 unused using statements |
| HisDataCrossMatching.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisDataCrossMatchingDataContract.cs | DTO | 19 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisDataCrossMatchingRequiredDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisDataCrossMatchingRequiredSearchParameters.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisDataCrossMatchingSearchParameters.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisMessage.cs | DTO | 7 commented code lines, 3 unused using statements |
| HisMessage.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisMessageContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisMessageData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrder.cs | DTO | 7 commented code lines, 3 unused using statements |
| HisOrder.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisOrderContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrderData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrderDataContract.cs | DTO | 16 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisOrderDataSearchParameters.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisOrderLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| HisOrderLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisOrderLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrderLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrderLineDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| HisOrderLineFieldMatchingType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| HisOrderMatchedOrderLineDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 2 unused using statements |
| HisOrderNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| HisOrderNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HisOrderNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HisOrderNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HistoryDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| HistoryItemType.cs | Enum | 3 unused using statements |
| HmacWrapper.cs | Service | 8 unused using statements |
| HmacWrapper.cs | Helper | 8 unused using statements |
| HtmlHelperExtensions.cs | Helper | 21 commented code lines, 10 unused using statements |
| HtmlHelperExtensions.cs | Helper | 9 unused using statements |
| HttpHeaderAttribute.cs | Service | 6 unused using statements |
| HttpRequestBaseExtensions.cs | DTO | 4 unused using statements |
| HttpStatusAttribute.cs | Service | 7 unused using statements |
| Hub.cs | DTO | 7 commented code lines, 2 unused using statements |
| Hub.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| HubContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| HubData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IAccountService.cs | Interface | 7 unused using statements |
| IApplyEvent.cs | Interface | 7 unused using statements |
| IAuditRule.cs | Interface | 4 unused using statements |
| IAutoclaveInStationService.cs | Interface | 63 WCF attributes, 1 WCF using statements, 7 unused using statements |
| IAutoclaveOutStationService.cs | Interface | 49 WCF attributes, 1 WCF using statements, 8 unused using statements |
| IBaseControllerExtensions.cs | Helper | 5 commented code lines, 9 unused using statements |
| IBaseControllerExtensions.cs | Helper | 2 commented code lines, 7 unused using statements |
| IBatch.cs | Interface | 4 unused using statements |
| IBatchCycle.cs | Interface | 3 unused using statements |
| ICacheManager.cs | Interface | 4 unused using statements |
| ICategory.cs | Interface | 3 unused using statements |
| IChargeListSummary.cs | Interface | 4 unused using statements |
| ICollectionExtensions.cs | Helper | 6 unused using statements |
| IComment.cs | Interface | 3 unused using statements |
| IConfigurationViewModel.cs | Interface | 4 unused using statements |
| IContainerContent.cs | Interface | 4 unused using statements |
| IContainerInstance.cs | Interface | 3 unused using statements |
| IContainerInstanceAutomaticEventService.cs | Interface | 7 unused using statements |
| IContainerMaster.cs | Interface | 3 unused using statements |
| IContainerMasterNote.cs | Interface | 3 unused using statements |
| IContainerMasterNoteStationType.cs | Interface | 4 unused using statements |
| IContract.cs | Interface | 3 unused using statements |
| IContractDataAdapter.cs | Interface | 4 unused using statements |
| IContractVendorMaintenance.cs | Interface | 4 unused using statements |
| IContractVendorMaintenanceDataAdapter.cs | Interface | 4 unused using statements |
| IContractedHours.cs | Interface | 4 unused using statements |
| IContractedHoursDataAdapter.cs | Interface | 2 commented code lines, 5 unused using statements |
| ICostingModel.cs | Interface | 4 unused using statements |
| ICostingModelDataAdapter.cs | Interface | 5 unused using statements |
| ICostingModelItemType.cs | Interface | 4 unused using statements |
| ICostingModelItemTypeDataAdapter.cs | Interface | 4 unused using statements |
| ICostingModelType.cs | Interface | 3 unused using statements |
| ICostingModelTypeDataAdapter.cs | Interface | 4 unused using statements |
| ICourier.cs | Interface | 3 unused using statements |
| ICulture.cs | Interface | 3 unused using statements |
| ICustomerDefect.cs | Interface | 4 unused using statements |
| ICustomerDefectDetail.cs | Interface | 4 unused using statements |
| ICustomerDefectReason.cs | Interface | 3 unused using statements |
| ICustomerIndexationSummary.cs | Interface | 4 unused using statements |
| ICustomerService.cs | Interface | 12 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IData.cs | Interface | 4 unused using statements |
| IDataCommand.cs | Interface | 4 unused using statements |
| IDataManager.cs | Interface | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 5 unused using statements |
| IDateFormater.cs | Interface | 4 unused using statements |
| IDateTimeFormat.cs | Interface | 4 unused using statements |
| IDateTimeFormatModel.cs | Interface | 2 commented code lines, 4 unused using statements |
| IDecontaminationTask.cs | Interface | 3 unused using statements |
| IDefect.cs | Interface | 4 unused using statements |
| IDefectAuditHistory.cs | Interface | 4 unused using statements |
| IDefectResponsibility.cs | Interface | 3 unused using statements |
| IDeliveryNote.cs | Interface | 4 unused using statements |
| IDeliveryPoint.cs | Interface | 3 unused using statements |
| IDespatchStationService.cs | Interface | 39 WCF attributes, 1 WCF using statements, 7 unused using statements |
| IDocumentAndImageService.cs | Interface | 11 WCF attributes, 1 WCF using statements, 5 unused using statements |
| IEngineExceptionHandler.cs | Interface | 4 unused using statements |
| IEnquiryStationService.cs | Interface | 9 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IEntityData.cs | Interface | 4 unused using statements |
| IEnumerableExtensions.cs | Enum | 5 unused using statements |
| IFacility.cs | Interface | 3 unused using statements |
| IFacilityArchived.cs | Interface | 3 unused using statements |
| IFacilityItemType.cs | Interface | 4 unused using statements |
| IFacilityNote.cs | Interface | 3 unused using statements |
| IFacilityService.cs | Interface | 15 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IFailureType.cs | Interface | 3 unused using statements |
| IFileModel.cs | Interface | 4 unused using statements |
| IFindStockViewModel.cs | Interface | 4 unused using statements |
| IGenericKeyValue.cs | Interface | 4 unused using statements |
| IGlobalDataContext.cs | Interface | 5 unused using statements |
| IICustomerIndexationDetailSummary.cs | Interface | 4 unused using statements |
| IInboundStationService.cs | Interface | 13 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IInspectionAndAssemblyService.cs | Interface | 49 WCF attributes, 1 WCF using statements, 8 unused using statements |
| IIntegrationServiceModel.cs | Interface | 4 unused using statements |
| IInvoiceService.cs | Interface | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| IItemExceptionReason.cs | Interface | 3 unused using statements |
| IItemExceptions.cs | Interface | 4 unused using statements |
| IItemService.cs | Interface | 146 WCF attributes, 2 commented code lines, 1 WCF using statements, 5 unused using statements |
| IItemType.cs | Interface | 3 unused using statements |
| ILoanSetRecordService.cs | Interface | 41 WCF attributes, 1 WCF using statements, 8 unused using statements |
| ILocation.cs | Interface | 3 unused using statements |
| ILog.cs | Interface | 5 unused using statements |
| IMSHelper.cs | Helper | 9 unused using statements |
| IMSUserCustomerResponse.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| IMachine.cs | Interface | 3 unused using statements |
| IMachineEventReason.cs | Interface | 3 unused using statements |
| IMachineService.cs | Interface | 49 WCF attributes, 1 commented code lines, 1 WCF using statements, 6 unused using statements |
| IMachineType.cs | Interface | 3 unused using statements |
| IMainViewModel.cs | Interface | 5 unused using statements |
| IMaintenanceActivity.cs | Interface | 3 unused using statements |
| IMaintenanceReport.cs | Interface | 4 unused using statements |
| IMaintenanceReportService.cs | Interface | 79 WCF attributes, 1 WCF using statements, 9 unused using statements |
| IMasterParameters.cs | Interface | 4 unused using statements |
| IModelDocumentationProvider.cs | Interface | 5 unused using statements |
| INavigationViewModel.cs | Interface | 4 unused using statements |
| INoteService.cs | Interface | 9 WCF attributes, 1 WCF using statements, 6 unused using statements |
| INotificationEngineHelper.cs | Interface | 6 unused using statements |
| IOOATrolleyDispatchHelper.cs | Interface | 5 unused using statements |
| IOmniSearch.cs | Interface | 4 unused using statements |
| IOmniSearchBatchDetail.cs | Interface | 4 unused using statements |
| IOmniSearchCustomerDetail.cs | Interface | 4 unused using statements |
| IOmniSearchDefectsDetail.cs | Interface | 4 unused using statements |
| IOmniSearchDeliveryNotesDetail.cs | Interface | 4 unused using statements |
| IOmniSearchDeliveryPointDetail.cs | Interface | 4 unused using statements |
| IOmniSearchFacilityDetail.cs | Interface | 4 unused using statements |
| IOmniSearchInstanceDetail.cs | Interface | 4 unused using statements |
| IOmniSearchItemDetail.cs | Interface | 4 unused using statements |
| IOmniSearchLoanSetsDetail.cs | Interface | 4 unused using statements |
| IOmniSearchSummary.cs | Interface | 4 unused using statements |
| IOmniSearchTurnaroundDetail.cs | Interface | 1 commented code lines, 4 unused using statements |
| IOmniSearchUserDetail.cs | Interface | 4 unused using statements |
| IOperationResponse.cs | Interface | 5 unused using statements |
| IOrderingService.cs | Interface | 9 WCF attributes, 1 commented code lines, 2 WCF using statements, 7 unused using statements |
| IPathwayExceptionHandler.cs | Interface | 4 unused using statements |
| IPathwayExceptionManager.cs | Interface | 4 unused using statements |
| IPathwayRepository.cs | Interface | 4 unused using statements |
| IPathwayWarehouseRepository.cs | Interface | 5 unused using statements |
| IPermission.cs | Interface | 3 unused using statements |
| IPickStockViewModel.cs | Interface | 5 unused using statements |
| IPrintEventHandler.cs | Interface | 5 unused using statements |
| IPrintHandler.cs | Interface | 6 unused using statements |
| IPrinter.cs | Interface | 3 unused using statements |
| IProcessingNote.cs | Interface | 3 unused using statements |
| IPutAwayViewModel.cs | Interface | 4 unused using statements |
| IQualityAssuranceStationService.cs | Interface | 34 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IQuarantineReason.cs | Interface | 3 unused using statements |
| IQueryableContainerMasterExtensions.cs | Helper | 6 unused using statements |
| IQueryableExtensions.cs | Helper | 8 unused using statements |
| IReport.cs | Interface | 3 unused using statements |
| IReportCategory.cs | Interface | 3 unused using statements |
| IReportOutputType.cs | Interface | 4 unused using statements |
| IReportingEventHandler.cs | Interface | 6 unused using statements |
| IReportingService.cs | Interface | 25 WCF attributes, 1 WCF using statements, 8 unused using statements |
| IRepository.cs | Interface | 8 unused using statements |
| IRole.cs | Interface | 3 unused using statements |
| IRolePermission.cs | Interface | 4 unused using statements |
| IServiceBase.cs | Interface | 4 unused using statements |
| IServiceExceptionManager.cs | Interface | 4 unused using statements |
| IServiceParameterModel.cs | Interface | 4 unused using statements |
| IServiceReports.cs | Interface | 4 unused using statements |
| IServiceRequirement.cs | Interface | 3 unused using statements |
| IServiceRequirementContractedHours.cs | Interface | 4 unused using statements |
| IServiceRequirementContractedHoursDataAdapter.cs | Interface | 4 unused using statements |
| IServiceRequirementDefinition.cs | Interface | 4 unused using statements |
| IServiceRequirementDetail.cs | Interface | 4 unused using statements |
| IServiceRequirementEventType.cs | Interface | 4 unused using statements |
| IServiceRequirementExpiry.cs | Interface | 4 unused using statements |
| IServiceRequirementExpiryWindow.cs | Interface | 4 unused using statements |
| ISetting.cs | Interface | 4 unused using statements |
| ISingleUseItemByContainerMasterSummary.cs | Interface | 4 unused using statements |
| ISingleUseItemSummary.cs | Interface | 4 unused using statements |
| ISpeciality.cs | Interface | 3 unused using statements |
| IStation.cs | Interface | 3 unused using statements |
| IStationData.cs | Interface | 6 unused using statements |
| IStationType.cs | Interface | 3 unused using statements |
| ISterilisationService.cs | Interface | 29 WCF attributes, 1 WCF using statements, 6 unused using statements |
| ISterilisationTestReport.cs | Interface | 4 unused using statements |
| IStockManagementService.cs | Interface | 71 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IStockTakeViewModel.cs | Interface | 4 unused using statements |
| ISynergyApplicationFrameworkService.cs | Interface | 25 WCF attributes, 1 WCF using statements, 8 unused using statements |
| ISynergyExceptionHandler.cs | Interface | 4 unused using statements |
| ISynergyExceptionManager.cs | Interface | 4 unused using statements |
| ISynergyTrakHelper.cs | Interface | 5 unused using statements |
| ISynergyTrakService.cs | Interface | 2 WCF attributes, 2 WCF using statements, 17 unused using statements |
| ITenancySetting.cs | Interface | 4 unused using statements |
| ITrakStarService.cs | Interface | 20 WCF attributes, 2 WCF using statements, 9 unused using statements |
| ITranslator.cs | Interface | 6 unused using statements |
| ITrayPrioritisationStationService.cs | Interface | 37 WCF attributes, 1 WCF using statements, 8 unused using statements |
| ITrolleyDispatchHelper.cs | Interface | 6 unused using statements |
| ITurnaround.cs | Interface | 4 unused using statements |
| ITurnaroundDetail.cs | Interface | 1 commented code lines, 4 unused using statements |
| ITurnaroundEvent.cs | Interface | 4 unused using statements |
| ITurnaroundEventList.cs | Interface | 4 unused using statements |
| ITurnaroundNote.cs | Interface | 3 unused using statements |
| ITurnaroundService.cs | Interface | 50 WCF attributes, 1 WCF using statements, 7 unused using statements |
| ITurnaroundTabDetail.cs | Interface | 4 unused using statements |
| ITurnaroundWH.cs | Interface | 4 unused using statements |
| IUnitOfWork.cs | Interface | 5 unused using statements |
| IUser.cs | Interface | 4 unused using statements |
| IUserComplexity.cs | Interface | 4 unused using statements |
| IUserExtendedProperty.cs | Interface | 4 unused using statements |
| IUserFacility.cs | Interface | 4 unused using statements |
| IUserPermission.cs | Interface | 4 unused using statements |
| IUserPrinter.cs | Interface | 4 unused using statements |
| IUserReport.cs | Interface | 4 unused using statements |
| IUserService.cs | Interface | 111 WCF attributes, 1 WCF using statements, 6 unused using statements |
| IUtilityEventHandler.cs | Interface | 6 unused using statements |
| IUtilityService.cs | Interface | 104 WCF attributes, 3 commented code lines, 1 WCF using statements, 8 unused using statements |
| IVendorService.cs | Interface | 57 WCF attributes, 1 WCF using statements, 10 unused using statements |
| IViewModel.cs | Interface | 4 unused using statements |
| IWashStationService.cs | Interface | 108 WCF attributes, 1 WCF using statements, 7 unused using statements |
| IWorkflow.cs | Interface | 4 unused using statements |
| IWorkflowDetail.cs | Interface | 4 unused using statements |
| Identifier.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| IdentifierConverter.cs | Service | 7 unused using statements |
| IdentifierType.cs | DTO | 1 WCF attributes, 5 unused using statements |
| ImageExtension.cs | Enum | 6 unused using statements |
| ImageGalleryModel.cs | DTO | 3 unused using statements |
| ImageGallerySecureModel.cs | DTO | 3 unused using statements |
| ImageHelper.cs | Helper | 1 commented code lines, 8 unused using statements |
| ImageModel.cs | DTO | 3 unused using statements |
| ImageViewerModel.cs | DTO | 3 unused using statements |
| ImsMaintenanceRequest.cs | DTO | 16 WCF attributes, 1 WCF using statements, 3 unused using statements |
| InboundInstanceTypes.cs | Enum | 3 unused using statements |
| InboundStationData.cs | DTO | 4 WCF attributes, 1 commented code lines, 1 WCF using statements, 3 unused using statements |
| InboundTypes.cs | Enum | 3 unused using statements |
| IncludeMany.cs | Helper | 8 unused using statements |
| IndexInfo.cs | DTO | 3 unused using statements |
| IndexModel.cs | DTO | 3 unused using statements |
| Indexation.cs | DTO | 7 commented code lines, 2 unused using statements |
| Indexation.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| IndexationCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| IndexationCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| IndexationCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndexationCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndexationCategoryIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| IndexationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndexationData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| IndexationExtensions.cs | DTO | 3 unused using statements |
| IndexationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| IndexationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| IndexationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndexationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndexingSummary.cs | DTO | 3 unused using statements |
| IndividualInstrumentTrackEventTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| IndividualInstrumentTrackingEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| IndividualInstrumentTrackingEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| IndividualInstrumentTrackingEventContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| IndividualInstrumentTrackingEventData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndividualInstrumentTrackingEventType.cs | DTO | 7 commented code lines, 2 unused using statements |
| IndividualInstrumentTrackingEventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| IndividualInstrumentTrackingEventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| IndividualInstrumentTrackingEventTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InspectionAndAssemblyStationData.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| InspectionAssemblyProcessingMode.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Instance.cs | DTO | 3 unused using statements |
| InstanceCollection.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InstanceCollectionData.cs | DTO | 30 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| InstanceFactory.cs | Interface | 4 unused using statements |
| InstanceIdentifier.cs | DTO | 4 unused using statements |
| InstanceLabel.cs | Service | 1 commented code lines, 8 unused using statements |
| InstanceLabelPrintAuditRequestDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 5 unused using statements |
| InstanceLabelPrintHandler.cs | Service | 5 commented code lines, 9 unused using statements |
| InstanceLabelPrintType.cs | Enum | 3 unused using statements |
| InstanceLabelPrintType.cs | Enum | 3 unused using statements |
| InstanceSpecificationInfo.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| InstanceTurnaroundEnquiryResponse.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| InstanceTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| InstrumentCrossMatch.cs | DTO | 7 WCF attributes, 1 WCF using statements, 2 unused using statements |
| InstrumentDetailsPinnedModalModel.cs | DTO | 3 unused using statements |
| IntegerRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| IntegrationModel.cs | DTO | 3 unused using statements |
| IntegrationServiceModel.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvalidCustomisableListValue.cs | DTO | 3 unused using statements |
| InvalidReference.cs | DTO | 1 commented code lines, 2 unused using statements |
| InvalidSample.cs | Service | 6 unused using statements |
| InventoryCaseRequest.cs | DTO | 7 WCF attributes, 5 unused using statements |
| Invoice.cs | DTO | 7 commented code lines, 3 unused using statements |
| Invoice.cs | DTO | 5 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceContract.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| InvoiceData.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| InvoiceLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| InvoiceLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoicePeriod.cs | DTO | 7 commented code lines, 2 unused using statements |
| InvoicePeriod.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoicePeriodContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoicePeriodData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoicePeriodIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| InvoiceSchedule.cs | DTO | 7 commented code lines, 3 unused using statements |
| InvoiceSchedule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceScheduleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceScheduleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| InvoiceStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusAuditHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| InvoiceStatusAuditHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusAuditHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusAuditHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| InvoiceStatusWorkflow.cs | DTO | 7 commented code lines, 3 unused using statements |
| InvoiceStatusWorkflow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusWorkflowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceStatusWorkflowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| InvoiceSummaryData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| InvoiceTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| IpAddressHelper.cs | Helper | 2 WCF using statements, 7 unused using statements |
| ItemComponent.cs | DTO | 3 unused using statements |
| ItemComponentExceptionModel.cs | DTO | 3 unused using statements |
| ItemComponentModel.cs | DTO | 3 unused using statements |
| ItemDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemDetailsDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemEstimatedTimeOfArrival.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemEstimatedTimeOfArrival_History.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemException.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemException.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemExceptionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemExceptionData.cs | DTO | 7 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemExceptionDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemExceptionDetailData.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemExceptionGrouped.cs | DTO | 3 unused using statements |
| ItemExceptionGroupedData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemExceptionHelper.cs | Helper | 7 unused using statements |
| ItemExceptionLabelInfo.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemExceptionReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemExceptionReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemExceptionReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemExceptionReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemExceptionReasonDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 2 unused using statements |
| ItemExceptionReasonIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ItemExceptionRepository.cs | Repository | 5 commented code lines, 6 unused using statements |
| ItemExceptionResponseContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ItemExceptionsDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstance.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemInstance.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceContract.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemInstanceData.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstanceData.cs | DTO | 22 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemInstanceDataContract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstanceDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstanceHelpers.cs | Helper | 8 unused using statements |
| ItemInstanceHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemInstanceHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceHistoryData.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemInstanceHistoryType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemInstanceHistoryType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceHistoryTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceHistoryTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceHistoryTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ItemInstanceIdDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstanceIdentifier.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemInstanceIdentifier.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemInstanceIdentifierType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemInstanceIdentifierType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemInstanceIdentifierTypeIdentifier.cs | Enum | 3 unused using statements |
| ItemInstancesDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemMaster.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemMaster.cs | DTO | 23 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| ItemMasterAlias.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemMasterAlias.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterAliasContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterAliasData.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemMasterBlueprint.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemMasterBlueprint.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterBlueprintContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterBlueprintData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterCosting.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemMasterCosting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterCostingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterCostingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterData.cs | DTO | 14 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| ItemMasterDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemMasterDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionGroup.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemMasterDefinitionGroup.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionGroupContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionGroupData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterDefinitionTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ItemMasterDetailsModel.cs | DTO | 3 unused using statements |
| ItemMasterPrice.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemMasterPrice.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemMasterPriceContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemMasterPriceData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ItemMasterRepository.cs | Repository | 2 commented code lines, 6 unused using statements |
| ItemMasterStockLevelDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemMasterSummary.cs | DTO | 3 unused using statements |
| ItemNotesTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ItemProcessingDetails.cs | Helper | 7 unused using statements |
| ItemRebuildList.cs | DTO | 7 commented code lines, 3 unused using statements |
| ItemRebuildList.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemRebuildListContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemRebuildListData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ItemScanDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ItemScanResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ItemStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ItemStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ItemSubtypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ItemSummary.cs | DTO | 2 unused using statements |
| ItemType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 3 unused using statements |
| ItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ItemTypeData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| ItemTypeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemTypeExtensions.cs | Helper | 6 unused using statements |
| ItemTypeFeatureIdentifiers.cs | Enum | 30 commented code lines, 3 unused using statements |
| ItemTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ItemTypeInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemTypeRepository.cs | Repository | 2 commented code lines, 6 unused using statements |
| ItemTypeSummaryDetail.cs | DTO | 3 unused using statements |
| ItemTypeSummaryDetailData.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemTypeTurnaroundsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ItemTypeTurnaroundsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ItemUsageData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ItemsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| JobInfo.cs | DTO | 3 unused using statements |
| JobListModel.cs | DTO | 3 unused using statements |
| Kernel.cs | Enum | 4 unused using statements |
| KeyValueDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| KeyValuePairModelDescription.cs | DTO | 3 unused using statements |
| KeyValuesDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| KnownCatalogueLoanSetState.cs | Enum | 3 unused using statements |
| KnownCatalogueLoanSetStatus.cs | Enum | 3 unused using statements |
| KnownCustomerLabelType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| KnownFacilitySetting.cs | Service | 4 commented code lines, 6 unused using statements |
| KnownFileType.cs | Enum | 3 unused using statements |
| KnownPermission.cs | DTO | 1 WCF attributes, 5 commented code lines, 3 unused using statements |
| KnownPrintType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| KnownTenancySetting.cs | Service | 11 commented code lines, 6 unused using statements |
| LabelContent.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| LabelDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| LabelDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LabelDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabelDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabelDefinitionRepository.cs | Repository | 6 unused using statements |
| LabelType.cs | DTO | 7 commented code lines, 2 unused using statements |
| LabelType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LabelTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabelTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabelTypeRepository.cs | Repository | 6 unused using statements |
| LabourBand.cs | DTO | 7 commented code lines, 2 unused using statements |
| LabourBand.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LabourBandContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabourBandData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| LabourLevel.cs | DTO | 7 commented code lines, 2 unused using statements |
| LabourLevel.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LabourLevelContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabourLevelData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LabourTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Language.cs | Service | 9 unused using statements |
| LastBatchRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| LayoutConstants.cs | Enum | 3 unused using statements |
| LazyAbandonReasonHelper.cs | Helper | 6 unused using statements |
| LazyAddressHelper.cs | Helper | 7 unused using statements |
| LazyAlertHelper.cs | Helper | 6 unused using statements |
| LazyAlertTypeHelper.cs | Helper | 6 unused using statements |
| LazyAppTypeHelper.cs | Helper | 6 unused using statements |
| LazyAuditLineExceptionReasonHelper.cs | Helper | 6 unused using statements |
| LazyAuditLineStatusTypeHelper.cs | Helper | 6 unused using statements |
| LazyAuditProcessFaultReasonHelper.cs | Helper | 6 unused using statements |
| LazyAuditResultTypeHelper.cs | Helper | 6 unused using statements |
| LazyAuditRuleHelper.cs | Helper | 7 unused using statements |
| LazyAuditTypeHelper.cs | Helper | 6 unused using statements |
| LazyBatchArchiveReasonHelper.cs | Helper | 6 unused using statements |
| LazyBatchCycleHelper.cs | Helper | 6 unused using statements |
| LazyBatchDecontaminationTaskHelper.cs | Helper | 7 unused using statements |
| LazyBatchFailureReasonHelper.cs | Helper | 6 unused using statements |
| LazyBatchHelper.cs | Helper | 7 unused using statements |
| LazyBatchStatusHelper.cs | Helper | 6 unused using statements |
| LazyBatchSterilisationTestReportHelper.cs | Helper | 7 unused using statements |
| LazyBiologicalIndicatorTestHelper.cs | Helper | 7 unused using statements |
| LazyBiologicalIndicatorTestStatusHelper.cs | Helper | 6 unused using statements |
| LazyCatalogueEditorHelper.cs | Helper | 7 unused using statements |
| LazyCategoryHelper.cs | Helper | 6 unused using statements |
| LazyChangeControlNoteHelper.cs | Helper | 7 unused using statements |
| LazyChargeHelper.cs | Helper | 7 unused using statements |
| LazyChargeListCategoryHelper.cs | Helper | 6 unused using statements |
| LazyChargeListHelper.cs | Helper | 6 unused using statements |
| LazyChargeReoccurringHelper.cs | Helper | 7 unused using statements |
| LazyClientSettingsHelper.cs | Helper | 7 unused using statements |
| LazyClockingConfigurationTypeHelper.cs | Helper | 6 unused using statements |
| LazyClockingEventTypeHelper.cs | Helper | 6 unused using statements |
| LazyCommentHelper.cs | Helper | 6 unused using statements |
| LazyCommunicationTypeHelper.cs | Helper | 6 unused using statements |
| LazyComplexityHelper.cs | Helper | 6 unused using statements |
| LazyConfigurableListTypeHelper.cs | Helper | 7 unused using statements |
| LazyConfigurableListValueHelper.cs | Helper | 7 unused using statements |
| LazyContactHelper.cs | Helper | 7 unused using statements |
| LazyContainerContentHelper.cs | Helper | 7 unused using statements |
| LazyContainerContentNoteHelper.cs | Helper | 6 unused using statements |
| LazyContainerInstanceHelper.cs | Helper | 6 unused using statements |
| LazyContainerInstanceIdentifierHelper.cs | Helper | 7 unused using statements |
| LazyContainerInstanceIdentifierTypeHelper.cs | Helper | 6 unused using statements |
| LazyContainerInstanceLabelAuditHelper.cs | Helper | 7 unused using statements |
| LazyContainerInstanceWeightHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterBlueprintHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterDefinitionAuditRuleHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterDefinitionMaintenanceCapacityHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterDefinitionMaintenanceCapacityTypeHelper.cs | Helper | 6 unused using statements |
| LazyContainerMasterHelper.cs | Helper | 1 commented code lines, 6 unused using statements |
| LazyContainerMasterNoteAuditHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterNoteHelper.cs | Helper | 6 unused using statements |
| LazyContainerMasterNoteStationTypeHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterNoteTypeHelper.cs | Helper | 6 unused using statements |
| LazyContainerMasterPriceAdjustmentHelper.cs | Helper | 6 unused using statements |
| LazyContainerMasterPriceAdjustmentTypeHelper.cs | Helper | 6 unused using statements |
| LazyContainerMasterPriceFullHelper.cs | Helper | 7 unused using statements |
| LazyContainerMasterPriceHelper.cs | Helper | 7 unused using statements |
| LazyContractHelper.cs | DTO | 3 unused using statements |
| LazyContractVendorMaintenanceHelper.cs | DTO | 4 unused using statements |
| LazyContractedHoursHelper.cs | DTO | 4 unused using statements |
| LazyCostingModelHelper.cs | DTO | 4 unused using statements |
| LazyCostingModelItemTypeHelper.cs | DTO | 4 unused using statements |
| LazyCostingModelTypeHelper.cs | DTO | 3 unused using statements |
| LazyCourierHelper.cs | Helper | 6 unused using statements |
| LazyCultureHelper.cs | Helper | 6 unused using statements |
| LazyCurrentTurnaroundEventHelper.cs | Helper | 7 unused using statements |
| LazyCustomStationeryHelper.cs | Helper | 7 unused using statements |
| LazyCustomStationeryLogicHelper.cs | Helper | 7 unused using statements |
| LazyCustomerDefectHelper.cs | Helper | 7 unused using statements |
| LazyCustomerDefectInformationHelper.cs | Helper | 7 unused using statements |
| LazyCustomerDefectReasonHelper.cs | Helper | 6 unused using statements |
| LazyCustomerDefectStatusHelper.cs | Helper | 6 unused using statements |
| LazyCustomerDefectStatusWorkflowHelper.cs | Helper | 7 unused using statements |
| LazyCustomerDefinitionGS1Helper.cs | Helper | 7 unused using statements |
| LazyCustomerDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyCustomerGroupHelper.cs | Helper | 6 unused using statements |
| LazyCustomerHelper.cs | Helper | 3 commented code lines, 6 unused using statements |
| LazyCustomerItemTypeHelper.cs | Helper | 7 unused using statements |
| LazyCustomerSettingHelper.cs | Helper | 7 unused using statements |
| LazyCustomerStatusHelper.cs | Helper | 6 unused using statements |
| LazyCustomerWorkflowHelper.cs | Helper | 7 unused using statements |
| LazyCustomisableTableHelper.cs | Helper | 7 unused using statements |
| LazyCycleParameterActivityTypeHelper.cs | Helper | 6 unused using statements |
| LazyCycleParameterAirRemovalHelper.cs | Helper | 7 unused using statements |
| LazyCycleParameterChamberHelper.cs | Helper | 6 unused using statements |
| LazyCycleParameterDetailHelper.cs | Helper | 7 unused using statements |
| LazyCycleParameterHelper.cs | Helper | 7 unused using statements |
| LazyDateTimeFormatHelper.cs | Helper | 7 unused using statements |
| LazyDecontaminationTaskHelper.cs | Helper | 6 unused using statements |
| LazyDecontaminationTaskItemTypeHelper.cs | Helper | 7 unused using statements |
| LazyDecontaminationTaskTimeHelper.cs | Helper | 7 unused using statements |
| LazyDefectAuditHistoryHelper.cs | Helper | 7 unused using statements |
| LazyDefectCategoryHelper.cs | Helper | 7 unused using statements |
| LazyDefectClassificationHelper.cs | Helper | 6 unused using statements |
| LazyDefectHelper.cs | Helper | 7 unused using statements |
| LazyDefectResponsibilityHelper.cs | Helper | 6 unused using statements |
| LazyDefectSeverityHelper.cs | Helper | 6 unused using statements |
| LazyDefectStatusHelper.cs | Helper | 6 unused using statements |
| LazyDefectTurnaroundEventHelper.cs | Helper | 7 unused using statements |
| LazyDefinitionTypeHelper.cs | Helper | 6 unused using statements |
| LazyDelayedBiTestTypeHelper.cs | Helper | 6 unused using statements |
| LazyDeliveryNoteHelper.cs | Helper | 7 unused using statements |
| LazyDeliveryPointHelper.cs | Helper | 6 unused using statements |
| LazyDeliveryTypeHelper.cs | Helper | 6 unused using statements |
| LazyDeniedTurnaroundEventHelper.cs | Helper | 7 unused using statements |
| LazyDeniedTurnaroundEventReasonHelper.cs | Helper | 6 unused using statements |
| LazyDirectorateHelper.cs | Helper | 6 unused using statements |
| LazyDocumentAuditHelper.cs | Helper | 7 unused using statements |
| LazyDocumentHelper.cs | Helper | 7 unused using statements |
| LazyEnquiryHelper.cs | Helper | 7 unused using statements |
| LazyEnquiryStatusHelper.cs | Helper | 6 unused using statements |
| LazyEventTypeCategoryHelper.cs | Helper | 7 unused using statements |
| LazyEventTypeGroupHelper.cs | Helper | 7 unused using statements |
| LazyEventTypeHelper.cs | Helper | 6 unused using statements |
| LazyEventTypeStationTypeHelper.cs | Helper | 7 unused using statements |
| LazyExpiryCalculationTypeHelper.cs | Helper | 6 unused using statements |
| LazyFacilityAuditRuleHelper.cs | Helper | 7 unused using statements |
| LazyFacilityHelper.cs | Helper | 1 commented code lines, 6 unused using statements |
| LazyFacilityItemTypeHelper.cs | Helper | 1 commented code lines, 7 unused using statements |
| LazyFacilityNoteHelper.cs | Helper | 6 unused using statements |
| LazyFacilitySettingHelper.cs | Helper | 7 unused using statements |
| LazyFacilityTypeHelper.cs | Helper | 6 unused using statements |
| LazyFailedBatchHelper.cs | Helper | 7 unused using statements |
| LazyFailedScanHelper.cs | Helper | 7 unused using statements |
| LazyFailedWashHelper.cs | Helper | 7 unused using statements |
| LazyFailedWashInstrumentHelper.cs | Helper | 7 unused using statements |
| LazyFailureTypeEventTypeHelper.cs | Helper | 7 unused using statements |
| LazyFailureTypeHelper.cs | Helper | 6 unused using statements |
| LazyFastTrackRequestHelper.cs | DTO | 3 unused using statements |
| LazyFastTrackRequestLineHelper.cs | DTO | 4 unused using statements |
| LazyFastTrackRequestStatusHelper.cs | DTO | 3 unused using statements |
| LazyFavouriteReportHelper.cs | Helper | 7 unused using statements |
| LazyFavouriteReportParameterHelper.cs | Helper | 7 unused using statements |
| LazyFavouriteReportParameterValueHelper.cs | Helper | 7 unused using statements |
| LazyFinanceHelper.cs | Helper | 220 commented code lines, 9 unused using statements |
| LazyFinancialCalendarHelper.cs | Helper | 7 unused using statements |
| LazyFormatHelper.cs | Helper | 6 unused using statements |
| LazyFormatTypeHelper.cs | Helper | 6 unused using statements |
| LazyHisDataCrossMatchTypeHelper.cs | Helper | 6 unused using statements |
| LazyHisDataCrossMatchingHelper.cs | Helper | 7 unused using statements |
| LazyHisMessageHelper.cs | Helper | 7 unused using statements |
| LazyHisOrderHelper.cs | Helper | 7 unused using statements |
| LazyHisOrderLineHelper.cs | Helper | 7 unused using statements |
| LazyHisOrderNoteHelper.cs | Helper | 6 unused using statements |
| LazyHubHelper.cs | Helper | 6 unused using statements |
| LazyIndexationCategoryHelper.cs | Helper | 6 unused using statements |
| LazyIndexationHelper.cs | Helper | 6 unused using statements |
| LazyIndexationTypeHelper.cs | Helper | 6 unused using statements |
| LazyIndividualInstrumentTrackingEventHelper.cs | Helper | 7 unused using statements |
| LazyIndividualInstrumentTrackingEventTypeHelper.cs | Helper | 6 unused using statements |
| LazyInvoiceHelper.cs | Helper | 7 unused using statements |
| LazyInvoiceLineHelper.cs | Helper | 8 commented code lines, 7 unused using statements |
| LazyInvoicePeriodHelper.cs | Helper | 6 unused using statements |
| LazyInvoiceScheduleHelper.cs | Helper | 7 unused using statements |
| LazyInvoiceStatusAuditHistoryHelper.cs | Helper | 7 unused using statements |
| LazyInvoiceStatusHelper.cs | Helper | 6 unused using statements |
| LazyInvoiceStatusWorkflowHelper.cs | Helper | 7 unused using statements |
| LazyItemExceptionHelper.cs | Helper | 7 unused using statements |
| LazyItemExceptionReasonHelper.cs | Helper | 6 unused using statements |
| LazyItemInstanceHelper.cs | Helper | 7 unused using statements |
| LazyItemInstanceHistoryHelper.cs | Helper | 7 unused using statements |
| LazyItemInstanceHistoryTypeHelper.cs | Helper | 6 unused using statements |
| LazyItemInstanceIdentifierHelper.cs | Helper | 7 unused using statements |
| LazyItemInstanceIdentifierTypeHelper.cs | Helper | 6 unused using statements |
| LazyItemMasterAliasHelper.cs | Helper | 6 unused using statements |
| LazyItemMasterBlueprintHelper.cs | Helper | 7 unused using statements |
| LazyItemMasterCostingHelper.cs | Helper | 7 unused using statements |
| LazyItemMasterDefinitionGroupHelper.cs | Helper | 6 unused using statements |
| LazyItemMasterDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyItemMasterHelper.cs | Helper | 6 unused using statements |
| LazyItemMasterPriceHelper.cs | Helper | 7 unused using statements |
| LazyItemRebuildListHelper.cs | Helper | 7 unused using statements |
| LazyItemStatusHelper.cs | Helper | 6 unused using statements |
| LazyItemTypeHelper.cs | Helper | 6 unused using statements |
| LazyLabelDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyLabelTypeHelper.cs | Helper | 6 unused using statements |
| LazyLabourBandHelper.cs | Helper | 6 unused using statements |
| LazyLabourLevelHelper.cs | Helper | 6 unused using statements |
| LazyLeafHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetAuditHistoryHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetContentProcessParametersHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetContentsHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetExternalReferenceHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetProcessAcceptanceHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetRequiredOnHelper.cs | Helper | 7 unused using statements |
| LazyLoanSetStatusHelper.cs | Helper | 6 unused using statements |
| LazyLocationHelper.cs | Helper | 6 unused using statements |
| LazyLocationTreeHelper.cs | Helper | 7 unused using statements |
| LazyLocationTypeHelper.cs | Helper | 6 unused using statements |
| LazyLoginAuditHelper.cs | Helper | 7 unused using statements |
| LazyLoginAuditTypeHelper.cs | Helper | 6 unused using statements |
| LazyMachineBatchCycleHelper.cs | Helper | 7 unused using statements |
| LazyMachineDetergentHelper.cs | Helper | 7 unused using statements |
| LazyMachineEventHelper.cs | Helper | 7 unused using statements |
| LazyMachineEventReasonHelper.cs | Helper | 6 unused using statements |
| LazyMachineEventTypeHelper.cs | Helper | 6 unused using statements |
| LazyMachineGroupHelper.cs | Helper | 6 unused using statements |
| LazyMachineHelper.cs | Helper | 6 unused using statements |
| LazyMachineSettingHelper.cs | Helper | 7 unused using statements |
| LazyMachineStationHelper.cs | Helper | 7 unused using statements |
| LazyMachineTypeHelper.cs | Helper | 6 unused using statements |
| LazyMaintenanceActivityHelper.cs | Helper | 6 unused using statements |
| LazyMaintenanceInstrumentStatusHelper.cs | Helper | 6 unused using statements |
| LazyMaintenanceReportAuditHistoryHelper.cs | Helper | 7 unused using statements |
| LazyMaintenanceReportHelper.cs | Helper | 7 unused using statements |
| LazyMaintenanceReportInstrumentDetailHelper.cs | Helper | 1 commented code lines, 7 unused using statements |
| LazyMaintenanceReportSettingHelper.cs | Helper | 6 unused using statements |
| LazyMaintenanceReportStatusHelper.cs | Helper | 6 unused using statements |
| LazyMaintenanceTypeHelper.cs | Helper | 6 unused using statements |
| LazyManufacturerHelper.cs | Helper | 7 unused using statements |
| LazyMasterHelper.cs | Helper | 1 commented code lines, 8 unused using statements |
| LazyMastersHelper.cs | Helper | 6 unused using statements |
| LazyMultiFacilityProcessHandShakeHelper.cs | Helper | 7 unused using statements |
| LazyMultiFacilityProcessRestrictionHelper.cs | Helper | 7 unused using statements |
| LazyMultiFacilityProcessStatusHelper.cs | Helper | 6 unused using statements |
| LazyMultiFacilityProcessingHelper.cs | Helper | 7 unused using statements |
| LazyNoteHelper.cs | Helper | 8 unused using statements |
| LazyNotificationOutputHelper.cs | Helper | 7 unused using statements |
| LazyNotificationRuleHelper.cs | Helper | 7 unused using statements |
| LazyNotificationRuleHistoryHelper.cs | Helper | 7 unused using statements |
| LazyNotificationRuleOutcomeHelper.cs | Helper | 6 unused using statements |
| LazyObjectTypeHelper.cs | Helper | 6 unused using statements |
| LazyOrderHelper.cs | Helper | 7 unused using statements |
| LazyOrderLineHelper.cs | Helper | 7 unused using statements |
| LazyOrderLineStatusHelper.cs | Helper | 6 unused using statements |
| LazyOrderNoteHelper.cs | Helper | 6 unused using statements |
| LazyOrderStatusHelper.cs | Helper | 6 unused using statements |
| LazyOrderStatusHistoryHelper.cs | Helper | 7 unused using statements |
| LazyOrderTemplateHelper.cs | Helper | 7 unused using statements |
| LazyOrderTemplateLineHelper.cs | Helper | 7 unused using statements |
| LazyOutputTypeHelper.cs | Helper | 6 unused using statements |
| LazyOwnerConfigurableListValueHelper.cs | Helper | 7 unused using statements |
| LazyOwnerHelper.cs | Helper | 7 unused using statements |
| LazyOwnerMaintenanceReportSettingHelper.cs | Helper | 7 unused using statements |
| LazyOwnerReportAccessHelper.cs | Helper | 7 unused using statements |
| LazyPermissionHelper.cs | Helper | 6 unused using statements |
| LazyPinRequestReasonHelper.cs | DTO | 3 unused using statements |
| LazyPlannedMaintenanceFlagSettingsHelper.cs | Helper | 7 unused using statements |
| LazyPlannedMaintenanceRuleHelper.cs | Helper | 7 unused using statements |
| LazyPriceCategoryBatchCycleHelper.cs | Helper | 7 unused using statements |
| LazyPriceCategoryDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyPriceCategoryGroupHelper.cs | Helper | 6 unused using statements |
| LazyPriceCategoryGroupItemTypeHelper.cs | Helper | 7 unused using statements |
| LazyPriceCategoryHelper.cs | Helper | 6 unused using statements |
| LazyPrintContentTypeHelper.cs | Helper | 6 unused using statements |
| LazyPrintHandlerHelper.cs | Helper | 10 unused using statements |
| LazyPrintHistoryBatchHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryContentHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryDeliveryNoteHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryNotificationRuleHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryTurnaroundEventHelper.cs | Helper | 7 unused using statements |
| LazyPrintHistoryTurnaroundHelper.cs | Helper | 7 unused using statements |
| LazyPrinterHelper.cs | Helper | 6 unused using statements |
| LazyPrinterTypeHelper.cs | Helper | 6 unused using statements |
| LazyProcessParametersHelper.cs | Helper | 6 unused using statements |
| LazyProcessingModeHelper.cs | Helper | 6 unused using statements |
| LazyProcessingNoteHelper.cs | Helper | 6 unused using statements |
| LazyProcessingNoteStationTypeHelper.cs | Helper | 7 unused using statements |
| LazyProcessingNoteTypeHelper.cs | Helper | 6 unused using statements |
| LazyQualityHelper.cs | Helper | 6 unused using statements |
| LazyQuarantineReasonHelper.cs | Helper | 6 unused using statements |
| LazyRecipientTypeHelper.cs | Helper | 6 unused using statements |
| LazyRepairCategoryHelper.cs | Helper | 6 unused using statements |
| LazyReportCategoryHelper.cs | Helper | 6 unused using statements |
| LazyReportHelper.cs | Helper | 6 unused using statements |
| LazyReportOutputTypeHelper.cs | Helper | 7 unused using statements |
| LazyReportTypeHelper.cs | Helper | 6 unused using statements |
| LazyReportingHelper.cs | Helper | 8 commented code lines, 7 unused using statements |
| LazyRequiredWorkflowHelper.cs | Helper | 7 unused using statements |
| LazyRetrospectiveEventWhiteListHelper.cs | Helper | 7 unused using statements |
| LazyRoleHelper.cs | Helper | 6 unused using statements |
| LazyRolePermissionHelper.cs | Helper | 7 unused using statements |
| LazyScanTypeHelper.cs | Helper | 6 unused using statements |
| LazyScheduleHelper.cs | Helper | 6 unused using statements |
| LazySearchHelper.cs | Helper | 1 commented code lines, 6 unused using statements |
| LazySearchTermHelper.cs | Helper | 6 unused using statements |
| LazyServiceReportsHelper.cs | Helper | 7 unused using statements |
| LazyServiceRequirementContractedHoursHelper.cs | DTO | 4 unused using statements |
| LazyServiceRequirementDefinitionHelper.cs | Helper | 7 unused using statements |
| LazyServiceRequirementEventTypeHelper.cs | Helper | 7 unused using statements |
| LazyServiceRequirementExpiryWindowHelper.cs | Helper | 7 unused using statements |
| LazyServiceRequirementHelper.cs | Helper | 6 unused using statements |
| LazySingleInstrumentAuditHelper.cs | Helper | 7 unused using statements |
| LazySingleInstrumentAuditLineHelper.cs | Helper | 7 unused using statements |
| LazySingleInstrumentAuditProcessFaultHelper.cs | Helper | 7 unused using statements |
| LazySpecialityHelper.cs | Helper | 6 unused using statements |
| LazyStationDeliveryPointHelper.cs | Helper | 7 unused using statements |
| LazyStationHelper.cs | Helper | 6 unused using statements |
| LazyStationPrinterHelper.cs | Helper | 7 unused using statements |
| LazyStationTypeCategoryHelper.cs | Helper | 6 unused using statements |
| LazyStationTypeHelper.cs | Helper | 6 unused using statements |
| LazyStationTypeItemTypeHelper.cs | Helper | 7 unused using statements |
| LazySterilisationExpiryTimeHelper.cs | Helper | 7 unused using statements |
| LazySterilisationTemperatureHelper.cs | Helper | 6 unused using statements |
| LazySterilisationTestReportAuditHistoryHelper.cs | Helper | 7 unused using statements |
| LazySterilisationTestReportHelper.cs | Helper | 7 unused using statements |
| LazySterilisationTestReportStatusHelper.cs | Helper | 6 unused using statements |
| LazyStockMovementHelper.cs | Helper | 7 unused using statements |
| LazyStockTransactionHelper.cs | Helper | 8 unused using statements |
| LazyStockTransactionTypeHelper.cs | Helper | 6 unused using statements |
| LazyStocktakeActivityHelper.cs | Helper | 6 unused using statements |
| LazyStocktakeHistoryHelper.cs | Helper | 7 unused using statements |
| LazyStoragePointHelper.cs | Helper | 6 unused using statements |
| LazySurgeonHelper.cs | Helper | 7 unused using statements |
| LazySurgicalProcedureHelper.cs | Helper | 7 unused using statements |
| LazySurgicalProcedureTurnaroundHelper.cs | Helper | 7 unused using statements |
| LazySurgicalProcedureTypeHelper.cs | Helper | 7 unused using statements |
| LazySynergyCustomerHelper.cs | Helper | 209 commented code lines, 11 unused using statements |
| LazySystemSettingHelper.cs | Helper | 7 unused using statements |
| LazyTaskHelper.cs | Helper | 7 unused using statements |
| LazyTenancyCustomValueHelper.cs | Helper | 7 unused using statements |
| LazyTenancyHelper.cs | Helper | 6 unused using statements |
| LazyTenancySettingHelper.cs | Helper | 7 unused using statements |
| LazyTestReportTemperatureHelper.cs | Helper | 7 unused using statements |
| LazyTimeZoneHelper.cs | Helper | 6 unused using statements |
| LazyTransferNoteHelper.cs | Helper | 7 unused using statements |
| LazyTransferNoteLineHelper.cs | Helper | 7 unused using statements |
| LazyTranslationHelper.cs | Helper | 7 unused using statements |
| LazyTreeHelper.cs | Helper | 6 unused using statements |
| LazyTurnaroundAssignedHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundEventAcknowledgeNoteHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundEventFailureTypeHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundEventHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundEventReprintHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundEventWeightHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundFacilityHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundNoteHelper.cs | Helper | 6 unused using statements |
| LazyTurnaroundNoteStationTypeHelper.cs | Helper | 7 unused using statements |
| LazyTurnaroundWHHelper.cs | Helper | 7 unused using statements |
| LazyUserCategoryHelper.cs | Helper | 6 unused using statements |
| LazyUserClockingEventHelper.cs | Helper | 7 unused using statements |
| LazyUserComplexityHelper.cs | Helper | 7 unused using statements |
| LazyUserDeliveryPointHelper.cs | Helper | 7 unused using statements |
| LazyUserFacilityHelper.cs | Helper | 7 unused using statements |
| LazyUserHelper.cs | Helper | 6 unused using statements |
| LazyUserItemAuditCopyListHelper.cs | Helper | 7 unused using statements |
| LazyUserItemAuditHelper.cs | Helper | 7 unused using statements |
| LazyUserItemAuditTypeHelper.cs | Helper | 6 unused using statements |
| LazyUserPasswordHistoryHelper.cs | Helper | 7 unused using statements |
| LazyUserPermissionHelper.cs | Helper | 7 unused using statements |
| LazyUserPrinterHelper.cs | Helper | 7 unused using statements |
| LazyUserProductionManagerFilterHelper.cs | Helper | 7 unused using statements |
| LazyUserReportHelper.cs | Helper | 7 unused using statements |
| LazyUserRoleHelper.cs | Helper | 7 unused using statements |
| LazyUtilityHelper.cs | Helper | 13 unused using statements |
| LazyVendorContactHelper.cs | Helper | 7 unused using statements |
| LazyVendorFacilityHelper.cs | Helper | 7 unused using statements |
| LazyVendorHelper.cs | Helper | 6 unused using statements |
| LazyVendorMaintenanceActivityHelper.cs | Helper | 6 unused using statements |
| LazyVendorRepairCostHelper.cs | Helper | 7 unused using statements |
| LazyWarningHelper.cs | Helper | 6 unused using statements |
| LazyWashHelper.cs | Helper | 4 commented code lines, 11 unused using statements |
| LazyWorkflowHelper.cs | Helper | 7 unused using statements |
| Leaf.cs | DTO | 7 commented code lines, 3 unused using statements |
| Leaf.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LeafContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LeafData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LegacyEncryptionHelper.cs | Helper | 6 commented code lines, 7 unused using statements |
| LinqExtensions.cs | Helper | 8 commented code lines, 10 unused using statements |
| ListItem.cs | Service | 6 unused using statements |
| ListPriorityItemsDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ListTurnaroundsByTypeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| LoadTrolley.cs | Service | 8 unused using statements |
| LoanSet.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSet.cs | DTO | 5 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetApprovalProcessParameterTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| LoanSetAuditHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetAuditHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetAuditHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetAuditHistoryData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| LoanSetContentInstanceInfo.cs | DTO | 3 unused using statements |
| LoanSetContentProcessParameters.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetContentProcessParameters.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetContentProcessParametersContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetContentProcessParametersData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetContents.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetContents.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetContentsContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetContentsData.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| LoanSetContentsRepository.cs | Repository | 6 unused using statements |
| LoanSetContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetEmailModel.cs | DTO | 3 unused using statements |
| LoanSetExternalReference.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetExternalReference.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetExternalReferenceContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetExternalReferenceData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetModel.cs | DTO | 1 commented code lines, 4 unused using statements |
| LoanSetProcessAcceptance.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetProcessAcceptance.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetProcessAcceptanceContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetProcessAcceptanceData.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| LoanSetRecordData.cs | DTO | 40 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| LoanSetRecordData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetRequiredOn.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoanSetRequiredOn.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetRequiredOnContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetRequiredOnData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| LoanSetStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoanSetStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoanSetStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| LoanSetSummary.cs | DTO | 3 unused using statements |
| Location.cs | DTO | 7 commented code lines, 2 unused using statements |
| Location.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LocationClockingData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| LocationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LocationData.cs | DTO | 29 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| LocationDataContract.cs | DTO | 16 WCF attributes, 1 WCF using statements, 2 unused using statements |
| LocationInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| LocationRepository.cs | Repository | 6 unused using statements |
| LocationStatus.cs | DTO | 1 WCF attributes, 3 unused using statements |
| LocationTree.cs | DTO | 7 commented code lines, 3 unused using statements |
| LocationTree.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 3 unused using statements |
| LocationTreeContract.cs | DTO | 1 interface inheritances removed, 3 unused using statements |
| LocationTreeData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| LocationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| LocationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LocationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LocationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LocationTypeIdentifier.cs | DTO | 1 WCF attributes, 1 commented code lines, 3 unused using statements |
| LocationsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| Log.cs | Service | 10 commented code lines, 1 interface inheritances removed, 12 unused using statements |
| LogDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| LogDefect.cs | DTO | 17 WCF attributes, 1 WCF using statements, 3 unused using statements |
| LoginAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| LoginAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoginAuditContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoginAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoginAuditType.cs | DTO | 7 commented code lines, 2 unused using statements |
| LoginAuditType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| LoginAuditTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoginAuditTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| LoginAuditTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| LoginModel.cs | DTO | 4 unused using statements |
| Lookup.cs | DTO | 3 unused using statements |
| LookupData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MFPProductionOverviewData.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MLDDuplicateInstancesModel.cs | DTO | 3 unused using statements |
| MLDLoanerSwitcherooHelper.cs | Helper | 14 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 13 unused using statements |
| MLDMissedLoanKitLineModel.cs | DTO | 3 unused using statements |
| MLDQuarantineHelper.cs | Helper | 8 unused using statements |
| Machine.cs | DTO | 7 commented code lines, 2 unused using statements |
| Machine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineBatchCycle.cs | DTO | 7 commented code lines, 3 unused using statements |
| MachineBatchCycle.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineBatchCycleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineBatchCycleData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MachineBatchData.cs | DTO | 23 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineBatchDataContract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineBatchesRequestDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 5 unused using statements |
| MachineBatchesResponseDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| MachineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineData.cs | DTO | 10 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MachineDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineDetergent.cs | DTO | 7 commented code lines, 3 unused using statements |
| MachineDetergent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineDetergentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineDetergentData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineDetergentDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 4 unused using statements |
| MachineEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| MachineEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineEventData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MachineEventReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| MachineEventReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineEventReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineEventReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineEventReasonDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineEventType.cs | DTO | 7 commented code lines, 2 unused using statements |
| MachineEventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineEventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineEventTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineEventTypeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineEventTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| MachineGroup.cs | DTO | 7 commented code lines, 2 unused using statements |
| MachineGroup.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineGroupContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineGroupData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineGroupRepository.cs | Repository | 6 unused using statements |
| MachineIdRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| MachineInfo.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineIntegrationType.cs | Enum | 3 unused using statements |
| MachineRepository.cs | Repository | 4 commented code lines, 5 unused using statements |
| MachineSetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| MachineSetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineSettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineSettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineSettingRepository.cs | Repository | 7 unused using statements |
| MachineSettings.cs | Helper | 6 unused using statements |
| MachineStationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineStationData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineStatusDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineType.cs | DTO | 7 commented code lines, 2 unused using statements |
| MachineType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MachineTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MachineTypeDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MachineTypeIdentifier.cs | DTO | 1 WCF attributes, 1 commented code lines, 3 unused using statements |
| Main.cs | Service | 3 commented code lines, 8 unused using statements |
| MainViewModel.cs | DTO | 4 unused using statements |
| MaintenanceActivity.cs | DTO | 7 commented code lines, 2 unused using statements |
| MaintenanceActivity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceActivityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceActivityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceInstrumentStatu.cs | Service | 7 commented code lines, 5 unused using statements |
| MaintenanceInstrumentStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| MaintenanceInstrumentStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceInstrumentStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceInstrumentStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceInstrumentStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| MaintenancePriority.cs | DTO | 1 WCF attributes, 3 unused using statements |
| MaintenanceReport.cs | DTO | 7 commented code lines, 3 unused using statements |
| MaintenanceReport.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportAuditHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| MaintenanceReportAuditHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportAuditHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportAuditHistoryData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MaintenanceReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportData.cs | DTO | 24 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MaintenanceReportInfo.cs | DTO | 18 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MaintenanceReportInstrumentDetail.cs | DTO | 7 commented code lines, 3 unused using statements |
| MaintenanceReportInstrumentDetail.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportInstrumentDetailContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportInstrumentDetailData.cs | DTO | 7 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MaintenanceReportInstrumentListData.cs | DTO | 23 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MaintenanceReportLineInfo.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MaintenanceReportSetting.cs | DTO | 7 commented code lines, 2 unused using statements |
| MaintenanceReportSetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportSetting.cs | DTO | 1 WCF attributes, 3 unused using statements |
| MaintenanceReportSettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportSettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| MaintenanceReportStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceReportStatusTypeIdentifier.cs | DTO | 2 WCF attributes, 3 unused using statements |
| MaintenanceRuleData.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MaintenanceRulesDropDownList.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| MaintenanceType.cs | DTO | 7 commented code lines, 2 unused using statements |
| MaintenanceType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MaintenanceTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MaintenanceTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Manufacturer.cs | DTO | 7 commented code lines, 3 unused using statements |
| Manufacturer.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ManufacturerContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ManufacturerData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ManufacturerDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ManufacturerHelper.cs | Helper | 8 unused using statements |
| Master.cs | DTO | 6 commented code lines, 4 unused using statements |
| MasterCollection.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MasterCollectionData.cs | DTO | 25 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MasterData.cs | DTO | 51 WCF attributes, 1 WCF using statements, 3 unused using statements |
| MasterDataAdapter.cs | Service | 10 unused using statements |
| MasterIdTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| MasterInstanceTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| MasterParametersData.cs | DTO | 10 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MasterRepository.cs | Repository | 1 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| Masters.cs | DTO | 7 commented code lines, 2 unused using statements |
| Masters.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MastersContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MastersData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MethodStatusAttribute.cs | Enum | 3 unused using statements |
| MissingIndexInfo.cs | DTO | 3 unused using statements |
| ModelDescription.cs | DTO | 3 unused using statements |
| ModelDescriptionGenerator.cs | DTO | 13 commented code lines, 1 WCF using statements, 11 unused using statements |
| ModelNameAttribute.cs | DTO | 3 unused using statements |
| ModelNameHelper.cs | DTO | 3 commented code lines, 5 unused using statements |
| ModelStateDictionaryExtensions.cs | DTO | 5 unused using statements |
| ModelStateExtensions.cs | DTO | 5 unused using statements |
| MultiFacilityProcessHandShake.cs | DTO | 7 commented code lines, 3 unused using statements |
| MultiFacilityProcessHandShake.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessHandShakeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessHandShakeData.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MultiFacilityProcessRestriction.cs | DTO | 7 commented code lines, 3 unused using statements |
| MultiFacilityProcessRestriction.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessRestrictionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessRestrictionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| MultiFacilityProcessStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessStatus.cs | Enum | 3 unused using statements |
| MultiFacilityProcessStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessing.cs | DTO | 7 commented code lines, 3 unused using statements |
| MultiFacilityProcessing.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| MultiFacilityProcessingData.cs | DTO | 14 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| MultiFacilityProcessingRepository.cs | Repository | 6 unused using statements |
| NamedReference.cs | DTO | 3 unused using statements |
| NavigationViewModel.cs | DTO | 3 unused using statements |
| NoteDataContract.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| NoteHelper.cs | Helper | 7 unused using statements |
| NoteStationTypeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| NotesDatabaseHelper.cs | Helper | 1 commented code lines, 1 interface inheritances removed, 6 unused using statements |
| NoticeModel.cs | DTO | 3 unused using statements |
| NoticeWidgetModel.cs | DTO | 3 unused using statements |
| NotificationEngineHelper.cs | Helper | 27 commented code lines, 1 interface inheritances removed, 12 unused using statements |
| NotificationOutput.cs | DTO | 7 commented code lines, 3 unused using statements |
| NotificationOutput.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| NotificationOutputContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationOutputData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| NotificationRule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| NotificationRuleHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleOutcome.cs | DTO | 7 commented code lines, 2 unused using statements |
| NotificationRuleOutcome.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleOutcomeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleOutcomeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| NotificationRuleOutcomeIdentifier.cs | Enum | 3 unused using statements |
| NotificationTypeIdentifier.cs | Enum | 3 unused using statements |
| OOATrolleyDispatchHelper.cs | Helper | 2 commented code lines, 1 interface inheritances removed, 11 unused using statements |
| ObjectExtensions.cs | Helper | 7 unused using statements |
| ObjectGenerator.cs | Service | 5 commented code lines, 9 unused using statements |
| ObjectQueryExtensions.cs | Helper | 9 unused using statements |
| ObjectType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ObjectType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ObjectTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ObjectTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearch.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearch.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearch.cs | DTO | 4 unused using statements |
| OmniSearchBatchDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchBatchDetailData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchCustomerDetail.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchCustomerDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchCustomerDetailData.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchData.cs | DTO | 13 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OmniSearchDefectsDetail.cs | DTO | 16 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchDefectsDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchDefectsDetailData.cs | DTO | 19 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchDeliveryNotesDetail.cs | DTO | 15 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchDeliveryNotesDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchDeliveryNotesDetailData.cs | DTO | 16 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OmniSearchDeliveryPointDetail.cs | DTO | 1 interface inheritances removed, 3 unused using statements |
| OmniSearchDeliveryPointDetailData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchFacilityDetail.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| OmniSearchFacilityDetail.cs | DTO | 1 interface inheritances removed, 3 unused using statements |
| OmniSearchFacilityDetailData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchInstanceDetail.cs | DTO | 10 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchInstanceDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchInstanceDetailData.cs | DTO | 18 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchItemDetail.cs | DTO | 12 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchItemDetail.cs | DTO | 10 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OmniSearchItemDetailData.cs | DTO | 14 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OmniSearchLoanSetDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchLoanSetsDetailData.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchRepository.cs | Repository | 1 commented code lines, 7 unused using statements |
| OmniSearchSummary.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| OmniSearchSummary.cs | DTO | 1 interface inheritances removed, 3 unused using statements |
| OmniSearchSummaryData.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OmniSearchTurnaroundDetail.cs | DTO | 17 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchTurnaroundDetail.cs | DTO | 2 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OmniSearchTurnaroundDetailData.cs | DTO | 23 WCF attributes, 3 commented code lines, 1 WCF using statements, 3 unused using statements |
| OmniSearchType.cs | DTO | 1 WCF attributes, 2 commented code lines, 3 unused using statements |
| OmniSearchUserDetail.cs | DTO | 9 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OmniSearchUserDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OmniSearchUserDetailData.cs | DTO | 11 WCF attributes, 1 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OperationResponseContract.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| OperativeModelContainer.cs | DTO | 4 unused using statements |
| OperativeModelInterfaces.cs | DTO | 3 unused using statements |
| Operative_GetBiTests_PriorityList_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| Order.cs | DTO | 7 commented code lines, 3 unused using statements |
| Order.cs | DTO | 6 commented code lines, 1 interface inheritances removed, 3 unused using statements |
| Order.cs | Helper | 14 commented code lines, 10 unused using statements |
| OrderBatchModel.cs | DTO | 3 unused using statements |
| OrderContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderData.cs | DTO | 22 WCF attributes, 1 WCF using statements, 5 unused using statements |
| OrderDateData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderDemand.cs | DTO | 13 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderDemandDate.cs | DTO | 3 unused using statements |
| OrderDetailsModel.cs | DTO | 3 unused using statements |
| OrderEmailModel.cs | DTO | 3 unused using statements |
| OrderHelper.cs | Helper | 3 commented code lines, 10 unused using statements |
| OrderIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| OrderInfo.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| OrderLine.cs | DTO | 5 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderLine.cs | Helper | 18 commented code lines, 10 unused using statements |
| OrderLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderLineData.cs | DTO | 14 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLineData.cs | DTO | 29 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLineDataContract.cs | DTO | 24 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLineHelper.cs | Helper | 6 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 11 unused using statements |
| OrderLineHoldStatusData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| OrderLineInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLineLocationsData.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderLineManagementRequest.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| OrderLineRepository.cs | Repository | 1 commented code lines, 5 unused using statements |
| OrderLineStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| OrderLineStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderLineStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderLineStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderLineStatusData.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| OrderLineStatusIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| OrderLinesData.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderList.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderManagementDataContract.cs | DTO | 22 WCF attributes, 1 WCF using statements, 4 unused using statements |
| OrderManagementRequest.cs | DTO | 10 WCF attributes, 1 commented code lines, 1 WCF using statements, 5 unused using statements |
| OrderManagementScanDetails.cs | DTO | 1 WCF attributes, 1 WCF using statements, 4 unused using statements |
| OrderModel.cs | DTO | 3 unused using statements |
| OrderNote.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| OrderNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| OrderNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderNoteDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| OrderPickListPrintDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| OrderRequest.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderRequestLine.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderReviewModel.cs | DTO | 3 unused using statements |
| OrderShippingDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| OrderSourceIdentifier.cs | Enum | 3 unused using statements |
| OrderStationData.cs | DTO | 17 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| OrderStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderStatusData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 2 unused using statements |
| OrderStatusHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| OrderStatusHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderStatusHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderStatusHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderStatusHistoryData.cs | DTO | 11 WCF attributes, 1 WCF using statements, 4 unused using statements |
| OrderStatusIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| OrderSummary.cs | DTO | 3 unused using statements |
| OrderTemplate.cs | DTO | 7 commented code lines, 3 unused using statements |
| OrderTemplate.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateData.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderTemplateInfo.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderTemplateLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| OrderTemplateLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OrderTemplateLineData.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderTemplateLineInfo.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OrderTypes.cs | Enum | 3 unused using statements |
| Orders.cs | Service | 1 commented code lines, 9 unused using statements |
| OutOfQuarantineData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OutputType.cs | DTO | 7 commented code lines, 2 unused using statements |
| OutputType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OutputTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OutputTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OutputTypeIdentifier.cs | Enum | 3 unused using statements |
| OwnSetting.cs | DTO | 3 unused using statements |
| Owner.cs | DTO | 7 commented code lines, 3 unused using statements |
| Owner.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OwnerConfigurableListValue.cs | DTO | 7 commented code lines, 3 unused using statements |
| OwnerConfigurableListValue.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OwnerConfigurableListValueContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerConfigurableListValueData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerMaintenanceReportSetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| OwnerMaintenanceReportSetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OwnerMaintenanceReportSettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerMaintenanceReportSettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerMaintenanceReportSettingDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OwnerMaintenanceReportSettingRepository.cs | Repository | 4 commented code lines, 6 unused using statements |
| OwnerReportAccess.cs | DTO | 7 commented code lines, 3 unused using statements |
| OwnerReportAccess.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| OwnerReportAccessContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerReportAccessData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| OwnerRepository.cs | Repository | 6 unused using statements |
| OwnerResultData.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| OwnerSettingInfo.cs | DTO | 3 unused using statements |
| OwnerSettingsDetail.cs | DTO | 3 unused using statements |
| OwnerSettingsIndex.cs | DTO | 3 unused using statements |
| PDFContent.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PDFReport.cs | Helper | 7 unused using statements |
| PackingTurnaroundEventData.cs | DTO | 30 WCF attributes, 1 WCF using statements, 4 unused using statements |
| PagedMasters_Result.cs | DTO | 7 commented code lines, 2 unused using statements |
| ParameterAnnotation.cs | DTO | 3 unused using statements |
| ParameterDescription.cs | DTO | 4 unused using statements |
| ParentTurnaroundDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Pathway.Context.cs | DTO | 7 commented code lines, 2 unused using statements |
| Pathway.cs | DTO | 7 commented code lines, 3 unused using statements |
| PathwayException.cs | Service | 6 unused using statements |
| PathwayRepository.cs | Repository | 1 interface inheritances removed, 5 unused using statements |
| PathwayWarehouseRepository.cs | Repository | 3 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 7 unused using statements |
| PdfHelper.cs | Helper | 9 unused using statements |
| PegaCaseRequest.cs | DTO | 41 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PegaCaseResponse.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| PegaCaseValidationResult.cs | DTO | 4 unused using statements |
| PegaLoanSetEmailModel.cs | DTO | 4 unused using statements |
| PerformanceCentreHelpers.cs | Helper | 7 unused using statements |
| PerformanceUpdateState.cs | Enum | 3 unused using statements |
| Permission.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Permission.cs | DTO | 7 commented code lines, 2 unused using statements |
| PermissionAreaIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| PermissionCheck.cs | Enum | 3 unused using statements |
| PermissionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PermissionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PermissionDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PermissionIdentifier.cs | DTO | 1 WCF attributes, 75 commented code lines, 3 unused using statements |
| PermissionRightIdentifiers.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| PickStockViewModel.cs | DTO | 5 unused using statements |
| PictureType.cs | Enum | 3 unused using statements |
| PinReasonDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PinRequestReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PinRequestReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| PinRequestReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PinRequestReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PlainTag.cs | Service | 9 commented code lines, 8 unused using statements |
| PlainTagPrintHandler.cs | Service | 2 commented code lines, 8 unused using statements |
| PlannedMaintenance.cs | Service | 1 commented code lines, 12 unused using statements |
| PlannedMaintenanceDataContract.cs | DTO | 17 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PlannedMaintenanceFlagSettings.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PlannedMaintenanceFlagSettings.cs | DTO | 7 commented code lines, 3 unused using statements |
| PlannedMaintenanceFlagSettingsContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PlannedMaintenanceFlagSettingsData.cs | DTO | 2 WCF attributes, 1 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PlannedMaintenanceFlagSettingsRepository.cs | Repository | 6 unused using statements |
| PlannedMaintenanceReportData.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PlannedMaintenanceRule.cs | DTO | 5 commented code lines, 1 interface inheritances removed, 3 unused using statements |
| PlannedMaintenanceRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| PlannedMaintenanceRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PlannedMaintenanceRuleData.cs | DTO | 15 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| PlannedMaintenanceRulesType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| PreSearchContainerInstanceData.cs | DTO | 11 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PriceCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PriceCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| PriceCategoryBatchCycle.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryBatchCycle.cs | DTO | 7 commented code lines, 3 unused using statements |
| PriceCategoryBatchCycleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryBatchCycleData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PriceCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryData.cs | DTO | 3 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PriceCategoryDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| PriceCategoryDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryGroup.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryGroup.cs | DTO | 7 commented code lines, 2 unused using statements |
| PriceCategoryGroupContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryGroupData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PriceCategoryGroupItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryGroupItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| PriceCategoryGroupItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceCategoryGroupItemTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PriceModelResources.cs | DTO | 3 unused using statements |
| Print.cs | Service | 8 unused using statements |
| PrintContentType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintContentType.cs | DTO | 7 commented code lines, 2 unused using statements |
| PrintContentTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintContentTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintContentTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| PrintDetailsDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PrintEventHandler.cs | Service | 24 commented code lines, 15 unused using statements, Fixed 1 missing closing braces |
| PrintFactory.cs | Service | 6 unused using statements |
| PrintHandlerBase.cs | Service | 1 interface inheritances removed, 9 unused using statements |
| PrintHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryBatch.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryBatch.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryBatchContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryBatchData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryBatchModel.cs | DTO | 3 unused using statements |
| PrintHistoryContent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryContent.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryContentContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryContentData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryContentDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| PrintHistoryContentModel.cs | DTO | 5 unused using statements |
| PrintHistoryContentRepository.cs | Repository | 6 unused using statements |
| PrintHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryDeliveryNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryDeliveryNote.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryDeliveryNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryDeliveryNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryDeliveryNoteModel.cs | DTO | 4 unused using statements |
| PrintHistoryHelper.cs | Helper | 3 commented code lines, 13 unused using statements |
| PrintHistoryModel.cs | DTO | 5 unused using statements |
| PrintHistoryNotificationRule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryNotificationRule.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryNotificationRuleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryNotificationRuleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryNotificationRuleModel.cs | DTO | 4 unused using statements |
| PrintHistoryPrinterType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| PrintHistoryRepository.cs | Repository | 6 unused using statements |
| PrintHistoryTurnaround.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaround.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryTurnaroundContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaroundData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaroundEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaroundEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| PrintHistoryTurnaroundEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaroundEventData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrintHistoryTurnaroundEventModel.cs | DTO | 3 unused using statements |
| PrintHistoryTurnaroundModel.cs | DTO | 3 unused using statements |
| PrintItem.cs | Helper | 7 unused using statements |
| PrintLog.cs | Helper | 7 unused using statements |
| PrintPdfHelper.cs | Helper | 7 unused using statements |
| PrintRequest.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| PrintTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| PrintUtility.cs | Helper | 3 commented code lines, 14 unused using statements |
| PrintUtility.cs | Helper | 32 commented code lines, 21 unused using statements |
| Printer.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Printer.cs | DTO | 7 commented code lines, 2 unused using statements |
| PrinterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrinterData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PrinterDataAdapter.cs | Service | 11 unused using statements |
| PrinterDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PrinterRepository.cs | Repository | 5 commented code lines, 5 unused using statements |
| PrinterStatus.cs | Enum | 3 unused using statements |
| PrinterType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| PrinterType.cs | DTO | 7 commented code lines, 2 unused using statements |
| PrinterType.cs | Enum | 3 unused using statements |
| PrinterTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| PrinterTypeData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| PrinterTypeIdentifier.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| PriorityItemDataContract.cs | DTO | 50 WCF attributes, 3 commented code lines, 1 WCF using statements, 3 unused using statements |
| PriorityItemsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| PriorityScreenData.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| PriorityViewTypeIdentifier.cs | Enum | 3 unused using statements |
| ProcedureDetailsModel.cs | DTO | 4 unused using statements |
| ProcedureLineModel.cs | DTO | 3 unused using statements |
| ProcedureTurnaroundModel.cs | DTO | 4 unused using statements |
| ProcedureTypeInfo.cs | DTO | 3 unused using statements |
| ProcedureTypeModel.cs | DTO | 4 unused using statements |
| ProcessGroupMode.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ProcessNoteType.cs | Enum | 3 unused using statements |
| ProcessParameters.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ProcessParameters.cs | DTO | 7 commented code lines, 2 unused using statements |
| ProcessParametersContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessParametersData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessReply.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ProcessRequest.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ProcessRequestType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ProcessingMode.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ProcessingMode.cs | DTO | 7 commented code lines, 2 unused using statements |
| ProcessingModeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingModeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingModeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ProcessingNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ProcessingNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| ProcessingNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteStationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteStationType.cs | DTO | 7 commented code lines, 3 unused using statements |
| ProcessingNoteStationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteStationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ProcessingNoteTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProcessingNoteTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductInfo.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ProductSpecificationInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ProductionDataContract.cs | DTO | 67 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ProductionEventType.cs | DTO | 1 commented code lines, 2 unused using statements |
| ProductionEventTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ProductionItem.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductionItemData.cs | DTO | 14 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ProductionItemType.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductionItemTypeData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ProductionOverview.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductionParamCollection.cs | DTO | 3 unused using statements |
| ProductionStation.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductionStationData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ProductionStationDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ProductionStationDetailData.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ProfileModel.cs | DTO | 4 unused using statements |
| PropertyAlias.cs | Enum | 24 commented code lines, 2 unused using statements |
| PulseTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| PutAwayViewModel.cs | DTO | 3 unused using statements |
| Quality.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Quality.cs | DTO | 7 commented code lines, 2 unused using statements |
| QualityAssuranceInstanceTypes.cs | Enum | 3 unused using statements |
| QualityAssuranceStationData.cs | DTO | 6 WCF attributes, 1 commented code lines, 1 WCF using statements, 3 unused using statements |
| QualityAssuranceTypes.cs | Enum | 3 unused using statements |
| QualityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| QualityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| QualityIdentifier.cs | Enum | 3 unused using statements |
| QualityType.cs | DTO | 7 commented code lines, 2 unused using statements |
| QualityTypeIdentifier.cs | Enum | 3 unused using statements |
| Quarantine.cs | Service | 2 commented code lines, 7 unused using statements |
| QuarantineReason.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| QuarantineReason.cs | DTO | 7 commented code lines, 2 unused using statements |
| QuarantineReasonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| QuarantineReasonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| QuarantineReasonIdentifier.cs | DTO | 1 WCF attributes, 1 commented code lines, 3 unused using statements |
| RawPrinterHelper.cs | Helper | 4 commented code lines, 8 unused using statements |
| RawPrinterHelper.cs | Helper | 9 commented code lines, 8 unused using statements |
| ReadItemInstancesByFacility_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| ReadServiceRequirementsDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ReassignBatchRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| RecipientType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| RecipientType.cs | DTO | 7 commented code lines, 2 unused using statements |
| RecipientTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RecipientTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RecipientTypeIdentifier.cs | Enum | 3 unused using statements |
| RecursiveSearchOption.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ReflectionHelper.cs | Helper | 1 commented code lines, 7 unused using statements |
| RelationshipType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ReleaseWashStationData.cs | DTO | 13 WCF attributes, 2 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| RepairCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| RepairCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| RepairCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RepairCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Report.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Report.cs | DTO | 7 commented code lines, 2 unused using statements |
| ReportCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ReportCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| ReportCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ReportCategoryData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ReportCategoryIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ReportCategoryRepository.cs | Repository | 6 unused using statements |
| ReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ReportData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| ReportDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ReportFileFormatExtensions.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ReportFileFormats.cs | DTO | 1 WCF attributes, 9 commented code lines, 3 unused using statements |
| ReportModel.cs | DTO | 3 unused using statements |
| ReportNavigationMenuModel.cs | DTO | 3 unused using statements |
| ReportOutputType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ReportOutputType.cs | DTO | 7 commented code lines, 3 unused using statements |
| ReportOutputTypeContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ReportOutputTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ReportOutputTypeIdentifier.cs | Enum | 3 unused using statements |
| ReportPrintHandler.cs | Service | 5 commented code lines, 16 unused using statements |
| ReportRepository.cs | Repository | 4 unused using statements |
| ReportServerCredentials.cs | Service | 1 interface inheritances removed, 9 unused using statements |
| ReportType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ReportType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ReportTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ReportTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ReportTypeExternalIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ReportTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Reporting.cs | Helper | 13 unused using statements |
| ReportingEventHandler.cs | Enum | 9 unused using statements |
| RepositoryIQueryableExtensions.cs | Repository | 6 unused using statements |
| RepositoryIQueryableExtensions.cs | Repository | 1 commented code lines, 6 unused using statements |
| ReprintListDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ReprintRequest.cs | DTO | 7 WCF attributes, 1 WCF using statements, 5 unused using statements |
| RequiredWorkflow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| RequiredWorkflow.cs | DTO | 7 commented code lines, 3 unused using statements |
| RequiredWorkflowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RequiredWorkflowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ResetPasswordEmailModel.cs | DTO | 3 unused using statements |
| ResetPasswordModel.cs | DTO | 3 unused using statements |
| RestartBatchRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| RestartBatchResponseDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ResultItem.cs | DTO | 3 unused using statements |
| ResultModel.cs | DTO | 4 unused using statements |
| RetrospectiveEventWhiteList.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| RetrospectiveEventWhiteList.cs | DTO | 7 commented code lines, 3 unused using statements |
| RetrospectiveEventWhiteListContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RetrospectiveEventWhiteListData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RetrospectiveEventWhiteListRepository.cs | Repository | 6 unused using statements |
| Retry.cs | Helper | 7 unused using statements |
| Role.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Role.cs | DTO | 7 commented code lines, 2 unused using statements |
| RoleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RoleData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| RoleDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| RolePermission.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| RolePermission.cs | DTO | 7 commented code lines, 3 unused using statements |
| RolePermissionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| RolePermissionData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| RouteValueDictionaryExtensions.cs | Helper | 7 unused using statements |
| RouteValueDictionaryExtensions.cs | Helper | 8 unused using statements |
| RowModel.cs | DTO | 3 unused using statements |
| SCSearch.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SCSearchCustomerDefect.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SCSearchCustomerDefectData.cs | DTO | 10 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SCSearchData.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SCSearchSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SCSearchSummaryData.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SCSearchType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| SIT_CreateAudit_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| SampleDirection.cs | Enum | 3 unused using statements |
| ScanAssetDataContract.cs | DTO | 106 WCF attributes, 1 WCF using statements, 10 unused using statements |
| ScanAssetDynamicReply.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ScanContainerDataContract.cs | DTO | 41 WCF attributes, 1 commented code lines, 1 WCF using statements, 4 unused using statements |
| ScanDetails.cs | DTO | 66 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ScanDetailsBatchRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| ScanEventDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ScanHelpers.cs | Helper | 57 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| ScanType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ScanType.cs | DTO | 7 commented code lines, 2 unused using statements |
| ScanType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ScanTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ScanTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ScannedStringType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Schedule.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Schedule.cs | DTO | 7 commented code lines, 2 unused using statements |
| ScheduleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ScheduleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ScheduleRepeatType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| SearchContainerInstanceByTagReplyDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SearchDataAdapter.cs | Service | 9 unused using statements |
| SearchForFastTrackTargetsResultModel.cs | DTO | 3 unused using statements |
| SearchItem.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SearchItem.cs | DTO | 3 unused using statements |
| SearchLogsModel.cs | DTO | 4 unused using statements |
| SearchModelType.cs | DTO | 3 unused using statements |
| SearchReplyDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SearchRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SearchRequestType.cs | DTO | 3 unused using statements |
| SearchResult.cs | DTO | 26 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SearchResult.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SearchResultDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SearchRfidComponentsRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SearchTerm.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SearchTerm.cs | DTO | 7 commented code lines, 2 unused using statements |
| SearchTermContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SearchTermData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SearchType.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| SearchViewModel.cs | DTO | 2 unused using statements |
| SearchViewResult.cs | DTO | 3 unused using statements |
| Searchable.cs | DTO | 3 unused using statements |
| SectorTimeDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SelectedFacilityDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ServerReportData.cs | Service | 6 unused using statements |
| ServiceBase.cs | Service | 1 commented code lines, 1 interface inheritances removed, 6 unused using statements |
| ServiceExceptionManager.cs | Service | 8 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 9 unused using statements |
| ServiceHelper.cs | Helper | 7 unused using statements |
| ServiceHelper.cs | Helper | 6 commented code lines, 1 WCF using statements, 6 unused using statements |
| ServiceParameterModel.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceReportRequest.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ServiceReports.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceReports.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceReportsContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceReportsData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirement.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirement.cs | DTO | 7 commented code lines, 2 unused using statements |
| ServiceRequirementContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementContractedHour.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceRequirementContractedHours.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementContractedHours.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceRequirementContractedHours.cs | DTO | 22 commented code lines, 3 unused using statements |
| ServiceRequirementContractedHoursContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementContractedHoursData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementContractedHoursDataAdapter.cs | DTO | 8 unused using statements |
| ServiceRequirementContractedHoursRepository.cs | DTO | 3 unused using statements |
| ServiceRequirementData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ServiceRequirementDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ServiceRequirementDefinition.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementDefinition.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceRequirementDefinitionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementDefinitionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementDetailData.cs | DTO | 5 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| ServiceRequirementDetailsData.cs | DTO | 5 WCF attributes, 9 commented code lines, 1 WCF using statements, 3 unused using statements |
| ServiceRequirementEventType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementEventType.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceRequirementEventTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementEventTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementExpiry.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementExpiryRepository.cs | Repository | 7 unused using statements |
| ServiceRequirementExpiryWindow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementExpiryWindow.cs | DTO | 7 commented code lines, 3 unused using statements |
| ServiceRequirementExpiryWindowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementExpiryWindowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ServiceRequirementExpiryWindowExpiryDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ServiceRequirementInfo.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ServiceRequirementItemTypeDataAdapter.cs | Service | 8 unused using statements |
| ServiceRequirementItemTypeRepository.cs | Repository | 5 unused using statements |
| ServiceRequirementRepository.cs | Repository | 1 commented code lines, 5 unused using statements |
| ServiceRequirementRequest.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ServiceRequirementResponse.cs | DTO | 2 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ServiceRequirementsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| ServiceStatus.cs | Enum | 3 unused using statements |
| SetAerBatchStatusDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 4 unused using statements |
| Setting.cs | DTO | 3 unused using statements |
| SettingDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SettingExtensions.cs | Helper | 6 unused using statements |
| SettingHelper.cs | Helper | 7 unused using statements |
| SettingKeyValueDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SettingType.cs | Enum | 3 unused using statements |
| Settings.cs | Helper | 5 unused using statements |
| SettingsModel.cs | DTO | 3 unused using statements |
| SettingsRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SettingsResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SharedAttributesResources.cs | Service | 6 unused using statements |
| SharedResources.cs | Service | 6 unused using statements |
| ShelfStatus.cs | DTO | 1 WCF attributes, 3 unused using statements |
| SignalREntity.cs | DTO | 3 unused using statements |
| SimilarTurnaroundModel.cs | DTO | 3 unused using statements |
| SimpleTypeModelDescription.cs | DTO | 3 unused using statements |
| SimplifiedLoanSetContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SingleInstrumentAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| SingleInstrumentAuditContract.cs | DTO | 13 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SingleInstrumentAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| SingleInstrumentAuditLineContract.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SingleInstrumentAuditLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditProcessFault.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditProcessFault.cs | DTO | 7 commented code lines, 3 unused using statements |
| SingleInstrumentAuditProcessFaultContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditProcessFaultData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleInstrumentAuditRepository.cs | Repository | 6 unused using statements |
| SingleUseItemByContainerMasterSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleUseItemByContainerMasterSummaryData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SingleUseItemSummary.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SingleUseItemSummaryData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SpecialitiesComplexity.cs | Helper | 7 unused using statements |
| Speciality.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Speciality.cs | DTO | 7 commented code lines, 2 unused using statements |
| SpecialityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SpecialityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SpecialityTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Specification.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Specification.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Specification.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SpecificationComponentInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SpecificationExceptionInfo.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SpecificationNoteInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| StartAerRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| StaticData.cs | DTO | 1 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| StaticDataDataContract.cs | DTO | 18 WCF attributes, 1 WCF using statements, 6 unused using statements |
| Station.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Station.cs | DTO | 7 commented code lines, 2 unused using statements |
| StationAssociatedStationTypeDataAdapter.cs | Service | 1 commented code lines, 8 unused using statements |
| StationAssociatedStationTypeRepository.cs | Repository | 7 unused using statements |
| StationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationData.cs | DTO | 7 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| StationDataBase.cs | DTO | 14 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| StationDataContract.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StationDeliveryPointContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationDeliveryPointData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationDeliveryPointDataAdapter.cs | Service | 1 commented code lines, 8 unused using statements |
| StationDeliveryPointRepository.cs | Repository | 1 commented code lines, 5 unused using statements |
| StationEnquiryData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StationHelper.cs | Helper | 1 commented code lines, 7 unused using statements |
| StationLabel.cs | Service | 47 commented code lines, 8 unused using statements |
| StationLabelData.cs | Service | 6 unused using statements |
| StationLabelPrintHandler.cs | Service | 4 commented code lines, 10 unused using statements |
| StationPrinter.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StationPrinter.cs | DTO | 7 commented code lines, 3 unused using statements |
| StationPrinterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationPrinterData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| StationPrinterRepository.cs | Repository | 4 commented code lines, 6 unused using statements |
| StationRepository.cs | Repository | 11 commented code lines, 7 unused using statements |
| StationScanModel.cs | DTO | 3 unused using statements |
| StationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StationType.cs | DTO | 7 commented code lines, 2 unused using statements |
| StationTypeCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StationTypeCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| StationTypeCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeCategoryIdentifier.cs | DTO | 1 WCF attributes, 1 commented code lines, 3 unused using statements |
| StationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeIdentifier.cs | DTO | 1 WCF attributes, 10 commented code lines, 3 unused using statements |
| StationTypeItemType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StationTypeItemType.cs | DTO | 7 commented code lines, 3 unused using statements |
| StationTypeItemTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeItemTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StationTypeRepository.cs | Repository | 4 commented code lines, 5 unused using statements |
| StationXMLDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StatusData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 2 unused using statements |
| StatusDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SterileExpiryHelper.cs | Helper | 3 commented code lines, 8 unused using statements |
| SterilisationExpiryTime.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SterilisationExpiryTime.cs | DTO | 7 commented code lines, 3 unused using statements |
| SterilisationExpiryTimeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationExpiryTimeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTemperature.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SterilisationTemperature.cs | DTO | 7 commented code lines, 2 unused using statements |
| SterilisationTemperatureContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTemperatureData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReport.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReport.cs | DTO | 7 commented code lines, 3 unused using statements |
| SterilisationTestReportAuditHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportAuditHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| SterilisationTestReportAuditHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportAuditHistoryData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SterilisationTestReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportData.cs | DTO | 7 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| SterilisationTestReportStatus.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportStatus.cs | DTO | 7 commented code lines, 2 unused using statements |
| SterilisationTestReportStatusContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportStatusData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SterilisationTestReportStatusTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| SterilisationTestReportType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| Stock.cs | Service | 9 unused using statements |
| StockForcast.cs | DTO | 3 unused using statements |
| StockInModel.cs | DTO | 3 unused using statements |
| StockItem.cs | DTO | 3 unused using statements |
| StockLocationDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StockManagementDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| StockManagementHelper.cs | Helper | 25 commented code lines, 9 unused using statements |
| StockManagementRequest.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| StockManagementType.cs | Enum | 3 unused using statements |
| StockMovement.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StockMovement.cs | DTO | 7 commented code lines, 3 unused using statements |
| StockMovementContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StockMovementData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StockMovementDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StockRequest.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| StockTakeViewModel.cs | DTO | 3 unused using statements |
| StockTransaction.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StockTransaction.cs | DTO | 7 commented code lines, 3 unused using statements |
| StockTransactionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StockTransactionData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| StockTransactionType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StockTransactionType.cs | DTO | 7 commented code lines, 2 unused using statements |
| StockTransactionTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StockTransactionTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StockTransactionTypeIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| StocktakeActivity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StocktakeActivity.cs | DTO | 7 commented code lines, 2 unused using statements |
| StocktakeActivityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StocktakeActivityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StocktakeActivityIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| StocktakeHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StocktakeHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| StocktakeHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StocktakeHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StoragePoint.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| StoragePoint.cs | DTO | 7 commented code lines, 2 unused using statements |
| StoragePointContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| StoragePointCreateModel.cs | DTO | 4 unused using statements |
| StoragePointData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| StoragePointDeleteModel.cs | DTO | 3 unused using statements |
| StoragePointDetailsModel.cs | DTO | 3 unused using statements |
| StoragePointInfo.cs | DTO | 3 unused using statements |
| StoragePointRepository.cs | Repository | 16 commented code lines, 6 unused using statements |
| StorageType.cs | DTO | 1 WCF attributes, 3 unused using statements |
| StoredProcedureNames.cs | Service | 6 unused using statements |
| StringExtensions.cs | Helper | 6 unused using statements |
| StringExtensions.cs | Helper | 6 unused using statements |
| StringExtensions.cs | Helper | 8 unused using statements |
| StringHelper.cs | Helper | 1 commented code lines, 8 unused using statements |
| SuggestedWorkflowArgs.cs | DTO | 3 unused using statements |
| SupervisorActions.cs | Enum | 3 unused using statements |
| Surgeon.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Surgeon.cs | DTO | 7 commented code lines, 3 unused using statements |
| SurgeonContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgeonData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgeonInfo.cs | DTO | 3 unused using statements |
| SurgeonModel.cs | DTO | 4 unused using statements |
| SurgicalProcedure.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedure.cs | DTO | 7 commented code lines, 3 unused using statements |
| SurgicalProcedureContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureCreateModel.cs | DTO | 3 unused using statements |
| SurgicalProcedureData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureEditModel.cs | DTO | 4 unused using statements |
| SurgicalProcedureInfo.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureModel.cs | DTO | 3 unused using statements |
| SurgicalProcedureRequest.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureResponse.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureSurgeon.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureTurnaround.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureTurnaround.cs | DTO | 7 commented code lines, 3 unused using statements |
| SurgicalProcedureTurnaround.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureTurnaroundContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureTurnaroundData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureTurnaroundUsageStatus.cs | DTO | 3 unused using statements |
| SurgicalProcedureType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureType.cs | DTO | 7 commented code lines, 3 unused using statements |
| SurgicalProcedureType.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SurgicalProcedureTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SurgicalProcedureValidationResult.cs | DTO | 2 WCF attributes, 4 unused using statements |
| SurgicalProcedureWarningResponse.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SynergyCustomer_CommonResources.cs | Service | 6 unused using statements |
| SynergyException.cs | Service | 6 unused using statements |
| SynergyItemType.cs | DTO | 44 WCF attributes, 3 unused using statements |
| SynergyTrakApplicationDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SynergyTrakAuthenticationAttribute.cs | Service | 12 commented code lines, 9 unused using statements |
| SynergyTrakClockInHelper.cs | Helper | 5 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 12 unused using statements |
| SynergyTrakData.cs | DTO | 5 unused using statements |
| SynergyTrakDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SynergyTrakEventHelper.cs | Helper | 41 commented code lines, 19 unused using statements |
| SynergyTrakHelperMk3.cs | Helper | 143 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 17 unused using statements |
| SynergyTrakHelperMk3.cs | Helper | 1 commented code lines, 8 unused using statements |
| SynergyTrakInfo.cs | DTO | 4 unused using statements |
| SynergyTrakReplyDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| SynergyTrakRequestDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| SynergyTrakUserDataContract.cs | DTO | 21 WCF attributes, 1 WCF using statements, 5 unused using statements |
| SystemSetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| SystemSetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| SystemSettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SystemSettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| SystemSettingDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| SystemSettingRepository.cs | Repository | 6 unused using statements |
| SystemSettings.cs | Helper | 7 unused using statements |
| TableCellModel.cs | DTO | 4 unused using statements |
| TableColumnModel.cs | DTO | 3 unused using statements |
| TableInfo.cs | DTO | 3 unused using statements |
| TableInfo.cs | DTO | 3 unused using statements |
| TableModel.cs | DTO | 1 commented code lines, 3 unused using statements |
| TableSummary.cs | DTO | 3 unused using statements |
| TableauAuthenticatedTicket.cs | Helper | 2 commented code lines, 8 unused using statements |
| TagContracts.cs | DTO | 28 WCF attributes, 1 WCF using statements, 2 unused using statements |
| TargetTime.cs | DTO | 3 unused using statements |
| TargetTimeData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Task.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Task.cs | DTO | 7 commented code lines, 3 unused using statements |
| TaskContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TaskData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TaskModel.cs | DTO | 3 unused using statements |
| TaskWidgetModel.cs | DTO | 3 unused using statements |
| TenSetting.cs | DTO | 3 unused using statements |
| Tenancy.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Tenancy.cs | DTO | 7 commented code lines, 2 unused using statements |
| TenancyContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancyCustomValue.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TenancyCustomValue.cs | DTO | 7 commented code lines, 3 unused using statements |
| TenancyCustomValueContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancyCustomValueData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancyCustomisationDataType.cs | DTO | 3 unused using statements |
| TenancyCustomisationIndex.cs | DTO | 3 unused using statements |
| TenancyCustomisationListModel.cs | DTO | 3 unused using statements |
| TenancyData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancyRepository.cs | Repository | 6 unused using statements |
| TenancySetting.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TenancySetting.cs | DTO | 7 commented code lines, 3 unused using statements |
| TenancySetting.cs | DTO | 1 commented code lines, 3 unused using statements |
| TenancySettingContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancySettingData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TenancySettingDataContract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TenancySettingInfo.cs | DTO | 3 unused using statements |
| TenancySettingRepository.cs | Repository | 1 commented code lines, 6 unused using statements |
| TenancySettingType.cs | DTO | 6 WCF attributes, 3 unused using statements |
| TenancySettings.cs | Helper | 6 unused using statements |
| TenancySettingsDetail.cs | DTO | 3 unused using statements |
| TenancySettingsIndex.cs | DTO | 3 unused using statements |
| TertiaryActivity.cs | DTO | 1 WCF attributes, 3 unused using statements |
| TestPrintHandler.cs | Service | 1 commented code lines, 10 unused using statements |
| TestReportTemperature.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TestReportTemperature.cs | DTO | 7 commented code lines, 3 unused using statements |
| TestReportTemperatureContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TestReportTemperatureData.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| TextDisplayColourAttribute.cs | Service | 6 unused using statements |
| TextSample.cs | Service | 5 unused using statements |
| TheatreImageTypeIdentifier.cs | Enum | 3 unused using statements |
| TimeZone.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TimeZone.cs | DTO | 7 commented code lines, 2 unused using statements |
| TimeZoneContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TimeZoneConverter.cs | Helper | 7 unused using statements |
| TimeZoneData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TimeZonesData.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TooltipAttribute.cs | Service | 6 unused using statements |
| TrackingData.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TrakStarPrint.cs | Service | 1 commented code lines, 6 unused using statements |
| Transfer.cs | Service | 31 commented code lines, 9 unused using statements |
| TransferDestination.cs | DTO | 5 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TransferDirection.cs | DTO | 1 WCF attributes, 3 unused using statements |
| TransferNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TransferNote.cs | DTO | 7 commented code lines, 3 unused using statements |
| TransferNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TransferNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TransferNoteDataContract.cs | DTO | 8 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TransferNoteHelper.cs | Helper | 3 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| TransferNoteInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TransferNoteLine.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TransferNoteLine.cs | DTO | 7 commented code lines, 3 unused using statements |
| TransferNoteLineContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TransferNoteLineData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TransferNoteLineInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TransferNoteLineRepository.cs | Repository | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| TransferNoteLineScan.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TransferNoteLineScanDetails.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TransferNotePriorityItem.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TransferNotePriorityListDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TransferNoteRequestDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TransferRulesDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| Translation.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Translation.cs | DTO | 7 commented code lines, 3 unused using statements |
| TranslationContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TranslationData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TranslationExtensions.cs | DTO | 2 commented code lines, 4 unused using statements |
| TranslationIndexModel.cs | DTO | 3 unused using statements |
| TranslationRepository.cs | Repository | 6 unused using statements |
| TrayBuilderContracts.cs | DTO | 55 WCF attributes, 1 WCF using statements, 2 unused using statements |
| TrayPrioritisationInstanceTypes.cs | Enum | 3 unused using statements |
| TrayPrioritisationStationData.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TrayPrioritisationTypes.cs | Enum | 3 unused using statements |
| Tree.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Tree.cs | DTO | 7 commented code lines, 2 unused using statements |
| TreeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TreeData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TrolleyCollectedModel.cs | DTO | 3 unused using statements |
| TrolleyContents.cs | DTO | 3 unused using statements |
| TrolleyDatabaseHelper.cs | Helper | 1 commented code lines, 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| TrolleyDispatch.cs | Service | 8 unused using statements |
| TrolleyDispatchContainerDataContract.cs | DTO | 22 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TrolleyDispatchDatabaseHelper.cs | Helper | Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 7 unused using statements |
| TrolleyDispatchDeliveryNoteDataContract.cs | DTO | 10 WCF attributes, 1 WCF using statements, 6 unused using statements |
| TrolleyDispatchDeliveryNotePrintRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TrolleyDispatchHelper.cs | Helper | 44 commented code lines, 1 interface inheritances removed, 12 unused using statements |
| TrolleyDispatchHubSummaryDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TrolleyDispatchScanTurnaroundScanDetails.cs | DTO | 5 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TrolleyDispatchTrolleyDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TrolleyDispatchTrolleySummaryDataContract.cs | DTO | 13 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TrolleyDispatch_GetSuggestedTurnarounds_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| TrolleyDispatch_GetTrolleyContents_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| TrolleyDispatch_GetTrolleyHubSummary_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| TrolleyDispatch_GetTrolleySummary_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| TrolleyLoadFromUsagePointContentsModel.cs | DTO | 3 unused using statements |
| TrolleyLoadFromUsagePointModel.cs | DTO | 3 unused using statements |
| TrolleyLoadModel.cs | DTO | 3 unused using statements |
| TrolleyLoadOntoModel.cs | DTO | 3 unused using statements |
| TrolleyPrint.cs | DTO | 3 unused using statements |
| TrolleylessDispatchContainerDataContract.cs | DTO | 20 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TurnAroundEventTypeIdentifier.cs | DTO | 1 WCF attributes, 10 commented code lines, 3 unused using statements |
| Turnaround.cs | DTO | 11 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| Turnaround.cs | DTO | 7 commented code lines, 3 unused using statements |
| Turnaround.cs | DTO | 8 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Turnaround.cs | Helper | 6 unused using statements |
| TurnaroundAssigned.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundAssigned.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundAssignedContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundAssignedData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundAssignedRepository.cs | Repository | 6 unused using statements |
| TurnaroundContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundData.cs | DTO | 62 WCF attributes, 1 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundDetailData.cs | DTO | 42 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundEnquiryResponse.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| TurnaroundEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundEvent.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TurnaroundEvent.cs | Helper | 1 commented code lines, 6 unused using statements |
| TurnaroundEventAcknowledgeNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventAcknowledgeNote.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundEventAcknowledgeNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventAcknowledgeNoteData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventAcknowledgeNoteRepository.cs | Repository | 6 unused using statements |
| TurnaroundEventComplete.cs | DTO | 1 commented code lines, 4 unused using statements |
| TurnaroundEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundEventDataContract.cs | DTO | 21 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TurnaroundEventDetail.cs | DTO | 1 commented code lines, 3 unused using statements |
| TurnaroundEventFailureType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventFailureType.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundEventFailureTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventFailureTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventFailureTypeRepository.cs | Repository | 6 unused using statements |
| TurnaroundEventListData.cs | DTO | 21 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundEventRepository.cs | Repository | 19 commented code lines, 11 unused using statements |
| TurnaroundEventReprint.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventReprint.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundEventReprintContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventReprintData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventReprintRepository.cs | Repository | 6 unused using statements |
| TurnaroundEventType.cs | DTO | 1 commented code lines, 2 unused using statements |
| TurnaroundEventTypeDataContract.cs | DTO | 5 WCF attributes, 1 WCF using statements, 2 unused using statements |
| TurnaroundEventWeight.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventWeight.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundEventWeightContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventWeightData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundEventWeightDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TurnaroundEventWeightExtensions.cs | DTO | 3 unused using statements |
| TurnaroundEventWeightRepository.cs | Repository | 6 unused using statements |
| TurnaroundEvents.cs | Service | 6 commented code lines, 19 unused using statements |
| TurnaroundExistence.cs | DTO | 1 WCF attributes, 3 unused using statements |
| TurnaroundExtensions.cs | Helper | 6 unused using statements |
| TurnaroundExtensions.cs | Helper | 8 commented code lines, 6 unused using statements |
| TurnaroundFacility.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundFacility.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundFacility.cs | Helper | 4 commented code lines, 7 unused using statements |
| TurnaroundFacilityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundFacilityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundFacilityRepository.cs | Repository | 6 unused using statements |
| TurnaroundHelpers.cs | Helper | 21 commented code lines, 9 unused using statements |
| TurnaroundInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TurnaroundLabelData.cs | Service | 6 unused using statements |
| TurnaroundLabelDataContract.cs | DTO | 7 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TurnaroundLabelDataMk2.cs | DTO | 56 commented code lines, 3 unused using statements |
| TurnaroundLabelPrintHandler.cs | Service | 5 commented code lines, 12 unused using statements |
| TurnaroundModel.cs | DTO | 2 unused using statements |
| TurnaroundNote.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundNote.cs | DTO | 7 commented code lines, 2 unused using statements |
| TurnaroundNoteContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundNoteData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundNoteStationType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundNoteStationType.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundNoteStationTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundNoteStationTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundNotesListData.cs | DTO | 6 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| TurnaroundPriority.cs | DTO | 1 WCF attributes, 3 unused using statements |
| TurnaroundProcessingCycleTypesDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TurnaroundRepository.cs | Repository | 24 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 12 unused using statements |
| TurnaroundServiceRequirementDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TurnaroundServiceRequirementsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| TurnaroundSpecificationInfo.cs | DTO | 6 WCF attributes, 1 WCF using statements, 3 unused using statements |
| TurnaroundSummary.cs | DTO | 3 unused using statements |
| TurnaroundTabDetailData.cs | DTO | 21 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundUsageModel.cs | DTO | 3 unused using statements |
| TurnaroundWH.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| TurnaroundWH.cs | DTO | 7 commented code lines, 3 unused using statements |
| TurnaroundWHContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| TurnaroundWHData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundWHDetailData.cs | DTO | 36 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| TurnaroundWHRepository.cs | Repository | 7 unused using statements |
| TurnaroundsOnDeliveryNoteResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 5 unused using statements |
| TwoDBarcodeInstanceLabel.cs | Service | 7 commented code lines, 7 unused using statements |
| TypeHelper.cs | Helper | 9 unused using statements |
| UnitOfWorkFactory.cs | Service | 4 commented code lines, 6 unused using statements |
| UpdateBatchRequestDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| UpdateHisResult.cs | DTO | 3 unused using statements |
| UpdateItemExceptionsRequestDataContract.cs | DTO | 16 WCF attributes, 1 WCF using statements, 5 unused using statements |
| UpdateMachineStatusRequestDataContract.cs | DTO | 4 WCF attributes, 1 WCF using statements, 5 unused using statements |
| UploadFile.cs | DTO | 11 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UploadModel.cs | DTO | 1 commented code lines, 4 unused using statements |
| UrlHelperExtensions.cs | Helper | 8 unused using statements |
| UsagePointDetailsModel.cs | DTO | 3 unused using statements |
| UsageStatus.cs | Service | 7 commented code lines, 6 unused using statements |
| User.cs | DTO | 5 commented code lines, 1 interface inheritances removed, 5 unused using statements |
| User.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserAuthenticationState.cs | DTO | 1 WCF attributes, 1 commented code lines, 3 unused using statements |
| UserCategory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserCategory.cs | DTO | 7 commented code lines, 2 unused using statements |
| UserCategory.cs | Enum | 3 unused using statements |
| UserCategoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserCategoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserChangePinDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserClockingData.cs | DTO | 11 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserClockingEvent.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserClockingEvent.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserClockingEventContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserClockingEventData.cs | DTO | 2 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| UserComplexity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserComplexity.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserComplexityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserComplexityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserContextModel.cs | DTO | 3 unused using statements |
| UserContract.cs | DTO | 1 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 3 unused using statements |
| UserCredentialsRequestMessage.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserCredentialsResponseMessage.cs | DTO | 4 WCF attributes, 5 commented code lines, 1 WCF using statements, 5 unused using statements |
| UserCultureData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserCustomerDetail.cs | DTO | 1 commented code lines, 4 unused using statements |
| UserData.cs | DTO | 24 WCF attributes, 1 commented code lines, 1 WCF using statements, 3 unused using statements |
| UserDeliveryPoint.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserDeliveryPoint.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserDeliveryPointContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserDeliveryPointData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserDeliveryPointDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 5 unused using statements |
| UserDeliveryPointRepository.cs | Repository | 6 unused using statements |
| UserDeliveryPointsModel.cs | DTO | 3 unused using statements |
| UserDetailsModel.cs | DTO | 3 unused using statements |
| UserExtendedPropertyData.cs | DTO | 9 commented code lines, 1 interface inheritances removed, 3 unused using statements |
| UserExtensions.cs | Helper | 6 unused using statements |
| UserExtensions.cs | Helper | 6 unused using statements |
| UserExtensions.cs | Helper | 3 commented code lines, 8 unused using statements |
| UserExtensions.cs | Helper | 5 commented code lines, 7 unused using statements |
| UserFacility.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserFacility.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserFacilityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserFacilityData.cs | DTO | 8 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| UserHelper.cs | Helper | 8 unused using statements |
| UserIndexInfo.cs | DTO | 4 unused using statements |
| UserInfo.cs | DTO | 10 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserInfo.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserInfo.cs | DTO | 4 unused using statements |
| UserItemAudit.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserItemAudit.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserItemAuditContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditCopyList.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditCopyList.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserItemAuditCopyListContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditCopyListData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditHelper.cs | Helper | 7 unused using statements |
| UserItemAuditType.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditType.cs | DTO | 7 commented code lines, 2 unused using statements |
| UserItemAuditTypeContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserItemAuditTypeData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserLocaleModel.cs | DTO | 4 unused using statements |
| UserLoginDatacontract.cs | DTO | 6 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserModel.cs | DTO | 3 unused using statements |
| UserPasswordHistory.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserPasswordHistory.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserPasswordHistoryContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPasswordHistoryData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPerformance.cs | DTO | 3 unused using statements |
| UserPerformanceData.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserPerformanceDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserPerformanceResponseDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserPermission.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserPermission.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserPermissionContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPermissionData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPermissionInfo.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserPermissionRights.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 6 unused using statements |
| UserPermissionRightsContract.cs | DTO | 1 WCF attributes, 15 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| UserPermissionRightsData.cs | DTO | 1 WCF attributes, 15 commented code lines, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| UserPinAttemptsDataContract.cs | DTO | 2 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserPrinter.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserPrinter.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserPrinterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPrinterData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserPrintersModel.cs | DTO | 4 unused using statements |
| UserProductionManagerFilter.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserProductionManagerFilter.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserProductionManagerFilterContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserProductionManagerFilterData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserProductionManagerFilterDataContract.cs | DTO | 17 WCF attributes, 1 WCF using statements, 4 unused using statements |
| UserReport.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserReport.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserReportContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserReportData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 4 unused using statements |
| UserRepository.cs | Repository | 2 commented code lines, 6 unused using statements |
| UserRole.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| UserRole.cs | DTO | 7 commented code lines, 3 unused using statements |
| UserRoleContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserRoleData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| UserRoleIdentifier.cs | DTO | 1 WCF attributes, 3 unused using statements |
| UserRolesModel.cs | DTO | 3 unused using statements |
| UserSpecialityDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| UserTag.cs | Service | 8 unused using statements |
| UserTagData.cs | Service | 6 unused using statements |
| UserTagPrintHandler.cs | Service | 4 commented code lines, 9 unused using statements |
| UtilityEventHandler.cs | Helper | 8 commented code lines, 14 unused using statements |
| VacPackMachineDataContract.cs | DTO | 3 WCF attributes, 1 WCF using statements, 3 unused using statements |
| ValidatePinResult.cs | DTO | 1 WCF attributes, 3 unused using statements |
| ValidationHelpers.cs | Helper | 61 commented code lines, 11 unused using statements |
| Vendor.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Vendor.cs | DTO | 7 commented code lines, 2 unused using statements |
| VendorActivityData.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| VendorContact.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| VendorContact.cs | DTO | 7 commented code lines, 3 unused using statements |
| VendorContactContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorContactData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorContractData.cs | DTO | 17 WCF attributes, 1 WCF using statements, 2 unused using statements |
| VendorData.cs | DTO | 4 WCF attributes, 1 interface inheritances removed, 1 WCF using statements, 5 unused using statements |
| VendorFacility.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| VendorFacility.cs | DTO | 7 commented code lines, 3 unused using statements |
| VendorFacilityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorFacilityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorMaintenanceActivity.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| VendorMaintenanceActivity.cs | DTO | 7 commented code lines, 2 unused using statements |
| VendorMaintenanceActivityContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorMaintenanceActivityData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorMaintenanceHelper.cs | Helper | 1 interface inheritances removed, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 8 unused using statements |
| VendorMaintenance_GetAllContractsForVendor_Result.cs | DTO | 3 unused using statements |
| VendorMaintenance_GetMaintenanceActivityInfoForVendor_Result.cs | DTO | 2 unused using statements |
| VendorRemoveContractsData.cs | DTO | 4 WCF attributes, 1 WCF using statements, 3 unused using statements |
| VendorRepairCost.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| VendorRepairCost.cs | DTO | 7 commented code lines, 3 unused using statements |
| VendorRepairCostContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| VendorRepairCostData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| ViewModel.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| Warning.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Warning.cs | DTO | 7 commented code lines, 2 unused using statements |
| WarningContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WarningData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WarningDataContract.cs | DTO | 15 WCF attributes, 1 WCF using statements, 3 unused using statements |
| Wash.cs | Service | 33 commented code lines, 12 unused using statements |
| WashStationData.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| WashTypes.cs | Enum | 3 unused using statements |
| WeightStatus.cs | DTO | 1 WCF attributes, 3 unused using statements |
| WorkFlowCache.cs | Helper | 3 commented code lines, 5 unused using statements |
| Workflow.cs | DTO | 4 commented code lines, 1 interface inheritances removed, 4 unused using statements |
| Workflow.cs | DTO | 7 commented code lines, 3 unused using statements |
| WorkflowArgs.cs | DTO | 3 unused using statements |
| WorkflowBaseArgs.cs | DTO | 3 unused using statements |
| WorkflowContract.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WorkflowCreateModel.cs | DTO | 3 unused using statements |
| WorkflowData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WorkflowDataContract.cs | DTO | 9 WCF attributes, 1 WCF using statements, 3 unused using statements |
| WorkflowDataContract.cs | DTO | 12 WCF attributes, 1 WCF using statements, 3 unused using statements |
| WorkflowDeleteModel.cs | DTO | 1 commented code lines, 3 unused using statements |
| WorkflowDetail.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WorkflowEventsData.cs | DTO | 1 interface inheritances removed, 4 unused using statements |
| WorkflowHelpers.cs | Helper | 38 commented code lines, 11 unused using statements |
| WorkflowIndexModel.cs | DTO | 3 unused using statements |
| WorkflowInfo.cs | DTO | 3 unused using statements |
| WorkflowRepository.cs | Repository | 16 commented code lines, Migrated to Microsoft.Data.SqlClient, Migrated to Microsoft.Data.SqlClient, 9 unused using statements |
| XmlDictionaryExtension.cs | Helper | 6 unused using statements |
| admapp_ReadAlerts_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchBatchDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchCustomerDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchDefectDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchDeliveryNoteDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchDeliveryPointDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchFacilityDetail_Result.cs | DTO | 7 commented code lines, 2 unused using statements |
| admapp_ReadOmniSearchInstanceDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchItemDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchLoanSetsDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchMasterDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchSummary_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchTurnaroundDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadOmniSearchUserDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadPagedItemMasters_Result.cs | DTO | 7 commented code lines, 2 unused using statements |
| admapp_ReadPagedMasters_Translated_Result.cs | DTO | 7 commented code lines, 2 unused using statements |
| admapp_ReadProductionOverviewByServiceRequirement_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadProductionOverview_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadTurnaroundsByFacilityAndCustomer_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadTurnaroundsForGraphByFacilityAndCustomer_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| admapp_ReadkeyStatistics_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| finapp_ReadChargeListByCustomerDefinitionId_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| finapp_ReadContainerMasterPrice_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| finapp_ReadCustomerIndexationByCategoryDetail_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| finapp_ReadCustomerIndexationByCategory_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| finapp_UpdateContainerMasterPrice_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| opsapp_GetAerData_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| opsapp_GetEndoscopeOverview_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| opsapp_GetEndscopeLocationData_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| opsapp_ReadAllUnpassedTurnaroundsByBatch_Result.cs | DTO | 7 commented code lines, 3 unused using statements |
| opsapp_ReadAwaitingEventsByStationType_Result.cs | DTO | 7 commented code lines, 3 unused using statements |


---

## Modernization Benefits

✅ **Cleaner Codebase**: Removed 13653 lines of obsolete code

✅ **Better Maintainability**: Eliminated WCF-specific patterns

✅ **Modern Patterns**: Converted to .NET 8 Web API standards

✅ **Production Ready**: Clean, documented, and ready for deployment

---

*This report was automatically generated during the WCF to .NET 8 Web API migration process.*
