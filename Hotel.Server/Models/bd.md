# Hotel Management System Database Documentation

This document provides an overview of the database schema for the Hotel Management System. The database is designed using Entity Framework Core (Code-First Approach) and ASP.NET Core Identity for user management.

## Table of Contents

1. [Overview](#overview)
2. [Tables and Columns](#tables-and-columns)
   - [AspNetUsers](#aspnetusers)
   - [Guests](#guests)
   - [GuestPreferences](#guestpreferences)
   - [Feedbacks](#feedbacks)
   - [Employees](#employees)
   - [ShiftAssignments](#shiftassignments)
   - [Rooms](#rooms)
   - [RoomTypes](#roomtypes)
   - [Bookings](#bookings)
   - [Payments](#payments)
   - [Events](#events)
   - [EventSpaces](#eventspaces)
   - [HousekeepingTasks](#housekeepingtasks)
   - [MaintenanceRequests](#maintenancerequests)
3. [Relationships](#relationships)

## Overview

The database schema consists of tables that manage user information, guest and employee profiles, room and event management, housekeeping, maintenance, and financial transactions. The schema leverages ASP.NET Core Identity for user management and implements various roles with specific permissions.

## Tables and Columns

### AspNetUsers

Stores user information managed by ASP.NET Core Identity.

- **Id**: `NVARCHAR(450)` - Primary Key
- **UserName**: `NVARCHAR(256)` - User's username
- **NormalizedUserName**: `NVARCHAR(256)` - Normalized username for indexing
- **Email**: `NVARCHAR(256)` - User's email
- **NormalizedEmail**: `NVARCHAR(256)` - Normalized email for indexing
- **EmailConfirmed**: `BIT` - Indicates if the email is confirmed
- **PasswordHash**: `NVARCHAR(MAX)` - Password hash
- **SecurityStamp**: `NVARCHAR(MAX)` - Security stamp used for password reset
- **ConcurrencyStamp**: `NVARCHAR(MAX)` - Used for concurrency control
- **PhoneNumber**: `NVARCHAR(MAX)` - User's phone number
- **PhoneNumberConfirmed**: `BIT` - Indicates if the phone number is confirmed
- **TwoFactorEnabled**: `BIT` - Indicates if two-factor authentication is enabled
- **LockoutEnd**: `DATETIMEOFFSET` - Lockout end date and time
- **LockoutEnabled**: `BIT` - Indicates if lockout is enabled
- **AccessFailedCount**: `INT` - Number of failed access attempts
- **FullName**: `NVARCHAR(256)` - Full name of the user
- **DateOfBirth**: `DATE` - Date of birth of the user
- **Address**: `NVARCHAR(256)` - Address of the user
- **Gender**: `NVARCHAR(10)` - Gender of the user
- **RegisteredOn**: `DATETIME` - Registration date
- **LastLogin**: `DATETIME` - Last login date

### Guests

Stores information specific to hotel guests.

- **Id**: `INT` - Primary Key
- **UserId**: `NVARCHAR(450)` - Foreign Key to `AspNetUsers(Id)`

### GuestPreferences

Stores preferences of guests.

- **Id**: `INT` - Primary Key
- **GuestId**: `INT` - Foreign Key to `Guests(Id)`
- **PreferenceType**: `NVARCHAR(100)` - Type of preference
- **Description**: `NVARCHAR(256)` - Description of the preference

### Feedbacks

Stores guest feedback and ratings.

- **Id**: `INT` - Primary Key
- **GuestId**: `INT` - Foreign Key to `Guests(Id)`
- **Comments**: `NVARCHAR(500)` - Guest comments
- **Rating**: `INT` - Guest rating (1-5)
- **FeedbackDate**: `DATETIME` - Date of feedback

### Employees

Stores information about hotel employees.

- **Id**: `INT` - Primary Key
- **UserId**: `NVARCHAR(450)` - Foreign Key to `AspNetUsers(Id)`
- **Position**: `NVARCHAR(100)` - Employee's position
- **Salary**: `DECIMAL(18, 2)` - Employee's salary
- **DateOfJoining**: `DATE` - Date of joining

### ShiftAssignments

Stores shift assignment details for employees.

- **Id**: `INT` - Primary Key
- **EmployeeId**: `INT` - Foreign Key to `Employees(Id)`
- **ShiftStart**: `DATETIME` - Shift start time
- **ShiftEnd**: `DATETIME` - Shift end time

### Rooms

Stores room details.

- **Id**: `INT` - Primary Key
- **RoomNumber**: `NVARCHAR(10)` - Room number
- **RoomTypeId**: `INT` - Foreign Key to `RoomTypes(Id)`
- **Status**: `TINYINT` - Room status (enum)
- **PricePerNight**: `DECIMAL(18, 2)` - Price per night

### RoomTypes

Stores information about different room types.

- **Id**: `INT` - Primary Key
- **TypeName**: `NVARCHAR(100)` - Room type name
- **Description**: `NVARCHAR(256)` - Room type description
- **MaxOccupancy**: `INT` - Maximum occupancy

### Bookings

Stores booking information.

- **Id**: `INT` - Primary Key
- **GuestId**: `INT` - Foreign Key to `Guests(Id)`
- **RoomId**: `INT` - Foreign Key to `Rooms(Id)`
- **CheckInDate**: `DATETIME` - Check-in date
- **CheckOutDate**: `DATETIME` - Check-out date
- **Status**: `TINYINT` - Booking status (enum)
- **TotalAmount**: `DECIMAL(18, 2)` - Total booking amount

### Payments

Stores payment information.

- **Id**: `INT` - Primary Key
- **BookingId**: `INT` - Foreign Key to `Bookings(Id)`
- **PaymentDate**: `DATETIME` - Payment date
- **Amount**: `DECIMAL(18, 2)` - Payment amount
- **Method**: `TINYINT` - Payment method (enum)
- **Status**: `TINYINT` - Payment status (enum)

### Events

Stores information about hotel events.

- **Id**: `INT` - Primary Key
- **Name**: `NVARCHAR(100)` - Event name
- **Description**: `NVARCHAR(256)` - Event description
- **EventDate**: `DATETIME` - Event date
- **EventSpaceId**: `INT` - Foreign Key to `EventSpaces(Id)`
- **CoordinatorId**: `INT` - Foreign Key to `Employees(Id)`

### EventSpaces

Stores details about event spaces in the hotel.

- **Id**: `INT` - Primary Key
- **SpaceName**: `NVARCHAR(100)` - Event space name
- **Capacity**: `INT` - Capacity of the space
- **PricePerHour**: `DECIMAL(18, 2)` - Price per hour

### HousekeepingTasks

Stores housekeeping task information.

- **Id**: `INT` - Primary Key
- **RoomId**: `INT` - Foreign Key to `Rooms(Id)`
- **ScheduledDate**: `DATETIME` - Scheduled date for the task
- **CompletedDate**: `DATETIME` - Completion date of the task
- **AssignedToEmployeeId**: `INT` - Foreign Key to `Employees(Id)`
- **Status**: `TINYINT` - Task status (enum)

### MaintenanceRequests

Stores maintenance requests and their statuses.

- **Id**: `INT` - Primary Key
- **RoomId**: `INT` - Foreign Key to `Rooms(Id)`
- **RequestDate**: `DATETIME` - Request date
- **CompletionDate**: `DATETIME` - Completion date
- **AssignedToEmployeeId**: `INT` - Foreign Key to `Employees(Id)`
- **IssueDescription**: `NVARCHAR(256)` - Description of the issue
- **Status**: `TINYINT` - Request status (enum)

## Relationships

- **AspNetUsers -> Guests**: One-to-One (UserId is unique in Guests)
- **AspNetUsers -> Employees**: One-to-One (UserId is unique in Employees)
- **Guests -> GuestPreferences**: One-to-Many (Each guest can have multiple preferences)
- **Guests -> Feedbacks**: One-to-Many (Each guest can provide multiple feedback entries)
- **Employees -> ShiftAssignments**: One-to-Many (Each employee can have multiple shift assignments)
- **RoomTypes -> Rooms**: One-to-Many (Each room type can have multiple rooms)
- **Rooms -> Bookings**: One-to-Many (Each room can be booked multiple times)
- **Guests -> Bookings**: One-to-Many (Each guest can have multiple bookings)
- **Bookings -> Payments**: One-to-Many (Each booking can have multiple payments)
- **EventSpaces -> Events**: One-to-Many (Each event space can host multiple events)
- **Employees -> Events**: One-to-Many (Each employee can coordinate multiple events)
- **Rooms -> HousekeepingTasks**: One-to-Many (Each room can have multiple housekeeping tasks)
- **Employees -> HousekeepingTasks**: One-to-Many (Each employee can be assigned multiple housekeeping tasks)
- **Rooms -> MaintenanceRequests**: One-to-Many (Each room can have multiple maintenance requests)
- **Employees -> MaintenanceRequests**: One-to-Many (Each employee can be assigned multiple maintenance requests)

## Enum Definitions

- **Room Status**:
  - 0: Available
  - 1: Occupied
  - 2: Maintenance
  - 3: Reserved

- **Booking Status**:
  - 0: Pending
  - 1: Confirmed
  - 2: Cancelled
  - 3: CheckedOut

- **Payment Method**:
  - 0: Cash
  - 1: CreditCard
  - 2: DebitCard
  - 3: OnlinePayment

- **Payment Status**:
  - 0: Pending
  - 1: Completed
  - 2: Failed
  - 3: Refunded

- **Task Status (Housekeeping and Maintenance)**:
  - 0: Pending
  - 1: InProgress
  - 2: Completed
  - 3: Cancelled
