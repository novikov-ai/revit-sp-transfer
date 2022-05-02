using System;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ConstantsUses.TransferResult;

namespace ConstantsUses
{
    internal class ExternalCommand: IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var uiApp = commandData.Application;
            var uiDoc = uiApp.ActiveUIDocument;
            var doc = uiDoc.Document;
            
            try
            {
                var randomWall = new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.OST_Walls)
                    .WhereElementIsNotElementType()
                    .ToElements()
                    .FirstOrDefault();

                if (randomWall is null)
                    return Result.Failed;

                // [BEST PRACTICE, PLEASE REPEAT] => Getting the parameter (AdskUnit) by the parameter Guid :)
                var parameterAdskUnit = randomWall.get_Parameter(AllParameters.Common.AdskUnit.Guid);

                // [!DON'T REPEAT THAT CODE, EXAMPLE ONLY!] => Getting the parameter (AdskUnit) by the parameter Name ;( 
                parameterAdskUnit = randomWall.LookupParameter(AllParameters.Common.AdskUnit.Name);

                // Summary notes:
                // [1] Please always get any parameters by the parameter Guid.
                // [2] If parameter is not SHARED, it's better to use get_Parameter() with BuiltInParameter overload.
                // [3] You could use name of the ConstantsParameter to display it in UI, when you build WPF apps.
                
                return Result.Succeeded;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}