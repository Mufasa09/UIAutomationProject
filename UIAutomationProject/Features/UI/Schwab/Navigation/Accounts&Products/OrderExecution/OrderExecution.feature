Feature: Charles Schwab Order Execution Navigation

Basic scenarios for navigating Order Execution

Background: 
	Given I navigate to Order Execution from Accounts & Products

Scenario: Verify you can access the Annuities Overview page
	Given I navigate to the secondary link Schwab Order Execution Advantage
	When I verify the title of the site is Trade execution quality | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality

Scenario: Verify you can access the Order Routing Process page
	Given I navigate to the secondary link Order Routing Process
	When I verify the title of the site is Trade order routing process | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality/order-routing-process

Scenario: Verify you can access the Income Annuity Estimator page
	Given I navigate to the secondary link Price Improvement
	When I verify the title of the site is Understanding Price Improvement | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality/price-improvement


