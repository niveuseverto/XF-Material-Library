﻿using Xamarin.Forms;
using XF.Material.Resources;

namespace XF.Material.Views
{
    public class MaterialNavigationPage : NavigationPage
    {
        public static readonly BindableProperty HasShadowProperty = BindableProperty.Create(nameof(HasShadow), typeof(bool), typeof(MaterialNavigationPage), true);

        public bool HasShadow
        {
            get => (bool)GetValue(HasShadowProperty);
            set => SetValue(HasShadowProperty, value);
        }

        public MaterialNavigationPage(Page rootPage) : base(rootPage)
        {
            this.SetDynamicResource(BarBackgroundColorProperty, MaterialConstants.MATERIAL_COLOR_PRIMARY);
            this.SetDynamicResource(BarTextColorProperty, MaterialConstants.MATERIAL_COLOR_ONPRIMARY);
            this.Pushed += this.MaterialNavigationPage_Pushed;
            rootPage.SetDynamicResource(BackgroundColorProperty, MaterialConstants.MATERIAL_COLOR_BACKGROUND);
        }

        private void MaterialNavigationPage_Pushed(object sender, NavigationEventArgs e)
        {
            if(e?.Page != null)
            {
                e.Page.SetDynamicResource(BackgroundColorProperty, MaterialConstants.MATERIAL_COLOR_BACKGROUND);
            }
        }
    }
}
