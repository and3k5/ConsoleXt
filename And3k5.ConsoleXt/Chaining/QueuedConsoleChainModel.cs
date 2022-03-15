using System;

namespace And3k5.ConsoleExtensions.Chaining
{
    public class QueuedConsoleChainModel : ConsoleChainModelBase
    {
        private Action _action;

        public override void AppendAction(Action action)
        {
            switch (_action)
            {
                case null:
                    _action = action;
                    break;
                default:
                    _action += action;
                    break;
            }
        }

        public override void Apply() => _action?.Invoke();
    }
}