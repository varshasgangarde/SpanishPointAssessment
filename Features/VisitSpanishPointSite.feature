Feature: Accessing Tabs of Modern Workplace Solutions On Spanish Point Technology Website

@DocumentManagementSystem
Scenario Outline: Verify Document Management System Tab Header And Paragraph
	Given Open the browser
	When Enter the url <spanish_point_url>
	When Hover on Solutions And Services menu
	When Click on Modern Work  menu option
	When Scroll down to Modern Workplace Solutions section
	When Click on Document Management System tab
	Then Search for header <tab_header>
	And Search for paragraph <panel_paragraph>

  
Examples:
	| spanish_point_url            | tab_header                 | panel_paragraph                                                  |
	| https://www.spanishpoint.ie/ | Document Management System | Our Document Management System is a comprehensive suite of tools |



@ContentAndCollaboration
Scenario Outline: Verify Content And Collaboration Tab
	Given Open the browser
	When Enter the url <spanish_point_url>
	When Hover on Solutions And Services menu
	When Click on Modern Work  menu option
	When Scroll down to Modern Workplace Solutions section
	Then Click on Content And Collaboration System tab

  
Examples:
	| spanish_point_url            |
	| https://www.spanishpoint.ie/ |