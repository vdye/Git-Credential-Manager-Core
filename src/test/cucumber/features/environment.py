import os
import uuid
import shutil
from pathlib import Path

TEST_ROOT = os.path.join(Path(__file__).parent.resolve(), "../../../../out/test")

def before_scenario(context, scenario):
    # Create a test directory
    workspace = Path(os.path.join(TEST_ROOT, str(uuid.uuid4())[:8]))
    workspace.mkdir(parents=True, exist_ok=True)
    context.workspace = workspace

def after_scenario(context, scenario):
    # Clean up test directory
    shutil.rmtree(context.workspace, ignore_errors = True)