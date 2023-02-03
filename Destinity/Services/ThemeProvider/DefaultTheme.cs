﻿using MudBlazor;

namespace Destinity.Services.ThemeProvider; 

public class DefaultTheme {
	public static MudTheme Value { get; } = new() {
		Palette = new Palette {
			AppbarBackground = Colors.Shades.White,
			AppbarText = Colors.Shades.Black
		}
	};
}