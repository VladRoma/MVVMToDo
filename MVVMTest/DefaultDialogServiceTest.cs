using MVVMToDo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MVVMTests
{
    
    
    /// <summary>
    ///Это класс теста для DefaultDialogServiceTest, в котором должны
    ///находиться все модульные тесты DefaultDialogServiceTest
    ///</summary>
    [TestClass()]
    public class DefaultDialogServiceTest
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
        ///Тест для Конструктор DefaultDialogService
        ///</summary>
        [TestMethod()]
        public void DefaultDialogServiceConstructorTest()
        {
            MVVMToDo.DefaultDialogService target = new MVVMToDo.DefaultDialogService();
        }

        /// <summary>
        ///Тест для OpenFileDialog
        ///</summary>
        [TestMethod()]
        public void OpenFileDialogTest()
        {
            MVVMToDo.DefaultDialogService target = new MVVMToDo.DefaultDialogService(); // TODO: инициализация подходящего значения
            bool expected = true; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.OpenFileDialog();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для SaveFileDialog
        ///</summary>
        [TestMethod()]
        public void SaveFileDialogTest()
        {
            MVVMToDo.DefaultDialogService target = new MVVMToDo.DefaultDialogService(); // TODO: инициализация подходящего значения
            bool expected = true; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.SaveFileDialog();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для ShowMessage
        ///</summary>
        [TestMethod()]
        public void ShowMessageTest()
        {
            MVVMToDo.DefaultDialogService target = new MVVMToDo.DefaultDialogService(); // TODO: инициализация подходящего значения
            string message = string.Empty; // TODO: инициализация подходящего значения
            target.ShowMessage(message);
        }

        /// <summary>
        ///Тест для FilePath
        ///</summary>
        [TestMethod()]
        public void FilePathTest()
        {
            MVVMToDo.DefaultDialogService target = new MVVMToDo.DefaultDialogService(); // TODO: инициализация подходящего значения
            string expected = string.Empty; // TODO: инициализация подходящего значения
            string actual;
            target.FilePath = expected;
            actual = target.FilePath;
            Assert.AreEqual(expected, actual);
        }
    }
}
