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
	/// Entity class which represents the entity 'TJadwal'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class TJadwalEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations


		private MPicEntity _mpic;
		private bool	_alwaysFetchMpic, _alreadyFetchedMpic, _mpicReturnsNewIfNotFound;
		private THistoryJadwalEntity _thistoryJadwal;
		private bool	_alwaysFetchThistoryJadwal, _alreadyFetchedThistoryJadwal, _thistoryJadwalReturnsNewIfNotFound;
		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name Mpic</summary>
			public static readonly string Mpic = "Mpic";


			/// <summary>Member name ThistoryJadwal</summary>
			public static readonly string ThistoryJadwal = "ThistoryJadwal";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TJadwalEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public TJadwalEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		public TJadwalEntity(Nullable<System.DateTime> dEntry)
		{
			InitClassFetch(dEntry, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public TJadwalEntity(Nullable<System.DateTime> dEntry, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(dEntry, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="validator">The custom validator object for this TJadwalEntity</param>
		public TJadwalEntity(Nullable<System.DateTime> dEntry, IValidator validator)
		{
			InitClassFetch(dEntry, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TJadwalEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_mpic = (MPicEntity)info.GetValue("_mpic", typeof(MPicEntity));
			if(_mpic!=null)
			{
				_mpic.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_mpicReturnsNewIfNotFound = info.GetBoolean("_mpicReturnsNewIfNotFound");
			_alwaysFetchMpic = info.GetBoolean("_alwaysFetchMpic");
			_alreadyFetchedMpic = info.GetBoolean("_alreadyFetchedMpic");
			_thistoryJadwal = (THistoryJadwalEntity)info.GetValue("_thistoryJadwal", typeof(THistoryJadwalEntity));
			if(_thistoryJadwal!=null)
			{
				_thistoryJadwal.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_thistoryJadwalReturnsNewIfNotFound = info.GetBoolean("_thistoryJadwalReturnsNewIfNotFound");
			_alwaysFetchThistoryJadwal = info.GetBoolean("_alwaysFetchThistoryJadwal");
			_alreadyFetchedThistoryJadwal = info.GetBoolean("_alreadyFetchedThistoryJadwal");
			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((TJadwalFieldIndex)fieldIndex)
			{
				case TJadwalFieldIndex.DEntry:
					DesetupSyncThistoryJadwal(true, false);
					_alreadyFetchedThistoryJadwal = false;
					break;
				case TJadwalFieldIndex.CPic:
					DesetupSyncMpic(true, false);
					_alreadyFetchedMpic = false;
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


			_alreadyFetchedMpic = (_mpic != null);
			_alreadyFetchedThistoryJadwal = (_thistoryJadwal != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return TJadwalEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Mpic":
					toReturn.Add(TJadwalEntity.Relations.MPicEntityUsingCPic);
					break;


				case "ThistoryJadwal":
					toReturn.Add(TJadwalEntity.Relations.THistoryJadwalEntityUsingDEntry);
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


			info.AddValue("_mpic", (!this.MarkedForDeletion?_mpic:null));
			info.AddValue("_mpicReturnsNewIfNotFound", _mpicReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMpic", _alwaysFetchMpic);
			info.AddValue("_alreadyFetchedMpic", _alreadyFetchedMpic);
			info.AddValue("_thistoryJadwal", (!this.MarkedForDeletion?_thistoryJadwal:null));
			info.AddValue("_thistoryJadwalReturnsNewIfNotFound", _thistoryJadwalReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchThistoryJadwal", _alwaysFetchThistoryJadwal);
			info.AddValue("_alreadyFetchedThistoryJadwal", _alreadyFetchedThistoryJadwal);
			
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
				case "Mpic":
					_alreadyFetchedMpic = true;
					this.Mpic = (MPicEntity)entity;
					break;


				case "ThistoryJadwal":
					_alreadyFetchedThistoryJadwal = true;
					this.ThistoryJadwal = (THistoryJadwalEntity)entity;
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
				case "Mpic":
					SetupSyncMpic(relatedEntity);
					break;

				case "ThistoryJadwal":
					SetupSyncThistoryJadwal(relatedEntity);
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
				case "Mpic":
					DesetupSyncMpic(false, true);
					break;

				case "ThistoryJadwal":
					DesetupSyncThistoryJadwal(false, true);
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
			if(_mpic!=null)
			{
				toReturn.Add(_mpic);
			}
			if(_thistoryJadwal!=null)
			{
				toReturn.Add(_thistoryJadwal);
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
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry)
		{
			return FetchUsingPK(dEntry, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(dEntry, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(dEntry, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(Nullable<System.DateTime> dEntry, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(dEntry, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.DEntry, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(TJadwalFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(TJadwalFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new TJadwalRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'MPicEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'MPicEntity' which is related to this entity.</returns>
		public MPicEntity GetSingleMpic()
		{
			return GetSingleMpic(false);
		}

		/// <summary> Retrieves the related entity of type 'MPicEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'MPicEntity' which is related to this entity.</returns>
		public virtual MPicEntity GetSingleMpic(bool forceFetch)
		{
			if( ( !_alreadyFetchedMpic || forceFetch || _alwaysFetchMpic) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(TJadwalEntity.Relations.MPicEntityUsingCPic);

				MPicEntity newEntity = new MPicEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CPic);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (MPicEntity)base.ActiveContext.Get(newEntity);
					}
					this.Mpic = newEntity;
				}
				else
				{
					if(_mpicReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_mpic == null)))
						{
							this.Mpic = newEntity;
						}
					}
					else
					{
						this.Mpic = null;
					}
				}
				_alreadyFetchedMpic = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _mpic;
		}

		/// <summary> Retrieves the related entity of type 'THistoryJadwalEntity', using a relation of type '1:1'</summary>
		/// <returns>A fetched entity of type 'THistoryJadwalEntity' which is related to this entity.</returns>
		public THistoryJadwalEntity GetSingleThistoryJadwal()
		{
			return GetSingleThistoryJadwal(false);
		}
		
		/// <summary> Retrieves the related entity of type 'THistoryJadwalEntity', using a relation of type '1:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'THistoryJadwalEntity' which is related to this entity.</returns>
		public virtual THistoryJadwalEntity GetSingleThistoryJadwal(bool forceFetch)
		{
			if( ( !_alreadyFetchedThistoryJadwal || forceFetch || _alwaysFetchThistoryJadwal) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode )
			{
				THistoryJadwalEntity newEntity = new THistoryJadwalEntity();
				IEntityRelation relation = TJadwalEntity.Relations.THistoryJadwalEntityUsingDEntry;
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(base.CheckIfLazyLoadingShouldOccur(relation))
				{
					fetchResult = newEntity.FetchUsingPK(this.DEntry.GetValueOrDefault());
				}
				if(!_thistoryJadwalReturnsNewIfNotFound && !fetchResult)
				{
					this.ThistoryJadwal = null;
				}
				else
				{
					if((base.ActiveContext!=null)&&fetchResult)
					{
						newEntity = (THistoryJadwalEntity)base.ActiveContext.Get(newEntity);
					}
					this.ThistoryJadwal = newEntity;
					_alreadyFetchedThistoryJadwal = fetchResult;
				}
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _thistoryJadwal;
		}

		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			TJadwalDAO dao = (TJadwalDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_mpic!=null)
			{
				_mpic.ActiveContext = base.ActiveContext;
			}
			if(_thistoryJadwal!=null)
			{
				_thistoryJadwal.ActiveContext = base.ActiveContext;
			}

		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			TJadwalDAO dao = (TJadwalDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			TJadwalDAO dao = (TJadwalDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Kalibrasi.Data.EntityType.TJadwalEntity);
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
			toReturn.Add("Mpic", _mpic);


			toReturn.Add("ThistoryJadwal", _thistoryJadwal);
			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="validator">The validator object for this TJadwalEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(Nullable<System.DateTime> dEntry, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(dEntry, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_mpic = null;
			_mpicReturnsNewIfNotFound = true;
			_alwaysFetchMpic = false;
			_alreadyFetchedMpic = false;
			_thistoryJadwal = null;
			_thistoryJadwalReturnsNewIfNotFound = true;
			_alwaysFetchThistoryJadwal = false;
			_alreadyFetchedThistoryJadwal = false;

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

			_fieldsCustomProperties.Add("CPeriode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CIdAlat", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CIdDept", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CIdLokasi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DPlan", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DRealisation", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CPic", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DConfirmRencana", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CConfirmRencana", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("DConfirmRealisation", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CConfirmRealisation", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("MKeterangan", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _mpic</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMpic(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _mpic, new PropertyChangedEventHandler( OnMpicPropertyChanged ), "Mpic", TJadwalEntity.Relations.MPicEntityUsingCPic, true, signalRelatedEntity, "Tjadwal", resetFKFields, new int[] { (int)TJadwalFieldIndex.CPic } );		
			_mpic = null;
		}
		
		/// <summary> setups the sync logic for member _mpic</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncMpic(IEntity relatedEntity)
		{
			if(_mpic!=relatedEntity)
			{		
				DesetupSyncMpic(true, true);
				_mpic = (MPicEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _mpic, new PropertyChangedEventHandler( OnMpicPropertyChanged ), "Mpic", TJadwalEntity.Relations.MPicEntityUsingCPic, true, ref _alreadyFetchedMpic, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMpicPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _thistoryJadwal</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncThistoryJadwal(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _thistoryJadwal, new PropertyChangedEventHandler( OnThistoryJadwalPropertyChanged ), "ThistoryJadwal", TJadwalEntity.Relations.THistoryJadwalEntityUsingDEntry, true, signalRelatedEntity, "Tjadwal", false, new int[] { (int)TJadwalFieldIndex.DEntry } );
			_thistoryJadwal = null;
		}
	
		/// <summary> setups the sync logic for member _thistoryJadwal</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncThistoryJadwal(IEntity relatedEntity)
		{
			if(_thistoryJadwal!=relatedEntity)
			{
				DesetupSyncThistoryJadwal(true, true);
				_thistoryJadwal = (THistoryJadwalEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _thistoryJadwal, new PropertyChangedEventHandler( OnThistoryJadwalPropertyChanged ), "ThistoryJadwal", TJadwalEntity.Relations.THistoryJadwalEntityUsingDEntry, true, ref _alreadyFetchedThistoryJadwal, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnThistoryJadwalPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="dEntry">PK value for TJadwal which data should be fetched into this TJadwal object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(Nullable<System.DateTime> dEntry, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)TJadwalFieldIndex.DEntry].ForcedCurrentValueWrite(dEntry);
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
			return DAOFactory.CreateTJadwalDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new TJadwalEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static TJadwalRelations Relations
		{
			get	{ return new TJadwalRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MPic' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMpic
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MPicCollection(),
					(IEntityRelation)GetRelationsForField("Mpic")[0], (int)Kalibrasi.Data.EntityType.TJadwalEntity, (int)Kalibrasi.Data.EntityType.MPicEntity, 0, null, null, null, "Mpic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'THistoryJadwal' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathThistoryJadwal
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.THistoryJadwalCollection(),
					(IEntityRelation)GetRelationsForField("ThistoryJadwal")[0], (int)Kalibrasi.Data.EntityType.TJadwalEntity, (int)Kalibrasi.Data.EntityType.THistoryJadwalEntity, 0, null, null, null, "ThistoryJadwal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);
			}
		}

		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "TJadwalEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return TJadwalEntity.CustomProperties;}
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
			get { return TJadwalEntity.FieldsCustomProperties;}
		}

		/// <summary> The CUserId property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CUserId
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CUserId, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CUserId, value, true); }
		}
		/// <summary> The DEntry property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."D_Entry"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual Nullable<System.DateTime> DEntry
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.DEntry, false); }
			set	{ SetValue((int)TJadwalFieldIndex.DEntry, value, true); }
		}
		/// <summary> The CPeriode property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_Periode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 6<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CPeriode
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CPeriode, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CPeriode, value, true); }
		}
		/// <summary> The CIdAlat property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_IdAlat"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CIdAlat
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CIdAlat, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CIdAlat, value, true); }
		}
		/// <summary> The CIdDept property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_IdDept"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CIdDept
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CIdDept, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CIdDept, value, true); }
		}
		/// <summary> The CIdLokasi property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_IdLokasi"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CIdLokasi
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CIdLokasi, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CIdLokasi, value, true); }
		}
		/// <summary> The DPlan property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."D_Plan"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DPlan
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.DPlan, false); }
			set	{ SetValue((int)TJadwalFieldIndex.DPlan, value, true); }
		}
		/// <summary> The DRealisation property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."D_Realisation"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DRealisation
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.DRealisation, false); }
			set	{ SetValue((int)TJadwalFieldIndex.DRealisation, value, true); }
		}
		/// <summary> The CPic property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_PIC"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CPic
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.CPic, true); }
			set	{ SetValue((int)TJadwalFieldIndex.CPic, value, true); }
		}
		/// <summary> The DConfirmRencana property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."D_ConfirmRencana"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DConfirmRencana
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.DConfirmRencana, false); }
			set	{ SetValue((int)TJadwalFieldIndex.DConfirmRencana, value, true); }
		}
		/// <summary> The CConfirmRencana property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_ConfirmRencana"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> CConfirmRencana
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.CConfirmRencana, false); }
			set	{ SetValue((int)TJadwalFieldIndex.CConfirmRencana, value, true); }
		}
		/// <summary> The DConfirmRealisation property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."D_ConfirmRealisation"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DConfirmRealisation
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.DConfirmRealisation, false); }
			set	{ SetValue((int)TJadwalFieldIndex.DConfirmRealisation, value, true); }
		}
		/// <summary> The CConfirmRealisation property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."C_ConfirmRealisation"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> CConfirmRealisation
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TJadwalFieldIndex.CConfirmRealisation, false); }
			set	{ SetValue((int)TJadwalFieldIndex.CConfirmRealisation, value, true); }
		}
		/// <summary> The MKeterangan property of the Entity TJadwal<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "T_Jadwal"."M_Keterangan"<br/>
		/// Table field type characteristics (type, precision, scale, length): LongVarWChar, 0, 0, 536870911<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MKeterangan
		{
			get { return (System.String)GetValue((int)TJadwalFieldIndex.MKeterangan, true); }
			set	{ SetValue((int)TJadwalFieldIndex.MKeterangan, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'MPicEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMpic()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual MPicEntity Mpic
		{
			get	{ return GetSingleMpic(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncMpic(value);
				}
				else
				{
					if(value==null)
					{
						if(_mpic != null)
						{
							_mpic.UnsetRelatedEntity(this, "Tjadwal");
						}
					}
					else
					{
						if(_mpic!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Tjadwal");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for Mpic. When set to true, Mpic is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Mpic is accessed. You can always execute
		/// a forced fetch by calling GetSingleMpic(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMpic
		{
			get	{ return _alwaysFetchMpic; }
			set	{ _alwaysFetchMpic = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property Mpic already has been fetched. Setting this property to false when Mpic has been fetched
		/// will set Mpic to null as well. Setting this property to true while Mpic hasn't been fetched disables lazy loading for Mpic</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMpic
		{
			get { return _alreadyFetchedMpic;}
			set 
			{
				if(_alreadyFetchedMpic && !value)
				{
					this.Mpic = null;
				}
				_alreadyFetchedMpic = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property Mpic is not found
		/// in the database. When set to true, Mpic will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool MpicReturnsNewIfNotFound
		{
			get	{ return _mpicReturnsNewIfNotFound; }
			set { _mpicReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'THistoryJadwalEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleThistoryJadwal()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual THistoryJadwalEntity ThistoryJadwal
		{
			get	{ return GetSingleThistoryJadwal(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncThistoryJadwal(value);
				}
				else
				{
					if(value==null)
					{
						DesetupSyncThistoryJadwal(true, true);
					}
					else
					{
						if(_thistoryJadwal!=value)
						{
							IEntity relatedEntity = (IEntity)value;
							relatedEntity.SetRelatedEntity(this, "Tjadwal");
							SetupSyncThistoryJadwal(relatedEntity);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ThistoryJadwal. When set to true, ThistoryJadwal is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ThistoryJadwal is accessed. You can always execute
		/// a forced fetch by calling GetSingleThistoryJadwal(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchThistoryJadwal
		{
			get	{ return _alwaysFetchThistoryJadwal; }
			set	{ _alwaysFetchThistoryJadwal = value; }	
		}
		
		/// <summary>Gets / Sets the lazy loading flag if the property ThistoryJadwal already has been fetched. Setting this property to false when ThistoryJadwal has been fetched
		/// will set ThistoryJadwal to null as well. Setting this property to true while ThistoryJadwal hasn't been fetched disables lazy loading for ThistoryJadwal</summary>
		[Browsable(false)]
		public bool AlreadyFetchedThistoryJadwal
		{
			get { return _alreadyFetchedThistoryJadwal;}
			set 
			{
				if(_alreadyFetchedThistoryJadwal && !value)
				{
					this.ThistoryJadwal = null;
				}
				_alreadyFetchedThistoryJadwal = value;
			}
		}
		
		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ThistoryJadwal is not found
		/// in the database. When set to true, ThistoryJadwal will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ThistoryJadwalReturnsNewIfNotFound
		{
			get	{ return _thistoryJadwalReturnsNewIfNotFound; }
			set	{ _thistoryJadwalReturnsNewIfNotFound = value; }	
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
			get { return (int)Kalibrasi.Data.EntityType.TJadwalEntity; }
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
