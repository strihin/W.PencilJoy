Feature: Clickable fields on the checkout page
	In order to click fields for billing and shipping addresses
	As a customer
	The user wants to be able clicking fields for billing and shipping addresses

@negative @clickable
Scenario: The user select the billing address is equal shipping address, the "Billing block" isn`t clickable
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox Bill to this address 
    Then The fields and checkbox in the block "Billing address" are disabled.

@negative @clickable
Scenario: The user select the shipping address is equal billing address, the "Shipping block" isn`t clickable
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox Ship to this address
    Then The fields and checkbox in the block "Shipping address" are disabled.