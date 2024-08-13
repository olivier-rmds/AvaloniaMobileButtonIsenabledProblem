using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using System;

namespace ButtonIsEnabledTest.Views
{
	public partial class MainView : UserControl
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
		{
			btnThatDoesThings.IsEnabled = false; //change is enabled state to prevent people from cliking again while treatment is ongoing
			Rectangle rectangle = new Rectangle() { Width = 25, Height=25, Fill=Brushes.Lime };
			ugThatChanges.Children.Add(rectangle);
			btnThatDoesThings.IsEnabled = true;
		}
	}
}