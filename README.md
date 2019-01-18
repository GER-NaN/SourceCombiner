# SourceCombiner

Combines multiple c# files and Visual Studio projects into a single 
consolidated source file. This is useful for submitting your work to a website
or online judge program that only accepts single files as input.

To combine multiple projects they must be added into the solution. A 
referenced project will be ignored.

Only support for Visual Studio is included. A Visual Studio solution file is
required to use this tool.

Parameters
    -   Solution File (Required): The full file path to the solution (.sln) 
        file for your project.
    
    -   Output Location (Required): The full file path where the generated c#
        file should be output.
        
    -   Open When Done (Optional): A true or false value indicating whether 
        the generated file should be opened and displayed after generation. 
        The default value is false.
        
    -   Minify Output (Optional): A true or false value indicating whether the
        generated file should be minified. The minification process is not a 
        complete minification. Newlines and comments are the only items removed 
        from the source. The default value is false.");


Example from command line:
> SourceCombiner.exe C:\Projects\...\MySolution.sln c:\...\output.cs true ture




