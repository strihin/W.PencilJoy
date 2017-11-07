@checkout
Feature: Returning from addressing step to shop homepage
    In order to return to the Bag page after checkout started
    As a Customer
    I want to be able to go back to the Bag page from checkout page

    Background:
        Given the store operates on a single channel in "United States"
        And the store has a product "The Stick of Truth" priced at "$19.99"
        And the store ships everywhere for free
        And I am a logged in customer

    @ui
    Scenario: Returning to bag page from addressing step
        Given I have product "The Stick of Truth" in the cart
        And I am at the checkout addressing step
        When I go back to store
        Then I should be redirected to the homepage

	@checkout
Feature: Returning to the addressing step and changing address data
    In order to correct my address data
    As a Visitor
    I want to be able to return to the addressing step and change previously typed data

    Background:
        Given the store operates on a single channel in "United States"
        And the store has a product "Apollo 11 T-Shirt" priced at "$49.99"
        And the store ships everywhere for free

    @ui
    Scenario: Going back to addressing step with and changing email
        Given I have product "Apollo 11 T-Shirt" in the cart
        And I am at the checkout addressing step
        When I specify the email as "jon.snow@example.com"
        And I specify the shipping address as "Ankh Morpork", "Frost Alley", "90210", "United States" for "Jon Snow"
        And I complete the addressing step
        And I decide to change my address
        And I specify the email as "ned.stark@example.com"
        And I complete the addressing step
        Then I should be checking out as "ned.stark@example.com"