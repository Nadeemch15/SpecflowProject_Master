Feature: LoginUser

	Scenario Outline: Login User
	Given I am on Demoblase "https://www.demoblaze.com/"
	And user click Login link
	When I enter Login detials <Username> <password> and click Login button
	#Then user successflly logged in
	Examples: 
	| Username | password |
	|Test101    |12345678  |