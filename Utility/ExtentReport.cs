﻿namespace SpanishPointAssessment.Utility;

public class ExtentReport
{
    public static ExtentReports _extentReports;
    public static ExtentTest _feature;
    public static ExtentTest _scenario;

    public static string dir = AppDomain.CurrentDomain.BaseDirectory;
    public static string testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");

    public static void ExtentReportInit()
    {
        var htmlReporter = new ExtentHtmlReporter(testResultPath);
        htmlReporter.Config.ReportName = "Automation Status Report";
        htmlReporter.Config.DocumentTitle = "Automation Status Report";
        htmlReporter.Config.Theme = Theme.Standard;
        htmlReporter.Start();

        _extentReports = new ExtentReports();
        _extentReports.AttachReporter(htmlReporter);
        _extentReports.AddSystemInfo("Application", "Spanish Point Technology Website");
        _extentReports.AddSystemInfo("Browser", "Chrome");
        _extentReports.AddSystemInfo("OS", "Windows");
    }

    public static void ExtentReportTearDown()
    {
        _extentReports.Flush();
    }

    public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
    {
        var takesScreenshot = (ITakesScreenshot)driver;
        Screenshot screenshot = takesScreenshot.GetScreenshot();
        string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
        screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
        return screenshotLocation;
    }
}
