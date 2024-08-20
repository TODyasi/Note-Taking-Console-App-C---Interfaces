using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteChive.Manager;
using NoteChive.MainMenu;

namespace NoteChive.MainMenu.MainMenu
{
    public class MainMenu : IMainMenu
    {
        private NotesManager notesManager;

        public MainMenu()
        {
            notesManager = new NotesManager();
        }
        public void DisplayMenu()
        {
            //Loop to display menu until the user wants to exit
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                Console.WriteLine("");
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. Delete Note");
                Console.WriteLine("3. Edit Note");
                Console.WriteLine("4. Display Note");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.WriteLine("=======================================================");
                Console.WriteLine("");

                string choice = ProcessUserInput();

                if(choice == "5")
                {

                    break;
                }

                ProcessSelection(choice);
            }
        }

        public string ProcessUserInput()
        {
           Console.WriteLine("Enter your choice");
            return Console.ReadLine();
        }

        public void ProcessSelection(string choice)
        {
            
            switch (choice)
            {
               
                case "1":
                    notesManager.AddNote();
                    break;
                case "2":
                    notesManager.DeleteNote();
                    break;
                case "3":
                    notesManager.EditNote();
                    break;
                case "4":
                    notesManager.DisplayNote();
                    break;
                default:
                    Console.WriteLine("Invalid selection, please try again");
                    break;
            }
        }
    }
}
