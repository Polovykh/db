using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using Microsoft.CSharp.RuntimeBinder;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для DataControl.xaml
	/// </summary>
	public partial class DataControl : UserControl
	{
		public IEnumerable<ComboBoxItem> TablesNames => DbContext
			.GetTablesNames()
			.Select(s => new ComboBoxItem
			{
				Content = s
			});

		public DataControl(DataContext dbContext)
		{
			InitializeComponent();
			DbContext = dbContext;
			ComboBox.DataContext = TablesNames;
		}

		#region Callbacks

		private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var item = ComboBox.SelectedItem as ComboBoxItem;
			if (null == item)
			{
				throw new RuntimeBinderException();
			}

			var tableName = item.Content.ToString();
			var table = DbContext.GetTable(tableName);

			var content = Content.Children;
			content.Clear();
			content.Add(new TableControl(table, DbContext));
		}

		#endregion

		#region SupportFunctions



		#endregion

		private DataContext DbContext { get; }
	}
}
