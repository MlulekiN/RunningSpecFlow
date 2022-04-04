using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RunningSpecFlow.Testing;
using TechTalk.SpecFlow;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Threading;

namespace RunningSpecFlow.Steps
{

    [Binding]
    public class PageLoadElements
    {

        public static IWebDriver driver = new ChromeDriver();
        string url = "https://to-pdi.salesperformanceplatform.com/xtelsp-automhfx/web/SM1V6/SM1.aspx?DBG=1";
        // public string url = "https://to-pdi.salesperformanceplatform.com/xtelsp-autom/web/?DBG=1";
        public static WebDriverWait Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));

        [Given(@"User opens the website for Kantar")]
        public void GivenUserOpensTheWebsiteForKantar()
        {
            driver.Navigate().GoToUrl(url);
            Wait.Until(ExpectedConditions.ElementIsVisible(Elements.homeToolBar));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };
            wait.IgnoreExceptionTypes(typeof(TimeoutException), typeof(NoSuchElementException));
        }

        [Then(@"User is at homepage")]
        public void ThenUserIsAtHomepage()
        {
            IWebElement homePage = driver.FindElement(Elements.homeToolBar);
            Assert.AreEqual(homePage, homePage);
        }

        [When(@"Clicks on the tools tab")]
        public void ThenClicksOnTheToolsTab()
        {
            driver.FindElement(Elements.homeToolBar).Click();
        }

        [Then(@"Customer details and promo codes should be visible")]
        public void ThenCustomerDetailsAndPromoCodesShouldBeVisible()
        {
            IWebElement promoSelect = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.promotionalTool));
            promoSelect.Click();

        }
        [Then(@"Customer details are visible")]
        public void GivenCustomerDetailsAreVisible()
        {
            IWebElement gearButton = Wait.Until(ExpectedConditions.ElementToBeClickable(Elements.gearIcon));
            gearButton.Click();
        }

        [Then(@"Dropdown list should appear")]
        public void ThenDropdownListShouldAppear()
        {
            IWebElement gearList = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.columnSelect));
            Assert.IsTrue(gearList.Displayed);
        }

        [When(@"User selects the columns option")]
        public void ThenUserSelectsTheColumnsOption()
        {
            driver.FindElement(Elements.columnSelect).Click();
        }

        [When(@"User selects visible tab")]
        public void ThenUserSelectsVisibleTab()
        {
            IWebElement visibleTrue = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.visibleTrigger));
            visibleTrue.Click();
        }

        [When(@"User makes sure that all columns are selected")]
        public void ThenUserMakesSureThatAllColumnsAreSelected()
        {
            IWebElement isTrueClicked = Wait.Until(ExpectedConditions.ElementToBeClickable(Elements.trueCheckBox));

            int i = 1;
            while (i < 2)
            {
                bool alertBox = false;
                if (alertBox == true)
                {
                    IWebElement alert = driver.FindElement(Elements.alertBox);
                    alert.Click();
                }
                else
                {
                    Console.WriteLine("Alert Box not present");
                }
                Assert.IsFalse(isTrueClicked.Selected);
                isTrueClicked.Click();
                i++;
            }
        }

        [When(@"User clicks on the Ok button")]
        public void ThenUserClicksOnTheOkButton()
        {
            IWebElement visibleOkBTN = driver.FindElement(Elements.visibleColumnOkBTN);
            visibleOkBTN.Click();
        }

        [When(@"User double checks if all visible checkboxes are ticked")]
        public void ThenUserDoubleChecksIfAllVisibleCheckboxesAreTicked()
        {
            IReadOnlyCollection<IWebElement> isClickedList = driver.FindElements(Elements.listClicked);
            foreach (var item in isClickedList)
            {
                Assert.IsNotNull(isClickedList);
            }
        }

        [When(@"User Clicks on visible column ok button")]
        public void ThenUserClicksOnVisibleColumnOkButton()
        {
            IWebElement listVisibleOk = driver.FindElement(Elements.listVisibleOkBTN);
            listVisibleOk.Click();
        }
        [Then(@"The user is back to the customer page")]
        public void GivenTheUserIsBackToTheCustomerPage()
        {
            IWebElement customerPage = driver.FindElement(Elements.customerPage);
            Assert.IsNotNull(customerPage);
        }


        [When(@"User selects multiple IDs")]
        public void ThenUserSelectsMultipleIDs()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            int i = 1;
            while (i <= 5)
            {
                bool alertBox = false;
                if (alertBox == true)
                {
                    IWebElement alert = driver.FindElement(Elements.alertBox);
                    alert.Click();
                }
                else
                {
                    Console.WriteLine("Alert Box not present");
                }

                try
                {
                    IWebElement ListBoxes = wait.Until(ExpectedConditions.ElementIsVisible(Elements.multipleIDs(i.ToString())));
                    ListBoxes.Click();
                    wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                    i++;

                }

                catch (StaleElementReferenceException) { }
            }
        }

        [When(@"User clicks on links")]
        public void ThenUserClicksOnLinks()
        {
            IWebElement linksSelect = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.linksSelect));
            linksSelect.Click();
        }

        [When(@"User selects '(.*)' link")]
        public void WhenUserSelectsLink(string link)
        {

            IWebElement links = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.LinkText(link)));
            links.Click();
        }


        [When(@"User goes back")]
        public void WhenUserGoesBack()
        {
            IWebElement backButton = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.backButton));
            backButton.Click();
        }

        [Then(@"User unchecks all selected promos")]
        public void ThenUserUnchecksAllSelectedPromos()
        {
            int i = 1;
            while (i <= 5)
            {
                IWebElement ListBoxes = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.multipleIDs(i.ToString())));
                ListBoxes.Click();
                Wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                i++;
            }
        }
        [When(@"User clicks on a promo '(.*)'")]
        public void WhenUserClicksOnAPromo(string codeSelect)
        {
            IWebElement promoSelect = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.PromoCode(codeSelect)));
            promoSelect.Click();
        }
        [Then(@"promo is unchecked")]
        public void ThenPromoIsUnchecked()
        {
            IWebElement unSelect = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.unselectBox));
            unSelect.Click();
        }
        [When(@"Clicks on view complete menu tab")]
        public void WhenClicksOnViewCompleteMenuTab()
        {
            IWebElement viewComMenu = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.viewCompleteMenu));
            viewComMenu.Click();
        }

        [When(@"User clicks on Promotional Actions Per Scenario")]
        public void WhenUserClicksOnPromotionalActionsPerScenario()
        {
            IWebElement promoActionsPerScenario = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.promoActionsPerScenario));
            promoActionsPerScenario.Click();
        }

        [When(@"Opens a promo '(.*)'")]
        public void WhenOpensAPromo(string promoSelect)
        {
            IWebElement promo = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.openPromo(promoSelect)));
            promo.Click();
        }

        [When(@"User clicks on the tools tab to go to menu page")]
        public void ThenUserClicksOnTheToolsTabToGoToMenuPage()
        {
            // IWebElement alertError = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.undefinedError));
            //alertError.Click();
            IWebElement homeToolBar = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.homeToolBar1));
            homeToolBar.Click();
        }

        [When(@"User clicks on Child promo holders")]
        public void WhenUserClicksOnChildPromoHolders()
        {
            IWebElement childPromoHolders = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.childPromoHolders));
            childPromoHolders.Click();
        }

        [When(@"Clicks on the gear icon")]
        public void WhenClicksOnTheGearIcon()
        {
          
                IWebElement gearButton = Wait.Until(ExpectedConditions.ElementToBeClickable(Elements.gearIcon));
                gearButton.Click();

        }

        [When(@"User clicks on visible column ok button")]
        public void WhenUserClicksOnVisibleColumnOkButton()
        {
            IWebElement okayButton = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.childHolderVisibleOkButton));
            okayButton.Click();
        }
        [When(@"User clicks on anomaly report")]
        public void WhenUserClicksOnAnomalyReport()
        {
            bool undefined = true;

            if (!undefined){
                IWebElement alertError = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.undefinedError));
                alertError.Click();
            }
            else
            {
                IWebElement anomalyReport = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.anomalyReport));
                anomalyReport.Click();
            }

           
        }
        [When(@"User selects a row")]
        public void ThenUserSelectsARow()
        {
            IWebElement selectARow = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.rowSelect));
            selectARow.Click();
        }

        [Then(@"User selects Open Detail")]
        public void ThenUserSelectsOpenDetail()
        {
            
            IWebElement openDetail = Wait.Until(ExpectedConditions.ElementIsVisible(Elements.openDetail));
            openDetail.Click();
        }
    }
}




