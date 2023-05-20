using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Capsules.Shared;

public partial class MainLayout
{
    [Inject] private ILocalStorageService LocalStorage { get; set; }
    [Inject] private IJSRuntime Js { get; set; }

    private bool IsDarkMode { get; set; }

    protected override void OnInitialized()
    {
        GetTheme();

        base.OnInitialized();
    }

    private async Task GetTheme()
    {
        var theme = await LocalStorage.GetItemAsStringAsync("theme") ?? "light";
        IsDarkMode = await Js.InvokeAsync<bool>("setTheme", theme);
    }

    private async Task ToggleDarkMode()
    {
        var theme = await LocalStorage.GetItemAsStringAsync("theme") ?? "light";

        switch (theme)
        {
            default:
            case "light":
                await LocalStorage.SetItemAsStringAsync("theme", "dark");
                await Js.InvokeVoidAsync("toggleTheme", "dark");
                IsDarkMode = false;
                break;
            case "dark":
                await LocalStorage.SetItemAsStringAsync("theme", "light");
                await Js.InvokeVoidAsync("toggleTheme", "light");
                IsDarkMode = true;
                break;
        }
    }
}