using NoteChive.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteChive.Manager
{
    public class NotesManager : INoteManager
    {
        private List<NoteClass> Notes;
        public string Title { get; set; }
        public string Description { get; set; }



        public NotesManager()
        {
            Notes = new List<NoteClass>();
        }

        public void AddNote()
        {
            string userTitle;
            string userDescription;

            Console.WriteLine("Add title");
            userTitle = Console.ReadLine();

            Console.WriteLine("Add description");
            userDescription = Console.ReadLine();

            Title = userTitle;
            Description = userDescription;

        }

        public void DeleteNote()
        {
            Console.WriteLine("Delete note method works");
        }

        public void DisplayNote()
        {
            Console.WriteLine("Display note method works");
        }

        public void EditNote()
        {
            Console.WriteLine("Edit note method works");
        }
        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}";
        }
    }
}
