Feature: Editing about child's data for a book
	In order to edit about child's data 
	As a customer
	The user wants the system applies edited child's data for a book

@positive @redirectFromPreviewPage
Scenario: The user is redirected to the edit page from the preview page
	Given The user is a customer
	And The user is on the preview page
	When The user clicks to the button Edit book
	Then The user is redirected to edit page.

@positive @editData
Scenario Outline: The user edits child's data with correct data
	Given The user is a customer
	And The user is on the edit book page
	When The user edits fields with correct data to fields name and date as <Username> , <NumberMonth> , <NumberDay> 
	And The user edits fields with correct data to field Gender as <numberSex> , <NumberCharacter>
	And The user clicks the button Update Changes
	Then The user is redirected to preview page with changing data.
| Username | NumberMonth | NumberDay | numberSex | NumberCharacter |
| Quill    | 11          | 19        | 0         | 5               |

@positive @editdata
Scenario: The user doesn`t edit child's data
	Given The user is a customer
	And The user is on the edit book page
	When The user isn`t edit fields
	And The user clicks the button Update Changes
	Then The user is redirected to preview page without changing data.

@negative @editData
Scenario Outline:  The user edits child's data with incorrect data
	Given The user is a customer
	And The user is on the edit book page	
	When The user edits fields with incorrect data to fields name and date as <Username> , <NumberMonth> , <NumberDay> 
	And The user edits fields with incorrect data to field Gender as <numberSex> , <NumberCharacter>
	And The user clicks the button Update Changes
	Then The user isn`t redirected to preview page with changing data.
| Username | NumberMonth	| NumberDay		| numberSex		| NumberCharacter	|
|	191215	|	8			|	3			|	0			|	2				|
|	Мария	|	8			|	20			|	1			|	1				|
|	ماريا		|	4			|	15			|	0			|	2				|
|	瑪麗亞	|	1			|	28			|	0			|	4				|
|	Quintin	|	2			|	29			|				|					|
|			|	2			|	29			|	1			|	5				|
