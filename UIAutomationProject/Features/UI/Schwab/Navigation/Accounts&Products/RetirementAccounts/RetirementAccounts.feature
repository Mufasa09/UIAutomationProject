Feature: Charles Schwab Retirement Accounts Navigation

Basic scenarios for navigating Retirement Accounts

Background:
	Given I navigate to Retirement Accounts (IRAs) from Accounts & Products

Scenario: Verify you can access the Retirement Accounts (IRAs) page
	Given I navigate to the secondary link Retirement Accounts (IRAs)
	When I verify the title of the site is What is an IRA? | Open an Individual Retirement Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira

Scenario: Verify you can access the What is a Traditional IRA? page
	Given I navigate to the secondary link Traditional IRA
		| Key   | Value    |
		| Item1 | What is a Traditional IRA? |
	When I verify the title of the site is What is a Traditional IRA? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/traditional-ira

Scenario: Verify you can access the Withdrawal Rules page from Traditional IRA
	Given I navigate to the secondary link Traditional IRA
		| Key   | Value               |
		| Item1 | Traditional IRA Withdrawal Rules |
	When I verify the title of the site is Traditional IRA Withdrawal Rules | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/traditional-ira/withdrawal-rules

 Scenario: Verify you can access the Contribution Limits page
	Given I navigate to the secondary link Traditional IRA
		| Key   | Value              |
		| Item1 | Traditional IRA Contribution Limits |
	When I verify the title of the site is Traditional IRA Contribution Limits for 2024 - 2025 | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/traditional-ira/contribution-limits

Scenario: Verify you can access the What is a Roth IRA? page
	Given I navigate to the secondary link Roth IRA
		| Key   | Value           |
		| Item1 | What is a Roth IRA? |
	When I verify the title of the site is Roth IRA: What is a Roth IRA? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/roth-ira

Scenario: Verify you can access the Roth vs Traditional page
	Given I navigate to the secondary link Roth IRA
		| Key   | Value      |
		| Item1 | Roth vs Traditional |
	When I verify the title of the site is Roth IRA vs. Traditional IRA: Differences and Rules | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/roth-vs-traditional-ira

Scenario: Verify you can access the Withdrawal Rules page from Roth IRA
	Given I navigate to the secondary link Roth IRA
		| Key   | Value                            |
		| Item1 | Roth IRA Withdrawal Rules |
	When I verify the title of the site is Roth IRA Withdrawal Rules | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/roth-ira/withdrawal-rules

	Scenario: Verify you can access the Contribution Limits page from Roth IRA
	Given I navigate to the secondary link Roth IRA
		| Key   | Value                            |
		| Item1 | Roth IRA Contribution Limits |
	When I verify the title of the site is Roth IRA Contribution Limits for 2024-2025 | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/roth-ira/contribution-limits

Scenario: Verify you can access the Rollover IRA page
	Given I navigate to the secondary link Rollover IRA
	When I verify the title of the site is What is a Rollover IRA? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/rollover-ira

Scenario: Verify you can access the Other IRAs page
	Given I navigate to the secondary link Other IRAs
	When I verify the title of the site is What are Inherited and Custodial IRAs? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/inherited-and-custodial-ira

Scenario: Verify you can access the Schwab IRA Calculators page
	Given I navigate to the secondary link Schwab IRA Calculators
	When I verify the title of the site is IRA Calculators | Open an IRA | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira/ira-calculators

