Feature: Choose PayPal payment on the checkout page
	In order to choose PayPal payment 
	As a customer
	The user wants to be able to choose PayPal payment

Scenario: The user clicks tab for seing PayPal payment
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Address
	When The user clicks the tab "PayPal" in the Payment Data
    Then The tab should be seen the button "Check out with PayPal"

Scenario: The user chooses PayPal payment
    Given The user is a customer
    And The user is on checkout page
    And The user correct fills the fields for Billing and Shipping Address
	And The user clicks the tab "PayPal" in the Payment Data
    When The user clicks the button "Check out with PayPal"
    Then Page is redirected to PayPal service
