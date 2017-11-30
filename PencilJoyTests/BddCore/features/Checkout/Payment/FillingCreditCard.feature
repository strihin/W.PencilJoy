Feature: Add payment data to checkout page
	In order to add payment data by credit card and paypal
	As a customer
	The user wants to be able to fill payment data to the payment method 

@payment @positive
Scenario Outline: The user fills fields for credit card with correct data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
    And The user fills the fields for 'Credit Card' tab with correct data  such as <CreditCardInput>	<CardVerifacationValue> <SelectMonth>	<SelectYear>
    When The user clicks the button 'Place your order'
    Then Page is redirected to successful page
Examples: 
| CreditCardInput  | CardVerifacationValue | SelectMonth | SelectYear |
| 4242424242424242 | 392                   | 12          | 2018       |
| 4242424242424242 | 451                   | 1           | 2018       |
| 4242424242424242 | 392                   | 6           | 2022       |

@payment @negative @emptyForm
Scenario: The user does not fill fields for credit card
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
    And The user chooses the tab 'Credit Card' 
	When The user left the fields as empty
    Then Page doessn`t redirected to successful page 
	And It should be shown message "Could not find payment information."

@payment @negative @vercode
Scenario Outline: The user fills the textbox "Card verification value" with incorrect data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
    And The user chooses the tab 'Credit Card' 
    When The user fills the fields for 'Credit Card' tab with correct data and the card verification value with incorrect data as <CreditCardInput>	<CardVerifacationValue> <SelectMonth>	<SelectYear>
    Then Page doesn`t redirected to successful page 
	And It should be shown message "Could not find payment information."
Examples:
| CreditCardInput  | CardVerifacationValue | SelectMonth | SelectYear |
| 4242424242424242 | 08968987689           | 12          | 2018       |
| 4242424242424242 | 2	                   | 1           | 2018       |
| 4242424242424242 |	                   | 6           | 2022       |
| 4242424242424242 | string				   | 4           | 2020       |
| 4242424242424242 | 78u		           | 3           | 2019       |

@payment @negative @expiredDate
Scenario Outline: The user fills fields for credit card with expired date
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
    And The user chooses the tab 'Credit Card' 
    When  The user fills the fields for 'Credit Card' tab with correct data besides the expiration date as <CreditCardInput> <CardVerifacationValue> <SelectMonth>	<SelectYear>
    And The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page 
	And It should be shown message "Could not find payment information."
Examples:
| CreditCardInput  | CardVerifacationValue | SelectMonth | SelectYear |
| 4242424242424242 | 392                   | 1           | 2017       |
| 4242424242424242 | 451                   | 12          | 2016       |
| 4242424242424242 | 392                   | 11          | 2017       |

@payment @negative @cardNumber
Scenario Outline: The user fills fields for credit card with incorrect card number
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing Address  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	And The user correct fills the fields for Shipping Address as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Grace	|	Chictto	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			 |	Gongju		|
    And The user chooses the tab 'Credit Card' 
    When  The user fills the fields for 'Credit Card' tab with correct data besides the card number as <CreditCardInput> <CardVerifacationValue> <SelectMonth>	<SelectYear>
   
    When The user fills the card number with incorrect data such as "1010 0101 0000 1010"
    And The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page
	And It should be shown message "Could not find payment information."
Examples:
| CreditCardInput  | CardVerifacationValue | SelectMonth | SelectYear |
| 1010010100001010 | 392                   | 12          | 2018       |
| 0				   | 451                   | 1           | 2018       |
| 24242424242424278| 392                   | 6           | 2022       |
| stringvalue	   | 392                   | 12          | 2018       |
| 424242stringvalue| 451                   | 1           | 2018       |
| 0978578646587689 | 392                   | 6           | 2022       |