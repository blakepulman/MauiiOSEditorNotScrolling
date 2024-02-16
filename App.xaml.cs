using Microsoft.Maui.Controls;

namespace MauiIosEditorScrollingBugDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}