using System;

using R5T.Stagira;


namespace R5T.T0049
{
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
