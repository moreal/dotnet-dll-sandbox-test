using System.Reflection;
using System.Runtime.Loader;

var context = new ContextImpl(10);

var liba = Assembly.LoadFile(Path.GetFullPath("out/liba/LibA.dll"));

var instanceA = (Common.IAction)Activator.CreateInstance(liba.GetType("Lib.Action")); 
instanceA.Execute(context);

var ctx = new AssemblyLoadContext("name", true);
ctx.LoadFromAssemblyPath(Path.GetFullPath("out/libb/LibB.dll"));
var instanceB = (Common.IAction)Activator.CreateInstance(ctx.Assemblies.First().GetType("Lib.Action"));
instanceB.Execute(context);
