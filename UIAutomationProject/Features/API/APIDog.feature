Feature: APIDog

Basic scenarios of the API site


Scenario: Verify basic API calls
	When I verify successful api call
		| Key        | Value |
		| StatusCode | OK    |
	Then I verify response body
		| Key        | Value   |
		| TxtFile    | APIMain |
		| StatusCode | OK      |

Scenario: Verify basic API calls for jsonplaceholder
	When I verify successful api call
		| Key        | Value |
		| StatusCode | OK    |
	Then I make an api post call
		| Key     | Value                                      |
		| userID  | 1                                          |
		| id      | 101                                        |
		| title   | Test                                       |
		| body    | Testing it out please                      |
		| APIUrl  | https://jsonplaceholder.typicode.com/posts |
		| TxtFile | APIMain.txt                                |

