using System;
namespace Avm;

/// <summary>A ViewModel that supports binding via events </summary>
/// <typeparam name="ViewState">The viewstate that the view can build on</typeparam>
public interface IEventViewModel<ViewState> :
    IAbstractViewModel<ViewState>
{
    /// <summary>All views should subscribe to this event, and build/update themselves</summary>
    event Action<ViewState> OnUpdate;
}