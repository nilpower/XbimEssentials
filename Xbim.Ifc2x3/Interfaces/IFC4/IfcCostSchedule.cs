// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedMgmtElements
{
	public partial class @IfcCostSchedule : IIfcCostSchedule
	{
		Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum? IIfcCostSchedule.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCostScheduleTypeEnum.BUDGET:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.BUDGET;
					
					case IfcCostScheduleTypeEnum.COSTPLAN:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.COSTPLAN;
					
					case IfcCostScheduleTypeEnum.ESTIMATE:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.ESTIMATE;
					
					case IfcCostScheduleTypeEnum.TENDER:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.TENDER;
					
					case IfcCostScheduleTypeEnum.PRICEDBILLOFQUANTITIES:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.PRICEDBILLOFQUANTITIES;
					
					case IfcCostScheduleTypeEnum.UNPRICEDBILLOFQUANTITIES:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.UNPRICEDBILLOFQUANTITIES;
					
					case IfcCostScheduleTypeEnum.SCHEDULEOFRATES:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.SCHEDULEOFRATES;
					
					case IfcCostScheduleTypeEnum.USERDEFINED:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.USERDEFINED;
					
					case IfcCostScheduleTypeEnum.NOTDEFINED:
						return Ifc4.SharedMgmtElements.IfcCostScheduleTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcCostSchedule.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime? IIfcCostSchedule.SubmittedOn 
		{ 
			get
			{
				//## Handle return of SubmittedOn for which no match was found
			    return SubmittedOn != null
			        ? new Ifc4.DateTimeResource.IfcDateTime(SubmittedOn.ToISODateTimeString())
			        : null;
			    //##
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime? IIfcCostSchedule.UpdateDate 
		{ 
			get
			{
				//## Handle return of UpdateDate for which no match was found
                return UpdateDate != null
                    ? new Ifc4.DateTimeResource.IfcDateTime(UpdateDate.ToISODateTimeString())
                    : null;
				//##
			} 
		}
	}
}