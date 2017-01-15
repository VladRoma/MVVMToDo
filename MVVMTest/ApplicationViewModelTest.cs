using MVVMToDo.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MVVMTests
{
    
    
    /// <summary>
    ///Это класс теста для ApplicationViewModelTest, в котором должны
    ///находиться все модульные тесты ApplicationViewModelTest
    ///</summary>
    [TestClass()]
    public class ApplicationViewModelTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Конструктор ApplicationViewModel
        ///</summary>
        [TestMethod()]
        public void ApplicationViewModelConstructorTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService);
        }

        /// <summary>
        ///Тест для OnPropertyChanged
        ///</summary>
        [TestMethod()]
        public void OnPropertyChangedTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            string prop = string.Empty; // TODO: инициализация подходящего значения
            target.OnPropertyChanged(prop);
        }

        /// <summary>
        ///Тест для AddCommand
        ///</summary>
        [TestMethod()]
        public void AddCommandTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand actual;
            actual = target.AddCommand;
        }

        /// <summary>
        ///Тест для DoubleCommand
        ///</summary>
        [TestMethod()]
        public void DoubleCommandTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand actual;
            actual = target.DoubleCommand;
        }

        /// <summary>
        ///Тест для OpenCommand
        ///</summary>
        [TestMethod()]
        public void OpenCommandTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand actual;
            actual = target.OpenCommand;
        }

        /// <summary>
        ///Тест для RemoveCommand
        ///</summary>
        [TestMethod()]
        public void RemoveCommandTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand actual;
            actual = target.RemoveCommand;
        }

        /// <summary>
        ///Тест для SaveCommand
        ///</summary>
        [TestMethod()]
        public void SaveCommandTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand actual;
            actual = target.SaveCommand;
        }

        /// <summary>
        ///Тест для SelectedTodo
        ///</summary>
        [TestMethod()]
        public void SelectedTodoTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            MVVMToDo.Model.TodoItem expected = null; // TODO: инициализация подходящего значения
            MVVMToDo.Model.TodoItem actual;
            target.SelectedTodo = expected;
            actual = target.SelectedTodo;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для TodoItems
        ///</summary>
        [TestMethod()]
        public void TodoItemsTest()
        {
            MVVMToDo.IDialogService dialogService = null; // TODO: инициализация подходящего значения
            MVVMToDo.IFileService fileService = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.ApplicationViewModel target = new MVVMToDo.ViewModel.ApplicationViewModel(dialogService, fileService); // TODO: инициализация подходящего значения
            System.Collections.ObjectModel.ObservableCollection<MVVMToDo.Model.TodoItem> expected = null; // TODO: инициализация подходящего значения
            System.Collections.ObjectModel.ObservableCollection<MVVMToDo.Model.TodoItem> actual;
            target.TodoItems = expected;
            actual = target.TodoItems;
            Assert.AreEqual(expected, actual);
        }
    }
}
