using System;

namespace TimeTable10.Util.Commands
{

    public abstract class DelegateCommandBase : CommandBase
    {
        private readonly Action<object> _onExecute;

        protected DelegateCommandBase(Action<object> act)
        {
            this._onExecute = act;
        }

        public override void Execute(object o)
        {
            _onExecute(o);
        }
    }
}
