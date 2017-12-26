Feature: Change value for fields in addresses blocks on the checkout page
	In order to change billing and shipping addresses data
	As a customer
	The user wants to be able to change billing and shipping addresses data on the checkout page

@positive @editValue @shipping
Scenario Outline: The user changes value for fields in the block Shipping Address
    Given The user is a customer
    And The user is on the checkout page
    And The user fills fields for shipping address with data  as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
    When The user edits the field "Last name" in the block Shipping Address "Cortes"
	Then The field "Last name" should be edited
Examples: 
| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
|	Anica	|Wilcocke	|	041 Rusk Parkway	|	Baozi	|	51727-0631	|	+86 (606) 824-0816	|	20			 |	Hudong		|

@positive @editValue @shipping
Scenario Outline: The user changes value for fields in the block Billing Address
    Given The user is a customer
    And The user is on the checkout page
	And The user clicks the checkbox Billing to this address in the block Shipping Address
    And The user fills fields for shipping address with data  as <UsernameS> <LastnameS> <StreetS> <CityS>	<ZipCodeS> <PhoneS> <NumberCountryS> <RegionS>
    When The user edits the field "City" in the block Billing Address as "Kirove"
	Then The field "City" should be edited
Examples: 
| UsernameS | LastnameS |	StreetS				| CityS		|	ZipCodeS	| PhoneS				| NumberCountryS | RegionS		|
|	Jemimah	|	Winston	|	142 Lunder Junction	|	Asen	|	55154-6980	|	+359 (948) 603-7618	|	4			 |	Salinggara	|

