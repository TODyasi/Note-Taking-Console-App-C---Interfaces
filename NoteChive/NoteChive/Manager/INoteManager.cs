using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteChive.Manager
{
    public interface INoteManager
    {
        void AddNote();
        void DisplayNote();
        void DeleteNote();
        void EditNote();
    }
}
