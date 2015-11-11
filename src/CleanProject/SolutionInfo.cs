using System;
using System.IO;
using System.Linq;

namespace CleanProject
{
    internal class SolutionInfo
    {
        #region Methods

        private string GetTempPath()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = Directory.Split(new[] {Path.DirectorySeparatorChar}, StringSplitOptions.RemoveEmptyEntries).Last();
            }

            tempPath = Path.Combine(Path.GetTempPath(), Name);

            return tempPath;
        }

        #endregion

        #region Constants and Fields

        private string tempPath;

        #endregion

        #region Properties

        public string WorkingPath
        {
            get { return Program.Options.ZipProject ? TempPath : Directory; }
        }

        public string TempPath
        {
            get { return string.IsNullOrWhiteSpace(tempPath) ? GetTempPath() : tempPath; }
        }

        internal string Directory { get; set; }

        internal string Name { get; private set; }

        #endregion
    }
}