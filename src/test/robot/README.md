# Robot Framework
Site: https://robotframework.org/

## How to run
1. Install Python 3.5+
2. In this directory (`git-credential-manager-core/src/test/robot`), run `python3 -m venv venv`
3. To activate the virtual environment, run (on a Mac) `source ./venv/bin/activate`
4. To install dependencies, run `pip install -r requirements.txt`
5. To run the tests, run `robot -o NONE -l NONE -r NONE clone.robot`

## Pros/Cons
### Pros
- Lots of built-in operations, including running a process and interacting with it
- Existing plugins/extensions cover even more pre-built functionality
- Highly customizable (or so the documentation tells me)

### Cons
- Syntax is frustrating (tab separation required between every argument, syntax errors not obvious when run)
- Test setup/teardown is limited (e.g., can't seem to assign variables in setup section)
- Custom extensions are in Python only