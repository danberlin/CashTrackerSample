Feature: MakeWithdrawal
	In order to use cash on hand
	As a store employee
	I want to make a cash withdrawal

Scenario: Make a withdrawal
	Given I have $10.01 in cash 
	When I withdraw $9.00 from the tracker
	Then I should have $1.01 in cash

Scenario: Insufficient Funds
	Given I have $10.00 in cash 
	When I withdraw $30.00 from the tracker
	Then I should get an error that says "Insufficient funds available"

Scenario: Minimum Withdrawal
	When I withdraw $0.01 from the tracker
	Then I should get an error that says "The minimum withdrawal is $1.00"