Feature: Charles Schwab Stocks Navigation

Basic scenarios for navigating Stocks

Background:
	Given I navigate to Investment Products Stocks from Accounts & Products

Scenario: Verify you can access the Stock Overview page
	Given I navigate to the secondary link Options Overview
	When I verify the title of the site is Stock Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks

Scenario: Verify you can access the Around the Clock Trading page
	Given I navigate to the secondary link Around the Clock Trading
	When I verify the title of the site is Extended Hours Trading: Pre-Market & After-Hours Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/extended-hours-trading

Scenario: Verify you can access the Get Started page
	Given I navigate to the secondary link Get Started
	When I verify the title of the site is Trade Stocks | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options/options-trading

Scenario: Verify you can access the International Stocks Overview page
	Given I navigate to the secondary link International Stocks
		| Key   | Value                         |
		| Item1 | International Stocks Overview |
	When I verify the title of the site is International Stocks: How and Why to Invest | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/international-stocks

Scenario: Verify you can access the ADRs, Foreign Ordinaries & Canadian Stocks page
	Given I navigate to the secondary link International Stocks
		| Key   | Value                                      |
		| Item1 | ADRs, Foreign Ordinaries & Canadian Stocks |
	When I verify the title of the site is Investing in ADRs, Foreign Ordinaries, & Canadian Stocks | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/adrs-foreign-ordinaries-canadian-stocks

Scenario: Verify you can access the Costs and fees of ETFs page
	Given I navigate to the secondary link Why Trade Stocks at Schwab
		| Key   | Value                    |
		| Item1 | Trading Stocks at Schwab |
	When I verify the title of the site is Why Trade Stocks at Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/stock-trading

Scenario: Verify you can access the Order Execution page
	Given I navigate to the secondary link Why Trade Stocks at Schwab
		| Key   | Value           |
		| Item1 | Order Execution |
	When I verify the title of the site is Trade execution quality | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality

Scenario: Verify you can access the Investment Research page
	Given I navigate to the secondary link Why Trade Stocks at Schwab
		| Key   | Value               |
		| Item1 | Investment Research |
	When I verify the title of the site is Investment Research | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/investment-research

Scenario: Verify you can access the Dividend Reinvestment Plans (DRIPs) page
	Given I navigate to the secondary link Why Trade Stocks at Schwab
		| Key   | Value                               |
		| Item1 | Dividend Reinvestment Plans (DRIPs) |
	When I verify the title of the site is Stocks Dividend Reinvestment Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/dividend-reinvestment-plan

Scenario: Verify you can access the Restricted Stock Services page
	Given I navigate to the secondary link Why Trade Stocks at Schwab
		| Key   | Value                     |
		| Item1 | Restricted Stock Services |
	When I verify the title of the site is Restricted Stock Services | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/restricted-stock-services

Scenario: Verify you can access the Intro to Stockspage
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value           |
		| Item1 | Intro to Stocks |
	When I verify the title of the site is What are stocks? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks

Scenario: Verify you can access the Over-the-counter Stocks (OTCs) page
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value                          |
		| Item1 | Over-the-counter Stocks (OTCs) |
	When I verify the title of the site is OTC (Over-the-Counter) Markets: Trading & Securities | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/otc-markets

Scenario: Verify you can access the Master Limited Partnerships (MLPs) page
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value                              |
		| Item1 | Master Limited Partnerships (MLPs) |
	When I verify the title of the site is Master Limited Partnerships (MLPs) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/mlps

Scenario: Verify you can access the Real Estate Investment Trusts (REITs) page
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value                                 |
		| Item1 | Real Estate Investment Trusts (REITs) |
	When I verify the title of the site is Real Estate Investment Trusts (REITs) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/reits

Scenario: Verify you can access the Business Development Companies (BDCs) page
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value                                 |
		| Item1 | Business Development Companies (BDCs) |
	When I verify the title of the site is Business Development Companies (BDCs) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/understand-stocks/bdcs

Scenario: Verify you can access the IPO DPO Stocks page
	Given I navigate to the secondary link Understanding Stocks
		| Key   | Value          |
		| Item1 | IPO/DPO Stocks |
	When I verify the title of the site is IPO & DPO Stocks: Types of New Issue Stocks | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks/ipo-direct-listing