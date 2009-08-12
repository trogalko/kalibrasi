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
using System.EnterpriseServices;

using System.Data.OleDb;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.HelperClasses
{
	/// <summary>
	/// General utility class for COM+ transactions. 
	/// </summary>
	[Transaction(TransactionOption.Required)]
	public partial class DbUtilsComPlus : ServicedComponent
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
		/// CTor
		/// </summary>
		public DbUtilsComPlus()
		{
		}


		/// <summary>
		/// Creates a new OleDbConnection
		/// </summary>
		/// <param name="connectionString">Conectionstring To use</param>
		/// <returns>A ready to use, closed, sqlconnection object</returns>
		public OleDbConnection CreateConnection(string connectionString)
		{
			return new OleDbConnection(connectionString);
		}

		/// <summary>
		/// Creates a new closed OleDbConnection object based on the connection string read from the *.config file of the appdomain.
		/// The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		/// </summary>
		/// <returns>A ready to use, closed, OleDbConnection object</returns>
		public OleDbConnection CreateConnection()
		{
			if(ActualConnectionString==string.Empty)
			{
				ActualConnectionString = ConfigFileHelper.ReadConnectionStringFromConfig( connectionKeyString);
			}

			return CreateConnection(ActualConnectionString);
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
