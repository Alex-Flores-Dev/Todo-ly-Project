using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.CacheStorage;
using SeleniumTraining.src.code.control;
using SeleniumTraining.src.code.mainPage;
using SeleniumTraining.src.code.test;
using SeleniumTraining.src.code.todoPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.testCases
{
    [TestClass]
    public class Todoly : TestBase
    {
        NewProject newProject = new NewProject();
        EditName editName = new EditName();
        LoginTodoly loginTodoly = new LoginTodoly();
        Delete deleteElement = new Delete();
        protected override string UrlBase()
        {
            return "https://todo.ly/";
        }

        [TestMethod]
        public void Login()
        {
            string nameProject = "newProject";
            string nameProjectEdit = "newProjectEdit";


            loginTodoly.loginButton.Click();
            loginTodoly.inputEmail.SetText("alex20212@yopmail.com");
            loginTodoly.inputPassword.SetText("123456789");
            loginTodoly.login.Click();


            newProject.newProjectButton.Click();
            newProject.newProjectInput.SetText(nameProject);
            newProject.newProject.Click();

            editName.changeStyle(nameProject);
            editName.clickEditButton(nameProject);
            editName.editButton.Click();
            editName.editInput.SetText(nameProjectEdit);
            editName.saveEditButton.Click();

            deleteElement.clickOption(nameProjectEdit) ;
            deleteElement.deleteButton.Click();

        }
    } 
}
