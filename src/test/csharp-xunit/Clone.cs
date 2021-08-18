using System;
using System.IO;
using Xunit;

namespace GCMCore.Tests
{
    public class CloneScenarios
    {
        [Fact]
        public void Clone_Public_GitHub_Repository()
        {
            // Test constants
            const string repo = "https://github.com/microsoft/Git-Credential-Manager-Core.git";

            using (GCMTestContext context = new GCMTestContext())
            {
                // Clone repository
                TestHelper.RunInContext(context,
                    "git", "-C", context.Workspace,
                    "clone", repo, "test-repo");

                // Verify repository cloned
                int status = TestHelper.RunInContext(context,
                    "git", "-C", Path.Join(context.Workspace, "test-repo"),
                    "status");
                Assert.Equal(0, status);
            }
        }
    }
}
