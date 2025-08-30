Feature: Intelligent Portfolios Tests

Basic scenarios of the Sauce Demo login 


Scenario: Verify you can log in the site
	Given I verify the title of the site is Swag Labs
	When I enter locked_out_user user credentials on SauceDemo site
	Then I verify login error
		| Key  | Value      |
		| Role | locked_out |

