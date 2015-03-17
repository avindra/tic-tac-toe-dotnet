# Prerequisites #
You need Visual Studio. I use Visual Studio 2010, as it's the latest version and has no major flaws compared with Visual Studio 2008 in C#.

# The Guide #

## Get the Source Code ##
  1. There are many guides for this, [here's one](http://code.google.com/p/imos-toolbox/wiki/tortoiseSVN). I prefer the TortoiseSVN client, as it is the most feature-rich and easy one to use.
  1. Note that the url if you're just downloading the code is "http://tic-tac-toe-dotnet.googlecode.com/svn/trunk/". If you are a project member, the correct url to use is "https://tic-tac-toe-dotnet.googlecode.com/svn/trunk/".
    * When prompted for your password, it is NOT YOUR GOOGLE ACCOUNT PASSWORD. It is your Google Code password, which can be found [here](http://code.google.com/hosting/settings).

## Build in Visual Studio ##

  1. Select "Release" from the Solution Configurations, and "x86" from Solution Platforms. You can choose x64 if you want, but there really is no practical need.
  1. Right click on the solution, and choose "Build Solution", or just press Ctrl + Shift + B.
    * The build directory is "\TicTacToe\bin\Release\", then "x86" or "x64" depending on which platform you chose.
  1. Now you can execute the file. Note there is are vshost files. You can ignore these, these are files used by Visual Studio. The program can run just with "TicTacToe.exe".

## Commit your changes ##

  1. If you have useful changes or additions to the code that you have TESTED, feel free to add them.
  1. Be sure to e-mail me and ask for permission (aavindraa@gmail.com).
  1. Once you have permission to commit, right click on the project folder and click "SVN Commit".
    * If you tested the code and there are any problems with it, tag it with a a comment "FIXME" or "TODO" so that we won't forget about it.
    * Be sure to fill out a commit message, fully documenting every change you made. If you double-click on the files in the commit window, you can see exactly what changes you made in case you forgot.
    * You have to be updated to the latest revision in order to commit...