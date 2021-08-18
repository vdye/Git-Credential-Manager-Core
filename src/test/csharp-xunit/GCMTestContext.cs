using System;
using System.IO;

namespace GCMCore.Tests
{
    public class GCMTestContext : IDisposable
    {
        public string Workspace { get; private set; }

        public GCMTestContext()
        {
            Workspace = Guid.NewGuid().ToString();
            Directory.CreateDirectory(Workspace);
        }

        public void Dispose()
        {
            if (!string.IsNullOrWhiteSpace(Workspace) && Directory.Exists(Workspace))
            {
                try
                {
                    Directory.Delete(Workspace, true);
                }
                catch
                {
                    // continue on error (usually unauthorized, on Windows)
                }
            }
        }
    }
}
