﻿using AmbientSounds.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbientSounds.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = DependencyService.Resolve<MainPageViewModel>();
        }
    }
}