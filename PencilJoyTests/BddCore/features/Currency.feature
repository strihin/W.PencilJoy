Feature: Editing currency and check price for a book
	In order to edit currency for order
	As a customer
	The user wants to be able to edit currency for order

@previewPage
Scenario: The user edits currency for checking currency and price in the button on the preview page
    Given The user is a customer
    And The user is on preview page     
    When The user clicks the dropdown with currency and chooses currency item
    Then The currency is changed in the button "Order for" as a currency item
	And The price for a book in the button "Order for..." is edited.

@messagePage
Scenario: The user edits currency on the message page for checking currency on the bag page
    Given The user is a customer
    And The user is on the message page     
    When The user clicks the dropdown with currency and chooses currency item
	And The user clicks "Next" for redirecting to the bag page
    Then The currency in the field "Subtotal" on the bag page is should be equal selected currency item
	And The currency in the field "Grand Total" on the bag page is should be equal selected currency item 
	And The active currency in the dropdown with currencies on the bag page should be equal  selected currency item

@bagPage @dropdownFooter
Scenario: The user edits currency using dropdown in the footer on the bag page
    Given The user is a customer
    And The user is on the bag page     
    When The user clicks the dropdown with currencies in the footer and chooses currency item
    Then The currency in the field "Subtotal" on the bag page is  should be equal selected currency item
	And The currency in the field "Grand Total" on the bag page is  should be equal selected currency item 
	And The active currency in the dropdown with currencies on the bag page should be equal  selected currency item

@bagPage @dropdown
Scenario: The user edits currency using dropdown on the bag page
    Given The user is a customer
    And The user is on the bag page     
    When The user clicks the dropdown with currencies and chooses currency item
    Then The currency in the field "Subtotal" on the bag page should be equal selected currency item
	And The currency in the field "Grand Total" on the bag page should be equal selected currency item 
	And The active currency in the dropdown with currencies ib the footer should be equal selected currency item