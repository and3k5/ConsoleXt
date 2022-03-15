using System;

namespace And3k5.ConsoleExtensions.Chaining
{
    internal class ImmediateConsoleChainModel : ConsoleChainModelBase
    {
        public override void AppendAction(Action action)
        {
            action();
        }
    }
}