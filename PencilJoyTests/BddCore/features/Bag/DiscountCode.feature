Feature: Verify discount code for order
	In order to fill discount code on the bag page
	As a customer
	The user wants to be able to get discount for order, when the user has filled discount code

@positive @fillcode
Scenario: The user fills correct discount code
    Given The user is a customer
    And The user is on the bag page
    When The user fills field for discount code with correct data as <DiscountCode>
	And The user clicks the button "Check"
    Then The user gets discount for his order as DiscountPercent
Examples: 
| DiscountCode  |  DiscountPercent	|
| kendra35		| 35				|
| vip25			| 25				|
| holiday20		| 20				|
| SARAB			| 5					|
| NOV			| 5					|
| kelina15		| 15				|

@redirect @positive
Scenario Outline: The user is redirected to checkout page with correct discount code
    Given The user is a customer
    And The user is on the bag page
    And The user fills  field for discount code with correct data  as <DiscountCode> 
	And The user clicks the button "Check"
    When The user clicks the button "Next" for redirecting to the checkout page
	Then The user is redirected to the checkout page, 
	And The field for discount code should get value as <DiscountPercent>
Examples: 
| DiscountCode  | DiscountPercent	|
| kendra35		| 35				|
| vip25			| 25				|

@negative @fillcode
Scenario Outline: The user fills incorrect discount code
    Given The user is a customer
    And The user is on the bag page
    When The user fills  field for discount code with incorrect data as <DiscountCode>
	And The user clicks the button "Check"
    Then The user doesn`t get discount for his order, field for discount code should got a red border.
	Examples: 
| DiscountCode  |
| kendra3545	|
| 000vip		|
| kimcoup		|
| Bles			|
| test			|
| 15			|
| dawn2008		|

@redirect @negative
Scenario Outline: The user is blocked to checkout page with incorrect discount code
    Given The user is a customer
    And The user is on the bag page
    And The user fills  field for discount code with incorrect data  as <DiscountCode>
	And The user clicks the button "Check"
    When The user clicks the button "Next" for redirecting to the checkout page
	Then The user doesn`t redirected to the checkout page, field for discount code should got a red border.
	Examples: 
| DiscountCode  |
| kendra3545	|
| 000vip		|
| kimcoup		|
| Bles			|
| test			|
| 15			|
| dawn2008		|

@positive @discountpercent
Scenario Outline: Check discount percent for order
    Given The user is a customer
    And The user is on the bag page
    When The user fills the field for discount code with correct data as <DiscountCode>
	And The user clicks the button "Check"
    Then The user gets right discount percent for his order as <DiscountPercent>
Examples: 
| DiscountCode  |  DiscountPercent	|
| kendra35		| 35				|
| vip25			| 25				|
| holiday20		| 20				|
| SARAB			| 5					|

@negative @expiredstartcode
Scenario: Expired  start date for discount code  
    Given The user is a customer
    And The user is on the bag page
    When The user fills field for discount code with expired start date as <DiscountCode>
	And The user clicks the button "Check"
	Then The user doesn`t redirected to the checkout page, field for discount code should got a red border.
Examples: 
| DiscountCode  |
| kimcoup30		|
| todayonly15	|
| dawn20		|

@negative @expiredendcode
Scenario: Expired  end date for discount code  
    Given The user is a customer
    And The user is on the bag page
    When The user fills field for discount code with expired end date as <DiscountCode>
	And The user clicks the button "Check"
	Then The user doesn`t redirected to the checkout page, field for discount code should got a red border.
Examples: 
| DiscountCode  |
| Blessings35	|
| emmy15		|
| special15		|