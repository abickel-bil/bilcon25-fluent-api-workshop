# Step 3: Implementation

We'll follow a simple aggregation strategy for this API implementation, since we're just collecting a handful of configuration values to generate a single output.  

Please note that there are several approaches to implementing fluent APIs; this workshop will focus on a simple implementation that focuses on two fundamental benefits of the Builder Pattern: `idempotency`and `object guarantees`.

## Go to tasks

If you want to stop reading and start building, open [Step 3: Action Item 1](./step-3-action-item-1.md).

## Idempotency

The fundamental benefit of idempotence is that objects returned from method calls are separate object instances. Long story short, a user of our API can retain reference to an object created at any phase of the API, and use it to invoke multiple downstream objects without worring about config pollution between any of the instances.

```csharp
var domainBuilder = new Builder().WithDomainName("my-domain.io");

// continue creating connection strings for 'my-domain.io' with the admin user
var adminUser = domainBuilder.WithUserName("admin");

// continue creating connection strings for 'my-domain.io' with the default user
var readonlyUser = domainBuilder.WithDefaultUserName();
```

## Object Guarantees

The fundamental benefit of object guarantees is that at any point, if our API returns an object, it is guaranteed to be in a consistent and healthy state.  Long story short, any attempt to call our API with invalid or missing inputs will result in a runtime exception being thrown.  Our users don't have to worry about whether they're working with null references or malformed objects at any phase of the API.

```csharp
var domainName = null;

// We can't guarantee that users will always provide validated inputs.
var badDomain = new Builder()
    .WithDomainName(domainName!);    // we CAN guarantee that this method throws when input is null
      
var goodDomain = new Builder()
    .WithDomainName("my-domain.io");

// if we reach this line of code, we are guaranteed to have a valid builder object
// that satisfies all implemented constraints
var guaranteed = goodDomain
    .WithDefaultUserName();
```
