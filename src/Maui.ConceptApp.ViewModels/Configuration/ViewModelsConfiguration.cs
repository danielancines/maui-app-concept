namespace Maui.ConceptApp.ViewModels.Configuration;

public static class ViewModelsConfiguration
{
    #region Public Methods
    public static MauiAppBuilder UseViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<MainPageViewModel>();

        return mauiAppBuilder;
    }

    #endregion
}
