using System.Reflection;

var liba = Assembly.LoadFile(Path.GetFullPath("out/liba/LibA.dll"));
var libb = Assembly.LoadFile(Path.GetFullPath("out/libb/LibB.dll"));

var instanceA = Activator.CreateInstance(liba.GetType("Lib.Action")); 
instanceA.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, instanceA, null);

var instanceB = Activator.CreateInstance(libb.GetType("Lib.Action")); 
instanceB.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, instanceB, null);
