using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider
{
	public class Provider : IDisposable
	{
		public Provider(string hostName, string userName, string password)
		{
			var connectionString = BuildConnectionString(hostName, userName, password);
			Connection = new OracleConnection(connectionString);
			CheckConnection(Connection);
		}

		#region MainFunctions

		public EntitiesContext EntitiesContext => new EntitiesContext(Connection);

		public RawQueriesContext RawQueriesContext => new RawQueriesContext(Connection);
		
		public RecordsContext RecordsContext => new RecordsContext(Connection);

		public ReplyContext ReplyContext => new ReplyContext(Connection);

		#endregion

		public void Dispose()
		{
			Connection.Dispose();
		}

		#region SupportFunctions

		private static void CheckConnection(IDbConnection connection)
		{
			connection.Open();
			if (0 == (connection.State & ConnectionState.Open))
			{
				throw new Exception("Connection is unavailable");
			}

			connection.Close();
		}

		private static string BuildConnectionString(string hostName, string userName, string password)
		{
			return $"Data Source={hostName}:1521/XE; User Id={userName}; Password={password}";
		}

		#endregion

		private OracleConnection Connection { get; }
	}
}
