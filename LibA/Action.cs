namespace Lib;
using Common;
public class Action
{
    public void Execute(Context context)
    {
        new Printer().Print(context.Value);
    }
}
