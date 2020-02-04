using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.IE;


namespace CargaInvGateUltima
{
    class Program
    {
        private const string URL = "https://ivirma.cloud.invgate.net";
        private const string IE_DRIVER_PATH = @"C:\Sel";
        static string txtHora;
        static string txtHora1;

        static void Main(string[] args)
        
        {
            var webDriverChrome = new ChromeDriver(IE_DRIVER_PATH);
            
            webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net");
            System.Threading.Thread.Sleep(3000);
            webDriverChrome.Manage().Window.Maximize();
            webDriverChrome.Manage().Window.FullScreen();
            System.Threading.Thread.Sleep(10000);
            webDriverChrome.FindElement(By.XPath("//div[@class='arrow']")).Click();
            System.Threading.Thread.Sleep(5000);
            webDriverChrome.FindElement(By.XPath("//div[contains(text(),'Cerrar sesión')]")).Click();
            System.Threading.Thread.Sleep(10000);
            var UserName = webDriverChrome.FindElement(By.Id("login_username"));
            UserName.SendKeys("superadmin");
            var LoginPass = webDriverChrome.FindElement(By.Id("login_password"));
            LoginPass.SendKeys("1nvGate01*");
            var ButtonLogin = webDriverChrome.FindElement(By.Id("button_login"));
            ButtonLogin.Click();
            txtHora = DateTime.Now.ToString("HH");
            txtHora1 = DateTime.Now.ToString("HH");
            IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriverChrome;
            
            while (!txtHora.Equals("23"))
            {
                System.Threading.Thread.Sleep(10000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/63/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/64/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/65/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/51/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/53/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/54/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/56/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/57/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/58/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/60/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                webDriverChrome.Navigate().GoToUrl("https://ivirma.cloud.invgate.net/dashboard/item/index/id/61/type/3");
                webDriverChrome.FindElement(By.Id("button_expand")).Click();
                System.Threading.Thread.Sleep(15000);
                txtHora = DateTime.Now.ToString("hh");
             }
            webDriverChrome.Close();
        }
    }
}
