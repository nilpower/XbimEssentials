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
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.GeometricConstraintResource
{
	public partial class @IfcConnectionSurfaceGeometry : IIfcConnectionSurfaceGeometry
	{

		[CrossSchemaAttribute(typeof(IIfcConnectionSurfaceGeometry), 1)]
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatingElement 
		{ 
			get
			{
				if (SurfaceOnRelatingElement == null) return null;
				var ifcfacebasedsurfacemodel = SurfaceOnRelatingElement as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
					return ifcfacebasedsurfacemodel;
				var ifcfacesurface = SurfaceOnRelatingElement as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
					return ifcfacesurface;
				var ifcsurface = SurfaceOnRelatingElement as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
					return ifcsurface;
				return null;
			} 
			set
			{
				if (value == null)
				{
					SurfaceOnRelatingElement = null;
					return;
				}	
				var ifcfacebasedsurfacemodel = value as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
				{
					SurfaceOnRelatingElement = ifcfacebasedsurfacemodel;
					return;
				}
				var ifcfacesurface = value as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
				{
					SurfaceOnRelatingElement = ifcfacesurface;
					return;
				}
				var ifcsurface = value as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
				{
					SurfaceOnRelatingElement = ifcsurface;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConnectionSurfaceGeometry), 2)]
		IIfcSurfaceOrFaceSurface IIfcConnectionSurfaceGeometry.SurfaceOnRelatedElement 
		{ 
			get
			{
				if (SurfaceOnRelatedElement == null) return null;
				var ifcfacebasedsurfacemodel = SurfaceOnRelatedElement as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
					return ifcfacebasedsurfacemodel;
				var ifcfacesurface = SurfaceOnRelatedElement as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
					return ifcfacesurface;
				var ifcsurface = SurfaceOnRelatedElement as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
					return ifcsurface;
				return null;
			} 
			set
			{
				if (value == null)
				{
					SurfaceOnRelatedElement = null;
					return;
				}	
				var ifcfacebasedsurfacemodel = value as GeometricModelResource.IfcFaceBasedSurfaceModel;
				if (ifcfacebasedsurfacemodel != null) 
				{
					SurfaceOnRelatedElement = ifcfacebasedsurfacemodel;
					return;
				}
				var ifcfacesurface = value as TopologyResource.IfcFaceSurface;
				if (ifcfacesurface != null) 
				{
					SurfaceOnRelatedElement = ifcfacesurface;
					return;
				}
				var ifcsurface = value as GeometryResource.IfcSurface;
				if (ifcsurface != null) 
				{
					SurfaceOnRelatedElement = ifcsurface;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}