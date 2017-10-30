Feature: Add payment data to checkout page
	In order to add payment data by credit card and paypal
	As a customer
	The user wants to be able to fill payment data to the method payment

Scenario: The user fills fields for credit card by correct data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Address
    And The user fills the fields for "Credit Card" tab by correct data     
    When The user clicks the button "Place your order"
    Then Page is redirected to successful page

Scenario: The user fills fields for credit card by incorrect data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Address
    And The user fills the card number and expiration date for "Credit Card" tab by correct data
    And The user fills the card verification value by incorrect data     
    When The user clicks the button "Place your order"
    Then Page isn`t redirected to successful page and It should be shown message "Your card verification value is incorrect."

Scenario: The user fills fields for credit card by incorrect data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Address
    And The user fills the card number and card verification value for "Credit Card" tab by correct data
    And The user fills the expiration date by incorrect data     
    When The user clicks the button "Place your order"
    Then Page isn`t redirected to successful page and It should be shown message "Your credit date is expired."

Scenario: The user fills fields for credit card by incorrect data
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Address
    And The user fills the expiration and card verification value date for "Credit Card" tab by correct data
    And The user fills the card number by incorrect data     
    When The user clicks the button "Place your order"
    Then Page isn`t redirected to successful page and It should be shown message "Your card number is incorrect."

Scenario: The user is redirected to the PayPal website
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Address
    When The user clicks the button "Check out with PayPal"
    Then Page is redirected to the PayPal website

  Scenario: PayPal website. Fill fields by correct data
  Scenario: PayPal website. Fill fields by incorrect data