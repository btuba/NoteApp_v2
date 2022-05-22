using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    internal class TextNote : Note
    {
        internal string Header { get; set; }
        internal List<string> Paragraphs { get; set; } // Paraghraph Builder
        public TextNote(string header)
        {
            Header = header;
            Paragraphs = new();
        }
        public override string View()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.AppendLine(Header);
            stringBuilder.AppendLine();
            
            foreach (string item in Paragraphs)
            {
                stringBuilder.AppendLine(item);
                stringBuilder.AppendLine();
            }
            
            return stringBuilder.ToString();
        }
    }
}
