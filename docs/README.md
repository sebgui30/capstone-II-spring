# Employee Onboarding and IT Access Management

A desktop-based application designed to streamline and track the employee onboarding process across HR, Management, and IT departments.

## Description

The Employee Onboarding and IT Access Management System is a desktop application designed to streamline and track the employee onboarding process across HR, Management, and IT departments. Organizations often struggle with the timely passage of information between the different departments when onboarding a new employee. There is no defined onboarding progress tracker, leaving certain onboarding tasks to be delayed or forgotten. This becomes an issue when the new employee must begin their role and does not have proper access. Our solution facilitates the transfer of onboarding information between all departments involved via onboarding forms, manager review forms, IT provisioning forms, and an onboarding status tracker. By hosting the information in one application, it is easier for the responsible departments to review onboarding progress and complete the necessary onboarding tasks. The application improves efficiency of employee onboarding, ensuring that new hires get started in their role faster.

## Built With

- Microsoft Windows Forms (WinForms)
- C# (.NET)
- PostgreSQL

## Getting Started
### Dependencies 

- Windows 10 or later
- Microsoft Visual Studio with .NET Desktop Development workload
- PostgreSQL (v13 or later recommended)

### Installation

1. Clone the repo.
   ```bash
   git clone https://github.com/sebgui30/capstone-II-spring.git
   cd capstone-II-spring
   ```
2. Set up the database.
3. Configure the connection string.
4. Restore dependencies.

### Run with Visual Studio

1. Open the solution file (OnboardingAPI.sln).
2. Set the main WinForms project as Startup Project.
3. Click Start.

### Step-by-Step Workflow

1. Launch the application.
2. Choose a role to login.
3. Based on the role:
     - HR: Creates onboarding requests.
     - Manager: Reviews onboarding requests to approve or reject.
     - IT: Provisions IT access.
5. Track onboarding status in the dashboard.

## Future Considerations Roadmap

- Automatic email notifications for status changes.
- Dashboard analytics for each role.
- Migration to a web-based and mobile application.
- Integration with Active Directory.

## Contributers

Horacio Andrade, Amber Garcia, Sebastien Guillen, Ana Gutierrez, Jerry Symbleme 

## Acknowledgements

Knight Foundation School of Computing and Information Sciences (KFSCIS) — Florida International University
Instructor: Masoud Sadjadi | Spring 2026 


## License

[MIT](https://choosealicense.com/licenses/mit/)
