# Subscription Tracker 💳

A web application designed to help users manage their subscriptions, track renewal dates, and understand their monthly subscription costs in one place.

🌐 **Live Demo:** [Try Subscription Tracker](https://subscription-tracker-lqh6.onrender.com)

---

## ✨ Overview

Subscription Tracker is a web application that provides a simple way to organize and track recurring subscriptions.

It allows users to add their subscriptions, monitor renewal dates, and calculate the average monthly cost, making it easier to understand and manage recurring expenses.

The project focuses on applying software design concepts through a practical C# application.

---

## ⭐ Features

- Add and manage subscriptions
- Support monthly and yearly subscription plans
- Calculate the average monthly subscription cost
- Track upcoming renewal dates
- Notify users about upcoming renewals
- Display subscription details in a simple and organized interface

---

## 🛠️ Tech Stack

- **C#**
- **.NET 10**
- **ASP.NET Core**
- **Blazor**
- **HTML & CSS**


---

## 🧩 Design Patterns

### Strategy Pattern

Used to handle different ways of calculating the **average monthly subscription cost**.

Monthly and yearly subscriptions require different calculations. The Strategy Pattern keeps each calculation method separate and allows the appropriate strategy to be selected based on the subscription type.

### Observer Pattern

Used to handle **subscription renewal reminders**.

When a subscription approaches its renewal date, the Observer Pattern allows the notification logic to react without tightly coupling it to the main subscription logic.

---

## 🧱 SOLID Principles

SOLID principles were applied to keep the application organized, maintainable, and easy to extend.

- **Single Responsibility Principle (SRP)** — Each class is responsible for a specific part of the application.
- **Open/Closed Principle (OCP)** — New subscription cost strategies can be added without changing the existing calculation logic.
- **Dependency Inversion Principle (DIP)** — The application relies on abstractions such as interfaces rather than depending directly on concrete implementations.



