Feature: Add User Account
	In order to keep separate cash accounts for users
	As a store owner
	I want to be able to add a new user account

Scenario: Add a new account
	Given there are no user accounts in the tracker
	When I add the user account "New User"
	Then I can set the active user to "New User"

Scenario: Separate balances
	Given there is a user account "User1"
	And user account "User1" has $0
	And there is a user account "User2"
	And user account "User2" has $0
	When I set the active user to "User1"
	And I deposit $100.00 into the tracker
	And I set the active user to "User2"
	Then I should have $0 in cash
	When I set the active user to "User1"
	Then I should have $100.00 in cash