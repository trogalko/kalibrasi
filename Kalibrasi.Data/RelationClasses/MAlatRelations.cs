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
	/// <summary>Implements the static Relations variant for the entity: MAlat. </summary>
	public partial class MAlatRelations
	{
		/// <summary>CTor</summary>
		public MAlatRelations()
		{
		}

		/// <summary>Gets all relations of the MAlatEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.THistoryAlatEntityUsingCIdAlat);

			toReturn.Add(this.MUserEntityUsingCUserId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between MAlatEntity and THistoryAlatEntity over the 1:n relation they have, using the relation between the fields:
		/// MAlat.CIdAlat - THistoryAlat.CIdAlat
		/// </summary>
		public virtual IEntityRelation THistoryAlatEntityUsingCIdAlat
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ThistoryAlat" , true);
				relation.AddEntityFieldPair(MAlatFields.CIdAlat, THistoryAlatFields.CIdAlat);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MAlatEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("THistoryAlatEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between MAlatEntity and MUserEntity over the m:1 relation they have, using the relation between the fields:
		/// MAlat.CUserId - MUser.CUserId
		/// </summary>
		public virtual IEntityRelation MUserEntityUsingCUserId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Muser", false);
				relation.AddEntityFieldPair(MUserFields.CUserId, MAlatFields.CUserId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MAlatEntity", true);
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
