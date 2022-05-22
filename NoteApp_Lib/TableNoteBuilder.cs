using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    internal class TableNoteBuilder : ITableNoteBuilder
    {
        TableNote tableNote;
        public TableNoteBuilder()
        {
            tableNote = new();
        }
        public ITableNoteBuilder AddColumm(string columnHeader)
        {
            //if(tableNote.Rows.Count > 0)
            //{
            //    throw new Exception("Error");
            //}
            if (tableNote.Rows.Count > 0)
            {
                foreach(var row in tableNote.Rows)
                {
                    row.Add("");
                }
            }
            tableNote.Columns.Add(columnHeader);
            return this;
        }

        public ITableNoteBuilder AddRow(params string[] data)
        {
            if(data.Length != tableNote.Columns.Count)
            {
                throw new Exception("Error!");
            }
            tableNote.Rows.Add(data.ToList());
            return this;
        }

        public Note Create()
        {
            return tableNote;
        }

        //public void AddRow(Dictionary<string,string> rowData)
        //{

        //}
    }
}
