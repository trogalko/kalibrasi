///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:46 PM
// Code is generated using templates: SD.TemplateBindings.AccessSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data.OleDb;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Kalibrasi.Data.HelperClasses
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((9 + 4));
			InitMAlatEntityMappings();
			InitMDepartementEntityMappings();
			InitMHakAksesEntityMappings();
			InitMLokasiEntityMappings();
			InitMPicEntityMappings();
			InitMUserEntityMappings();
			InitTHistoryAlatEntityMappings();
			InitTHistoryJadwalEntityMappings();
			InitTJadwalEntityMappings();
			InitQDaftarIndukTypedViewMappings();
			InitQMjadwalTypedViewMappings();
			InitQTjadwalKalibrasiTypedViewMappings();
			InitQTreminderTypedViewMappings();
		}


		/// <summary>Inits MAlatEntity's mappings</summary>
		private void InitMAlatEntityMappings()
		{
			base.AddElementMapping( "MAlatEntity", "Kalibrasi", @"Default", "M_Alat", 13 );
			base.AddElementFieldMapping( "MAlatEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MAlatEntity", "DEntry", "D_Entry", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "MAlatEntity", "CIdAlat", "C_IdAlat", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MAlatEntity", "CNamaAlat", "C_NamaAlat", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "MAlatEntity", "CBatasToleransi", "C_BatasToleransi", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "MAlatEntity", "NInterval", "N_Interval", true, (int)OleDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			base.AddElementFieldMapping( "MAlatEntity", "NIntervalEks", "N_IntervalEks", true, (int)OleDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 6 );
			base.AddElementFieldMapping( "MAlatEntity", "LJkInternal", "L_JkInternal", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			base.AddElementFieldMapping( "MAlatEntity", "LJkEksternal", "L_JkEksternal", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			base.AddElementFieldMapping( "MAlatEntity", "LStatusAlat", "L_StatusAlat", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "MAlatEntity", "CKeterangan", "C_Keterangan", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "MAlatEntity", "DConfirm", "D_Confirm", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "MAlatEntity", "CConfirm", "C_Confirm", true, (int)OleDbType.VarWChar, 15, 0, 0, false, "", null, typeof(System.String), 12 );
		}
		/// <summary>Inits MDepartementEntity's mappings</summary>
		private void InitMDepartementEntityMappings()
		{
			base.AddElementMapping( "MDepartementEntity", "Kalibrasi", @"Default", "M_Departement", 3 );
			base.AddElementFieldMapping( "MDepartementEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MDepartementEntity", "CIdDept", "C_IdDept", true, (int)OleDbType.VarWChar, 5, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MDepartementEntity", "CNamaDept", "C_NamaDept", true, (int)OleDbType.VarWChar, 30, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits MHakAksesEntity's mappings</summary>
		private void InitMHakAksesEntityMappings()
		{
			base.AddElementMapping( "MHakAksesEntity", "Kalibrasi", @"Default", "M_HakAkses", 2 );
			base.AddElementFieldMapping( "MHakAksesEntity", "CIdHakAkses", "C_IdHakAkses", true, (int)OleDbType.VarWChar, 5, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MHakAksesEntity", "CHakAkses", "C_HakAkses", true, (int)OleDbType.VarWChar, 15, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits MLokasiEntity's mappings</summary>
		private void InitMLokasiEntityMappings()
		{
			base.AddElementMapping( "MLokasiEntity", "Kalibrasi", @"Default", "M_Lokasi", 4 );
			base.AddElementFieldMapping( "MLokasiEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MLokasiEntity", "CIdLokasi", "C_IdLokasi", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MLokasiEntity", "CIdDept", "C_IdDept", true, (int)OleDbType.VarWChar, 15, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MLokasiEntity", "CNamaLokasi", "C_NamaLokasi", true, (int)OleDbType.VarWChar, 50, 0, 0, false, "", null, typeof(System.String), 3 );
		}
		/// <summary>Inits MPicEntity's mappings</summary>
		private void InitMPicEntityMappings()
		{
			base.AddElementMapping( "MPicEntity", "Kalibrasi", @"Default", "M_PIC", 9 );
			base.AddElementFieldMapping( "MPicEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MPicEntity", "DEntry", "D_Entry", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "MPicEntity", "CPic", "C_PIC", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "MPicEntity", "MAlamat", "M_Alamat", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "MPicEntity", "CNoTelp", "C_NoTelp", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "MPicEntity", "CFax", "C_Fax", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "MPicEntity", "CEmail", "C_Email", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "MPicEntity", "CCperson", "C_CPerson", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "MPicEntity", "MNotes", "M_Notes", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String), 8 );
		}
		/// <summary>Inits MUserEntity's mappings</summary>
		private void InitMUserEntityMappings()
		{
			base.AddElementMapping( "MUserEntity", "Kalibrasi", @"Default", "M_User", 3 );
			base.AddElementFieldMapping( "MUserEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "MUserEntity", "CPassword", "C_Password", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "MUserEntity", "CIdHakAkses", "C_IdHakAkses", true, (int)OleDbType.VarWChar, 5, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits THistoryAlatEntity's mappings</summary>
		private void InitTHistoryAlatEntityMappings()
		{
			base.AddElementMapping( "THistoryAlatEntity", "Kalibrasi", @"Default", "T_HistoryAlat", 11 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "DEntry", "D_Entry", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "CIdAlat", "C_IdAlat", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "CNamaAlat", "C_NamaAlat", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "CBatasToleransi", "C_BatasToleransi", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "NInterval", "N_Interval", true, (int)OleDbType.SmallInt, 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "NIntervalEks", "N_IntervalEks", true, (int)OleDbType.Integer, 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "LJkInternal", "L_JkInternal", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 7 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "LJkEksternal", "L_JkEksternal", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 8 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "LStatusAlat", "L_StatusAlat", false, (int)OleDbType.Boolean, 2, 0, 0, false, "", null, typeof(System.Boolean), 9 );
			base.AddElementFieldMapping( "THistoryAlatEntity", "CKeterangan", "C_Keterangan", true, (int)OleDbType.VarWChar, 255, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits THistoryJadwalEntity's mappings</summary>
		private void InitTHistoryJadwalEntityMappings()
		{
			base.AddElementMapping( "THistoryJadwalEntity", "Kalibrasi", @"Default", "T_HistoryJadwal", 10 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "DEntry", "D_Entry", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CPeriode", "C_Periode", true, (int)OleDbType.VarWChar, 6, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CIdAlat", "C_IdAlat", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CIdDept", "C_IdDept", true, (int)OleDbType.VarWChar, 5, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CIdLokasi", "C_IdLokasi", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "DPlan", "D_Plan", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "DRealisation", "D_Realisation", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "CPic", "C_PIC", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "THistoryJadwalEntity", "MKeterangan", "M_Keterangan", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String), 9 );
		}
		/// <summary>Inits TJadwalEntity's mappings</summary>
		private void InitTJadwalEntityMappings()
		{
			base.AddElementMapping( "TJadwalEntity", "Kalibrasi", @"Default", "T_Jadwal", 14 );
			base.AddElementFieldMapping( "TJadwalEntity", "CUserId", "C_UserId", true, (int)OleDbType.VarWChar, 10, 0, 0, false, "", null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "TJadwalEntity", "DEntry", "D_Entry", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			base.AddElementFieldMapping( "TJadwalEntity", "CPeriode", "C_Periode", true, (int)OleDbType.VarWChar, 6, 0, 0, false, "", null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "TJadwalEntity", "CIdAlat", "C_IdAlat", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "TJadwalEntity", "CIdDept", "C_IdDept", true, (int)OleDbType.VarWChar, 5, 0, 0, false, "", null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "TJadwalEntity", "CIdLokasi", "C_IdLokasi", true, (int)OleDbType.VarWChar, 20, 0, 0, false, "", null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "TJadwalEntity", "DPlan", "D_Plan", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "TJadwalEntity", "DRealisation", "D_Realisation", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			base.AddElementFieldMapping( "TJadwalEntity", "CPic", "C_PIC", true, (int)OleDbType.VarWChar, 100, 0, 0, false, "", null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "TJadwalEntity", "DConfirmRencana", "D_ConfirmRencana", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 9 );
			base.AddElementFieldMapping( "TJadwalEntity", "CConfirmRencana", "C_ConfirmRencana", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			base.AddElementFieldMapping( "TJadwalEntity", "DConfirmRealisation", "D_ConfirmRealisation", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 11 );
			base.AddElementFieldMapping( "TJadwalEntity", "CConfirmRealisation", "C_ConfirmRealisation", true, (int)OleDbType.Date, 0, 0, 0, false, "", null, typeof(System.DateTime), 12 );
			base.AddElementFieldMapping( "TJadwalEntity", "MKeterangan", "M_Keterangan", true, (int)OleDbType.LongVarWChar, 536870911, 0, 0, false, "", null, typeof(System.String), 13 );
		}

		/// <summary>Inits View's mappings</summary>
		private void InitQDaftarIndukTypedViewMappings()
		{
			base.AddElementMapping( "QDaftarIndukTypedView", "Kalibrasi", @"Default", "qDaftarInduk", 9 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CIdAlat", "C_IdAlat", false, (int)OleDbType.VarWChar, 20, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CNamaAlat", "C_NamaAlat", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CBatasToleransi", "C_BatasToleransi", false, (int)OleDbType.VarWChar, 255, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CNamaDept", "C_NamaDept", false, (int)OleDbType.VarWChar, 30, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "NInterval", "N_Interval", false, (int)OleDbType.SmallInt, 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 4 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CNamaLokasi", "C_NamaLokasi", false, (int)OleDbType.VarWChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "JenisKalibrasi", "JenisKalibrasi", false, (int)OleDbType.VarWChar, 255, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "CPic", "C_PIC", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "QDaftarIndukTypedView", "MKeterangan", "M_Keterangan", false, (int)OleDbType.LongVarWChar, 536870911, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitQMjadwalTypedViewMappings()
		{
			base.AddElementMapping( "QMjadwalTypedView", "Kalibrasi", @"Default", "qMJadwal", 6 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "CIdAlat", "C_IdAlat", false, (int)OleDbType.VarWChar, 20, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "CIdLokasi", "C_IdLokasi", false, (int)OleDbType.VarWChar, 20, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "CNamaLokasi", "C_NamaLokasi", false, (int)OleDbType.VarWChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "CNamaDept", "C_NamaDept", false, (int)OleDbType.VarWChar, 30, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "CPic", "C_PIC", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			base.AddElementFieldMapping( "QMjadwalTypedView", "MKeterangan", "M_Keterangan", false, (int)OleDbType.LongVarWChar, 536870911, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitQTjadwalKalibrasiTypedViewMappings()
		{
			base.AddElementMapping( "QTjadwalKalibrasiTypedView", "Kalibrasi", @"Default", "Q_TJadwalKalibrasi", 10 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "CIdAlat", "C_IdAlat", false, (int)OleDbType.VarWChar, 20, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "CNamaAlat", "C_NamaAlat", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "CNamaDept", "C_NamaDept", false, (int)OleDbType.VarWChar, 30, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "CNamaLokasi", "C_NamaLokasi", false, (int)OleDbType.VarWChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "DPlan", "D_Plan", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "DConfirmRencana", "D_ConfirmRencana", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "DRealisation", "D_Realisation", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "CPic", "C_PIC", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "MKeterangan", "M_Keterangan", false, (int)OleDbType.LongVarWChar, 536870911, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "QTjadwalKalibrasiTypedView", "NInterval", "N_Interval", false, (int)OleDbType.SmallInt, 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 9 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitQTreminderTypedViewMappings()
		{
			base.AddElementMapping( "QTreminderTypedView", "Kalibrasi", @"Default", "Q_TReminder", 13 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CIdAlat", "C_IdAlat", false, (int)OleDbType.VarWChar, 20, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CNamaAlat", "C_NamaAlat", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CNamaDept", "C_NamaDept", false, (int)OleDbType.VarWChar, 30, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CNamaLokasi", "C_NamaLokasi", false, (int)OleDbType.VarWChar, 50, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			base.AddElementFieldMapping( "QTreminderTypedView", "DPlan", "D_Plan", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 4 );
			base.AddElementFieldMapping( "QTreminderTypedView", "DConfirmRencana", "D_ConfirmRencana", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 5 );
			base.AddElementFieldMapping( "QTreminderTypedView", "DRealisation", "D_Realisation", false, (int)OleDbType.Date, 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 6 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CPic", "C_PIC", false, (int)OleDbType.VarWChar, 100, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			base.AddElementFieldMapping( "QTreminderTypedView", "MKeterangan", "M_Keterangan", false, (int)OleDbType.LongVarWChar, 536870911, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
			base.AddElementFieldMapping( "QTreminderTypedView", "NInterval", "N_Interval", false, (int)OleDbType.SmallInt, 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 9 );
			base.AddElementFieldMapping( "QTreminderTypedView", "CPeriode", "C_Periode", false, (int)OleDbType.VarWChar, 6, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			base.AddElementFieldMapping( "QTreminderTypedView", "Bulan", "Bulan", false, (int)OleDbType.SmallInt, 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 11 );
			base.AddElementFieldMapping( "QTreminderTypedView", "Tahun", "Tahun", false, (int)OleDbType.SmallInt, 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 12 );
		}
	}
}
