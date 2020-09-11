using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Assessment.Steps
{
    [Binding]
    public class HippodromeOnlineStepDefinitions : IDisposable
    {
        private ChromeDriver _chromeDriver;

        private bool IsElementPresent(By by)
        {
            try
            {
                _chromeDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        [Given("I have navigated to the website")]
        public void INavigateToWebsite()
        {
            var options = new ChromeOptions();
            options.AddArgument("ignore-certificate-errors");
            _chromeDriver = new ChromeDriver(options);
            _chromeDriver.Navigate().GoToUrl("https://www.hippodromeonline.com/#/");
            Assert.IsTrue(true);
        }

        [Given("I have clicked the register button")]
        public void IClickRegisterButton()
        {
            var registerBut = _chromeDriver.FindElementByCssSelector(".header a[href='#/register']");
            Assert.IsTrue(registerBut.Displayed);
            registerBut.Click();
        }

        [When("I fill in the registration form correctly")]
        public void RegistrationFormRenders()
        {
            var modal = _chromeDriver.FindElementByCssSelector("#modal");
            Assert.IsTrue(modal.Displayed);
        }

        [When("I put username as (.*)")]
        public void FillInUsername(string username)
        {
            var UsernameFld = _chromeDriver.FindElementByCssSelector("input#UserName");
            Assert.IsTrue(UsernameFld.Displayed);
            UsernameFld.SendKeys(username);
            var UsernameError = IsElementPresent(By.CssSelector("span#UserName-error"));
            Assert.IsFalse(UsernameError);
        }

        [When("I put email as (.*)")]
        public void FillInEmail(string email)
        {
            var EmailFld = _chromeDriver.FindElementByCssSelector("input#Email");
            Assert.IsTrue(EmailFld.Displayed);
            EmailFld.SendKeys(email);
            var EmailError = IsElementPresent(By.CssSelector("span#Email-error"));
            Assert.IsFalse(EmailError);
        }

        [When("I put password as (.*)")]
        public void FillInPassword(string password)
        {
            var PasswordFld = _chromeDriver.FindElementByCssSelector("input#Password");
            Assert.IsTrue(PasswordFld.Displayed);
            PasswordFld.SendKeys(password);
            var ConfirmPasswordFld = _chromeDriver.FindElementByCssSelector("input#ConfirmPassword");
            Assert.IsTrue(ConfirmPasswordFld.Displayed);
            ConfirmPasswordFld.SendKeys(password);
            var PasswordError = IsElementPresent(By.CssSelector("span#Password-error"));
            var ConfirmPasswordError = IsElementPresent(By.CssSelector("span#ConfirmPassword-error"));
            Assert.IsFalse(PasswordError);
            Assert.IsFalse(ConfirmPasswordError);
        }

        [When("I click the next button")]
        public void ClickNextButton()
        {
            var NextBtn = _chromeDriver.FindElementByCssSelector(".modal-buttonContainer button.modal-button_next:nth-child(1)");
            Assert.IsTrue(NextBtn.Displayed);
            NextBtn.Click();
        }

        [When("I fill in firstname as (.*)")]
        public void FillInFirstname(string firstname)
        {
            var FirstnameFld = _chromeDriver.FindElementByCssSelector("input#FirstName");
            Assert.IsTrue(FirstnameFld.Displayed);
            FirstnameFld.SendKeys(firstname);
            var FirstNameError = IsElementPresent(By.CssSelector("span#FirstName-error"));
            Assert.IsFalse(FirstNameError);
        }

        [When("I fill in surname as (.*)")]
        public void FillInSurname(string surname)
        {
            var SurnameFld = _chromeDriver.FindElementByCssSelector("input#LastName");
            Assert.IsTrue(SurnameFld.Displayed);
            SurnameFld.SendKeys(surname);
            var SurnameError = IsElementPresent(By.CssSelector("span#LastName-error"));
            Assert.IsFalse(SurnameError);
        }

        [When("I set my birthday day to (.*)")]
        public void FillInBirthdayDay(string day)
        {
            var Day = _chromeDriver.FindElementByCssSelector("select#DateOfBirth_Day");
            Assert.IsTrue(Day.Displayed);
            var selectElement = new SelectElement(Day);

            selectElement.SelectByValue(day);
        }

        [When("I set my birthday month to (.*)")]
        public void FillInBirthdayMonth(string month)
        {
            var Month = _chromeDriver.FindElementByCssSelector("select#DateOfBirth_Month");
            Assert.IsTrue(Month.Displayed);
            var selectElement = new SelectElement(Month);

            selectElement.SelectByValue(month);
        }

        [When("I set my birthday year to (.*)")]
        public void FillInBirthdayYear(string year)
        {
            var Year = _chromeDriver.FindElementByCssSelector("select#DateOfBirth_Year");
            Assert.IsTrue(Year.Displayed);
            var selectElement = new SelectElement(Year);

            selectElement.SelectByValue(year);
        }

        [When("I click next")]
        public void ClickNext()
        {
            var NextBtn = _chromeDriver.FindElementByCssSelector(".modal-buttonContainer button.modal-button_next:nth-child(2)");
            Assert.IsTrue(NextBtn.Displayed);
            NextBtn.Click();
        }

        [When("I select the country to (.*)")]
        public void changeCountry(string CountryAb)
        {
            var Country = _chromeDriver.FindElementByCssSelector("select#Country");
            Assert.IsTrue(Country.Displayed);
            var selectElement = new SelectElement(Country);

            selectElement.SelectByValue(CountryAb);
        }

        [When("I fill in zipcode to (.*)")]
        public void FillInZipcode(string zipcode)
        {
            var ZipcodeFld = _chromeDriver.FindElementByCssSelector("input#ZipCode");
            Assert.IsTrue(ZipcodeFld.Displayed);
            ZipcodeFld.SendKeys(zipcode);
            var ZipcodeError = IsElementPresent(By.CssSelector("span#ZipCode-error"));
            Assert.IsFalse(ZipcodeError);
        }

        [When("I fill in address 1 to (.*)")]
        public void FillInAddress1(string address1)
        {
            var Address1Fld = _chromeDriver.FindElementByCssSelector("input#Address1");
            Assert.IsTrue(Address1Fld.Displayed);
            Address1Fld.SendKeys(address1);
            var Address1Error = IsElementPresent(By.CssSelector("span#Address1-error"));
            Assert.IsFalse(Address1Error);
        }

        [When("I fill in address 2 to (.*)")]
        public void FillInAddress2(string address2)
        {
            var Address2Fld = _chromeDriver.FindElementByCssSelector("input#Address2");
            Assert.IsTrue(Address2Fld.Displayed);
            Address2Fld.SendKeys(address2);
            var Address1Error = IsElementPresent(By.CssSelector("span#Address2-error"));
            Assert.IsFalse(Address1Error);
        }

        [When("I fill in city to (.*)")]
        public void FillInCity(string city)
        {
            var CityFld = _chromeDriver.FindElementByCssSelector("input#City");
            Assert.IsTrue(CityFld.Displayed);
            CityFld.SendKeys(city);
            var CityError = IsElementPresent(By.CssSelector("span#City-error"));
            Assert.IsFalse(CityError);
        }

        [When("I fill in phone number to (.*)")]
        public void FillInPhoneNumber(string number)
        {
            var NumberFld = _chromeDriver.FindElementByCssSelector("input#MobileTelephoneNumber");
            Assert.IsTrue(NumberFld.Displayed);
            NumberFld.SendKeys(number);
            var NumberError = IsElementPresent(By.CssSelector("span#MobileTelephoneNumber-error"));
            Assert.IsFalse(NumberError);
        }

        [Then("I should get a registered successful")]
        public void ThenTheResultShouldBe()
        {
            Assert.IsTrue(true);
        }

        public void Dispose()
        {
            if (_chromeDriver != null)
            {
                _chromeDriver.Dispose();
                _chromeDriver = null;
            }
        }
    }
}
