Feature: Choose PayPal payment on the checkout page
	In order to choose PayPal payment Billing Address
	As a customer
	The user wants to be able to choose PayPal payment

Scenario: The user clicks tab for seing PayPal payment
    Given The user is a customer
    And The user is on the checkout page
    And The user correct fills the fields for Billing Address as <UsernameB> <LastnameB> <StreetB> <CityB> <ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	Barbi		|	D'orsay	|	3108 Northwestern		|	Panyambungan|	43063-445	|	+62 (563) 802-6203	|	14			|	Malasin		|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS> <ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Gerty	|	Eagles	|	13911 Everett Pass	|	Eslāmāb	|	0924-5701	|	+98 (540) 526-5197	|	12			 |	Lumsden		|
	When The user clicks the tab PayPal in the Payment Data
    Then The tab should show the button Check out with PayPal

Scenario: The user chooses PayPal payment
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address as <UsernameB> <LastnameB> <StreetB> <CityB> <ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS> <ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
	And The user clicks the tab PayPal in the Payment Data
    When The user clicks the button Check out with PayPal
    Then The page is redirected to PayPal service
