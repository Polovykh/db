using System.Windows.Controls;
using OracleDbProvider.Contexts;

namespace DatabaseClient.Views
{
	/// <summary>
	/// Логика взаимодействия для ModelControl.xaml
	/// </summary>
	public partial class ModelControl : UserControl
	{
		public ModelControl(ModelContext dbContext)
		{
			InitializeComponent();
			DbContext = dbContext;
		}

		private ModelContext DbContext { get; }
	}
}
