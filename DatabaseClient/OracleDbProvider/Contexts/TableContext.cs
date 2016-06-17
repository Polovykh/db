using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes.TableChanges;

namespace OracleDbProvider.Contexts
{
	public class TableContext : BaseContext
	{
		internal TableContext(OracleConnection connection) : base(connection)
		{
		}

		public void CreateTable(TableChanges changes)
		{
			
		}

		public void UpdateTable(TableChanges changes)
		{
			
		}

		public void DeleteTable(TableChanges changes)
		{
			
		}
	}
}
