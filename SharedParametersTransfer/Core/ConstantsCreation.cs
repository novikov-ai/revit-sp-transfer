using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharedParametersTransfer.Models;

namespace SharedParametersTransfer.Core
{
    public static class ConstantsCreation
    {
        private const string NamespaceDeclaration = @"using System;
using SharedParametersTransfer.Models;

namespace SharedParametersTransfer {
public class SharedParameters {";
        
        private const string ParameterConstantClassName = nameof(ConstantParameter);
        private const string GroupAttributeName = nameof(GroupNameAttribute);
        
        private const string BasicNameGroup = "Group";
        private const string BasicNameParameter = "Parameter";

        private const string EndBrackets = @"}}";
        
        public static void CreateFile(string sharedFileParameter, List<IGrouping<string, ParsedParameter>> groups)
        {
            var outputFile = $"{Path.GetDirectoryName(sharedFileParameter)}\\Exported_{DateTime.Now:yyyyMMdd}.cs";
            
            using (var sw = new StreamWriter(outputFile))
            {
                sw.WriteLine(NamespaceDeclaration);

                var groupCount = 0;
                foreach (var group in groups)
                {
                    var parameterCount = 0;

                    sw.WriteLine($@"[{GroupAttributeName}(""{group.Key}"")]
public static class {BasicNameGroup}{groupCount}{{");

                    foreach (ParsedParameter fspParameter in group)
                    {
                        sw.WriteLine($@"/// <summary>
/// {fspParameter.Name}
/// </summary>
public static readonly {ParameterConstantClassName} {BasicNameParameter}{parameterCount} =
new {ParameterConstantClassName}(""{fspParameter.Name}"", new Guid(""{fspParameter.Guid}""));");

                        parameterCount++;
                    }

                    sw.WriteLine('}');
                    groupCount++;
                }

                sw.WriteLine(EndBrackets);
            }
        }
    }
}