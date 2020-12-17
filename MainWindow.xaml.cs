using System;
using System.Windows;
using TheDonMVVMTutorial.ViewModel;

namespace TheDonMVVMTutorial
{
    public partial class MainWindow : Window
    {
        #region ViewModels
        private MainWindowViewModel viewModel;
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();
            DataContext = viewModel;
        }
    }
}
