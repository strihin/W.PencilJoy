Feature: Fill the fields about child data
	In order to fill book data
	As a customer
	The user wantss the system applies filled data for book

Scenario: The fields for child's data are filled by correct data
	Given The user is a customer
	And The user is on create book page
	When The user fill correct data to field
	Then The user is redirected to preview page

Scenario: Fields for child's data are filled by correct data
	Given The user is a customer
	And The user is on create book page
	When The user fills incorrect data to field
	Then The user stays on create book page and incorrect data get red border.

Scenario: Redirect to edit page
	Given The user is a customer
	And The user is on preview page
	When The user clicks to the button "Edit book"
	Then The user is redirected to edit page.

Scenario: Edit book by correct data on edit book page
	Given The user is a customer
	And The user is on edit book page
	When The user edits fields by correct data
	And clicks the button "Update Changes"
	Then The user is redirected to preview page with changing data.

Scenario: Edit book by incorrect data on edit book page
	Given The user is a customer
	And The user is on edit book page
	When The user edits fields by incorrect data
	And clicks the button "Update Changes"
	Then The user is redirected to preview page with changing data.

Scenario: Edit book by incorrect data on bag page
	Given The user is a customer
	And The user is registered user
	And The user is on bag page
	And The user clicks to link "Edit"
	When The user edits fields by incorrect data
	And clicks the button  "Update Changes"
	Then The user is stayed on edit book page and incorrect data get red border.

Scenario: Edit book by correct data on bag page
	Given The user is a customer
	And The user is new user
	And The user is on bag page
	And The user clicks to the link "Edit"
	When The user edits fields by incorrect data
	And click the button "Update Changes"
	Then The user is stayed on edit book page and incorrect data get red border