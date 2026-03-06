using System;
using System.Collections.Generic;
using System.Linq;
using ReportTypeIdentifier = Synergy.LabelPrinting.Enums.ReportTypeIdentifier;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.Services
{
    /// <summary>
    /// print event handler
    /// </summary>
    public sealed class PrintEventHandler : EventHandlerBase, IPrintEventHandler
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PrintEventHandler"/> class.
        /// </summary>
        /// <param name="workUnit">The work unit.</param>
        internal PrintEventHandler(IUnitOfWork workUnit)
            : base(workUnit)
        {

        }

        /// <summary>
        /// Creates an instance label that can be printed
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="instance">The instance.</param>
        /// <param name="userId"></param>
        /// <param name="stationId"></param>
        /// <param name="facilityId"></param>
        /// <param name="isNewInstanceCreated"></param>
        /// <summary>
        /// PrintInstanceLabel operation
        /// </summary>
        public IPrintDetails PrintInstanceLabel(IPrinter printer, IContainerInstance instance, int userId, int? stationId, short facilityId, bool isNewInstanceCreated, string culture)
        {
            try
            {
                var customerDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
                var deliveryPointDataAdapter = DataAdapterFactory.GetDeliveryPointDataAdapter(OperativeWorkUnit);
                var containerMasterDataAdapter = DataAdapterFactory.GetContainerMasterDataAdapter(OperativeWorkUnit);
                var containerMasterDefinitionDataAdapter = DataAdapterFactory.GetContainerMasterDefinitionDataAdapter(OperativeWorkUnit);

                var containerMaster = containerMasterDataAdapter.GetActiveContainerMasterBydefinitionId(instance.ContainerMasterDefinitionId);
                var deliveryPoint = (DeliveryPoint)deliveryPointDataAdapter.GetDeliveryPoint(instance.DeliveryPointId);
                var customer = (Customer)customerDataAdapter.GetActiveOneByDefinitionId(deliveryPoint.CustomerDefinitionId);
                var containerMasterDefinition = containerMasterDefinitionDataAdapter.GetContainerMasterDefinition(instance.ContainerMasterDefinitionId);
                var deliveryPointText = deliveryPoint.Text;
                var pleaseReturnText = TranslatorManager.GetText("pathway", "PTouchLabels", "PleaseReturnAfterUse", false, culture);

                if (deliveryPoint != null && containerMaster != null && deliveryPoint.CustomerDefinitionId != containerMasterDefinition.CustomerDefinitionId)
                {
                    customer = (Customer)customerDataAdapter.GetActiveOneByDefinitionId(containerMasterDefinition.CustomerDefinitionId);
                    deliveryPointText = "*" + deliveryPointText;
                }

                InstanceLabelData instanceLabelData;
                var concCI = (ContainerInstance)instance;

                PrintTypeIdentifier labelFormat;

                if (instance.Linear1dBarcodeId != null && instance.Datamatrix2dBarcodeId != null)
                {
                    string instanceLabelId = null;
                    string datamatrix2DBarcode = null;

                    instanceLabelId = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == instance.Linear1dBarcodeId).FirstOrDefault().Value;
                    datamatrix2DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == instance.Datamatrix2dBarcodeId).FirstOrDefault().Value;

                    instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                             customer.Text,
                                                             deliveryPointText,
                                                             instanceLabelId,
                                                             PrintTypeIdentifier.CombinedBarcodeInstanceLabel,
                                                             instance.WeighingRequired,
                                                             datamatrix2DBarcode,
                                                             pleaseReturnText);

                    labelFormat = PrintTypeIdentifier.CombinedBarcodeInstanceLabel;
                }
                else if (instance.Linear1dBarcodeId != null)
                {
                    string instanceLabelId = null;

                    instanceLabelId = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == instance.Linear1dBarcodeId).FirstOrDefault().Value;

                    instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                                customer.Text,
                                                                deliveryPointText,
                                                                instanceLabelId,
                                                                PrintTypeIdentifier.InstanceLabel,
                                                                instance.WeighingRequired,
                                                                pleaseReturnText: pleaseReturnText);

                    labelFormat = PrintTypeIdentifier.InstanceLabel;
                }
                else if (instance.Datamatrix2dBarcodeId != null)
                {
                    string datamatrix2DBarcode = null;

                    datamatrix2DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == instance.Datamatrix2dBarcodeId).FirstOrDefault().Value;

                    instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                                customer.Text,
                                                                deliveryPointText,
                                                                datamatrix2DBarcode,
                                                                PrintTypeIdentifier.TwoDBarcodeInstanceLabel,
                                                                instance.WeighingRequired,
                                                                datamatrix2DBarcode,
                                                                pleaseReturnText);

                    labelFormat = PrintTypeIdentifier.TwoDBarcodeInstanceLabel;
                }
                else
                {
                    instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                                customer.Text,
                                                                deliveryPointText,
                                                                concCI.PrimaryId,
                                                                PrintTypeIdentifier.InstanceLabel,
                                                                instance.WeighingRequired,
                                                                pleaseReturnText: pleaseReturnText);

                    labelFormat = PrintTypeIdentifier.InstanceLabel;
                }
                var oneDLabelType = instance?.Linear1dBarcodeId;
                var twoDLabelType = instance?.Datamatrix2dBarcodeId;
                AuditInstanceLabelPrint(instance.ContainerInstanceId, userId, stationId, facilityId, oneDLabelType, twoDLabelType, labelFormat, !isNewInstanceCreated);

                return new PrintDetails(printer.Text, 1, true, instanceLabelData.PrintTypeIdentifierValue, instanceLabelData);
            }
            catch (PathwayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog($"PrintEventHandler: PrintInstanceLabel: {ex.Message} - {DateTime.UtcNow}", EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// SetupInstanceLabelImage operation
        /// </summary>
        public IPrintDetails SetupInstanceLabelImage(IContainerInstance instance, string culture, short? linear1DBarcodeTypeId, short? datamatrix2DBarcodeTypeId)
        {
            var customerDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
            var deliveryPointDataAdapter = DataAdapterFactory.GetDeliveryPointDataAdapter(OperativeWorkUnit);
            var containerMasterDataAdapter = DataAdapterFactory.GetContainerMasterDataAdapter(OperativeWorkUnit);

            var containerMaster = containerMasterDataAdapter.GetActiveContainerMasterBydefinitionId(instance.ContainerMasterDefinitionId);
            var deliveryPoint = deliveryPointDataAdapter.GetDeliveryPoint(instance.DeliveryPointId);
            var customer = customerDataAdapter.GetActiveOneByDefinitionId(deliveryPoint.CustomerDefinitionId);

            var pleaseReturnText = TranslatorManager.GetText("pathway", "PTouchLabels", "PleaseReturnAfterUse", false, culture);

            InstanceLabelData instanceLabelData;
            var concCI = (ContainerInstance)instance;

            if (linear1DBarcodeTypeId != null && datamatrix2DBarcodeTypeId != null)
            {
                string linear1DBarcode = null;
                string datamatrix2DBarcode = null;
                linear1DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == linear1DBarcodeTypeId || cii.IsPrimary).OrderBy(cii => cii.IsPrimary).FirstOrDefault().Value;
                datamatrix2DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == datamatrix2DBarcodeTypeId || cii.IsPrimary).OrderBy(cii => cii.IsPrimary).FirstOrDefault().Value;

                instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                         customer.Text,
                                                         deliveryPoint.Text,
                                                         linear1DBarcode,
                                                         PrintTypeIdentifier.CombinedBarcodeInstanceLabel,
                                                         instance.WeighingRequired,
                                                         datamatrix2DBarcode,
                                                         pleaseReturnText);
            }
            else if (linear1DBarcodeTypeId != null)
            {
                string linear1DBarcode = null;
                linear1DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == linear1DBarcodeTypeId || cii.IsPrimary).OrderBy(cii => cii.IsPrimary).FirstOrDefault().Value;

                instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                            customer.Text,
                                                            deliveryPoint.Text,
                                                            linear1DBarcode,
                                                            PrintTypeIdentifier.InstanceLabel,
                                                            instance.WeighingRequired,
                                                            pleaseReturnText: pleaseReturnText);
            }
            else if (datamatrix2DBarcodeTypeId != null)
            {
                string datamatrix2DBarcode = null;
                datamatrix2DBarcode = concCI.ContainerInstanceIdentifier.Where(cii => cii.ContainerInstanceIdentifierTypeId == datamatrix2DBarcodeTypeId || cii.IsPrimary).OrderBy(cii => cii.IsPrimary).FirstOrDefault().Value;

                instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                            customer.Text,
                                                            deliveryPoint.Text,
                                                            datamatrix2DBarcode,
                                                            PrintTypeIdentifier.TwoDBarcodeInstanceLabel,
                                                            instance.WeighingRequired,
                                                            datamatrix2DBarcode,
                                                            pleaseReturnText);
            }
            else
            {
                instanceLabelData = new InstanceLabelData(containerMaster.Text,
                                                            customer.Text,
                                                            deliveryPoint.Text,
                                                            concCI.PrimaryId,
                                                            PrintTypeIdentifier.InstanceLabel,
                                                            instance.WeighingRequired,
                                                            pleaseReturnText: pleaseReturnText);
            }

            return new PrintDetails("Image Printer", 1, true, instanceLabelData.PrintTypeIdentifierValue, instanceLabelData);
        }

        /// <summary>
        /// SetupInstanceLabelImage operation
        /// </summary>
        public IPrintDetails SetupInstanceLabelImage(
            string containerMasterText,
            string customerText,
            string deliveryPointText,
            bool weighingRequired,
            string culture,
            string linear1DBarcode,
            string datamatrix2DBarcode)
        {
            InstanceLabelData instanceLabelData;

            var pleaseReturnText = TranslatorManager.GetText("pathway", "PTouchLabels", "PleaseReturnAfterUse", false, culture);

            if (!string.IsNullOrEmpty(linear1DBarcode) && !string.IsNullOrEmpty(datamatrix2DBarcode))
            {
                instanceLabelData = new InstanceLabelData(containerMasterText,
                                                         customerText,
                                                         deliveryPointText,
                                                         linear1DBarcode,
                                                         PrintTypeIdentifier.CombinedBarcodeInstanceLabel,
                                                         weighingRequired,
                                                         datamatrix2DBarcode,
                                                         pleaseReturnText);
            }
            else if (!string.IsNullOrEmpty(linear1DBarcode))
            {
                instanceLabelData = new InstanceLabelData(containerMasterText,
                                                            customerText,
                                                            deliveryPointText,
                                                            linear1DBarcode,
                                                            PrintTypeIdentifier.InstanceLabel,
                                                            weighingRequired,
                                                            pleaseReturnText: pleaseReturnText);
            }
            else if (!string.IsNullOrEmpty(datamatrix2DBarcode))
            {
                instanceLabelData = new InstanceLabelData(containerMasterText,
                                                            customerText,
                                                            deliveryPointText,
                                                            datamatrix2DBarcode,
                                                            PrintTypeIdentifier.TwoDBarcodeInstanceLabel,
                                                            weighingRequired,
                                                            datamatrix2DBarcode,
                                                            pleaseReturnText);
            }
            else
            {
                instanceLabelData = new InstanceLabelData(containerMasterText,
                                                            customerText,
                                                            deliveryPointText,
                                                            "NO BARCODE DATA",
                                                            PrintTypeIdentifier.InstanceLabel,
                                                            weighingRequired,
                                                            pleaseReturnText: pleaseReturnText);
            }

            return new PrintDetails("Image Printer", 1, true, instanceLabelData.PrintTypeIdentifierValue, instanceLabelData);
        }

        /// <summary>
        /// print an station label
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="station">The station.</param>
        /// <summary>
        /// PrintStationLabel operation
        /// </summary>
        public IPrintDetails PrintStationLabel(IPrinter printer, IStation station, bool localPrintingEnabled = false)
        {
            try
            {
                var stationLabelData = new StationLabelData(station.Text,
                                                            station.NTLogon);

                var printUtility = PrintFactory.Create();
                var printDetails = new PrintDetails(printer.Text,
                                                    1,
                                                    true,
                                                    PrintTypeIdentifier.StationLabel,
                                                    stationLabelData);

                if (localPrintingEnabled)
                {
                    printDetails.ReturnPdfData = true;
                    return printDetails;
                }

                printUtility.Print(printDetails);
                ErrorLog($"PrintEventHandler: Printed to:{printDetails.PrinterName} - {DateTime.UtcNow}", EventLogEntryType.Information);

                return null;
            }
            catch (PathwayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog($"PrintEventHandler: PrintStationLabel:{ex} - {DateTime.UtcNow}", EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// print a user tag
        /// </summary>
        /// <summary>
        /// PrintUserTag operation
        /// </summary>
        public IPrintDetails PrintUserTag(IPrinter printer, IUser user, bool localPrintingEnabled = false)
        {
            try
            {
                var userTagData = new UserTagData(user.FirstName, user.Surname, user.ExternalId);

                var printUtility = PrintFactory.Create();
                var printDetails = new PrintDetails(printer.Text,
                                                    1,
                                                    true,
                                                    PrintTypeIdentifier.UserTag,
                                                    userTagData);

                if (localPrintingEnabled)
                {
                    return printDetails;
                }

                printUtility.Print(printDetails);

                ErrorLog($"PrintEventHandler: Printed to:{printDetails.PrinterName} - {DateTime.UtcNow}", EventLogEntryType.Information);
                return null;
            }
            catch (PathwayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog($"PrintEventHandler: PrintUserTag:{ex} - {DateTime.UtcNow}", EventLogEntryType.Error);

                throw;
            }
        }

        /// <summary>
        /// PrintLocation operation
        /// </summary>
        public IPrintDetails PrintLocation(IPrinter printer, ILocation location, bool localPrintingEnabled = false)
        {
            try
            {
                var locationBarcodeData = new LocationBarcodeData(location.Text, location.ExternalId);
                var printDetails = new PrintDetails(printer.Text, 1, true, PrintTypeIdentifier.Location, locationBarcodeData);

                ErrorLog($"PrintEventHandler: Printed to:{printDetails.PrinterName} - {DateTime.UtcNow}", EventLogEntryType.Information);
                return printDetails;
            }
            catch (PathwayException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog($"PrintEventHandler: PrintUserTag:{ex} - {DateTime.UtcNow}", EventLogEntryType.Error);

                throw;
            }
        }

        #region Report prints

        /// <summary>
        /// Prints a pick list for the Order.
        /// </summary>
        /// <param name="orderNumber">The Order Number of the order to print the pick list for</param>
        /// <param name="printer">The printer to print on.</param>
        /// <param name="ownerId">The Id of the owner/facility</param>
        /// <summary>
        /// PrintOrderPickListReport operation
        /// </summary>
        public IPrintDetails PrintOrderPickListReport(IPrinter printer, string orderNumber, int ownerId, string systemId = null)
        {
            var parameters = new List<ReportParameter>();
            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            parameters.Add(new ReportParameter("OrderNumber", orderNumber));
            parameters.Add(new ReportParameter("OwnerId", ownerId.ToString()));
            var orderPickListReport = new ServerReportData(ReportTypeIdentifier.OrderPickList, parameters);

            var printDetails = new PrintDetails(printer.Text, 1, true, PrintTypeIdentifier.Report, orderPickListReport);

            return printDetails;
        }

        /// <summary>
        /// PrintLocationLabels operation
        /// </summary>
        public List<IPrintDetails> PrintLocationLabels(IPrinter printer, List<LocationBarcodeData> locationLabels, string pdfTitle)
        {
            var results = new List<IPrintDetails>();

            try
            {
                var printerName = printer == null
                    ? string.Empty
                    : printer.Text;

                var printDetails = new PrintDetails(printerName,
                    1,
                    true,
                    PrintTypeIdentifier.AveryLocationLabel,
                    new AveryLocationLabelsData(locationLabels, pdfTitle))
                { ReturnPdfData = true };

                results.Add(printDetails);
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintLocationLabels: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintLocationLabels: Exception: " + ex, EventLogEntryType.Error);

                throw;
            }

            return results;
        }

        /// <summary>
        /// PrintLocationLabels operation
        /// </summary>
        public List<IPrintDetails> PrintLocationLabels(IPrinter printer, List<LocationBarcodeData> locationLabels)
        {
            var results = new List<IPrintDetails>();

            try
            {
                var printerName = printer == null
                    ? string.Empty
                    : printer.Text;

                var printDetails = new PrintDetails(printerName,
                    1,
                    true,
                    PrintTypeIdentifier.AveryLocationLabel,
                    new AveryLocationLabelsData(locationLabels))
                { ReturnPdfData = true };

                results.Add(printDetails);
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintLocationLabels: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintLocationLabels: Exception: " + ex, EventLogEntryType.Error);
                throw;
            }

            return results;
        }

        /// <summary>
        /// print a tray list by turnaround
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="turnaround">The turnaround.</param>
        /// <param name="containerInstance">The container instance.</param>
        /// <param name="reprint">if set to <c>true</c> [reprint].</param>
        /// <summary>
        /// PrintTrayListByTurnaround operation
        /// </summary>
        public List<IPrintDetails> PrintTrayListByTurnaround(IPrinter printer, ITurnaround turnaround, ContainerInstance containerInstance, bool reprint, bool autoTickFirstCheck, bool isSupervisorNotAvailabe, string systemId = null)
        {
            var results = new List<IPrintDetails>();

            try
            {
                var deliveryPointDataAdapter = DataAdapterFactory.GetDeliveryPointDataAdapter(OperativeWorkUnit);
                var customer = (Customer)deliveryPointDataAdapter.GetCustomerByDeliveryPoint(turnaround.DeliveryPointId);

                ErrorLog("PrintTrayListByTurnaround:  step1:" + containerInstance.PrimaryId + " " + turnaround.TurnaroundId + " " + DateTime.UtcNow, EventLogEntryType.Information);

                var parameters = new List<ReportParameter>
                {
                    new ReportParameter("TurnaroundUid", turnaround.TurnaroundId.ToString()),
                    new ReportParameter("ContainerInstanceUid", containerInstance.ContainerInstanceId.ToString()),
                    new ReportParameter("Reprint", reprint.ToString())
                };

                if (!string.IsNullOrEmpty(systemId))
                {
                    parameters.Add(new ReportParameter("S", systemId));
                }

                GetStationeryVersion_Result stationeryVersion;
                if (customer != null && customer.PrintTrayListFrontSheet == true)
                {
                    stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TrayListFrontSheet, turnaround.CustomerDefinitionId, turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);
                    for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                    {
                        results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TrayListFrontSheet, parameters, stationeryVersion.ReportPath));
                    }
                }
                var tlparameters = new List<ReportParameter>
                {
                    new ReportParameter("TurnaroundUid", turnaround.TurnaroundId.ToString()),
                    new ReportParameter("ContainerInstanceUid", containerInstance.ContainerInstanceId.ToString()),
                    new ReportParameter("Reprint", reprint.ToString()),
                    new ReportParameter("AutoTickFirstCheck", autoTickFirstCheck.ToString()),
                    new ReportParameter("SupervisorNotAvailable", isSupervisorNotAvailabe.ToString())
                };

                if (!string.IsNullOrEmpty(systemId))
                {
                    tlparameters.Add(new ReportParameter("S", systemId));
                }
                ErrorLog("PrintTrayListByTurnaround:  step2:" + parameters + " " + DateTime.UtcNow, EventLogEntryType.Information);

                stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TrayList, turnaround.CustomerDefinitionId, turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);

                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TrayList, tlparameters, stationeryVersion.ReportPath));
                }

                return results;
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintTrayListByTurnaround: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintTrayListByTurnaround: Exception: " + ex, EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// GetStationeryVersion operation
        /// </summary>
        public GetStationeryVersion_Result GetStationeryVersion(Synergy.LabelPrinting.Enums.ReportTypeIdentifier reportType, int? customerDefinitionId, int? facilityId, int? tenancyId)
        {
            using (var repository = new PathwayRepository())
            {
                var context = repository.Container;

                var parameters = new Dictionary<string, object>
                {
                    {"ReportType", reportType.ToString()},
                    {"CustomerDefinitionId", customerDefinitionId},
                    {"FacilityId", facilityId},
                    {"TenancyId", tenancyId}
                };

                var dataCommand = DataCommandFactory.CreateCommand(context, System.Data.CommandType.StoredProcedure, "GetStationeryVersion", parameters);

                var results = dataCommand.GetEntityList<GetStationeryVersion_Result>().FirstOrDefault();

                if (results.ReportPath != null)
                {
                    if (results.NumberOfCopies == null)
                    {
                        results.NumberOfCopies = 1;
                    }

                    return results;
                }

                var noCustomReportResult = new GetStationeryVersion_Result
                {
                    ReportPath = reportType.ToString(),
                    NumberOfCopies = 1
                };

                return noCustomReportResult;
            }
        }

        /// <summary>
        /// print a tray list by container instance
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="containerMasterId"></param>
        /// <summary>
        /// PrintTrayListByDefinitionMaster operation
        /// </summary>
        public List<IPrintDetails> PrintTrayListByDefinitionMaster(IPrinter printer, IContainerMaster containerMasterId, string systemId = null)
        {
            try
            {
                ErrorLog($"PrintTrayListByDefinitionMaster:  step1:{containerMasterId.ContainerMasterId} {DateTime.UtcNow}", EventLogEntryType.Information);
                var parameters = new List<ReportParameter>
                {
                    new ReportParameter("ContainerMasterid", containerMasterId.ContainerMasterId.ToString())
                };

                if (!string.IsNullOrEmpty(systemId))
                {
                    parameters.Add(new ReportParameter("S", systemId));
                }

                ErrorLog("PrintTrayListByDefinitionMaster:  step2:" + parameters + " " + DateTime.UtcNow, EventLogEntryType.Information);

                var containerMasterDefinitionDataAdapter = DataAdapterFactory.GetContainerMasterDefinitionDataAdapter(OperativeWorkUnit);
                var containerMasterDefinition = containerMasterDefinitionDataAdapter.GetContainerMasterDefinition(containerMasterId.ContainerMasterDefinitionId);
                var customerDefinitionDataAdapter = DataAdapterFactory.GetCustomerDefinitionDataAdapter(OperativeWorkUnit);
                var customerDefinition = customerDefinitionDataAdapter.GetCustomerDefinition(containerMasterDefinition.CustomerDefinitionId);
                var customerDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
                var customer = customerDataAdapter.GetActiveOneByDefinitionId(customerDefinition.CustomerDefinitionId);
                var ownerDataAdapter = DataAdapterFactory.GetOwnerDataAdapter(OperativeWorkUnit);
                var owner = ownerDataAdapter.GetOwner(customerDefinition.OwnerId);

                var results = new List<IPrintDetails>();
                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ComponentList, customerDefinition.CustomerDefinitionId, customer.FacilityId, owner.TenancyId);
                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ComponentList, parameters, stationeryVersion.ReportPath));
                }

                return results;
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintTrayListByDefinitionMaster: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintTrayListByDefinitionMaster: Exception: " + ex, EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// print a tray list by container instance
        /// </summary>
        /// <summary>
        /// PrintTrayListByContainerInstance operation
        /// </summary>
        public List<IPrintDetails> PrintTrayListByContainerInstance(IPrinter printer, IContainerInstance containerInstanceId, string systemId = null)
        {
            try
            {
                ErrorLog($"PrintTrayListByContainerInstance:  step1:{containerInstanceId.ContainerInstanceId} {DateTime.UtcNow}", EventLogEntryType.Information);
                var parameters = new List<ReportParameter>
                {
                    new ReportParameter("ContainerInstanceUid", containerInstanceId.ContainerInstanceId.ToString())
                };

                if (!string.IsNullOrEmpty(systemId))
                {
                    parameters.Add(new ReportParameter("S", systemId));
                }

                ErrorLog($"PrintTrayListByContainerInstance:  step2:{parameters} {DateTime.UtcNow}", EventLogEntryType.Information);

                var containerInstance = (ContainerInstance)containerInstanceId;
                var results = new List<IPrintDetails>();

                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ContainerInstanceTrayList,
                    containerInstance.DeliveryPoint.CustomerDefinitionId,
                    containerInstance.FacilityId,
                    containerInstance.Facility.Owner.TenancyId);

                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ContainerInstanceTrayList, parameters, stationeryVersion.ReportPath));
                }

                return results;
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintTrayListByContainerInstance: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintTrayListByContainerInstance: Exception: " + ex, EventLogEntryType.Error);
                throw;
            }
        }

        /// <summary>
        /// print a trolley list
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="trolley">The trolley.</param>
        /// <summary>
        /// PrintTrolleyList operation
        /// </summary>
        public List<IPrintDetails> PrintTrolleyList(IPrinter printer, IContainerInstance trolley, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("TrolleyId", trolley.ContainerInstanceId.ToString())
                };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TrayList, ((Turnaround)trolley).CustomerDefinitionId, trolley.FacilityId, ((Turnaround)trolley).Facility.Owner.TenancyId);

            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TrolleyList, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// print a pack list
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="turnaround">The turnaround.</param>
        /// <summary>
        /// PrintPackList operation
        /// </summary>
        public List<IPrintDetails> PrintPackList(IPrinter printer, ITurnaround turnaround, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("id", turnaround.TurnaroundId.ToString())
                };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.PackList, turnaround.CustomerDefinitionId,
                    turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.PackList, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// print a delivery note
        /// </summary>
        /// <summary>
        /// PrintDeliveryNote operation
        /// </summary>
        public List<IPrintDetails> PrintDeliveryNote(IPrinter printer, IDeliveryNote deliveryNote, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("DeliveryNoteId", deliveryNote.DeliveryNoteId.ToString())
                };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            var fullDeliveryNote = (DeliveryNote)deliveryNote;
            var results = new List<IPrintDetails>();

            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.DeliveryNote, fullDeliveryNote.DeliveryPoint.CustomerDefinitionId,
                fullDeliveryNote.FacilityId, fullDeliveryNote.Facility.Owner.TenancyId);

            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.DeliveryNote, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints the details of the turnaround.
        /// </summary>
        /// <summary>
        /// PrintTurnaroundDetails operation
        /// </summary>
        public List<IPrintDetails> PrintTurnaroundDetails(ITurnaround turnaround, IPrinter printer, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("TurnaroundId", turnaround.TurnaroundId.ToString())
                };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TurnaroundDetails, turnaround.CustomerDefinitionId,
                turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TurnaroundDetails, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints the decontamination certificate.
        /// </summary>
        /// <summary>
        /// PrintDeContaminationCertificate operation
        /// </summary>
        public List<IPrintDetails> PrintDeContaminationCertificate(ITurnaround turnaround, IPrinter printer, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("item", turnaround.ContainerInstanceId.ToString())
                };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.DecontaminationCertificate, turnaround.CustomerDefinitionId, turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.DecontaminationCertificate, parameters, stationeryVersion.ReportPath));
            }
            return results;
        }

        /// <summary>
        /// Reprint the decontamination certificate.
        /// </summary>
        /// <summary>
        /// ReprintDecontaminationCertificate operation
        /// </summary>
        public List<IPrintDetails> ReprintDecontaminationCertificate(ITurnaround turnaround, IPrinter printer, string systemId = null)
        {
            var turnaroundEventId = turnaround.LastEventId.ToString();
            using (var workUnit = UnitOfWorkFactory.CreateOperativeEFUnitOfWork())
            {

                var turnaroundRepository = TurnaroundRepository.New(workUnit);

                var turnaroundInstance = turnaroundRepository.Get(turnaround.TurnaroundId);

                if (turnaroundInstance != null)
                {
                    var printDeconEvent = turnaroundInstance.TurnaroundEvent.Where(te => te.EventTypeId == (int)TurnAroundEventTypeIdentifier.PrintDecontaminationCertificate);
                    if (printDeconEvent == null)
                    {
                        return null;
                    }

                    turnaroundEventId = printDeconEvent.SingleOrDefault().TurnaroundEventId.ToString();
                }
            }

            var parameters = new List<ReportParameter>
            {
                new ReportParameter("TurnaroundEventId", turnaroundEventId)
            };

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            parameters.Add(new ReportParameter("Facilityid", Convert.ToString(turnaround.FacilityId)));

            var printUtility = PrintFactory.Create();
            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.DecontaminationCertificate, turnaround.CustomerDefinitionId, turnaround.FacilityId, ((Turnaround)turnaround).Facility.Owner.TenancyId);

            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                var printDetails = ProcessReportPrintJob(printer, ReportTypeIdentifier.DecontaminationCertificate, parameters, stationeryVersion.ReportPath);
                results.Add(printDetails);
            }

            return results;
        }

        /// <summary>
        /// Prints the customer service report
        /// </summary>
        /// <param name="customerDefect">The customer defect.</param>
        /// <param name="printer">The printer.</param>
        /// <summary>
        /// PrintCustomerServiceReport operation
        /// </summary>
        public List<IPrintDetails> PrintCustomerServiceReport(ICustomerDefect customerDefect, Guid systemId, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("CustomerDefectId", customerDefect.CustomerDefectId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var customerDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
            var customer = customerDataAdapter.ReadCustomerByItem(((CustomerDefect)customerDefect).Turnaround.ContainerMasterId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.CustomerDefect, customer.CustomerDefinitionId,
                    customerDefect.FacilityId, ((CustomerDefect)customerDefect).Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.CustomerDefect, parameters, stationeryVersion.ReportPath));
            }
            return results;
        }

        /// <summary>
        /// Prints the service report
        /// </summary>
        /// <param name="defect">The defect.</param>
        /// <param name="printer">The printer.</param>
        /// <summary>
        /// PrintServiceReport operation
        /// </summary>
        public List<IPrintDetails> PrintServiceReport(IDefect defect, Guid systemId, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("defectid", defect.DefectId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var results = new List<IPrintDetails>();

            if (defect.TurnaroundId != null)
            {
                var turnaroundDataAdapter = DataAdapterFactory.GetTurnaroundDataAdapter(OperativeWorkUnit);
                var turnaround = (Turnaround)turnaroundDataAdapter.GetTurnaround((int)defect.TurnaroundId);
                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ServiceReportAuditDetails, turnaround.CustomerDefinitionId,
                        turnaround.FacilityId, turnaround.Facility.Owner.TenancyId);
                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ServiceReportAuditDetails, parameters, stationeryVersion.ReportPath));
                }

                return results;
            }

            results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ServiceReportAuditDetails, parameters));
            return results;
        }

        /// <summary>
        ///  Prints loan set details
        /// </summary>
        /// <param name="reportId"></param>
        /// <param name="systemId"></param>
        /// <param name="printer"></param>
        /// <summary>
        /// PrintLoanSetReport operation
        /// </summary>
        public List<IPrintDetails> PrintLoanSetReport(IPrinter printer, Guid systemId, int reportId)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("LoanSetId", reportId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var loanSetDataAdapter = DataAdapterFactory.GetLoanSetDataAdapter(OperativeWorkUnit);
            var loanSet = loanSetDataAdapter.GetLoanSet(reportId);
            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility(loanSet.FacilityId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.LoanKitReport, loanSet.CustomerDefinitionId,
                    loanSet.FacilityId, facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.LoanKitReport, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints batch Turnaround details
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="systemId"></param>
        /// <param name="printer"></param>
        /// <summary>
        /// PrintBatchTurnaroundsReport operation
        /// </summary>
        public List<IPrintDetails> PrintBatchTurnaroundsReport(int batchId, int facilityId, Guid systemId, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("BatchId", batchId.ToString()),
                    new ReportParameter("FacilityId", facilityId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility((short)facilityId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TurnaroundsForBatch, null,
                    facilityId, facility.Owner.TenancyId);

            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TurnaroundsForBatch, parameters, stationeryVersion.ReportPath));
            }
            return results;
        }

        /// <summary>
        /// Prints the service report
        /// </summary>
        /// <param name="defect">The defect.</param>
        /// <param name="printer">The printer.</param>
        /// <summary>
        /// PrintServiceReportDetails operation
        /// </summary>
        public List<IPrintDetails> PrintServiceReportDetails(IDefect defect, Guid systemId, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("DefectId", defect.DefectId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var results = new List<IPrintDetails>();
            if (defect.TurnaroundId != null)
            {
                var turnaroundDataAdapter = DataAdapterFactory.GetTurnaroundDataAdapter(OperativeWorkUnit);
                var turnaround = (Turnaround)turnaroundDataAdapter.GetTurnaround((int)defect.TurnaroundId);

                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ServiceReport, turnaround.CustomerDefinitionId,
                        turnaround.FacilityId, turnaround.Facility.Owner.TenancyId);
                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ServiceReport, parameters, stationeryVersion.ReportPath));
                }

                return results;

            }
            results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ServiceReport, parameters));
            return results;
        }

        /// <summary>
        /// Prints the details of the turnaround.
        /// </summary>
        /// <summary>
        /// PrintMaintenanceReport operation
        /// </summary>
        public List<IPrintDetails> PrintMaintenanceReport(IPrinter printer, Guid systemId, IMaintenanceReport report)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("MaintenanceReportId", report.MaintenanceReportId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var turnaroundDataAdapter = DataAdapterFactory.GetTurnaroundDataAdapter(OperativeWorkUnit);
            var turnaround = (Turnaround)turnaroundDataAdapter.GetTurnaround(report.TurnaroundId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.MaintenanceReportDetail, turnaround.CustomerDefinitionId,
                    turnaround.FacilityId, turnaround.Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.MaintenanceReportDetail, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints the Sterlisation Report.
        /// </summary>
        /// <summary>
        /// PrintSterlisationReport operation
        /// </summary>
        public List<IPrintDetails> PrintSterlisationReport(IPrinter printer, Guid systemId, ISterilisationTestReport report)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("SterilisationTestReportId", report.SterilisationTestReportId.ToString()),
                    new ReportParameter("S", systemId.ToString())
                };

            var type = report.ReportType == (byte)SterilisationTestReportType.Daily ? ReportTypeIdentifier.DailyTestReport : ReportTypeIdentifier.WeeklyTestReport;

            var machineDataAdapter = DataAdapterFactory.GetMachineDataAdapter(OperativeWorkUnit);
            var machine = machineDataAdapter.GetMachine(report.MachineId);
            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility(machine.FacilityId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(type, null, machine.FacilityId, facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, type, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints the Instrument Stock Report.
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="facilityId"></param>
        /// <param name="isLocation"></param>
        /// <summary>
        /// PrintInstrumentStockReport operation
        /// </summary>
        public List<IPrintDetails> PrintInstrumentStockReport(IPrinter printer, short facilityId, bool isLocation, Guid SystemId, DataFilter filter)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("FacilityId", facilityId.ToString()),
                    new ReportParameter("IsLocation", isLocation.ToString()),
                    new ReportParameter("S", SystemId.ToString()),
                    new ReportParameter("ExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Text", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.Text.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemMasterExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemMasterExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ManufacturersReference", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ManufacturersReference.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemMasterText",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemMasterText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("LocationCode",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.LocationCode.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Quantity",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.Quantity.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy)
                };

            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility(facilityId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.InstrumentStock, null,
                    facilityId, facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.InstrumentStock, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// print a tray list by turnaround
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="turnaround">The turnaround.</param>
        /// <param name="containerInstance">The container instance.</param>
        /// <param name="reprint">if set to <c>true</c> [reprint].</param>
        /// <summary>
        /// PrintTrayListFrontSheetTurnaround operation
        /// </summary>
        public List<IPrintDetails> PrintTrayListFrontSheetTurnaround(IPrinter printer, ITurnaround turnaround, IContainerInstance containerInstance, bool reprint, string systemId)
        {
            try
            {
                var deliveryPointDataAdapter = DataAdapterFactory.GetDeliveryPointDataAdapter(OperativeWorkUnit);
                var customer = (Customer)deliveryPointDataAdapter.GetCustomerByDeliveryPoint(turnaround.DeliveryPointId);

                var parameters = new List<ReportParameter>
                {
                    new ReportParameter("TurnaroundUid", turnaround.TurnaroundId.ToString()),
                    new ReportParameter("ContainerInstanceUid", containerInstance.ContainerInstanceId.ToString()),
                    new ReportParameter("Reprint", reprint.ToString())
                };

                if (!string.IsNullOrEmpty(systemId))
                {
                    parameters.Add(new ReportParameter("S", systemId));
                }

                var turnaroundDataAdapter = DataAdapterFactory.GetTurnaroundDataAdapter(OperativeWorkUnit);
                var fullTurnaround = (Turnaround)turnaroundDataAdapter.GetTurnaround(turnaround.TurnaroundId);

                var results = new List<IPrintDetails>();
                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.TrayListFrontSheet, turnaround.CustomerDefinitionId,
                    turnaround.FacilityId, fullTurnaround.Facility.Owner.TenancyId);
                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.TrayListFrontSheet, parameters, stationeryVersion.ReportPath));
                }

                if (customer != null && customer.PrintTrayListFrontSheet == true)
                {
                    return results;
                }

                return null;
            }
            catch (PathwayException ex)
            {
                ErrorLog("PrintTrayListByTurnaround: PathwayException: " + ex, EventLogEntryType.Error);
                throw;
            }
            catch (Exception ex)
            {
                ErrorLog("PrintTrayListByTurnaround: Exception: " + ex, EventLogEntryType.Error);

                throw;
            }
        }

        #endregion

        private static IPrintDetails ProcessReportPrintJob(IPrinter printer, Synergy.LabelPrinting.Enums.ReportTypeIdentifier reportName, List<ReportParameter> parameters)
        {
            var printDetails = new PrintDetails(printer.Text,
                1,
                true,
                PrintTypeIdentifier.Report,
                new ServerReportData(reportName, parameters));
            return printDetails;
        }
        private static IPrintDetails ProcessReportPrintJob(IPrinter printer, Synergy.LabelPrinting.Enums.ReportTypeIdentifier reportName, List<ReportParameter> parameters, string customReport)
        {
            var printDetails = new PrintDetails(printer.Text,
                1,
                true,
                PrintTypeIdentifier.Report,
                new ServerReportData(reportName, parameters, customReport));
            return printDetails;
        }

        /// <summary>
        /// Prints the Instrument Stock Report.
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="facilityId"></param>
        /// <param name="isLocation"></param>
        /// <summary>
        /// PrintProductionSummary operation
        /// </summary>
        public List<IPrintDetails> PrintProductionSummary(short facilityId, int? baseItemTypeId, int? lastProcessEventTypeId, Synergy.Core.Data.DataFilter filter, IPrinter printer, Guid systemId, string userTimeZone)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("FacilityId", facilityId.ToString()),
                    new ReportParameter("BaseItemTypeId", baseItemTypeId.GetValueOrDefault() == default(int) ? null : baseItemTypeId.GetValueOrDefault().ToString()),
                    new ReportParameter("LastProcessEventTypeId", lastProcessEventTypeId.GetValueOrDefault() == default(int) ? null : lastProcessEventTypeId.GetValueOrDefault().ToString()),
                    new ReportParameter("TurnaroundExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.TurnaroundExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ContainerInstancePrimaryId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ContainerInstancePrimaryId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ContainerMasterName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ContainerMasterName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("LastEventName",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.LastEventName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("LastEventTime",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.LastEventTime.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Expiry",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.Expiry.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ServiceRequirementName",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ServiceRequirementName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("CustomerName",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.CustomerName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("QuarantineReasonText",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.QuarantineReason.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("FacilityName",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.FacilityName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("CustomerDefinitionId",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.SelectedCustomerDefinitions.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy),
                    new ReportParameter("S", systemId.ToString()),
                    new ReportParameter("UserTimeZone", userTimeZone)
                };

            foreach (var param in parameters)
            {
                if (param.Values[0] != null)
                {
                    param.Values[0] = param.Values[0].Replace("%3a", ":").Replace("+", " "); //MW: Replace url encoded colon with colon,then + with space
                }
            }

            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility(facilityId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ProductionReport, null,
                    facilityId, facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ProductionReport, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// Prints item instance list report
        /// </summary>
        /// <param name="printer">The printer.</param>
        /// <param name="facilityId"></param>
        /// <summary>
        /// PrintItemInstanceList operation
        /// </summary>
        public List<IPrintDetails> PrintItemInstanceList(short facilityId, int itemMasterDefId, Synergy.Core.Data.DataFilter filter, IPrinter printer, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("FacilityId", facilityId.ToString()),
                    new ReportParameter("ItemMasterDefinitionId", itemMasterDefId.ToString()),
                    new ReportParameter("TurnaroundExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.TurnaroundExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("InstanceId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.InstanceId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("TrayName",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ContainerMasterText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Status",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.Status.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ProcessEvent",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.LastEvent.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ContainerInstancePrimaryId",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ContainerInstancePrimaryId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy),
                    new ReportParameter("S", systemId)

                };

            var facilityDataAdapter = DataAdapterFactory.GetFacilityDataAdapter(OperativeWorkUnit);
            var facility = (Facility)facilityDataAdapter.GetFacility(facilityId);
            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ItemInstanceList, null, facilityId, facility.Owner.TenancyId);

            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ItemInstanceList, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// PrintSingleUseItems operation
        /// </summary>
        public List<IPrintDetails> PrintSingleUseItems(int customerDefinitionId, Guid systemId, Synergy.Core.Data.DataFilter filter, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("CustomerDefinitionId", customerDefinitionId.ToString()),
                    new ReportParameter("S", systemId.ToString()),
                    new ReportParameter("ExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemMasterExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Name", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemMasterText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemTypeName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemTypeText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("SingleUsePrice",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.SingleUsePrice.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy)
                };

            var facilityDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
            var customer = (Customer)facilityDataAdapter.GetActiveOneByDefinitionId(customerDefinitionId);
            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.SingleUseComponents, customerDefinitionId,
                    customer.FacilityId, customer.Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.SingleUseComponents, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        /// <summary>
        /// PrintDeliverableItems operation
        /// </summary>
        public List<IPrintDetails> PrintDeliverableItems(int customerDefinitionId, string searchText, Guid systemID, Synergy.Core.Data.DataFilter filter, IPrinter printer)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("CustomerDefinitionId", customerDefinitionId.ToString()),
                    new ReportParameter("SearchText", searchText),
                    new ReportParameter("S", systemID.ToString()),
                    new ReportParameter("ExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("Name", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.Text.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemTypeName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemTypeText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ContainerInstanceCount",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.NumOfContainerInstances.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("FinancialComponentCount",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.FinancialComponentCount.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("PriceCategoryName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.PriceCategoryText.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ReprocessingPrice", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ReprocessingPrice.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("SingleUsePrice", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.SingleUsePrice.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("AdjustmentPrice",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.AdjustmentPrice.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("TotalPrice",((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.TotalPrice.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy)
                };

            var facilityDataAdapter = DataAdapterFactory.GetCustomerDataAdapter(OperativeWorkUnit);
            var customer = (Customer)facilityDataAdapter.GetActiveOneByDefinitionId(customerDefinitionId);

            var results = new List<IPrintDetails>();
            var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ItemsForCustomer, customerDefinitionId,
                    customer.FacilityId, customer.Facility.Owner.TenancyId);
            for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
            {
                results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.ItemsForCustomer, parameters, stationeryVersion.ReportPath));
            }

            return results;
        }

        #region Error handling / status logging

        /// <summary>
        /// ErrorLog operation
        /// </summary>
        public void ErrorLog(string Message, EventLogEntryType eventLogType)
        {
            ////StreamWriter sw = null;

            ////try
            ////{
            ////    string sLogFormat = DateTime.UtcNow.ToShortDateString().ToString() + " " + DateTime.UtcNow.ToLongTimeString().ToString() + " ==> ";
            ////    string sPathName = @"C:\log\";

            ////    string sYear = DateTime.UtcNow.Year.ToString();
            ////    string sMonth = DateTime.UtcNow.Month.ToString();
            ////    string sDay = DateTime.UtcNow.Day.ToString();

            ////    string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

            ////    sw = new StreamWriter(sPathName + "TrakStar_ErrorLog_" + sErrorTime + ".txt", true);

            ////    sw.WriteLine(sLogFormat + Message);
            ////    sw.Flush();

            ////    WriteToEventLog(sLogFormat + Message, eventLogType);
        }
        #endregion

        /// <summary>
        /// PrintMaintainenceReports operation
        /// </summary>
        public List<IPrintDetails> PrintMaintainenceReports(IPrinter printer, short facilityId, bool? isClose, bool? isCancelled, int? turnaroundId, int? containerInstanceId, DataFilter filter, string systemId = null)
        {
            var parameters = new List<ReportParameter>
                {
                    new ReportParameter("FacilityId", facilityId.ToString()),
                    new ReportParameter("IsClose", isClose.GetValueOrDefault().ToString()),
                    new ReportParameter("IsCancelled", isCancelled.GetValueOrDefault().ToString()),
                    new ReportParameter("IsAscending", filter.OrderByAscending.ToString()),
                    new ReportParameter("SortField", filter.OrderBy),
                    new ReportParameter("PageIndex", (filter.Skip == -1 ? 0 : filter.Skip == 0 ? 1 : (1 + (filter.Skip / filter.Take))).ToString()),
                    new ReportParameter("PageSize", filter.Take.ToString()),
                    new ReportParameter("MaintenanceReportExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ItemName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ItemName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("TurnaroundExternalId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.TurnaroundExternalId.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("CreatedDate", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.CreatedDate.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("EstimatedCompletionDate", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.EstimatedCompletionDate.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("ModifiedDate", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.ModifiedDate.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("CustomerName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.CustomerName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("DeliveryPointName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.DeliveryPointName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("MaintenanceReportStatus", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.MaintenanceReportStatus.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("TurnaroundId", turnaroundId.ToString()),
                    new ReportParameter("ContainerInstanceId", containerInstanceId.ToString()),
                    new ReportParameter("VendorName", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.VendorName.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("StatusModifiedDate", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.StatusModifiedDate.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("MaintenanceTypeId", ((filter.SearchItems.FirstOrDefault(i => i.PropertyAlias == PropertyAlias.MaintenanceTypeIdString.ToString()) ?? (new SearchItem())).Value)),
                    new ReportParameter("S", systemId),
                };

            var results = new List<IPrintDetails>();
            if (turnaroundId != null)
            {
                var turnaroundDataAdapter = DataAdapterFactory.GetTurnaroundDataAdapter(OperativeWorkUnit);
                var turnaround = turnaroundDataAdapter.GetTurnaround((int)turnaroundId);

                var stationeryVersion = GetStationeryVersion(ReportTypeIdentifier.ItemsForCustomer, turnaround.CustomerDefinitionId,
                        turnaround.FacilityId, turnaround.Facility.Owner.TenancyId);
                for (var i = 0; i < stationeryVersion.NumberOfCopies; i++)
                {
                    results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.MaintenanceReportList, parameters, stationeryVersion.ReportPath));
                }

                return results;
            }

            results.Add(ProcessReportPrintJob(printer, ReportTypeIdentifier.MaintenanceReportList, parameters));
            return results;
        }

        /// <summary>
        /// AuditInstanceLabelPrint operation
        /// </summary>
        public void AuditInstanceLabelPrint(int containerInstanceId, int userId, int? stationId, short facilityId, short? oneDLabelType, short? twoDLabelType, PrintTypeIdentifier labelFormat, bool isReprint)
        {
            {
                var containerInstanceRepository = ContainerInstanceRepository.New(workUnit);
                var containerInstance = containerInstanceRepository.Get(containerInstanceId);

                if (containerInstance != null)
                {
                    var audit = ContainerInstanceLabelAuditFactory.CreateEntity(workUnit,
                        containerInstanceId: containerInstance.ContainerInstanceId,
                        created: DateTime.UtcNow,
                        createdUserId: userId,
                        stationId: stationId ?? 0,
                        facilityId: facilityId,
                        oneDLabelType: (byte?)oneDLabelType,
                        twoDLabelType: (byte?)twoDLabelType,
                        labelFormat: (byte)labelFormat,
                        reprint: isReprint
                    );

                    containerInstance.ContainerInstanceLabelAudit.Add(audit);
                    containerInstanceRepository.Save();
                }
            }
        }

        /// <summary>
        /// PrintServiceReportImage operation
        /// </summary>
        public IPrintDetails PrintServiceReportImage(IPrinter printer, string imagePath,
            bool localPrintingEnabled = false, string systemId = null)
        {
            var parameters = new List<ReportParameter>();
            var printUtility = PrintFactory.Create();

            if (!string.IsNullOrEmpty(systemId))
            {
                parameters.Add(new ReportParameter("S", systemId));
            }

            parameters.Add(new ReportParameter("ImagePath", imagePath));

            var printDetails = ProcessReportPrintJob(printer, ReportTypeIdentifier.ServiceReportImage, parameters);

            if (localPrintingEnabled)
            {
                printDetails.ReturnPdfData = true;
                return printDetails;
            }

            printUtility.Print((printDetails));

            return null;
        }
    }
}

}