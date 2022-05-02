using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SharedParametersTransfer.Models;

namespace SharedParametersTransfer.Core
{
    public static class SpFileHelper
    {
        public static string GetSelectedFilePath()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
            }
        }

        public static Dictionary<string, string> GetGroupsNamingMap(IEnumerable<string> rawText)
        {
            var filteredGroups = rawText
                .Where(line => line.StartsWith("GROUP"))
                .ToList();

            var groupsNamingMap = new Dictionary<string, string>();

            foreach (var group in filteredGroups)
            {
                var parsedGroup = group.Split('\t');
                groupsNamingMap.Add(parsedGroup[1], parsedGroup[2]);
            }

            return groupsNamingMap;
        }

        public static IEnumerable<ParsedParameter> Parse(IEnumerable<string> filteredParams,
            IReadOnlyDictionary<string, string> groupsNamingMap)
        {
            var parsedParameters = new List<ParsedParameter>();
            foreach (var line in filteredParams)
            {
                var parameterValues = line.Split('\t').ToList();
                parameterValues.RemoveAt(0);

                var parsedParameter = new ParsedParameter();

                var parsedParameterFields = typeof(ParsedParameter).GetFields();

                for (int i = 0; i < parameterValues.Count; i++)
                {
                    var field = parsedParameter.GetType().GetField(parsedParameterFields[i].Name);

                    if (field.Name == "Group")
                    {
                        groupsNamingMap.TryGetValue(parameterValues[i], out var groupName);
                        field.SetValue(parsedParameter, groupName);
                        continue;
                    }

                    field.SetValue(parsedParameter, parameterValues[i]);
                }

                parsedParameters.Add(parsedParameter);
            }

            return parsedParameters;
        }
    }
}