using System.Reflection;

var context = new ContextImpl(10);

var liba = Assembly.LoadFile(Path.GetFullPath("../../../../out/liba/LibA.dll"));
var libb = Assembly.LoadFile(Path.GetFullPath("../../../../out/libb/LibB.dll"));

var instanceA = Activator.CreateInstance(liba.GetType("Lib.Action")); 
instanceA.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, instanceA, new[] { context });

var instanceB = Activator.CreateInstance(libb.GetType("Lib.Action")); 
instanceB.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, instanceB, new[] { context });
