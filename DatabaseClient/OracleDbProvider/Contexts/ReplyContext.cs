using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class ReplyContext : BaseContext
	{
		internal ReplyContext(OracleConnection connection) : base(connection)
		{
		}
	}
}