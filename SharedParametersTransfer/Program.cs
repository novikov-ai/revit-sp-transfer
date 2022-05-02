using System;
using System.IO;
using System.Linq;
using SharedParametersTransfer.Core;

namespace SharedParametersTransfer
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                var spFile = SpFileHelper.GetSelectedFilePath();
                if (spFile is null)
                    return;

                var rawText = File.ReadAllLines(spFile);

                var groupsNamingMap = SpFileHelper.GetGroupsNamingMap(rawText);

                var filteredParams = rawText
                    .Where(line => line.StartsWith("PARAM"));

                var parsedParameters = SpFileHelper.Parse(filteredParams, groupsNamingMap);

                var groupedParsedParameters = parsedParameters
                    .GroupBy(param => param.Group)
                    .ToList();

                if (!groupedParsedParameters.Any())
                    return;

                ConstantsCreation.CreateFile(spFile, groupedParsedParameters);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error happened: {e.Message}");
                throw;
            }
        }
    }
}