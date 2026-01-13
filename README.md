# Lumina Agency - ASP.NET Core MVC Project

This repository contains the source code for **Activity 3 (Frontend)** and **Activity 4 (Database & CRUD)**. The project is a modern digital agency website titled *"Lumina Agency,"* built using ASP.NET Core MVC.

## Project Overview
This application demonstrates the progression from a static frontend implementation to a fully functional dynamic web application using the Model-View-Controller (MVC) architectural pattern.

### Technologies Used
* **Framework:** .NET 9.0 (ASP.NET Core MVC)
* **Language:** C#
* **Styling:** Tailwind CSS (via CDN)
* **Database:** Entity Framework Core 
* **Version Control:** Git & GitHub

---

## 🎨 Activity 3: Frontend Implementation
**Branch:** `master`

The goal of this activity was to translate a React/Next.js design into ASP.NET Core MVC Razor Views for a better looking front-end UI.

### Key Features
* **Master Layout:** Implemented a reusable `_Layout.cshtml` containing the Navigation Bar and Footer.
* **Modern UI:** Integrated **Tailwind CSS** to replicate the "Lumina Agency" dark theme (Purple/Dark Blue palette).
* **Static Views:**
    * **Home Page:** Hero section, Expertise cards, and a visual Contact Form.
    * **Services:** Static display of agency capabilities.
* **No Database:** All content is hardcoded in HTML/Razor to focus purely on visual fidelity.

---

## 🛠️ Activity 4: Database & CRUD
**Branch:** `act4-crud`

The goal of this activity was to implement the "Backend" logic, connecting the application to a database to manage services dynamically.

### Key Features
* **Entity Framework Core:** Configured an **Auto Creation Database** without writing SQL queries.
* **MVC CRUD Operations:**
    * **Create:** A form to add new services (Title, Price, Description) to the database.
    * **Read:** A dynamic grid view that fetches and displays services stored in the system.