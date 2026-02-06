-- ---------------------------------------------------------
-- Sample Roles & Users Seed Data
-- Purpose: Ensures core system roles exist and inserts sample user accounts for testing workflows
-- ---------------------------------------------------------

-- Ensure all operations run against the onboarding schema
SET search_path TO onboarding;

-- ---------------------------------------------------------
-- Seed Roles
-- Purpose: Creates required system roles if they do not already exist
-- ---------------------------------------------------------
INSERT INTO roles (role_name) VALUES
('HR'), ('Manager'), ('IT'), ('Admin')
ON CONFLICT DO NOTHING;

-- ---------------------------------------------------------
-- Seed Users
-- Purpose: Adds sample system users mapped to roles
-- Notes: role_id values are resolved dynamically
--  - email uniqueness prevents duplicate users
-- ---------------------------------------------------------
INSERT INTO users (full_name, email, role_id) VALUES
('Hannah HR', 'hannah.hr@company.com', (SELECT role_id FROM roles WHERE role_name='HR')),
('Mike Manager', 'mike.manager@company.com', (SELECT role_id FROM roles WHERE role_name='Manager')),
('Ivan IT', 'ivan.it@company.com', (SELECT role_id FROM roles WHERE role_name='IT'))
ON CONFLICT (email) DO NOTHING;

