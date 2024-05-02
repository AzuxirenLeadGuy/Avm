using System;

namespace Avm;
/// <summary>A View model that provides update commands using Enum types</summary>
/// <typeparam name="ViewState">The type of ViewState</typeparam>
/// <typeparam name="CommandType">The type of Commands</typeparam>
public interface ICommandableViewModel<ViewState, CommandType> : IAbstractViewModel<ViewState>
{
    /// <summary>
    /// This method launches a command to the viewmodel to update itself.
    /// The viewmodel should then call the <c>UpdateView()</c> method on the
    /// View with the new Viewstate (as many times as needed)
    /// </summary>
    /// <param name="command">The command type</param>
    void RequestUpdate(CommandType command);
}