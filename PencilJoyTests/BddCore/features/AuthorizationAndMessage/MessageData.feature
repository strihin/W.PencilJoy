Feature: Actions for message field of a book
	In order to fill, edit, remove message data
	As a customer
	I want the system applies filled data of a book


@positive @emptyMessage
Scenario: The user fills empty message field with correct data
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user clears existing message 
	And The user fills text for it
	And The user click the button "Next"
	Then The user is redirected to the bag page	

@positive @endMessage
Scenario: The user adds to existing message correct text to the end of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the end of the message
	And The user click the button "Next"
	Then The user is redirected to the bag page	

@positive @startMessage
Scenario: The user adds to existing message correct text to the start of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the start of the message
	And The user click the button "Next"
	Then The user is redirected to the bag page	

@positive @middleMessage
Scenario: The user adds to existing message correct text to the middle of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the middle of the message
	And The user click the button "Next"
	Then The user is redirected to the bag page	

@positive @defaultMessage
Scenario: The user doesn`t change existing message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user doesn`t change existing message
	And The user click the button "Next"
	Then The user is redirected to the bag page	