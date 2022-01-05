using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Colegial.Business.Extensions
{
    internal static class Mapeo
    {
        public static List<T> Mapear<T>(this DataTable dataTable)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow row)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();
            foreach (DataColumn column in row.Table.Columns)
            {
                foreach (PropertyInfo prop in temp.GetProperties())
                {
                    if (column.ColumnName == prop.Name)
                        prop.SetValue(obj, row[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
