using System;
using System.Windows;
using OracleDbProvider;

namespace DatabaseClient.View
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, IDisposable
	{
		public MainWindow()
		{
			InitializeComponent();
			DbProvider = Initialize();
		}

		public void Dispose()
		{
			DbProvider.Dispose();
		}

		#region SupportFunctions

		private Provider Initialize()
		{
			var dialog = new AuthenticationDialog();
			var authenticationIsSuccessful = dialog.ShowDialog();
			if (true != authenticationIsSuccessful)
			{
				Close();
			}

			return dialog.DbProvider;
		}

		#endregion

		private Provider DbProvider { get; }
	}
}