﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.Configuration")>]
[<assembly: AssemblyProductAttribute("FSharp.Configuration")>]
[<assembly: AssemblyDescriptionAttribute("Type providers for the configuration of .NET projects.")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"