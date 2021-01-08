Feature: AddItem
	

@mytag
Scenario: Add Item
	Given I am on DemoWebsite "https://www.demoblaze.com/"
	When I click Montors and add to cart
	Then monitor is add in the Cart