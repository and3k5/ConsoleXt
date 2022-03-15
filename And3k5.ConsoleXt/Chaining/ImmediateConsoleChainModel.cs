using System;

namespace And3k5.ConsoleExtensions.Chaining
{
    public class ImmediateConsoleChainModel : ConsoleChainModelBase
    {
        public override void AppendAction(Action action)
        {
            action();
        }
    }
}