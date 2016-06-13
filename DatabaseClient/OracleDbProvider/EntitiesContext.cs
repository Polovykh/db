using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class EntitiesContext : BaseContext
	{
		internal EntitiesContext(OracleConnection connection) : base(connection)
		{
		}
	}
}
