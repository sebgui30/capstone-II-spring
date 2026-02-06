-- ---------------------------------------------------------
-- First Sample Employee Seed Data
-- Purpose: Inserts a test employee record to support onboarding request and workflow testing
-- ---------------------------------------------------------

-- Ensure all operations run against the onboarding schema
SET search_path TO onboarding;

-- Insert a sample employee record
INSERT INTO employees (first_name, last_name, personal_email, start_date, department, job_title)
VALUES ('John', 'Doe', 'john.doe@gmail.com', '2026-02-10', 'IT', 'Junior Analyst')
RETURNING employee_id;
