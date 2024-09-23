﻿namespace SystemDot.Web.Razor.MaterialCompontents.Examples.Views.Shared;

public record MenuItem
{
    public string Name { get; init; }
    public string Icon { get; init; }
    public bool IsSelected { get; init; }

    public static MenuItem CreateMenuItem(string name, string icon, string nameOfSelectedItem) =>
        new()
        {
            Name = name,
            Icon = icon,
            IsSelected = nameOfSelectedItem == name
        };
}