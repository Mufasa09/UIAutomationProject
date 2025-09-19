Feature: Charles Schwab Futures Navigation

Basic scenarios for navigating Futures

Background: 
	Given I navigate to Futures from Accounts & Products

Scenario: Verify you can access the Why Trade Futures Through Us page
	Given I navigate to the secondary link Why Trade Futures Through Us
	When I verify the title of the site is Futures Trading | Charles Schwab Futures and Forex
	Then I verify the url of the site is https://www.schwab.com/futures/futures-trading

Scenario: Verify you can access the Around the Clock Trading page
	Given I navigate to the secondary link Around the Clock Trading
	When I verify the title of the site is Futures Around the Clock Trading | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/futures/futures-around-the-clock-trading

Scenario: Verify you can access the Get Started page
	Given I navigate to the secondary link Get Started
	When I verify the title of the site is Futures Account | Charles Schwab Futures and Forex
	Then I verify the url of the site is https://www.schwab.com/futures/trade-futures


