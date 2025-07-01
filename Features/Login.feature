Feature: Login
This feature is of login. The tests contains the login to platform

@Regression
Scenario: Logging in to platform with a valid username and password
	Given We navigate to the login page
	And We we click on accept consent button
	And We enter username and password and click on Login button
	Then User is logged into dashboard 
