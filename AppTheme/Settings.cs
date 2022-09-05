using Xamarin.Essentials;

namespace AppTheme
{
    public static class Settings
    {
        // 0 = Default, 1 = light, 2 = dark.
        const int theme = 0;
        public static int Theme
        {
            get => Preferences.Get(nameof(Theme), theme);
            set => Preferences.Set(nameof(Theme), value);
        }
    }
}
