using System.Collections.Generic;
using System.Text;

namespace OracleDbProvider.Datatypes.DataChanges
{
	public class UpdateEvent : BaseEvent
	{
		public override string Query
		{
			get
			{
				var builder = new StringBuilder($"UPDATE {TableName} SET {ColumnName} = {NewColumnValue} WHERE ");
				if (0 == Key.Count)
				{
					return builder.ToString(0, builder.Length - 7);
				}

				foreach (var pair in Key)
				{
					builder.Append($"{pair.Key} = {pair.Value} AND ");
				}

				return builder.ToString(0, builder.Length - 5);
			}
		}
		

		public UpdateEvent(string tableName, string columnName, string newColumnValue, Dictionary<string, string> key)
		{
			TableName = tableName;
			ColumnName = columnName;
			NewColumnValue = newColumnValue;
			Key = key;
		}

		private string TableName { get; }
		private string ColumnName { get; }
		private string NewColumnValue { get; }
		private Dictionary<string, string> Key { get; }
	}
}
