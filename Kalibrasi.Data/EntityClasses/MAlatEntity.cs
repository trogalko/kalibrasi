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
	/// Entity class which represents the entity 'MAlat'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MAlatEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private Kalibrasi.Data.CollectionClasses.THistoryAlatCollection	_thistoryAlat;
		private bool	_alwaysFetchThistoryAlat, _alreadyFetchedThistoryAlat;

		private MUserEntity _muser;
		private bool	_alwaysFetchMuser, _alreadyFetchedMuser, _muserReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Muser</summary>
			public static readonly string Muser = "Muser";
			/// <summary>Member name ThistoryAlat</summary>
			public static readonly string ThistoryAlat = "ThistoryAlat";


		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static MAlatEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public MAlatEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		public MAlatEntity(System.String cIdAlat)
		{
			InitClassFetch(cIdAlat, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public MAlatEntity(System.String cIdAlat, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(cIdAlat, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="validator">The custom validator object for this MAlatEntity</param>
		public MAlatEntity(System.String cIdAlat, IValidator validator)
		{
			InitClassFetch(cIdAlat, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected MAlatEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_thistoryAlat = (Kalibrasi.Data.CollectionClasses.THistoryAlatCollection)info.GetValue("_thistoryAlat", typeof(Kalibrasi.Data.CollectionClasses.THistoryAlatCollection));
			_alwaysFetchThistoryAlat = info.GetBoolean("_alwaysFetchThistoryAlat");
			_alreadyFetchedThistoryAlat = info.GetBoolean("_alreadyFetchedThistoryAlat");

			_muser = (MUserEntity)info.GetValue("_muser", typeof(MUserEntity));
			if(_muser!=null)
			{
				_muser.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_muserReturnsNewIfNotFound = info.GetBoolean("_muserReturnsNewIfNotFound");
			_alwaysFetchMuser = info.GetBoolean("_alwaysFetchMuser");
			_alreadyFetchedMuser = info.GetBoolean("_alreadyFetchedMuser");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((MAlatFieldIndex)fieldIndex)
			{
				case MAlatFieldIndex.CUserId:
					DesetupSyncMuser(true, false);
					_alreadyFetchedMuser = false;
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
			_alreadyFetchedThistoryAlat = (_thistoryAlat.Count > 0);

			_alreadyFetchedMuser = (_muser != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return MAlatEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Muser":
					toReturn.Add(MAlatEntity.Relations.MUserEntityUsingCUserId);
					break;
				case "ThistoryAlat":
					toReturn.Add(MAlatEntity.Relations.THistoryAlatEntityUsingCIdAlat);
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
			info.AddValue("_thistoryAlat", (!this.MarkedForDeletion?_thistoryAlat:null));
			info.AddValue("_alwaysFetchThistoryAlat", _alwaysFetchThistoryAlat);
			info.AddValue("_alreadyFetchedThistoryAlat", _alreadyFetchedThistoryAlat);

			info.AddValue("_muser", (!this.MarkedForDeletion?_muser:null));
			info.AddValue("_muserReturnsNewIfNotFound", _muserReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMuser", _alwaysFetchMuser);
			info.AddValue("_alreadyFetchedMuser", _alreadyFetchedMuser);

			
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
				case "Muser":
					_alreadyFetchedMuser = true;
					this.Muser = (MUserEntity)entity;
					break;
				case "ThistoryAlat":
					_alreadyFetchedThistoryAlat = true;
					if(entity!=null)
					{
						this.ThistoryAlat.Add((THistoryAlatEntity)entity);
					}
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
				case "Muser":
					SetupSyncMuser(relatedEntity);
					break;
				case "ThistoryAlat":
					_thistoryAlat.Add((THistoryAlatEntity)relatedEntity);
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
				case "Muser":
					DesetupSyncMuser(false, true);
					break;
				case "ThistoryAlat":
					base.PerformRelatedEntityRemoval(_thistoryAlat, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_muser!=null)
			{
				toReturn.Add(_muser);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_thistoryAlat);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cIdAlat)
		{
			return FetchUsingPK(cIdAlat, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cIdAlat, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(cIdAlat, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(cIdAlat, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(cIdAlat, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CIdAlat, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(MAlatFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(MAlatFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new MAlatRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'THistoryAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'THistoryAlatEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.THistoryAlatCollection GetMultiThistoryAlat(bool forceFetch)
		{
			return GetMultiThistoryAlat(forceFetch, _thistoryAlat.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'THistoryAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'THistoryAlatEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.THistoryAlatCollection GetMultiThistoryAlat(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiThistoryAlat(forceFetch, _thistoryAlat.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'THistoryAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.THistoryAlatCollection GetMultiThistoryAlat(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiThistoryAlat(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'THistoryAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.THistoryAlatCollection GetMultiThistoryAlat(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedThistoryAlat || forceFetch || _alwaysFetchThistoryAlat) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_thistoryAlat.ParticipatesInTransaction)
					{
						base.Transaction.Add(_thistoryAlat);
					}
				}
				_thistoryAlat.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_thistoryAlat.EntityFactoryToUse = entityFactoryToUse;
				}
				_thistoryAlat.GetMultiManyToOne(this, filter);
				_thistoryAlat.SuppressClearInGetMulti=false;
				_alreadyFetchedThistoryAlat = true;
			}
			return _thistoryAlat;
		}

		/// <summary> Sets the collection parameters for the collection for 'ThistoryAlat'. These settings will be taken into account
		/// when the property ThistoryAlat is requested or GetMultiThistoryAlat is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersThistoryAlat(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_thistoryAlat.SortClauses=sortClauses;
			_thistoryAlat.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary> Retrieves the related entity of type 'MUserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'MUserEntity' which is related to this entity.</returns>
		public MUserEntity GetSingleMuser()
		{
			return GetSingleMuser(false);
		}

		/// <summary> Retrieves the related entity of type 'MUserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'MUserEntity' which is related to this entity.</returns>
		public virtual MUserEntity GetSingleMuser(bool forceFetch)
		{
			if( ( !_alreadyFetchedMuser || forceFetch || _alwaysFetchMuser) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(MAlatEntity.Relations.MUserEntityUsingCUserId);

				MUserEntity newEntity = new MUserEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CUserId);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (MUserEntity)base.ActiveContext.Get(newEntity);
					}
					this.Muser = newEntity;
				}
				else
				{
					if(_muserReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_muser == null)))
						{
							this.Muser = newEntity;
						}
					}
					else
					{
						this.Muser = null;
					}
				}
				_alreadyFetchedMuser = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _muser;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			MAlatDAO dao = (MAlatDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_thistoryAlat.ActiveContext = base.ActiveContext;

			if(_muser!=null)
			{
				_muser.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			MAlatDAO dao = (MAlatDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			MAlatDAO dao = (MAlatDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Kalibrasi.Data.EntityType.MAlatEntity);
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
			toReturn.Add("Muser", _muser);
			toReturn.Add("ThistoryAlat", _thistoryAlat);


			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="validator">The validator object for this MAlatEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String cIdAlat, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(cIdAlat, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_thistoryAlat = new Kalibrasi.Data.CollectionClasses.THistoryAlatCollection(new THistoryAlatEntityFactory());
			_thistoryAlat.SetContainingEntityInfo(this, "Malat");
			_alwaysFetchThistoryAlat = false;
			_alreadyFetchedThistoryAlat = false;

			_muser = null;
			_muserReturnsNewIfNotFound = true;
			_alwaysFetchMuser = false;
			_alreadyFetchedMuser = false;


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
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DConfirm", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CConfirm", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _muser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMuser(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _muser, new PropertyChangedEventHandler( OnMuserPropertyChanged ), "Muser", MAlatEntity.Relations.MUserEntityUsingCUserId, true, signalRelatedEntity, "Malat", resetFKFields, new int[] { (int)MAlatFieldIndex.CUserId } );		
			_muser = null;
		}
		
		/// <summary> setups the sync logic for member _muser</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncMuser(IEntity relatedEntity)
		{
			if(_muser!=relatedEntity)
			{		
				DesetupSyncMuser(true, true);
				_muser = (MUserEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _muser, new PropertyChangedEventHandler( OnMuserPropertyChanged ), "Muser", MAlatEntity.Relations.MUserEntityUsingCUserId, true, ref _alreadyFetchedMuser, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMuserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="cIdAlat">PK value for MAlat which data should be fetched into this MAlat object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String cIdAlat, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)MAlatFieldIndex.CIdAlat].ForcedCurrentValueWrite(cIdAlat);
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
			return DAOFactory.CreateMAlatDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new MAlatEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static MAlatRelations Relations
		{
			get	{ return new MAlatRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'THistoryAlat' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathThistoryAlat
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.THistoryAlatCollection(),
					(IEntityRelation)GetRelationsForField("ThistoryAlat")[0], (int)Kalibrasi.Data.EntityType.MAlatEntity, (int)Kalibrasi.Data.EntityType.THistoryAlatEntity, 0, null, null, null, "ThistoryAlat", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MUser' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMuser
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MUserCollection(),
					(IEntityRelation)GetRelationsForField("Muser")[0], (int)Kalibrasi.Data.EntityType.MAlatEntity, (int)Kalibrasi.Data.EntityType.MUserEntity, 0, null, null, null, "Muser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "MAlatEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return MAlatEntity.CustomProperties;}
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
			get { return MAlatEntity.FieldsCustomProperties;}
		}

		/// <summary> The CUserId property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CUserId
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CUserId, true); }
			set	{ SetValue((int)MAlatFieldIndex.CUserId, value, true); }
		}
		/// <summary> The DEntry property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."D_Entry"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DEntry
		{
			get { return (Nullable<System.DateTime>)GetValue((int)MAlatFieldIndex.DEntry, false); }
			set	{ SetValue((int)MAlatFieldIndex.DEntry, value, true); }
		}
		/// <summary> The CIdAlat property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_IdAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual System.String CIdAlat
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CIdAlat, true); }
			set	{ SetValue((int)MAlatFieldIndex.CIdAlat, value, true); }
		}
		/// <summary> The CNamaAlat property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_NamaAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CNamaAlat
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CNamaAlat, true); }
			set	{ SetValue((int)MAlatFieldIndex.CNamaAlat, value, true); }
		}
		/// <summary> The CBatasToleransi property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_BatasToleransi"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CBatasToleransi
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CBatasToleransi, true); }
			set	{ SetValue((int)MAlatFieldIndex.CBatasToleransi, value, true); }
		}
		/// <summary> The NInterval property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."N_Interval"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> NInterval
		{
			get { return (Nullable<System.Int16>)GetValue((int)MAlatFieldIndex.NInterval, false); }
			set	{ SetValue((int)MAlatFieldIndex.NInterval, value, true); }
		}
		/// <summary> The NIntervalEks property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."N_IntervalEks"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> NIntervalEks
		{
			get { return (Nullable<System.Int16>)GetValue((int)MAlatFieldIndex.NIntervalEks, false); }
			set	{ SetValue((int)MAlatFieldIndex.NIntervalEks, value, true); }
		}
		/// <summary> The LJkInternal property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."L_JkInternal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LJkInternal
		{
			get { return (System.Boolean)GetValue((int)MAlatFieldIndex.LJkInternal, true); }
			set	{ SetValue((int)MAlatFieldIndex.LJkInternal, value, true); }
		}
		/// <summary> The LJkEksternal property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."L_JkEksternal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LJkEksternal
		{
			get { return (System.Boolean)GetValue((int)MAlatFieldIndex.LJkEksternal, true); }
			set	{ SetValue((int)MAlatFieldIndex.LJkEksternal, value, true); }
		}
		/// <summary> The LStatusAlat property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."L_StatusAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): Boolean, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean LStatusAlat
		{
			get { return (System.Boolean)GetValue((int)MAlatFieldIndex.LStatusAlat, true); }
			set	{ SetValue((int)MAlatFieldIndex.LStatusAlat, value, true); }
		}
		/// <summary> The CKeterangan property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_Keterangan"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CKeterangan
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CKeterangan, true); }
			set	{ SetValue((int)MAlatFieldIndex.CKeterangan, value, true); }
		}
		/// <summary> The DConfirm property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."D_Confirm"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DConfirm
		{
			get { return (Nullable<System.DateTime>)GetValue((int)MAlatFieldIndex.DConfirm, false); }
			set	{ SetValue((int)MAlatFieldIndex.DConfirm, value, true); }
		}
		/// <summary> The CConfirm property of the Entity MAlat<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_Alat"."C_Confirm"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CConfirm
		{
			get { return (System.String)GetValue((int)MAlatFieldIndex.CConfirm, true); }
			set	{ SetValue((int)MAlatFieldIndex.CConfirm, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'THistoryAlatEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiThistoryAlat()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.THistoryAlatCollection ThistoryAlat
		{
			get	{ return GetMultiThistoryAlat(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ThistoryAlat. When set to true, ThistoryAlat is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ThistoryAlat is accessed. You can always execute
		/// a forced fetch by calling GetMultiThistoryAlat(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchThistoryAlat
		{
			get	{ return _alwaysFetchThistoryAlat; }
			set	{ _alwaysFetchThistoryAlat = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ThistoryAlat already has been fetched. Setting this property to false when ThistoryAlat has been fetched
		/// will clear the ThistoryAlat collection well. Setting this property to true while ThistoryAlat hasn't been fetched disables lazy loading for ThistoryAlat</summary>
		[Browsable(false)]
		public bool AlreadyFetchedThistoryAlat
		{
			get { return _alreadyFetchedThistoryAlat;}
			set 
			{
				if(_alreadyFetchedThistoryAlat && !value && (_thistoryAlat != null))
				{
					_thistoryAlat.Clear();
				}
				_alreadyFetchedThistoryAlat = value;
			}
		}


		/// <summary> Gets / sets related entity of type 'MUserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMuser()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual MUserEntity Muser
		{
			get	{ return GetSingleMuser(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncMuser(value);
				}
				else
				{
					if(value==null)
					{
						if(_muser != null)
						{
							_muser.UnsetRelatedEntity(this, "Malat");
						}
					}
					else
					{
						if(_muser!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Malat");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Muser. When set to true, Muser is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Muser is accessed. You can always execute
		/// a forced fetch by calling GetSingleMuser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMuser
		{
			get	{ return _alwaysFetchMuser; }
			set	{ _alwaysFetchMuser = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Muser already has been fetched. Setting this property to false when Muser has been fetched
		/// will set Muser to null as well. Setting this property to true while Muser hasn't been fetched disables lazy loading for Muser</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMuser
		{
			get { return _alreadyFetchedMuser;}
			set 
			{
				if(_alreadyFetchedMuser && !value)
				{
					this.Muser = null;
				}
				_alreadyFetchedMuser = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Muser is not found
		/// in the database. When set to true, Muser will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool MuserReturnsNewIfNotFound
		{
			get	{ return _muserReturnsNewIfNotFound; }
			set { _muserReturnsNewIfNotFound = value; }	
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
			get { return (int)Kalibrasi.Data.EntityType.MAlatEntity; }
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
