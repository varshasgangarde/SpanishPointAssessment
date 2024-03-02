namespace SpanishPointAssessment.Utility;

public static class PageOjbects
{
    //public static readonly By RejectCookiesButton = By.XPath("//a[@id='wt-cli-reject-btn']");
    public static readonly By RejectCookiesButton = By.Id("wt-cli-reject-btn");
    //public static readonly By SolutionsAndServicesMenu = By.XPath("//li[@id='menu-item-30711']");
    public static readonly By SolutionsAndServicesMenu = By.Id("menu-item-30711");
    //public static readonly By ModernWorkMenuOption = By.XPath("//li[@id='menu-item-40377']");
    public static readonly By ModernWorkMenuOption = By.Id("menu-item-40377");
    public static readonly By ModernWorkTitleText = By.XPath("//section/div[5]/div/div/div/h2[contains(text(), 'Modern Workplace Solutions')]");
    public static readonly By DocumentManagementSystemTab = By.XPath("//section/div[5]/div/div/div/div[4]/div/div[1]/ul/li[3]/a/span");
    public static readonly By DocumentManagementSystemContent = By.XPath("//*[@id='document-management-system']/div[2]/div[1]/div[2]/div/div/div[1]");
    public static readonly By ContentAndCollaborationTab = By.LinkText("Content & Collaboration");
}
