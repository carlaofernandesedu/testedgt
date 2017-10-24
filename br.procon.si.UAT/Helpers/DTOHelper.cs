using System;
using System.Data;
using System.Reflection;

namespace br.procon.si.UAT.Helpers
{
    public static class DTOHelper
    {
        public static T ConverterPara<T>(DataRow registro)
            where T : class, new()
        {
            var dto = new T();
            foreach (PropertyInfo prop in dto.GetType().GetProperties())
            {
                if (prop.CanWrite)
                {
                    var attributes = prop.GetCustomAttributes(typeof(Coluna), true);
                    var columnName = attributes.Length > 0 ? ((Coluna)attributes[0]).Nome : prop.Name;
                    if (registro.Table.Columns.Contains(columnName))
                    {
                        if (registro[columnName] != DBNull.Value)
                        {
                            if (prop.PropertyType == typeof(Int32))
                                prop.SetValue(dto, Convert.ToInt32(registro[columnName]), null);
                            else if (prop.PropertyType == typeof(decimal))
                                prop.SetValue(dto, Convert.ToDecimal(registro[columnName]), null);
                            else if (prop.PropertyType == typeof(DateTime))
                                prop.SetValue(dto, Convert.ToDateTime(registro[columnName]), null);
                            else
                                prop.SetValue(dto, registro[columnName].ToString(), null);
                        }
                    }
                }
            }
            return dto;
        }
    }
}