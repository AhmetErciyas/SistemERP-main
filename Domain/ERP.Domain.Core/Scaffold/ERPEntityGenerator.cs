using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using System;

namespace ERP.Domain.Core
{
    public class ERPEntityTypeGenerator : CSharpEntityTypeGenerator
    {
        public ERPEntityTypeGenerator(IAnnotationCodeGenerator annotationCodeGenerator, ICSharpHelper cSharpUtilities)
            : base(cSharpUtilities)
        {
        }

        public override string WriteCode(IEntityType entityType, string @namespace, bool useDataAnnotations)
        {
            Console.WriteLine(entityType.Name);

            string code = base.WriteCode(entityType, @namespace, useDataAnnotations);

            var oldClassString = "public partial class " + entityType.Name;
            var newClassString = "public partial class " + entityType.Name + " : ERP.Data.Entity, ERP.Data.IAggregateRoot";
            code = code.Replace(oldClassString, newClassString);

            return code;
        }
    }
}