﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("TypedWrappers")>]
[<assembly: AssemblyProductAttribute("TypedWrappers")>]
[<assembly: AssemblyDescriptionAttribute("Type Provider to create types that wrap prim")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"