Feature: GoogleNews
	In order to test search functionality on youtube
	As a developer
	I want to ensure functionality is working end to end
 
@GoogleNews
Scenario: Google news should render and news titles should render
	Given I have navigated to google news website
	When I have loaded into the page successfully
	Then I should pull down all headline titles