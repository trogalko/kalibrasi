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
	/// <summary>Implements the static Relations variant for the entity: MHakAkses. </summary>
	public partial class MHakAksesRelations
	{
		/// <summary>CTor</summary>
		public MHakAksesRelations()
		{
		}

		/// <summary>Gets all relations of the MHakAksesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.MUserEntityUsingCIdHakAkses);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between MHakAksesEntity and MUserEntity over the 1:n relation they have, using the relation between the fields:
		/// MHakAkses.CIdHakAkses - MUser.CIdHakAkses
		/// </summary>
		public virtual IEntityRelation MUserEntityUsingCIdHakAkses
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Muser" , true);
				relation.AddEntityFieldPair(MHakAksesFields.CIdHakAkses, MUserFields.CIdHakAkses);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MHakAksesEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MUserEntity", false);
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
