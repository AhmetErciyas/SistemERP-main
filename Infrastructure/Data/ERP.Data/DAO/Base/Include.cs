using System.Collections.Generic;

namespace ERP.Data.DAO.Base
{
    public class Include
    {
        public string IncludeName { get; set; }
        public IncludeType IncludeType { get; set; }
        public List<Include> Includes { get; set; } = new List<Include>();

        public static Include Create(string includeName, IncludeType includeType)
        {
            return new Include()
            {
                IncludeName = includeName,
                IncludeType = includeType
            };
        }

        public Include Add(string includeName, IncludeType includeType)
        {
            Includes.Add(Create(includeName, includeType));
            return this;
        }

        public Include Add(Include includeTable)
        {
            Includes.Add(includeTable);
            return this;
        }
    }

    public enum IncludeType
    {
        Reference,
        Collection
    }
}
