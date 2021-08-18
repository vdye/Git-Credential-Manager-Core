# Cucumber
Site: https://cucumber.io/tools/cucumber-open/

## How to run
1. Install Python 3.5+
2. In this directory (`git-credential-manager-core/src/test/cucumber`), run `python3 -m venv venv`
3. To activate the virtual environment, run (on a Mac) `source ./venv/bin/activate`
4. To install dependencies, run `pip install -r requirements.txt`
5. To run the tests, run `behave`

## Pros/Cons
### Pros
- If step definitions are written flexibly, _extremely_ easy to add new scenarios
- Available in [lots of languages](https://cucumber.io/docs/installation/)
  - I went with Python for this example because it was the fastest for me to set up
- Feature files are nearly identical across languages (only really varying by tag syntax)

### Cons
- C# Gherkin/Cucumber framework (SpecFlow) isn't formally supported as part of Cucumber (it's a separate project, with its own OSS vs. paid licensing model)
- Developers are often tempted to write brand new step definitions for a single test, rather than reusing/generalizing what already exists
- You might end up being super picky about grammar in step definitions (I certainly am)
- Varying support of parallelization (e.g., SpecFlow can only parallelize between feature files, behave doesn't natively support parallel execution, Cucumber.js seems to only support scenario-level parallelization)