Feature: Charles Schwab Schwab Coaching Navigation

Basic scenarios for navigating Schwab Coaching

Background: 
	Given I navigate to Schwab Coaching from Learn

Scenario: Verify you can access the Overview page
	Given I navigate to the secondary link Overview
	When I verify the title of the site is Schwab Coaching | Overview | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/coaching

Scenario: Verify you can access the Live webcasts & virtual workshops page
	Given I navigate to the secondary link Live webcasts & virtual workshops
	When I verify the title of the site is Schwab Coaching | Live webcasts & virtual workshops | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/coaching/webcasts

Scenario: Verify you can access the On-demand Webcasts page
	Given I navigate to the secondary link On-demand Webcasts
	When I verify the title of the site is On-demand Webcasts | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/coaching/ondemand-webcasts


Scenario: Verify you can access the In-person Events page
	Given I navigate to the secondary link In-person Events
	When I verify the title of the site is In-person Trading Workshops and Events | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/coaching/live-events



