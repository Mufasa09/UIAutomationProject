Feature: Charles Schwab Automated Investing Navigation

Basic scenarios for navigating Automted Investing  

Background:
	Given I navigate to Automated Investing from Why Schwab

Scenario: Verify you can access the Schwab Intelligent Portfolios page
	Given I navigate to the secondary link  Schwab Intelligent Portfolios
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios

Scenario: Verify you can access the Schwab Intelligent Portfolios Premium page
	Given I navigate to the secondary link  Schwab Intelligent Portfolios Premium
	When I verify the title of the site is Schwab automated investing with unlimited guidance | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios-premium

Scenario: Verify you can access the Schwab Intelligent Income page
	Given I navigate to the secondary link  Schwab Intelligent Income
	When I verify the title of the site is Schwab Intelligent Income™ | Automated withdrawals | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/automated-investing/intelligent-income

Scenario: Verify you can access the Compare our Solutions page
	Given I navigate to the secondary link Compare Solutions
		| Key   | Value                 |
		| Item1 | Compare our Solutions |
	When I verify the title of the site is Compare Our Intelligent Solutions | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/automated-investing/compare

Scenario: Verify you can access the Compare us to others page
	Given I navigate to the secondary link Compare Solutions
		| Key   | Value                |
		| Item1 | Compare us to others |
	When I verify the title of the site is Schwab Intelligent Portfolios Compare Us | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/automated-investing/compare-us

Scenario: Verify you can access the An Introduction to Robo-Advice page
	Given I navigate to the secondary link Resources
		| Key   | Value                          |
		| Item1 | An Introduction to Robo-Advice |
	When I verify the title of the site is What is a Robo Advisor | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/automated-investing/what-is-a-robo-advisor

Scenario: Verify you can access the Robo Advisor Myths page
	Given I navigate to the secondary link Resources
		| Key   | Value              |
		| Item1 | Robo Advisor Myths |
	When I verify the title of the site is What is a Robo-Advisor: Debunking Myths | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/automated-investing/robo-advisor-myths

Scenario: Verify you can access the Education page
	Given I navigate to the secondary link Resources
		| Key   | Value     |
		| Item1 | Education |
	When I verify the title of the site is Schwab Intelligent Portfolios Investing Insights | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/learn/intelligent-portfolios-insights
