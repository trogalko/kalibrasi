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
using System.Data;
using Kalibrasi.Data;
using Kalibrasi.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField instances, used in IEntityFields instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MAlatEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MAlatFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MAlatEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MDepartementEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MDepartementFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MDepartementEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MHakAksesEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MHakAksesFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MHakAksesEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MLokasiEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MLokasiFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MLokasiEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MPicEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MPicFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MPicEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the MUserEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(MUserFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("MUserEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the THistoryAlatEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(THistoryAlatFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("THistoryAlatEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the THistoryJadwalEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(THistoryJadwalFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("THistoryJadwalEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the TJadwalEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(TJadwalFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("TJadwalEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the QDaftarInduk TypedView. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(QDaftarIndukFieldIndex fieldIndex)
		{
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("QDaftarIndukTypedView", (int)fieldIndex), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo("QDaftarIndukTypedView", fieldIndex.ToString()));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the QMjadwal TypedView. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(QMjadwalFieldIndex fieldIndex)
		{
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("QMjadwalTypedView", (int)fieldIndex), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo("QMjadwalTypedView", fieldIndex.ToString()));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the QTjadwalKalibrasi TypedView. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(QTjadwalKalibrasiFieldIndex fieldIndex)
		{
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("QTjadwalKalibrasiTypedView", (int)fieldIndex), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo("QTjadwalKalibrasiTypedView", fieldIndex.ToString()));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the QTreminder TypedView. Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(QTreminderFieldIndex fieldIndex)
		{
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo("QTreminderTypedView", (int)fieldIndex), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo("QTreminderTypedView", fieldIndex.ToString()));
		}

		/// <summary>Creates a new IEntityField instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField Create(string objectName, string fieldName)
        {
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
