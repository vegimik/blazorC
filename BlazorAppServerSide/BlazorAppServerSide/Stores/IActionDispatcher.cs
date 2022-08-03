using System;

namespace BlazorAppServerSide.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscript(Action<IAction> actionhandler);
        void Unsubscript(Action<IAction> actionhandler);
    }
}