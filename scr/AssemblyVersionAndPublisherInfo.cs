using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.


[assembly: AssemblyCompany("None")]
[assembly: AssemblyProduct("BDDish")]
[assembly: AssemblyCopyright("Licenced under LGPL")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]


// Make it easy to distinguish Debug and Release (i.e. Retail) builds;
// for example, through the file properties window.
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Retail")]
[assembly: AssemblyDescription("Flavor=Retail")] // a.k.a. "Comments"
#endif

[assembly: AssemblyVersion("0.9.0.*")]