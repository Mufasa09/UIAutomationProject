Feature: Charles Schwab Wealth Advisory Navigation

Basic scenarios for navigating Schwab Wealth Advisory 

Background: 
	Given I navigate to Schwab Wealth Advisory from Advice

Scenario: Verify you can access the Overview page
	Given I navigate to the secondary link Overview
	When I verify the title of the site is Schwab Wealth Advisory - Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor

Scenario: Verify you can access the Personalized Approach page
	Given I navigate to the secondary link Personalized Approach
	When I verify the title of the site is Personalized Approach - Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor/approach

Scenario: Verify you can access the Comprehensive Wealth Management page
	Given I navigate to the secondary link Comprehensive Wealth Management
	When I verify the title of the site is Strategy - Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor/strategy

Scenario: Verify you can access the Experienced Team page
	Given I navigate to the secondary link Experienced Team
	When I verify the title of the site is Experienced Team - Wealth Management | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor/team

	Scenario: Verify you can access the Sample Scenarios page
	Given I navigate to the secondary link Sample Scenarios
	When I verify the title of the site is Schwab Wealth Advisory Sample Scenarios | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/wealth-management/wealth-advisor/sample-scenarios

