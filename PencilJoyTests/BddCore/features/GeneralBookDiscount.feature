Feature: Verify discount for next book
	In order to buy next book
	As a customer
	The user wants to be able to buy book with general discount for next book

Scenario: The user buys a book without general discount
    Given The user is a customer
    And The user is on bag page
    When The user has a book in the bag 
    Then The user hasn`t any general discount for book

Scenario: The user buys 2 books with general discount
    Given The user is a customer
    And The user is on bag page
    When The user has 2 books in the bag 
    Then The user has 19 percent discount for the 2nd book

Scenario: The user buys 5 books with general discount
    Given The user is a customer
    And The user is on bag page
    When The user has 5 books in the bag 
    Then The user has 10 percent discount for the 2nd book
    And 15 percent discount for the 3th book
    And 20 percent discount for the 4th book
    And 25 percent discount for the 5th book

Scenario: The user buys 6 books with general discount
    Given The user is a customer
    And The user is on bag page
    When The user has 6 books in bag 
    Then The user has 10 percent discount for the 2nd book
    And 15 percent discount for the 3th book
    And 20 percent discount for the 4th book
    And 25 percent discount for the 5th book
	And 25 percent discount for the 6th book

Scenario: Compare price books on bag page and checkout page
	Given The user is a customer
    And The user saves price book on bag page
    And The user is on checkout page
    When The user compares price books on bag page and checkout page 
    Then It should be equals