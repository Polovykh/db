using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Contexts
{
	public class BaseContext : IDisposable
	{
		protected OracleConnection Connection { get; }

		internal BaseContext(OracleConnection connection)
		{
			if (ConnectionState.Closed != connection.State)
			{
				throw new Exception("Attempt to reopen connection");
			}

			Connection = connection;
			Connection.Open();
		}

		public void Dispose()
		{
			Connection.Close();
		}
	}
}
