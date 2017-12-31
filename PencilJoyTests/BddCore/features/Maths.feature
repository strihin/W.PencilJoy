Feature: Equal price and discount value on different steps of order
	In order to compare value on different steps of order
	As a customer
	The user wants to be able to edit currency for order

@comparePriceForABook @previewPage @bagPage
Scenario: The user compares price and currency for a book on the preview page and on the bag page 
	Given The user is a customer
	And The user is on the preview page
	And The user gets price and currency for a book from the button  Order on the preview page
	And The user clicks the button  Order
	And The user clicks the button Next on the message page
	When The user gets price and currency  for the first book on the bag page
	Then The price and currency for a book on the preview page and on the bag page should be equal 

@comparePriceForABook @bagPage @checkoutPage
Scenario: The user compares price and currency for a book on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user gets price and currency for the first book on the bag page
	And The user clicks the button N+ext
	When The user gets  price and currency for the first book on the checkout page
	Then The price and currency for a book on the bag page and  on the checkout page should be equal 

@compareTotalPrice @bagPage @checkoutPage
Scenario: The user compares totalprice and currency for order on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user gets price and currency for the totalprice on the bag page
	And The user clicks the button Next
	When The user gets  price and currency for the totalprice on the checkout page
	Then The price and currency for the totalprice on the bag page and on the checkout page should be equal 

@compareTotalPriceWithDiscount @bagPage @checkoutPage
Scenario: The user compares totalprice and currency for order with discount code on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user enters correct discount code
	And The user gets price and currency for the totalprice on the bag page
	And The user clicks the button Next
	When The user gets  price and currency for the totalprice on the checkout page
	Then The price and currency for the totalprice on the bag page and on the checkout page should be equal 

@compareDiscountPercent @bagPage @checkoutPage
Scenario Outline: The user compares discount percent and name for order on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user enters correct discount code
	And The user gets discount percent and name for order on the bag page as <DiscountPercent>  <DiscountPercent>
	And The user clicks the button Next
	When The user gets discount percent and name for order on the checkout page as <DiscountPercent>  <DiscountPercent>
	Then The discount percent and name for order should be equal on the bag page and on the checkout page 
Examples: 
| DiscountCode  | DiscountPercent	|
| kendra35		| 35				|
| vip25			| 25				|

@verifyPriceBookList @bagPage
Scenario: The user verifies price for booklist on the bag page
	Given The user is a customer
	And The user is on the bag page
	When The user adds few books in the bag
	Then The price for every book should be equal counted values

@comparePriceBookList @bagPage @checkoutPage
Scenario: The user compares price for booklist on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user adds few books in the bag
	And The user clicks the button Next
	When The user gets price for booklist on the checkout page
	Then The price for booklist should be equal on the bag page and on the checkout page 

@compareCurrency @bagPage @checkoutPage @totalPrice
Scenario: The user compares currency for totalprice on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user adds few books in the bag
	And The user gets currency from totalprice
	And The user clicks the button Next
	When The user gets currency for totalprice on the checkout page
	Then The currency for totalprice should be equal on the bag page and on the checkout page 

@comparePriceWithDifferentCurrency @bagPage 
Scenario Outline: The user compares price for the first book using different currency
	Given The user is a customer
	And The user is on the bag page
	And The user adds few books in the bag
	When The user changes currency for order as <Currency>
	And The user gets price for the first book
	Then The price for the first book with  should be equal as <CurrencyValue>
Examples: 
| Currency | CurrencyValue |  
| USD      | 29.99         |
| GBP      | 19.99         |
| EUR      | 26.99         |
| JPY      | 3000.00       |
| AUD      | 39.99         |
| CHF      | 29.99         |
| CAD      | 38.99         |
| SEK      | 249.99        |
| NZD      | 39.99         |
						   
@positive @priceorder
Scenario: Checking price for order after removing a book
    Given The user is a customer
    And The user is on the bag page
    When The user clicks button Ok on the popup notification for removing
    Then The price for the order should be subtracted price for removing book.

@positive @generaldiscount
Scenario: Compare price books on bag page and checkout page
	Given The user is a customer
    And The user saves price book on the bag page
    When The user is on the checkout page
    Then The user compares price books on the bag page and the checkout page, they should be equal