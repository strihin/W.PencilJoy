Feature: Edit currency and check price for book
	In order to edit currency for order
	As a customer
	The user wants to be able to edit currency for order

Scenario: The user edit currency on preview page
    Given The user is a customer
    And The user is on preview page     
    When The user clicks the dropdown with currency and chooses currency item
    Then The currency is changed in the button "Order for" as a currency item

Scenario: The user edit currency on preview page
    Given The user is a customer
    And The user is on preview page     
    When The user clicks the dropdown with currency and chooses currency item
    When The current currency is edited
    Then The price for a book in the button "Order for..." is edited too.

Scenario: The user edit currency on message page
    Given The user is a customer
    And The user is on message page     
    When The user clicks the dropdown with currency and chooses currency item
    Then The currency is changed as a currency item

Scenario: The user edit currency on bag page
    Given The user is a customer
    And The user is on bag page     
    When The user clicks the dropdown with currency and chooses currency item
    Then The currency and price for books are changed as a currency item