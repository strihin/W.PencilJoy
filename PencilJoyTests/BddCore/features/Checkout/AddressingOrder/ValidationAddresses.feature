@checkout
Feature: Order addressing validation
    In order to avoid making mistakes when addressing an order
    As an Customer
    I want to be prevented from adding it without specifying required fields and checked incorrect data to fields

	@negative @validation  @shipping
	Scenario: The user removes value for fields in the block "Shipping Address"
		Given The user is a customer
		And The user is on checkout page
		And The user fills fields for shipping address with data 
		When The user edits the field "Last name" in the block "Shipping address"
		Then The field "Last name" should be empty
    
	@ui @negative @shipping
    Scenario: Shipping address without any filling fields
        Given The user is a customer
        And The user is on checkout page
        When The user does not specify any shipping address information
        And The user  tries to complete the addressing step
        Then The user should be notified that all fields in shipping details are required such as FIRST NAME, LAST NAME, STREET ADDRESS, CITY, STATE/REGION, POSTCODE / ZIP CODE, COUNTRY, PHONE
	
	@ui @negative @billing
    Scenario: Billing address without any filling fields
        Given The user is a customer
        And The user is on checkout page
		And The user clicks the checkbox "Bill to this address"
        When The user does not specify any billing address information
        And The user  tries to complete the addressing step
        Then The user should be notified that all fields in billing details are required such as FIRST NAME, LAST NAME, STREET ADDRESS, CITY, STATE/REGION, POSTCODE / ZIP CODE, COUNTRY, PHONE

	@ui @negative @shipping
    Scenario: Shipping address without the first name and the last name
        Given The user is a customer
        And The user is on checkout page
        When The user specifies  in shipping address all fields becides the first name and the last name 
        And The user  tries to complete the addressing step
        Then The user should be notified that the "first name" and the "last name" in shipping details are required
       
	@ui @negative  @billing
    Scenario: Billing address without the first name and the last name
        Given The user is a customer
        And The user is on checkout page
		And The user clicks the checkbox "Bill to this address"
		And The user clicks the checkbox "Ship to this address"
        When The user specifies  in billing address all fields becides the first name and the last name 
        And The user  tries to complete the addressing step
        Then The user should be notified that the "first name" and the "last name" in billing details are required       

    @ui @negative
    Scenario: Billing address without the city and the postcode / zip code and Shipping address without the Phone
        Given The user is a customer
        And The user is on checkout page
		And The user clicks the checkbox "Bill to this address"
        When The user specifies  in billing address all fields becides the city and the postcode / zip code
		And The user specifies  in shipping address all fields becides the Phone
        And The user  tries to complete the addressing step
        Then The user should be notified that the "the city" and "the postcode /zip code" in billing details are required
		And The user should be notified that the "the Phone" in shipping details isrequired

	@ui @negative @shipping
    Scenario: Shipping address with the Phone as string
        Given The user is a customer
        And The user is on checkout page
        When The user specifies  in shipping address all fields with correct data
		And The user specifies  in shipping address the field "Phone" with string as "three-two-one-one"
        And The user  tries to complete the addressing step
        Then The user should be notified that the "Phone" in shipping details should be numeric value, no string value

	@ui @negative @billing
    Scenario: Billing address with the Phone as string
        Given The user is a customer
        And The user is on checkout page
		And The user clicks the checkbox "Bill to this address"
        When The user specifies  in billing address all fields with correct data
		And The user specifies  in billing address the field "Phone" with string as "three-two-one-one"
        And The user  tries to complete the addressing step
        Then The user should be notified that the "Phone" in billing details should be numeric value, no string value