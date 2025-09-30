Feature: Charles Schwab Checking Navigation

Basic scenarios for navigating Checking

Background:
	Given I navigate to Checking from Accounts & Products

Scenario: Verify you can access the Overview page
	Given I navigate to the secondary link Checking Overview
	When I verify the title of the site is Open a Checking Account Online | Schwab Bank
	Then I verify the url of the site is https://www.schwab.com/checking

Scenario: Verify you can access the Schwab Bank Debit Card page
	Given I navigate to the secondary link Schwab Bank Debit Card
	When I verify the title of the site is Visa Platinum Debit Card | Schwab Bank
	Then I verify the url of the site is https://www.schwab.com/checking/debit-card

Scenario: Verify you can access the Send Money with Zelle® page
	Given I navigate to the secondary link Send Money with Zelle
	When I verify the title of the site is Send and receive money with Zelle® | Schwab Bank | Charles Schwab
		| Key         | Value |
		| TitleEnding | CR    |
	Then I verify the url of the site is https://www.schwab.com/checking/zelle

Scenario: Verify you can access the FAQs page
	Given I navigate to the secondary link FAQs
	When I verify the title of the site is Schwab Bank Investor Checking Account Frequently Asked Questions
	Then I verify the url of the site is https://www.schwab.com/checking/faqs


