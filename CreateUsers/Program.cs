using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreateUsers
{
    [TestFixture]
    class TesteCronapp
    {

        private IWebDriver driver;
        private string baseUrl;




        [SetUp]
        public void AbrirNavegador()
        {

            driver = new ChromeDriver("C:\\Users\\bianca.ferreira\\Downloads\\chromedriver_win32 (4)");
            driver.Manage().Window.Maximize();
            baseUrl = "https://app-11-48-14151.ide.cronapp.io";
        }

        [Test(Description = "Teste acesso ide")]
        public void AcessarIde()
        {
            driver.Navigate().GoToUrl(baseUrl);

            Thread.Sleep(2000);
            IWebElement InputEmail = driver.FindElement(By.Id("input7274"));
            Thread.Sleep(2000);

            IWebElement InputPassword = driver.FindElement(By.Id("input9836"));
            InputEmail.SendKeys("admin");
            InputPassword.SendKeys("admin");
            IWebElement ButtonLogin = driver.FindElement(By.XPath("//button[@class='btn btn-default col-md-12 col-xs-12 k-button btn-primary']"));
            ButtonLogin.Click();

            Thread.Sleep(3000);


         //   IWebElement menu = driver.FindElement(By.Id("crn-subtitle-814474"));
         //   menu.Click();

            driver.Navigate().GoToUrl("https://app-11-48-14151.ide.cronapp.io/#/home/admin/user");

            //Thread.Sleep(3000);

           
            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(3000);
                IWebElement BotaoAdd = driver.FindElement(By.XPath("//span[contains(@class,'k-icon k-i-plus')]"));
                BotaoAdd.Click();

                Thread.Sleep(2000);

                IWebElement Email = driver.FindElement(By.Id("textinput-email"));
                IWebElement Nome = driver.FindElement(By.Id("textinput-name"));
                IWebElement Login = driver.FindElement(By.Id("textinput-userName"));
                IWebElement senha = driver.FindElement(By.Id("textinput-password"));

                Thread.Sleep(1000);

                Email.SendKeys("cr7@hotmail.com");
                Nome.SendKeys("Cristiano");
                Login.SendKeys("cr"+i);
                senha.SendKeys("123456");

                Thread.Sleep(1000);

                IWebElement btnfinal = driver.FindElement(By.XPath("//button[@id='btn_crud_post41107']"));
                btnfinal.Click();



            }
           




        }

        [TearDown]
        public void TearDown()
        {

            // driver.Close();

        }

        static void Main(string[] args)
        {

        }

    }
}
