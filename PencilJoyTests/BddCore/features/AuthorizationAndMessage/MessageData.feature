Feature: Fill message field about child data
	In order to fill message data
	As a customer
	I want the system applies filled data for book

Scenario: Redirect to message page
	Given The user is a customer
	And The user is on preview page
	When The user clicks the button "Order for ..."
	Then The user is redirected to message page

Scenario: Field for message data is filled by correct data
	Given The user is a customer
	And The user is on message page
	When The user clears existing message 
	And fill new text for it
	And click the button "Next"
	The user is redirected to bag page	