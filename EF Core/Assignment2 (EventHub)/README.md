# EventHub - EF Core Relationships & Configurations

A console application built using **Entity Framework Core** to practice modeling entities, relationships, and different configuration techniques.

## 🔗 Relationships Implemented

This project includes multiple types of relationships:

* **One-to-One**

  * Organizer ↔ PublicFacingProfile
  * Attendee ↔ Badge

* **One-to-Many**

  * Organizer → Events

* **Many-to-Many**

  * Attendee ↔ Event through the `EventAttendee` join entity

* **Self-Referencing Relationship**

  * Event → Parent Event / Child Events

## ⚙️ Configuration Techniques

### Data Annotations

The following entities are configured using **Data Annotations**:

* `Organizer`
* `Attendee`

### Fluent API

The following entities and relationships are configured using **Fluent API**:

* `Event`

  * Organizer relationship
  * Self-referencing relationship

* `Badge`

  * One-to-One relationship with Attendee

* `PublicFacingProfile`

  * One-to-One relationship with Organizer

* `EventAttendee`

  * Many-to-Many relationship between Event and Attendee
  * Composite Primary Key

## 🛠 Technologies Used

* C#
* .NET
* Entity Framework Core
* SQL Server
* EF Core Migrations
