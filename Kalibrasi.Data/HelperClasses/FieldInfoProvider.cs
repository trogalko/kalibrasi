///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:38 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (9 + 4));
			InitMAlatEntityInfos();
			InitMDepartementEntityInfos();
			InitMHakAksesEntityInfos();
			InitMLokasiEntityInfos();
			InitMPicEntityInfos();
			InitMUserEntityInfos();
			InitTHistoryAlatEntityInfos();
			InitTHistoryJadwalEntityInfos();
			InitTJadwalEntityInfos();
			InitQDaftarIndukTypedViewInfos();
			InitQMjadwalTypedViewInfos();
			InitQTjadwalKalibrasiTypedViewInfos();
			InitQTreminderTypedViewInfos();
			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits MAlatEntity's FieldInfo objects</summary>
		private void InitMAlatEntityInfos()
		{
			base.AddElementFieldInfo("MAlatEntity", "CUserId", typeof(System.String), false, true, false, true,  (int)MAlatFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "DEntry", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MAlatFieldIndex.DEntry, 0, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "CIdAlat", typeof(System.String), true, false, false, true,  (int)MAlatFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "CNamaAlat", typeof(System.String), false, false, false, true,  (int)MAlatFieldIndex.CNamaAlat, 100, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "CBatasToleransi", typeof(System.String), false, false, false, true,  (int)MAlatFieldIndex.CBatasToleransi, 255, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "NInterval", typeof(Nullable<System.Int16>), false, false, false, true,  (int)MAlatFieldIndex.NInterval, 0, 0, 5);
			base.AddElementFieldInfo("MAlatEntity", "NIntervalEks", typeof(Nullable<System.Int16>), false, false, false, true,  (int)MAlatFieldIndex.NIntervalEks, 0, 0, 5);
			base.AddElementFieldInfo("MAlatEntity", "LJkInternal", typeof(System.Boolean), false, false, false, false,  (int)MAlatFieldIndex.LJkInternal, 2, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "LJkEksternal", typeof(System.Boolean), false, false, false, false,  (int)MAlatFieldIndex.LJkEksternal, 2, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "LStatusAlat", typeof(System.Boolean), false, false, false, false,  (int)MAlatFieldIndex.LStatusAlat, 2, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "CKeterangan", typeof(System.String), false, false, false, true,  (int)MAlatFieldIndex.CKeterangan, 255, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "DConfirm", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MAlatFieldIndex.DConfirm, 0, 0, 0);
			base.AddElementFieldInfo("MAlatEntity", "CConfirm", typeof(System.String), false, false, false, true,  (int)MAlatFieldIndex.CConfirm, 15, 0, 0);
		}
		/// <summary>Inits MDepartementEntity's FieldInfo objects</summary>
		private void InitMDepartementEntityInfos()
		{
			base.AddElementFieldInfo("MDepartementEntity", "CUserId", typeof(System.String), false, true, false, true,  (int)MDepartementFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("MDepartementEntity", "CIdDept", typeof(System.String), true, false, false, true,  (int)MDepartementFieldIndex.CIdDept, 5, 0, 0);
			base.AddElementFieldInfo("MDepartementEntity", "CNamaDept", typeof(System.String), false, false, false, true,  (int)MDepartementFieldIndex.CNamaDept, 30, 0, 0);
		}
		/// <summary>Inits MHakAksesEntity's FieldInfo objects</summary>
		private void InitMHakAksesEntityInfos()
		{
			base.AddElementFieldInfo("MHakAksesEntity", "CIdHakAkses", typeof(System.String), true, false, false, true,  (int)MHakAksesFieldIndex.CIdHakAkses, 5, 0, 0);
			base.AddElementFieldInfo("MHakAksesEntity", "CHakAkses", typeof(System.String), false, false, false, true,  (int)MHakAksesFieldIndex.CHakAkses, 15, 0, 0);
		}
		/// <summary>Inits MLokasiEntity's FieldInfo objects</summary>
		private void InitMLokasiEntityInfos()
		{
			base.AddElementFieldInfo("MLokasiEntity", "CUserId", typeof(System.String), false, true, false, true,  (int)MLokasiFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("MLokasiEntity", "CIdLokasi", typeof(System.String), true, false, false, true,  (int)MLokasiFieldIndex.CIdLokasi, 20, 0, 0);
			base.AddElementFieldInfo("MLokasiEntity", "CIdDept", typeof(System.String), false, false, false, true,  (int)MLokasiFieldIndex.CIdDept, 15, 0, 0);
			base.AddElementFieldInfo("MLokasiEntity", "CNamaLokasi", typeof(System.String), false, false, false, true,  (int)MLokasiFieldIndex.CNamaLokasi, 50, 0, 0);
		}
		/// <summary>Inits MPicEntity's FieldInfo objects</summary>
		private void InitMPicEntityInfos()
		{
			base.AddElementFieldInfo("MPicEntity", "CUserId", typeof(System.String), false, true, false, true,  (int)MPicFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "DEntry", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)MPicFieldIndex.DEntry, 0, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "CPic", typeof(System.String), true, false, false, true,  (int)MPicFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "MAlamat", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.MAlamat, 536870911, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "CNoTelp", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.CNoTelp, 255, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "CFax", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.CFax, 255, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "CEmail", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.CEmail, 255, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "CCperson", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.CCperson, 255, 0, 0);
			base.AddElementFieldInfo("MPicEntity", "MNotes", typeof(System.String), false, false, false, true,  (int)MPicFieldIndex.MNotes, 536870911, 0, 0);
		}
		/// <summary>Inits MUserEntity's FieldInfo objects</summary>
		private void InitMUserEntityInfos()
		{
			base.AddElementFieldInfo("MUserEntity", "CUserId", typeof(System.String), true, false, false, true,  (int)MUserFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("MUserEntity", "CPassword", typeof(System.String), false, false, false, true,  (int)MUserFieldIndex.CPassword, 255, 0, 0);
			base.AddElementFieldInfo("MUserEntity", "CIdHakAkses", typeof(System.String), false, true, false, true,  (int)MUserFieldIndex.CIdHakAkses, 5, 0, 0);
		}
		/// <summary>Inits THistoryAlatEntity's FieldInfo objects</summary>
		private void InitTHistoryAlatEntityInfos()
		{
			base.AddElementFieldInfo("THistoryAlatEntity", "CUserId", typeof(System.String), false, false, false, true,  (int)THistoryAlatFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "DEntry", typeof(Nullable<System.DateTime>), true, false, false, true,  (int)THistoryAlatFieldIndex.DEntry, 0, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "CIdAlat", typeof(System.String), true, true, false, true,  (int)THistoryAlatFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "CNamaAlat", typeof(System.String), false, false, false, true,  (int)THistoryAlatFieldIndex.CNamaAlat, 100, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "CBatasToleransi", typeof(System.String), false, false, false, true,  (int)THistoryAlatFieldIndex.CBatasToleransi, 255, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "NInterval", typeof(Nullable<System.Int16>), false, false, false, true,  (int)THistoryAlatFieldIndex.NInterval, 0, 0, 5);
			base.AddElementFieldInfo("THistoryAlatEntity", "NIntervalEks", typeof(Nullable<System.Int32>), false, false, false, true,  (int)THistoryAlatFieldIndex.NIntervalEks, 0, 0, 10);
			base.AddElementFieldInfo("THistoryAlatEntity", "LJkInternal", typeof(System.Boolean), false, false, false, false,  (int)THistoryAlatFieldIndex.LJkInternal, 2, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "LJkEksternal", typeof(System.Boolean), false, false, false, false,  (int)THistoryAlatFieldIndex.LJkEksternal, 2, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "LStatusAlat", typeof(System.Boolean), false, false, false, false,  (int)THistoryAlatFieldIndex.LStatusAlat, 2, 0, 0);
			base.AddElementFieldInfo("THistoryAlatEntity", "CKeterangan", typeof(System.String), false, false, false, true,  (int)THistoryAlatFieldIndex.CKeterangan, 255, 0, 0);
		}
		/// <summary>Inits THistoryJadwalEntity's FieldInfo objects</summary>
		private void InitTHistoryJadwalEntityInfos()
		{
			base.AddElementFieldInfo("THistoryJadwalEntity", "CUserId", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "DEntry", typeof(Nullable<System.DateTime>), true, false, false, true,  (int)THistoryJadwalFieldIndex.DEntry, 0, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "CPeriode", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CPeriode, 6, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "CIdAlat", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "CIdDept", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CIdDept, 5, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "CIdLokasi", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CIdLokasi, 20, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "DPlan", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)THistoryJadwalFieldIndex.DPlan, 0, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "DRealisation", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)THistoryJadwalFieldIndex.DRealisation, 0, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "CPic", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("THistoryJadwalEntity", "MKeterangan", typeof(System.String), false, false, false, true,  (int)THistoryJadwalFieldIndex.MKeterangan, 536870911, 0, 0);
		}
		/// <summary>Inits TJadwalEntity's FieldInfo objects</summary>
		private void InitTJadwalEntityInfos()
		{
			base.AddElementFieldInfo("TJadwalEntity", "CUserId", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.CUserId, 10, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "DEntry", typeof(Nullable<System.DateTime>), true, true, false, true,  (int)TJadwalFieldIndex.DEntry, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CPeriode", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.CPeriode, 6, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CIdAlat", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CIdDept", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.CIdDept, 5, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CIdLokasi", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.CIdLokasi, 20, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "DPlan", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.DPlan, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "DRealisation", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.DRealisation, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CPic", typeof(System.String), false, true, false, true,  (int)TJadwalFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "DConfirmRencana", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.DConfirmRencana, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CConfirmRencana", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.CConfirmRencana, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "DConfirmRealisation", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.DConfirmRealisation, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "CConfirmRealisation", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TJadwalFieldIndex.CConfirmRealisation, 0, 0, 0);
			base.AddElementFieldInfo("TJadwalEntity", "MKeterangan", typeof(System.String), false, false, false, true,  (int)TJadwalFieldIndex.MKeterangan, 536870911, 0, 0);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitQDaftarIndukTypedViewInfos()
		{
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CIdAlat", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CNamaAlat", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CNamaAlat, 100, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CBatasToleransi", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CBatasToleransi, 255, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CNamaDept", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CNamaDept, 30, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "NInterval", typeof(System.Int16), false, false, true, false, (int)QDaftarIndukFieldIndex.NInterval, 0, 0, 5);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CNamaLokasi", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CNamaLokasi, 50, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "JenisKalibrasi", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.JenisKalibrasi, 255, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "CPic", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("QDaftarIndukTypedView", "MKeterangan", typeof(System.String), false, false, true, false, (int)QDaftarIndukFieldIndex.MKeterangan, 536870911, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitQMjadwalTypedViewInfos()
		{
			base.AddElementFieldInfo("QMjadwalTypedView", "CIdAlat", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("QMjadwalTypedView", "CIdLokasi", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.CIdLokasi, 20, 0, 0);
			base.AddElementFieldInfo("QMjadwalTypedView", "CNamaLokasi", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.CNamaLokasi, 50, 0, 0);
			base.AddElementFieldInfo("QMjadwalTypedView", "CNamaDept", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.CNamaDept, 30, 0, 0);
			base.AddElementFieldInfo("QMjadwalTypedView", "CPic", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("QMjadwalTypedView", "MKeterangan", typeof(System.String), false, false, true, false, (int)QMjadwalFieldIndex.MKeterangan, 536870911, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitQTjadwalKalibrasiTypedViewInfos()
		{
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "CIdAlat", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "CNamaAlat", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.CNamaAlat, 100, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "CNamaDept", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.CNamaDept, 30, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "CNamaLokasi", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.CNamaLokasi, 50, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "DPlan", typeof(System.DateTime), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.DPlan, 0, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "DConfirmRencana", typeof(System.DateTime), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.DConfirmRencana, 0, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "DRealisation", typeof(System.DateTime), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.DRealisation, 0, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "CPic", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "MKeterangan", typeof(System.String), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.MKeterangan, 536870911, 0, 0);
			base.AddElementFieldInfo("QTjadwalKalibrasiTypedView", "NInterval", typeof(System.Int16), false, false, true, false, (int)QTjadwalKalibrasiFieldIndex.NInterval, 0, 0, 5);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitQTreminderTypedViewInfos()
		{
			base.AddElementFieldInfo("QTreminderTypedView", "CIdAlat", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CIdAlat, 20, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "CNamaAlat", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CNamaAlat, 100, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "CNamaDept", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CNamaDept, 30, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "CNamaLokasi", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CNamaLokasi, 50, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "DPlan", typeof(System.DateTime), false, false, true, false, (int)QTreminderFieldIndex.DPlan, 0, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "DConfirmRencana", typeof(System.DateTime), false, false, true, false, (int)QTreminderFieldIndex.DConfirmRencana, 0, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "DRealisation", typeof(System.DateTime), false, false, true, false, (int)QTreminderFieldIndex.DRealisation, 0, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "CPic", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CPic, 100, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "MKeterangan", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.MKeterangan, 536870911, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "NInterval", typeof(System.Int16), false, false, true, false, (int)QTreminderFieldIndex.NInterval, 0, 0, 5);
			base.AddElementFieldInfo("QTreminderTypedView", "CPeriode", typeof(System.String), false, false, true, false, (int)QTreminderFieldIndex.CPeriode, 6, 0, 0);
			base.AddElementFieldInfo("QTreminderTypedView", "Bulan", typeof(System.Int16), false, false, true, false, (int)QTreminderFieldIndex.Bulan, 0, 0, 5);
			base.AddElementFieldInfo("QTreminderTypedView", "Tahun", typeof(System.Int16), false, false, true, false, (int)QTreminderFieldIndex.Tahun, 0, 0, 5);
		}		
	}
}




