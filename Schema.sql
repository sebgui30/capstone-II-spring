-- =========================================================
-- File: schema.sql
-- Project: Employee Onboarding & IT Access Management Portal
-- Description: Creates the onboarding schema, core tables,lookup/status tables, relationships, and indexes.
-- =========================================================

-- ---------------------------------------------------------
-- Schema Setup
-- Purpose: Keeps all onboarding portal objects organized
-- ---------------------------------------------------------
CREATE SCHEMA IF NOT EXISTS onboarding;
SET search_path TO onboarding;

-- ---------------------------------------------------------
-- Table: roles
-- Purpose: Defines system roles (HR, Manager, IT, Admin)
-- ---------------------------------------------------------
CREATE TABLE roles (
  role_id SERIAL PRIMARY KEY,
  role_name VARCHAR(50) UNIQUE NOT NULL
);

-- ---------------------------------------------------------
-- Table: users
-- Purpose: Stores system user accounts tied to a role
-- ---------------------------------------------------------
CREATE TABLE users (
  user_id SERIAL PRIMARY KEY,
  full_name VARCHAR(120) NOT NULL,
  email VARCHAR(255) UNIQUE NOT NULL,
  role_id INT NOT NULL REFERENCES roles(role_id),
  is_active BOOLEAN NOT NULL DEFAULT TRUE,
  created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- ---------------------------------------------------------
-- Table: employees
-- Purpose: Stores employees being onboarded
-- Note: These are the new hires, not system accounts
-- ---------------------------------------------------------
CREATE TABLE employees (
  employee_id SERIAL PRIMARY KEY,
  first_name VARCHAR(60) NOT NULL,
  last_name VARCHAR(60) NOT NULL,
  personal_email VARCHAR(255),
  start_date DATE,
  department VARCHAR(80),
  job_title VARCHAR(80),
  created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- ---------------------------------------------------------
-- Table: onboarding_request_statuses (lookup)
-- Purpose: Defines valid status values for onboarding requests
-- ---------------------------------------------------------
CREATE TABLE onboarding_request_statuses (
  status_id SERIAL PRIMARY KEY,
  status_code VARCHAR(40) UNIQUE NOT NULL,
  status_label VARCHAR(80) NOT NULL,
  description VARCHAR(255)
);

-- ---------------------------------------------------------
-- Table: onboarding_requests
-- Purpose: Represents an onboarding request (the main workflow record)
-- ---------------------------------------------------------
CREATE TABLE onboarding_requests (
  request_id SERIAL PRIMARY KEY,
  employee_id INT NOT NULL REFERENCES employees(employee_id),
  created_by_user_id INT NOT NULL REFERENCES users(user_id),
  manager_user_id INT REFERENCES users(user_id),
  status_id INT NOT NULL REFERENCES onboarding_request_statuses(status_id),
  notes TEXT,
  created_at TIMESTAMP NOT NULL DEFAULT NOW(),
  updated_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- ---------------------------------------------------------
-- Table: it_task_statuses (lookup)
-- Purpose: Defines valid status values for IT tasks
-- ---------------------------------------------------------
CREATE TABLE it_task_statuses (
  status_id SERIAL PRIMARY KEY,
  status_code VARCHAR(40) UNIQUE NOT NULL,
  status_label VARCHAR(80) NOT NULL,
  description VARCHAR(255)
);

-- ---------------------------------------------------------
-- Table: it_tasks
-- Purpose: Stores IT work items required for onboarding
-- Notes: Each task is tied to an onboarding request
--  - Tasks are deleted automatically if the request is deleted
-- ---------------------------------------------------------
CREATE TABLE it_tasks (
  task_id SERIAL PRIMARY KEY,
  request_id INT NOT NULL REFERENCES onboarding_requests(request_id) ON DELETE CASCADE,
  assigned_to_user_id INT REFERENCES users(user_id),
  task_type VARCHAR(60) NOT NULL,
  details TEXT,
  status_id INT NOT NULL REFERENCES it_task_statuses(status_id),
  due_date DATE,
  created_at TIMESTAMP NOT NULL DEFAULT NOW(),
  updated_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- ---------------------------------------------------------
-- Indexes
-- Purpose: Improves query performance for common filters/joins
-- ---------------------------------------------------------
CREATE INDEX idx_requests_employee_id ON onboarding_requests(employee_id);
CREATE INDEX idx_requests_status_id ON onboarding_requests(status_id);
CREATE INDEX idx_tasks_request_id ON it_tasks(request_id);
CREATE INDEX idx_tasks_status_id ON it_tasks(status_id);
