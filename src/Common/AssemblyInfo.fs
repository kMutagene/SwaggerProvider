﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("SwaggerProvider")>]
[<assembly: AssemblyProductAttribute("SwaggerProvider")>]
[<assembly: AssemblyDescriptionAttribute("F# Type Provider for Swagger")>]
[<assembly: AssemblyVersionAttribute("0.3.1")>]
[<assembly: AssemblyFileVersionAttribute("0.3.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.1"
