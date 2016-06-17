using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes.TableChanges;

namespace OracleDbProvider.Contexts
{
	public class ModelContext : BaseContext
	{
		internal ModelContext(OracleConnection connection) : base(connection)
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
