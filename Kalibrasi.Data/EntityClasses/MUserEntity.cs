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
	/// Entity class which represents the entity 'MUser'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class MUserEntity : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private Kalibrasi.Data.CollectionClasses.MAlatCollection	_malat;
		private bool	_alwaysFetchMalat, _alreadyFetchedMalat;
		private Kalibrasi.Data.CollectionClasses.MDepartementCollection	_mdepartement;
		private bool	_alwaysFetchMdepartement, _alreadyFetchedMdepartement;
		private Kalibrasi.Data.CollectionClasses.MLokasiCollection	_mlokasi;
		private bool	_alwaysFetchMlokasi, _alreadyFetchedMlokasi;
		private Kalibrasi.Data.CollectionClasses.MPicCollection	_mpic;
		private bool	_alwaysFetchMpic, _alreadyFetchedMpic;

		private MHakAksesEntity _mhakAkses;
		private bool	_alwaysFetchMhakAkses, _alreadyFetchedMhakAkses, _mhakAksesReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static class MemberNames
		{
			/// <summary>Member name MhakAkses</summary>
			public static readonly string MhakAkses = "MhakAkses";
			/// <summary>Member name Malat</summary>
			public static readonly string Malat = "Malat";
			/// <summary>Member name Mdepartement</summary>
			public static readonly string Mdepartement = "Mdepartement";
			/// <summary>Member name Mlokasi</summary>
			public static readonly string Mlokasi = "Mlokasi";
			/// <summary>Member name Mpic</summary>
			public static readonly string Mpic = "Mpic";


		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static MUserEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public MUserEntity()
		{
			InitClassEmpty(null);
		}


		/// <summary>CTor</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		public MUserEntity(System.String cUserId)
		{
			InitClassFetch(cUserId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public MUserEntity(System.String cUserId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(cUserId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="validator">The custom validator object for this MUserEntity</param>
		public MUserEntity(System.String cUserId, IValidator validator)
		{
			InitClassFetch(cUserId, validator, null);
		}


		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected MUserEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_malat = (Kalibrasi.Data.CollectionClasses.MAlatCollection)info.GetValue("_malat", typeof(Kalibrasi.Data.CollectionClasses.MAlatCollection));
			_alwaysFetchMalat = info.GetBoolean("_alwaysFetchMalat");
			_alreadyFetchedMalat = info.GetBoolean("_alreadyFetchedMalat");
			_mdepartement = (Kalibrasi.Data.CollectionClasses.MDepartementCollection)info.GetValue("_mdepartement", typeof(Kalibrasi.Data.CollectionClasses.MDepartementCollection));
			_alwaysFetchMdepartement = info.GetBoolean("_alwaysFetchMdepartement");
			_alreadyFetchedMdepartement = info.GetBoolean("_alreadyFetchedMdepartement");
			_mlokasi = (Kalibrasi.Data.CollectionClasses.MLokasiCollection)info.GetValue("_mlokasi", typeof(Kalibrasi.Data.CollectionClasses.MLokasiCollection));
			_alwaysFetchMlokasi = info.GetBoolean("_alwaysFetchMlokasi");
			_alreadyFetchedMlokasi = info.GetBoolean("_alreadyFetchedMlokasi");
			_mpic = (Kalibrasi.Data.CollectionClasses.MPicCollection)info.GetValue("_mpic", typeof(Kalibrasi.Data.CollectionClasses.MPicCollection));
			_alwaysFetchMpic = info.GetBoolean("_alwaysFetchMpic");
			_alreadyFetchedMpic = info.GetBoolean("_alreadyFetchedMpic");

			_mhakAkses = (MHakAksesEntity)info.GetValue("_mhakAkses", typeof(MHakAksesEntity));
			if(_mhakAkses!=null)
			{
				_mhakAkses.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_mhakAksesReturnsNewIfNotFound = info.GetBoolean("_mhakAksesReturnsNewIfNotFound");
			_alwaysFetchMhakAkses = info.GetBoolean("_alwaysFetchMhakAkses");
			_alreadyFetchedMhakAkses = info.GetBoolean("_alreadyFetchedMhakAkses");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((MUserFieldIndex)fieldIndex)
			{
				case MUserFieldIndex.CIdHakAkses:
					DesetupSyncMhakAkses(true, false);
					_alreadyFetchedMhakAkses = false;
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
			_alreadyFetchedMalat = (_malat.Count > 0);
			_alreadyFetchedMdepartement = (_mdepartement.Count > 0);
			_alreadyFetchedMlokasi = (_mlokasi.Count > 0);
			_alreadyFetchedMpic = (_mpic.Count > 0);

			_alreadyFetchedMhakAkses = (_mhakAkses != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return MUserEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "MhakAkses":
					toReturn.Add(MUserEntity.Relations.MHakAksesEntityUsingCIdHakAkses);
					break;
				case "Malat":
					toReturn.Add(MUserEntity.Relations.MAlatEntityUsingCUserId);
					break;
				case "Mdepartement":
					toReturn.Add(MUserEntity.Relations.MDepartementEntityUsingCUserId);
					break;
				case "Mlokasi":
					toReturn.Add(MUserEntity.Relations.MLokasiEntityUsingCUserId);
					break;
				case "Mpic":
					toReturn.Add(MUserEntity.Relations.MPicEntityUsingCUserId);
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
			info.AddValue("_alwaysFetchMalat", _alwaysFetchMalat);
			info.AddValue("_alreadyFetchedMalat", _alreadyFetchedMalat);
			info.AddValue("_mdepartement", (!this.MarkedForDeletion?_mdepartement:null));
			info.AddValue("_alwaysFetchMdepartement", _alwaysFetchMdepartement);
			info.AddValue("_alreadyFetchedMdepartement", _alreadyFetchedMdepartement);
			info.AddValue("_mlokasi", (!this.MarkedForDeletion?_mlokasi:null));
			info.AddValue("_alwaysFetchMlokasi", _alwaysFetchMlokasi);
			info.AddValue("_alreadyFetchedMlokasi", _alreadyFetchedMlokasi);
			info.AddValue("_mpic", (!this.MarkedForDeletion?_mpic:null));
			info.AddValue("_alwaysFetchMpic", _alwaysFetchMpic);
			info.AddValue("_alreadyFetchedMpic", _alreadyFetchedMpic);

			info.AddValue("_mhakAkses", (!this.MarkedForDeletion?_mhakAkses:null));
			info.AddValue("_mhakAksesReturnsNewIfNotFound", _mhakAksesReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchMhakAkses", _alwaysFetchMhakAkses);
			info.AddValue("_alreadyFetchedMhakAkses", _alreadyFetchedMhakAkses);

			
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
				case "MhakAkses":
					_alreadyFetchedMhakAkses = true;
					this.MhakAkses = (MHakAksesEntity)entity;
					break;
				case "Malat":
					_alreadyFetchedMalat = true;
					if(entity!=null)
					{
						this.Malat.Add((MAlatEntity)entity);
					}
					break;
				case "Mdepartement":
					_alreadyFetchedMdepartement = true;
					if(entity!=null)
					{
						this.Mdepartement.Add((MDepartementEntity)entity);
					}
					break;
				case "Mlokasi":
					_alreadyFetchedMlokasi = true;
					if(entity!=null)
					{
						this.Mlokasi.Add((MLokasiEntity)entity);
					}
					break;
				case "Mpic":
					_alreadyFetchedMpic = true;
					if(entity!=null)
					{
						this.Mpic.Add((MPicEntity)entity);
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
				case "MhakAkses":
					SetupSyncMhakAkses(relatedEntity);
					break;
				case "Malat":
					_malat.Add((MAlatEntity)relatedEntity);
					break;
				case "Mdepartement":
					_mdepartement.Add((MDepartementEntity)relatedEntity);
					break;
				case "Mlokasi":
					_mlokasi.Add((MLokasiEntity)relatedEntity);
					break;
				case "Mpic":
					_mpic.Add((MPicEntity)relatedEntity);
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
				case "MhakAkses":
					DesetupSyncMhakAkses(false, true);
					break;
				case "Malat":
					base.PerformRelatedEntityRemoval(_malat, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Mdepartement":
					base.PerformRelatedEntityRemoval(_mdepartement, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Mlokasi":
					base.PerformRelatedEntityRemoval(_mlokasi, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Mpic":
					base.PerformRelatedEntityRemoval(_mpic, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_mhakAkses!=null)
			{
				toReturn.Add(_mhakAkses);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_malat);
			toReturn.Add(_mdepartement);
			toReturn.Add(_mlokasi);
			toReturn.Add(_mpic);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cUserId)
		{
			return FetchUsingPK(cUserId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cUserId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(cUserId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cUserId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(cUserId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String cUserId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(cUserId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.CUserId, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(MUserFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(MUserFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new MUserRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'MAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MAlatEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MAlatCollection GetMultiMalat(bool forceFetch)
		{
			return GetMultiMalat(forceFetch, _malat.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MAlatEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MAlatCollection GetMultiMalat(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMalat(forceFetch, _malat.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.MAlatCollection GetMultiMalat(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMalat(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MAlatEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.MAlatCollection GetMultiMalat(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMalat || forceFetch || _alwaysFetchMalat) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_malat.ParticipatesInTransaction)
					{
						base.Transaction.Add(_malat);
					}
				}
				_malat.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_malat.EntityFactoryToUse = entityFactoryToUse;
				}
				_malat.GetMultiManyToOne(this, filter);
				_malat.SuppressClearInGetMulti=false;
				_alreadyFetchedMalat = true;
			}
			return _malat;
		}

		/// <summary> Sets the collection parameters for the collection for 'Malat'. These settings will be taken into account
		/// when the property Malat is requested or GetMultiMalat is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMalat(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_malat.SortClauses=sortClauses;
			_malat.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'MDepartementEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MDepartementEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MDepartementCollection GetMultiMdepartement(bool forceFetch)
		{
			return GetMultiMdepartement(forceFetch, _mdepartement.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MDepartementEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MDepartementEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MDepartementCollection GetMultiMdepartement(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMdepartement(forceFetch, _mdepartement.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MDepartementEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.MDepartementCollection GetMultiMdepartement(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMdepartement(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MDepartementEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.MDepartementCollection GetMultiMdepartement(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMdepartement || forceFetch || _alwaysFetchMdepartement) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_mdepartement.ParticipatesInTransaction)
					{
						base.Transaction.Add(_mdepartement);
					}
				}
				_mdepartement.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_mdepartement.EntityFactoryToUse = entityFactoryToUse;
				}
				_mdepartement.GetMultiManyToOne(this, filter);
				_mdepartement.SuppressClearInGetMulti=false;
				_alreadyFetchedMdepartement = true;
			}
			return _mdepartement;
		}

		/// <summary> Sets the collection parameters for the collection for 'Mdepartement'. These settings will be taken into account
		/// when the property Mdepartement is requested or GetMultiMdepartement is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMdepartement(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_mdepartement.SortClauses=sortClauses;
			_mdepartement.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'MLokasiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MLokasiEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MLokasiCollection GetMultiMlokasi(bool forceFetch)
		{
			return GetMultiMlokasi(forceFetch, _mlokasi.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MLokasiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MLokasiEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MLokasiCollection GetMultiMlokasi(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMlokasi(forceFetch, _mlokasi.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MLokasiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.MLokasiCollection GetMultiMlokasi(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMlokasi(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MLokasiEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.MLokasiCollection GetMultiMlokasi(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMlokasi || forceFetch || _alwaysFetchMlokasi) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_mlokasi.ParticipatesInTransaction)
					{
						base.Transaction.Add(_mlokasi);
					}
				}
				_mlokasi.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_mlokasi.EntityFactoryToUse = entityFactoryToUse;
				}
				_mlokasi.GetMultiManyToOne(this, filter);
				_mlokasi.SuppressClearInGetMulti=false;
				_alreadyFetchedMlokasi = true;
			}
			return _mlokasi;
		}

		/// <summary> Sets the collection parameters for the collection for 'Mlokasi'. These settings will be taken into account
		/// when the property Mlokasi is requested or GetMultiMlokasi is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMlokasi(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_mlokasi.SortClauses=sortClauses;
			_mlokasi.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'MPicEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'MPicEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MPicCollection GetMultiMpic(bool forceFetch)
		{
			return GetMultiMpic(forceFetch, _mpic.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MPicEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'MPicEntity'</returns>
		public Kalibrasi.Data.CollectionClasses.MPicCollection GetMultiMpic(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiMpic(forceFetch, _mpic.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'MPicEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public Kalibrasi.Data.CollectionClasses.MPicCollection GetMultiMpic(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiMpic(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'MPicEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual Kalibrasi.Data.CollectionClasses.MPicCollection GetMultiMpic(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedMpic || forceFetch || _alwaysFetchMpic) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_mpic.ParticipatesInTransaction)
					{
						base.Transaction.Add(_mpic);
					}
				}
				_mpic.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_mpic.EntityFactoryToUse = entityFactoryToUse;
				}
				_mpic.GetMultiManyToOne(this, filter);
				_mpic.SuppressClearInGetMulti=false;
				_alreadyFetchedMpic = true;
			}
			return _mpic;
		}

		/// <summary> Sets the collection parameters for the collection for 'Mpic'. These settings will be taken into account
		/// when the property Mpic is requested or GetMultiMpic is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersMpic(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_mpic.SortClauses=sortClauses;
			_mpic.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}


		/// <summary> Retrieves the related entity of type 'MHakAksesEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'MHakAksesEntity' which is related to this entity.</returns>
		public MHakAksesEntity GetSingleMhakAkses()
		{
			return GetSingleMhakAkses(false);
		}

		/// <summary> Retrieves the related entity of type 'MHakAksesEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'MHakAksesEntity' which is related to this entity.</returns>
		public virtual MHakAksesEntity GetSingleMhakAkses(bool forceFetch)
		{
			if( ( !_alreadyFetchedMhakAkses || forceFetch || _alwaysFetchMhakAkses) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(MUserEntity.Relations.MHakAksesEntityUsingCIdHakAkses);

				MHakAksesEntity newEntity = new MHakAksesEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.CIdHakAkses);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (MHakAksesEntity)base.ActiveContext.Get(newEntity);
					}
					this.MhakAkses = newEntity;
				}
				else
				{
					if(_mhakAksesReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_mhakAkses == null)))
						{
							this.MhakAkses = newEntity;
						}
					}
					else
					{
						this.MhakAkses = null;
					}
				}
				_alreadyFetchedMhakAkses = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _mhakAkses;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			MUserDAO dao = (MUserDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_malat.ActiveContext = base.ActiveContext;
			_mdepartement.ActiveContext = base.ActiveContext;
			_mlokasi.ActiveContext = base.ActiveContext;
			_mpic.ActiveContext = base.ActiveContext;

			if(_mhakAkses!=null)
			{
				_mhakAkses.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			MUserDAO dao = (MUserDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			MUserDAO dao = (MUserDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(Kalibrasi.Data.EntityType.MUserEntity);
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
			toReturn.Add("MhakAkses", _mhakAkses);
			toReturn.Add("Malat", _malat);
			toReturn.Add("Mdepartement", _mdepartement);
			toReturn.Add("Mlokasi", _mlokasi);
			toReturn.Add("Mpic", _mpic);


			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="validator">The validator object for this MUserEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.String cUserId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(cUserId, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_malat = new Kalibrasi.Data.CollectionClasses.MAlatCollection(new MAlatEntityFactory());
			_malat.SetContainingEntityInfo(this, "Muser");
			_alwaysFetchMalat = false;
			_alreadyFetchedMalat = false;
			_mdepartement = new Kalibrasi.Data.CollectionClasses.MDepartementCollection(new MDepartementEntityFactory());
			_mdepartement.SetContainingEntityInfo(this, "Muser");
			_alwaysFetchMdepartement = false;
			_alreadyFetchedMdepartement = false;
			_mlokasi = new Kalibrasi.Data.CollectionClasses.MLokasiCollection(new MLokasiEntityFactory());
			_mlokasi.SetContainingEntityInfo(this, "Muser");
			_alwaysFetchMlokasi = false;
			_alreadyFetchedMlokasi = false;
			_mpic = new Kalibrasi.Data.CollectionClasses.MPicCollection(new MPicEntityFactory());
			_mpic.SetContainingEntityInfo(this, "Muser");
			_alwaysFetchMpic = false;
			_alreadyFetchedMpic = false;

			_mhakAkses = null;
			_mhakAksesReturnsNewIfNotFound = true;
			_alwaysFetchMhakAkses = false;
			_alreadyFetchedMhakAkses = false;


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

			_fieldsCustomProperties.Add("CPassword", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("CIdHakAkses", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _mhakAkses</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncMhakAkses(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _mhakAkses, new PropertyChangedEventHandler( OnMhakAksesPropertyChanged ), "MhakAkses", MUserEntity.Relations.MHakAksesEntityUsingCIdHakAkses, true, signalRelatedEntity, "Muser", resetFKFields, new int[] { (int)MUserFieldIndex.CIdHakAkses } );		
			_mhakAkses = null;
		}
		
		/// <summary> setups the sync logic for member _mhakAkses</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncMhakAkses(IEntity relatedEntity)
		{
			if(_mhakAkses!=relatedEntity)
			{		
				DesetupSyncMhakAkses(true, true);
				_mhakAkses = (MHakAksesEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _mhakAkses, new PropertyChangedEventHandler( OnMhakAksesPropertyChanged ), "MhakAkses", MUserEntity.Relations.MHakAksesEntityUsingCIdHakAkses, true, ref _alreadyFetchedMhakAkses, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnMhakAksesPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="cUserId">PK value for MUser which data should be fetched into this MUser object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String cUserId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)MUserFieldIndex.CUserId].ForcedCurrentValueWrite(cUserId);
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
			return DAOFactory.CreateMUserDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new MUserEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static MUserRelations Relations
		{
			get	{ return new MUserRelations(); }
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
					(IEntityRelation)GetRelationsForField("Malat")[0], (int)Kalibrasi.Data.EntityType.MUserEntity, (int)Kalibrasi.Data.EntityType.MAlatEntity, 0, null, null, null, "Malat", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MDepartement' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMdepartement
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MDepartementCollection(),
					(IEntityRelation)GetRelationsForField("Mdepartement")[0], (int)Kalibrasi.Data.EntityType.MUserEntity, (int)Kalibrasi.Data.EntityType.MDepartementEntity, 0, null, null, null, "Mdepartement", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MLokasi' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMlokasi
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MLokasiCollection(),
					(IEntityRelation)GetRelationsForField("Mlokasi")[0], (int)Kalibrasi.Data.EntityType.MUserEntity, (int)Kalibrasi.Data.EntityType.MLokasiEntity, 0, null, null, null, "Mlokasi", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MPic' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMpic
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MPicCollection(),
					(IEntityRelation)GetRelationsForField("Mpic")[0], (int)Kalibrasi.Data.EntityType.MUserEntity, (int)Kalibrasi.Data.EntityType.MPicEntity, 0, null, null, null, "Mpic", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MHakAkses' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathMhakAkses
		{
			get
			{
				return new PrefetchPathElement(new Kalibrasi.Data.CollectionClasses.MHakAksesCollection(),
					(IEntityRelation)GetRelationsForField("MhakAkses")[0], (int)Kalibrasi.Data.EntityType.MUserEntity, (int)Kalibrasi.Data.EntityType.MHakAksesEntity, 0, null, null, null, "MhakAkses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "MUserEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return MUserEntity.CustomProperties;}
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
			get { return MUserEntity.FieldsCustomProperties;}
		}

		/// <summary> The CUserId property of the Entity MUser<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_User"."C_UserId"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, true, false</remarks>
		public virtual System.String CUserId
		{
			get { return (System.String)GetValue((int)MUserFieldIndex.CUserId, true); }
			set	{ SetValue((int)MUserFieldIndex.CUserId, value, true); }
		}
		/// <summary> The CPassword property of the Entity MUser<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_User"."C_Password"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 255<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CPassword
		{
			get { return (System.String)GetValue((int)MUserFieldIndex.CPassword, true); }
			set	{ SetValue((int)MUserFieldIndex.CPassword, value, true); }
		}
		/// <summary> The CIdHakAkses property of the Entity MUser<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "M_User"."C_IdHakAkses"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarWChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CIdHakAkses
		{
			get { return (System.String)GetValue((int)MUserFieldIndex.CIdHakAkses, true); }
			set	{ SetValue((int)MUserFieldIndex.CIdHakAkses, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'MAlatEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMalat()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.MAlatCollection Malat
		{
			get	{ return GetMultiMalat(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Malat. When set to true, Malat is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Malat is accessed. You can always execute
		/// a forced fetch by calling GetMultiMalat(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMalat
		{
			get	{ return _alwaysFetchMalat; }
			set	{ _alwaysFetchMalat = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Malat already has been fetched. Setting this property to false when Malat has been fetched
		/// will clear the Malat collection well. Setting this property to true while Malat hasn't been fetched disables lazy loading for Malat</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMalat
		{
			get { return _alreadyFetchedMalat;}
			set 
			{
				if(_alreadyFetchedMalat && !value && (_malat != null))
				{
					_malat.Clear();
				}
				_alreadyFetchedMalat = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'MDepartementEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMdepartement()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.MDepartementCollection Mdepartement
		{
			get	{ return GetMultiMdepartement(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Mdepartement. When set to true, Mdepartement is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Mdepartement is accessed. You can always execute
		/// a forced fetch by calling GetMultiMdepartement(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMdepartement
		{
			get	{ return _alwaysFetchMdepartement; }
			set	{ _alwaysFetchMdepartement = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Mdepartement already has been fetched. Setting this property to false when Mdepartement has been fetched
		/// will clear the Mdepartement collection well. Setting this property to true while Mdepartement hasn't been fetched disables lazy loading for Mdepartement</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMdepartement
		{
			get { return _alreadyFetchedMdepartement;}
			set 
			{
				if(_alreadyFetchedMdepartement && !value && (_mdepartement != null))
				{
					_mdepartement.Clear();
				}
				_alreadyFetchedMdepartement = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'MLokasiEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMlokasi()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.MLokasiCollection Mlokasi
		{
			get	{ return GetMultiMlokasi(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Mlokasi. When set to true, Mlokasi is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Mlokasi is accessed. You can always execute
		/// a forced fetch by calling GetMultiMlokasi(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMlokasi
		{
			get	{ return _alwaysFetchMlokasi; }
			set	{ _alwaysFetchMlokasi = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Mlokasi already has been fetched. Setting this property to false when Mlokasi has been fetched
		/// will clear the Mlokasi collection well. Setting this property to true while Mlokasi hasn't been fetched disables lazy loading for Mlokasi</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMlokasi
		{
			get { return _alreadyFetchedMlokasi;}
			set 
			{
				if(_alreadyFetchedMlokasi && !value && (_mlokasi != null))
				{
					_mlokasi.Clear();
				}
				_alreadyFetchedMlokasi = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'MPicEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMpic()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual Kalibrasi.Data.CollectionClasses.MPicCollection Mpic
		{
			get	{ return GetMultiMpic(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for Mpic. When set to true, Mpic is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Mpic is accessed. You can always execute
		/// a forced fetch by calling GetMultiMpic(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMpic
		{
			get	{ return _alwaysFetchMpic; }
			set	{ _alwaysFetchMpic = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property Mpic already has been fetched. Setting this property to false when Mpic has been fetched
		/// will clear the Mpic collection well. Setting this property to true while Mpic hasn't been fetched disables lazy loading for Mpic</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMpic
		{
			get { return _alreadyFetchedMpic;}
			set 
			{
				if(_alreadyFetchedMpic && !value && (_mpic != null))
				{
					_mpic.Clear();
				}
				_alreadyFetchedMpic = value;
			}
		}


		/// <summary> Gets / sets related entity of type 'MHakAksesEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMhakAkses()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual MHakAksesEntity MhakAkses
		{
			get	{ return GetSingleMhakAkses(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncMhakAkses(value);
				}
				else
				{
					if(value==null)
					{
						if(_mhakAkses != null)
						{
							_mhakAkses.UnsetRelatedEntity(this, "Muser");
						}
					}
					else
					{
						if(_mhakAkses!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "Muser");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for MhakAkses. When set to true, MhakAkses is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time MhakAkses is accessed. You can always execute
		/// a forced fetch by calling GetSingleMhakAkses(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchMhakAkses
		{
			get	{ return _alwaysFetchMhakAkses; }
			set	{ _alwaysFetchMhakAkses = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property MhakAkses already has been fetched. Setting this property to false when MhakAkses has been fetched
		/// will set MhakAkses to null as well. Setting this property to true while MhakAkses hasn't been fetched disables lazy loading for MhakAkses</summary>
		[Browsable(false)]
		public bool AlreadyFetchedMhakAkses
		{
			get { return _alreadyFetchedMhakAkses;}
			set 
			{
				if(_alreadyFetchedMhakAkses && !value)
				{
					this.MhakAkses = null;
				}
				_alreadyFetchedMhakAkses = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property MhakAkses is not found
		/// in the database. When set to true, MhakAkses will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool MhakAksesReturnsNewIfNotFound
		{
			get	{ return _mhakAksesReturnsNewIfNotFound; }
			set { _mhakAksesReturnsNewIfNotFound = value; }	
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
			get { return (int)Kalibrasi.Data.EntityType.MUserEntity; }
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
