Feature: Verify discount code for order
	In order to fill discount code on the bag page
	As a customer
	The user wants to be able to get discount for order, when the user has filled discount code

@positive @fillcode
Scenario: The user fills correct discount code
    Given The user is a customer
    And The user is on the bag page
    When The user fills field for discount code with correct data
	And The user clicks the button "Check"
    Then The user gets discount for his order

@negative @fillcode
Scenario: The user fills incorrect discount code
    Given The user is a customer
    And The user is on the bag page
    When The user fills  field for discount code with incorrect data
	And The user clicks the button "Check"
    Then The user doesn`t get discount for his order, field for discount code should got a red border.

@redirect @positive
Scenario: The user is redirected to checkout page with correct discount code
    Given The user is a customer
    And The user is on the bag page
    And The user fills  field for discount code with correct data
	And The user clicks the button "Check"
    When The user clicks the button "Next" for redirecting to the checkout page
	Then The user is redirected to the checkout page, field for discount code should got a red border.
	
@redirect @negative
Scenario: The user is blocked to checkout page with incorrect discount code
    Given The user is a customer
    And The user is on the bag page
    And The user fills  field for discount code with incorrect data
	And The user clicks the button "Check"
    When The user clicks the button "Next" for redirecting to the checkout page
	Then The user doesn`t redirected to the checkout page, field for discount code should got a red border.

@positive @discountpercent
Scenario: Check discount percent for order
    Given The user is a customer
    And The user is on the bag page
    When The user fill field for discount code with correct data
	And The user clicks the button "Check"
    Then The user gets right discount percent for his order

@negative @expiredcode
Scenario: Expired discount code for order 
    Given The user is a customer
    And The user is on the bag page
    When The user fill field for discount code with expired date
	And The user clicks the button "Check"
	Then The user doesn`t redirected to the checkout page, field for discount code should got a red border.
