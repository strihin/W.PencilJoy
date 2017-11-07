Feature: Change value for fields in addresses blocks on checkout page
	In order to change billing and shipping addresses data
	As a customer
	The user wants to be able to change billing and shipping addresses data on the checkout page

@positive @editValue @shipping
Scenario: The user changes value for fields in the block "Shipping Address"
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with data 
    When The user edits the field "Last name" in the block "Shipping address"
    Then The field "Last name" should be edited

@positive @editValue @shipping
Scenario: The user changes value for fields in the block "Billing Address"
    Given The user is a customer
    And The user is on checkout page
	And The user clicks the checkbox "Billing to this address" in the block "Shipping address"
    And The user fills fields for shipping address with data 
    When The user edits the field "City" in the block "Billing address"
    Then The field "City" should be edited

