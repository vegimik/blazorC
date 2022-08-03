using System;

namespace BlazorAppServerSide.Stores
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registeredActionHandlers;

        public void Subscript(Action<IAction> actionhandler) => _registeredActionHandlers += actionhandler;

        public void Unsubscript(Action<IAction> actionhandler) => _registeredActionHandlers -= actionhandler;

        public void Dispatch(IAction action) => _registeredActionHandlers?.Invoke(action);

    }
}
