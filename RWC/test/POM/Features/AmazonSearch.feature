Feature: As a user I can enter in the search term “qa testing” in the search box and see
the results of that search on the search results page

@mytag
Scenario: Search term
	Given I open Amazon.com
	And I introduce the term qa testing
	When I perform the search
	Then I see the results in the search page