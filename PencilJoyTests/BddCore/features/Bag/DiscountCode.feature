Feature: Verify discount code for order
	In order to fill discount code
	As a customer
	The user wants to be able to get discount for order, when the user has filled discount code

Scenario: The user fills correct discount code
    Given The user is a customer
    And The user is on bag page
    When The user correct fills field for discount code 
    Then The user gets discount for his order

Scenario: The user fills incorrect discount code
    Given The user is a customer
    And The user is on bag page
    When The user fills incorrect fill field for discount code 
    Then The user doesn`t get discount for his order, field for discount code should got a red border.

Scenario: Check discount percent for order
    Given The user is a customer
    And The user is on bag page
    When The user correct fill field for discount code 
    Then The user gets right discount percent for his order

Scenario: Expired discount code for order