using System.Data;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using OracleDbProvider.Datatypes;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для QueryResultControl.xaml
	/// </summary>
	public partial class QueryResultControl : DataGrid
	{
		public QueryResultControl(DataTable queryResult)
		{
			InitializeComponent();
			DataContext = queryResult;
		}

		#region Callbacks



		#endregion

		#region SupportFunctions



		#endregion
	}
}
