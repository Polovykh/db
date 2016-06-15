using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes;

namespace OracleDbProvider.Contexts
{
	public class RawQueriesContext : BaseContext
	{
		internal RawQueriesContext(OracleConnection connection) : base(connection)
		{
		}

		public QueryResult Execute(string query)
		{
			var command = new OracleCommand(query, Connection);
			using (var reader = command.ExecuteReader())
			{
				return new QueryResult(reader);		
			}
		} 
	}
}