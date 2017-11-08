Feature: Verify discount for next book
	In order to buy next book
	As a customer
	The user wants to be able to buy book with general discount for next book

@positive @generaldiscount 
Scenario: The user buys a book without general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has a book in the bag 
    Then The user hasn`t any general discount for book

@positive @generaldiscount
Scenario: The user buys 2 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 2 books in the bag 
    Then The user has 10 percent discount for the 2nd book

@positive @generaldiscount
Scenario: The user buys 3 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 3 books in the bag 
    Then The user has 15 percent discount for the 3nd book

@positive @generaldiscount
Scenario: The user buys 4 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 2 books in the bag 
    Then The user has 20 percent discount for the 4nd book

@positive @generaldiscount
Scenario: The user buys 5 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 5 books in the bag 
    Then The user has 10 percent discount for the 2nd book
    And 15 percent discount for the 3th book
    And 20 percent discount for the 4th book
    And 25 percent discount for the 5th book

@positive @generaldiscount
Scenario: The user buys 6 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 6 books in bag 
    Then The user has 10 percent discount for the 2nd book
    And 15 percent discount for the 3th book
    And 20 percent discount for the 4th book
    And 25 percent discount for the 5th book
	And 25 percent discount for the 6th book

@positive @generaldiscount
Scenario: The user buys 12 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 12 books in bag 
    Then The user has 10 percent discount for the 2nd book
    And 15 percent discount for the 3th book
    And 20 percent discount for the 4th book
    And 25 percent discount for the 5th book
	And 25 percent discount for the 6th book
	And 25 percent discount for the 7th book
	And 25 percent discount for the 8th book
	And 25 percent discount for the 9th book
	And 25 percent discount for the 10th book
	And 25 percent discount for the 11th book
	And 25 percent discount for the 12th book

@positive @generaldiscount
Scenario: Compare price books on bag page and checkout page
	Given The user is a customer
    And The user saves price book on the bag page
    And The user is on the checkout page
    When The user compares price books on bag page and checkout page 
    Then The should be equals