Feature: SauceDemoProducts

Basic scenarios of the Sauce Demo Product page

Scenario: Verify you can add an item to the cart
	Given I verify the title of the site is Swag Labs
	When I enter standard_user user credentials on SauceDemo site
	Then I add the item Sauce Labs Backpack to the cart
	* I verify items in cart before removing
		| Key      | Value               |
		| ItemName | Sauce Labs Backpack |


Scenario Outline: Verify you can add items to the cart as a standard user
	Given I verify the title of the site is Swag Labs
	When I enter standard_user user credentials on SauceDemo site
	Then I add the item to the cart
		| Key      | Value      |
		| ItemName | <ItemName> |
	* I verify items in cart before removing
		| Key      | Value      |
		| ItemName | <ItemName> |

Examples:
	| ItemName                          |
	| Sauce Labs Backpack               |
	| Sauce Labs Bike Light             |
	| Sauce Labs Bolt T-Shirt           |
	| Sauce Labs Fleece Jacket          |
	| Sauce Labs Onesie                 |
	| Test.allTheThings() T-Shirt (Red) |

Scenario Outline: Verify you can add items to the cart as a perfomance user
	Given I verify the title of the site is Swag Labs
	When I enter performance_glitch_user user credentials on SauceDemo site
	Then I add the item to the cart
		| Key      | Value      |
		| ItemName | <ItemName> |
	* I verify items in cart before removing
		| Key      | Value      |
		| ItemName | <ItemName> |

Examples:
	| ItemName                          |
	| Sauce Labs Backpack               |
	| Sauce Labs Bike Light             |
	| Sauce Labs Bolt T-Shirt           |
	| Sauce Labs Fleece Jacket          |
	| Sauce Labs Onesie                 |
	| Test.allTheThings() T-Shirt (Red) |

Scenario Outline: Verify you can add items to the cart as a visual user
	Given I verify the title of the site is Swag Labs
	When I enter visual_user user credentials on SauceDemo site
	Then I add the item to the cart
		| Key      | Value      |
		| ItemName | <ItemName> |
	* I verify items in cart before removing
		| Key      | Value      |
		| ItemName | <ItemName> |

Examples:
	| ItemName                          |
	| Sauce Labs Backpack               |
	| Sauce Labs Bike Light             |
	| Sauce Labs Bolt T-Shirt           |
	| Sauce Labs Fleece Jacket          |
	| Sauce Labs Onesie                 |
	| Test.allTheThings() T-Shirt (Red) |

Scenario Outline: Verify you can add items to the cart as a problem user
	Given I verify the title of the site is Swag Labs
	When I enter visual_user user credentials on SauceDemo site
	Then I add the item to the cart
		| Key      | Value      |
		| ItemName | <ItemName> |
	* I verify items in cart before removing
		| Key      | Value      |
		| ItemName | <ItemName> |

Examples:
	| ItemName                          |
	| Sauce Labs Backpack               |
	| Sauce Labs Bike Light             |
	| Sauce Labs Bolt T-Shirt           |
	| Sauce Labs Fleece Jacket          |
	| Sauce Labs Onesie                 |
	| Test.allTheThings() T-Shirt (Red) |



#	Scenario Outline: Verify you can add items to the cart as a standard user
#	Given I verify the title of the site is Swag Labs
#	When I enter standard_user user credentials on SauceDemo site
#	Then I add the item to the cart
#		| Key      | Value      |
#		| ItemName | <ItemName> |
#	* I verify items in cart before removing
#		| Key      | Value      |
#		| ItemName | <ItemName> |
#
#Examples:
#	| ItemName                          |
#	| Sauce Labs Backpack               |
#	| Sauce Labs Bike Light             |
#	| Sauce Labs Bolt T-Shirt           |
#	| Sauce Labs Fleece Jacket          |
#	| Sauce Labs Onesie                 |
#	| Test.allTheThings() T-Shirt (Red) |

#Scenario Outline: Verify you can add items to the cart as a perfomance user
#	Given I verify the title of the site is Swag Labs
#	When I enter performance_glitch_user user credentials on SauceDemo site
#	Then I add the item to the cart
#		| Key      | Value      |
#		| ItemName | <ItemName> |
#	* I verify items in cart before removing
#		| Key      | Value      |
#		| ItemName | <ItemName> |
#
#Examples:
#	| ItemName                          |
#	| Sauce Labs Backpack               |
#	| Sauce Labs Bike Light             |
#	| Sauce Labs Bolt T-Shirt           |
#	| Sauce Labs Fleece Jacket          |
#	| Sauce Labs Onesie                 |
#	| Test.allTheThings() T-Shirt (Red) |
#
#Scenario Outline: Verify you can add items to the cart as a visual user
#	Given I verify the title of the site is Swag Labs
#	When I enter visual_user user credentials on SauceDemo site
#	Then I add the item to the cart
#		| Key      | Value      |
#		| ItemName | <ItemName> |
#	* I verify items in cart before removing
#		| Key      | Value      |
#		| ItemName | <ItemName> |

#Examples:
#	| ItemName                          |
#	| Sauce Labs Backpack               |
#	| Sauce Labs Bike Light             |
#	| Sauce Labs Bolt T-Shirt           |
#	| Sauce Labs Fleece Jacket          |
#	| Sauce Labs Onesie                 |
#	| Test.allTheThings() T-Shirt (Red) |

Scenario Outline: Verify you can add 2 items to the cart as a problem user
	Given I verify the title of the site is Swag Labs
	When I enter visual_user user credentials on SauceDemo site
	Then I add the item to the cart
		| Key      | Value      |
		| ItemName | <ItemName> |
	* I verify items in cart before removing
		| Key      | Value      |
		| ItemName | <ItemName> |

Examples:
	| ItemName                          |  |
	| Sauce Labs Backpack               |  |
	| Sauce Labs Bike Light             |  |
	| Sauce Labs Bolt T-Shirt           |  |
	| Sauce Labs Fleece Jacket          |  |
	| Sauce Labs Onesie                 |  |
	| Test.allTheThings() T-Shirt (Red) |  |