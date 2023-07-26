using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Table
    {
        public Table(string? tableName, int chairNumber)
        {
            TableName = tableName;
            ChairNumber = chairNumber;
        }

        public string? TableName { get; set; }
        public int ChairNumber { get; set; }
    }
}
