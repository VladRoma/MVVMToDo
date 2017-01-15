using MVVMToDo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MVVMTests
{
    
    
    /// <summary>
    ///Это класс теста для MainWindowTest, в котором должны
    ///находиться все модульные тесты MainWindowTest
    ///</summary>
    [TestClass()]
    public class MainWindowTest
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


        /*/// <summary>
        ///Тест для System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MVVMToDo.exe")]
        public void ConnectTest()
        {
            System.Windows.Markup.IComponentConnector target = new MainWindow(); // TODO: инициализация подходящего значения
            int connectionId = 0; // TODO: инициализация подходящего значения
            object target1 = null; // TODO: инициализация подходящего значения
            target.Connect(connectionId, target1);
        }*/

        /// <summary>
        ///Тест для InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            MainWindow target = new MainWindow(); // TODO: инициализация подходящего значения
            target.InitializeComponent();
        }

        /// <summary>
        ///Тест для Конструктор MainWindow
        ///</summary>
        [TestMethod()]
        public void MainWindowConstructorTest()
        {
            MVVMToDo.MainWindow target = new MVVMToDo.MainWindow();
        }
    }
}
