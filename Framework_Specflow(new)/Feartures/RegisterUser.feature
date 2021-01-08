Feature: Register
	

@Register
Scenario Outline: Register User
	Given I am on Demoblase websit "https://www.demoblaze.com/"
	And I click Sing up link
	When I enter user detials <Username> <password> and click Sign up button
	#Then user created successflly
	Examples: 
	| Username | password |
	|Test103    |12345678  |