using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class RecordsContext : BaseContext
	{
		internal RecordsContext(OracleConnection connection) : base(connection)
		{
		}
	}
}