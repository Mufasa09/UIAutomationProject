Feature: Charles Schwab Pledged Asset Line Navigation

Basic scenarios for navigating Pledge dAsset Line

Background:
	Given I navigate to Pledged Asset Line from Accounts & Products

Scenario: Verify you can access the Schwab Overview page
	Given I navigate to the secondary link Overview
	When I verify the title of the site is Pledged Asset Line® | Schwab Bank
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/pledged-asset-line

Scenario: Verify you can access the Rates page
	Given I navigate to the secondary link Rates
	When I verify the title of the site is Pledged Asset Line® Rates | Schwab Bank | Charles Schwab
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/pledged-asset-line/rates

Scenario: Verify you can access the FAQs page
	Given I navigate to the secondary link FAQs
	When I verify the title of the site is Pledged Asset Line® Frequently Asked Questions | Schwab Bank
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/pledged-asset-line/faqs


