-- ---------------------------------------------------------
-- More Sample Employees Seed Data
-- Purpose: Inserts additional employee records to populate the database for testing and demo scenarios
-- ---------------------------------------------------------

-- Ensure all operations run against the onboarding schema
SET search_path TO onboarding;

-- Insert multiple sample employee records
INSERT INTO employees (first_name, last_name, personal_email, start_date, department, job_title) VALUES
('Daniel', 'Rivera', 'daniel.rivera@gmail.com', '2025-01-08', 'Information Technology', 'IT Support Specialist'),
('Alyssa', 'Chen', 'alyssa.chen@yahoo.com', '2024-11-18', 'Human Resources', 'HR Coordinator'),
('Marcus', 'Thompson', 'marcus.thompson@outlook.com', '2025-02-03', 'Finance', 'Financial Analyst'),
('Sofia', 'Martinez', 'sofia.martinez@gmail.com', '2024-09-30', 'Operations', 'Operations Manager'),
('Jordan', 'Patel', 'jordan.patel@gmail.com', '2025-01-22', 'Marketing', 'Digital Marketing Specialist');
