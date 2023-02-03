using MudBlazor;

namespace Destinity.Services.ThemeProvider;

public class ThemeProvider : IThemeProvider {
	private MudTheme _theme = DefaultTheme.Value;
	
	public MudTheme GetTheme() {
		return _theme;
	}
}