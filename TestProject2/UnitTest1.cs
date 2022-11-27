using NUnit.Framework;
using OpenQA.Selenium;
using TestProject2.Driver;
using TestProject2.Page;

namespace TestProject2
{
    public class TestClass
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]

        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();

        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.CleanUp();
        }




        [Test]
        public void TC01_LoginAndFillData()
        {
            Login("zika", "12345");
            _homePage.Country.SendKeys("serbia");
            _homePage.Address.SendKeys("Beograd 22");
            _homePage.EMail.SendKeys("mail@mail.com");
            _homePage.Phone.SendKeys("38112345");
            _homePage.SaveButton.Click();
            _homePage.LogoutButton.Click();
        }





        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }
}