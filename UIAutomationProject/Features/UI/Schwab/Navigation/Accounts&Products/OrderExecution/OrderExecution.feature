Feature: Charles Schwab Order Execution Navigation

Basic scenarios for navigating Order Execution

Background: 
	Given I navigate to Order Execution from Accounts & Products

Scenario: Verify you can access the Annuities Overview page
	Given I navigate to the secondary link Annuities Overview
	When I verify the title of the site is Annuities: Saving for Retirement Income | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities

Scenario: Verify you can access the Order Routing Process page
	Given I navigate to the secondary link Order Routing Process
	When I verify the title of the site is Trade order routing process | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/execution-quality/order-routing-process

Scenario: Verify you can access the Income Annuity Estimator page
	Given I navigate to the secondary link Income Annuity Estimator
	When I verify the title of the site is Income Annuity Estimator: Calculate Your Payout | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/annuities/fixed-income-annuity-calculator


