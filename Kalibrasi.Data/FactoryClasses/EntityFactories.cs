///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:45 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using Kalibrasi.Data.HelperClasses;

using Kalibrasi.Data.EntityClasses;
using Kalibrasi.Data.RelationClasses;
using Kalibrasi.Data.DaoClasses;
using Kalibrasi.Data.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase : EntityFactoryCore
	{
		private string _entityName;
		private Kalibrasi.Data.EntityType _typeOfEntity;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		public EntityFactoryBase(string entityName, Kalibrasi.Data.EntityType typeOfEntity)
		{
			_entityName = entityName;
			_typeOfEntity = typeOfEntity;
		}

		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((Kalibrasi.Data.EntityType)entityTypeValue);
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields object for the entity to create. </summary>
		/// <returns>Empty IEntityFields object.</returns>
		public override IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(_entityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity)
		{
			IEntityFactory toReturn = (IEntityFactory)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(_entityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
						
		/// <summary>Creates a new entity collection for the entity of this factory.</summary>
		/// <returns>ready to use new entity collection, typed.</returns>
		public override IEntityCollection CreateEntityCollection()
		{
			return GeneralEntityCollectionFactory.Create(_typeOfEntity);
		}
		
		/// <summary>returns the name of the entity this factory is for, e.g. "EmployeeEntity"</summary>
		public override string ForEntityName 
		{ 
			get { return _entityName; }
		}
	}
	
	/// <summary>Factory to create new, empty MAlatEntity objects.</summary>
	[Serializable]
	public partial class MAlatEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MAlatEntityFactory() : base("MAlatEntity", Kalibrasi.Data.EntityType.MAlatEntity) { }

		/// <summary>Creates a new, empty MAlatEntity object.</summary>
		/// <returns>A new, empty MAlatEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MAlatEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMAlat
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MAlatEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMAlatUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MDepartementEntity objects.</summary>
	[Serializable]
	public partial class MDepartementEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MDepartementEntityFactory() : base("MDepartementEntity", Kalibrasi.Data.EntityType.MDepartementEntity) { }

		/// <summary>Creates a new, empty MDepartementEntity object.</summary>
		/// <returns>A new, empty MDepartementEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MDepartementEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMDepartement
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MDepartementEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMDepartementUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MHakAksesEntity objects.</summary>
	[Serializable]
	public partial class MHakAksesEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MHakAksesEntityFactory() : base("MHakAksesEntity", Kalibrasi.Data.EntityType.MHakAksesEntity) { }

		/// <summary>Creates a new, empty MHakAksesEntity object.</summary>
		/// <returns>A new, empty MHakAksesEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MHakAksesEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMHakAkses
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MHakAksesEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMHakAksesUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MLokasiEntity objects.</summary>
	[Serializable]
	public partial class MLokasiEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MLokasiEntityFactory() : base("MLokasiEntity", Kalibrasi.Data.EntityType.MLokasiEntity) { }

		/// <summary>Creates a new, empty MLokasiEntity object.</summary>
		/// <returns>A new, empty MLokasiEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MLokasiEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMLokasi
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MLokasiEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMLokasiUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MPicEntity objects.</summary>
	[Serializable]
	public partial class MPicEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MPicEntityFactory() : base("MPicEntity", Kalibrasi.Data.EntityType.MPicEntity) { }

		/// <summary>Creates a new, empty MPicEntity object.</summary>
		/// <returns>A new, empty MPicEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MPicEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMPic
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MPicEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMPicUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty MUserEntity objects.</summary>
	[Serializable]
	public partial class MUserEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public MUserEntityFactory() : base("MUserEntity", Kalibrasi.Data.EntityType.MUserEntity) { }

		/// <summary>Creates a new, empty MUserEntity object.</summary>
		/// <returns>A new, empty MUserEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new MUserEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMUser
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new MUserEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewMUserUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty THistoryAlatEntity objects.</summary>
	[Serializable]
	public partial class THistoryAlatEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public THistoryAlatEntityFactory() : base("THistoryAlatEntity", Kalibrasi.Data.EntityType.THistoryAlatEntity) { }

		/// <summary>Creates a new, empty THistoryAlatEntity object.</summary>
		/// <returns>A new, empty THistoryAlatEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new THistoryAlatEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTHistoryAlat
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new THistoryAlatEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTHistoryAlatUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty THistoryJadwalEntity objects.</summary>
	[Serializable]
	public partial class THistoryJadwalEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public THistoryJadwalEntityFactory() : base("THistoryJadwalEntity", Kalibrasi.Data.EntityType.THistoryJadwalEntity) { }

		/// <summary>Creates a new, empty THistoryJadwalEntity object.</summary>
		/// <returns>A new, empty THistoryJadwalEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new THistoryJadwalEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTHistoryJadwal
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new THistoryJadwalEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTHistoryJadwalUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}
	
	/// <summary>Factory to create new, empty TJadwalEntity objects.</summary>
	[Serializable]
	public partial class TJadwalEntityFactory : EntityFactoryBase {
		/// <summary>CTor</summary>
		public TJadwalEntityFactory() : base("TJadwalEntity", Kalibrasi.Data.EntityType.TJadwalEntity) { }

		/// <summary>Creates a new, empty TJadwalEntity object.</summary>
		/// <returns>A new, empty TJadwalEntity object.</returns>
		public override IEntity Create() {
			IEntity toReturn = new TJadwalEntity();
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTJadwal
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		
		/// <summary>Creates a new TJadwalEntity instance and will set the Fields object of the new IEntity instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields object for the new IEntity to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields object) IEntity object</returns>
		public override IEntity Create(IEntityFields fields) {
			IEntity toReturn = Create();
			toReturn.Fields = fields;
			
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTJadwalUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}

		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new entity collection objects</summary>
	[Serializable]
	public partial class GeneralEntityCollectionFactory
	{
		/// <summary>Creates a new entity collection</summary>
		/// <param name="typeToUse">The entity type to create the collection for.</param>
		/// <returns>A new entity collection object.</returns>
		public static IEntityCollection Create(Kalibrasi.Data.EntityType typeToUse)
		{
			switch(typeToUse)
			{
				case Kalibrasi.Data.EntityType.MAlatEntity:
					return new MAlatCollection();
				case Kalibrasi.Data.EntityType.MDepartementEntity:
					return new MDepartementCollection();
				case Kalibrasi.Data.EntityType.MHakAksesEntity:
					return new MHakAksesCollection();
				case Kalibrasi.Data.EntityType.MLokasiEntity:
					return new MLokasiCollection();
				case Kalibrasi.Data.EntityType.MPicEntity:
					return new MPicCollection();
				case Kalibrasi.Data.EntityType.MUserEntity:
					return new MUserCollection();
				case Kalibrasi.Data.EntityType.THistoryAlatEntity:
					return new THistoryAlatCollection();
				case Kalibrasi.Data.EntityType.THistoryJadwalEntity:
					return new THistoryJadwalCollection();
				case Kalibrasi.Data.EntityType.TJadwalEntity:
					return new TJadwalCollection();
				default:
					return null;
			}
		}		
	}
	
	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity Create(Kalibrasi.Data.EntityType entityTypeToCreate)
		{
			IEntityFactory factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case Kalibrasi.Data.EntityType.MAlatEntity:
					factoryToUse = new MAlatEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.MDepartementEntity:
					factoryToUse = new MDepartementEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.MHakAksesEntity:
					factoryToUse = new MHakAksesEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.MLokasiEntity:
					factoryToUse = new MLokasiEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.MPicEntity:
					factoryToUse = new MPicEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.MUserEntity:
					factoryToUse = new MUserEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.THistoryAlatEntity:
					factoryToUse = new THistoryAlatEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.THistoryJadwalEntity:
					factoryToUse = new THistoryJadwalEntityFactory();
					break;
				case Kalibrasi.Data.EntityType.TJadwalEntity:
					factoryToUse = new TJadwalEntityFactory();
					break;
			}
			IEntity toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
	
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the Kalibrasi.Data.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Kalibrasi.Data.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory> _factoryPerType = new Dictionary<Type, IEntityFactory>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(Kalibrasi.Data.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity dummy = GeneralEntityFactory.Create((Kalibrasi.Data.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Type typeOfEntity)
		{
			IEntityFactory toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the Kalibrasi.Data.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory GetFactory(Kalibrasi.Data.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif
	}
	
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator
	{
		/// <summary>Gets the factory of the Entity type with the Kalibrasi.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(int entityTypeValue)
		{
			return (IEntityFactory)this.GetFactoryImpl(entityTypeValue);
		}

		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}
		
		/// <summary>Gets an instance of the TypedListDAO class to execute dynamic lists and projections.</summary>
		/// <returns>ready to use typedlistDAO</returns>
		public IDao GetTypedListDao()
		{
			return new TypedListDAO();
		}
		
		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (Kalibrasi.Data.EntityType)Enum.Parse(typeof(Kalibrasi.Data.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((Kalibrasi.Data.EntityType)Enum.Parse(typeof(Kalibrasi.Data.EntityType), leftOperandEntityName, false), joinType, (Kalibrasi.Data.EntityType)Enum.Parse(typeof(Kalibrasi.Data.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
				
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the Kalibrasi.Data.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((Kalibrasi.Data.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
