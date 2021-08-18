Feature: GCM Core with git clone

  Scenario: Clone a public GitHub repository
    Given a user with the configuration:
      | config     | value            |
      | user.name  | Test User        |
      | user.email | test@example.com |
    When the user clones https://github.com/microsoft/Git-Credential-Manager-Core.git
    Then the repository is cloned