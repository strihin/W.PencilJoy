Feature: Remove value from addresses fields
	In order to remove value in billing and shipping addresses fields
	As a customer
	The user wants to be able to remove values from fields in billing and shipping addresses

@positive @removeValue @shipping
Scenario Outline: The user removes value for the field "Last name" in the block "Shipping Address"
    Given The user is a customer
    And The user is on the checkout page
    And The user fills fields for shipping address with data  as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
    When The user removes  values for the field "Last name" in the block "Shipping address"
    Then The field "Last name" should be empty  in the block "Shipping address"
Examples: 
	| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
	|	Natty	|	Davescu	|	549 Dawn Parkway	|	Talisay	|	0409-7938	|	+63 (655) 490-8096	|	22			 |	Libertad	|

@positive @removeValue @shipping
Scenario Outline: The user removes value for the field "City" in the block "Billing Address"
    Given The user is a customer
    And The user is on the checkout page
	And The user clicks the checkbox Billing to this address in the block Shipping address
    And The user fills fields for billing address with data  as <UsernameB> <LastnameB> <StreetB> <CityB>	<ZipCodeB> <PhoneB> <NumberCountryB> <RegionB>
    When The user removes  values for the field "City" in the block "Billing address"
    Then The field "City" should be empty in the block "Billing address"
Examples: 
	| UsernameB		| LastnameB |	StreetB					| CityB			|	ZipCodeB	| PhoneB				| NumberCountryB| RegionB		|
	|	Olenolin	|	Lighter	|	61 Evergreen Crossing	|	Paris 06	|	0268-0639	|	+33 (860) 710-6683	|	20			|	Huallanca	|
	|	Herb		|	Cohen	|	115 Golf View Road		|	Yao’an		|	49260-615	|	+86 (267) 782-8010	|	13			|	Chornoliztsi|
	|	Margalit	|	Cochern	|	672 Utah Plaza			|	Brylivka	|	0362-9010	|	+380 (667) 550-6654	|	19			|	Krugersdorp	|
	|	Ximenes		|	Traut	|	3 Crowley Terrace		|	Xugu		|	52584-704	|	+86 (192) 784-2660	|	18			|	Omīdcheh	|
	|	Barbi		|	D'orsay	|	3108 Northwestern		|	Panyambungan|	43063-445	|	+62 (563) 802-6203	|	14			|	Malasin		|
	|	August		|	Accomb	|	8 Grasskamp Trail		|	Kuroiso		|	0093-7206	|	+81 (504) 678-7207	|	3			|	Cucutilla	|
	|	Grace		|	Chictto	|	115 Arizona Parkway		|	Langtang	|	36800-647	|	+234 (683) 231-9702	|	20			|	Gongju		|

