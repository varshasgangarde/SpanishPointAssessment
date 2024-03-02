namespace SpanishPointAssessment.Utility;

public static class UtilityActions
{
    public static void MaximizeBrowser(IWebDriver driver)
    {
        driver.Manage().Window.Maximize();
    }

    public static void ImplicitWait(IWebDriver driver, int seconds)
    {
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
    }

    public static IWebElement ExplicitWait(IWebDriver driver, int seconds, By selector)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        var element = wait.Until(ExpectedConditions.ElementIsVisible(selector));
        return element;
    }
}
