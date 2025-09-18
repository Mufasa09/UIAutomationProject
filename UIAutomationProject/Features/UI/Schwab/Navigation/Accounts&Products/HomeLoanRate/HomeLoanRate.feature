Feature: Charles Schwab Home Loans & Rates Navigation

Basic scenarios for navigating Home Loans & Rates

Background:
	Given I navigate to Home Loans & Rates from Accounts & Products

Scenario: Verify you can access the Overview page
	Given I navigate to the secondary link Schwab Order Execution Advantage
	When I verify the title of the site is Mortgage – Apply for mortgages at low interest rates | Schwab Bank
		| Key         | Value |
		| TitleEnding | Dash  |
	Then I verify the url of the site is https://www.schwab.com/mortgages

Scenario: Verify you can access the Products page
	Given I navigate to the secondary link Products
	When I verify the title of the site is Products | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mortgages/mortgage-refinance

Scenario: Verify you can access the Rates page
	Given I navigate to the secondary link Rates
	When I verify the title of the site is Mortgage Rates | Schwab Bank | Charles Schwab
		| Key         | Value |
		| TitleEnding | Dash  |
	Then I verify the url of the site is https://www.schwab.com/mortgages/mortgage-rates

Scenario: Verify you can access the Start Your Loan page
	Given I navigate to the secondary link Start Your Loan
	When I verify the title of the site is Apply for a Mortgage | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mortgages/apply

