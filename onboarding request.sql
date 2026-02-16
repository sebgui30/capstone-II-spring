-- ---------------------------------------------------------
-- Sample Onboarding Request Seed Data
-- Purpose: Creates an onboarding request to demonstrate the HR -> Manager -> IT workflow
-- ---------------------------------------------------------

-- Ensure all operations run against the onboarding schema
SET search_path TO onboarding;

-- Insert a sample onboarding request
INSERT INTO onboarding_requests (
  employee_id,
  created_by_user_id,
  manager_user_id,
  status_id,
  notes
)
VALUES (
  (SELECT employee_id FROM employees ORDER BY employee_id DESC LIMIT 1),
  (SELECT user_id FROM users WHERE email='hannah.hr@company.com'),
  (SELECT user_id FROM users WHERE email='mike.manager@company.com'),
  (SELECT status_id FROM onboarding_request_statuses WHERE status_code='PENDING_APPROVAL'),
  'New hire onboarding request created by HR.'
)
RETURNING request_id;
