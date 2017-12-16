Feature: Verify discount for next book
	In order to buy next book
	As a customer
	The user wants to be able to buy book with general discount for next book

@positive @generaldiscount 
Scenario Outline: The user buys a book without general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 1 book in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |

@positive @generaldiscount
Scenario Outline: The user buys 2 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 2 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |

@positive @generaldiscount
Scenario Outline: The user buys 3 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 3 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |
| 3          | 15      |

@positive @generaldiscount
Scenario Outline: The user buys 4 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 4 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |
| 3          | 15      |
| 4          | 20      |

@positive @generaldiscount
Scenario Outline: The user buys 5 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 5 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples: 
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |
| 3          | 15      |
| 4          | 20      |
| 5          | 25      |

@positive @generaldiscount
Scenario Outline: The user buys 6 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 6 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |
| 3          | 15      |
| 4          | 20      |
| 5          | 25      |
| 6          | 25      |

@positive @generaldiscount
Scenario Outline: The user buys 12 books with general discount
    Given The user is a customer
    And The user is on the bag page
    When The user has 12 books in the bag 
    Then The user has correct discount percent for each book as <NumberBook>, <Percent>
Examples:
| NumberBook | Percent |
| 1          | 0       |
| 2          | 10      |
| 3          | 15      |
| 4          | 20      |
| 5          | 25      |
| 6          | 25      |
| 7          | 25      |
| 8          | 25      |
| 9          | 25      |
| 10         | 25      |
| 11         | 25      |
| 12         | 25      |

@positive @generaldiscount
Scenario: Compare price books on bag page and checkout page
	Given The user is a customer
    And The user saves price book on the bag page
    When The user is on the checkout page
    Then The user compares price books on the bag page and the checkout page, they should be equal