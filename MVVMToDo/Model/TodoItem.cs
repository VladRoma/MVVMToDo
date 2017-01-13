using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace MVVMToDo.Model
{
    public class TodoItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Время начала задания
        /// </summary>
        private string datetimeStart;
        /// <summary>
        /// Примечание
        /// </summary>
        private string description;
        /// <summary>
        /// Время окончания задания
        /// </summary>
        private string datetimeEnd;

        private Visibility completely = Visibility.Visible;

        private bool showDone = true;

        /// <summary>
        /// Время начала задания
        /// </summary>
        public string DateTimeStart
        {
            get { return datetimeStart; }
            set
            {
                datetimeStart = value;
                OnPropertyChanged("DateTimeStart");
            }
        }
        /// <summary>
        /// Примечание
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                if (showDone)
                {
                    description = value;
                }
                OnPropertyChanged("Description");
            }
        }
        /// <summary>
        /// Время окончания задания
        /// </summary>
        public string DateTimeEnd
        {
            get { return datetimeEnd; }
            set
            {
                datetimeEnd = value;
                OnPropertyChanged("DateTimeEnd");
            }
        }

        public Visibility Completely
        {
            get { return completely; }
            set
            {
                completely = value;
                OnPropertyChanged("Completely");
            }
        }

        /// <summary>
        /// Отображать 
        /// </summary>
        public bool ShowDone
        {
            get { return showDone; }
            set
            {
                showDone = value;
                OnPropertyChanged("ShowDone");
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
