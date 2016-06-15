using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Oracle.ManagedDataAccess.Client;

namespace OracleDbProvider.Datatypes
{
	public class QueryResult
	{
		public Dictionary<string, object[]> Content { get; }

		internal QueryResult(OracleDataReader reader)
		{
			
			/*
			var schema = reader.GetSchemaTable();
			if (null == schema)
			{
				throw new Exception("Schema table has not been received");
			}
			
			var columns = schema.Columns;
			var rows = schema.Rows;

			Content = new Dictionary<string, object[]>(columns.Count);			
			foreach (var columnName in 
				from DataColumn column in columns
				select column.ColumnName)
			{
				Content[columnName] = new object[rows.Count];
				foreach (var i in Enumerable.Range(0, rows.Count))
				{
					Content[columnName][i] = rows[i][columnName];
				}
			}
			*/
		}
	}
}
