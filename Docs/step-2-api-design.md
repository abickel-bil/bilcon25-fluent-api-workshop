# Fluent API Design

Now that we've got out [functional requirements](../Outcomes/step-1-requirements-analysis.md) in hand, we can begin to lay out the flow of our api.

## Semantic Considerations

Before modeling out API, we want to have an understanding of how our users (application developers) will consume our API. The goal of introducing fluent APIs is to lean on natural-language composition, so that calling the methods in our API feels progressive and compositional.  

In plain english, we can easily describe the ordering of out methods and the general verbiage that we'd like to use. It may seem a little pedantic, but taking a moment to express our desired functionality in plain, relaxed language gives a great foundation for interface design, and also paints a clear picture of the chaining paths that the API is likely to follow.  

```md
Create a database connection with a specified domain name (or use the default value), 
...
```

### Action Item 1

Take a minute to write out the entire API flow, using natural language. No need to worry about punctuation or typos ;)

## Define the interface chains

With our natural-language outline in place, now we can begin to identify how our users will step through our API.  

Typically, each action (or group of options for a given action) represents a single 'phase' of the api.  For example, a natural language flow that captures the domain name first, then user name would have two phases.   Once the user selects an option that satisfies the data collection requirements for that phase, they can move onto the next phase.

```csharp
interface IPhaseOne 
{
    public IPhaseTwo WithDomainName(string domain);
    public IPhaseTwo WithDefaultDomainName();
}

interface IPhaseTwo
{
    public IPHaseThree WithUserName(string userName);
    public IPHaseThree WithDefaultUserName();
}
```

### Common Gotchas

When implementing a phase that allows a user to invoke the same phase method multiple times, always provide a method that clearly progresses the user to the next phase.

```csharp

interface IApiPhaseTwo
{
    // user can call this method as many times as they'd like - how will we know when they're done adding values?
    public IApiPhaseTwo WithAdditionalValue(object value);

    // this method is the clearly defined 'exit condition' of API phase 2
    public IApiPhaseThree WithNoAdditionalValues();
}

// Program.cs
...

var phaseThree = builder
    .WithAdditionalValue(1)
    .WithAdditionalValue(2)
    ...
    .WithNoAdditionalValues()

```
