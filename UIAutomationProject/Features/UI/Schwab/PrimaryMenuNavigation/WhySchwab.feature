Feature: Charles Schwab Why Schwab Navigation

Basic scenarios for navigating Why Schwab


Scenario: Verify you can access the Intelligent Portfolios site
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios