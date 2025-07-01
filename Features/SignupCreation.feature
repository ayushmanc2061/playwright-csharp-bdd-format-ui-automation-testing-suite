Feature: SignupCreation

A short summary of the feature

@LoginRequired
Scenario: Creating signups for the organisations of type Admin, Advisor, Advocate, Issuer, Institutional investor and Private investor that were created in Scenario 1 
	Given User navigates to the signup management page 
	When User clicks on Create user button and then enters organisation name and type and click on save button
	| organisationType       | Role              | FirstName			| LastName |
	| Advisor                | Advisor corporate | Adv					| isor     |
	| Advocate               | Advocate          | Advo				    | cate     |
	| Issuer                 | Issuer            | Iss					| user     |
	| Admin                  | Administrator     | Adm					| in       |
	| Institutional Investor | Bidder            | Institutional	    | investor |
	| Private Investor       | Bidder            | Private				| investor |
	Then The signup is created successfully