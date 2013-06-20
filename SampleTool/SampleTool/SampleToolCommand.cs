using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Revit.UI;

namespace SampleTool
{
	public class SampleToolCommand : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
		{
			return Result.Succeeded;
		}
	}
}
