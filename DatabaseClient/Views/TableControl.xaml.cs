using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Windows.Controls;
using OracleDbProvider.Contexts;
using OracleDbProvider.Datatypes.DataChanges;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для TableControl.xaml
	/// </summary>
	public partial class TableControl : DataGrid
	{
		public TableControl(DataTable table, DataContext dbContext = null)
		{
			InitializeComponent();
			DataContext = table;
			Table = table;
			DbContext = dbContext;
		}

		#region Callbacks

		protected override void OnCellEditEnding(DataGridCellEditEndingEventArgs e)
		{
			base.OnCellEditEnding(e);

			var changedColumnName = e.Column.Header.ToString();
			var rowNo = e.Row.AlternationIndex;
			var newValue = (e.EditingElement as TextBox)?.Text;

			var key = new Dictionary<string, string>();
			foreach (var keyColumnName in Table.PrimaryKey.Select(column => column.ColumnName))
			{
				key[keyColumnName] = Table.Rows[rowNo][keyColumnName].ToString();
			}

			try
			{
				var updateEvent = new UpdateEvent(Table.TableName, changedColumnName, newValue, key);
				DbContext.Update(updateEvent);
			}
			catch (Exception exception)
			{
				/*e.Cancel = true;
				CancelEdit();
				UnselectAll();*/
			}
		}

		#endregion

		#region SupportFunctions



		#endregion

		private DataTable Table { get; }
		private DataContext DbContext { get; }
	}
}
