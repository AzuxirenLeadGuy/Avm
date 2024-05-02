namespace Avm;

/// <summary>A View that processes a ViewState object</summary>
/// <typeparam name="ViewState">The type that represents the data held in the view</typeparam>
public interface IAbstractView<ViewState>
{
    /// <summary>
    /// This method will be called by the viewmodel object
    /// (with which this view is subscribed to), in order
    /// to provide the current viewstate. The View should
    /// update its controls accordingly.
    /// </summary>
    /// <param name="state">The current values of the view</param>
    void UpdateView(ViewState state);
}
