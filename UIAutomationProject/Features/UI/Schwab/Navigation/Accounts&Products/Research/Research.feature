Feature: Charles Schwab Research Navigation

Basic scenarios for navigating Research

Background:
	Given I navigate to Research from Accounts & Products

Scenario: Verify you can access the Investment Research page
	Given I navigate to the secondary link Investment Research
	When I verify the title of the site is Investment Research | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/investment-research

Scenario: Verify you can access the Research Tools page
	Given I navigate to the secondary link Research Tools
	When I verify the title of the site is Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/research/markets/us-markets

Scenario: Verify you can access the STAX Overview page
	Given I navigate to the secondary link Schwab Trading Activity Index
		| Key   | Value         |
		| Item1 | STAX Overview |
	When I verify the title of the site is Schwab Trading Activity Index™ (STAX) | Charles Schwab
		| Key         | Value |
		| TitleEnding | TM    |
	Then I verify the url of the site is https://www.schwab.com/investment-research/stax

Scenario: Verify you can access the View the STAX page
	Given I navigate to the secondary link Schwab Trading Activity Index
		| Key   | Value         |
		| Item1 | View the STAX |
	When I verify the title of the site is View the Schwab Trading Activity Index™ | Charles Schwab
		| Key         | Value |
		| TitleEnding | TM    |
	Then I verify the url of the site is https://www.schwab.com/investment-research/stax/view-schwab-trading-activity-index

