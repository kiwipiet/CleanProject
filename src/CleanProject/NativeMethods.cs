using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CleanProject
{
    internal static class NativeMethods
    {
        /// <summary>
        ///     The find window.
        /// </summary>
        /// <param name="sClassName">
        ///     The s class name.
        /// </param>
        /// <param name="sAppName">
        ///     The s app name.
        /// </param>
        /// <returns>
        /// </returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string sClassName, string sAppName);

        /// <summary>
        ///     The get long path name.
        /// </summary>
        /// <param name="path">
        ///     The path.
        /// </param>
        /// <param name="pszPath">
        ///     The psz path.
        /// </param>
        /// <param name="cchPath">
        ///     The cch path.
        /// </param>
        /// <returns>
        ///     The get long path name.
        /// </returns>
        [DllImport("kernel32.dll")]
        public static extern int GetLongPathName(string path, StringBuilder pszPath, int cchPath);

        /// <summary>
        ///     The show window.
        /// </summary>
        /// <param name="hWnd">
        ///     The h wnd.
        /// </param>
        /// <param name="nCmdShow">
        ///     The n cmd show.
        /// </param>
        /// <returns>
        ///     The show window.
        /// </returns>
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}