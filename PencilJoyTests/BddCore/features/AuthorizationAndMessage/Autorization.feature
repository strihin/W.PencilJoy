Feature: Fill customer data for autorization
	In order to fill autorization data
	As a customer
	The user wantss the system applies filled data for autorization
@correctData1
Scenario: Fields for new autorization data are filled by correct data
	Given The user is a new user
	And The user is on message page
	And The active tab is "New customer"
	When The user fills correct data for fields  
	And clicks the button "Next"
	Then The user is redirected to bag page

Scenario: incorected data
Scenario: Forget password