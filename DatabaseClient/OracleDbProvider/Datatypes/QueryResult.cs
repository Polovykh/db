using System.Data;
using System.Data.Common;
using System.Linq;

namespace OracleDbProvider.Datatypes
{
	public class QueryResult : DataTable
	{
		internal QueryResult(DbDataReader reader) : base()
		{
			Initialize(reader);
		}

		private void Initialize(DbDataReader reader)
		{
			var columnsCount = reader.FieldCount;
			foreach (var columnName in Enumerable.Range(0, columnsCount).Select(reader.GetName))
			{
				Columns.Add(columnName, typeof (string));
			}

			if (!reader.HasRows)
			{
				return;
			}

			while (reader.Read())
			{
				var values = new object[columnsCount];
				reader.GetValues(values);
				Rows.Add(values);
			}
		}
	}
}
