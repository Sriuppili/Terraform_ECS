using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.Services
{
    /// <summary>
    /// EntLibWrapper,
    /// </summary>
    public class EntLibWrapper, ISynergyExceptionManager
    {
        protected ExceptionManager ExManager { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public EntLibWrapper()
        {
            var unityContainer = new UnityContainer()
                .AddNewExtension<EnterpriseLibraryCoreExtension>();
            ExManager = unityContainer.Resolve<ExceptionManager>();
        }

        #region ISynergyExceptionHandler Members

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <summary>
        /// HandleException operation
        /// </summary>
        public bool HandleException(Exception exception)
        {
            return ExManager.HandleException(exception, "DefaultHandling");
        }

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="policyName">Name of the policy.</param>
        /// <summary>
        /// HandleException operation
        /// </summary>
        public bool HandleException(Exception exception, String policyName)
        {
            return ExManager.HandleException(exception, policyName);
        }

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="policyName">Name of the policy.</param>
        /// <param name="exceptionToThrow">The exception to throw.</param>
        /// <summary>
        /// HandleException operation
        /// </summary>
        public bool HandleException(Exception exception, String policyName, out Exception exceptionToThrow)
        {
            return ExManager.HandleException(exception, policyName, out exceptionToThrow);
        }

        #endregion

        #region ISynergyExceptionManager Members

        /// <summary>
        /// Manages the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <summary>
        /// ManageException operation
        /// </summary>
        public void ManageException(Exception exception)
        {
            ExManager.HandleException(exception, "DefaultManagement");
        }

        /// <summary>
        /// Manages the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="policyName">Name of the policy.</param>
        /// <summary>
        /// ManageException operation
        /// </summary>
        public void ManageException(Exception exception, String policyName)
        {
            ExManager.HandleException(exception, policyName);
        }

        /// <summary>
        /// Manages the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="policyName">Name of the policy.</param>
        /// <param name="exceptionToThrow">The exception to throw.</param>
        /// <summary>
        /// ManageException operation
        /// </summary>
        public void ManageException(Exception exception, String policyName, out Exception exceptionToThrow)
        {
            ExManager.HandleException(exception, policyName, out exceptionToThrow);
        }

        #endregion
    }
}