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
                todoItem.Completely = value;
                OnPropertyChanged("Completely");
            }
        }

        public string DateTimeStart
        {
            get { return todoItem.DateTimeStart; }
            set
            {
                todoItem.DateTimeStart = value;
                OnPropertyChanged("DateTimeStart");
            }
        }
        public string Description
        {
            get { return todoItem.Description; }
            set
            {
                todoItem.Description = value;
                OnPropertyChanged("Description");
            }
        }
        public string DateTimeEnd
        {
            get { return todoItem.DateTimeEnd; }
            set
            {
                todoItem.DateTimeEnd = value;
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
