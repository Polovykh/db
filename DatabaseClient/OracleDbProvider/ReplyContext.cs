using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class ReplyContext : BaseContext
	{
		internal ReplyContext(OracleConnection connection) : base(connection)
		{
		}
	}
}