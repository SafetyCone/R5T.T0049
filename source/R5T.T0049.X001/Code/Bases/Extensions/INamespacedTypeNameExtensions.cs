using System;

using R5T.T0049;

using INamespacedTypeName = R5T.T0034.INamespacedTypeName; // Specified since R5T.T0034.NamespacedTypeName exists, so including R5T.T0034 would require specifying something.


namespace System
{
    public static class INamespacedTypeNameExtensions
    {
        public static NamespacedTypeName ToStronglyTypedNamespacedTypeName(this INamespacedTypeName _,
            string namespacedTypeName)
        {
            var output = NamespacedTypeName.From(namespacedTypeName);
            return output;
        }
    }
}
