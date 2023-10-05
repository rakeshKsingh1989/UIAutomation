Feature: Buy Items and place order 

Buy Items and place order 

@tag1
Scenario: Verify user is able to place order
	Given user is logged in to application
	When user adds items to cart
	And user places order
	Then verify order is placed successfully
