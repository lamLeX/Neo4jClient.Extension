using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


[assembly: AssemblyCopyright("Copyright � 2014")]
[assembly: AssemblyVersion("1.0.1")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyInformationalVersion("0.1.3.1-beta")]    // trigger pre release package
#else
    [assembly: AssemblyConfiguration("Release")]
#endif
[assembly: InternalsVisibleTo("Neo4jClient.Extension.Test")]
[assembly: ComVisible(false)]