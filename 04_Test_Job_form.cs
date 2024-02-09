global using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using UI_test.PageObjects;

namespace UI_test
{
    public class Test_Job_form : Base
    {
        [Test]
        public void Test_Job()
        {
            var mainPage = new MainPage(driver);
            mainPage
                .MenuJobLinkClick()
                .JobPageScrollToJobForm()
                .JobPageSelectCity("Москва")
                .JobPageSelectVacancy("Администратор")
                .JobPageInputFIO("Петров Иван")
                .JobPageInputPhone("9197854152")
                .JobPageInputWhatsUp("9197854152")
                .JobPageConfirmAgrement()
                .JobPageSendForm()
                .JobPageCheckSuccessSendForm();
        }

    }
}