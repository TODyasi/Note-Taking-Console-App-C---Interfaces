using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteChive.MainMenu.MainMenu
{
    public interface IMainMenu
    {
        void DisplayMenu();
        string ProcessUserInput();
        void ProcessSelection(string choice);
    }
}
