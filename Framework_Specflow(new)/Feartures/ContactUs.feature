Feature: ContactUs
	

@mytag
Scenario Outline: ContactUs
	Given I am on WebSite "https://www.demoblaze.com/"
	And I click Contact us link
	#When I provide the <Email> <Name> <Message> and click Send message button
	When I provide the <Email> <Name> and click Send message button
	Then message is sent
	Examples: 
	|Email				|Name |
	|test1@email.com	|Test1|

