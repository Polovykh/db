using System.Data;
using System.Windows.Controls;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для TableControl.xaml
	/// </summary>
	public partial class TableControl : DataGrid
	{
		public TableControl(DataTable table)
		{
			InitializeComponent();
			DataContext = table;
		}

		#region Callbacks



		#endregion

		#region SupportFunctions



		#endregion
	}
}
