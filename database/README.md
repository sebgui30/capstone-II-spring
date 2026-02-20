# Database – Employee Onboarding & IT Access Management Portal

## Overview
This Section contains all SQL scripts used to create, seed, and populate the PostgreSQL database for the Employee Onboarding & IT Access Management Portal.

The database supports a role based onboarding workflow where:

HR creates onboarding requests for new hires

Managers approve or reject requests

IT completes required setup tasks

The database focuses on data structure, relationships, and integrity, while business logic and role enforcement are handled by the backend API.

## Database Technology

Database: PostgreSQL  
Schema: onboarding  

All tables and data are created under the onboarding schema to keep the database organized.

## File Descriptions:

schema.sql = Creates the core database structure.

Includes:
roles
users
employees
onboarding_requests
onboarding_request_statuses
it_tasks
it_task_statuses
Primary keys
Foreign key relationships
Indexes for performance

This file must be run first.

statuses.sql= Seeds all valid status values used in the system.

Includes:
Onboarding request statuses (Pending Approval, Approved, Rejected, etc.)
IT task statuses (Open, In Progress, Completed, etc.)
Uses lookup tables to ensure consistent status tracking and prevent invalid values.




users.sql=Seeds core system roles and sample users.

Includes:
Roles: HR, Manager, IT, Admin

Sample users for testing workflows:
HR user
Manager user
IT user

These users simulate real system access during demos and testing.




Sample_Employee.sql= Inserts an initial sample employee record.

Purpose:Provides a base employee to test onboarding request creation, also useful for early workflow testing.


More_sample_Employees.sql =Adds additional employee records to populate the system.

Purpose:
Makes the database more realistic for demos it also allows testing onboarding across multiple departments and job roles.


onboarding_request.sql = Creates a sample onboarding request.

Purpose: Demonstrates the HR ,Manager, and IT workflow. Links an employee to an onboarding request and sets the initial status to Pending Approval.


IT_Tasks.sql = Seeds sample IT tasks linked to the most recent onboarding request.

Includes:
Email account creation
Laptop provisioning

Also contains optional verification queries to confirm that tasks and relationships were inserted correctly.


## Recommended Execution Order
When setting up the database from scratch, run the scripts in this order:
schema.sql
statuses.sql
users.sql
Sample_Employee.sql
More_sample_Employees.sql
onboarding_request.sql
IT_Tasks.sql

## Workflow Support
The database supports the following process:
HR creates an onboarding request for a new employee.
The request enters Pending Approval.
A Manager approves or rejects the request.
Approved requests generate IT tasks.
IT completes tasks and updates task statuses.
The onboarding request is marked Completed.

Foreign key constraints ensure that:
Requests cannot exist without employees
Tasks cannot exist without onboarding requests
Status values are always valid

## Notes
Role based permissions are enforced by the backend API (FastAPI), not directly by SQL.

This database is designed for clarity and demo purposes, not production deployment.

Sample data is included to support testing and live demonstrations
