Feature: Add addresses to checkout page
	In order to add billing and shipping addresses
	As a customer
	The user wants to be able to billing and shipping addresses to the checkout

Scenario: The user fills fields for shipping address, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address by correct data 
    And clicks the checkbox "Bill to this address" 
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

Scenario: The user fills fields for shipping address by incorrect data, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address by incorrect data 
    And clicks the checkbox "Bill to this address" 
    When The user clicks the button "Place your order"
    Then Page isn`t redirected to successful page and shipping`s fields, which haven`t passed, get a red border.

Scenario: The user fills fields for shipping address, the billing address is equal shipping address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox "Bill to this address" 
    Then The fields and checkbox in block "Billing address" aren`t available.

Scenario: The user fills fields for billing address, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for billing address by correct data 
    And clicks the checkbox "Ship to this address" 
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

Scenario: The user fills fields for billing address by incorrect data, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for billing address by incorrect data 
    And clicks the checkbox "Ship to this address" 
    When The user clicks the button "Place your order"
    Then Page isn`t redirected to successful page and billing address` fields, which haven`t passed, get a red border.

Scenario: The user fills fields for billing address, the shipping address is equal billing address
    Given The user is a customer
    And The user is on checkout page
    When The user clicks the checkbox "Ship to this address" 
    Then The fields and checkbox in block "Shipping address" aren`t available.