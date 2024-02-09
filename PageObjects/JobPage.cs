using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_test.PageObjects
{


    class JobPage
    {
        private IWebDriver _webDriver;

        private readonly By SelectGorod = By.Id("edit-submitted-gorod");
        private readonly By SelectVacancy = By.Id("edit-submitted-vybrat-vakansiyu");
        private readonly By ButtonSubmit = By.Id("edit-webform-ajax-submit-18942");
        private readonly By MenuLinkJob = By.XPath("//ul//li[3]//a");
        private readonly By InputFIO = By.Id("edit-submitted-fio");
        private readonly By InputPhone = By.Id("edit-submitted-telefon");
        private readonly By InputWhatsUp = By.Id("edit-submitted-whatsapp");
        private readonly By CheckBox = By.Id("edit-submitted-politika-konfidencialnosti");

        private readonly By confirm = By.XPath("//div[@class='jl-confirmation-message']");

        public JobPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public JobPage JobPageScrollToJobForm()
        {
            var elementButtonSubmit = _webDriver.FindElement(ButtonSubmit);
            Actions actions = new Actions(_webDriver);
            actions.MoveToElement(elementButtonSubmit);
            actions.Perform();
            return this;
        }

        public JobPage JobPageSelectCity(string city)
        {
            var elementSelectGorod = _webDriver.FindElement(SelectGorod);
            var selectElementGorod = new SelectElement(elementSelectGorod);
            selectElementGorod.SelectByText(city);
            return this;
        }

        public JobPage JobPageSelectVacancy(string vacancy)
        {
            var elementSelectVacancy = _webDriver.FindElement(SelectVacancy);
            var selectElementVacancy = new SelectElement(elementSelectVacancy);
            selectElementVacancy.SelectByText(vacancy);
            return this;
        }

        public JobPage JobPageInputFIO(string fio)
        {
            _webDriver.FindElement(InputFIO).SendKeys("fio");
            return this;
        }

        public JobPage JobPageInputPhone(string phone)
        {
            _webDriver.FindElement(InputPhone).SendKeys(phone);
            return this;
        }

        public JobPage JobPageInputWhatsUp(string whatsUp)
        {
            _webDriver.FindElement(InputWhatsUp).SendKeys(whatsUp);
            return this;
        }

        public JobPage JobPageConfirmAgrement()
        {
            _webDriver.FindElement(CheckBox).Click(); 
            return this;
        }

        public JobPage JobPageSendForm()
        {
            _webDriver.FindElement(ButtonSubmit).Click();
            return this;
        }

        public JobPage JobPageCheckSuccessSendForm()
        {
            _webDriver.FindElement(confirm);
            return this;
        }

    }
}
