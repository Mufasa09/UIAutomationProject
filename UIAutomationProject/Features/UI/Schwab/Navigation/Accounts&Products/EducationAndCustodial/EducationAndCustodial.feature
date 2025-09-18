Feature: Charles Schwab Education and Custodial Navigation

Basic scenarios for navigating Education and Custodial

Background:
	Given I navigate to Education and Custodial from Accounts & Products

Scenario: Verify you can access the Trading Overview page
	Given I navigate to the secondary link Education and Custodial
	When I verify the title of the site is College Savings Account | Education & Custodial | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/college-savings-accounts

Scenario: Verify you can access the College Savings Calculator page
	Given I navigate to the secondary link College Savings Calculator
	When I verify the title of the site is College Savings Calculator | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/saving-for-college/college-savings-calculator

Scenario: Verify you can access the 529 Savings Plan Overview page
	Given I navigate to the secondary link 529 Savings Plan
		| Key   | Value               |
		| Item1 | Overview |
	When I verify the title of the site is Schwab 529 Savings Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/529-plan

Scenario: Verify you can access the thinkorswim Mobile page
	Given I navigate to the secondary link 529 Savings Plan
		| Key   | Value              |
		| Item1 | 529 State Tax Calculator |
	When I verify the title of the site is 529 State Tax Calculator | Schwab 529 Savings Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/529-plan/529-state-tax-calculator

Scenario: Verify you can access the thinkorswim Web page
	Given I navigate to the secondary link 529 Savings Plan
		| Key   | Value           |
		| Item1 | Learning Quest 529 Plan |
	When I verify the title of the site is Learning Quest 529 Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/529-plan/learning-quest

Scenario: Verify you can access the Education Savings Account page
	Given I navigate to the secondary link Education Savings Account
	When I verify the title of the site is Education Savings Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/educational-savings-account

Scenario: Verify you can access the Custodial Account Overview page
	Given I navigate to the secondary link Custodial Account
		| Key   | Value      |
		| Item1 | Overview |
	When I verify the title of the site is Schwab One® Custodial Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/custodial-account

Scenario: Verify you can access the thinkorswim Download Instructions page
	Given I navigate to the secondary link Custodial Account
		| Key   | Value                            |
		| Item1 | Custodial Transfer |
	When I verify the title of the site is Custodial Account Transfer | Schwab One® Custodial Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/custodial-account/custodial-transfer




