Feature: Add payment data to checkout page
	In order to add payment data by credit card and paypal
	As a customer
	The user wants to be able to fill payment data to the payment method 

@payment @positive
Scenario: The user fills fields for credit card with correct data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Addresses
    And The user fills the fields for "Credit Card" tab with correct data  such as
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

@payment @negative @emptyForm
Scenario: The user does not fill fields for credit card
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Addresses
    And The user fills the card number and expiration date for "Credit Card" tab by correct data
    And The user fills the card verification value by incorrect data     
    When The user left the fields be empty
    Then Page doessn`t redirected to successful page 
	And It should be shown message "Could not find payment information."

@payment @negative @vercode
Scenario: The user fills the textbox "Card verification value" with incorrect data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Addresses
    And The user fills the card number and expiration date for the tab "Credit Card" with correct data
    When The user fills the textbox "Card verification value" with incorrect data 
	And The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page 
	And It should be shown message "Could not find payment information."

@payment @negative @expiredDate
Scenario: The user fills fields for credit card with expired date
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Addresses
    And The user fills the card number and card verification value for the tab "Credit Card" with correct data
    When The user fills the expiration date with expired date such as 01-January for month and 2017 for year
    And The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page 
	And It should be shown message "Could not find payment information."

@payment @negative @cardNumber
Scenario: The user fills fields for credit card with incorrect card number
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Addresses
    And The user fills the expiration and card verification value date for the tab "Credit Card" with correct data
    When The user fills the card number with incorrect data such as "1010 0101 0000 1010"
    And The user clicks the button "Place your order"
    Then Page doesn`t redirected to successful page
	And It should be shown message "Could not find payment information."
