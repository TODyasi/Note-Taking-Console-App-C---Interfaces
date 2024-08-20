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
        // Dictionary to store notes with the title as the key and description as the value
        private readonly Dictionary<string, string> _notesDictionary = new Dictionary<string, string>();

        public void AddNote()
        {
            // Variables to store user input for title and description
            string userTitle;
            string userDescription;

            // Prompt user to enter a title for the note
            Console.WriteLine("Add title");
            userTitle = Console.ReadLine();

            // Check if the title already exists in the dictionary
            if (_notesDictionary.ContainsKey(userTitle))
            {
                Console.WriteLine("Title already exists");
                return; // Exit the method if the title is a duplicate
            }

            // Prompt user to enter a description for the note
            Console.WriteLine("Add description");
            userDescription = Console.ReadLine();

            // Add the new note to the dictionary
            _notesDictionary.Add(userTitle, userDescription);
        }

        public void DeleteNote()
        {
            // Prompt user to enter the title of the note they wish to delete
            Console.WriteLine("Enter title to delete");
            string userTitle = Console.ReadLine();

            // Check if the note with the given title exists in the dictionary
            if (_notesDictionary.ContainsKey(userTitle))
            {
                // Remove the note from the dictionary
                _notesDictionary.Remove(userTitle);
                Console.WriteLine($"{userTitle} has been successfully deleted");
            }
            else
            {
                // Inform user if the title does not exist
                Console.WriteLine("Enter correct title");
            }
        }

        public void DisplayNote()
        {
            // Check if there are no notes in the dictionary
            if (_notesDictionary.Count == 0)
            {
                Console.WriteLine("No notes exist in the current dictionary");
            }
            else
            {
                // Iterate through each note in the dictionary and display its title and description
                foreach (var note in _notesDictionary)
                {
                    Console.WriteLine($"Title: {note.Key} \nDescription: {note.Value} ");
                }
            }
        }

        public void EditNote()
        {
            // Prompt user to enter the title of the note they wish to edit
            Console.WriteLine("Enter title of note you wish to edit");
            string noteTitle = Console.ReadLine(); // Store the entered title

            // Check if the note with the given title exists in the dictionary
            if (_notesDictionary.ContainsKey(noteTitle))
            {
                // Prompt user to enter the new description for the note
                Console.WriteLine("Enter new description");
                string newDescription = Console.ReadLine();

                // Update the note's description in the dictionary
                _notesDictionary[noteTitle] = newDescription;

                Console.WriteLine("Description Updated");
            }
            else
            {
                // Inform user if the note with the given title does not exist
                Console.WriteLine($"{noteTitle} not found");
                return; // Exit the method if the note does not exist
            }
        }
    }
}
