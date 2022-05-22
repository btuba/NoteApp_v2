namespace NoteApp_Lib
{
    // interface de olabilir
    public abstract class Note
    {
        public TextColor Color { get; set; }
        public abstract string View();
    }
}