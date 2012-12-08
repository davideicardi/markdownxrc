Markdown xrc
====================

C# Markdown processor

markdownxrc is a fork of [markdownsharp][] version 1.13 (23/Sept/2012).
The goal of this fork is to support virtual path link (with tilde ~).
For example ~/test.html link inside a markdown file should produce 
/yourvirtualpath/test.html if your web site is on a virtual path or 
/test.html if your web site isn't on a virtual path.

Added a BaseUrl options used for the substitution and the required unit test.
Currently BaseUrl is used for a.href and img.src tags.

MarkdownXrc is compiled with .NET 4.0.

MarkdownXrc is available on nuget: [markdownxrc@nuget][]

[markdownxrc@nuget]: https://nuget.org/packages/MarkdownXrc
[markdownsharp]: http://code.google.com/p/markdownsharp/


## License

Copyright (c) markdownsharp (http://code.google.com/p/markdownsharp/)

[MIT License](http://opensource.org/licenses/mit-license.php)