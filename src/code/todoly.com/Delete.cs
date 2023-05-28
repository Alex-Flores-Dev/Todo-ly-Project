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
    public class Delete
    {
        public Button editProject = new Button(By.XPath("//td[contains(text(),\"asd\")]/..//td[4]/div[2]"));
        public Button editButton = new Button(By.XPath("//ul[@id=\"projectContextMenu\"]/li[1]"));
        public Button deleteButton = new Button(By.XPath("//a[@id=\"ProjShareMenuDel\"]"));

        
        public void changeSdtyle()
        {
            editProject.applyStyle("//td[contains(text(),\"asd\")]/..//td[4]/div[2]", "arguments[0].style.display='block';");
        }


        public void clickOption(string text)
        {
            Button moreOptions = new Button(By.XPath($"//td[contains(text(),\"{text}\")]/..//td[4]/div[2]"));
            moreOptions.Click();
        }
    }
        
}

