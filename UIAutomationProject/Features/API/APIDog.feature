Feature: APIDog

Basic scenarios of the API site


Scenario: Verify basic API calls
	Given I navigate to API site
	When I verify successful api call
		| Key        | Value |
		| StatusCode | OK    |
	Then I verify response body
		| Key        | Value   |
		| TxtFile    | APIMain |
		| StatusCode | OK      |
