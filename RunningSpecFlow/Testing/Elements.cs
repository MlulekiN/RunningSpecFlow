

using OpenQA.Selenium;

namespace RunningSpecFlow.Testing
{
    public class Elements
    {

        public static By homeToolBar = By.XPath("//div[@sm1-id='homeToolbarMenuBTN']");
        public static By promotionalTool = By.XPath("//div[@class='x-panel sm1-mainmenu-summary-panel x-box-item x-panel-default']/descendant::div[@sm1-id='PROMOACTION']");
        public static By gearIcon = By.XPath("//span[@sm1-id='GridContextMenuButton']/descendant::span[@data-ref='btnWrap']");// ("//span[@data-qtip='Context menu']");//("//span[@sm1-id='GridContextMenuButton']");
        public static By columnSelect = By.XPath("//span[text()='Columns']");
        public static By visibleTrigger = By.XPath("//div[@data-qtip='Visible']/descendant::div[@data-ref='triggerEl']");
        public static By trueCheckBox = By.XPath("//span[contains(@id,'sm1checkbox')]/following::label[text()='True']");
        public static By visibleColumnOkBTN = By.XPath("//div[@sm1-id='LOGICALCHECKBOXCOLUMNPOPUP']/descendant::span[@sm1-id='SM1OkButton']");
        public static By listClicked = By.XPath("//div[@sm1-id='LOGICALGRIDCOLUMNSPOPUP']/descendant::td[contains(@data-columnid,'sm1gridtextcolumn')]/child::div[contains(text(),a)]/following::td[1]");
        public static By listVisibleOkBTN = By.XPath("//span[text()='OK']");
        public static By customerPage = By.XPath("//span[text()='Promotional actions']/parent::span[contains(@id,'button')]");
        public static By alertBox = By.XPath("//div[contains(@class,'sm1-messagebox-error')]/descendant::a[@sm1-id='messageboxbuttonok']/descendant::span[text()='OK']");
        public static By multipleIDs(string rowindex) => By.XPath("(//div[contains(@class,'lt x-panel-body-default x-docked-noborder-right')]/descendant::table/descendant::div[contains(@class,'checkcolumn')]/parent::td[@role='gridcell'])[" + rowindex + "]");
        public static By linksSelect = By.XPath("//span[@sm1-id='LogicalNavCtrl.NAVIGATORLINKS_Button']");
        public static By LinkText(string text)
        {
            return By.XPath($"//div[contains(@sm1-id,'ACTION_navlink')]/descendant::span[text()='{text}']");
        }
        public static By backButton = By.XPath("//span[contains(@class,'topbar-back')]");
        public static By unclickElement = By.XPath("//tr[@aria-selected='true']");
        public static By PromoCode(string codeSelect)
        {
            return By.XPath($"//div[text()='Draft']/parent::td/preceding-sibling::td/child::div[text()='{codeSelect}']/ancestor::tr");
        }
        public static By unselectBox = By.XPath("//div[text()='Draft']/parent::td/preceding-sibling::td/div[text()='EC86263']/parent::td/preceding-sibling::td/descendant::span[@class='x-grid-checkcolumn']/parent::div");
        public static By viewCompleteMenu = By.XPath("//span[text()='View Complete Menu']");
        public static By promoActionsPerScenario = By.XPath("//span[text()='Promotional actions per scenario']");
        public static By openPromo(string promo)
        {
            return By.XPath($"//div[text()='{promo}']/parent::td/preceding-sibling::td[contains(@class,'x-selmodel-column x-grid-cell-first')]");
        }
        public static By childPromoHolders = By.XPath("//span[text()='Child promo holders']");
        public static By homeToolBar1 = By.XPath("//div[@sm1-id='homeToolbarMenuBTN']/span");
        public static By undefinedError = By.XPath("//div[contains(@class,'sm1-messagebox-error')]/descendant::div[@data-qtip='Close dialog']/child::div[contains(@class,'tool-close')]");
        public static By childHolderVisibleOkButton = By.XPath("//span[text()='OK']/parent::span[contains(@id,'sm1okbutton')]");
        public static By anomalyReport = By.XPath("//span[text()='Anomaly report']");
        public static By rowSelect = By.XPath("//td[contains(@class,'mn x-grid-cell-first')]");
        public static By openDetail = By.XPath("//div[@data-qtip='Open Detail']");
        public static By generalInfo = By.XPath("//div[text()='General Info']");
        public static By alertDialog = By.XPath("//div[@role='alertdialog']/descendant::div[contains(@class,'x-tool-close')]");


    }

}
