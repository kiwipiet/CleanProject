namespace CleanProject
{
    using System.Collections.Generic;

    /// <summary>
    ///   Cleans solutions
    /// </summary>
    internal class SolutionCleaner
    {
        #region internal Methods

        internal static void CleanDirectories(IEnumerable<SolutionInfo> directories)
        {
            foreach (var solutionInfo in directories)
            {
                CleanDirectory(solutionInfo.WorkingPath);
            }
        }

        internal static void CleanDirectory(string directory)
        {
            // Remove standard directories
            DirectoryHelper.RemoveSubDirectories(directory, "bin", "obj", "TestResults", "_ReSharper*");

            // Remove directories provided on command line also
            DirectoryHelper.RemoveSubDirectories(directory, Program.Options.RemoveDirectories);

            FileHelper.DeleteFiles(directory, "*.ReSharper*", "*.suo");
            FileHelper.DeleteFiles(directory, Program.Options.RemoveFiles);

            if (Program.Options.RemoveSourceControl)
            {
                RemoveSourceControlBindings.Clean(directory);
            }
        }

        #endregion
    }
}