using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    public interface ITableNoteBuilder
    {
        ITableNoteBuilder AddColumm(string columnHeader);
        ITableNoteBuilder AddRow(params string[] data);
        Note Create();
    }
}
