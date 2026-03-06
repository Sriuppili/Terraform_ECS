using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Infrastructure.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public partial class ContainerInstanceRepository
    {
        private Expression<Func<ContainerInstance, bool>> HasIdentifier(string scanString)
        {
            Expression<Func<ContainerInstance, bool>> predicate = ci => scanString != null && scanString != " " && ci.ContainerInstanceIdentifier.Any(cii => cii.Value == scanString);
            return predicate;
        }

        /// <summary>
        /// Gets the specified container instance id.
        /// </summary>
        /// <param name="containerInstanceId">The container instance id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// Get operation
        /// </summary>
        public ContainerInstance Get(int containerInstanceId)
        {
            return Repository.Find(ci => ci.ContainerInstanceId == containerInstanceId).Include("ContainerInstanceIdentifier")
                                                                                       .Include("ContainerInstanceIdentifier.ContainerInstanceIdentifierType")
                                                                                       .FirstOrDefault();
        }

        /// <summary>
        /// Gets the specified container instances.
        /// </summary>
        /// <param name="containerInstanceId">The list of container instance ids.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetMultiple operation
        /// </summary>
        public List<ContainerInstance> GetMultiple(List<int> containerInstanceIds)
        {
            return Repository.Find(ci => containerInstanceIds.Any(cids => cids == ci.ContainerInstanceId)).Include("ContainerInstanceIdentifier")
                                                                                                          .Include("ContainerInstanceIdentifier.ContainerInstanceIdentifierType")
                                                                                                          .ToList();
        }

        /// <summary>
        /// Gets the specified container instance id.
        /// </summary>
        /// <param name="containerInstanceId"></param>
        /// <returns>ContainerInstance</returns>
        /// <summary>
        /// Read operation
        /// </summary>
        public ContainerInstance Read(int containerInstanceId)
        {
            return Repository.Find(ci => ci.ContainerInstanceId == containerInstanceId && ci.Archived == null).Include("ContainerInstanceIdentifier")
                                                                                                              .Include("ContainerInstanceIdentifier.ContainerInstanceIdentifierType")
                                                                                                              .FirstOrDefault();
        }

        /// <summary>
        /// Gets a ContainerInstance by external ID and facility ID.
        /// </summary>
        /// <param name="primaryId"></param>
        /// <param name="facilityId"></param>
        /// <returns></returns>
        /// <summary>
        /// GetByPrimaryAndFacilityId operation
        /// </summary>
        public ContainerInstance GetByPrimaryAndFacilityId(string primaryId, short facilityId)
        {
            return Repository.Find(CustomLinqExpressions.ContainerInstanceHasPrimaryId(primaryId, facilityId)).FirstOrDefault();
        }
        /// <summary>
        /// GetAllByContainerMasterDefinitionAndFacilityId operation
        /// </summary>
        public List<ContainerInstance> GetAllByContainerMasterDefinitionAndFacilityId(int containerMasterDefinitionId, short facilityId)
        {
            return Repository.Find(ci => ci.ContainerMasterDefinitionId == containerMasterDefinitionId && ci.FacilityId == facilityId).ToList();
        }

        #region GetContainerInstancesByCustomerDefinitionId
        /// <summary>
        /// Gets the container instances by customer definition uid.  **DM NOT NEEDED AS CONTAINER MASTER RELATES TO CUST DEFINITION**
        /// </summary>
        /// <param name="customerDefinitionId">The customer definition id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstancesByCustomerDefinitionId operation
        /// </summary>
        public IQueryable<ContainerInstance> GetContainerInstancesByCustomerDefinitionId(int customerDefinitionId)
        {
            return Repository.Find(ci => ci.ContainerMasterDefinition.CustomerDefinitionId == customerDefinitionId && ci.Archived == null);
        }
        #endregion

        #region GetContainerInstancesByMasterAndFacility

        /// <summary>
        /// Gets the container instances by master.
        /// </summary>
        /// <param name="containerMasterDefinitionUid">The container master definition uid.</param>
        /// <param name="facilityId">The facility id.</param>
        /// <param name="archivedInstances"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstancesByMaster operation
        /// </summary>
        public IQueryable<ContainerInstance> GetContainerInstancesByMaster(int containerMasterDefinitionUid, short facilityId, bool? archivedInstances)
        {
            if (archivedInstances == null || archivedInstances == false)
            {
                return Repository.Find(ci => ci.ContainerMasterDefinitionId == containerMasterDefinitionUid && ci.FacilityId == facilityId && ci.Archived == null);

            }
            return Repository.Find(ci => ci.ContainerMasterDefinitionId == containerMasterDefinitionUid && ci.FacilityId == facilityId);

        }
        #endregion

        #region GetContainerInstancesByMaster
        /// <summary>
        /// Gets the container instances by master.
        /// </summary>
        /// <param name="containerMasterDefinitionId">The container master definition id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstancesByMasterDefinition operation
        /// </summary>
        public IQueryable<ContainerInstance> GetContainerInstancesByMasterDefinition(int containerMasterDefinitionId)
        {
            return Repository.Find(ci => ci.ContainerMasterDefinitionId == containerMasterDefinitionId && ci.Archived == null);
        }
        #endregion

        #region GetContainerInstanceLegacyId
        /// <summary>
        /// Gets the container instance legacy id.
        /// </summary>
        /// <param name="legacyId">The legacy id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstanceLegacyId operation
        /// </summary>
        public ContainerInstance GetContainerInstanceLegacyId(int legacyId)
        {
            return Repository.Find(ci => ci.LegacyExternalId.Equals(legacyId)).FirstOrDefault();
        }
        #endregion

        #region GetLastLiveTurnaroundByInstanceAndFacililtyId
        /// <summary>
        /// Gets the last live turnaround by instance.
        /// </summary>
        /// <param name="primaryId">The primary id.</param>
        /// <summary>
        /// GetLastLiveTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstance(string primaryId, short facilityId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(CustomLinqExpressions.TurnaroundContainerInstanceHasPrimaryId(primaryId, facilityId));
            return GetLastLiveTurnaround(turnarounds);
        }
        #endregion

        #region GetLastTurnaroundByExternalId
        /// <summary>
        /// Gets the last turnaround by instance
        /// </summary>
        /// <param name="externalId"></param>
        /// <returns></returns>
        /// <summary>
        /// GetLastTurnaroundByExternalOrAlternateId operation
        /// </summary>
        public Turnaround GetLastTurnaroundByExternalOrAlternateId(string externalId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());

            var instance = GetContainerInstanceByExternalOrAlternateId(externalId);

            if (instance != null)
            {
                var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == instance.ContainerInstanceId).ToList();
                return turnarounds.OrderByDescending(t => t.Created).FirstOrDefault();
            }

            return null;
        }
        #endregion

        #region GetLastTurnaroundByInstanceAndFacilityId
        /// <summary>
        /// Gets the last turnaround by instance
        /// </summary>
        /// <param name="primaryId"></param>
        /// <param name="facilityId"></param>
        /// <returns></returns>
        /// <summary>
        /// GetLastTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastTurnaroundByInstance(string primaryId, short facilityId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(CustomLinqExpressions.TurnaroundContainerInstanceHasPrimaryId(primaryId, facilityId));
            return turnarounds.OrderByDescending(t => t.Created).FirstOrDefault();
        }
        #endregion

        #region GetLastTurnaroundByInstance
        /// <summary>
        /// Gets the last turnaround by instance
        /// </summary>
        /// <param name="containerInstanceId"></param>
        /// <param name="facilityId"></param>
        /// <returns></returns>
        /// <summary>
        /// GetLastTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastTurnaroundByInstance(int containerInstanceId, short facilityId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == containerInstanceId && t.ContainerInstance.FacilityId == facilityId);
            return turnarounds.OrderByDescending(t => t.Created).FirstOrDefault();
        }
        #endregion

        #region GetLastTurnaroundByInstance
        /// <summary>
        /// Gets the last turnaround by instance
        /// </summary>
        /// <param name="containerInstanceId"></param>
        /// <returns></returns>
        /// <summary>
        /// GetLastTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastTurnaroundByInstance(int containerInstanceId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == containerInstanceId);
            return turnarounds.OrderByDescending(t => t.Created).FirstOrDefault();
        }
        #endregion

        #region

        /// <summary>
        /// GetLastWeighedTurnaround operation
        /// </summary>
        public Turnaround GetLastWeighedTurnaround(int containerInstanceId)
        {
            var turnaroundRepository = TurnaroundRepository.New(
                UnitOfWorkFactory.CreateOperativeEFUnitOfWork());

            var turnaround = turnaroundRepository.All().Where(t => t.ContainerInstanceId == containerInstanceId &&
                                                            t.TurnaroundEvent.Any(
                                                                te =>
                                                                    (te.EventTypeId == (short)TurnAroundEventTypeIdentifier.WeighedUsingPostWashTolerances
                                                                     || te.EventTypeId == (short)TurnAroundEventTypeIdentifier.WeighedUsingPreWashTolerances)
                                                                    &&
                                                                    te.TurnaroundEventWeight.Any(
                                                                        tew =>
                                                                            tew.WeightStatusId == (short)WeightStatus.Accepted ||
                                                                            tew.WeightStatusId == (short)WeightStatus.Passed)))
                                                        .OrderByDescending(t => t.TurnaroundId).FirstOrDefault();

            return turnaround;
        }
        #endregion

        #region GetLastLiveTurnaroundByInstanceAndFacililtyId
        /// <summary>
        /// Gets the last live turnaround by instance.
        /// </summary>
        /// <param name="containerInstanceId">The container instance id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetLastLiveTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstance(int containerInstanceId, short facilityId)
        {

            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == containerInstanceId && t.ContainerInstance.FacilityId == facilityId);
            return GetLastLiveTurnaround(turnarounds);
        }
        #endregion

        #region GetLastLiveTurnaroundByInstance
        /// <summary>
        /// Gets the last live turnaround by instance.
        /// </summary>
        /// <param name="containerInstanceId">The container instance id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetLastLiveTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstance(int containerInstanceId)
        {

            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == containerInstanceId);
            return GetLastLiveTurnaround(turnarounds);
        }

        /// <summary>
        /// GetLastTurnaroundIfNotArchived operation
        /// </summary>
        public Turnaround GetLastTurnaroundIfNotArchived(int containerInstanceId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnaround = turnaroundRepository.Repository
                .Find(t => t.ContainerInstanceId == containerInstanceId)
                .OrderByDescending(t => t.Created)
                .FirstOrDefault();
            return turnaround == null || turnaround.TurnaroundEvent.Any(te => te.EventType.IsArchiveEvent)
                ? null :
                turnaround;
        }

        /// <summary>
        /// Gets the last live turnaround by instance.
        /// </summary>
        /// <param name="containerInstanceId">The container instance id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetLastLiveTurnaroundByInstanceForStock operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstanceForStock(int containerInstanceId)
        {

            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == containerInstanceId);
            return GetLastLiveTurnaroundForStock(turnarounds);
        }

        #endregion

        #region GetLastLiveTurnaround
        /// <summary>
        /// GetLastLiveTurnaround operation
        /// </summary>
        public static Turnaround GetLastLiveTurnaround(IQueryable<Turnaround> turnarounds)
        {
            var orderedTurnaround = turnarounds.OrderByDescending(i => i.Created);
            return turnarounds.
                Select(t => new
                {
                    Turnaround = t,
                    Workflows = t.TurnaroundEvent.Select(te => te.Workflow),
                    LastWorkflow = t.TurnaroundEvent.Where(te => te.Workflow != null).OrderByDescending(te => te.Created).ThenByDescending(te => te.TurnaroundEventId).FirstOrDefault().Workflow
                }).
                Where(i =>
                    (i.Turnaround.TurnaroundId == orderedTurnaround.FirstOrDefault().TurnaroundId) &&
                    (i.Turnaround.StartEventId != null || i.Turnaround.LastEventId != null) &&
                    (!i.Workflows.Any() || !i.LastWorkflow.IsEnd)).
                Select(i => i.Turnaround).
                FirstOrDefault();
        }

        /// <summary>
        /// GetLastLiveTurnaroundForStock operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundForStock(IQueryable<Turnaround> turnarounds)
        {
            var orderedTurnaround = turnarounds.OrderByDescending(i => i.Created);
            return turnarounds.
                Select(t => new
                {
                    Turnaround = t,
                    Workflows = t.TurnaroundEvent.Select(te => te.Workflow),
                    LastWorkflow = t.TurnaroundEvent.Where(te => te.Workflow != null).OrderByDescending(te => te.Created).FirstOrDefault().Workflow
                }).
                Where(i =>
                    (i.Turnaround.TurnaroundId == orderedTurnaround.FirstOrDefault().TurnaroundId) &&
                    (i.Turnaround.StartEventId != null || i.Turnaround.LastEventId != null)).Select(i => i.Turnaround).FirstOrDefault();
        }

        #endregion

        #region GetPreviousTurnaroundByInstance
        /// <summary>
        /// Gets the previous turnaround by instance.
        /// </summary>
        /// <param name="containerInstanceId">The container instance uid.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetPreviousTurnaroundByInstance operation
        /// </summary>
        public Turnaround GetPreviousTurnaroundByInstance(int containerInstanceId)
        {
            return
                Repository.Find(ci => ci.ContainerInstanceId == containerInstanceId).SelectMany(
                    ci => ci.Turnaround).OrderByDescending(t => t.Created)
                    .FirstOrDefault();
        }

        /// <summary>
        /// Gets the previous turnaround by instance.
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="turnaroundId"></param>
        /// <returns></returns>
        /// <summary>
        /// ReadPreviousTurnaroundByInstanceAndTurnaround operation
        /// </summary>
        public ITurnaround ReadPreviousTurnaroundByInstanceAndTurnaround(int instanceId, int turnaroundId)
        {
            return
                Repository.Find(ci => ci.ContainerInstanceId == instanceId).SelectMany(
                    ci => ci.Turnaround).Where(i => i.TurnaroundId != turnaroundId).OrderByDescending(t => t.Created)
                    .FirstOrDefault();
        }
        #endregion

        #region GetLastTurnaround
        /// <summary>
        /// Gets the last turnaround.
        /// </summary>
        /// <param name="primaryId"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetLastTurnaround operation
        /// </summary>
        public Turnaround GetLastTurnaround(string primaryId, short facilityId)
        {
            return
                Repository.Find(CustomLinqExpressions.ContainerInstanceHasPrimaryId(primaryId, facilityId)).FirstOrDefault().Turnaround.OrderByDescending(
                        t => t.TurnaroundId).FirstOrDefault();
        }
        #endregion

        #region PreSearchContainerInstance

        /// <summary>
        /// PreSearchContainerInstance operation
        /// </summary>
        public ContainerInstance PreSearchContainerInstance(int containerInstanceId, short facilityId)
        {
            ContainerInstance instance = null;
            var mfpRepository = MultiFacilityProcessingRepository.New(Repository.UnitOfWork);
            var facilities = mfpRepository.GetPrimaryFacilities(facilityId);

            try
            {
                instance = Repository.Find(ci => ci.ContainerInstanceId == containerInstanceId && !ci.Archived.HasValue).FirstOrDefault();
            }
            catch (Exception)
            {

            }

            var turnaround = instance?.Turnaround.OrderByDescending(t => t.Created).FirstOrDefault();

            if (turnaround != null)
            {
                var lastProcessEvent = turnaround.TurnaroundEvent.OrderByDescending(te => te.Created).FirstOrDefault(te => te.EventType.ProcessEvent);

                if (lastProcessEvent?.Workflow != null && !lastProcessEvent.Workflow.IsEnd)
                {
                    if (!facilities.Contains(instance.FacilityId) && turnaround.TurnaroundFacility.All(tf => tf.FacilityId != facilityId))
                    {
                        instance = null;
                    }
                }
                else
                {
                    if (!facilities.Contains(instance.FacilityId))
                    {
                        instance = null;
                    }
                }
            }
            else
            {
                if (instance != null && !facilities.Contains(instance.FacilityId))
                {
                    instance = null;
                }
            }

            return instance;
        }

        /// <summary>
        /// PreSearch container instance.
        /// </summary>
        /// <param name="externalId">The external id.</param>
        /// <param name="facilityId">The facility id.</param>
        /// <param name="excludeTrolleyFromMFP">Prevents trolleys in MFP facilities from being returned.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// PreSearchContainerInstance operation
        /// </summary>
        public IQueryable<ContainerInstance> PreSearchContainerInstance(string externalId, short facilityId, bool excludeTrolleyFromMFP, TurnAroundEventTypeIdentifier eventToApply = TurnAroundEventTypeIdentifier.Unknown)
        {
            IList<ContainerInstance> instances = null;
            var facilities = new List<short>();

            var mfpRepository = MultiFacilityProcessingRepository.New(Repository.UnitOfWork);
            facilities = mfpRepository.GetPrimaryFacilities(facilityId);

            try
            {
                if (externalId == string.Empty)
                {
                    instances = Repository.Find(ci => ci.LegacyExternalId == externalId && !ci.Archived.HasValue).ToList();
                }
                else
                {
                    instances = Repository.Find(HasIdentifier(externalId)).Where(ci => !ci.Archived.HasValue).Include("ContainerInstanceIdentifier").Include("ContainerInstanceIdentifier.ContainerInstanceIdentifierType").ToList();
                }
            }
            catch { }

            if (instances == null)
                return new List<ContainerInstance>().AsQueryable();
            var instanceList = instances.ToList();
            var trolleys = new List<TrolleyDispatch_GetTrolleySummary_Result>(instanceList.Count);
            if(instanceList.Any(x=>x.ActiveContainerMaster?.BaseItemType?.ItemTypeId == (int)ItemTypeIdentifier.Trolley))
            {
                using (var trolleyRepository = InstanceFactory.GetInstance<ITrolleyDatabaseHelper>())
                {
                    trolleys = trolleyRepository.GetTrolleySummary(externalId, facilityId).Where(x => x.IsOwner || x.CanProcessForMFPCustomer).ToList();
                }
            }
            foreach (var ci in instanceList)
            {
                var turnaround = ci.Turnaround.OrderByDescending(t => t.Created).FirstOrDefault();
                if (excludeTrolleyFromMFP && ci.FacilityId != facilityId && ci.ActiveContainerMaster.BaseItemType.ItemTypeId == (int)ItemTypeIdentifier.Trolley && !trolleys.Select(x=>x.TrolleyInstanceId).Contains(ci.ContainerInstanceId))
                {
                    if (ci.CurrentTurnaround?.ChildTurnaround.FirstOrDefault()?.DeliveryPoint?.CustomerDefinition?.CurrentCustomer?.FacilityId != facilityId || eventToApply == TurnAroundEventTypeIdentifier.LoadTrolleyEPOC)
                        instances.Remove(ci);
                }
                else if (turnaround != null)
                {
                    var lastProcessEvent = turnaround.TurnaroundEvent.OrderByDescending(te => te.Created).FirstOrDefault(te => te.EventType.ProcessEvent);
                    var workflowRepository = WorkflowRepository.New(Repository.UnitOfWork);
                    var nextEventType = workflowRepository.ReadNextEvent(lastProcessEvent?.EventTypeId,
                        turnaround.ContainerMaster.ItemTypeId, turnaround.FacilityId, turnaround.ContainerMaster.ContainerMasterId, turnaround.ContainerInstance.DeliveryPointId);

                    if (lastProcessEvent != null && lastProcessEvent.Workflow != null && nextEventType != null)
                    {
                        var canStartAturnaroundWithThisEventType = false;

                        if (eventToApply != TurnAroundEventTypeIdentifier.Unknown)
                        {
                            canStartAturnaroundWithThisEventType = lastProcessEvent.Workflow.IsEnd
                                && workflowRepository.ReadWorkflow(null, (int)eventToApply, ci.ContainerMasterDefinition.ContainerMaster.ItemTypeId, facilityId, ci.ContainerMasterDefinition.ContainerMaster.ContainerMasterId, ci.DeliveryPointId) != null;
                        }
                        if (facilities.Contains(ci.FacilityId) || (turnaround.TurnaroundFacility.Any(tf => tf.FacilityId == facilityId) && !canStartAturnaroundWithThisEventType) || (ci.ActiveContainerMaster?.BaseItemType?.ItemTypeId == (int)ItemTypeIdentifier.Trolley && trolleys.Where(x=>x.CanProcessForAnyCustomerFacility == true).Select(x=>x.TrolleyInstanceId).Contains(ci.ContainerInstanceId)))
                        {
                        }
                        else
                        {
                            instances.Remove(ci);
                        }
                    }
                    else
                    {
                        if (!facilities.Contains(ci.FacilityId))
                        {
                            instances.Remove(ci);
                        }
                    }
                }
                else
                {
                    if ((!facilities.Contains(ci.FacilityId) && ci.ActiveContainerMaster?.BaseItemType?.ItemTypeId != (int)ItemTypeIdentifier.Trolley) || (!excludeTrolleyFromMFP && ci.ActiveContainerMaster?.BaseItemType?.ItemTypeId == (int)ItemTypeIdentifier.Trolley && !trolleys.Select(x=>x.TrolleyInstanceId).Contains(ci.ContainerInstanceId)) || (excludeTrolleyFromMFP && !trolleys.Select(x => x.TrolleyInstanceId).Contains(ci.ContainerInstanceId) && ci.ActiveContainerMaster?.BaseItemType?.ItemTypeId == (int)ItemTypeIdentifier.Trolley && ci.FacilityId != facilityId))
                    {
                        instances.Remove(ci);
                    }
                }
            }

            return instances.AsQueryable();
        }

        #endregion

        #region GetContainerInstanceByUidAndFacility
        /// <summary>
        /// Gets the container instance by uid and facility.
        /// </summary>
        /// <param name="containerInstanceId">The container instance id.</param>
        /// <param name="facilityId">The facility id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstanceByUidAndFacility operation
        /// </summary>
        public ContainerInstance GetContainerInstanceByUidAndFacility(int containerInstanceId, short facilityId)
        {
            var customerRepository = CustomerRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            return
                customerRepository.Repository.Find(
                    c => c.FacilityId == facilityId && c.CustomerStatusId == (int)CustomerStatusTypeIdentifier.Active)
                    .Select(c => c.CustomerDefinition).SelectMany(cd => cd.DeliveryPoint).Where(
                        dp => dp.Archived == null).SelectMany(dp => dp.ContainerInstance).Where(
                            ci => ci.Archived == null && ci.ContainerInstanceId == containerInstanceId).FirstOrDefault();
        }
        #endregion

        #region GetContainerInstanceByTurnaround
        /// <summary>
        /// Gets the container instance by turnaround.
        /// </summary>
        /// <param name="turnaroundId">The turnaround id.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        /// <summary>
        /// GetContainerInstanceByTurnaround operation
        /// </summary>
        public ContainerInstance GetContainerInstanceByTurnaround(int turnaroundId)
        {
            var turnaround = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var ci = turnaround.Repository.Find(t => t.TurnaroundId == turnaroundId).FirstOrDefault();
            return Repository.Find(c => c.ContainerInstanceId == ci.ContainerInstanceId).FirstOrDefault();
        }
        #endregion

        #region ReadTurnaroundsByContainerInstance
        /// <summary>
        /// Read turnarounds of instance
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        /// <summary>
        /// ReadTurnaroundsByContainerInstance operation
        /// </summary>
        public IQueryable<Turnaround> ReadTurnaroundsByContainerInstance(int instanceId, DateTime? start, DateTime? end)
        {
            var list = Repository.Find(ci => ci.ContainerInstanceId == instanceId).SelectMany(ci => ci.Turnaround);
            if (start != null)
                list = list.Where(t => t.Created >= start);
            if (end != null)
                list = list.Where(t => t.Created < end);
            return list;
        }
        #endregion

        #region DeliveryPointContainsInstances
        /// <summary>
        /// Reads all containers at a delivery point
        /// </summary>
        /// <param name="deliveryPointId"></param>
        /// <returns></returns>
        /// <summary>
        /// DeliveryPointContainsInstances operation
        /// </summary>
        public bool DeliveryPointContainsInstances(int deliveryPointId)
        {
            return Repository.Find(ci => ci.DeliveryPointId == deliveryPointId && ci.Archived == null).Count() > 0 ? true : false;
        }
        #endregion

        #region ContainerInstancesHasServiceRequirement
        /// <summary>
        /// ContainerInstancesHasServiceRequirement operation
        /// </summary>
        public bool ContainerInstancesHasServiceRequirement(int serviceRequirementDefinitionId)
        {
            return Repository.Find(ci => ci.ServiceRequirementDefinitionId == serviceRequirementDefinitionId && ci.Archived == null).Count() > 0 ? true : false;
        }
        #endregion

        /// <summary>
        /// GetPrintBarcodeCharges operation
        /// </summary>
        public ChargeList GetPrintBarcodeCharges(int containerInstanceId)
        {
            return
                Repository.Find(c => c.ContainerInstanceId == containerInstanceId).FirstOrDefault().DeliveryPoint.
                    CustomerDefinition.ChargeList.FirstOrDefault(j => j.Archived == null && j.ChargeListCategoryId == (byte)ChargeListCategoryIdentifier.BarcodeReplacement);

        }

        #region IsLastEventTypeReprintBarcode
        /// <summary>
        /// To check whether last event is ReprintBarcode
        /// </summary>
        /// <param name="containerInstanceId"></param>
        /// <returns></returns>
        /// <summary>
        /// IsLastEventTypeReprintBarcode operation
        /// </summary>
        public bool IsLastEventTypeReprintBarcode(int? containerInstanceId)
        {
            var conatinerMaster = Repository.Find(c => c.ContainerInstanceId == containerInstanceId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
            var context = new OperativeModelContainer();
            if (conatinerMaster != null)
            {
                var turnaround = context.Turnaround.Where(t => t.ContainerInstanceId == conatinerMaster.ContainerInstanceId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
                if (turnaround != null)
                {
                    var turnaroundLastEvent = context.TurnaroundEvent.Where(t => t.TurnaroundId == turnaround.TurnaroundId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
                    if (turnaroundLastEvent != null && turnaroundLastEvent.EventTypeId == (int)TurnAroundEventTypeIdentifier.ReprintInstanceBarcode)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

        #region IsLastEventTypeLegacyInstanceBarcodeReplaced
        /// <summary>
        /// To check whether last event is LegacyInstanceBarcodeReplaced
        /// </summary>
        /// <param name="containerInstanceId"></param>
        /// <returns>bool</returns>
        /// <summary>
        /// IsLastEventTypeLegacyInstanceBarcodeReplaced operation
        /// </summary>
        public bool IsLastEventTypeLegacyInstanceBarcodeReplaced(int? containerInstanceId)
        {
            var containerMaster = Repository.Find(c => c.ContainerInstanceId == containerInstanceId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
            var context = new OperativeModelContainer();
            if (containerMaster != null)
            {
                var turnaround = context.Turnaround.Where(t => t.ContainerInstanceId == containerMaster.ContainerInstanceId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
                if (turnaround != null)
                {
                    var turnaroundLastEvent = context.TurnaroundEvent.Where(t => t.TurnaroundId == turnaround.TurnaroundId).OrderByDescending(i => i.Created).Take(1).FirstOrDefault();
                    if (turnaroundLastEvent.EventTypeId == (int)TurnAroundEventTypeIdentifier.LegacyInstanceBarcodeReplaced)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        #endregion

        #region GetLastLiveTurnaroundByInstanceForNonProcessEvent
        /// <summary>
        /// GetLastLiveTurnaroundByInstanceForNonProcessEvent
        /// </summary>
        /// <param name="primaryId"></param>
        /// <param name="facilityId"></param>
        /// <returns>Turnaround</returns>
        /// <summary>
        /// GetLastLiveTurnaroundByInstanceForNonProcessEvent operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstanceForNonProcessEvent(string primaryId, short facilityId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(CustomLinqExpressions.TurnaroundContainerInstanceHasPrimaryId(primaryId, facilityId));
            return GetLastLiveTurnaroundForNonProcessEvent(turnarounds);
        }

        /// <summary>
        /// GetLastLiveTurnaroundByInstanceIdForNonProcessEvent
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="facilityId"></param>
        /// <returns>Turnaround</returns>
        /// <summary>
        /// GetLastLiveTurnaroundByInstanceIdForNonProcessEvent operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundByInstanceIdForNonProcessEvent(int instanceId, short facilityId)
        {
            var turnaroundRepository = TurnaroundRepository.New(UnitOfWorkFactory.CreateOperativeEFUnitOfWork());
            var turnarounds = turnaroundRepository.Repository.Find(t => t.ContainerInstance.ContainerInstanceId == instanceId && t.ContainerInstance.FacilityId == facilityId);

            using (var repository = new PathwayRepository())
            {
                if (turnarounds != null && turnarounds.Count() > 0)
                {
                    var turnaroundId = turnarounds.OrderByDescending(i => i.Created).FirstOrDefault().TurnaroundId;

                    var turnaroundEvents = repository.Container.TurnaroundEvent.Where(i => i.TurnaroundId == turnaroundId);

                    if (turnaroundEvents != null)
                    {
                        var isWorkflowEnd = turnaroundEvents.OrderByDescending(i => i.Created).Where(t => t.EventType.ProcessEvent).FirstOrDefault().Workflow.IsEnd;

                        if (isWorkflowEnd)
                            return null;
                    }
                }
            }

            return GetLastLiveTurnaroundForNonProcessEvent(turnarounds);
        }
        #endregion

        #region GetLastLiveTurnaroundForNonProcessEvent
        /// <summary>
        /// GetLastLiveTurnaroundForNonProcessEvent
        /// </summary>
        /// <param name="turnarounds"></param>
        /// <returns>Turnaround</returns>
        /// <summary>
        /// GetLastLiveTurnaroundForNonProcessEvent operation
        /// </summary>
        public Turnaround GetLastLiveTurnaroundForNonProcessEvent(IQueryable<Turnaround> turnarounds)
        {
            var orderedTurnaround = turnarounds.OrderByDescending(i => i.Created);
            return turnarounds.
                Select(t => new
                {
                    Turnaround = t,
                }).
                Where(i =>
                    (i.Turnaround.TurnaroundId == orderedTurnaround.FirstOrDefault().TurnaroundId) &&
                    (i.Turnaround.StartEventId != null || i.Turnaround.LastEventId != null)).
                Select(i => i.Turnaround).
                FirstOrDefault();
        }
        #endregion

        /// <summary>
        /// Read Container instances by the given searchText
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <summary>
        /// ReadContainerInstanceBySearchText operation
        /// </summary>
        public IQueryable<ContainerInstance> ReadContainerInstanceBySearchText(string searchText, short facilityId, Synergy.Core.Data.DataFilter filter)
        {
            var context = (OperativeModelContainer)Repository.UnitOfWork.Context;
            var instances = searchText != null ? context.ContainerInstance.Where
                (
                    i => i.FacilityId == facilityId && (i.ContainerInstanceIdentifier.Any(cii => cii.Value.Contains(searchText)) || i.ContainerMasterDefinition.ContainerMasters.Any(c => c.Text.Contains(searchText)))
                ) : context.ContainerInstance.Where(i => i.FacilityId == facilityId);
            var query = instances.
                Where(i => i.Archived == null).
                Select(i => new
                {
                    i.ContainerMasterDefinition,
                    ActiveContainerMaster = i.ContainerMasterDefinition.ContainerMasters.OrderByDescending(cm => cm.Revision).FirstOrDefault(),
                    ContainerInstance = i,
                });

            var queryFilter = query.SynergyCreateFilter(filter);
            queryFilter.MapProperty(PropertyAlias.ContainerInstancePrimaryId, i => i.ContainerInstance.PrimaryId, true);
            queryFilter.MapProperty(PropertyAlias.ContainerMasterName, i => i.ActiveContainerMaster.Text);
            queryFilter.MapProperty(PropertyAlias.ContainerMasterExternalId, i => i.ActiveContainerMaster.ExternalId);

            var items = query.
                SynergyFilter(queryFilter).
                ToList().
                Select(i => i.ContainerInstance).Distinct();

            return items.AsQueryable();
        }

        /// <summary>
        /// GetTargetTimeData operation
        /// </summary>
        public IList<TargetTime> GetTargetTimeData(int instanceId, int stationTypeId)
        {
            var context = (OperativeModelContainer)Repository.UnitOfWork.Context;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("ContainerInstanceId", instanceId);
            parameters.Add("StationTypeId", stationTypeId);
            var datacommand = DataCommandFactory.CreateCommand(context, CommandType.StoredProcedure, "GetTargetTime", parameters);
            return datacommand.GetEntityList<TargetTime>();
        }

        /// <summary>
        /// GetUserPerformance operation
        /// </summary>
        public IList<UserPerformance> GetUserPerformance(int userId, int stationTypeId)
        {
            var context = (OperativeModelContainer)Repository.UnitOfWork.Context;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("UserId", userId);
            parameters.Add("StationTypeId", stationTypeId);
            var dataCommand = DataCommandFactory.CreateCommand(context, CommandType.StoredProcedure, "GetUserRecentPerformance", parameters);
            return dataCommand.GetEntityList<UserPerformance>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        /// <summary>
        /// SearchContainerInstances operation
        /// </summary>
        public List<ContainerInstance> SearchContainerInstances(string searchTerm, int facilityId)
        {
            {
                var containerInstances = repository.DataManager.ExecuteQuery<ContainerInstance>((row, table, set) =>
                {
                    return new ContainerInstance
                    {
                        ContainerInstanceId = Convert.ToInt32(row["ID"]),
                        Text = row["Text"].ToString(),
                        ContainerInstanceIdentifier = new List<ContainerInstanceIdentifier>
                        {
                            new ContainerInstanceIdentifier
                            {
                                Value = row["ExternalID"].ToString(),
                                IsPrimary = true
                            }
                        }
                    };
                },
                "dbo.[IS_OmniSearch_Operative]",
                CommandType.StoredProcedure,
                new SqlParameter("@searchString", searchTerm),
                new SqlParameter("@facilityID", facilityId),
                new SqlParameter("@SearchType", "2,")
                );

                var v = containerInstances.Take(5);

                return v.ToList();
            }
        }

        /// <summary>
        /// GetFacilitiesEndoscopes operation
        /// </summary>
        public List<ContainerInstance> GetFacilitiesEndoscopes(short facilityId)
        {
            var customerstoCache = CustomerSettings.GetEndoscopyCachingCustomers();
            if (customerstoCache == null || !customerstoCache.Any()) return new List<ContainerInstance>(); //No one set to cache, so nothing to cache.
            var mfpRepository = MultiFacilityProcessingRepository.New(Repository.UnitOfWork);
            var facilityAndMfpFacilities = mfpRepository.GetPrimaryFacilities(facilityId);
            var customerRepo = CustomerDefinitionRepository.New(Repository.UnitOfWork);
            var customersToGet = customerRepo.Get(facilityAndMfpFacilities).Where(cd => customerstoCache.Contains(cd.CustomerDefinitionId)).Select(c => c.CustomerDefinitionId).ToList();

            if (customersToGet == null || !customersToGet.Any()) return new List<ContainerInstance>(); //No one for this facility or relevant facilities set to Cache
            return Repository.Find(ci => customersToGet.Contains(ci.ContainerMasterDefinition.CustomerDefinitionId) //customer is valid at this facility or mfp facility
                                         && ci.ContainerMasterDefinition.ContainerMaster.ItemType.ParentItemTypeId == (int)ItemTypeIdentifier.Endoscopy //endoscopes only
                                         && ci.Archived == null) // Exclude archived
                                    .OrderBy(c => c.PrimaryId).Take(200).ToList(); // 200 max to avoid massive cache and timeouts filling it!

        }

        /// <summary>
        /// GetContainerInstanceByExternalOrAlternateId operation
        /// </summary>
        public ContainerInstance GetContainerInstanceByExternalOrAlternateId(string externalId)
        {
            return Repository.Find(HasIdentifier(externalId)).Where(ci => !ci.Archived.HasValue).FirstOrDefault();
        }
    }
}