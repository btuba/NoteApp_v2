using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp_Lib
{
    internal class ListNoteBuilder : IListNoteBuilder
    {
        ListNote listNote;
        public ListNoteBuilder()
        {
            listNote = new();
        }
        public IListNoteBuilder AddItem(string item)
        {
            listNote.Items.Add(item);
            return this;
        }

        public Note Create()
        {
            return listNote;
        }

        public IListNoteBuilder IsOrdered(bool order = true)
        {
            listNote.IsOrdered = order;
            return this;
        }

        public IListNoteBuilder SetCharachter(UnorderedListTypes listType)
        {
            if(listNote.IsOrdered)
            {
                throw new Exception("Error!");
            }
            listNote.ListType = (char)listType;
            return this;
        }

        public IListNoteBuilder SetFormat(OrderedListTypes listType)
        {
            if(!listNote.IsOrdered)
            {
                throw new Exception("Error!");
            }
            listNote.ListType = (char)listType;
            return this;
        }
    }
}
