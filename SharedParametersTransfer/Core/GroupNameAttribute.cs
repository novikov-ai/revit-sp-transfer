namespace SharedParametersTransfer.Core
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class GroupNameAttribute: System.Attribute
    {
        private string _name;

        public GroupNameAttribute(string name)
        {
            _name = name;
        }

        public string GetName() => _name;
    }
}