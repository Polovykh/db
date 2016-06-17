using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class DataContext : BaseContext
	{
		internal DataContext(OracleConnection connection) : base(connection)
		{
		}
	}
}