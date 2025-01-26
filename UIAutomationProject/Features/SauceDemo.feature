Feature: SauceDemo

Basic scenarios of the site


Background:
	Given Navigate to site https://www.saucedemo.com/

@SmokeTest
Scenario: Verify you can log in the site
	Given I verify the title of the site is Swag Labs
	When I enter user credentials on SauceDemo site
		| Key      | Value         |
		| UserName | standard_user |
