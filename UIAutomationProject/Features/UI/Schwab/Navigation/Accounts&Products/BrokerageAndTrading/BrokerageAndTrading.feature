Feature: Charles Schwab Brokerage and Trading Navigation

Basic scenarios for navigating Brokerage and Trading

Background:
	Given I navigate to Brokerage and Trading from Accounts & Products

Scenario: Verify you can access the Brokerage And Trading Account page
	Given I navigate to the secondary link Brokerage And Trading Account
	When I verify the title of the site is Brokerage account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/brokerage

Scenario: Verify you can access the What is a Brokerage Account page
	Given I navigate to the secondary link What is a Brokerage Account 
	When I verify the title of the site is What is a Brokerage Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/brokerage/what-is-a-brokerage-account

Scenario: Verify you can access the Types of Brokerage Accounts page
	Given I navigate to the secondary link Types of Brokerage Accounts
	When I verify the title of the site is Types of Brokerage Accounts | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/brokerage/types-of-brokerage-accounts

