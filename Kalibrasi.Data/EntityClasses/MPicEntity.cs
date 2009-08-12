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
	/// Entity class which represents the entity 'MPic'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MPicEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private Kalibrasi.Data.CollectionClasses.TJadwalCollection	_tjadwal;
		private bool	_alwaysFetchTjadwal, _alreadyFetchedTjadwal;

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
			/// <summary>Member name Tjadwal</summary>
			public static readonly string Tjadwal = "Tjadwal";


		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static MPicEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public MPicEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		public MPicEntity(System.String cPic)
		{
			InitClassFetch(cPic, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public MPicEntity(System.String cPic, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(cPic, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="validator">The custom validator object for this MPicEntity</param>
		public MPicEntity(System.String cPic, IValidator validator)
		{
			InitClassFetch(cPic, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected MPicEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_tjadwal = (Kalibrasi.Data.CollectionClasses.TJadwalCollection)info.GetValue("_tjadwal", typeof(Kalibrasi.Data.CollectionClasses.TJadwalCollection));
			_alwaysFetchTjadwal = info.GetBoolean("_alwaysFetchTjadwal");
			_alreadyFetchedTjadwal = info.GetBoolean("_alreadyFetchedTjadwal");

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
			switch((MPicFieldIndex)fieldIndex)
			{
				case MPicFieldIndex.CUserId:
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
			_alreadyFetchedTjadwal = (_tjadwal.Count > 0);

			_alreadyFetchedMuser = (_muser != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return MPicEntity.GetRelationsForField(fieldName);
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
					toReturn.Add(MPicEntity.Relations.MUserEntityUsingCUserId);
					break;
				case "Tjadwal":
					toReturn.Add(MPicEntity.Relations.TJadwalEntityUsingCPic);
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
			info.AddValue("_tjadwal", (!this.MarkedForDeletion?_tjadwal:null));
			info.AddValue("_alwaysFetchTjadwal", _alwaysFetchTjadwal);
			info.AddValue("_alreadyFetchedTjadwal", _alreadyFetchedTjadwal);

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
				case "Tjadwal":
					_alreadyFetchedTjadwal = true;
					if(entity!=null)
					{
						this.Tjadwal.Add((TJadwalEntity)entity);
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
				case "Tjadwal":
					_tjadwal.Add((TJadwalEntity)relatedEntity);
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
				case "Tjadwal":
					base.PerformRelatedEntityRemoval(_tjadwal, relatedEntity, signalRelatedEntityManyToOne);
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
			toReturn.Add(_tjadwal);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cPic)
		{
			return FetchUsingPK(cPic, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cPic, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(cPic, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cPic, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(cPic, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cPic, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(cPic, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CPic, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(MPicFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(MPicFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new MPicRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'TJadwalEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TJadwalEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.TJadwalCollection GetMultiTjadwal(bool forceFetch)
		{
			return GetMultiTjadwal(forceFetch, _tjadwal.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TJadwalEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'TJadwalEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.TJadwalCollection GetMultiTjadwal(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiTjadwal(forceFetch, _tjadwal.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'TJadwalEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.TJadwalCollection GetMultiTjadwal(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiTjadwal(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'TJadwalEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.TJadwalCollection GetMultiTjadwal(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedTjadwal || forceFetch || _alwaysFetchTjadwal) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_tjadwal.ParticipatesInTransaction)
					{
						base.Transaction.Add(_tjadwal);
					}
				}
				_tjadwal.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_tjadwal.EntityFactoryToUse = entityFactoryToUse;
				}
				_tjadwal.GetMultiManyToOne(this, filter);
				_tjadwal.SuppressClearInGetMulti=false;
				_alreadyFetchedTjadwal = true;
			}
			return _tjadwal;
		}

		/// <summary> Sets the collection parameters for the collection for 'Tjadwal'. These settings will be taken into account
		/// when the property Tjadwal is requested or GetMultiTjadwal is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersTjadwal(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_tjadwal.SortClauses=sortClauses;
			_tjadwal.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(MPicEntity.Relations.MUserEntityUsingCUserId);

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
			MPicDAO dao = (MPicDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_tjadwal.ActiveContext = base.ActiveContext;

			if(_muser!=null)
			{
				_muser.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			MPicDAO dao = (MPicDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			MPicDAO dao = (MPicDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Kalibrasi.Data.EntityType.MPicEntity);
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
			toReturn.Add("Tjadwal", _tjadwal);


			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="validator">The validator object for this MPicEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String cPic, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(cPic, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_tjadwal = new Kalibrasi.Data.CollectionClasses.TJadwalCollection(new TJadwalEntityFactory());
			_tjadwal.SetContainingEntityInfo(this, "Mpic");
			_alwaysFetchTjadwal = false;
			_alreadyFetchedTjadwal = false;

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

			_fieldsCustomProperties.Add("CPic", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MAlamat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CNoTelp", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CFax", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CEmail", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CCperson", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MNotes", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _muser</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMuser(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _muser, new PropertyChangedEventHandler( OnMuserPropertyChanged ), "Muser", MPicEntity.Relations.MUserEntityUsingCUserId, true, signalRelatedEntity, "Mpic", resetFKFields, new int[] { (int)MPicFieldIndex.CUserId } );		
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
				base.PerformSetupSyncRelatedEntity( _muser, new PropertyChangedEventHandler( OnMuserPropertyChanged ), "Muser", MPicEntity.Relations.MUserEntityUsingCUserId, true, ref _alreadyFetchedMuser, new string[] {  } );
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
		/// <param name="cPic">PK value for MPic which data should be fetched into this MPic object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String cPic, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)MPicFieldIndex.CPic].ForcedCurrentValueWrite(cPic);
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
			return DAOFactory.CreateMPicDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new MPicEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static MPicRelations Relations
		{
			get	{ return new MPicRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TJadwal' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathTjadwal
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.TJadwalCollection(),
					(IEntityRelation)GetRelationsForField("Tjadwal")[0], (int)Kalibrasi.Data.EntityType.MPicEntity, (int)Kalibrasi.Data.EntityType.TJadwalEntity, 0, null, null, null, "Tjadwal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
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
					(IEntityRelation)GetRelationsForField("Muser")[0], (int)Kalibrasi.Data.EntityType.MPicEntity, (int)Kalibrasi.Data.EntityType.MUserEntity, 0, null, null, null, "Muser", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "MPicEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return MPicEntity.CustomProperties;}
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
			get { return MPicEntity.FieldsCustomProperties;}
		}

		/// <summary> The CUserId property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CUserId
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CUserId, true); }
			set	{ SetValue((int)MPicFieldIndex.CUserId, value, true); }
		}
		/// <summary> The DEntry property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."D_Entry"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DEntry
		{
			get { return (Nullable<System.DateTime>)GetValue((int)MPicFieldIndex.DEntry, false); }
			set	{ SetValue((int)MPicFieldIndex.DEntry, value, true); }
		}
		/// <summary> The CPic property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_PIC"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual System.String CPic
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CPic, true); }
			set	{ SetValue((int)MPicFieldIndex.CPic, value, true); }
		}
		/// <summary> The MAlamat property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."M_Alamat"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MAlamat
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.MAlamat, true); }
			set	{ SetValue((int)MPicFieldIndex.MAlamat, value, true); }
		}
		/// <summary> The CNoTelp property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_NoTelp"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CNoTelp
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CNoTelp, true); }
			set	{ SetValue((int)MPicFieldIndex.CNoTelp, value, true); }
		}
		/// <summary> The CFax property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_Fax"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CFax
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CFax, true); }
			set	{ SetValue((int)MPicFieldIndex.CFax, value, true); }
		}
		/// <summary> The CEmail property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_Email"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CEmail
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CEmail, true); }
			set	{ SetValue((int)MPicFieldIndex.CEmail, value, true); }
		}
		/// <summary> The CCperson property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."C_CPerson"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CCperson
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.CCperson, true); }
			set	{ SetValue((int)MPicFieldIndex.CCperson, value, true); }
		}
		/// <summary> The MNotes property of the Entity MPic<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_PIC"."M_Notes"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MNotes
		{
			get { return (System.String)GetValue((int)MPicFieldIndex.MNotes, true); }
			set	{ SetValue((int)MPicFieldIndex.MNotes, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'TJadwalEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTjadwal()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.TJadwalCollection Tjadwal
		{
			get	{ return GetMultiTjadwal(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Tjadwal. When set to true, Tjadwal is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Tjadwal is accessed. You can always execute
		/// a forced fetch by calling GetMultiTjadwal(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchTjadwal
		{
			get	{ return _alwaysFetchTjadwal; }
			set	{ _alwaysFetchTjadwal = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Tjadwal already has been fetched. Setting this property to false when Tjadwal has been fetched
		/// will clear the Tjadwal collection well. Setting this property to true while Tjadwal hasn't been fetched disables lazy loading for Tjadwal</summary>
		[Browsable(false)]
		public bool AlreadyFetchedTjadwal
		{
			get { return _alreadyFetchedTjadwal;}
			set 
			{
				if(_alreadyFetchedTjadwal && !value && (_tjadwal != null))
				{
					_tjadwal.Clear();
				}
				_alreadyFetchedTjadwal = value;
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
							_muser.UnsetRelatedEntity(this, "Mpic");
						}
					}
					else
					{
						if(_muser!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Mpic");
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
			get { return (int)Kalibrasi.Data.EntityType.MPicEntity; }
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
