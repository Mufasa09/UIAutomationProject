Feature: SauceDemo

Basic scenarios of the site


Background:
	Given Navigate to site https://www.saucedemo.com/

@SmokeTest
Scenario: Verify you can log in the site
	Given I verify the title of the site is Swag Labs
	When I enter user credentials on SauceDemo site
		| Key      | Value           |
		| UserName | locked_out_user |
		| Password | secret_sauce    |
	Then I verify login error
		| Key      | Value           |
		| UserName | locked_out_user |
		| Password | secret_sauce    |

Scenario: I verify all elements are displayed on login page
	When I verify the title of the site is Swag Labs
	Then I verify login page elements

Scenario: I verify negative login scenario
	Given I verify the title of the site is Swag Labs
	When I verify login page elements
	Then I verify login error
		| Key      | Value |
		| UserName |       |
		| Password |       |


Scenario Outline: Verify you can log in the site with multiple users
	Given I verify the title of the site is Swag Labs
	When I enter user credentials on SauceDemo site
		| Key      | Value      |
		| UserName | <UserName> |
		| Password | <Password> |
	Then I verify user is on the main page

Examples:
	| UserName                | Password     |
	| standard_user           | secret_sauce |
	| performance_glitch_user | secret_sauce |
	| visual_user             | secret_sauce |
	| error_user              | secret_sauce |
