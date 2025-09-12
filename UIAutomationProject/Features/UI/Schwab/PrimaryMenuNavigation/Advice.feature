Feature: Charles Schwab Advice Navigation

Basic scenarios for navigating Advice


Scenario: Verify you can access the Schwab Wealth Advisory™
	Given I navigate to Schwab Wealth Advisory™ from Advice
	When I verify the title of the site is Schwab Wealth Advisory - Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor


Scenario: Verify you can access the Autmated Investing with Guidance
	Given I navigate to Automated Investing with Guidance from Advice
	When I verify the title of the site is Schwab automated investing with unlimited guidance | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios-premium

Scenario: Verify you can access the Autmated Investing
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios

Scenario: Verify you can access the More Advice Solutions
	Given I navigate to  More Advice Solutions from Advice
	When I verify the title of the site is Wealth Management & Investment Services | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/invest-with-us/wealth-management-services

	Scenario: Verify you can access the Financial Planning Offering
	Given I navigate to Financial Planning Offering  from Advice
	When I verify the title of the site is Financial Planning - Are You on Track to Your Goals? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning

Scenario: Verify you can access the How Much You Need to Retire
	Given I navigate to How Much You Need to Retire from Advice
	When I verify the title of the site is Retirement Solutions Hub | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/how-much-do-i-need

Scenario: Verify you can access the Planning Calculators
	Given I navigate to Planning Calculators from Advice
	When I verify the title of the site is Financial Planning Tools & Calculators | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning/tools

Scenario: Verify you can access the Complimentary Plan
	Given I navigate to Complimentary Plan from Advice
	When I verify the title of the site is Your Complimentary Financial Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning/schwab-plans

