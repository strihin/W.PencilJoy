Feature: Add addresses to checkout page
	In order to add billing and shipping addresses
	As a customer
	The user wants to be able to billing and shipping addresses to the checkout

@positive @fillingBothBlocks
Scenario: The user fills fields for shipping and billing address 
    Given The user is a customer
    And The user is on checkout page
    When The user fills fields for shipping address with correct data: 
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Jemimah	|	Winston	|	142 Lunder Junction	|	Asen	|	55154-6980	|	+359 (948) 603-7618	|	4			 |	Salinggara	|
	|	Rosie	|	Alwood	|	970 Maple Trail		|	Burgau	|	55315-251	|	+351 (652) 626-8183	|	20			 |	Soi Dao		|
	|	Lil		|	Bouzan	|	5 Walton Crossing	|	Ubaitab	|	55289-091	|	+55 (290) 603-7614	|	12			 |	Jdaidet 	|
	|	Gerty	|	Eagles	|	13911 Everett Pass	|	Eslāmāb	|	0924-5701	|	+98 (540) 526-5197	|	12			 |	Lumsden		|
	|	Wendye	|	Dury	|	27480 Melvin Street	|	Shipaid	|	10590-0001	|	+86 (245) 871-8082	|	13			 |	Panambi		|
	|	Natty	|	Davescu	|	549 Dawn Parkway	|	Talisay	|	0409-7938	|	+63 (655) 490-8096	|	22			 |	Libertad	|
	And The user clicks the checkbox Bill to this address
	And The user fills fields for billing address with correct data:
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	Olenolin	|	Lighter	|	61 Evergreen Crossing	|	Paris 06	|	0268-0639	|	+33 (860) 710-6683	|	20			|	Huallanca	|
	|	Herb		|	Cohen	|	115 Golf View Road		|	Yao’an		|	49260-615	|	+86 (267) 782-8010	|	13			|	Chornoliztsi|
	|	Margalit	|	Cochern	|	672 Utah Plaza			|	Brylivka	|	0362-9010	|	+380 (667) 550-6654	|	19			|	Krugersdorp	|
	|	Ximenes		|	Traut	|	3 Crowley Terrace		|	Xugu		|	52584-704	|	+86 (192) 784-2660	|	18			|	Omīdcheh	|
	|	Barbi		|	Dorsay	|	3108 Northwestern		|	Panyambungan|	43063-445	|	+62 (563) 802-6203	|	14			|	Malasin		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	|	Grace		|	Chictto	|	115 Arizona Parkway		|	Langtang	|	36800-647	|	+234 (683) 231-9702	|	20			|	Gongju		|
	Then All fields in the Billing ahd Shipping are filled

@ShippingAddressGeneral @positive @filling
Scenario Outline: The user fills fields for shipping address, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with correct data as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
	And The user clicks the checkbox Bill to this address
    When The user clicks the button Place your order
    Then The page is redirected to successful page
Examples: 
| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
|	Anica	|Wilcocke	|	041 Rusk Parkway	|	Baozi	|	51727-0631	|	+86 (606) 824-0816	|	20			 |	Hudong		|

@BillingAddressGeneral @positive @filling
Scenario Outline: The user fills fields for billing address, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And  The user fills fields for billing address with correct data as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	And The user clicks the checkbox Ship to this address 
    When The user clicks the button Place your order
    Then The page is redirected to successful page
Examples: 
| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
|	Anica	|Wilcocke	|	041 Rusk Parkway	|	Baozi	|	51727-0631	|	+86 (606) 824-0816	|	20			 |	Hudong		|

@positive @filling @country @shipping
Scenario Outline: Specifying State/Region name manually for country with defined State/Region for shipping address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the field Country in the block Shipping address with <country>
    Then The field  State/Region should be dropdown
Examples: 
| country        | 
| USA            |
| United Kingdom |

@positive @filling @country @shipping
Scenario Outline: Specifying State/Region name manually for country without State/Region defined for shipping address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the field Country in the block Shipping address with <country>
    Then The field  State/Region should be textbox
Examples: 
| country	|
|Austria	|
|Belgium	|
|Brazil		|
|Canada		|
|Colombia	|
|Denmark	|
|Germany	|
|France		|
|Hong Kong	|
|Ireland	|
|Italy		|
|Korea		|
|Netherland |
|Norway		|
|Singapore	|
|Spain		|
|Sweden		|
|Switzerland|
|Taiwan		|

@positive @filling @country @billing
Scenario Outline: Specifying State/Region name manually for country with defined State/Region for billing address
    Given The user is a customer
    And The user is on checkout page
	And The user clicks the checkbox Billing to this address in the block Shipping address
    When The user clicks the field Country in the block Billing address with <country>
    Then The field  State/Region should be dropdown
Examples: 
| country        | 
| USA            |
| United Kingdom |

@positive @filling @country @billing
Scenario Outline:  Specifying State/Region name manually for country without State/Region defined for billing address
    Given The user is a customer
    And The user is on checkout page
	And The user clicks the checkbox Billing to this address in the block Shipping address
    When The user clicks the field Country in the block Billing address with <country>
    Then The field  State/Region should be textbox
Examples: 
| country	|
|Austria	|
|Belgium	|
|Brazil		|
|Canada		|
|Colombia	|
|Denmark	|
|Germany	|
|France		|
|Hong Kong	|
|Ireland	|
|Italy		|
|Korea		|
|Netherland |
|Norway		|
|Singapore	|
|Spain		|
|Sweden		|
|Switzerland|
|Taiwan		|

@negative @filling @incorrectData
Scenario Outline: The user fills fields for shipping address with incorrect data, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with incorrect data as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
    And The user clicks the checkbox Bill to this address 
    When The user clicks the button Place your order
    Then The page doesn`t redirected to the successful page 
	And The shipping`s fields, which haven`t passed, get a red border.
Examples:
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	15946	|	Winston	|	142 Lunder Junction	|	Asen	|	55154-6980	|	+359 (948) 603-7618	|	4			 |	Salinggara	|
	|	Rosie	|	0649723	|	970 Maple Trail		|	Burgau	|	55315-251	|	+351 (652) 626-8183	|	20			 |	Soi Dao		|
	|	Lil		|	Bouzan	|	5 Walton Crossing	|	4545646	|	55289-091	|	+55 (290) 603-7614	|	12			 |	Jdaidet 	|
	|	Gerty	|	Eagles	|	13911 Everett Pass	|	Eslāmāb	|	Scoville	|	+98 (540) 526-5197	|	12			 |	Lumsden		|
	|	Wendye	|	Dury	|	27480 Melvin Street	|	Shipaid	|	10590-0001	|	Eguia				|	13			 |	Panambi		|
	|	Natty	|	Davescu	|	549 Dawn Parkway	|	Talisay	|	0409-7938	|	+63 (655) 490-8096	|	Chuanshan	 |	Libertad	|
	|	Olenolin|	Lightow	|	61 Evergreen		|	Paris 	|	0268-0639	|	+33 (860) 710-6683	|	20			 |	566464520	|

@negative @incorrectData @filling
Scenario Outline: The user fills fields for billing address with incorrect data, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for billing address with incorrect data  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
	And The user clicks the checkbox Ship to this address 
    When The user clicks the button Place your order
    Then The page doesn`t redirected to the successful page 
	And The billing address` fields, which haven`t passed, get a red border.
Examples: 
| UsernameB		| LastnameB |	StreetB				| CityB		|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
|	1216+502	|	Cohen	|	115 Golf View Road	|	Yao’an	|	49260-615	|	+86 (267) 782-8010	|	13			|	Chornoliztsi|
|	Margalit	|	132466	|	672 Utah Plaza		|	Brylivka|	0362-9010	|	+380 (667) 550-6654	|	19			|	Krugersdorp	|
|	Ximenes		|	Traut	|	3 Crowley Terrace	|	456465	|	52584-704	|	+86 (192) 784-2660	|	18			|	Omīdcheh	|
|	Barbi		|	Dorsay	|	3108 Northwestern	|	Panyambu|	Hudong		|	+62 (563) 802-6203	|	14			|	Malasin		|
|	Anica		|	Wilcoce	|	041 Rusk Parkway	|	Baozi	|	51727-0631	|	Xinpeicun			|	20			|	Hudong		|
|	August		|	Accomb	|	8 Grasskamp Trail	|	Kuroiso	|	0093-7206	|	+81 (504) 678-7207	|	Kearsley	|	Cucutilla	|
|	Grace		|	Chiccho	|	115 Arizona Parkway	|	Langtang|	36800-647	|	+234 (683) 231-9702	|	20			|	64245642	|

@negative @blockedControllers
Scenario: The user should blocked to click any fields and checkbox in the block Shipping address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox Ship to this address 
    Then The fields and checkbox in block Shipping address doesn`t available.

@negative @blockedControllers
Scenario: The user should blocked to click any fields and checkbox in the block Billing address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox Bill to this address 
    Then The fields and checkbox in block Billing address doesn`t available.