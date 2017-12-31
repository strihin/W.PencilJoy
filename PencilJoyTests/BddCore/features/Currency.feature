Feature: Editing currency and check price for a book
	In order to edit currency for order
	As a customer
	The user wants to be able to edit currency for order

@positive @previewPage
Scenario Outline: The user edits currency for checking currency and price in the button on the preview page
    Given The user is a customer
    And The user is on the preview page     
    When The user clicks the dropdown with currency and chooses currency item as <Currency>
    Then The currency is changed in the button Order for as <Currency>
	And The price for a book in the button Order for is edited.
Examples: 
| Currency |
| USD      |
| GBP      |
| EUR      |
| JPY      |
| AUD      |
| CHF      |
| CAD      |
| SEK      |
| NZD      |

@positive @messagePage
Scenario Outline: The user edits currency on the message page for checking currency on the bag page
    Given The user is a customer
    And The user is on the message page     
    When The user clicks the dropdown with currency and chooses currency item as <Currency>
	And The user clicks th button Next for redirecting to the bag page
    Then The currency in the field "Subtotal" on the bag page is <Currency>
	And The currency in the field "Grand Total" on the bag page is <Currency>
	And The active currency in the dropdown with currencies on the bag page should be equal <Currency>
Examples: 
| Currency |
| USD      |
| GBP      |
| EUR      |
| JPY      |
| AUD      |
| CHF      |
| CAD      |
| SEK      |
| NZD      |

@positive @bagPage @dropdownFooter
Scenario Outline: The user edits currency using dropdown in the footer on the bag page
    Given The user is a customer
    And The user is on the bag page     
    When The user clicks the dropdown with currencies in the footer and chooses currency item as <Currency>
    Then The currency in the field "Subtotal" on the bag page is  should be equal <Currency>
	And The currency in the field "Grand Total" on the bag page is  should be equal <Currency>
	And The active currency in the dropdown with currencies on the bag page should be equal  <Currency>
Examples: 
| Currency |
| USD      |
| GBP      |
| EUR      |
| JPY      |
| AUD      |
| CHF      |
| CAD      |
| SEK      |
| NZD      |

@positive @bagPage @dropdown
Scenario Outline: The user edits currency using dropdown on the bag page
    Given The user is a customer
    And The user is on the bag page     
    When The user clicks the dropdown with currencies and chooses currency item as <Currency>
    Then The currency in the field "Subtotal" on the bag page should be equal <Currency>
	And The currency in the field "Grand Total" on the bag page should be equal <Currency>
	And The active currency in the dropdown with currencies in the footer should be equal <Currency>
	Examples: 
| Currency |
| USD      |
| GBP      |
| EUR      |
| JPY      |
| AUD      |
| CHF      |
| CAD      |
| SEK      |
| NZD      |
