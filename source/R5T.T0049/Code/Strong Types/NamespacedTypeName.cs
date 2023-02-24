using System;

using R5T.Stagira;

using R5T.T0150;


namespace R5T.T0049
{
    [StrongTypeMarker]
    public sealed class NamespacedTypeName : TypedString
    {
        #region Static

        public static NamespacedTypeName From(string value)
        {
            var output = new NamespacedTypeName(value);
            return output;
        }

        #endregion


        public NamespacedTypeName(string value)
            : base(value)
        {
        }
    }
}
