# Step 1 Outcomes: Requirements Analysis

Based on the constraints defined in the [overview readme](../Docs/overview.readme.md#constraints), we'll use the following list as our functional requirements

## Functional Requirements

### Domain Name

- API must allow domain name to be specified, with an option to use a default value
- API must not allow a provided domain name to be null or empty
- API must reject domain names that include connection prototcol (`http` | `https`)

### User Name

- API must allow user name to be specified, with an option to use a default value
- API must not allow a provided user name to be null or empty

### Password

- API must allow password to be specified
  - No default password value shall be allowed, as this is conflicts with conventional security stance
- API must not allow provided password to be null or empty

### Port Number

- API must allow port number to be specified, with an option to use a default value
- API must not allow provided port number to be null, empty, or less than `1000`

### Collection Order

- Lacking clear need for configuration value collection order, API shall collect inputs in the following order
  1. Domain Name
  2. User Name
  3. Password
  4. Port Number
