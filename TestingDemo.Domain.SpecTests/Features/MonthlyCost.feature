Feature: Monthly Cost
	In order to know how much a raise will impact my budget
	As a Human Resource employee
	I want to know the monthly cost of an employee

Scenario: The employee only has a salary
	Given I have an employee with a salary of 1000 euros
	When I view his cost
	Then the cost is 1399.67 euros
