Feature: Remove value from addresses fields
	In order to remove value in billing and shipping addresses fields
	As a customer
	The user wants to be able to remove values from fields in billing and shipping addresses

@positive @removeValue @shipping
Scenario: The user removes value for the field "Last name" in the block "Shipping Address"
    Given The user is a customer
    And The user is on checkout page
    And The user fills fields for shipping address with data 
    When The user removes  values for the field "Last name" in the block "Shipping address"
    Then The field "Last name" should be empty

@positive @removeValue @shipping
Scenario: The user removes value for the field "City" in the block "Billing Address"
    Given The user is a customer
    And The user is on checkout page
	And The user clicks the checkbox "Billing to this address" in the block "Shipping address"
    And The user fills fields for billing address with data 
    When The user removes the field "City" in the block "Billing address"
    Then The field "City" should be empty

