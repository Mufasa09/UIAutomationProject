Feature: Charles Schwab Costs & Considerations Navigation

Basic scenarios for navigating Costs & Considerations

Background: 
	Given I navigate to Costs & Considerations from Pricing

Scenario: Verify you can access the Complimentary Plan page
	Given I navigate to the secondary link Transfer of Accounts
	When I verify the title of the site is Transfers: Moving Accounts to Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab

Scenario: Verify you can access the Calculators & Tools page
	Given I navigate to the secondary link Consideration Benefits
	When I verify the title of the site is Consolidate Accounts - Asset Transfer | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab/consolidate-accounts

Scenario: Verify you can access the How to reach your goals page
	Given I navigate to the secondary link FAQs
	When I verify the title of the site is Frequently Asked Questions - Asset Transfer | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab/faqs


