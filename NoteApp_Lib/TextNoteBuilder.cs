using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    internal class TextNoteBuilder : ITextNoteBuilder
    {
        TextNote textNote;
        public TextNoteBuilder(string header)
        {
            textNote = new(header);
        }

        public ITextNoteBuilder AddParagraph(string content)
        {
            textNote.Paragraphs.Add(content);
            return this;
        }

        public Note Create()
        {
            return textNote;
        }
    }
}
