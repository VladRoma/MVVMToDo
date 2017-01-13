using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMToDo.Model;

namespace MVVMToDo
{
    public interface IFileService
    {
        List<TodoItem> Open(string filename);
        void Save(string filename, List<TodoItem> todoItemsList);
    }
}
