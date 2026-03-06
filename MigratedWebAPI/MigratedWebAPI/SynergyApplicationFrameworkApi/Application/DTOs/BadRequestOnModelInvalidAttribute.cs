using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SynergyApplicationFrameworkApi.Application.DTOs
{
    /// <summary>
    /// Action filter to force bad request on model invalid.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    /// <summary>
    /// BadRequestOnModelInvalidAttribute
    /// </summary>
    public class BadRequestOnModelInvalidAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// OnActionExecuting operation
        /// </summary>
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var modelState = actionContext.ModelState;
            if (modelState != null && !modelState.IsValid)
            {
                var errors = modelState.Values.Select(valueBinder => "Value: {0}, Errors : {1}".FormatWith(valueBinder.Value, string.Join(", ", valueBinder.Errors.Select(e => e.Exception == null ? e.ErrorMessage : e.Exception.Message).ToArray()))).ToList();

                var concat = string.Join(",", errors);
                
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, Services.Constants.General.Errors.InvalidBody + " : {0} ({1})".FormatWith(concat, errors.Count));
            }

            base.OnActionExecuting(actionContext);
        }
    }
}