Feature: Editing about child's data for a book
	In order to edit about child's data 
	As a customer
	The user wants the system applies edited child's data for a book

@positive @redirectEditpage
Scenario: The user is redirected to the edit page
	Given The user is a customer
	And The user is on the preview page
	When The user clicks to the button "Edit book"
	Then The user is redirected to edit page.

@positive @editData
Scenario: The user edits child's data with correct data
	Given The user is a customer
	And The user is on the edit book page
	When The user edits fields with correct data
	And The user clicks the button "Update Changes"
	Then The user is redirected to preview page with changing data.


@positive @editdata
Scenario: The user doesn`t edit child's data
	Given The user is a customer
	And The user is on the edit book page
	When The user doesn`t edit fields
	And The user clicks the button "Update Changes"
	Then The user is redirected to preview page without changing data.

@negative @editData
Scenario:  The user edits child's data with incorrect data
	Given The user is a customer
	And The user is on the edit book page
	When The user edits fields with incorrect data
	And clicks the button "Update Changes"
	Then The user doesn`t redirected to preview page with changing data.