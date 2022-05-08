namespace Lib;
using Common;
public class Action : IAction
{
    public void Execute(Context context)
    {
        new Printer().Print(context.Value);
    }
}
