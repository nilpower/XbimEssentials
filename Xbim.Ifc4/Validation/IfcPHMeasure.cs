using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.MeasureResource
{
	public partial struct IfcPHMeasure 
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.MeasureResource.IfcPHMeasure");

		/// <summary>
		/// Tests the express where clause WR21
		/// </summary>
		/// <returns>true if the clause is satisfied.</returns>
		public bool WR21() {
			var retVal = false;
			try {
				retVal = ((0 <= this) && (this <= 14) );
			} catch (Exception ex) {
				Log.Error($"Exception thrown evaluating where-clause 'WR21'.", ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!WR21())
				yield return new ValidationResult() { Item = this, IssueSource = "WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}