using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    public interface ITextNoteBuilder
    {
        // ITextNoteBuilder SetHeader(string header);
        ITextNoteBuilder AddParagraph(string content);
        Note Create();
    }
}
