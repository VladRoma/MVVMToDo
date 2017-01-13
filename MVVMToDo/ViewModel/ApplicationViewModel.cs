using MVVMToDo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMToDo.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Выбораная задача
        /// </summary>
        private TodoItem selectedtodoItem;

        /// <summary>
        /// Интерфейс работы с файлом
        /// </summary>
        IFileService fileService;
        /// <summary>
        /// Диалоговые окна(интерфейс)
        /// </summary>
        IDialogService dialogService;

        /// <summary>
        /// Лист задач
        /// </summary>
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        /// <summary>
        /// Отображение завершенных задач
        /// </summary>
        private bool showDoneItems;

        /// <summary>
        /// Отображение завершенных задач
        /// </summary>
        public bool ShowDoneItems
        {
            get { return showDoneItems; }
            set
            {
                showDoneItems = value;
                if (showDoneItems)
                {
                    foreach (TodoItem item in TodoItems)
                    {
                        item.Completely = Visibility.Visible;
                    }
                }
                else
                {
                    foreach (TodoItem item in TodoItems)
                    {
                        if (!item.ShowDone)
                        {
                            item.Completely = Visibility.Collapsed;
                        }
                    }
                }

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ShowDoneItems"));
                }
            }
        }


        /// <summary>
        /// Выбораная задача
        /// </summary>
        public TodoItem SelectedTodo
        {
            get { return selectedtodoItem; }
            set
            {
                selectedtodoItem = value;
                OnPropertyChanged("SelectedTodo");
            }
        }

        
        /// <summary>
        /// Команда сохранения задач в файл
        /// </summary>
        private RelayCommand saveCommand;
        /// <summary>
        /// Команда сохранения задач в файл
        /// </summary>
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                        //  if (dialogService.SaveFileDialog() == true)
                          {
                              AppSettingsReader asr = new AppSettingsReader();
                              string listFileName = (string)asr.GetValue("listFileName", typeof(string));
                              fileService.Save(listFileName, TodoItems.ToList());
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        
        /// <summary>
        /// Команда открытия файла задач
        /// </summary>
        private RelayCommand openCommand;
        /// <summary>
        /// Команда открытия файла задач
        /// </summary>
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          //if (dialogService.OpenFileDialog() == true)
                          {
                              AppSettingsReader asr = new AppSettingsReader();
                              string listFileName = (string)asr.GetValue("listFileName", typeof(string));
                              if (File.Exists(listFileName))
                              {
                                  //var todoItem = fileService.Open(dialogService.FilePath);
                                  var todoItem = fileService.Open(listFileName);
                                  TodoItems.Clear();
                                  foreach (var p in todoItem)
                                      TodoItems.Add(p);
                              }
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        /// <summary>
        /// Команда добавление задачи
        /// </summary>
        private RelayCommand addCommand;

        /// <summary>
        /// Команда добавление задачи
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                       (addCommand = new RelayCommand(obj =>
                       {
                           TodoItem todoItem = new TodoItem();
                           todoItem.DateTimeStart = DateTime.Now.ToString("g");
                           // todoItem.DateTimeEnd = DateTime.Now;
                           TodoItems.Insert(0, todoItem);
                           SelectedTodo = todoItem;
                       }));
            }
        }

        /// <summary>
        /// Команда фиксировния задачи(выполненость)
        /// </summary>
        private RelayCommand doubleCommand;

        /// <summary>
        /// Команда фиксировния задачи(выполненость)
        /// </summary>
        public RelayCommand DoubleCommand
        {
            get
            {
                return doubleCommand ??
                       (doubleCommand = new RelayCommand(obj =>
                       {
                           TodoItem todoItem = obj as TodoItem;
                           if (todoItem != null)
                           {
                               MessageBoxResult done = MessageBox.Show("Mark this as done?", "Done?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                               if (done == MessageBoxResult.Yes)
                               {
                                   todoItem.Completely = Visibility.Collapsed;
                                   todoItem.ShowDone = false;
                                   todoItem.DateTimeEnd = DateTime.Now.ToString("g");
                               }
                               SelectedTodo = null;
                           }
                       }));
            }
        }

        /// <summary>
        /// Команда удаления задачи
        /// </summary>
        private RelayCommand removeCommand;
        /// <summary>
        /// Команда удаления задачи
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        TodoItem todoItem = obj as TodoItem;
                        if (todoItem != null)
                        {
                            MessageBoxResult del = MessageBox.Show("Delete this item?", "Delete?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                            if (del == MessageBoxResult.Yes)
                            {
                                TodoItems.Remove(todoItem);
                            }
                        }
                    },
                    (obj) => TodoItems.Count > 0));
            }
        }

        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;

            TodoItems = new ObservableCollection<TodoItem>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
