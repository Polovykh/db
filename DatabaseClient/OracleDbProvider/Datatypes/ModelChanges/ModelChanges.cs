using System.Collections.Generic;

namespace OracleDbProvider.Datatypes.ModelChanges
{
	public class ModelChanges
	{
		public string TableName { get; set; }
		public PrimaryKeyChanges PrimaryKeyChanges { get; set; }
		public List<ColumnChanges> ColumnsChanges { get; set; }
		public List<ForeignKeyChanges> ForeignKeyChanges { get; set; } 
		public List<CheckConstraintChanges> CheckConstraintChanges { get; set; }
		public List<UniqueConstraintChanges> UniqueConstraintChanges { get; set; }

		public ModelChanges()
		{
			TableName = string.Empty;
			ColumnsChanges = new List<ColumnChanges>();
			ForeignKeyChanges = new List<ForeignKeyChanges>();
			CheckConstraintChanges = new List<CheckConstraintChanges>();
			UniqueConstraintChanges = new List<UniqueConstraintChanges>();
		}
	}
}
