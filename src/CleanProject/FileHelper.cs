namespace CleanProject
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal class FileHelper
    {
        #region Methods

        internal static void DeleteFiles(string directory, params string[] searchPatterns)
        {
            foreach (var searchPattern in searchPatterns)
            {
                DeleteFiles(directory, searchPattern);
            }
        }

        internal static void DeleteFiles(string directory, string searchPattern)
        {
            if (!Directory.Exists(directory))
            {
                return;
            }

            var files = Directory.GetFiles(directory, searchPattern, SearchOption.AllDirectories);
            foreach (var file in files)
            {
                try
                {
                    Program.WriteVerboseMessage("Deleting file {0}", file);
                    TurnOffReadOnlyFlag(file);
                    File.Delete(file);
                }
                catch (IOException ex)
                {
                    throw new ApplicationException(string.Format("Error removing file {0} - {1}", file, ex.Message), ex);
                }
            }
        }

        internal static void DeleteFiles(string directory)
        {
            DeleteFiles(directory, "*");
        }

        internal static void DeleteFiles(string directory, IEnumerable<string> searchPatterns)
        {
            foreach (var searchPattern in searchPatterns)
            {
                DeleteFiles(directory, searchPattern);
            }
        }

        /// <summary>
        ///   Turns off the read only flag on a file.
        /// </summary>
        /// <param name = "file">
        ///   The file to change.
        /// </param>
        /// <returns>
        ///   Returns true if the read only flag was set.
        /// </returns>
        internal static bool TurnOffReadOnlyFlag(String file)
        {
            var retValue = false;
            var attribs = File.GetAttributes(file);
            if ((attribs & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                retValue = true;
                File.SetAttributes(file, attribs & ~FileAttributes.ReadOnly);
            }
            return (retValue);
        }

        /// <summary>
        ///   Turns on the read only flag for a file.
        /// </summary>
        /// <param name = "file">
        ///   The file to change.
        /// </param>
        internal static void TurnOnReadOnlyFlag(String file)
        {
            var attribs = File.GetAttributes(file);
            File.SetAttributes(file, attribs | FileAttributes.ReadOnly);
        }

        #endregion
    }
}