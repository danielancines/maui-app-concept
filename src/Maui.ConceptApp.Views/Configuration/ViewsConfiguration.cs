using Maui.ConceptApp.ViewModels;

namespace Maui.ConceptApp.Views.Configuration;

public static class ViewsConfiguration
{
    #region Public Methods
    public static MauiAppBuilder UseViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingletonBindingContext<MainPageView, MainPageViewModel>();

        return mauiAppBuilder;
    }

    static void AddTransientBindingContext<T1, T2>(this IServiceCollection serviceCollection)
        where T1 : BindableObject, new()
        where T2 : class
    {
        serviceCollection.AddTransient(serviceProvider =>
        {
            var targetObject = new T1();
            targetObject.BindingContext = serviceProvider.GetService<T2>();
            return targetObject;
        });
    }

    static void AddSingletonBindingContext<T1, T2>(this IServiceCollection serviceCollection)
    where T1 : BindableObject, new()
    where T2 : class
    {
        serviceCollection.AddSingleton(serviceProvider =>
        {
            var targetObject = new T1();
            targetObject.BindingContext = serviceProvider.GetService<T2>();
            return targetObject;
        });
    }

    #endregion
}
