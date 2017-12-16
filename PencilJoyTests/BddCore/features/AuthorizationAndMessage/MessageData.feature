Feature: Actions for message field of a book
	In order to fill, edit, remove message data
	As a customer
	I want the system applies filled data of a book

@positive @emptyMessage
Scenario Outline: The user fills empty message field with correct data
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user clears existing message
	And The user fills text for it as <Message>
	And The user clicks the button Next
	Then The user is redirected to the bag page	
Examples: 
| Message |
|         |

@positive @endMessage
Scenario Outline: The user adds to existing message correct text to the end of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the end of the message as <Message>
	And The user clicks the button Next
	Then The user is redirected to the bag page	
Examples: 
| Message												|
|  Duis consequat dui nec nisi volutpat eleifend		|

@positive @startMessage
Scenario Outline: The user adds to existing message correct text to the start of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the start of the message as <Message>
	And The user clicks the button Next
	Then The user is redirected to the bag page	
Examples: 
| Message								|
|  Nullam sit amet turpis elementum		|

@positive @middleMessage
Scenario Outline: The user adds to existing message correct text to the middle of the message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user adds to existing message correct text to the middle of the message as <Message>
	And The user clicks the button Next
	Then The user is redirected to the bag page	
Examples: 
| Message										|
| Cras non velit nec nisi vulputate nonummy		|

@positive @defaultMessage
Scenario: The user doesn`t change existing message
	Given The user is a customer
	And The user is on the message page
	And The user fills authorization fields with correct data
	When The user doesn`t change existing message
	And The user clicks the button Next
	Then The user is redirected to the bag page	