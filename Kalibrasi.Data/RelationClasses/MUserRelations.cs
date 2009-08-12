///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:40 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Kalibrasi.Data;
using Kalibrasi.Data.FactoryClasses;
using Kalibrasi.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: MUser. </summary>
	public partial class MUserRelations
	{
		/// <summary>CTor</summary>
		public MUserRelations()
		{
		}

		/// <summary>Gets all relations of the MUserEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.MAlatEntityUsingCUserId);
			toReturn.Add(this.MDepartementEntityUsingCUserId);
			toReturn.Add(this.MLokasiEntityUsingCUserId);
			toReturn.Add(this.MPicEntityUsingCUserId);

			toReturn.Add(this.MHakAksesEntityUsingCIdHakAkses);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between MUserEntity and MAlatEntity over the 1:n relation they have, using the relation between the fields:
		/// MUser.CUserId - MAlat.CUserId
		/// </summary>
		public virtual IEntityRelation MAlatEntityUsingCUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Malat" , true);
				relation.AddEntityFieldPair(MUserFields.CUserId, MAlatFields.CUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MAlatEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between MUserEntity and MDepartementEntity over the 1:n relation they have, using the relation between the fields:
		/// MUser.CUserId - MDepartement.CUserId
		/// </summary>
		public virtual IEntityRelation MDepartementEntityUsingCUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Mdepartement" , true);
				relation.AddEntityFieldPair(MUserFields.CUserId, MDepartementFields.CUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MDepartementEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between MUserEntity and MLokasiEntity over the 1:n relation they have, using the relation between the fields:
		/// MUser.CUserId - MLokasi.CUserId
		/// </summary>
		public virtual IEntityRelation MLokasiEntityUsingCUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Mlokasi" , true);
				relation.AddEntityFieldPair(MUserFields.CUserId, MLokasiFields.CUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MLokasiEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between MUserEntity and MPicEntity over the 1:n relation they have, using the relation between the fields:
		/// MUser.CUserId - MPic.CUserId
		/// </summary>
		public virtual IEntityRelation MPicEntityUsingCUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Mpic" , true);
				relation.AddEntityFieldPair(MUserFields.CUserId, MPicFields.CUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MPicEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between MUserEntity and MHakAksesEntity over the m:1 relation they have, using the relation between the fields:
		/// MUser.CIdHakAkses - MHakAkses.CIdHakAkses
		/// </summary>
		public virtual IEntityRelation MHakAksesEntityUsingCIdHakAkses
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "MhakAkses", false);
				relation.AddEntityFieldPair(MHakAksesFields.CIdHakAkses, MUserFields.CIdHakAkses);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MHakAksesEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", true);
				return relation;
			}
		}

		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
