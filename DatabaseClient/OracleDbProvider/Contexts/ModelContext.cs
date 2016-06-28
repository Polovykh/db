using Oracle.ManagedDataAccess.Client;
using OracleDbProvider.Datatypes.ModelChanges;

namespace OracleDbProvider.Contexts
{
	public class ModelContext : BaseContext
	{
		internal ModelContext(OracleConnection connection) : base(connection)
		{
		}

		public void CreateTable(ModelChanges changes)
		{
			
		}

		public void UpdateTable(ModelChanges changes)
		{
			
		}

		public void DeleteTable(ModelChanges changes)
		{
			
		}
	}
}
