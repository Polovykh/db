using System.Windows.Controls;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для ModelControl.xaml
	/// </summary>
	public partial class ModelControl : UserControl
	{
		public ModelControl(TableContext context)
		{
			InitializeComponent();
			Context = context;
		}

		private TableContext Context { get; }
	}
}
