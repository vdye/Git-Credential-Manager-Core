using System.Diagnostics;

namespace GCMCore.Tests
{
    public static class TestHelper
    {
        public static int RunInContext(GCMTestContext context, string command,
            params string[] args)
        {
            var psi = new ProcessStartInfo(command, string.Join(' ', args))
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            using (Process cmd = new Process() { StartInfo = psi })
            {
                cmd.Start();
                cmd.WaitForExit();
                return cmd.ExitCode;
            }
        }
    }
}
