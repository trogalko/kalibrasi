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
	/// Typed datatable for the view 'QMjadwal'.<br/><br/>
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
	public partial class QMjadwalTypedView : TypedViewBase<QMjadwalRow>, ITypedView
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private DataColumn _columnCIdAlat;
		private DataColumn _columnCIdLokasi;
		private DataColumn _columnCNamaLokasi;
		private DataColumn _columnCNamaDept;
		private DataColumn _columnCPic;
		private DataColumn _columnMKeterangan;
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 6;
		#endregion


		/// <summary>
		/// Static CTor for setting up custom property hashtables. Is executed before the first instance of this
		/// class or derived classes is constructed. 
		/// </summary>
		static QMjadwalTypedView()
		{
			SetupCustomPropertyHashtables();
		}
		

		/// <summary>
		/// CTor
		/// </summary>
		public QMjadwalTypedView():base("QMjadwal")
		{
			InitClass();
		}
		
#if !CF		
		/// <summary>
		/// Protected constructor for deserialization.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected QMjadwalTypedView(SerializationInfo info, StreamingContext context):base(info, context)
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
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QMjadwalTypedView);
		}


		/// <summary>Gets an array of all QMjadwalRow objects.</summary>
		/// <returns>Array with QMjadwalRow objects</returns>
		public new QMjadwalRow[] Select()
		{
			return (QMjadwalRow[])base.Select();
		}


		/// <summary>Gets an array of all QMjadwalRow objects that match the filter criteria in order of primary key (or lacking one, order of addition.) </summary>
		/// <param name="filterExpression">The criteria to use to filter the rows.</param>
		/// <returns>Array with QMjadwalRow objects</returns>
		public new QMjadwalRow[] Select(string filterExpression)
		{
			return (QMjadwalRow[])base.Select(filterExpression);
		}


		/// <summary>Gets an array of all QMjadwalRow objects that match the filter criteria, in the specified sort order</summary>
		/// <param name="filterExpression">The filter expression.</param>
		/// <param name="sort">A string specifying the column and sort direction.</param>
		/// <returns>Array with QMjadwalRow objects</returns>
		public new QMjadwalRow[] Select(string filterExpression, string sort)
		{
			return (QMjadwalRow[])base.Select(filterExpression, sort);
		}


		/// <summary>Gets an array of all QMjadwalRow objects that match the filter criteria, in the specified sort order that match the specified state</summary>
		/// <param name="filterExpression">The filter expression.</param>
		/// <param name="sort">A string specifying the column and sort direction.</param>
		/// <param name="recordStates">One of the <see cref="System.Data.DataViewRowState"/> values.</param>
		/// <returns>Array with QMjadwalRow objects</returns>
		public new QMjadwalRow[] Select(string filterExpression, string sort, DataViewRowState recordStates)
		{
			return (QMjadwalRow[])base.Select(filterExpression, sort, recordStates);
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
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QMjadwalTypedView);
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
			return new QMjadwalRow(rowBuilder);
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

			_fieldsCustomProperties.Add("CIdLokasi", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CNamaLokasi", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CNamaDept", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("CPic", fieldHashtable);
			
			fieldHashtable = new Hashtable();

			_fieldsCustomProperties.Add("MKeterangan", fieldHashtable);
						
		}


		/// <summary>
		/// Initialize the datastructures.
		/// </summary>
		protected override void InitClass()
		{
			TableName = "QMjadwal";		
			
			_columnCIdAlat = new DataColumn("CIdAlat", typeof(System.String), null, MappingType.Element);
			_columnCIdAlat.ReadOnly = true;
			_columnCIdAlat.Caption = @"CIdAlat";
			this.Columns.Add(_columnCIdAlat);

			_columnCIdLokasi = new DataColumn("CIdLokasi", typeof(System.String), null, MappingType.Element);
			_columnCIdLokasi.ReadOnly = true;
			_columnCIdLokasi.Caption = @"CIdLokasi";
			this.Columns.Add(_columnCIdLokasi);

			_columnCNamaLokasi = new DataColumn("CNamaLokasi", typeof(System.String), null, MappingType.Element);
			_columnCNamaLokasi.ReadOnly = true;
			_columnCNamaLokasi.Caption = @"CNamaLokasi";
			this.Columns.Add(_columnCNamaLokasi);

			_columnCNamaDept = new DataColumn("CNamaDept", typeof(System.String), null, MappingType.Element);
			_columnCNamaDept.ReadOnly = true;
			_columnCNamaDept.Caption = @"CNamaDept";
			this.Columns.Add(_columnCNamaDept);

			_columnCPic = new DataColumn("CPic", typeof(System.String), null, MappingType.Element);
			_columnCPic.ReadOnly = true;
			_columnCPic.Caption = @"CPic";
			this.Columns.Add(_columnCPic);

			_columnMKeterangan = new DataColumn("MKeterangan", typeof(System.String), null, MappingType.Element);
			_columnMKeterangan.ReadOnly = true;
			_columnMKeterangan.Caption = @"MKeterangan";
			this.Columns.Add(_columnMKeterangan);
			
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
			_columnCIdLokasi = this.Columns["CIdLokasi"];
			_columnCNamaLokasi = this.Columns["CNamaLokasi"];
			_columnCNamaDept = this.Columns["CNamaDept"];
			_columnCPic = this.Columns["CPic"];
			_columnMKeterangan = this.Columns["MKeterangan"];
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}


		/// <summary>
		/// Return the type of the typed datarow
		/// </summary>
		/// <returns>returns the requested type</returns>
		protected override Type GetRowType() 
		{
			return typeof(QMjadwalRow);
		}


		/// <summary>
		/// Clones this instance.
		/// </summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			QMjadwalTypedView cloneToReturn = ((QMjadwalTypedView)(base.Clone()));
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
			return new QMjadwalTypedView();
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
			get { return QMjadwalTypedView.CustomProperties;}
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
			get { return QMjadwalTypedView.FieldsCustomProperties;}
		}

		/// <summary>
		/// Indexer of this strong typed view
		/// </summary>
		public QMjadwalRow this[int index] 
		{
			get 
			{
				return ((QMjadwalRow)(this.Rows[index]));
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
		/// Returns the column object belonging to the TypedView field CIdLokasi
		/// </summary>
		internal DataColumn CIdLokasiColumn 
		{
			get { return _columnCIdLokasi; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CNamaLokasi
		/// </summary>
		internal DataColumn CNamaLokasiColumn 
		{
			get { return _columnCNamaLokasi; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedView field CNamaDept
		/// </summary>
		internal DataColumn CNamaDeptColumn 
		{
			get { return _columnCNamaDept; }
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
	/// Typed datarow for the typed datatable QMjadwal
	/// </summary>
	public partial class QMjadwalRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private QMjadwalTypedView	_parent;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal QMjadwalRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((QMjadwalTypedView)(this.Table));
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Gets / sets the value of the TypedView field CIdAlat<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "qMJadwal"."C_IdAlat"<br/>
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
		/// Gets / sets the value of the TypedView field CIdLokasi<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "qMJadwal"."C_IdLokasi"<br/>
		/// View field characteristics (type, precision, scale, length): VarWChar, 0, 0, 20
		/// </remarks>
		public System.String CIdLokasi 
		{
			get 
			{
				if(IsCIdLokasiNull())
				{
					// return default value for this type.
					return (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String));
				}
				else
				{
					return (System.String)this[_parent.CIdLokasiColumn];
				}
			}
			set 
			{
				this[_parent.CIdLokasiColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedView field CIdLokasi is NULL, false otherwise.
		/// </summary>
		public bool IsCIdLokasiNull() 
		{
			return IsNull(_parent.CIdLokasiColumn);
		}

		/// <summary>
		/// Sets the TypedView field CIdLokasi to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCIdLokasiNull() 
		{
			this[_parent.CIdLokasiColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedView field CNamaLokasi<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "qMJadwal"."C_NamaLokasi"<br/>
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
		/// Gets / sets the value of the TypedView field CNamaDept<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "qMJadwal"."C_NamaDept"<br/>
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
		/// Gets / sets the value of the TypedView field CPic<br/><br/>
		/// 
		/// </summary>
		/// <remarks>
		/// Mapped on view field: "qMJadwal"."C_PIC"<br/>
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
		/// Mapped on view field: "qMJadwal"."M_Keterangan"<br/>
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

	
		#endregion
		
		#region Custom Typed View Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
	}
}
