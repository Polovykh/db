using System;
using System.Windows;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
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

			// TEST
			using (var ctx = DbProvider.RawQueriesContext)
			{
				//var queryResult = ctx.Execute(@"CREATE TABLE test ( column1 NUMBER PRIMARY KEY )");
				//queryResult = ctx.Execute(@"INSERT INTO test VALUES (1)");
				//queryResult = ctx.Execute(@"SELECT * FROM test");
				//queryResult = ctx.Execute(@"DROP TABLE test");
			}
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