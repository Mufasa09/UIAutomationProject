Feature: Charles Schwab Intelligent Portfolios

Basic scenarios of the Charles Schwab Intelligent Portfolios


Scenario: Verify you can access the Intelligent Portfolios site
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/intelligent-portfolios

Scenario: Verify you can access the Get Started button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the Get Started button
	Then I verify the title of the site is Let's get started creating your account. But first, we need to show you the fine print.

Scenario: Verify you can access the Let's Take a deeper dive button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the Take a deeper dive button
	Then I verify the title of the site is Schwab Intelligent Portfolios Historical Performance | Charles Schwab

Scenario: Verify you can access the See how we stack up button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the See how we stack up button
	Then I verify the title of the site is Schwab Intelligent Portfolios Compare Us | Charles Schwab

Scenario: Verify you can access the Open an account button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the Open an account button
	Then I verify the title of the site is Let's get started creating your account. But first, we need to show you the fine print.

Scenario: Verify you can access the Find branch button
	Given I navigate to Automated Investing from Advice
	When I verify the title of the site is Automated Investing | Schwab Intelligent Portfolios | Charles Schwab
	And I access the Find a local branch to apply in person button
	Then I verify the title of the site is Find a Branch | Financial Services | Brokerage Firm | Charles Schwab

