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
	/// <summary>Implements the static Relations variant for the entity: TJadwal. </summary>
	public partial class TJadwalRelations
	{
		/// <summary>CTor</summary>
		public TJadwalRelations()
		{
		}

		/// <summary>Gets all relations of the TJadwalEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();

			toReturn.Add(this.THistoryJadwalEntityUsingDEntry);
			toReturn.Add(this.MPicEntityUsingCPic);
			return toReturn;
		}

		#region Class Property Declarations


		/// <summary>Returns a new IEntityRelation object, between TJadwalEntity and THistoryJadwalEntity over the 1:1 relation they have, using the relation between the fields:
		/// TJadwal.DEntry - THistoryJadwal.DEntry
		/// </summary>
		public virtual IEntityRelation THistoryJadwalEntityUsingDEntry
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "ThistoryJadwal", false);



				relation.AddEntityFieldPair(THistoryJadwalFields.DEntry, TJadwalFields.DEntry);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("THistoryJadwalEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TJadwalEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between TJadwalEntity and MPicEntity over the m:1 relation they have, using the relation between the fields:
		/// TJadwal.CPic - MPic.CPic
		/// </summary>
		public virtual IEntityRelation MPicEntityUsingCPic
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Mpic", false);
				relation.AddEntityFieldPair(MPicFields.CPic, TJadwalFields.CPic);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("MPicEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TJadwalEntity", true);
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
