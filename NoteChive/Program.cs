namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotesManager notesManager = new NotesManager();
            notesManager.AddNotes();
            notesManager.DisplayNotes();

        }
    }
}
