using SkillTree.Mapping.Models.Dtos;
using SkillTree.Mapping.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Mapping.Models.Mapping
{
    public static class CustomMapper<TSrc, TDest>
    where TSrc : class
    where TDest : new()
    {
        public static TDest Map(TSrc source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source), "Source object cannot be null.");

            TDest destination = new TDest();

            Type sourceType = typeof(TSrc);
            Type destType = typeof(TDest);

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destProperties = destType.GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                var destProperty = Array.Find(destProperties, p => p.Name == sourceProperty.Name && p.PropertyType == sourceProperty.PropertyType);

                if (destProperty != null && destProperty.CanWrite)
                {
                    object value = sourceProperty.GetValue(source);
                    destProperty.SetValue(destination, value);
                }
            }

            return destination;
        }
    }
}
