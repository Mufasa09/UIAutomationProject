Feature: Charles Schwab ETFs Navigation

Basic scenarios for navigating ETFs

Background:
	Given I navigate to ETFs from Accounts & Products

Scenario: Verify you can access the ETF Overview page
	Given I navigate to the secondary link ETF Overview
	When I verify the title of the site is ETF (Exchange-Traded Fund) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs

Scenario: Verify you can access the ETFs at Schwab page
	Given I navigate to the secondary link ETFs at Schwab
		| Key   | Value          |
		| Item1 | ETFs at Schwab |
	When I verify the title of the site is ETF Investing at Schwab | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/invest-in-etfs

Scenario: Verify you can access the Investor Information page
	Given I navigate to the secondary link ETFs at Schwab
		| Key   | Value                |
		| Item1 | Investor Information |
	When I verify the title of the site is Investor Information for ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/investor-information


Scenario: Verify you can access the Education page
	Given I navigate to the secondary link Selecting ETFs
	When I verify the title of the site is How to Choose an ETF – Guide to ETF Investing | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/tools

Scenario: Verify you can access the Understanding ETFs page
	Given I navigate to the secondary link Understanding ETFs
		| Key   | Value              |
		| Item1 | Understanding ETFs |
	When I verify the title of the site is What is an ETF (Exchange-Traded Fund)? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/understand-etfs

Scenario: Verify you can access the Benefits and considerations of ETFs page
	Given I navigate to the secondary link Understanding ETFs
		| Key   | Value                               |
		| Item1 | Benefits and considerations of ETFs |
	When I verify the title of the site is ETF Benefits - Strengthening Your Portfolio | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/benefits

Scenario: Verify you can access the Costs and fees of ETFs page
	Given I navigate to the secondary link  Understanding ETFs
		| Key   | Value                  |
		| Item1 | Costs and fees of ETFs |
	When I verify the title of the site is ETF Fees and Associated Costs of ETF Investing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/costs-fees

Scenario: Verify you can access the ETFs vs. Mutual Funds page
	Given I navigate to the secondary link  Understanding ETFs
		| Key   | Value                 |
		| Item1 | ETFs vs. Mutual Funds |
	When I verify the title of the site is ETFs vs. Mutual Funds – What’s the Difference? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/mutual-funds-vs-etfs

	##
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


