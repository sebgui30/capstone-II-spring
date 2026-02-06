-- =========================================================
-- File:statuses.sql
-- Project: Employee Onboarding & IT Access Management Portal
-- Description: Seeds default status values used to track onboarding requests and IT tasks.
-- =========================================================

-- Set the active schema for all operations in this file

SET search_path TO onboarding;

-- ---------------------------------------------------------
-- Cleanup Existing Seed Data
-- Purpose: Removes old placeholder data to prevent duplicate status entries when reseeding
-- ---------------------------------------------------------

TRUNCATE onboarding_request_statuses RESTART IDENTITY CASCADE;
TRUNCATE it_task_statuses RESTART IDENTITY CASCADE;

-- =========================================================
-- Onboarding Request Statuses
-- Purpose: Tracks the status flow of an employee onboarding request from submission to completion
-- =========================================================

INSERT INTO onboarding_request_statuses (status_code, status_label, description) VALUES
('PENDING_APPROVAL', 'Pending Approval', 'The onboarding request has been submitted and is waiting for approval.'),
('APPROVED', 'Approved', 'The request has been approved and is ready for IT action.'),
('REJECTED', 'Rejected', 'The request was denied and will not move forward.'),
('IN_PROGRESS', 'In Progress', 'The onboarding setup is currently being worked on.'),
('ON_HOLD', 'On Hold', 'The onboarding process is paused due to missing info or dependencies.'),
('COMPLETED', 'Completed', 'All onboarding steps have been finished successfully.'),
('CANCELLED', 'Cancelled', 'The onboarding request was stopped before completion.');

-- =========================================================
-- IT Task Statuses
-- Purpose: Tracks the progress of individual IT tasks required to support onboarding
-- =========================================================

INSERT INTO it_task_statuses (status_code, status_label, description) VALUES
('OPEN', 'Open', 'The task has been created but work has not started yet.'),
('IN_PROGRESS', 'In Progress', 'The task is currently being worked on.'),
('WAITING_ON_USER', 'Waiting on User', 'The task is paused while waiting for user input or confirmation.'),
('WAITING_ON_THIRD_PARTY', 'Waiting on Third Party', 'The task is blocked by an external vendor or system.'),
('ON_HOLD', 'On Hold', 'The task is temporarily paused for internal reasons.'),
('COMPLETED', 'Completed', 'The task has been finished and verified.'),
('CLOSED', 'Closed', 'The task is completed and formally closed in the system.'),
('CANCELLED', 'Cancelled', 'The task was stopped and will not be completed.');