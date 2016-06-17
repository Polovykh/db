using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class BaseContext
	{
		protected OracleConnection Connection { get; }

		internal BaseContext(OracleConnection connection)
		{
			if (ConnectionState.Closed != connection.State)
			{
				connection.Close();
			}

			Connection = connection;
			Connection.Open();
		}
	}
}
