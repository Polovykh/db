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
		public RawQueriesControl(RawQueriesContext context)
		{
			InitializeComponent();
			Context = context;
		}

		private RawQueriesContext Context { get; }

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			throw new System.NotImplementedException();
		}
	}
}
