Feature: Charles Schwab Mutual Funds Navigation

Basic scenarios for navigating Mutual Funds

Background:
	Given I navigate to Mutual Funds from Accounts & Products

Scenario: Verify you can access the Mutual Funds Overview page
	Given I navigate to the secondary link Mutual Funds Overview
	When I verify the title of the site is Investing in Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds

Scenario: Verify you can access the Find Mutual Funds page
	Given I navigate to the secondary link Find Mutual Funds
		| Key   | Value             |
		| Item1 | Find Mutual Funds |
	When I verify the title of the site is Find and Invest in Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/find-mutual-funds

Scenario: Verify you can access the Investor Information page
	Given I navigate to the secondary link Find Mutual Funds
		| Key   | Value                |
		| Item1 | Investor Information |
	When I verify the title of the site is Mutual Fund Prospectuses: Investor Information | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/find-mutual-funds/investor-information


Scenario: Verify you can access the Selecting List page
	Given I navigate to the secondary link Selecting List
	When I verify the title of the site is Build a Mutual Fund Portfolio - Personalized Portfolio | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/build-a-portfolio

Scenario: Verify you can access the Invest in a Portfolio Solution page
	Given I navigate to the secondary link Invest in a Portfolio Solution
	When I verify the title of the site is Invest in Portfolio Solutions - Mutual Funds |Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/invest-in-a-portfolio-solution

Scenario: Verify you can access the Overview page
	Given I navigate to the secondary link Understanding Mutual Funds
		| Key   | Value    |
		| Item1 | Overview |
	When I verify the title of the site is What is an ETF (Exchange-Traded Fund)? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/understand-etfs

Scenario: Verify you can access the Benefits and Considerations of Mutual Funds page
	Given I navigate to the secondary link Understanding Mutual Funds
		| Key   | Value                                       |
		| Item1 | Benefits and Considerations of Mutual Funds |
	When I verify the title of the site is Mutual Fund Benefits - Diversification at Low Cost | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/benefits

Scenario: Verify you can access the Costs and Fees of Mutual Funds page
	Given I navigate to the secondary link Understanding Mutual Funds
		| Key   | Value                          |
		| Item1 | Costs and Fees of Mutual Funds |
	When I verify the title of the site is Mutual Fund Fees, Costs & Expense Ratios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/costs-fees

Scenario: Verify you can access the ETFs vs. Mutual Funds page
	Given I navigate to the secondary link Understanding Mutual Funds
		| Key   | Value                 |
		| Item1 | ETFs vs. Mutual Funds |
	When I verify the title of the site is ETFs vs. Mutual Funds – What’s the Difference? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/mutual-funds-vs-etfs

Scenario: Verify you can access the Types of Mutual Funds page
	Given I navigate to the secondary link Types of Mutual Funds
		| Key   | Value                 |
		| Item1 | Types of Mutual Funds |
	When I verify the title of the site is Types of mutual funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types

Scenario: Verify you can access the Equity Mutual Funds page
	Given I navigate to the secondary link Types of Mutual Funds
		| Key   | Value               |
		| Item1 | Equity Mutual Funds |
	When I verify the title of the site is Equity mutual funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/equity-mutual-funds

Scenario: Verify you can access the Index Mutual Funds page
	Given I navigate to the secondary link  Types of Mutual Funds
		| Key   | Value              |
		| Item1 | Index Mutual Funds |
	When I verify the title of the site is Index Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/index-mutual-funds

Scenario: Verify you can access the Asset Allocation Mutual Funds page
	Given I navigate to the secondary link  Types of Mutual Funds
		| Key   | Value                         |
		| Item1 | Asset Allocation Mutual Funds |
	When I verify the title of the site is Asset Allocation Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/asset-allocation-mutual-funds

Scenario: Verify you can access the Target Date Mutual Funds page
	Given I navigate to the secondary link Types of Mutual Funds
		| Key   | Value                    |
		| Item1 | Target Date Mutual Funds |
	When I verify the title of the site is Target Date Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/target-date-mutual-funds

Scenario: Verify you can access the Commodity Mutual Funds page
	Given I navigate to the secondary link  Types of Mutual Funds
		| Key   | Value                  |
		| Item1 | Commodity Mutual Funds |
	When I verify the title of the site is Commodity mutual funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/commodity-mutual-funds

Scenario: Verify you can access the Environmental, Social and Governance (ESG) Mutual Funds page
	Given I navigate to the secondary link  Types of Mutual Funds
		| Key   | Value                                                   |
		| Item1 | Environmental, Social and Governance (ESG) Mutual Funds |
	When I verify the title of the site is Socially Responsible Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds/types/socially-responsible-mutual-funds


