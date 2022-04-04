Feature: Adding a new promo to a customer

Scenario: Logging in to Kantar website
	Given User opens the website for Kantar
	Then User is at homepage
	When Clicks on the tools tab
	Then Customer details and promo codes should be visible
	And Customer details are visible
	Then Dropdown list should appear
	When User selects the columns option
	And User selects visible tab
	And User makes sure that all columns are selected
	And User clicks on the Ok button
	And User double checks if all visible checkboxes are ticked
	And User Clicks on visible column ok button
	Then The user is back to the customer page
	When User selects multiple IDs

	And User clicks on links
	And User selects 'Matched Claims' link
	And User goes back

	And User clicks on links
	And User selects 'Customer (promo holder)' link
	And User goes back
	
	And User clicks on links
	And User selects 'Customer (Ship-To(s))' link
	And User goes back

	And User clicks on links
	And User selects 'Child promo holders' link 
	And User goes back
	Then User unchecks all selected promos

	When User clicks on a promo 'EC86263'
	And User clicks on links
	And User selects 'Matched Claims' link
	And User goes back

	And User clicks on links
	And User selects 'Customer (promo holder)' link
	And User goes back
	
	And User clicks on links
	And User selects 'Customer (Ship-To(s))' link
	And User goes back

	And User clicks on links
	And User selects 'Child promo holders' link 
	And User goes back
	When User clicks on a promo 'EC86263'
	Then promo is unchecked

	When Clicks on the tools tab
	And Clicks on view complete menu tab
	And User clicks on Promotional Actions Per Scenario
	And Opens a promo 'EC86171'
	And User goes back

	When User clicks on the tools tab to go to menu page
	And Clicks on view complete menu tab
	When User clicks on Child promo holders
	And Clicks on the gear icon
	Then Dropdown list should appear
	When User selects the columns option
	And User selects visible tab
	And User makes sure that all columns are selected
	And User clicks on the Ok button
	And User double checks if all visible checkboxes are ticked
	And User clicks on visible column ok button

	And User clicks on links
	And User selects 'Customer Master' link
	And User goes back
	
	And User clicks on links
	And User selects 'Promotional actions' link
	And User goes back

	When Clicks on the tools tab
	And Clicks on view complete menu tab
	And User clicks on anomaly report 
	And Clicks on the gear icon
	Then Dropdown list should appear
	When User selects the columns option
	And User selects visible tab
	And User makes sure that all columns are selected
	And User clicks on the Ok button
	And User double checks if all visible checkboxes are ticked
	And User clicks on visible column ok button
	And User selects a row 
	Then User selects Open Detail



