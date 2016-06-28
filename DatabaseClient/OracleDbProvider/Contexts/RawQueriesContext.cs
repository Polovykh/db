using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class RawQueriesContext : BaseContext
	{
		internal RawQueriesContext(OracleConnection connection) : base(connection)
		{
		}
	}
}