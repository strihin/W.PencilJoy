Feature: Verify Reminder
	In order to fill remind data on the preview page
	As a customer
	The user wants to be able to fill data for reminder with the letter

@previewPage @openingPopup  @positive
Scenario: The user opens the popup "Remind me later" on the preview page
	Given The user is a customer
	And The user is on the preview page
	When The user clicks the button "Remind me later"
	Then The popup "Remind me later" should be appear

@previewPage @closingPopupRemindMeLater  @positive
Scenario: The user closes the popup "Remind me later" on the preview page
	Given The user is a customer
	And The user is on the preview page
	And The popup "Remind me later" should be appear
	When The user clicks the button "X"
	Then The popup "Remind me later" should be disappear

@previewPage @closingPopupYourReminderIsSet  @positive
Scenario: The user closes the popup "Your reminder is set" on the preview page
	Given The user is a customer
	And The user is on the preview page
	And The popup "Your reminder is set" should be appear
	When The user clicks the button "X"
	Then The popup "Your reminder is set" should be disappear

@previewPage @55days @30days @newsAndSpecialDeals @positive
Scenario: The user fills form for the letter reminder with all activated checkboxes
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	And The user fills the field "Your email" with correct data
	And The user clicks the checkbox "55 days before December 25th"
	And The user clicks the checkbox "30 days before"
	And The user clicks the checkbox "Subscribe to news and special deals"
	When The user clicks the button "Set reminder"
	Then The popup "Remind me later" should be disappear
	And The popup "Your reminder is set" should be appear

@55days @previewPage  @positive
Scenario: The user fills form for the letter reminder before 55 days
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	When The user fills the field "Your email" with correct data
	And The user clicks the checkbox "55 days before December 25th"
	And The user clicks the button "Set reminder"
	Then The popup "Remind me later" should be disappear
	And The popup "Your reminder is set" should be appear

@30days @previewPage  @positive
Scenario: The user fills form for the letter reminder before 30 days
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	When The user fills the field "Your email" with correct data
	And The user clicks the checkbox "30 days before"
	And The user fill date in the datepicker
	And The user clicks the button "Set reminder"
	Then The popup "Remind me later" should be disappear
	And The popup "Your reminder is set" should be appear

@verifyEmails @positive
Scenario: The user compares email in the popups
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	And The user fills the field "Your email" with correct data
	And The user clicks the checkbox "55 days before December 25th"
	When The user clicks the button "Set reminder"
	Then The string in the popup "Your reminder is set" should exist email as was filling before

@55days @previewPage  @negative
Scenario: The user fills form for the letter without email
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	When The user clicks the checkbox "55 days before December 25th"
	And The user clicks the button "Set reminder"
	Then The fiels "Your email" should get red border 
	And The popup "Your reminder is set" should not be appear

@30days @previewPage  @negative
Scenario: The user fills form for the letter reminder before 30 days without selected date
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	And The user fills the field "Your email" with correct data
	And The user clicks the checkbox "30 days before"
	When The user clicks the button "Set reminder"
	Then The textbox for datepicker should get red border
	And The popup "Your reminder is set" should not be appear

 @previewPage  @negative
 Scenario: The user doesn`t checked any checkbox in the form for the letter reminder
	Given The user is a customer
	And The user is on the preview page 
	And The popup "Remind me later" should be appear
	And The user fills the field "Your email" with correct data
	When The user clicks the button "Set reminder"
	Then The block with the red text "Please select any option below" should be appear 
	And The popup "Your reminder is set" should not be appear