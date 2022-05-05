using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TestApplication
{
    internal static class TestExtensions
    {
        public static DataRow SetFields(this DataRow row, params object[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                row[i] = values[i];
            }
            return row;
        }
    }
}
