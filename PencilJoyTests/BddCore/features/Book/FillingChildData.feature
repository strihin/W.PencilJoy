Feature: Filling about child's data for a book
	In order to fill about child's data 
	As a customer
	The user wants the system applies filled child's data for a book

@positive
Scenario Outline: The user fills fields about child's data with correct data
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields name and date as <Username> , <NumberMonth> , <NumberDay> 
	And The user fills correct data to field Gender as <numberSex> , <NumberCharacter>
	Then The user is redirected to the preview page
Examples: 
| Username | NumberMonth | NumberDay | numberSex | NumberCharacter |
| Quill    | 11          | 19        | 0         | 4               |

@positive
Scenario Outline: The user fills fields about child's data without fields for birthday
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to field name as '<Username>' besides fields for birthday as month and day
	And The user fills correct data to field Gender as <numberSex> , <NumberCharacter>
	Then The user is redirected to the preview page
Examples: 
| Username | NumberMonth | NumberDay | numberSex | NumberCharacter |
| Dahlia   | null		 | null      | 1         | 2			   |

@negative
Scenario Outline: The user fills fields about child's data with incorrect data
	Given The user is a customer
	And The user is on the create book page
	When The user fills incorrect data to field Name and correct data for another fields as <Username> , <NumberMonth> , <NumberDay> <numberSex> , <NumberCharacter>
	Then The user  isn`t redirected to the preview page
	And The field for "First name" with incorrect data get a red border.
Examples:
| Username	| NumberMonth	| NumberDay		| numberSex		| NumberCharacter	|
|	191215	|	8			|	3			|	0			|	2				|
|	Мария	|	8			|	20			|	1			|	1				|
|	ماريا		|	4			|	15			|	0			|	2				|
|	瑪麗亞	|	1			|	28			|	0			|	4				|


@negative
Scenario Outline: The user fills fields about child's data without the field First name
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields and the field First name is empty: <Username> , <NumberMonth> , <NumberDay>
	And The user fills correct data to field Gender as <numberSex> , <NumberCharacter>
	Then The user  isn`t redirected to the preview page
	And The field "First name" gets a red border.
Examples: 
| Username	| NumberMonth	| NumberDay		| numberSex		| NumberCharacter	|
|			|	1			|	28			|	0			|	4				|
@negative
Scenario Outline: The user fills fields about child's data without the field Gender
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields without choosing the button "Gender" : <Username> , <NumberMonth> , <NumberDay>
	Then The user  isn`t redirected to the preview page
	And The button "Gender" gets a red border.
Examples: 
| Username	| NumberMonth	| NumberDay		| numberSex		| NumberCharacter	|
|	Quintin	|	2			|	29			|				|					|

@negative
Scenario Outline: The user fills fields about child's data without the option Character option
	Given The user is a customer
	And The user is on the create book page
	When The user fills correct data to fields without choosing the option Character option: <Username> , <NumberMonth> , <NumberDay> <numberSex>
	Then The user  isn`t redirected to the preview page
	And The button "Gender" gets a red border.
Examples: 
| Username	| NumberMonth	| NumberDay		| numberSex		| NumberCharacter	|
|	Kane	|	12			|	29			|	1			|					|

