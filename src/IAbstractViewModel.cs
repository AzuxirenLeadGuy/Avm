namespace Avm;

/// <summary>A ViewModel that can handle a given type of ViewState</summary>
/// <typeparam name="ViewState">The type that represents the data held in the view</typeparam>
public interface IAbstractViewModel<ViewState>
{
    /// <summary>Returns the current ViewState that this ViewModel represents</summary>
    /// <returns>The current ViewState</returns>
    ViewState GetCurrentViewState();
}
