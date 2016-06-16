using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace OracleDbProvider.Datatypes
{
	public class QueryResult
	{
		public Dictionary<string, List<string>> Content { get; }

		internal QueryResult(DbDataReader reader)
		{
			Content = Initialize(reader);
		}

		private static Dictionary<string, List<string>> Initialize(DbDataReader reader)
		{
			var dictionary = new Dictionary<string, List<string>>();
			var columnsCount = reader.FieldCount;
			var columnsNames = new List<string>(columnsCount);
			//var columnsTypes = new List<Type>(columnsCount); 

			foreach (var columnNo in Enumerable.Range(0, columnsCount))
			{
				var columnName = reader.GetName(columnNo);
				//var columnType = reader.GetFieldType(columnNo);
				columnsNames.Add(columnName);
				//columnsTypes.Add(columnType);
				dictionary[columnName] = new List<string>();
			}

			if (!reader.HasRows)
			{
				return dictionary;
			}

			while (reader.Read())
			{
				foreach (var columnNo in Enumerable.Range(0, columnsCount))
				{
					var columnName = columnsNames[columnNo];
					var columnValue = reader.GetValue(columnNo).ToString();
					dictionary[columnName].Add(columnValue);
				}			
			}

			return dictionary;
		}
	}
}
