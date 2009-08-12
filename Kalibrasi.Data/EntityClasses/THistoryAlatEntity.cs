///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:44 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using Kalibrasi.Data;
using Kalibrasi.Data.FactoryClasses;
using Kalibrasi.Data.DaoClasses;
using Kalibrasi.Data.RelationClasses;
using Kalibrasi.Data.HelperClasses;
using Kalibrasi.Data.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	

	/// <summary>
	/// Entity class which represents the entity 'THistoryAlat'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class THistoryAlatEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private MAlatEntity _malat;
		private bool	_alwaysFetchMalat, _alreadyFetchedMalat, _malatReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Malat</summary>
			public static readonly string Malat = "Malat";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static THistoryAlatEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public THistoryAlatEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		public THistoryAlatEntity(Nullable<System.DateTime> dEntry, System.String cIdAlat)
		{
			InitClassFetch(dEntry, cIdAlat, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public THistoryAlatEntity(Nullable<System.DateTime> dEntry, System.String cIdAlat, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(dEntry, cIdAlat, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="validator">The custom validator object for this THistoryAlatEntity</param>
		public THistoryAlatEntity(Nullable<System.DateTime> dEntry, System.String cIdAlat, IValidator validator)
		{
			InitClassFetch(dEntry, cIdAlat, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected THistoryAlatEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_malat = (MAlatEntity)info.GetValue("_malat", typeof(MAlatEntity));
			if(_malat!=null)
			{
				_malat.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_malatReturnsNewIfNotFound = info.GetBoolean("_malatReturnsNewIfNotFound");
			_alwaysFetchMalat = info.GetBoolean("_alwaysFetchMalat");
			_alreadyFetchedMalat = info.GetBoolean("_alreadyFetchedMalat");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((THistoryAlatFieldIndex)fieldIndex)
			{
				case THistoryAlatFieldIndex.CIdAlat:
					DesetupSyncMalat(true, false);
					_alreadyFetchedMalat = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{


			_alreadyFetchedMalat = (_malat != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return THistoryAlatEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Malat":
					toReturn.Add(THistoryAlatEntity.Relations.MAlatEntityUsingCIdAlat);
					break;



				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{


			info.AddValue("_malat", (!this.MarkedForDeletion?_malat:null));
			info.AddValue("_malatReturnsNewIfNotFound", _malatReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMalat", _alwaysFetchMalat);
			info.AddValue("_alreadyFetchedMalat", _alreadyFetchedMalat);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "Malat":
					_alreadyFetchedMalat = true;
					this.Malat = (MAlatEntity)entity;
					break;



				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Malat":
					SetupSyncMalat(relatedEntity);
					break;


				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Malat":
					DesetupSyncMalat(false, true);
					break;


				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_malat!=null)
			{
				toReturn.Add(_malat);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, System.String cIdAlat)
		{
			return FetchUsingPK(dEntry, cIdAlat, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, System.String cIdAlat, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(dEntry, cIdAlat, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(dEntry, cIdAlat, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(dEntry, cIdAlat, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DEntry, this.CIdAlat, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(THistoryAlatFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(THistoryAlatFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new THistoryAlatRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'MAlatEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'MAlatEntity' which is related to this entity.</returns>
		public MAlatEntity GetSingleMalat()
		{
			return GetSingleMalat(false);
		}

		/// <summary> Retrieves the related entity of type 'MAlatEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'MAlatEntity' which is related to this entity.</returns>
		public virtual MAlatEntity GetSingleMalat(bool forceFetch)
		{
			if( ( !_alreadyFetchedMalat || forceFetch || _alwaysFetchMalat) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(THistoryAlatEntity.Relations.MAlatEntityUsingCIdAlat);

				MAlatEntity newEntity = new MAlatEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CIdAlat);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (MAlatEntity)base.ActiveContext.Get(newEntity);
					}
					this.Malat = newEntity;
				}
				else
				{
					if(_malatReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_malat == null)))
						{
							this.Malat = newEntity;
						}
					}
					else
					{
						this.Malat = null;
					}
				}
				_alreadyFetchedMalat = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _malat;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			THistoryAlatDAO dao = (THistoryAlatDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_malat!=null)
			{
				_malat.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			THistoryAlatDAO dao = (THistoryAlatDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			THistoryAlatDAO dao = (THistoryAlatDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(Kalibrasi.Data.EntityType.THistoryAlatEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Malat", _malat);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="validator">The validator object for this THistoryAlatEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(Nullable<System.DateTime> dEntry, System.String cIdAlat, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(dEntry, cIdAlat, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_malat = null;
			_malatReturnsNewIfNotFound = true;
			_alwaysFetchMalat = false;
			_alreadyFetchedMalat = false;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CUserId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DEntry", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CIdAlat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CNamaAlat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CBatasToleransi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NInterval", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("NIntervalEks", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LJkInternal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LJkEksternal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("LStatusAlat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CKeterangan", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _malat</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMalat(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _malat, new PropertyChangedEventHandler( OnMalatPropertyChanged ), "Malat", THistoryAlatEntity.Relations.MAlatEntityUsingCIdAlat, true, signalRelatedEntity, "ThistoryAlat", resetFKFields, new int[] { (int)THistoryAlatFieldIndex.CIdAlat } );		
			_malat = null;
		}
		
		/// <summary> setups the sync logic for member _malat</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncMalat(IEntity relatedEntity)
		{
			if(_malat!=relatedEntity)
			{		
				DesetupSyncMalat(true, true);
				_malat = (MAlatEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _malat, new PropertyChangedEventHandler( OnMalatPropertyChanged ), "Malat", THistoryAlatEntity.Relations.MAlatEntityUsingCIdAlat, true, ref _alreadyFetchedMalat, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMalatPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="dEntry">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="cIdAlat">PK value for THistoryAlat which data should be fetched into this THistoryAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(Nullable<System.DateTime> dEntry, System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)THistoryAlatFieldIndex.DEntry].ForcedCurrentValueWrite(dEntry);
				base.Fields[(int)THistoryAlatFieldIndex.CIdAlat].ForcedCurrentValueWrite(cIdAlat);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateTHistoryAlatDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new THistoryAlatEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static THistoryAlatRelations Relations
		{
			get	{ return new THistoryAlatRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MAlat' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMalat
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MAlatCollection(),
					(IEntityRelation)GetRelationsForField("Malat")[0], (int)Kalibrasi.Data.EntityType.THistoryAlatEntity, (int)Kalibrasi.Data.EntityType.MAlatEntity, 0, null, null, null, "Malat", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "THistoryAlatEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return THistoryAlatEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return THistoryAlatEntity.FieldsCustomProperties;}
		}

		/// <summary> The CUserId property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."C_UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CUserId
		{
			get { return (System.String)GetValue((int)THistoryAlatFieldIndex.CUserId, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.CUserId, value, true); }
		}
		/// <summary> The DEntry property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."D_Entry"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual Nullable<System.DateTime> DEntry
		{
			get { return (Nullable<System.DateTime>)GetValue((int)THistoryAlatFieldIndex.DEntry, false); }
			set	{ SetValue((int)THistoryAlatFieldIndex.DEntry, value, true); }
		}
		/// <summary> The CIdAlat property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."C_IdAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual System.String CIdAlat
		{
			get { return (System.String)GetValue((int)THistoryAlatFieldIndex.CIdAlat, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.CIdAlat, value, true); }
		}
		/// <summary> The CNamaAlat property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."C_NamaAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CNamaAlat
		{
			get { return (System.String)GetValue((int)THistoryAlatFieldIndex.CNamaAlat, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.CNamaAlat, value, true); }
		}
		/// <summary> The CBatasToleransi property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."C_BatasToleransi"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CBatasToleransi
		{
			get { return (System.String)GetValue((int)THistoryAlatFieldIndex.CBatasToleransi, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.CBatasToleransi, value, true); }
		}
		/// <summary> The NInterval property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."N_Interval"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> NInterval
		{
			get { return (Nullable<System.Int16>)GetValue((int)THistoryAlatFieldIndex.NInterval, false); }
			set	{ SetValue((int)THistoryAlatFieldIndex.NInterval, value, true); }
		}
		/// <summary> The NIntervalEks property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."N_IntervalEks"<br/>
		/// Table field type characteristics (type, precision, scale, length): Integer, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> NIntervalEks
		{
			get { return (Nullable<System.Int32>)GetValue((int)THistoryAlatFieldIndex.NIntervalEks, false); }
			set	{ SetValue((int)THistoryAlatFieldIndex.NIntervalEks, value, true); }
		}
		/// <summary> The LJkInternal property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."L_JkInternal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LJkInternal
		{
			get { return (System.Boolean)GetValue((int)THistoryAlatFieldIndex.LJkInternal, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.LJkInternal, value, true); }
		}
		/// <summary> The LJkEksternal property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."L_JkEksternal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LJkEksternal
		{
			get { return (System.Boolean)GetValue((int)THistoryAlatFieldIndex.LJkEksternal, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.LJkEksternal, value, true); }
		}
		/// <summary> The LStatusAlat property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."L_StatusAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LStatusAlat
		{
			get { return (System.Boolean)GetValue((int)THistoryAlatFieldIndex.LStatusAlat, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.LStatusAlat, value, true); }
		}
		/// <summary> The CKeterangan property of the Entity THistoryAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_HistoryAlat"."C_Keterangan"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CKeterangan
		{
			get { return (System.String)GetValue((int)THistoryAlatFieldIndex.CKeterangan, true); }
			set	{ SetValue((int)THistoryAlatFieldIndex.CKeterangan, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'MAlatEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMalat()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual MAlatEntity Malat
		{
			get	{ return GetSingleMalat(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncMalat(value);
				}
				else
				{
					if(value==null)
					{
						if(_malat != null)
						{
							_malat.UnsetRelatedEntity(this, "ThistoryAlat");
						}
					}
					else
					{
						if(_malat!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ThistoryAlat");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Malat. When set to true, Malat is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Malat is accessed. You can always execute
		/// a forced fetch by calling GetSingleMalat(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMalat
		{
			get	{ return _alwaysFetchMalat; }
			set	{ _alwaysFetchMalat = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Malat already has been fetched. Setting this property to false when Malat has been fetched
		/// will set Malat to null as well. Setting this property to true while Malat hasn't been fetched disables lazy loading for Malat</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMalat
		{
			get { return _alreadyFetchedMalat;}
			set 
			{
				if(_alreadyFetchedMalat && !value)
				{
					this.Malat = null;
				}
				_alreadyFetchedMalat = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Malat is not found
		/// in the database. When set to true, Malat will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool MalatReturnsNewIfNotFound
		{
			get	{ return _malatReturnsNewIfNotFound; }
			set { _malatReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the Kalibrasi.Data.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)Kalibrasi.Data.EntityType.THistoryAlatEntity; }
		}
		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
