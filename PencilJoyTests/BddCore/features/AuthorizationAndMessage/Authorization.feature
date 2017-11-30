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
Examples: 
| FullName          | Email						|
|Mano Eyam          | mey+-a.M_7@icq.com		|
|Fannie Lillow		| 8fli.l.l.ow8@php.net		|
|Gonzales Spenton	| gspenton9@cbsnews.com		|
|Mommy Hummerston	| mhummerstona@enga-dget.com|
|Bill Goldby		| bgoldbyb@ly.co.s.com		|
|Alphard Fears		| afearsc@nature.com		|
|Auroora Dauncey	| adaunceyd@seesaa.net		|
|Rosalind Abramson	| rabramsone@webeden.co.uk	|
|Ivan Marienko		| ivan@марья.рф				|
|Muslim Ivanov		| ivan@اتصالات‎.اتصالات‎		|

@negative @newcustomer
Scenario Outline: The user fills data for new authorization with existing data in DB
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user fills data for fields, which exists in DB  as <FullName> , <Email>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| FullName				| Email						|
|	Auroora Dauncey		|	qaengineer6@yahoo.com	|
|	Birgit Drennan		|	qaengineer7@yahoo.com	|
|	Casi Demo			|	demo@altsolution.net	|


@negative @newcustomer @validation
Scenario Outline: The user fills data for new authorization with invalid mail
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user fills correct name and invalid email as <FullName> , <Email>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| FullName           | Email                       |
| Rivy Vasishchev    | .rvasishchevf@amazonaws.com |
| Rayner Biggin      | rbigging.@about.me          |
| Hamilton Witherden | "hwitherdenh"@netscape.com  |
| Birgit Drennan     | bdr@ennani@suncom           |
| Augustine Puden    | apudenj@-myspace.com        |
| Udale Ballsdon     | uballsdonk@so-net-.ne.jp    |
| Archer Spittle     | aspittlel@privacy..au       |
| Ivan Marienko      | иван@марья.рф               |

@negative @newcustomer
Scenario Outline: The user doesn`t fill data for new authorization
	Given The user is a new user
	And The user is on the message page
	And The active tab is "New customer"
	When The user doesn`t fill data for fields
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| FullName | Email         |
|          |               |
| Alex     |               |
|          | tes@test.test |

@positive @returningcustomer
Scenario Outline: The user fills data for registrated account before with correct data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB as <Email>, <Password>
	And The user clicks the button "Next"
	Then The user is redirected to the bag page
Examples: 
| Email                 | Password |
| qaengineer6@yahoo.com | 1q1q1q   |
| qaengineer7@yahoo.com | 1q1q1q   |
| demo@altsolution.net  | 1q1q1q   |

	
@negative @returningcustomer
Scenario Outline: The user fills data for registrated account before with expitrd data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields for expired account as <Email>, <Password>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| Email               | Password |
| qaengineer9@ukr.net | 1q1q1q   |

@negative @returningcustomer
Scenario Outline: The user fills data for registrated account before with no existing data
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which no exists in DB as  <Email>, <Password>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| Email                   | Password      |
| lgillisq@soundcloud.com | pass10383     |
| gbaumer@fc2.com         | baumerosen202 |
	
@negative @returningcustomer
Scenario Outline: The user fills data for registrated account before with invalid password
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB  with incorrect password  as  <Email>, <Password>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
Examples: 
| Email						| Password	|
| qaengineer6@yahoo.com		| 1q1q		|
| qaengineer7@yahoo.com		| 1q1 q1q   |
| demo@altsolution.net		| 1q1q1q1q1 |	

@negative @returningcustomer
Scenario Outline: The user fills data for registrated account before with invalid email
	Given The user is a registrated user
	And The user is on the message page
	And The user clicks the tab "Returning customer"
	When The user fills data for fields, which exists in DB  with incorrect email  as  <Email>, <Password>
	And The user clicks the button "Next"
	Then The user doesn`t redirected to the bag page
| Email                   | Password |
| qaengineer678@yahoo.com | 1q1q1q   |
| qaengineer7@yahoocom    | 1q1q1q   |
| demoaltsolution.net     | 1q1q1q   |
| akopsx@i2i.jp789        | 1q1q1q   |
| bdelortygoodreads.com   | 1q1q1q   |
