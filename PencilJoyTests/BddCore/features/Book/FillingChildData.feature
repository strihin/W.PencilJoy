Feature: Filling about child's data for a book
	In order to fill about child's data 
	As a customer
	The user wants the system applies filled child's data for a book

@positive
Scenario Outline: The user fills fields about child's data with correct data
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields as <Username> , <NumberMonth> , <NumberDay> <numberSex> , <NumberCharacter>
	Then The user is redirected to the preview page
@source:ChildData.xlsx
Examples: 
| Username | NumberMonth | NumberDay | numberSex | NumberCharacter |

@positive
Scenario: The user fills fields about child's data without fields for birthday
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to all fields besides fields for birthday as month and day
	Then The user is redirected to the preview page

@negative
Scenario: The user fills fields about child's data with incorrect data
	Given The user is a customer
	And The user is on the create book page
	When The user fills incorrect data to fields
	Then The user doesn`t redirected to the preview page
	And The fields with incorrect data gets a red border.

@negative
Scenario: The user fills fields about child's data without the field "First name"
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields besides the field "First name"
	And The user leaves the field "First name" empty
	Then The user doesn`t redirected to the preview page
	And The field "First name" gets a red border.

@negative
Scenario: The user fills fields about child's data without the field "Gender"
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields without choosing the button "Gender" as "Boy"
	Then The user doesn`t redirected to the preview page
	And The buttons "Boy", "Girl" get a red border.

@negative
Scenario: The user fills fields about child's data without the option "Character option"
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields without choosing the option "Character option"
	Then The user doesn`t redirected to the preview page
	And The buttons "Boy", "Girl" get a red border.

