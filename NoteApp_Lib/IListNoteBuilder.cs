using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    public interface IListNoteBuilder
    {
        IListNoteBuilder IsOrdered(bool order = true);
        IListNoteBuilder SetFormat(OrderedListTypes listType);
        IListNoteBuilder SetCharachter(UnorderedListTypes listType);
        IListNoteBuilder AddItem(string item);
        Note Create();
    }
    public enum OrderedListTypes //: byte max 255
    {
        Number = '1',
        Letter = 'a'
    }
    public enum UnorderedListTypes
    {
        Asterisk = '*',
        Dot = '.',
        Hypen = '-'
    }
}
