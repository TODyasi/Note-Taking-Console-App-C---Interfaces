using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class NotesManager
    {
        private List<NoteClass> Notes;

        public NotesManager()
        {
            Notes = new List<NoteClass>();
        }
        public void AddNotes()
        {
            NoteClass note = new NoteClass();
            note.GetUserInput();
            Notes.Add(note);
        }

        public void DisplayNotes()
        {
            foreach (var note in Notes)
            {
                Console.WriteLine(note.ToString());
            }
        }
           
    }
}
