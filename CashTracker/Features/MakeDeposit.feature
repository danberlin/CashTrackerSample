Feature: MakeDeposit
	In order to track cash on hand
	As a store employee
	I want to make a cash deposit

Scenario: Make a deposit
	Given I have $0.00 in cash
	When I deposit $100.00 into the tracker
	Then I should have $100.00 in cash

	Given I have $100.00 in cash
	When I deposit $10.01 into the tracker
	Then I should have $110.01 in cash

Scenario: Minimum deposit
	When I deposit $0.01 into the tracker
	Then I should get an error that says "The minimum deposit is $1.00"
