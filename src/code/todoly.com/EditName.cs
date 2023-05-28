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
    public class EditName
    {
        
        public Button editButton = new Button(By.XPath("//ul[@id=\"projectContextMenu\"]/li[1]"));
        public TextBox editInput = new TextBox(By.XPath("//input[@id=\"ItemEditTextbox\"]"));
        public Button saveEditButton = new Button(By.XPath("//div[@id=\"ProjectEditDiv\"]/img[1]"));
        

        public void changeStyle(string nameProject)
        {
            Button editProject = new Button(By.XPath("//td[contains(text(),\"asd\")]/..//td[4]/div[2]"));
            editProject.applyStyle($"//td[contains(text(),\"{nameProject}\")]/..//td[4]/div[2]", "arguments[0].style.display='block';");
        }

        public void clickEditButton(string nameProject)
        {
            Button editProject = new Button(By.XPath($"//td[contains(text(),\"{nameProject}\")]/..//td[4]/div[2]"));
            editProject.Click();
    }
    }
        
}

