using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Xipa_Poshta.Utils
{
    public class ItemComparer<T> : IEqualityComparer<T>
    {
        public bool Equals(T x, T y)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (!property.GetValue(x).Equals(property.GetValue(y)))
                {
                    return false;
                }
            }

            return true;
        }

        public int GetHashCode(T obj)
        {
            int hashCode = 17;
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                hashCode = hashCode * 23 + (value != null ? value.GetHashCode() : 0);
            }

            return hashCode;
        }
    }
}
