using System;

namespace BlazorAppServerSide.Stores.CounterStore
{
    public class CounterState
    {
        public int Count { get; set; }

        public CounterState(int count)
        {
            Count = count;
        }
    }
    public class CounterStore
    {
        private CounterState _state { get; set; }

        private readonly IActionDispatcher _actionDispatcher;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            _state = new CounterState(0);
            _actionDispatcher = actionDispatcher;
            this._actionDispatcher.Subscript(HandleAction);

        }

        //~CounterStore()
        //{
        //    this._actionDispatcher.Unsubscript(HandleAction);
        //}

        public CounterState GetState()
        {
            return _state;
        }

        public void HandleAction(IAction action)
        {
            switch (action.Name)
            {
                case IncrementAction.INCREMENT:
                    IncrementCount();
                    break;
                case DecrementAction.DECREMENT:
                    DecrementCount();
                    break;
                default:
                    break;
            }

        }

        private void IncrementCount()
        {
            var count = this._state.Count;
            count++;
            this._state = new CounterState(count);
            BrodcastStateChange();
        }

        private void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            BrodcastStateChange();
        }

        #region Observer pattern
        private Action _listeners { get; set; }
        public void AddStateChangeListeners(Action listener)
        {
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            _listeners -= listener;
        }
        public void BrodcastStateChange()
        {
            _listeners.Invoke();
        }
        #endregion



    }
}
