Feature: Actions with books in the shopping bag
	In order to add, remove and edit books in the bag
	As a customer
	The user wants to be able to remove, add and edit books in the bag

@addbook
Scenario: The user adds an item to the bag
    Given The user is a customer
    And The user is on the bag page
    When The user clicks the button "Shop more books" 
    Then The user is redirected on the create book page for adding a new book

@addbook @newcustomer
 Scenario: The user adds an item to the bag as a new customer  
    Given The user is a new customer
    And The user is on the bag page
    When The user clicks the button "Shop more books" 
    Then The user is redirected on the create book page for adding a new book

@addbook @returningcustomer
 Scenario: The user adds an item to the bag as a returning customer  
    Given The user is a returning customer
    And The user is on the bag page
    When The user clicks the button "Shop more books" 
    Then The user is redirected on the create book page for adding a new book

@removebook
Scenario: The user removes an item from the bag
    Given The user is a customer
    And The user is on the bag page
	And The basket contains any items
    When The user clicks the button "X" at the book with number "2"
    And The user clicks button "Ok" on the popup notification for removing
    Then The basket does not contain the item with number "2"

@removebook @popup
Scenario: Popup notification for removing a book is shown
    Given The user is a customer
    And The user is on the bag page
	And The basket contains any items
    When The user clicks the button "X" at the book with number "2"
    Then  The popup notification for removing is shown

@priceorder
Scenario: Checking price for order after removing a book
    Given The user is a customer
    And The user is on the bag page
    And The user clicks the button "X" at the book
    When The user clicks thr button "Ok" on the popup notification for removing
    Then The price for the order should be subtracted price for removing book.
 
@removebook @emptybag
Scenario: The user removes all books from the order
    Given The user is a customer
    And The user is on the bag page
    When The user clicks the button "X" at all books in the order
    And The user clicks the buttons "Ok" on popup notification
    Then The user gets empty cart with the button "Continue shopping"

@emptybasket
Scenario: A new basket no contents
    Given The user is on the bag page
    When The user hasn`t add any product to bag
    Then The basket has no contents

@redirect @emptybasket
Scenario: The user should be redirected on the create book page after removing all books
    Given The user is a customer
    And The user is on the bag page
    And The user clicks the button "X" into all books in the order
    And The user clicks the button "Ok" into popups notification
	And The user gets empty cart with the button "Continue shopping"
    When The user clicks the button "Continue shopping"
	Then The user is redirected to create book page

@editbook @redirect
 Scenario: The user is redirected to the edit page from the bag 
    Given The user is a customer
    And The user is on the bag page
    When The user clicks the link "Edit" for a book 
    Then The user is redirected on the edit book page