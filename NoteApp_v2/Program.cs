using NoteApp_Lib;

Note textNote = NoteFactory.GetTextNote("Başlık")
    .AddParagraph("Parapraf 1")
    .AddParagraph("Paragraf 2")
    .Create();

textNote.Color = TextColor.Red;

Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textNote.Color.ToString());
Console.WriteLine(textNote.View());

Note tableNote = NoteFactory.GetTableNote()
    .AddColumm("Ad").AddColumm("Soyad")
    .AddRow("Harry", "Potter")
    .AddRow("Buse", "Tuba")
    .AddColumm("Telefon")
    .AddRow("Willy", "Wonka", "12345")
    .Create();

tableNote.Color = TextColor.Yellow;

Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), tableNote.Color.ToString());
Console.WriteLine(tableNote.View());

Note listNote = NoteFactory.GetListNote()
    .IsOrdered(true)
    .SetFormat(OrderedListTypes.Number)
    .AddItem("item 1")
    .AddItem("item 2")
    .AddItem("item 3")
    .Create();

listNote.Color = TextColor.Blue;
Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), listNote.Color.ToString());

Console.WriteLine(listNote.View());
