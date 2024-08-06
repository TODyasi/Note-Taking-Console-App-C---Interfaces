using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class NoteClass
    {
        public string Title { get; set; }
        public string Description { get; set; }

       
        public void GetUserInput()
        {
            string userTitle;
            string userDescription;

            Console.WriteLine("Add title");
            userTitle = Console.ReadLine();

            Console.WriteLine("Add description");
            userDescription = Console.ReadLine();

            this.Title = userTitle;
            this.Description = userDescription;

        }
        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}";
        }      
    }
}
