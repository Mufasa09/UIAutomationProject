Feature: Charles Schwab ETFs Navigation

Basic scenarios for navigating ETFs

Background:
	Given I navigate to Investment ETFs from Accounts & Products

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

Scenario: Verify you can access the Selecting ETFs page
	Given I navigate to the secondary link Selecting ETFs
	When I verify the title of the site is How to Choose an ETF – Guide to ETF Investing | Charles Schwab | Charles Schwab
		| Key         | Value |
		| TitleEnding | Dash  |
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
	Given I navigate to the secondary link Understanding ETFs
		| Key   | Value                  |
		| Item1 | Costs and fees of ETFs |
	When I verify the title of the site is ETF Fees and Associated Costs of ETF Investing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/costs-fees

#Need to fix
#Scenario: Verify you can access the ETFs vs. Mutual Funds page
#	Given I navigate to the secondary link Understanding ETFs
#		| Key   | Value                 |
#		| Item1 | ETFs vs. Mutual Funds |
#	When I verify the title of the site is ETFs vs. Mutual Funds – What’s the Difference? | Charles Schwab
#		| Key          | Value |
#		| TitleEnding  | Dash  |
#		| TitleEnding2 | AP    |
#	Then I verify the url of the site is https://www.schwab.com/etfs/mutual-funds-vs-etfs

Scenario: Verify you can access the Types of ETFss page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value         |
		| Item1 | Types of ETFs |
	When I verify the title of the site is Types of ETFs: Choosing ETFs for Your Portfolio | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types

Scenario: Verify you can access the Complex ETPs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value        |
		| Item1 | Complex ETPs |
	When I verify the title of the site is Complex exchange-traded products (ETPs) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/complex-etps

Scenario: Verify you can access the Sector ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value       |
		| Item1 | Sector ETFs |
	When I verify the title of the site is Sector ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/sector-etfs

Scenario: Verify you can access the Dividend ETFspage
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value         |
		| Item1 | Dividend ETFs |
	When I verify the title of the site is Dividend ETFs for Income Investing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/dividend-etfs

Scenario: Verify you can access the Smart Beta ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value           |
		| Item1 | Smart Beta ETFs |
	When I verify the title of the site is Smart Beta ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/smart-beta-etfs

Scenario: Verify you can access the Environmental, Social and Governance (ESG) ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value                                           |
		| Item1 | Environmental, Social and Governance (ESG) ETFs |
	When I verify the title of the site is Environmental, Social, and Governance (ESG) ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/socially-responsible-etfs

Scenario: Verify you can access the Bond ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value     |
		| Item1 | Bond ETFs |
	When I verify the title of the site is Bond Funds and Bond ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income/bond-funds-etfs

Scenario: Verify you can access the Commodity ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value          |
		| Item1 | Commodity ETFs |
	When I verify the title of the site is Commodity ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/commodity-etfs

Scenario: Verify you can access the Currency ETFs page
	Given I navigate to the secondary link Types of ETFs
		| Key   | Value         |
		| Item1 | Currency ETFs |
	When I verify the title of the site is Currency ETFs | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs/types/currency-etfs


