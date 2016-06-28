using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для RawQueriesControl.xaml
	/// </summary>
	public partial class RawQueriesControl : UserControl
	{
		public RawQueriesControl(RawQueriesContext dbContext)
		{
			InitializeComponent();
			DbContext = dbContext;
		}

		#region Callbacks

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			var queryBody = QueryBox.Text;
			var content = Content.Children;
			content.Clear();

			if (string.IsNullOrEmpty(queryBody))
			{
				content.Add(WrapMessage("Query body is empty"));
				return;
			}

			try
			{
				var queryResult = new DataTable();
				if (0 >= DbContext.Execute(queryBody, queryResult))
				{
					throw new Exception();
				}
				
				var queryResultControl = new TableControl(queryResult)
				{
					IsReadOnly = true
				};
				content.Add(queryResultControl);
			}
			catch (Exception exception)
			{
				content.Add(WrapMessage(exception.Message));
			}
		}

		#endregion

		#region SupportFunctions

		private static Label WrapMessage(string message)
		{
			return new Label()
			{
				Content = message,
				FontSize = 14,
				HorizontalContentAlignment = HorizontalAlignment.Center,
				VerticalContentAlignment = VerticalAlignment.Center
			};
		}

		#endregion

		private RawQueriesContext DbContext { get; }
	}
}
