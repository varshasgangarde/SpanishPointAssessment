using SpanishPointAssessment.Utility;

namespace SpanishPointAssessment.StepDefinitions;

[Binding]
public sealed class VisitSpanishPointSite
{
    private IWebDriver _driver;
    private Actions _actions;
    public VisitSpanishPointSite(IWebDriver driver)
    {
        _driver = driver;
        _actions = new Actions(_driver);
    }

    [Given(@"Open the browser")]
    public void OpenTheBrowser()
    {
        UtilityActions.MaximizeBrowser(_driver);
    }

    [When(@"Enter the url (.*)")]
    public void EnterTheUrl(string url)
    {
        _driver.Url = url;
        UtilityActions.ImplicitWait(_driver, 5);
        var rejectCookieButton = _driver.FindElement(PageOjbects.RejectCookiesButton);
        rejectCookieButton.Click();
    }

    [When(@"Hover on Solutions And Services menu")]
    public void HoverOnMenu()
    {
        var element = UtilityActions.ExplicitWait(_driver, 5, PageOjbects.SolutionsAndServicesMenu);
        _actions.MoveToElement(element).Perform();
        UtilityActions.ImplicitWait(_driver, 5);
        _actions.Click().Perform();
    }

    [When(@"Click on Modern Work  menu option")]
    public void ClickOnMenuOption()
    {
        var element = UtilityActions.ExplicitWait(_driver, 5, PageOjbects.ModernWorkMenuOption);
        element.Click();
    }

    [When(@"Scroll down to Modern Workplace Solutions section")]
    public void ScrollDownToASection()
    {
        var jsDriver = (IJavaScriptExecutor)_driver;
        jsDriver.ExecuteScript("window.scrollBy(0,1500);");
    }

    [When(@"Click on Document Management System tab")]
    public void ClickOnDocumentManagementSystemTab()
    {
        var element = UtilityActions.ExplicitWait(_driver, 5, PageOjbects.DocumentManagementSystemTab);
        Assert.IsNotNull(element);
        element.Click();
    }

    [Then(@"Search for header (.*)")]
    public void SearchForThePanelHeader(string panelHeader)
    {
        var element = _driver.FindElement(PageOjbects.DocumentManagementSystemTab);
        var text = element.Text;
        Assert.AreEqual(panelHeader, text);
    }


    [Then(@"Search for paragraph (.*)")]
    public void SearchForThePanelParagraph(string panelParagraphStartText)
    {
        var element = _driver.FindElement(PageOjbects.DocumentManagementSystemContent);
        var text = element.Text;
        Assert.IsTrue(text.StartsWith(panelParagraphStartText));
    }


    [Then(@"Click on Content And Collaboration System tab")]
    public void ClickOnContentAndCollaborationTab()
    {
        var element = UtilityActions.ExplicitWait(_driver, 5, PageOjbects.ContentAndCollaborationTab);
        Assert.IsNotNull(element);
        element.Click();
    }
}
