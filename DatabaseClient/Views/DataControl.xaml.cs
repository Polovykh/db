using System.Windows.Controls;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для DataControl.xaml
	/// </summary>
	public partial class DataControl : UserControl
	{
		public DataControl(RecordsContext context)
		{
			InitializeComponent();
			Context = context;
		}

		private RecordsContext Context { get; }
	}
}
