from behave import use_step_matcher, given, when, then
import os
import subprocess

use_step_matcher("re")

@given('a user with the configuration')
def step_impl(context):
    for row in context.table:
        subprocess.run([
            "git",
            "config",
            "--file", os.path.join(context.workspace, ".gitconfig"),
            row["config"], row["value"]])

@when('the user clones (?P<repo>.*)')
def step_impl(context, repo):
    subprocess.run([
        "git", "-C", context.workspace,
        "clone", repo, "test-repo"])

@then('the repository is cloned')
def step_impl(context):
    assert 0 == subprocess.run([
        "git", "-C", os.path.join(context.workspace, "test-repo"),
        "status"]).returncode