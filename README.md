
# Emergency Response Dispatch System

A C# Windows Forms desktop application that simulates an emergency dispatch center for managing emergency cases, assigning responder units, and tracking mission progress.

## Project Overview

The Emergency Response Dispatch System is a desktop simulation project built with C# and Windows Forms. It allows users to create emergency requests, prioritize emergency cases, assign available responder units, and track mission completion.

The project demonstrates object-oriented programming, asynchronous programming, and basic thread synchronization concepts.

## Features

- Add new emergency cases with caller name, emergency type, priority, and description
- Prioritize pending emergency cases based on priority level
- Dispatch available responder units to emergency cases
- Support multiple responder types:
  - Ambulance
  - Firefighter
  - Police
  - General responder
- Track responder availability and current mission status
- Mark dispatched missions as completed
- Display real-time notifications for system actions
- Use asynchronous programming to simulate dispatching and mission tracking
- Use locking and `SemaphoreSlim` to handle safe concurrent dispatch operations

## Screenshots
<img width="1540" height="885" alt="image" src="https://github.com/user-attachments/assets/f691c9d1-4a9e-4bc0-8afb-9afb31bd6e49" />

<img width="1646" height="947" alt="image" src="https://github.com/user-attachments/assets/e6854ec8-a4c5-4409-9042-5002655e4082" />





## Technologies Used

- C#
- .NET 8
- Windows Forms
- Object-Oriented Programming
- Async/Await
- Thread Synchronization
- SemaphoreSlim
- ManualResetEvent

## Project Structure

```text
Emergency System  project/
├── Models/
│   ├── EmergencyCase.cs
│   └── ResponderUnit.cs
├── Services/
│   ├── DispatchCoordinator.cs
│   ├── EmergencyRequestManager.cs
│   └── MissionTracker.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── Csc413 project.csproj
