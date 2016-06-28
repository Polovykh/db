using System.Data;
using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes;

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

		public int Execute(string query, DataTable dataTable)
		{
			using (var adapter = new OracleDataAdapter(query, Connection)
			{
				MissingSchemaAction = MissingSchemaAction.AddWithKey
			})
			{
				return adapter.Fill(dataTable);
			}
		}

		public int Execute(string query)
		{
			var command = new OracleCommand(query, Connection);
			return command.ExecuteNonQuery();
		}
	}
}
