using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopManager.Other
{
    public static class Validator
    {
        public static void Validation(object value, string type)
        {
            if(value is string)
            {
                string s = value.ToString();
                if(s == null || s == "")
                {
                    throw new ArgumentNullException(string.Format("{0} cannot be null or empty."), type);
                }
            }
            else
            {
                if (value is int)
                {
                    int i = (int)value;
                    IsNegative(i, type);
                }
                if(value is decimal)
                {
                    decimal d = (decimal)value;
                    IsNegative(d, type);
                }
            }     
        }

        private static void IsNegative<T>(T value, string type) where T : IComparable<T>
        {
            if(value.CompareTo(default(T)) < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} cannot be negative."), type);
            }
        }

    }
}
