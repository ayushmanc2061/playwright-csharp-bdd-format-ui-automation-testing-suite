Feature: NavbarValidation

This feature contains tests related to the navigation bar menu
Scenario: Admin user login to the platform and verifies all the navbar items that he is authorized to see
	Given "[ADMIN_EMAIL_ADDRESS]@gmail.com" logs in to the platform
	When When the navbar appears
	And "Dashboard" is appearing in the navbar	
	And "Deal analytics" is appearing in the navbar	
	And "Companies" is appearing in the navbar	
	And "Offers" is appearing in the navbar
	And "Investor profiles" is appearing in the navbar	
	And "Meetings" is appearing in the navbar		

Scenario: Issuer user login to the platform and verifies all the navbar items that he is authorized to see
	Given "[ISSUER_EMAIL_ADDRESS]@gmail.com" logs in to the platform
	When When the navbar appears
	And "Dashboard" is appearing in the navbar
	And "My company" is appearing in the navbar
	And "Merger and acquisitions" is appearing in the navbar
	And "Matchmaking" is appearing in the navbar
	And "Data rooms" is appearing in the navbar
	And "Document access" is appearing in the navbar
	And "Meetings" is appearing in the navbar
	And "Auction management" is appearing in the navbar
	And "Offers" is appearing in the sub menu of "Auction management" in the navbar
	And "Flags" is appearing in the sub menu of "Auction management" in the navbar
	And "Tranches" is appearing in the sub menu of "Auction management" in the navbar
	And "Interest" is appearing in the navbar
	And "Secondary" is appearing in the sub menu of "Auction management" in the navbar
	And "Private" is appearing in the sub menu of "Auction management" in the navbar
	And "Forms" is appearing in the navbar
	And "Questionnaires" is appearing in the sub menu of "Forms" in the navbar
	And "Forms" is appearing in the sub menu of "Forms" in the navbar
	And "User management" is appearing in the navbar
	And "Referrals" is appearing in the sub menu of "User management" in the navbar
	And "Refer an investor" is appearing in the sub menu of "User management" in the navbar


Scenario: Private investor user login to the platform and verifies all the navbar items that he is authorized to see
	Given "[INVESTOR_EMAIL_ADDRESS]@gmail.com" logs in to the platform
	When When the navbar appears
	And "Home" is appearing in the navbar
	And "Companies" is appearing in the navbar
	And "Companies" is appearing in the sub menu of "Companies" in the navbar
	And "Offers" is appearing in the sub menu of "Companies" in the navbar
	And "Meetings" is appearing in the sub menu of "Companies" in the navbar
	And "Investors" is appearing in the navbar
	And "My invitations" is appearing in the sub menu of "Investors" in the navbar
	And "Referrals" is appearing in the sub menu of "Investors" in the navbar
	And "Refer an investor" is appearing in the sub menu of "Investors" in the navbar

