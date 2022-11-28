using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Driver;

namespace TestProject2.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;


        public IWebElement Country => driver.FindElement(By.Id("country"));
        public IWebElement Address => driver.FindElement(By.Id("address"));
        public IWebElement EMail => driver.FindElement(By.Id("email"));
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));


        // public void Title(string option)
        //{
        //    SelectElement drop = new SelectElement(driver.FindElement(By.Id("TitleId")));
        //    drop.SelectByText(option);
        //}


        public void Alert()
        {

            driver.SwitchTo().Alert().Accept();
        }

    }
}
