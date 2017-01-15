using MVVMToDo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MVVMTests
{
    
    
    /// <summary>
    ///Это класс теста для RelayCommandTest, в котором должны
    ///находиться все модульные тесты RelayCommandTest
    ///</summary>
    [TestClass()]
    public class RelayCommandTest
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
        ///Тест для Конструктор RelayCommand
        ///</summary>
        [TestMethod()]
        public void RelayCommandConstructorTest()
        {
            System.Action<object> execute = null; // TODO: инициализация подходящего значения
            System.Func<object, bool> canExecute = null; // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand target = new MVVMToDo.RelayCommand(execute, canExecute);
        }

        /// <summary>
        ///Тест для CanExecute
        ///</summary>
        [TestMethod()]
        public void CanExecuteTest()
        {
            System.Action<object> execute = null; // TODO: инициализация подходящего значения
            System.Func<object, bool> canExecute = null; // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand target = new MVVMToDo.RelayCommand(execute, canExecute); // TODO: инициализация подходящего значения
            object parameter = null; // TODO: инициализация подходящего значения
            bool expected = true; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.CanExecute(parameter);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest()
        {
            System.Action<object> execute = null; // TODO: инициализация подходящего значения
            System.Func<object, bool> canExecute = null; // TODO: инициализация подходящего значения
            MVVMToDo.RelayCommand target = new MVVMToDo.RelayCommand(execute, canExecute); // TODO: инициализация подходящего значения
            object parameter = null; // TODO: инициализация подходящего значения
            target.Execute(parameter);
        }
    }
}
