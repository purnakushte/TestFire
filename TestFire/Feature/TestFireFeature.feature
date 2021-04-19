Feature: TestFireFeature
	In order to see Sign Out Sucessfull
	As a User
	I want to be able to navigate to TestFire Website


@SignOutSucessfull
Scenario: Verify that 2 accounts are visible under Account Details
	Given I navigate to	testfire
	When I click on Online Banking Login
	And I enter the valid user details
	And I can see 2 accounts are visible under Account Details
	And I click on Signoff
	Then I signoff sucessfully
