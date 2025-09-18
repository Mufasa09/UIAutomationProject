Feature: Charles Schwab Our Security Knowledge Center Navigation

Basic scenarios for navigating Our Security Knowledge Center

Background: 
	Given I navigate to Our Security Knowledge Center from Why Schwab

Scenario: Verify you can access the Our commitment to your security page
	Given I navigate to the secondary link Our commitment to your security
	When I verify the title of the site is SchwabSafe | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/schwabsafe

Scenario: Verify you can access the Resources to keep you safe online page
	Given I navigate to the secondary link Resources to keep you safe online
	When I verify the title of the site is Security Knowledge Center | SchwabSafe | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/schwabsafe/security-knowledge-center

Scenario: Verify you can access the Protecting senior investors page
	Given I navigate to the secondary link Protecting senior investors
	When I verify the title of the site is Protecting Senior and Vulnerable Investors | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/schwabsafe/protecting-senior-investors


	Scenario: Verify you can access the Fraud and Security Video Library page
	Given I navigate to the secondary link Fraud and Security Video Library
	When I verify the title of the site is Fraud & Security Video Library | SchwabSafe | Charles Schwab | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/schwabsafe/fraud-and-security-video-library


	Scenario: Verify you can access the Schwab Security Guarantee page
	Given I navigate to the secondary link Schwab Security Guarantee
	When I verify the title of the site is Schwab Security Guarantee | SchwabSafe | Charles Schwab
	Then I verify the url of the site is https://www.schwab.com/schwabsafe/security-guarantee

