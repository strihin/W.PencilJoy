Feature: Add addresses to checkout page
	In order to add billing and shipping addresses
	As a customer
	The user wants to be able to billing and shipping addresses to the checkout

@positive @fillingBothBlocks
Scenario Outline: The user fills fields for shipping and billing address 
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with correct data as <Username>	<Lastname>	<Street>	<City>	<ZipCode>	<Phone>	<NumberCountry>	<Region>
    And The user clicks the checkbox "Bill to this address"
	And The user fills fields for billing address with correct data as <Username>	<Lastname>	<Street>	<City>	<ZipCode>	<Phone>	<NumberCountry>	<Region>
    When All fields in the Billing ahd Shipping are filled
	Then The values in Blocks should be difference
@source:CheckoutShippingAddressData.xlsx
| Username | Lastname |	Street | City |	ZipCode	| Phone	| NumberCountry | Region |
@source:CheckoutBillingAddressData.xlsx
| Username | Lastname |	Street | City |	ZipCode	| Phone	| NumberCountry | Region |


@ShippingAddressGeneral @positive @filling
Scenario: The user fills fields for shipping address, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with correct data 
    And The user clicks the checkbox "Bill to this address" 
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

@BillingAddressGeneral @positive @filling
Scenario: The user fills fields for billing address, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And  The user fills fields for billing address with correct data 
    And The user clicks the checkbox "Ship to this address" 
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

@positive @filling @country @shipping
Scenario Outline: Specifying State/Region name manually for country with defined State/Region for shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with correct data 
    When The user clicks the field "Country" in the block "Shipping address" with <country>
    Then The field  "State/Region" should be dropdown
Examples: 
| country        | 
| USA            |
| United Kingdom |

@positive @filling @country @shipping
Scenario Outline: Specifying State/Region name manually for country without State/Region defined for shipping address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the field "Country" in the block "Shipping address" with <country>
    Then The field  "State/Region" should be textbox
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
	And The user clicks the checkbox "Billing to this address" in the block "Shipping address"
    When The user clicks the field "Country" in the block "Billing address" with <country>
    Then The field  "State/Region" should be dropdown
Examples: 
| country        | 
| USA            |
| United Kingdom |

@positive @filling @country @billing
Scenario Outline:  Specifying State/Region name manually for country without State/Region defined for billing address
    Given The user is a customer
    And The user is on checkout page
	And The user clicks the checkbox "Billing to this address" in the block "Shipping address"
    When The user clicks the field "Country" in the block "Billing address" with <country>
    Then The field  "State/Region" should be textbox
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

@negative @filling
Scenario Outline: The user fills fields for shipping address with incorrect data, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address by incorrect data 
    And clicks the checkbox "Bill to this address" 
    When The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page and shipping`s fields, which haven`t passed, get a red border.

@negative @incorrectData
Scenario: The user fills fields for billing address with incorrect data, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for billing address by incorrect data 
    And The user clicks the checkbox "Ship to this address" 
    When The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page and billing address` fields, which haven`t passed, get a red border.

@negative @blockedControllers
Scenario: The user should blocked to click any fields and checkbox in the block "Shipping address"
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox "Ship to this address" 
    Then The fields and checkbox in block "Shipping address" doesn`t available.