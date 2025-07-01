# BDD UI Automation Tests using Playwright in C\# with XUNIT

## Overview
This automation testing suite designed to perform end-to-end testing for a web application. Built with **Playwright** in **C#** and the **XUnit** testing framework, this project utilizes **Behavior-Driven Development (BDD)** with **Gherkin** syntax through the **SpecFlow** library in **DotNet**. The suite implements the **Page Object Model (POM)** design pattern, ensuring maintainability and scalability of the test codebase.

The testing suite validates critical functionalities of a web platform, including:
- **User Login**: Verifying successful authentication with valid credentials.
- **Navigation Bar Validation**: Ensuring correct menu items are displayed for different user roles (Admin, Issuer, Private Investor).
- **Signup Creation**: Testing the creation of user signups for various types.

This project serves as a showcase of my expertise in designing and implementing scalable automation testing frameworks and is hosted on my public GitHub repository as part of my portfolio.

---

## Project Structure
The project is organized into logical directories and files, each with a specific role in the testing framework:

```
UIAutomationTests/
├── Config/                     # Configuration files
├── Drivers/                    # Playwright driver setup
├── Features/                   # Gherkin feature files defining test scenarios
│   ├── Login.feature           # Tests login functionality
│   ├── NavbarValidation.feature# Tests navigation bar for different roles
│   ├── SignupCreation.feature  # Tests signup creation for organization types
├── Hooks/                      # SpecFlow hooks for setup and teardown
│   ├── LoginHook.cs            # Hook for login before specific scenarios
├── Pages/                      # Page Object Model classes for web pages
│   ├── CreateUserPage.cs       # Manages signup creation page interactions
│   ├── IndexPage.cs            # Manages index page interactions
│   ├── LoginPage.cs            # Manages login page interactions
│   ├── Navbar.cs               # Manages navigation bar interactions
│   ├── OrganisationPage.cs     # Manages organization-related pages
├── StepDefinitions/            # Implementations of Gherkin steps
│   ├── LoginStepDefinitions.cs # Steps for login feature
│   ├── NavbarValidationStepDefinitions.cs # Steps for navbar validation
│   ├── SignupCreationStepDefinitions.cs  # Steps for signup creation
├── appsettings.json            # Configuration settings
├── ImplicitUsings.cs           # Implicit usings for the project
└── UIAutomationTests.csproj    # Project file
```

### Key Components
1. **Features/**: Gherkin `.feature` files written in BDD style written in Given, When, Then, And human readable style.
   - `Login.feature`: Tests login with valid credentials.
   - `NavbarValidation.feature`: Validates navigation bar items for Admin, Issuer, and Private Investor roles.
   - `SignupCreation.feature`: Tests signup creation for multiple organization types.

2. **Hooks/**: SpecFlow hooks for scenario setup.
   - `LoginHook.cs`: Implements a `@LoginRequired` tag to handle login before applicable scenarios.

3. **Pages/**: Implements the Page Object Model for maintainable test code. Each class containing UI locators of that page and reusable functions.
   - `CreateUserPage.cs`: Handles signup creation page interactions.
   - `LoginPage.cs`: Manages login page actions and verifications.
   - `Navbar.cs`: Validates navigation bar behavior across user roles.

4. **StepDefinitions/**: C# implementations of defined scenarios in the feature files.
   - `LoginStepDefinitions.cs`: Defines login scenario steps.
   - `NavbarValidationStepDefinitions.cs`: Defines navbar validation steps.
   - `SignupCreationStepDefinitions.cs`: Defines signup creation steps.

5. **Configuration**: Uses `appsettings.json` and user secrets for managing sensitive data like credentials and URLs.

---

## Features and Scenarios

### 1. Login Feature
**File**: `Login.feature`  
Tests the login functionality of the web platform.

**Scenario**: Logging in with valid credentials  
```
Scenario: Logging in to platform with a valid username and password
    Given We navigate to the login page
    And We click on accept consent button
    And We enter username and password and click on Login button
    Then User is logged into dashboard
```

### 2. Navbar Validation Feature
**File**: `NavbarValidation.feature`  
Validates navigation bar items for different user roles.

#### Scenario 1: Admin User Navbar Validation
```
Scenario: Admin user login to the platform and verifies all the navbar items that he is authorized to see
    Given "[ADMIN_EMAIL_ADDRESS]@gmail.com" logs in to the platform
    When When the navbar appears
    And "Dashboard" is appearing in the navbar
    And "Deal analytics" is appearing in the navbar
    And "Companies" is appearing in the navbar
    And "Offers"is appearing in the navbar
    And "Investor profiles" is appearing in the navbar
    And "Meetings" is appearing in the navbar
```

#### Scenario 2: Issuer User Navbar Validation
```
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
```

#### Scenario 3: Private Investor User Navbar Validation
```
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
```

### 3. Signup Creation Feature
**File**: `SignupCreation.feature`  
Tests signup creation for various organization types.

**Scenario**: Creating signups for different organization types  
```
Scenario: Creating signups for the organisations of type Admin, Advisor, Advocate, Issuer, Institutional investor and Private investor
    Given User navigates to the signup management page
    When User clicks on Create user button and then enters organisation name and type and click on save button
        | organisationType       | Role              | FirstName    | LastName  |
        | Advisor                | Advisor corporate | Adv          | isor      |
        | Advocate               | Advocate          | Advo         | cate      |
        | Issuer                 | Issuer            | Iss          | user      |
        | Admin                  | Administrator     | Adm          | in        |
        | Institutional Investor | Bidder            | Institutional| investor  |
        | Private Investor       | Bidder            | Private      | investor  |
    Then The signup is created successfully
```

---

## Technologies Used
- **Playwright**: Browser automation for end-to-end testing.
- **C#**: Core programming language for test scripts.
- **XUnit**: Framework for running and asserting tests.
- **SpecFlow**: Enables BDD with Gherkin syntax.
- **Page Object Model (POM)**: Design pattern for maintainable test code.
- **Microsoft.Extensions.Configuration**: Manages sensitive data via user secrets.

---

## Key Features and Highlights
- **BDD with Gherkin**: Human-readable test scenarios for technical and non-technical stakeholders.
- **Page Object Model**: Organized, reusable code for web interactions.
- **Role-Based Testing**: Validates UI behavior for multiple user roles.
- **SpecFlow Hooks**: Automates setup tasks like login with `@LoginRequired`.
- **Secure Configuration**: Uses user secrets for sensitive data management.

---

## Contact
For questions or feedback, reach out to me:  
- **GitHub**: [EhtashamAhmed](https://github.com/EhtashamAhmed)
- **LinkedIn**: [Ehtasham Ahmad](https://www.linkedin.com/in/ehtasham-ahmad-b76807151/)  
- **Email**: [ehtashamahmedea@gmail.com](mailto:[ehtashamahmedea@gmail.com])

---

This project highlights my skills in automation testing and framework design. I hope you find it a valuable addition to my portfolio!