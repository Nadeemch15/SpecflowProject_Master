Feature: Login User
	As a user, I want to Login to the website successfully

@LoginUser
Scenario Outline: Login User
	Given I am on login page	
	When User entere the login details <Email> <Password> 	
	Then User logged in successfully

	Examples:
| Email        | Password |
|asif@yahoo.com|123456	|