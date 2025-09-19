Feature: Charles Schwab Costs and Considerations Navigation

Basic scenarios for navigating Costs and Considerations

Background: 
	Given I navigate to Costs and Considerations from Pricing

Scenario: Verify you can access the Transfer of Accounts page
	Given I navigate to the secondary link Transfer of Accounts
	When I verify the title of the site is Transfers: Moving Accounts to Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab

Scenario: Verify you can access the Consolidation Benefits page
	Given I navigate to the secondary link Consolidation Benefits
	When I verify the title of the site is Consolidate Accounts - Asset Transfer | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab/consolidate-accounts

Scenario: Verify you can access the FAQs page
	Given I navigate to the secondary link FAQs
	When I verify the title of the site is Frequently Asked Questions - Asset Transfer | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/transfer-to-schwab/faqs


