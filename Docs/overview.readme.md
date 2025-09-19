# Fluent API Workshop Overview

So.  A "real-world" problem, huh?  And we're going to design and implement it in 45 minutes?  Well, I mean... yeah? kind of? Let's dig in.

## The problem

Databases.  

Specifically, connecting to them.  Most applications use some type of persistence back-end, and we typically have different instances for different deployment environments.

---

Today, we're connecting to the totally-real, definitely-not-fictisious Possum DB, which requires a connection string including `url`, `username`, `password`, and `port`.

### Constraints

- Our application is hosted in multiple environments, and each deployment must be able provide different values for each of those configurations
- All values have specific validation requirements.
  - port number must be a non-negative integer of at least four digits.
  - url must include a fully-qualified domain name, and must not specifiy connection protocol.
  - username must not be empty.
  - password must not be empty.
<<<<<<< HEAD
- All inputs (excluding password) must have the option to use a default value

## Objectives

- Identify technical requiremnts based on the given problem statement and known constraints
- Design API Flows based on configuration needs and technical requirements
- Implement API design

### First Steps

Before we dive into creating our API design, let's take a moment to ensure we understand both the constraints and their impact on our solution.

---

- `git checkout step-1-requirements-analysis` to continue.
=======
- All inputs must have the option to use a default value
- We need to restrict access to database connections

### First Steps

Before we dive into creating our API design, let's take a moment to ensure we understand both the constraints and their impact on our solution. 

---

- `git checkout step-1` to continue.
>>>>>>> 11a7f15 (defines the project overview)
