Feature: Charles Schwab Pricing Navigation

Basic scenarios for navigating Pricing


Scenario: Verify you can access the Commissions and Fees
	Given I navigate to Commissions and Fees from Pricing
	When I verify the title of the site is Pricing | Account Fees | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/pricings

Scenario: Verify you can access the Understanding Investment Fees
	Given I navigate to Understanding Investment Fees from Pricing
	When I verify the title of the site is Investing Costs: Mutual funds, ETFs, Stocks | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/costs-of-investing

Scenario: Verify you can access the Low-Cost Investments
	Given I navigate to Low-Cost Investments from Pricing
	When I verify the title of the site is Low-Cost Investments and Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/pricing/low-cost-investments

Scenario: Verify you can access the Cost and Considerations
	Given I navigate to Costs and Considerations from Pricing
	When I verify the title of the site is Transfers: Moving Accounts to Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab

Scenario: Verify you can access the Client Relationship Summaries
	Given I navigate to Client Relationship Summaries from Pricing
	When I verify the title of the site is Important Information About Our Services and Fees | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transparency

Scenario: Verify you can access the See our Pricing
	Given I navigate to See our pricing from Pricing
	When I verify the title of the site is Pricing | Account Fees | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/pricing