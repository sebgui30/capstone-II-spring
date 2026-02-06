-- ---------------------------------------------------------
-- Sample IT Tasks Seed Data
-- Purpose: Creates sample IT tasks linked to the most recent onboarding request for demo/testing
-- ---------------------------------------------------------

-- Ensure all operations run against the onboarding schema
SET search_path TO onboarding;

-- Insert sample IT tasks tied to the latest onboarding request
INSERT INTO it_tasks (
  request_id,
  assigned_to_user_id,
  task_type,
  details,
  status_id,
  due_date
)
VALUES
(
  (SELECT request_id FROM onboarding_requests ORDER BY request_id DESC LIMIT 1),
  (SELECT user_id FROM users WHERE email='ivan.it@company.com'),
  'Create Email Account',
  'Create company email and add to required groups.',
  (SELECT status_id FROM it_task_statuses WHERE status_code='OPEN'),
  '2026-02-07'
),
(
  (SELECT request_id FROM onboarding_requests ORDER BY request_id DESC LIMIT 1),
  (SELECT user_id FROM users WHERE email='ivan.it@company.com'),
  'Laptop Provisioning',
  'Prepare laptop, install software, and configure security.',
  (SELECT status_id FROM it_task_statuses WHERE status_code='OPEN'),
  '2026-02-08'
);



-- =========================================================
-- Verification Queries (Optional)
-- Purpose: Quick checks to confirm seed data was inserted
-- Note: Safe to keep for development; remove for production
-- =========================================================

SET search_path TO onboarding;

-- Show onboarding requests with employee name, request status, and creator
SELECT r.request_id,
       e.first_name || ' ' || e.last_name AS employee,
       ors.status_label AS request_status,
       u.full_name AS created_by
FROM onboarding_requests r
JOIN employees e ON e.employee_id = r.employee_id
JOIN onboarding_request_statuses ors ON ors.status_id = r.status_id
JOIN users u ON u.user_id = r.created_by_user_id;

-- Show IT tasks linked to onboarding requests with current status and assignee
SELECT t.task_id,
       t.task_type,
       its.status_label AS task_status,
       u.full_name AS assigned_to,
       t.due_date
FROM it_tasks t
JOIN it_task_statuses its ON its.status_id = t.status_id
JOIN users u ON u.user_id = t.assigned_to_user_id;
