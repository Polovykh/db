using System.Collections.Generic;
using System.Data;
using System.Linq;
using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes;
using OracleDbProvider.Datatypes.DataChanges;

namespace OracleDbProvider.Contexts
{
	public class DataContext : BaseContext
	{
		internal DataContext(OracleConnection connection) : base(connection)
		{
		}

		public IEnumerable<string> GetTablesNames()
		{
			var command = new OracleCommand("SELECT table_name FROM user_tables", Connection);
			using (var reader = command.ExecuteReader(CommandBehavior.KeyInfo))
			{
				if (!reader.HasRows)
				{
					return Enumerable.Empty<string>();
				}

				var result = new List<string>();
				while (reader.Read())
				{
					result.Add(reader.GetString(0));
				}

				return result;
			}
		}

		public DataTable GetTable(string tableName)
		{
			var dataTable = new DataTable();

			return 0 < Execute($"SELECT * FROM {tableName}", dataTable) ? dataTable : null;
		}

		public bool Update(UpdateEvent e)
		{
			return 1 == Execute(e.Query);
		}

		// $"INSERT INTO {tableName} ({columnName}) VALUES ({value}"
	}
}