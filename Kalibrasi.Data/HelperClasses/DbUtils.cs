///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:36 PM
// Code is generated using templates: SD.TemplateBindings.AccessSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Configuration;

using System.Data.OleDb;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.HelperClasses
{
	/// <summary>
	/// General utility methods used for Access usage by the framework. 
	/// </summary>
	public partial class DbUtils
	{
		#region Public Static Members
		public static string ActualConnectionString = string.Empty;
		#endregion

		#region Constants
		private const string connectionKeyString = "Main.ConnectionString";
		#endregion

		#region Class Member Declarations
		private static int _commandTimeOut = 30;
		#endregion

		/// <summary>
		/// Private CTor, no instatiation possible
		/// </summary>
		private DbUtils()
		{
		}


		/// <summary>
		/// Creates a new OleDbConnection
		/// </summary>
		/// <param name="connectionString">Connectionstring To use</param>
		/// <returns>A ready to use, closed, OleDbConnection object</returns>
		public static OleDbConnection CreateConnection(string connectionString)
		{
			return new OleDbConnection(connectionString);
		}


		/// <summary>
		/// Creates a new closed OleDbConnection object based on the connection string read from the *.config file of the appdomain.
		/// The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		/// </summary>
		/// <returns>A ready to use, closed, OleDbConnection object</returns>
		public static OleDbConnection CreateConnection()
		{
			if(ActualConnectionString==string.Empty)
			{
				ActualConnectionString = ConfigFileHelper.ReadConnectionStringFromConfig( connectionKeyString);
			}

			return CreateConnection(ActualConnectionString);
		}


		/// <summary>
		/// Determines which connection to use: the connection held by the passed in transaction (if any) or a new one (if no Transaction was passed in)
		/// </summary>
		/// <param name="containingTransaction">A transaction the caller participates in. If null, the caller is not participating in a transaction</param>
		/// <returns>A ready to use connection object</returns>
		public static IDbConnection DetermineConnectionToUse(ITransaction containingTransaction)
		{
			if(containingTransaction!=null)
			{
				return containingTransaction.ConnectionToUse;
			}
			else
			{
				return CreateConnection();
			}
		}


		/// <summary>
		/// Creates a new OleDbDataAdapter.
		/// </summary>
		/// <returns></returns>
		public static OleDbDataAdapter CreateDataAdapter()
		{
			return new OleDbDataAdapter();
		}


		/// <summary>
		/// Creates a new OleDbTransaction transaction
		/// </summary>
		/// <param name="connectionToUse">the connection to use</param>
		/// <param name="isolationLevelToUse">the isolation level to use</param>
		/// <param name="name">the name for the transaction</param>
		/// <returns>new OleDbTransaction object.</returns>
		public static OleDbTransaction CreateTransaction(IDbConnection connectionToUse, IsolationLevel isolationLevelToUse, string name)
		{
			return ((OleDbConnection)connectionToUse).BeginTransaction(isolationLevelToUse);
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets the command time out (in seconds). This is a global setting, so every Command object created after you've set this
		/// property to a value will have that value as CommandTimeOut. Default is 30 seconds which is the ADO.NET default.
		/// </summary>
		public static int CommandTimeOut
		{
			get
			{
				return _commandTimeOut;
			}
			set
			{
				_commandTimeOut = value;
				SD.LLBLGen.Pro.DQE.Access.DynamicQueryEngine.CommandTimeOut = _commandTimeOut;
			}
		}
		#endregion


		#region Included Code

		#endregion
	}
}
