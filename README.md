# Bicycle Rental and Mushroom Identification System

## Overview

This is a Windows Forms Application developed in C# using Visual Studio.

The application provides:

- Login System
- Dashboard Navigation
- Bicycle Rental Calculator
- Mushroom Identification System
- Logout Functionality

---

## Features

### Login Module

- Username validation
- Password validation
- Prevents empty fields
- Opens Dashboard after successful login

### Dashboard

The dashboard provides access to:

- Bicycle Rental System
- Mushroom Identification System
- Logout

---

## Bicycle Rental System

Calculates bicycle rental cost based on rental hours.

### Rental Rates

| Time Range | Cost |
|------------|------|
| 00:00 - 06:59 | 500 RWF |
| 07:00 - 13:59 | 1000 RWF |
| 14:00 - 18:59 | 1500 RWF |
| 19:00 - 20:59 | 1000 RWF |
| 21:00 - 23:59 | 500 RWF |

### Validation

- Start hour cannot be empty
- End hour cannot be empty
- End hour must be greater than start hour
- Invalid values are rejected

---

## Mushroom Identification System

Identifies mushrooms based on the following characteristics:

- Gills
- Forest
- Ring
- Convex Cup

### Mushroom Table

| Mushroom | Gills | Forest | Ring | Convex Cup |
|-----------|--------|---------|------|------------|
| Cepe de Bordeaux | No | Yes | No | No |
| Agaric Jaunissant | Yes | No | Yes | Yes |
| Amanite Tue-Mouche | Yes | Yes | Yes | Yes |
| Coprin Chevelu | Yes | No | Yes | No |
| Pied Bleu | Yes | Yes | No | Yes |
| Girolle | Yes | Yes | No | No |

---

## Application Flow

```text
Login Form
     |
     V
 Dashboard
  /        \
 V          V
Bicycle   Mushroom
     \    /
      \  /
     Logout
        |
        V
     Login
```

---

## Technologies Used

- C#
- Windows Forms
- Visual Studio
- .NET Framework

---

## Project Structure

```text
FOAM1
│
├── LoginFoam.cs
├── LoginFoam.Designer.cs
│
├── Dashboard.cs
├── Dashboard.Designer.cs
│
├── BicycleRental.cs
├── BicycleRental.Designer.cs
│
├── Mushroom.cs
├── Mushroom.Designer.cs
│
├── Program.cs
│
└── App.config
```

---

## How to Run

1. Open the solution in Visual Studio.
2. Build the project.
3. Press F5 to run.
4. Enter Username and Password.
5. Navigate through the Dashboard.
6. Use the Bicycle Rental or Mushroom Identification systems.

---

## Author

**Melissa Sangwa Kamanzi**

Windows Forms Application Project
