using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumTraining.src.code.todoPage
{
    public class LoginTodoly
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
        public TextBox inputEmail = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxEmail"));
        public TextBox inputPassword = new TextBox(By.Id("ctl00_MainContent_LoginControl1_TextBoxPassword"));
        public Button login = new Button(By.Id("ctl00_MainContent_LoginControl1_ButtonLogin"));
    }
        
}

