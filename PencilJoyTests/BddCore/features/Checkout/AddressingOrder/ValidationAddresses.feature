@checkout
Feature: Order addressing validation
    In order to avoid making mistakes when addressing an order
    As an Customer
    I want to be prevented from adding it without specifying required fields and checked incorrect data to fields

	@ui @negative @shipping
    Scenario: Shipping address without any filling fields
        Given The user is a customer
        And The user is on the checkout page
        When The user does not specify any shipping address information
        And The user  tries to complete the addressing step
        Then The user should be notified that all fields in the block "Shipping address" are required 

	@ui @negative @billing
    Scenario: Billing address without any filling fields
        Given The user is a customer
        And The user is on the checkout page
		And The user clicks the checkbox Bill to this address
        When The user does not specify any billing address information
        And The user  tries to complete the addressing step
        Then The user should be notified that all fields in the block "Billing address" are required 

	@ui @negative @shipping
    Scenario Outline: Shipping address without the first name and the last name
        Given The user is a customer
        And The user is on the checkout page
        When The user specifies  in shipping address all fields becides fields First name and Last name as <UsernameS> <LastnameS> <StreetS> <CityS> <ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
        And The user  tries to complete the addressing step
        Then The user should be notified that the "First name" in the block "Shipping address" is required
		And The user should be notified that the "Last name" in the block "Shipping address" is required
  Examples: 
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|			|			|	549 Dawn Parkway	|	Talisay	|	0409-7938	|	+63 (655) 490-8096	|	22			 |	Libertad	|   
	  
	@ui @negative  @billing
    Scenario Outline: Billing address without the first name and the last name
        Given The user is a customer
        And The user is on the checkout page
		And The user clicks the checkbox Bill to this address
		And The user clicks the checkbox Ship to this address
        When The user specifies  in billing address all fields becides fields First name and Last name as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
        And The user tries to complete the addressing step
        Then The user should be notified that the "First name" in the block "Shipping address" is required
		And The user should be notified that the "Last name" in the block "Shipping address" is required      
Examples: 
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|				|			|	115 Arizona Parkway		|	Langtang	|	36800-647	|	+234 (683) 231-9702	|	20			|	Gongju		|

    @ui @negative
    Scenario: Billing address without the city and the postcode / zip code and Shipping address without the Phone
        Given The user is a customer
        And The user is on the checkout page
		And The user clicks the checkbox Bill to this address
        When The user specifies  in billing address all fields becides fields City and Postcode / zip code  as <UsernameB> <LastnameB> <StreetB> <CityB> <ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|				|				|	+81 (504) 678-7207	|	3			|	Cucutilla	|	
		And The user specifies  in shipping address all fields becides fields Phone as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS| NumberCountryS | RegionS		|
	|	Natty	|	Davescu	|	549 Dawn Parkway	|	Talisay	|	0409-7938	|		|	22			 |	Libertad	|
        And The user  tries to complete the addressing step
        Then The user should be notified that field "City" in the block "Shipping address" is required
		And  The user should be notified that field "the postcode /zip code"  in the block "Billing address" is required
		And The user should be notified that the field "Phone" in shipping details is required


	@ui @negative @shipping
    Scenario Outline: Shipping address with the Phone as string
        Given The user is a customer
        And The user is on the checkout page
        When The user specifies  in shipping address all fields with correct data and field Phone as string  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
        And The user  tries to complete the addressing step
        Then The user should be notified that the field "Phone" in the block "Shipping address" doesn`t correct
Examples: 
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Natty	|	Davescu	|	549 Dawn Parkway	|	Talisay	|	0409-7938	|	three-two-one-one	|	22			 |	Libertad	|

	@ui @negative @billing
    Scenario Outline: Billing address with the Phone as string
        Given The user is a customer
        And The user is on the checkout page
		And The user clicks the checkbox Bill to this address
        When The user specifies  in billing address all fields with correct data and field Phone as string as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
		And The user  tries to complete the addressing step
        Then The user should be notified that the field "Phone" in the block "Billing address" doesn`t correct
Examples: 
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	Ximenes		|	Traut	|	3 Crowley Terrace		|	Xugu		|	52584-704	|	three-two-one-one	|	18			|	Omīdcheh	|