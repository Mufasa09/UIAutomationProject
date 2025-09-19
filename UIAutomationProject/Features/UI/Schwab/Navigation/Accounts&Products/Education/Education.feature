Feature: Charles Schwab Education Navigation

Basic scenarios for navigating Education

Background:
	Given I navigate to Education from Accounts & Products

Scenario: Verify you can access the Trading Overview page
	Given I navigate to the secondary link Trading Overview
	When I verify the title of the site is Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading

Scenario: Verify you can access the thinkorswim Overview page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value    |
		| Item1 | Overview |
	When I verify the title of the site is thinkorswim | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim

Scenario: Verify you can access the thinkorswim Desktop page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value               |
		| Item1 | thinkorswim Desktop |
	When I verify the title of the site is thinkorswim desktop | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/desktop

Scenario: Verify you can access the thinkorswim Mobile page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value              |
		| Item1 | thinkorswim Mobile |
	When I verify the title of the site is thinkorswim mobile | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/mobile-app

Scenario: Verify you can access the thinkorswim Web page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value           |
		| Item1 | thinkorswim Web |
	When I verify the title of the site is thinkorswim web | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/web

Scenario: Verify you can access the paperMoney page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value      |
		| Item1 | paperMoney |
	When I verify the title of the site is Paper Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/paper-trading

Scenario: Verify you can access the thinkorswim Download Instructions page
	Given I navigate to the secondary link thinkorswim Platforms
		| Key   | Value                            |
		| Item1 | thinkorswim Download Instructions |
	When I verify the title of the site is thinkorswim Download | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/download

Scenario: Verify you can access the Education page
	Given I navigate to the secondary link Education
	When I verify the title of the site is Learn to Trade | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/learn-to-trade

Scenario: Verify you can access the Support page
	Given I navigate to the secondary link Support
	When I verify the title of the site is Trading Support | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/support

