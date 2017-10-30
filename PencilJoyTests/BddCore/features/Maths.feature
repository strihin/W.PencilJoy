Feature: Equal price value on different steps of order
	In order to compare value on different steps of order
	As a customer
	The user wants to be able to edit currency for order

Scenario: Equal currency and price value on preview and bag page 
	Given The user is a customer
	And The user is on preview page
	And Get currency and price for a book from the button "Order for .." on preview page
	And The user clicks the button "Order for .."
	And The user clicks the button "Next" on the message page
	Then get price for the first book on the bag page
	And get currency on the bag page

Scenario: Equal discount code on bag and checkout page
Scenario: Equal full price on bag and checkout page
Scenario: Equal currency on bag and checkout page 
Scenario: Check discount code`s value with name
Scenario: Check price for 1st book with different currency

11***************Remind me later***************
12*****************Profile page. Order list. Change password*************