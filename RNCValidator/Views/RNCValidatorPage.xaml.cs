using System;
using System.Collections.Generic;
using RNCValidator.ViewModels;
using Xamarin.Forms;

namespace RNCValidator.Views
{
    public partial class RNCValidatorPage : ContentPage
    {
        public RNCValidatorPage()
        {
            InitializeComponent();
            this.BindingContext = new RNCValidatorPageViewModel();
        }
    }
}
