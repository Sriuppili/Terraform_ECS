using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace SynergyApplicationFrameworkApi.Application.DTOs
{
	public sealed partial class ReportData
	{
	    public ReportData()
	    {
	    }

	    public ReportData(short reportId, string reportURL, byte reportCategoryId, string reportCategoryName, bool isLive, string text, string description)
		{

			ReportId = reportId;

			URL = reportURL;

			ReportCategoryId = reportCategoryId;

			ReportCategoryName = reportCategoryName;

			IsLive = isLive;
			
			Text = text;

			Description = description;

			EntityKeyValue = reportId.ToString();
		}

        public ReportData(short reportId, string reportURL, byte reportCategoryId, string reportCategoryName, bool isLive, string text, string description, byte reportTypeId)
        {

            ReportId = reportId;

            URL = reportURL;

            ReportCategoryId = reportCategoryId;

            ReportCategoryName = reportCategoryName;

            IsLive = isLive;

            Text = text;

            Description = description;

            ReportTypeId = reportTypeId;

            EntityKeyValue = reportId.ToString();
        }
		/// <summary>
		/// Gets or sets ReportCategoryName
		/// </summary>
		public string ReportCategoryName { get; set; }
        /// <summary>
        /// Gets or sets RoleReport
        /// </summary>
        public bool RoleReport { get; set; } = false; 

	}
}
