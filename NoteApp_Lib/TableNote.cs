using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    internal class TableNote : Note
    {
        internal List<string> Columns { get; set; } // Column Builder
        internal List<List<string>> Rows { get; set; }
        public TableNote()
        {
            Columns = new();
            Rows = new();
        }
        public override string View()
        {
            StringBuilder stringBuilder = new();

            foreach (string item in Columns)
            {
                stringBuilder.Append($"{item}\t");
            }

            stringBuilder.AppendLine();
            
            foreach (List<string> row in Rows)
            {
                foreach (string item in row)
                {
                    stringBuilder.Append($"{item}\t");
                }
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }
    }
}
