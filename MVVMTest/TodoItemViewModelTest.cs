using MVVMToDo.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MVVMToDo.Model;

namespace MVVMTests
{
    
    
    /// <summary>
    ///Это класс теста для TodoItemViewModelTest, в котором должны
    ///находиться все модульные тесты TodoItemViewModelTest
    ///</summary>
    [TestClass()]
    public class TodoItemViewModelTest
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
        ///Тест для Конструктор TodoItemViewModel
        ///</summary>
        [TestMethod()]
        public void TodoItemViewModelConstructorTest()
        {
            MVVMToDo.Model.TodoItem p = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.TodoItemViewModel target = new MVVMToDo.ViewModel.TodoItemViewModel(p);
        }

        /// <summary>
        ///Тест для OnPropertyChanged
        ///</summary>
        [TestMethod()]
        public void OnPropertyChangedTest()
        {
            MVVMToDo.Model.TodoItem p = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.TodoItemViewModel target = new MVVMToDo.ViewModel.TodoItemViewModel(p); // TODO: инициализация подходящего значения
            string prop = string.Empty; // TODO: инициализация подходящего значения
            target.OnPropertyChanged(prop);
        }

        /// <summary>
        ///Тест для DateTimeEnd
        ///</summary>
        [TestMethod()]
        public void DateTimeEndTest()
        {
            MVVMToDo.Model.TodoItem p = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.TodoItemViewModel target = new MVVMToDo.ViewModel.TodoItemViewModel(p); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.DateTimeEnd = expected;
            actual = target.DateTimeEnd;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для DateTimeStart
        ///</summary>
        [TestMethod()]
        public void DateTimeStartTest()
        {
            MVVMToDo.Model.TodoItem p = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.TodoItemViewModel target = new MVVMToDo.ViewModel.TodoItemViewModel(p); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.DateTimeStart = expected;
            actual = target.DateTimeStart;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Description
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            MVVMToDo.Model.TodoItem p = null; // TODO: инициализация подходящего значения
            MVVMToDo.ViewModel.TodoItemViewModel target = new MVVMToDo.ViewModel.TodoItemViewModel(p); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
        }
    }
}
