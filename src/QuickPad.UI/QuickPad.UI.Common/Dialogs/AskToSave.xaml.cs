﻿using Windows.UI.Xaml.Controls;
using QuickPad.Mvvm.Commands;
using QuickPad.Mvvm.Models.Theme;
using QuickPad.Mvvm.ViewModels;
using QuickPad.UI.Common.Theme;
using Windows.ApplicationModel.Resources;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QuickPad.UI.Common.Dialogs
{
    public sealed partial class AskToSave
    {
        private DocumentViewModel _viewModel;
        public IVisualThemeSelector VtSelector => VisualThemeSelector.Current;
        public QuickPadCommands Commands { get; }
        public ResourceLoader ResourceLoader { get; }

        public DocumentViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel == value) return;

                DataContext = _viewModel = value;
            }
        }

        public AskToSave(QuickPadCommands commands, ResourceLoader resourceLoader)
        {
            Commands = commands;
            ResourceLoader = resourceLoader;
            this.InitializeComponent();

            this.Title = ResourceLoader.GetString("SaveDialog/Title");
            this.PrimaryButtonText = ResourceLoader.GetString("SaveDialog/PrimaryButtonText");
            this.SecondaryButtonText = ResourceLoader.GetString("SaveDialog/SecondaryButtonText");
            this.CloseButtonText = ResourceLoader.GetString("SaveDialog/CloseButtonText");
            Content.Text = ResourceLoader.GetString("WouldYouLikeToSave/Text");
        }

        private void AskToSave_OnSecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }
    }
}
