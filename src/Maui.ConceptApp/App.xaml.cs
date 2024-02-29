
namespace Maui.ConceptApp;

public partial class App : Application
{
    #region Constructor
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    #endregion

    #region Override Methods
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);
        window.Title = "Maui App Concept";

        return window;
    }

    #endregion
}
