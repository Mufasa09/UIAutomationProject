Feature: Charles Schwab Bonds, CDs & Fixed Income  Navigation

Basic scenarios for navigating Bonds, CDs & Fixed Income 

Background:
	Given I navigate to Bonds, CDs & Fixed Income from Accounts & Products

Scenario: Verify you can access the Schwab Overview page
	Given I navigate to the secondary link Fixed Income Overview
	When I verify the title of the site is Fixed Income Investments | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income

Scenario: Verify you can access the Bond Funds, Bond ETFs, and Preferred Securities page
	Given I navigate to the secondary link Fixed Income Products
		| Key   | Value                                           |
		| Item1 | Bond Funds, Bond ETFs, and Preferred Securities |
	When I verify the title of the site is Bond Funds and Bond ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/bond-funds-etfs

Scenario: Verify you can access the Certificates of Deposit page
	Given I navigate to the secondary link Fixed Income Products
		| Key   | Value                   |
		| Item1 | Certificates of Deposit |
	When I verify the title of the site is Certificate of Deposit | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/certificates-deposit

Scenario: Verify you can access the Individual Bonds page
	Given I navigate to the secondary link Fixed Income Products
		| Key   | Value            |
		| Item1 | Individual Bonds |
	When I verify the title of the site is Bonds: Buying & Investing in Bonds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/individual-bonds

Scenario: Verify you can access the Selecting Fixed Income page
	Given I navigate to the secondary link Selecting Fixed Income
	When I verify the title of the site is Selecting Investments - Fixed Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/selecting

Scenario: Verify you can access the Pricing page
	Given I navigate to the secondary link Pricing
	When I verify the title of the site is Fixed Income Pricing - Fixed Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/pricing


