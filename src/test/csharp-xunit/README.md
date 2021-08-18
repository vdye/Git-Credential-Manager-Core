# C# (xunit)
xunit was chosen for the purposes of this example, but it's by no means the only test adapter available. Other options include:
- nunit (used by Scalar functional tests)
- MSTest

Note: if going with a plain .NET test framework, it should _not_ be included in the standard GCM Core solution - it should exist independent of the code it's testing. However, that separation might not even be possible if we want to test the UIs.

## How to run
1. In this directory (`git-credential-manager-core/src/test/csharp-xunit`), run `dotnet test`

## Pros/Cons
### Pros
- **No extra dependencies**
- Native C# makes contribution easy for people already contributing the GCM Core
- Finer granularity of parallel execution control (down to per-test, depending on the test adapater)

### Cons
- To be easily maintainable, will probably require building out substantial test infrastructure, such as:
  - Helper functions for executing common Git operations & handling text I/O with GCM Core
  - A "context" structure for organizing information generated and used throughout the tests
  - Custom, descriptive assertion error messages (like in Scalar functional tests)
- Tests will be "monolithic" - long scenarios with multiple assertions, without "step" separation