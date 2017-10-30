Feature: Shopping Basket
	A simple shooping basket that we can add and remove items from
	As a customer
	The user wants to be able to remove and add book to the order

Scenario: A new basket no contents
    Given The user is on the checkout page
    When The user creates a new basket
    Then The basket has no contents


Scenario: Adding an item to the basket
    Given The user is a customer
    And The user is on bag page
    When The user clicks the button "Shop more books" 
    Then The user is redirected on create book page for adding a new book

Scenario: Removing an item from the basket
    Given The user is a customer
    And The user is on bag page
	And The basket contains any items
    When The user clicks the button "X" at the book
    And The user clicks button "Ok" on popup notification
    Then The basket does not contain the item
    
Scenario: Check price for order after removing a book
    Given The user is a customer
    And The user is on bag page
    And The user clicks the button "X" at the book
    When The user clicks thr button "Ok" on popup notification
    Then The price for the order should be subtracted price for removing book.
    
Scenario: Remove all books from thr order
    Given The user is a customer
    And The user is on bag page
    When The user clicks the button "X" at all books in the order
    And The user clicks the buttons "Ok" on popup notification
    Then The user gets empty cart with the button "Continue shopping"

Scenario: Redirect to create book page after removing all books
    Given The user is a customer
    And The user is on bag page
    And The user clicks the button "X" into all books in the order
    And The user clicks the button "Ok" into popup notification
    When The user gets empty cart with the button "Continue shopping"
    Then The user redirected to create book page