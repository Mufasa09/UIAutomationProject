Feature: Charles Schwab Financial Planning Offering Navigation

Basic scenarios for navigating Financial Planning Offering 

Background: 
	Given I navigate to Financial Planning Offering from Advice

Scenario: Verify you can access the Complimentary Plan page
	Given I navigate to the secondary link Complimentary Plan
	When I verify the title of the site is Your Complimentary Financial Plan | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning/schwab-plan

Scenario: Verify you can access the Calculators & Tools page
	Given I navigate to the secondary link Calculators & Tools
	When I verify the title of the site is Financial Planning Tools & Calculators | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning/tools

Scenario: Verify you can access the How to reach your goals page
	Given I navigate to the secondary link How to reach your goals
	When I verify the title of the site is Financial Planning - Are You on Track to Your Goals? | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/financial-planning
