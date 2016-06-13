using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class RawQueriesContext : BaseContext
	{
		internal RawQueriesContext(OracleConnection connection) : base(connection)
		{
		}
	}
}