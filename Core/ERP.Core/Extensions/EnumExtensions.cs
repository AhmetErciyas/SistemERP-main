using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ERP.Core.Extensions
{
    public static class EnumExtensions
    {
        public static List<EnumValue> GetValues<T>()
        {
            List<EnumValue> values = new List<EnumValue>();
            foreach (var itemType in Enum.GetValues(typeof(T)))
            {
                //For each value of this enumeration, add a new EnumValue instance
                values.Add(new EnumValue()
                {
                    Name = Enum.GetName(typeof(T), itemType),
                    Value = (int)itemType
                });
            }
            return values;
        }
        public static List<KeyValuePair<string, int>> GetEnumValuesAndDescriptions<T>()
        {
            Type enumType = typeof(T);

            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T is not System.Enum");

            List<KeyValuePair<string, int>> enumValList = new List<KeyValuePair<string, int>>();

            foreach (var e in Enum.GetValues(typeof(T)))
            {
                var fi = e.GetType().GetField(e.ToString());
                var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                enumValList.Add(new KeyValuePair<string, int>((attributes.Length > 0) ? attributes[0].Description : e.ToString(), (int)e));
            }

            return enumValList;
        }
    }
    public static class EnumerationExtension
    {
        public static string Description(this Enum value)
        {
            // get attributes  
            return value.GetType()
                   .GetMember(value.ToString())
                   .First()
                   .GetCustomAttribute<DescriptionAttribute>()?
                   .Description ?? string.Empty;
        }
    }
    public class EnumValue
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}

