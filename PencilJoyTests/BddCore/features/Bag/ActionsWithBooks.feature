﻿Feature: Actions with books in the shopping bag
	In order to add, remove and edit books in the bag
	As a customer
	The user wants to be able to remove, add and edit books in the bag

@positive @redirectToCheckoutPage
Scenario: The user is redirected to the checkout page from the bag page
	Given The user is a customer
	And The user is on the bag page
	When The user clicks to the button Next
	Then The user is redirected to the checkout page.

@positive @addbook
Scenario: The user adds an item to the bag
    Given The user is a customer
    And The user is on the bag page
    When The user clicks the button Shop more books 
    Then The user is redirected on the create book page for adding a new book

@positive @addbook @newcustomer
 Scenario: The user adds an item to the bag as a new customer  
    Given The user is a new customer
    And The user is on the bag page
    When The user clicks the button Shop more books 
    Then The user is redirected on the create book page for adding a new book

@positive @addbook @returningcustomer
 Scenario: The user adds an item to the bag as a returning customer  
    Given The user is a returning customer
    And The user is on the bag page
    When The user clicks the button Shop more books
    Then The user is redirected on the create book page for adding a new book

@positive @removebook
Scenario Outline: The user removes an item from the bag
    Given The user is a customer
    And The user is on the bag page
	And The basket contains any items
    When The user clicks the button X at the book with number <BookNumber>
    And The user clicks button Ok on the popup notification for removing
    Then The basket does not contain the removing item
Examples:
| BookNumber |
| 1          |
| 3          |
| 2          |

@positive @removebook @popup
Scenario Outline: Popup notification for removing a book is shown
    Given The user is a customer
    And The user is on the bag page
	And The basket contains any items
    When The user clicks the button X at the book with number <BookNumber>
    Then  The popup notification for removing is shown
Examples:
| BookNumber |
| 1          |
| 3          |
| 2          |

@removebook @emptybag
Scenario: The user removes all books from the order
    Given The user is a customer
    And The user is on the bag page
    When The user clicks button Ok on the popup notification for removing
    Then The user gets empty cart with the button Continue shopping

@negative @emptybasket
Scenario: A new basket no contents
    Given The user is on the bag page
    When The user hasn`t add any product in bag
    Then The basket has no contents

@positive @redirect @emptybasket
Scenario: The user should be redirected on the create book page after removing all books
    Given The user is a customer
    And The user is on the bag page
    And The user removes all books in the order
	And The user gets empty cart with the button Continue shopping
    When The user clicks the button Continue shopping
	Then The user is redirected to create book page

@positive  @editbook @redirect
 Scenario Outline: The user is redirected to the edit page from the bag 
    Given The user is a customer
    And The user is on the bag page
    When The user clicks the link Edit for a book with number <Number>
    Then The user is redirected on the edit book page
Examples: 
| Number |
| 1      |
| 2      |
| 3      |

@positive @redirectToEditPage
Scenario: The user is redirected to the edit page from the bag page
	Given The user is a customer
	And The user is on the bag page
	When The user clicks to the button Edit book
	Then The user is redirected to edit page.