using System;

namespace BuildingBlocks.Extensions
{
    public static class ObjectHelper
    {
        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }
    }
}