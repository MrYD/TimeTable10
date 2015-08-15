using System;

namespace TimeTable10.Util.Commands
{
    public class AlwaysExecutableDelegateCommand : DelegateCommandBase
    {
        public AlwaysExecutableDelegateCommand(Action<object> act)
            : base(act)
        {

        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
