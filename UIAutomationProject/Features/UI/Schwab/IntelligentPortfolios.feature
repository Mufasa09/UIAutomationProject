Feature: Charles Schwab Intelligent Portfolios

Basic scenarios of the Charles Schwab Intelligent Portfolios


Scenario: Verify you can access the site
	Given I verify the title of the site is Charles Schwab | A Modern Approach to Investing and Retirement Planning | Charles Schwab
	When I navigate to Automated Investing from Advice
	Then I verify the title of the site is Schwab Intelligent Portfolios | Charles Schwab

