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
    public class NewProject
    {
        public Button newProjectButton = new Button(By.XPath("//*[@id=\"MainTable\"]/tbody/tr/td[1]/div[6]/div"));
        public TextBox newProjectInput = new TextBox(By.XPath("//input[@id=\"NewProjNameInput\"]"));
        public Button newProject = new Button(By.XPath("//input[@id=\"NewProjNameButton\"]"));

        public void clickOption(string text)
        {
            Button moreOptions = new Button(By.XPath($"//span[contains(text(),\"{text}\")]/../..//div/button"));
            moreOptions.Click();
        }
    }
        
}

