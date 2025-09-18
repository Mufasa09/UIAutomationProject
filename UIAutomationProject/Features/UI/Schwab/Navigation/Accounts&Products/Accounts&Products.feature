Feature: Charles Schwab Accounts & Products Navigation

Basic scenarios for navigating Accounts & Products


#Accounts
Scenario: Verify you can access the Brokerage and Trading site
	Given I navigate to Brokerage and Trading from Accounts & Products
	When I verify the title of the site is Brokerage account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/brokerage

Scenario: Verify you can access the Retirement Accounts (IRAs) site
	Given I navigate to Retirement Accounts (IRAs) from Accounts & Products
	When I verify the title of the site is What is an IRA? | Open an Individual Retirement Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/ira

Scenario: Verify you can access the Education and Custodial site
	Given I navigate to Education and Custodial from Accounts & Products
	When I verify the title of the site is College Savings Account | Education & Custodial | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/college-savings-accounts

Scenario: Verify you can access the Personal Choice Retirement site
	Given I navigate to Personal Choice Retirement  from Accounts & Products
	When I verify the title of the site is Schwab Brokerage: Personal Choice Retirement Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/pcra

Scenario: Verify you can access the Small Business site
	Given I navigate to Small Business from Accounts & Products
	When I verify the title of the site is Small Business Solutions and Services | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/small-business-solutions

Scenario: Verify you can access the Open an Account site
	Given I navigate to Open an Account from Accounts & Products
	When I verify the title of the site is Open a Schwab account online | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/open-an-account

Scenario: Verify you can access the Schwab Trading Powered by Ameritrade site
	Given I navigate to Schwab Trading Powered by Ameritrade from Accounts & Products
	When I verify the title of the site is Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading

Scenario: Verify you can access the Trading Platforms site
	Given I navigate to Trading Platforms from Accounts & Products
	When I verify the title of the site is thinkorswim | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim

Scenario: Verify you can access the Platforms Overview site
	Given I navigate to Platforms Overview from Accounts & Products
	When I verify the title of the site is Compare Platforms | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/thinkorswim/compare-platforms

Scenario: Verify you can access the Education site
	Given I navigate to Education from Accounts & Products
	When I verify the title of the site is Learn to Trade | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/learn-to-trade

Scenario: Verify you can access the Support site
	Given I navigate to Support from Accounts & Products
	When I verify the title of the site is Trading Support | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/trading/support

Scenario: Verify you can access the Order Execution site
	Given I navigate to Order Execution from Accounts & Products
	When I verify the title of the site is Trade execution quality | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality

Scenario: Verify you can access the Research site
	Given I navigate to Research from Accounts & Products
	When I verify the title of the site is Investment Research | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/investment-research

Scenario: Verify you can access the Mutual Funds site
	Given I navigate to Investment Mutual Funds from Accounts & Products
	When I verify the title of the site is Investing in Mutual Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/mutual-funds

Scenario: Verify you can access the ETFs site
	Given I navigate to Investment ETFs from Accounts & Products
	When I verify the title of the site is ETF (Exchange-Traded Fund) | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/etfs

Scenario: Verify you can access the Stocks site
	Given I navigate to Investment Stocks from Accounts & Products
	When I verify the title of the site is Stock Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/stocks

Scenario: Verify you can access the Options site
	Given I navigate to Investment Options from Accounts & Products
	When I verify the title of the site is Options Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/options

Scenario: Verify you can access the Futures site
	Given I navigate to Investment Futures from Accounts & Products
	When I verify the title of the site is Futures | Charles Schwab Futures and Forex
	Then I verify the url of the site is https://www.schwab.com/futures

Scenario: Verify you can access the Bonds, CDs & Fixed Income site
	Given I navigate to Bonds, CDs & Fixed Income from Accounts & Products
	When I verify the title of the site is Fixed Income Investments | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fixed-income

Scenario: Verify you can access the Money Market Funds site
	Given I navigate to Money Market Funds from Accounts & Products
	When I verify the title of the site is Money Market Funds | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/money-market-funds

Scenario: Verify you can access the Cash Solutions & Rates site
	Given I navigate to Cash Solutions & Rates from Accounts & Products
	When I verify the title of the site is Cash Investments – Sweeps, CDs, Money Market Funds & More | Charles Schwab
		| Key         | Value |
		| TitleEnding | Dash  |
	Then I verify the url of the site is https://www.schwab.com/cash-investments

Scenario: Verify you can access the Annuities site
	Given I navigate to Annuities from Accounts & Products
	When I verify the title of the site is Annuities: Saving for Retirement Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities

Scenario: Verify you can access the Cryptocurrency site
	Given I navigate to Cryptocurrency from Accounts & Products
	When I verify the title of the site is Cryptocurrency Investing | Cryptocurrency Investment Types | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/cryptocurrency

Scenario: Verify you can access the More Investment Products site
	Given I navigate to More Investment Products from Accounts & Products
	When I verify the title of the site is Investment Products | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/investment

Scenario: Verify you can access the Bank Offerings site
	Given I navigate to Bank Offerings from Accounts & Products
	When I verify the title of the site is Charles Schwab Bank & Lending Products | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/bank

Scenario: Verify you can access the Checking site
	Given I navigate to Checking from Accounts & Products
	When I verify the title of the site is Open a Checking Account Online | Schwab Bank
	Then I verify the url of the site is https://www.schwab.com/checking

Scenario: Verify you can access the Savings site
	Given I navigate to Savings from Accounts & Products
	When I verify the title of the site is Investor Savings Account | Savings Account | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/savings

Scenario: Verify you can access the Home Loans & Rates site
	Given I navigate to Home Loans & Rates from Accounts & Products
	When I verify the title of the site is Mortgage – Apply for mortgages at low interest rates | Schwab Bank
		| Key         | Value |
		| TitleEnding | Dash  |
	Then I verify the url of the site is https://www.schwab.com/mortgages

Scenario: Verify you can access the Pledged Asset Line site
	Given I navigate to Pledged Asset Line from Accounts & Products
	When I verify the title of the site is Pledged Asset Line® | Schwab Bank
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/pledged-asset-line

Scenario: Verify you can access the Credit Cards site
	Given I navigate to Credit Cards from Accounts & Products
	When I verify the title of the site is Charles Schwab Cards from American Express
	Then I verify the url of the site is https://www.schwab.com/credit-cards

Scenario: Verify you can access the Schwab Investing Themes™ site
	Given I navigate to Schwab Investing Themes from Accounts & Products
	When I verify the title of the site is Thematic Investing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/thematic-investing

Scenario: Verify you can access the Schwab Starter Kit™ site
	Given I navigate to Schwab Starter Kit from Accounts & Products
	When I verify the title of the site is Schwab Starter Kit™ | Charles Schwab
		| Key         | Value |
		| TitleEnding | TM    |
	Then I verify the url of the site is https://www.schwab.com/investing-starter-kit
	
Scenario: Verify you can access the Schwab Stock Slices™ site
	Given I navigate to Schwab Stock Slices from Accounts & Products
	When I verify the title of the site is Fractional Shares | Invest in Stock Slices | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/fractional-shares-stock-slices

Scenario: Verify you can access the Schwab Personalized Indexing™ site
	Given I navigate to Schwab Personalized Indexing from Accounts & Products
	When I verify the title of the site is Direct Indexing with Schwab Personalized Indexing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/direct-indexing

Scenario: Verify you can access the Generating Retirement Income site
	Given I navigate to Generating Retirement Income from Accounts & Products
	When I verify the title of the site is Generating Retirement Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/invest-with-us/retirement-income

Scenario: Verify you can access the Tax-Efficient Investing site
	Given I navigate to Tax-Efficient Investing from Accounts & Products
	When I verify the title of the site is Tax-Efficient Investing | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/invest-with-us/tax-efficient-investing

Scenario: Verify you can access the Schwab Personal Trust Services site
	Given I navigate to Schwab Personal Trust Services from Accounts & Products
	When I verify the title of the site is Personal Trust Services & Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/personal-trust-services

Scenario: Verify you can access the Alternative Investments site
	Given I navigate to Alternative Investments from Accounts & Products
	When I verify the title of the site is Alternative Investments | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/alternative-investments

