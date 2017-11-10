Feature: Equal price value on different steps of order
	In order to compare value on different steps of order
	As a customer
	The user wants to be able to edit currency for order

@comparePriceForABook @previewPage @bagPage
Scenario: The user compares price and currency for a book on the preview page and on the bag page 
	Given The user is a customer
	And The user is on the preview page
	And The user gets price and currency for a book from the button "Order for .." on the preview page
	And The user clicks the button "Order for .."
	And The user clicks the button "Next" on the message page
	When The user gets price and currency  for the first book on the bag page
	Then The price and currency for a book on the preview page and on the bag page should be equal 

@comparePriceForABook @bagPage @checkoutPage
Scenario: The user compares price and currency for a book on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user gets price and currency for the first book on the bag page
	And The user clicks the button "Next"
	When The user gets  price and currency for the first book on the checkout page
	Then The price and currency for a book on the bag page and  on the checkout page should be equal 

@compareTotalPrice @bagPage @checkoutPage
Scenario: The user compares totalprice and currency for order on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user gets price and currency for the totalprice on the bag page
	And The user clicks the button "Next"
	When The user gets  price and currency for the totalprice on the checkout page
	Then The price and currency for the totalprice on the bag page and on the checkout page should be equal 

@compareTotalPriceWithDiscount @bagPage @checkoutPage
Scenario: The user compares totalprice and currency for order with discount code on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user enters correct discount code
	And The user gets price and currency for the totalprice on the bag page
	And The user clicks the button "Next"
	When The user gets  price and currency for the totalprice on the checkout page
	Then The price and currency for the totalprice on the bag page and on the checkout page should be equal 

@compareDiscountPercent @bagPage @checkoutPage
Scenario: The user compares discount percent for order on the bag page and on the checkout page
	Given The user is a customer
	And The user is on the bag page
	And The user enters correct discount code
	And The user gets discount percent for order on the bag page
	And The user clicks the button "Next"
	When The user gets discount percent for order on the checkout page
	Then The discount percent for order should be equal on the bag page and on the checkout page 

@totalPrice @discount 
Scenario: Equal currency and price value on preview and bag page 
	Given The user is a customer
	And The user is on preview page
	And Get currency and price for a book from the button "Order for .." on preview page
	And The user clicks the button "Order for .."
	And The user clicks the button "Next" on the message page
	Then get price for the first book on the bag page
	And get currency on the bag page

	CompareListBook actual expected
	ComparePrices actual expected
	Verify price for a 1st book
Scenario: Equal discount code on bag and checkout page (перерасчет цен)
Scenario: Equal full price on bag and checkout page (вс
Scenario: Equal currency on bag and checkout page 
Scenario: Check discount code`s value with name
Scenario: Check price for 1st book with different currency

@positive @discountpercent
Scenario: Check discount percent for order
    Given The user is a customer
    And The user is on the bag page
    When The user fill field for discount code with correct data
	And The user clicks the button "Check"
    Then The user gets right discount percent for his order

11***************Remind me later***************
12*****************Profile page. Order list. Change password*************