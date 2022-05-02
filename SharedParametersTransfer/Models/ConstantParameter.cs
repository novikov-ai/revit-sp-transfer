using System;

namespace SharedParametersTransfer.Models
{
    public class ConstantParameter
    {
        public readonly string Name;
        public readonly Guid Guid;

        public ConstantParameter(string name, Guid guid)
        {
            Name = name;
            Guid = guid;
        }
    }
}