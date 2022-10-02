# Wolfram Calculator

<h1> Hello Hello </h1>

The documentation about calling the Wolfram Language from .Net (https://reference.wolfram.com/language/NETLink/tutorial/CallingTheWolframLanguageFromNET.html) is outdated so I made a small sample application and a guide.

<h2> How it works </h2>

The program uses WSTP to communicate with a Wolfram Mathematica kernel which then executes code. In this example, the program we're communicating with is the Mathematica Kernel, and as such the link interface used is IKernelLink.

To use the interface, as the guide says, the file Wolfram.NETLink.dll is needed. Furthermore, the file must also be placed in the directory of the program. What the guide does not mention is that an additional file - ml32i4.dll or ml64i4.dll depending on your architecture - is also required. In older versions of Mathematica, this wasn't the case and it was enough to use Wolfram.NETLink.dll, which has since obviously changed, but the documentation wasn't updated. <b> You cannot reference the files in a .Net project, but adding them to your program's binaries fixes the problem. There is, as far as I know, no redist or actual setup of any kind, and the files can be found in \Mathematica\10.0\SystemFiles\Links\MathLink\DeveloperKit\Windows\SystemAdditions. </b>

Good luck everyone~
