﻿using Microsoft.Maui.Controls;

namespace sharki;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}