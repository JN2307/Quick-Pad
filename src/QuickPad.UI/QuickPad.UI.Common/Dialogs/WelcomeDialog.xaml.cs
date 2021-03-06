﻿using Windows.UI.Xaml.Controls;
using QuickPad.Mvvm.Commands;
using QuickPad.Mvvm.Models.Theme;
using QuickPad.Mvvm.ViewModels;
using QuickPad.UI.Common.Theme;
using Windows.ApplicationModel.Resources;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace QuickPad.UI.Common.Dialogs
{
    public sealed partial class WelcomeDialog
    {
        private DocumentViewModel _viewModel;
        public IVisualThemeSelector VtSelector => VisualThemeSelector.Current;

        public QuickPadCommands Commands { get; }
        public ResourceLoader ResourceLoader { get; }
        public SettingsViewModel Settings { get; }

        public DocumentViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel == value) return;

                DataContext = _viewModel = value;
            }
        }

        public WelcomeDialog(QuickPadCommands commands, SettingsViewModel settings, ResourceLoader resourceLoader)
        {
            Settings = settings;
            Commands = commands;
            ResourceLoader = resourceLoader;
            this.InitializeComponent();

            //this.Title = ResourceLoader.GetString("WelcomeDialogTitle/Title");
            //Par1.Text = ResourceLoader.GetString("WelcomeDialogPar1/Text");
            //Par2.Text = ResourceLoader.GetString("WelcomeDialogPar2/Text");
            //CmdClose.Content = ResourceLoader.GetString("CmdLetsGo/Content");
        }

        private void CmdClose_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Hide();
        }
    }
}
