# CleanProject
A copy of the code from [CleanProject - Cleans Visual Studio Solutions For Uploading or Email](https://code.msdn.microsoft.com/Clean-Cleans-Visual-Studio-a05bca4f)

#Introduction
Clean Project is a utility that cleans Visual Studio project directories so you can quickly upload or email a zip file with your solution.

How many times have you wanted to send a project to a friend or upload it to a web site like MSDN Code Gallery only to find that your zip file has lots of stuff that you don't need to send in it making the file larger than it needs to be.

  * bin folder
  * obj folder
  * TestResults folder
  * Resharper folders

And then if you forget about removing Source Control bindings whoever gets your project will be prompted about that.  As someone who does this process a great deal I decided to share with you my code for cleaning a project.

<a id="http://i1.code.msdn.s-msft.com/clean-cleans-visual-studio-a05bca4f/image/file/25379/1/cleanproject.wmv" href="http://i1.code.msdn.s-msft.com/clean-cleans-visual-studio-a05bca4f/image/file/25379/1/cleanproject.wmv">Download video</a>

#Building the Sample
This sample comes complete but it does have some dependencies which you may want to update with NuGet

Package Dependencies

* [cmdline](http://nuget.org/List/Packages/CmdLine)
* [DotNetZip](http://nuget.org/List/Packages/DotNetZip)
* [Wix](http://wix.codeplex.com/)

To update a package, open the Package Manager Console and type

PM>update-package cmdline

Open the solution and build it to get a tool you can use for cleaning projects

# Using CleanProject.exe

The best way to use CleanProject.exe is to run the CleanProject.msi installer. 

~~The installer will add Clean Project to your external tools:~~

It will also register a Shell Folder Command to clean from Windows Explorer:

![Shell Folder Command](shellfolder.png")
