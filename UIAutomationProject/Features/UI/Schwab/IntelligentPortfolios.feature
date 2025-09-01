Feature: Charles Schwab Intelligent Portfolios

Basic scenarios of the Charles Schwab Intelligent Portfolios


Scenario: Verify you can access the site
	Given I verify the title of the site is Charles Schwab | A Modern Approach to Investing and Retirement Planning | Charles Schwab
	When I navigate to Automated Investing from Advice
	Then I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab

Scenario: Verify you can access the Get Started button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the Get Started button
	Then I verify the title of the site is Let's get started creating your account. But first, we need to show you the fine print.

