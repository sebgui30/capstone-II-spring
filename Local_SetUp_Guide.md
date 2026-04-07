# Local Development Setup Guide

## Overview
This project is a VB.NET Windows Forms application connected to a PostgreSQL database. It supports three roles:

- HR
- Manager
- IT

The application allows:
- HR to create onboarding requests
- Managers to approve or reject requests
- IT to view approved requests and review request details

At the moment, the application is configured to use a **local PostgreSQL database** on each teammate’s computer.

---

## Important Note
This project currently uses:

- **Host:** `localhost`
- **Port:** `5432`
- **Database:** `onboarding_portal`

Each teammate must:
- Install PostgreSQL locally
- Create the database locally
- Run SQL setup files
- Update the connection string password

This is **not** using a shared cloud database yet.

---

## Technologies Used
- VB.NET (Windows Forms)
- PostgreSQL
- pgAdmin
- Npgsql
- Visual Studio

---

## Before You Start
Make sure you have:

- Visual Studio
- PostgreSQL
- pgAdmin
- Git
- Access to the GitHub repo

---

## Step 1 - Get the Project

### Clone the repository

```bash
git clone https://github.com/sebgui30/capstone-II-spring.git
cd capstone-II-spring
```


 updating a previous version 
```bash
git pull
```

## Step 2 - Install PostgreSQL

Download PostgreSQL  
Run the installer  

During installation remember:
- Host: localhost  
- Port: 5432  
- Username: postgres  
- Password: (choose your own and remember it)  

Make sure pgAdmin is installed  

---

**Important**

Do NOT forget your PostgreSQL password, You will need it later  

---

## Step 3 - Open pgAdmin and Connect

- Open pgAdmin  
- Expand your PostgreSQL server  
- Enter your password if prompted  
- And connect  

---

## Step 4 - Create the Database

In pgAdmin:
- Right click Databases  
- Click Create — > Database  
- Name it: onboarding_portal  
- Then Click Save  

---

## Step 5 - Run SQL Files **IN ORDER**

Run these files in this exact order:

- schema.sql  
- statuses.sql  
- users.sql  
- Sample_Employee.sql  
- More_sample_Employees.sql  
- onboarding_request.sql  
- IT_Tasks.sql  

**How to run each file**:

- Open file  
- Copy SQL  
- Open Query Tool in pgAdmin  
- Paste  
- Click Execute  

**DO NOT change the order**

---

## Step 6 - Verify Database

After running all SQL files, you need to confirm the database was set up correctly.

### How to run the verification query

1. Open **pgAdmin**
2. Expand:
   - Servers
   - PostgreSQL
   - Databases
3. Click on the database: onboarding_portal
4. Click the **Query Tool** button  

---

### Copy and paste this query:

```sql
SELECT 
 r.request_id,
 e.first_name,
 e.last_name,
 e.department,
 s.status_code
FROM onboarding.onboarding_requests r
JOIN onboarding.employees e 
 ON r.employee_id = e.employee_id
JOIN onboarding.onboarding_request_statuses s 
 ON r.status_id = s.status_id
ORDER BY r.request_id;
```

Click Execute query  

## Expected Result

You should see rows with:
- Employee names  
- Departments  
- Status values:
  - APPROVED  
  - REJECTED  
  - PENDING_APPROVAL  

---

## Step 7 - Open Project

- Open Visual Studio  
- Open solution file  
- Wait for everything to load  

---

## Step 8 - Restore NuGet Packages

- Right click solution  
- Click Restore NuGet Packages  

---

## Step 9 - Update Connection String

- What connection string would look like:

```bash

“Host=localhost;Port=5432;Username=postgres;Password=YOUR_PASSWORD;Database=onboarding_portal”
```
- Replace this password with what you wrote as you password

- What it looks like:
```bash
“Password=YOUR_PASSWORD”
```
## Important

**Do NOT change these unless your setup is different**:
- Host=localhost  
- Port=5432  
- Username=postgres  
- Database=onboarding_portal

## Update ALL connection strings

You must update the password in every file that connects to the database.

Here a shortcut for Visual Studio:

In Visual Studio press these commands:

- Ctrl + Shift + F

after That type in the search bar for 

- “Host=localhost”

Then just replace the password for every result that pops up  

---

## Common files to check:

- HRDashboardService.vb  
- RequestDetailsService.vb  
- frmManagerDashboard.vb  
- frmITdashboard.vb  

---

## Important

If even ONE file has the wrong password:
- That part of the app will fail  
- Some dashboards may work while others don’t  

—

---

## Step 10 - Build Project

Press the following commands:

“Ctrl + Shift + B”

 Expected Result no errors and the build succeeds  

---

## Step 11 - Run Application

- Press Start  
- test each dashboard  

Note:

For IT Dashboard and Manager Dashboard you must double click the name of the employee to view task details  

---

## Step 12 - Verify Data Was Saved to PostgreSQL

After creating a new onboarding request in the HR dashboard, you need to confirm that the data was saved to the database.

---

### Step-by-step verification

1. Go back to **pgAdmin**
2. Expand:
   - Servers
   - PostgreSQL
   - Databases
3. Click on: onboarding_portal
4. Click the **Query Tool** button

---

### Run the verification query

Copy and paste the following:

```sql
SELECT 
 r.request_id,
 e.first_name,
 e.last_name,
 e.department,
 s.status_code
FROM onboarding.onboarding_requests r
JOIN onboarding.employees e 
 ON r.employee_id = e.employee_id
JOIN onboarding.onboarding_request_statuses s 
 ON r.status_id = s.status_id
ORDER BY r.request_id;
```


Click the Execute query button  

## What you should see

- A new row at the bottom (depending on order)  
- The new employee you just created in the app  
- The correct department and status  

---

## Notes

- Local setup only  
- No shared database yet  
- Some old in-memory files may exist but are unused

