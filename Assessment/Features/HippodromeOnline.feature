Feature: HippodromeOnline
	In order to test registration functionality on Hippodrome Online
	As a developer
	I want to fill out the registration form and submit it
 
@HippodromeOnline
Scenario: The Website Should Render And A Register Button Should Display
	Given I have navigated to the website
	And I have clicked the register button
	When I fill in the registration form correctly
	And I put username as John636
	And I put email as test@testuser.co.za
	And I put password as P@SSW0RD@12331
	And I click the next button
	And I fill in firstname as John
	And I fill in surname as Smith
	And I set my birthday day to 04
	And I set my birthday month to 01
	And I set my birthday year to 1995
	And I click next
	And I select the country to ATA
	And I fill in zipcode to 8000
	And I fill in address 1 to 12 test street
	And I fill in address 2 to 12 test street
	And I fill in city to ASDASD
	And I fill in phone number to 123456

	Then I should get a registered successful