Feature: Login
	In order not to repeat my feature steps
	As a guru tester
	I want to use background to avoid repitation


Background: User is Logged In
    Given I navigate to the website"https://www.qa.giftrete.com"
	When I click on Sign in
	And I enter my email "nelytino@yahoo.com"
	And I enter my password "nnenna123"
	And I click on Sign In bottun
	#Then I should see "Home"

@mytag
Scenario: one
	When  I click on prifile image
	And I click on Logout
	Then I should see message "Forgot password?"


Scenario: Two
    When I click on community
	#Then the message "Discover Communities"
	And I click on profile name bottun
	And I click on logout bottun
	Then I should see the message "Forgot password"


Scenario: Three
     When I click on Search
	 #Then I should see "Items posted to giftretecycle"
	 And I click on profile bottun
	 And I click on Log bottun
	 Then message "Forgot password"



