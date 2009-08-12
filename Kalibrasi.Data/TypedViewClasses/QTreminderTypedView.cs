///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:47 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif

using Kalibrasi.Data;
using Kalibrasi.Data.HelperClasses;
using Kalibrasi.Data.DaoClasses;
using Kalibrasi.Data.EntityClasses;
using Kalibrasi.Data.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.TypedViewClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>
	/// Typed datatable for the view 'QTreminder'.<br/><br/>
	/// 
	/// </summary>
	/// <remarks>
	/// It embeds a fill method which accepts a filter.
	/// The code doesn't support any changing of data. Users who do that are on their own.
	/// It also doesn't support any event throwing. This view should be used as a base for readonly databinding
	/// or dataview construction.
	/// </remarks>
#if !CF
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
#endif	
	public partial class QTreminderTypedView : TypedViewBase<QTreminderRow>, ITypedView
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private DataColumn _columnCIdAlat;
		private DataColumn _columnCNamaAlat;
		private DataColumn _columnCNamaDept;
		private DataColumn _columnCNamaLokasi;
		private DataColumn _columnDPlan;
		private DataColumn _columnDConfirmRencana;
		private DataColumn _columnDRealisation;
		private DataColumn _columnCPic;
		private DataColumn _columnMKeterangan;
		private DataColumn _columnNInterval;
		private DataColumn _columnCPeriode;
		private DataColumn _columnBulan;
		private DataColumn _columnTahun;
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 13;
		#endregion


		/// <summary>
		/// Static CTor for setting up custom property hashtables. Is executed before the first instance of this
		/// class or derived classes is constructed. 
		/// </summary>
		static QTreminderTypedView()
		{
			SetupCustomPropertyHashtables();
		}
		

		/// <summary>
		/// CTor
		/// </summary>
		public QTreminderTypedView():base("QTreminder")
		{
			InitClass();
		}
		
#if !CF		
		/// <summary>
		/// Protected constructor for deserialization.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected QTreminderTypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
#endif

		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned
		/// </summary>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill()
		{
			return Fill(0, null, true, null, null, null, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will not use a filter, will allow duplicate rows.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, true, null, null, null, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will not use a filter.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, null, null, null, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, null, null, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, null, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 
			IGroupByCollection groupByClause)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 
			IGroupByCollection groupByClause, int pageNumber, int pageSize)
		{
			// Build resultset
			IEntityFields fieldsInResultset = GetFields();
			
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call fieldsInResultset.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			TypedListDAO dao = DAOFactory.CreateTypedListDAO();
			return dao.GetMultiAsDataTable(fieldsInResultset, this, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize);
		}
		
		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QTreminderTypedView);
		}


		/// <summary>Gets an array of all QTreminderRow objects.</summary>
		/// <returns>Array with QTreminderRow objects</returns>
		public new QTreminderRow[] Select()
		{
			return (QTreminderRow[])base.Select();
		}


		/// <summary>Gets an array of all QTreminderRow objects that match the filter criteria in order of primary key (or lacking one, order of addition.) </summary>
		/// <param name="filterExpression">The criteria to use to filter the rows.</param>
		/// <returns>Array with QTreminderRow objects</returns>
		public new QTreminderRow[] Select(string filterExpression)
		{
			return (QTreminderRow[])base.Select(filterExpression);
		}


		/// <summary>Gets an array of all QTreminderRow objects that match the filter criteria, in the specified sort order</summary>
		/// <param name="filterExpression">The filter expression.</param>
		/// <param name="sort">A string specifying the column and sort direction.</param>
		/// <returns>Array with QTreminderRow objects</returns>
		public new QTreminderRow[] Select(string filterExpression, string sort)
		{
			return (QTreminderRow[])base.Select(filterExpression, sort);
		}


		/// <summary>Gets an array of all QTreminderRow objects that match the filter criteria, in the specified sort order that match the specified state</summary>
		/// <param name="filterExpression">The filter expression.</param>
		/// <param name="sort">A string specifying the column and sort direction.</param>
		/// <param name="recordStates">One of the <see cref="System.Data.DataViewRowState"/> values.</param>
		/// <returns>Array with QTreminderRow objects</returns>
		public new QTreminderRow[] Select(string filterExpression, string sort, DataViewRowState recordStates)
		{
			return (QTreminderRow[])base.Select(filterExpression, sort, recordStates);
		}
		
		/// <summary>
		/// Gets the amount of rows in the database for this typed view, not skipping duplicates
		/// </summary>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount()
		{
			return GetDbCount(true, null);
		}
		
		
		/// <summary>
		/// Gets the amount of rows in the database for this typed view.
		/// </summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates)
		{
			return GetDbCount(allowDuplicates, null);
		}

		
		/// <summary>
		/// Gets the amount of rows in the database for this typed list.
		/// </summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates, IPredicateExpression filter)
		{
			return GetDbCount(allowDuplicates, filter, null);
		}


		/// <summary>
		/// Gets the amount of rows in the database for this typed list.
		/// </summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public virtual int GetDbCount(bool allowDuplicates, IPredicateExpression filter, GroupByCollection groupByClause)
		{
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QTreminderTypedView);
			TypedListDAO dao = DAOFactory.CreateTypedListDAO();
			return dao.GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}


		/// <summary>
		/// Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.
		/// </summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new QTreminderRow(rowBuilder);
		}


		/// <summary>
		/// Initializes the hashtables for the typed view type and typed view field custom properties. 
		/// </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();

			// Add custom properties of this type

			// Add per Field a new Hashtable with its custom properties, indexed by the name of the field.
			Hashtable fieldHashtable = null;
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CIdAlat", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CNamaAlat", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CNamaDept", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CNamaLokasi", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DPlan", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DConfirmRencana", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("DRealisation", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CPic", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("MKeterangan", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("NInterval", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CPeriode", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Bulan", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("Tahun", fieldHashtable);
						
		}


		/// <summary>
		/// Initialize the datastructures.
		/// </summary>
		protected override void InitClass()
		{
			TableName = "QTreminder";		
			
			_columnCIdAlat = new DataColumn("CIdAlat", typeof(System.String), null, MappingType.Element);
			_columnCIdAlat.ReadOnly = true;
			_columnCIdAlat.Caption = @"CIdAlat";
			this.Columns.Add(_columnCIdAlat);

			_columnCNamaAlat = new DataColumn("CNamaAlat", typeof(System.String), null, MappingType.Element);
			_columnCNamaAlat.ReadOnly = true;
			_columnCNamaAlat.Caption = @"CNamaAlat";
			this.Columns.Add(_columnCNamaAlat);

			_columnCNamaDept = new DataColumn("CNamaDept", typeof(System.String), null, MappingType.Element);
			_columnCNamaDept.ReadOnly = true;
			_columnCNamaDept.Caption = @"CNamaDept";
			this.Columns.Add(_columnCNamaDept);

			_columnCNamaLokasi = new DataColumn("CNamaLokasi", typeof(System.String), null, MappingType.Element);
			_columnCNamaLokasi.ReadOnly = true;
			_columnCNamaLokasi.Caption = @"CNamaLokasi";
			this.Columns.Add(_columnCNamaLokasi);

			_columnDPlan = new DataColumn("DPlan", typeof(System.DateTime), null, MappingType.Element);
			_columnDPlan.ReadOnly = true;
			_columnDPlan.Caption = @"DPlan";
			this.Columns.Add(_columnDPlan);

			_columnDConfirmRencana = new DataColumn("DConfirmRencana", typeof(System.DateTime), null, MappingType.Element);
			_columnDConfirmRencana.ReadOnly = true;
			_columnDConfirmRencana.Caption = @"DConfirmRencana";
			this.Columns.Add(_columnDConfirmRencana);

			_columnDRealisation = new DataColumn("DRealisation", typeof(System.DateTime), null, MappingType.Element);
			_columnDRealisation.ReadOnly = true;
			_columnDRealisation.Caption = @"DRealisation";
			this.Columns.Add(_columnDRealisation);

			_columnCPic = new DataColumn("CPic", typeof(System.String), null, MappingType.Element);
			_columnCPic.ReadOnly = true;
			_columnCPic.Caption = @"CPic";
			this.Columns.Add(_columnCPic);

			_columnMKeterangan = new DataColumn("MKeterangan", typeof(System.String), null, MappingType.Element);
			_columnMKeterangan.ReadOnly = true;
			_columnMKeterangan.Caption = @"MKeterangan";
			this.Columns.Add(_columnMKeterangan);

			_columnNInterval = new DataColumn("NInterval", typeof(System.Int16), null, MappingType.Element);
			_columnNInterval.ReadOnly = true;
			_columnNInterval.Caption = @"NInterval";
			this.Columns.Add(_columnNInterval);

			_columnCPeriode = new DataColumn("CPeriode", typeof(System.String), null, MappingType.Element);
			_columnCPeriode.ReadOnly = true;
			_columnCPeriode.Caption = @"CPeriode";
			this.Columns.Add(_columnCPeriode);

			_columnBulan = new DataColumn("Bulan", typeof(System.Int16), null, MappingType.Element);
			_columnBulan.ReadOnly = true;
			_columnBulan.Caption = @"Bulan";
			this.Columns.Add(_columnBulan);

			_columnTahun = new DataColumn("Tahun", typeof(System.Int16), null, MappingType.Element);
			_columnTahun.ReadOnly = true;
			_columnTahun.Caption = @"Tahun";
			this.Columns.Add(_columnTahun);
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitialized();
		}


		/// <summary>
		/// Initializes the members, after a clone action.
		/// </summary>
		private void InitMembers()
		{
			_columnCIdAlat = this.Columns["CIdAlat"];
			_columnCNamaAlat = this.Columns["CNamaAlat"];
			_columnCNamaDept = this.Columns["CNamaDept"];
			_columnCNamaLokasi = this.Columns["CNamaLokasi"];
			_columnDPlan = this.Columns["DPlan"];
			_columnDConfirmRencana = this.Columns["DConfirmRencana"];
			_columnDRealisation = this.Columns["DRealisation"];
			_columnCPic = this.Columns["CPic"];
			_columnMKeterangan = this.Columns["MKeterangan"];
			_columnNInterval = this.Columns["NInterval"];
			_columnCPeriode = this.Columns["CPeriode"];
			_columnBulan = this.Columns["Bulan"];
			_columnTahun = this.Columns["Tahun"];
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}


		/// <summary>
		/// Return the type of the typed datarow
		/// </summary>
		/// <returns>returns the requested type</returns>
		protected override Type GetRowType() 
		{
			return typeof(QTreminderRow);
		}


		/// <summary>
		/// Clones this instance.
		/// </summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			QTreminderTypedView cloneToReturn = ((QTreminderTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}

#if !CF
		/// <summary>
		/// Creates a new instance of the DataTable class.
		/// </summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new QTreminderTypedView();
		}
#endif

		#region Class Property Declarations
		/// <summary>
		/// Returns the amount of rows in this typed view.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public int Count 
		{
			get 
			{
				return this.Rows.Count;
			}
		}
		
		/// <summary>
		/// The custom properties for this TypedView type.
		/// </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>
		/// The custom properties for the type of this TypedView instance.
		/// </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return QTreminderTypedView.CustomProperties;}
		}

		/// <summary>
		/// The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. 
		/// </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>
		/// The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value
		/// pairs. 
		/// </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return QTreminderTypedView.FieldsCustomProperties;}
		}

		/// <summary>
		/// Indexer of this strong typed view
		/// </summary>
		public QTreminderRow this[int index] 
		{
			get 
			{
				return ((QTreminderRow)(this.Rows[index]));
			}
		}

	
		/// <summary>
		/// Returns the column object belonging to the TypedView field CIdAlat
		/// </summary>
		internal DataColumn CIdAlatColumn 
		{
			get { return _columnCIdAlat; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CNamaAlat
		/// </summary>
		internal DataColumn CNamaAlatColumn 
		{
			get { return _columnCNamaAlat; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CNamaDept
		/// </summary>
		internal DataColumn CNamaDeptColumn 
		{
			get { return _columnCNamaDept; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CNamaLokasi
		/// </summary>
		internal DataColumn CNamaLokasiColumn 
		{
			get { return _columnCNamaLokasi; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field DPlan
		/// </summary>
		internal DataColumn DPlanColumn 
		{
			get { return _columnDPlan; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field DConfirmRencana
		/// </summary>
		internal DataColumn DConfirmRencanaColumn 
		{
			get { return _columnDConfirmRencana; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field DRealisation
		/// </summary>
		internal DataColumn DRealisationColumn 
		{
			get { return _columnDRealisation; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CPic
		/// </summary>
		internal DataColumn CPicColumn 
		{
			get { return _columnCPic; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field MKeterangan
		/// </summary>
		internal DataColumn MKeteranganColumn 
		{
			get { return _columnMKeterangan; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field NInterval
		/// </summary>
		internal DataColumn NIntervalColumn 
		{
			get { return _columnNInterval; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CPeriode
		/// </summary>
		internal DataColumn CPeriodeColumn 
		{
			get { return _columnCPeriode; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field Bulan
		/// </summary>
		internal DataColumn BulanColumn 
		{
			get { return _columnBulan; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field Tahun
		/// </summary>
		internal DataColumn TahunColumn 
		{
			get { return _columnTahun; }
		}
    
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
		
 		#endregion
		
		#region Custom Typed View code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included Code

		#endregion
	}


	/// <summary>
	/// Typed datarow for the typed datatable QTreminder
	/// </summary>
	public partial class QTreminderRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private QTreminderTypedView	_parent;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal QTreminderRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((QTreminderTypedView)(this.Table));
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Gets / sets the value of the TypedView field CIdAlat<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_IdAlat"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 20
		/// </remarks>
		public System.String CIdAlat 
		{
			get 
			{
				if(IsCIdAlatNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CIdAlatColumn];
				}
			}
			set 
			{
				this[_parent.CIdAlatColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CIdAlat is NULL, false otherwise.
		/// </summary>
		public bool IsCIdAlatNull() 
		{
			return IsNull(_parent.CIdAlatColumn);
		}

		/// <summary>
		/// Sets the TypedView field CIdAlat to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCIdAlatNull() 
		{
			this[_parent.CIdAlatColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CNamaAlat<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_NamaAlat"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 100
		/// </remarks>
		public System.String CNamaAlat 
		{
			get 
			{
				if(IsCNamaAlatNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CNamaAlatColumn];
				}
			}
			set 
			{
				this[_parent.CNamaAlatColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CNamaAlat is NULL, false otherwise.
		/// </summary>
		public bool IsCNamaAlatNull() 
		{
			return IsNull(_parent.CNamaAlatColumn);
		}

		/// <summary>
		/// Sets the TypedView field CNamaAlat to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCNamaAlatNull() 
		{
			this[_parent.CNamaAlatColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CNamaDept<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_NamaDept"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 30
		/// </remarks>
		public System.String CNamaDept 
		{
			get 
			{
				if(IsCNamaDeptNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CNamaDeptColumn];
				}
			}
			set 
			{
				this[_parent.CNamaDeptColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CNamaDept is NULL, false otherwise.
		/// </summary>
		public bool IsCNamaDeptNull() 
		{
			return IsNull(_parent.CNamaDeptColumn);
		}

		/// <summary>
		/// Sets the TypedView field CNamaDept to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCNamaDeptNull() 
		{
			this[_parent.CNamaDeptColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CNamaLokasi<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_NamaLokasi"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 50
		/// </remarks>
		public System.String CNamaLokasi 
		{
			get 
			{
				if(IsCNamaLokasiNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CNamaLokasiColumn];
				}
			}
			set 
			{
				this[_parent.CNamaLokasiColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CNamaLokasi is NULL, false otherwise.
		/// </summary>
		public bool IsCNamaLokasiNull() 
		{
			return IsNull(_parent.CNamaLokasiColumn);
		}

		/// <summary>
		/// Sets the TypedView field CNamaLokasi to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCNamaLokasiNull() 
		{
			this[_parent.CNamaLokasiColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field DPlan<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."D_Plan"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0
		/// </remarks>
		public System.DateTime DPlan 
		{
			get 
			{
				if(IsDPlanNull())
				{
					// return default value for this type.
					return (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				else
				{
					return (System.DateTime)this[_parent.DPlanColumn];
				}
			}
			set 
			{
				this[_parent.DPlanColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field DPlan is NULL, false otherwise.
		/// </summary>
		public bool IsDPlanNull() 
		{
			return IsNull(_parent.DPlanColumn);
		}

		/// <summary>
		/// Sets the TypedView field DPlan to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetDPlanNull() 
		{
			this[_parent.DPlanColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field DConfirmRencana<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."D_ConfirmRencana"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0
		/// </remarks>
		public System.DateTime DConfirmRencana 
		{
			get 
			{
				if(IsDConfirmRencanaNull())
				{
					// return default value for this type.
					return (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				else
				{
					return (System.DateTime)this[_parent.DConfirmRencanaColumn];
				}
			}
			set 
			{
				this[_parent.DConfirmRencanaColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field DConfirmRencana is NULL, false otherwise.
		/// </summary>
		public bool IsDConfirmRencanaNull() 
		{
			return IsNull(_parent.DConfirmRencanaColumn);
		}

		/// <summary>
		/// Sets the TypedView field DConfirmRencana to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetDConfirmRencanaNull() 
		{
			this[_parent.DConfirmRencanaColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field DRealisation<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."D_Realisation"<br/>
		/// View field characteristics (type, precision, scale, length): Date, 0, 0, 0
		/// </remarks>
		public System.DateTime DRealisation 
		{
			get 
			{
				if(IsDRealisationNull())
				{
					// return default value for this type.
					return (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime));
				}
				else
				{
					return (System.DateTime)this[_parent.DRealisationColumn];
				}
			}
			set 
			{
				this[_parent.DRealisationColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field DRealisation is NULL, false otherwise.
		/// </summary>
		public bool IsDRealisationNull() 
		{
			return IsNull(_parent.DRealisationColumn);
		}

		/// <summary>
		/// Sets the TypedView field DRealisation to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetDRealisationNull() 
		{
			this[_parent.DRealisationColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CPic<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_PIC"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 100
		/// </remarks>
		public System.String CPic 
		{
			get 
			{
				if(IsCPicNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CPicColumn];
				}
			}
			set 
			{
				this[_parent.CPicColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CPic is NULL, false otherwise.
		/// </summary>
		public bool IsCPicNull() 
		{
			return IsNull(_parent.CPicColumn);
		}

		/// <summary>
		/// Sets the TypedView field CPic to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCPicNull() 
		{
			this[_parent.CPicColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field MKeterangan<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."M_Keterangan"<br/>
		/// View field characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911
		/// </remarks>
		public System.String MKeterangan 
		{
			get 
			{
				if(IsMKeteranganNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.MKeteranganColumn];
				}
			}
			set 
			{
				this[_parent.MKeteranganColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field MKeterangan is NULL, false otherwise.
		/// </summary>
		public bool IsMKeteranganNull() 
		{
			return IsNull(_parent.MKeteranganColumn);
		}

		/// <summary>
		/// Sets the TypedView field MKeterangan to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetMKeteranganNull() 
		{
			this[_parent.MKeteranganColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field NInterval<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."N_Interval"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		/// </remarks>
		public System.Int16 NInterval 
		{
			get 
			{
				if(IsNIntervalNull())
				{
					// return default value for this type.
					return (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				else
				{
					return (System.Int16)this[_parent.NIntervalColumn];
				}
			}
			set 
			{
				this[_parent.NIntervalColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field NInterval is NULL, false otherwise.
		/// </summary>
		public bool IsNIntervalNull() 
		{
			return IsNull(_parent.NIntervalColumn);
		}

		/// <summary>
		/// Sets the TypedView field NInterval to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetNIntervalNull() 
		{
			this[_parent.NIntervalColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CPeriode<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."C_Periode"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 6
		/// </remarks>
		public System.String CPeriode 
		{
			get 
			{
				if(IsCPeriodeNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CPeriodeColumn];
				}
			}
			set 
			{
				this[_parent.CPeriodeColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CPeriode is NULL, false otherwise.
		/// </summary>
		public bool IsCPeriodeNull() 
		{
			return IsNull(_parent.CPeriodeColumn);
		}

		/// <summary>
		/// Sets the TypedView field CPeriode to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCPeriodeNull() 
		{
			this[_parent.CPeriodeColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field Bulan<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."Bulan"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		/// </remarks>
		public System.Int16 Bulan 
		{
			get 
			{
				if(IsBulanNull())
				{
					// return default value for this type.
					return (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				else
				{
					return (System.Int16)this[_parent.BulanColumn];
				}
			}
			set 
			{
				this[_parent.BulanColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field Bulan is NULL, false otherwise.
		/// </summary>
		public bool IsBulanNull() 
		{
			return IsNull(_parent.BulanColumn);
		}

		/// <summary>
		/// Sets the TypedView field Bulan to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetBulanNull() 
		{
			this[_parent.BulanColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field Tahun<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "Q_TReminder"."Tahun"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0
		/// </remarks>
		public System.Int16 Tahun 
		{
			get 
			{
				if(IsTahunNull())
				{
					// return default value for this type.
					return (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16));
				}
				else
				{
					return (System.Int16)this[_parent.TahunColumn];
				}
			}
			set 
			{
				this[_parent.TahunColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field Tahun is NULL, false otherwise.
		/// </summary>
		public bool IsTahunNull() 
		{
			return IsNull(_parent.TahunColumn);
		}

		/// <summary>
		/// Sets the TypedView field Tahun to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetTahunNull() 
		{
			this[_parent.TahunColumn] = System.Convert.DBNull;
		}

	
		#endregion
		
		#region Custom Typed View Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
	}
}
