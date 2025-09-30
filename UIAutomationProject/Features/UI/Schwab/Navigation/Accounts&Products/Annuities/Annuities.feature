Feature: Charles Schwab Annuities Navigation

Basic scenarios for navigating Annuities

Background:
	Given I navigate to Annuities from Accounts & Products

Scenario: Verify you can access the Schwab Order Execution Advantage page
	Given I navigate to the secondary link Annuities Overview
	When I verify the title of the site is Annuities: Saving for Retirement Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality

Scenario: Verify you can access the Variable Annuities Overview page
	Given I navigate to the secondary link Variable Annuities
		| Key   | Value                       |
		| Item1 | Variable Annuities Overview |
	When I verify the title of the site is Variable Annuities | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/variable-annuities

Scenario: Verify you can access the Schwab Genesis Variable Annuity™ page
	Given I navigate to the secondary link Variable Annuities
		| Key   | Value                           |
		| Item1 | Schwab Genesis Variable Annuity |
	When I verify the title of the site is Schwab Genesis Variable Annuity | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/variable-annuities/schwab-genesis-variable-annuity

Scenario: Verify you can access the Pacific Odyssey® Advantage Variable Annuity page
	Given I navigate to the secondary link Variable Annuities
		| Key   | Value           |
		| Item1 | Pacific Odyssey |
	When I verify the title of the site is Pacific Odyssey® Advantage Variable Annuity | Charles Schwab
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/annuities/variable-annuities/odyssey-advantage-variable-annuity

Scenario: Verify you can access the Fixed Deferred Annuities page
	Given I navigate to the secondary link Fixed Deferred Annuities
	When I verify the title of the site is Fixed Deferred Annuities: Retirement Investment | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/fixed-annuities

Scenario: Verify you can access the Fixed Indexed Annuities page
	Given I navigate to the secondary link Indexed Annuities
		| Key   | Value                   |
		| Item1 | Fixed Indexed Annuities |
	When I verify the title of the site is Fixed Indexed Annuities | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/fixed-indexed-annuities

Scenario: Verify you can access the Registered Index-Linked Annuities page
	Given I navigate to the secondary link Indexed Annuities
		| Key   | Value                             |
		| Item1 | Registered Index-Linked Annuities |
	When I verify the title of the site is Registered Index-Linked Annuities | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/indexed-annuities/registered-index-linked-annuity

Scenario: Verify you can access the Single Premium Immediate Annuities page
	Given I navigate to the secondary link Income Annuities
		| Key   | Value                              |
		| Item1 | Single Premium Immediate Annuities |
	When I verify the title of the site is Income Annuities–Retirement Income | Charles Schwab
		| Key         | Value |
		| TitleEnding | Dash  |
	Then I verify the url of the site is https://www.schwab.com/annuities/income-annuity

Scenario: Verify you can access the Deferred Income Annuities page
	Given I navigate to the secondary link Income Annuities
		| Key   | Value                     |
		| Item1 | Deferred Income Annuities |
	When I verify the title of the site is Deferred Income Annuities Overview | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/deferred-income-annuities


Scenario: Verify you can access the Income Annuity Estimator page
	Given I navigate to the secondary link Income Annuity Estimator
	When I verify the title of the site is Income Annuity Estimator: Calculate Your Payout | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/fixed-income-annuity-calculator


