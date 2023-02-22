using MudBlazor;

namespace Destinity.Theme; 

public class DefaultTheme {
	public static MudTheme Value { get; } = new() {
		Palette = new Palette {
			AppbarBackground = Colors.Shades.White,
			AppbarText = Colors.Shades.Black,
			Primary = new MudColor("#B113F6")
		},
		PaletteDark = new PaletteDark {
			Primary = new MudColor("#B113F6")
		}
	};
}