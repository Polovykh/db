using System;
using System.Windows;
using OracleDbProvider;

namespace DatabaseClient.View
{
	/// <summary>
	/// Логика взаимодействия для AuthenticationDialog.xaml
	/// </summary>
	public partial class AuthenticationDialog : Window
	{
		public AuthenticationDialog()
		{
			InitializeComponent();
		}

		private void Apply_OnClick(object sender, RoutedEventArgs e)
		{
			try
			{
				DbProvider = new Provider(Hostname.Text, Username.Text, Password.Password);
				DialogResult = true;
				Close();
			}
			catch (Exception exception)
			{
				Error.Content = exception.Message;
			}
		}

		private void Cancel_OnClick(object sender, RoutedEventArgs e)
		{
			DialogResult = false;
			Close();
		}

		public Provider DbProvider { get; private set; }
	}
}
