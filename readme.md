Markdown xrc
====================

markdownxrc is a fork of [markdownsharp][] at version 1.13 (23/Sept/2012).
The goal of this fork is to support virtual path link (with tilde ~).
For example ~/test.html link inside a markdown file should produce 
/yourvirtualpath/test.html if your web site is on a virtual path or 
/test.html if your web site isn't on a virtual path.

I have added a BaseUrl options used for the substitution and the required unit test.

I have also compiled it on .NET 4.0.

[markdownsharp]: http://code.google.com/p/markdownsharp/