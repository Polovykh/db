using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class RecordsContext : BaseContext
	{
		internal RecordsContext(OracleConnection connection) : base(connection)
		{
		}
	}
}