using System;
using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class OracleDbProvider : IDisposable
	{
		public OracleDbProvider(string ip, string userName, string password)
		{
			var connectionString = BuildConnectionString(ip, userName, password);
			Connection = new OracleConnection(connectionString);
		}

		#region MainFunctions

		public EntitiesContext CreatEntitiesContext()
		{
			return new EntitiesContext(Connection);
		}

		public RawQueriesContext CreateRawQueriesContext()
		{
			return new RawQueriesContext(Connection);
		}

		public RecordsContext CreateRecordsContext()
		{
			return new RecordsContext(Connection);
		}

		public ReplyContext CreateReplyContext()
		{
			return new ReplyContext(Connection);
		}

		#endregion

		public void Dispose()
		{
			Connection.Dispose();
		}

		#region SupportFunctions

		private static string BuildConnectionString(string ip, string userName, string password)
		{
			return $"{userName}/{password}@{ip}:1521/XE";
		}

		#endregion

		private OracleConnection Connection { get; }
	}
}
