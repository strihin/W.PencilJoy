Feature: Filling customer`s data for authorization
	In order to fill authorization data
	As a customer
	The user wants the system applies filled data for authorization

@positive @newcustomer
Scenario Outline: The user fills data for new authorization with correct data
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user fills correct data for fields  as <FullName> , <Email>
	And The user clicks the button "Next"
	Then The user is redirected to the bag page
@source:AuthorizationData.xlsx
Examples: 
| FullName | Email |

@negative @newcustomer
Scenario: The user fills data for new authorization with existing data in DB
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user fills data for fields, which exists in DB  
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page

@negative @newcustomer @validation
Scenario: The user fills data for new authorization with invalid mail
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user fills correct name
	And The user fills invalid email as "ckdlck.cdjkl"
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page

@negative @newcustomer
Scenario: The user doesn`t fill data for new authorization
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user doesn`t fill data for fields
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page

@positive @returningcustomer
Scenario: The user fills data for registrated account before with correct data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB  
	And The user clicks the button "Next"
	Then The user is redirected to the bag page
	
@negative @returningcustomer
Scenario: The user fills data for registrated account before with expitrd data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields for expired account
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page

@negative @returningcustomer
Scenario: The user fills data for registrated account before with no existing data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which no exists in DB  
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
	
@negative @returningcustomer
Scenario: The user fills data for registrated account before with invalid password
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB  with incorrect password
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
	
@negative @returningcustomer
Scenario: The user fills data for registrated account before with invalid email
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB  with incorrect email
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page