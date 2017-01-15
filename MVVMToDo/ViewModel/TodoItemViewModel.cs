using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MVVMToDo.Model;

namespace MVVMToDo.ViewModel
{
   public class TodoItemViewModel:INotifyPropertyChanged
    {
        private TodoItem todoItem;

        public TodoItemViewModel(TodoItem p)
        {
            todoItem = p;
        }

       private bool showDone;

       public bool ShowDone
       {
            get { return showDone; }
           set
           {
               todoItem.ShowDone = value;
               OnPropertyChanged("ShowDone");
           }
       }

       public Visibility Completely
       {
            get { return todoItem.Completely; }
            set
            {
                if (todoItem != null) todoItem.Completely = value;
                OnPropertyChanged("Completely");
            }
        }

        public string DateTimeStart
        {
            get { return todoItem != null ? todoItem.DateTimeStart : String.Empty; }
            set
            {
                if (todoItem != null) todoItem.DateTimeStart = value;
                OnPropertyChanged("DateTimeStart");
            }
        }
        public string Description
        {
            get { return todoItem != null ? todoItem.Description : String.Empty; }
            set
            {
                if (todoItem != null) todoItem.Description = value;
                OnPropertyChanged("Description");
            }
        }
        public string DateTimeEnd
        {
            get { return todoItem != null ? todoItem.DateTimeEnd : String.Empty; }
            set
            {
                if (todoItem != null) todoItem.DateTimeEnd = value;
                OnPropertyChanged("DateTimeEnd");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
