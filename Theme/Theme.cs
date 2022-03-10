using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Forosh.Views.Theme
{
    public static class Theme
    {
        public static void changeTheme(ThemeName theme)
        {

            Application.Current.Resources.MergedDictionaries.Clear();

            if (theme == ThemeName.firtstTheme)
            {
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/Theme;component/ColorThemes/CT1.xaml")
                });
            }
            else if (theme == ThemeName.secondTheme)
            {
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/Theme;component/ColorThemes/CT2.xaml")
                });
            }
            else if (theme == ThemeName.thirdTheme)
            {
                Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/Theme;component/ColorThemes/CT3.xaml")
                });
            }

        }
    }
    public enum ThemeName
    {
        firtstTheme,
        secondTheme,
        thirdTheme
    }
}
