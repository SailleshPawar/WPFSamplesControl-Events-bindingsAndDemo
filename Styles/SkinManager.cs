using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Styles
{
    public enum AppSkin
    {
        Default,
        Green
    }
    public  static class SkinManager
    {
        public static AppSkin CurrentThemeType { get; private set; }
        public static void SetSkin(AppSkin skin)
        {
            CurrentThemeType = skin;
            Application.Current.Resources.MergedDictionaries[0].MergedDictionaries.Clear();
            var newDictionary = new ResourceDictionary();
            switch (skin)
            {
                case AppSkin.Default:
                    newDictionary.Source = new Uri("pack://application:,,,Styles;Skins/DefaultSkin.xaml");
                    break;
                case AppSkin.Green:
                    newDictionary.Source = new Uri("pack://application:,,,Styles;ControlTemplates/RoundButtonTemplate.xaml");
                    break;
            }
            Application.Current.Resources.MergedDictionaries[0].MergedDictionaries.Add(newDictionary);
        }
    }
}
