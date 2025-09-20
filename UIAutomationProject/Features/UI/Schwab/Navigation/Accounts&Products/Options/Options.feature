Feature: Charles Schwab Options Navigation

Basic scenarios for navigating Options

Background:
	Given I navigate to Investment Options from Accounts & Products

Scenario: Verify you can access the Options Overview page
	Given I navigate to the secondary link Options Overview
	When I verify the title of the site is Options Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options

Scenario: Verify you can access the Why Trade Options at Schwab page
	Given I navigate to the secondary link Why Trade Options at Schwab
	When I verify the title of the site is Options Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-trading

	Scenario: Verify you can access the Get Started page
	Given I navigate to the secondary link Get Started
	When I verify the title of the site is Trade Options | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-trading

Scenario: Verify you can access the Intro to Options page
	Given I navigate to the secondary link Introduction to Options
		| Key   | Value              |
		| Item1 | Intro to Options |
	When I verify the title of the site is Introduction to Options | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/what-is-trading-options

Scenario: Verify you can access the Options Contracts page
	Given I navigate to the secondary link Introduction to Options
		| Key   | Value                               |
		| Item1 | Options Contracts |
	When I verify the title of the site is Options Contracts | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-contracts

Scenario: Verify you can access the Options Greeks page
	Given I navigate to the secondary link Introduction to Options
		| Key   | Value                  |
		| Item1 | Options Greeks |
	When I verify the title of the site is Options Greeks | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-greeks

Scenario: Verify you can access the Options Strategies page
	Given I navigate to the secondary link Introduction to Options
		| Key   | Value                 |
		| Item1 | Options Strategies |
	When I verify the title of the site is Options Trading Strategies | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-trading-strategies

Scenario: Verify you can access the How to Trade Options page
	Given I navigate to the secondary link Introduction to Options
		| Key   | Value                 |
		| Item1 | How to Trade Options |
	When I verify the title of the site is How to Trade Options | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/how-to-trade-options
