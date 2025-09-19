# Requirements Analysis

The first step to any application design activity is to ensure that we've got a clear understanding of the "expected behavior", and can define those expectations in technically applicable terms.

It's important to note that while product or business requirements often translate directly to functional technical requirements, there are often requirements for our software that are not explicitly stated in business documents.  

## Requirements decomposition process

### Review the problem statement and/or product requirements

Product requirements and problem statements typically express the desired software behavior in terms of  "user expectation".

In this workshop, the `users` of our software are application developers, not end users.

Typically, we would not expect a problem statement or business requirements document to contain the level of specificity that are provided in the `Constraints` section of the overview, but let's not look that gift horse in the mouth.

### Action Item 1

Review the [Constraints](./overview.readme.md#constraints) section of the overview readme, and list any functional requirements.

---

### Consider non-functional and implied requirements

- Does the software need to consider availability, security, scalability, or other "*ilities"?  
  - Often, these kinds of technical constraints aren't present, but it's our job to ensure that application design takes them into consideration.
  - Never assume that someone else has thought though the problem for you.  If you're not asking questions, you're not decomposing.
- Do you notice any ambiguous wording in the problem statement or see areas where a single business requirement can't be translated to a single functional requirement?
  - Computers need precise instructions to perform precise tasks.
  - Developers need precise designs to implement precise instructions
  - We can't create precise designs without precise understanding.
- _Remember:_ Unanswered questions, or questions that don't have clear, concise answers indicate that further discussion or investigation is required.

 For the sake of brevity, __this workshop will consider the constraints provided to be exhaustive.  Don't get used to that :)__

### Action Item 2

This workshop will not require any additional requirements analysis steps, though you are welcome to introduce them on your own, if you'd like the extra challenge.

Note: _additional requirements may impact your design; don't be surprised if you notice variance between your API design and the samples provided here_

## Next Steps

- To view the solution to this step, `git checkout step-1-requirements-analysis-outcome`
- To continue to the next step, `git checkout step-2-api-design`
