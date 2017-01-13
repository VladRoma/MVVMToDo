using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using MVVMToDo.Model;

namespace MVVMToDo
{
    public class JsonFileService : IFileService
    {
        public List<TodoItem> Open(string filename)
        {
            List<TodoItem> todoItems = new List<TodoItem>();
            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<TodoItem>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                todoItems = jsonFormatter.ReadObject(fs) as List<TodoItem>;
            }

            return todoItems;
        }

        public void Save(string filename, List<TodoItem> todoItemsList)
        {
            DataContractJsonSerializer jsonFormatter =
                new DataContractJsonSerializer(typeof(List<TodoItem>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, todoItemsList);
            }
        }
    }
}
