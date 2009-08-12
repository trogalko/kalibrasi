///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: Friday, August 07, 2009 1:24:37 PM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace Kalibrasi.Data
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MAlat.
	/// </summary>
	public enum MAlatFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>DEntry. </summary>
		DEntry,
		///<summary>CIdAlat. </summary>
		CIdAlat,
		///<summary>CNamaAlat. </summary>
		CNamaAlat,
		///<summary>CBatasToleransi. </summary>
		CBatasToleransi,
		///<summary>NInterval. </summary>
		NInterval,
		///<summary>NIntervalEks. </summary>
		NIntervalEks,
		///<summary>LJkInternal. </summary>
		LJkInternal,
		///<summary>LJkEksternal. </summary>
		LJkEksternal,
		///<summary>LStatusAlat. </summary>
		LStatusAlat,
		///<summary>CKeterangan. </summary>
		CKeterangan,
		///<summary>DConfirm. </summary>
		DConfirm,
		///<summary>CConfirm. </summary>
		CConfirm,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MDepartement.
	/// </summary>
	public enum MDepartementFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>CIdDept. </summary>
		CIdDept,
		///<summary>CNamaDept. </summary>
		CNamaDept,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MHakAkses.
	/// </summary>
	public enum MHakAksesFieldIndex:int
	{
		///<summary>CIdHakAkses. </summary>
		CIdHakAkses,
		///<summary>CHakAkses. </summary>
		CHakAkses,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MLokasi.
	/// </summary>
	public enum MLokasiFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>CIdLokasi. </summary>
		CIdLokasi,
		///<summary>CIdDept. </summary>
		CIdDept,
		///<summary>CNamaLokasi. </summary>
		CNamaLokasi,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MPic.
	/// </summary>
	public enum MPicFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>DEntry. </summary>
		DEntry,
		///<summary>CPic. </summary>
		CPic,
		///<summary>MAlamat. </summary>
		MAlamat,
		///<summary>CNoTelp. </summary>
		CNoTelp,
		///<summary>CFax. </summary>
		CFax,
		///<summary>CEmail. </summary>
		CEmail,
		///<summary>CCperson. </summary>
		CCperson,
		///<summary>MNotes. </summary>
		MNotes,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: MUser.
	/// </summary>
	public enum MUserFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>CPassword. </summary>
		CPassword,
		///<summary>CIdHakAkses. </summary>
		CIdHakAkses,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: THistoryAlat.
	/// </summary>
	public enum THistoryAlatFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>DEntry. </summary>
		DEntry,
		///<summary>CIdAlat. </summary>
		CIdAlat,
		///<summary>CNamaAlat. </summary>
		CNamaAlat,
		///<summary>CBatasToleransi. </summary>
		CBatasToleransi,
		///<summary>NInterval. </summary>
		NInterval,
		///<summary>NIntervalEks. </summary>
		NIntervalEks,
		///<summary>LJkInternal. </summary>
		LJkInternal,
		///<summary>LJkEksternal. </summary>
		LJkEksternal,
		///<summary>LStatusAlat. </summary>
		LStatusAlat,
		///<summary>CKeterangan. </summary>
		CKeterangan,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: THistoryJadwal.
	/// </summary>
	public enum THistoryJadwalFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>DEntry. </summary>
		DEntry,
		///<summary>CPeriode. </summary>
		CPeriode,
		///<summary>CIdAlat. </summary>
		CIdAlat,
		///<summary>CIdDept. </summary>
		CIdDept,
		///<summary>CIdLokasi. </summary>
		CIdLokasi,
		///<summary>DPlan. </summary>
		DPlan,
		///<summary>DRealisation. </summary>
		DRealisation,
		///<summary>CPic. </summary>
		CPic,
		///<summary>MKeterangan. </summary>
		MKeterangan,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TJadwal.
	/// </summary>
	public enum TJadwalFieldIndex:int
	{
		///<summary>CUserId. </summary>
		CUserId,
		///<summary>DEntry. </summary>
		DEntry,
		///<summary>CPeriode. </summary>
		CPeriode,
		///<summary>CIdAlat. </summary>
		CIdAlat,
		///<summary>CIdDept. </summary>
		CIdDept,
		///<summary>CIdLokasi. </summary>
		CIdLokasi,
		///<summary>DPlan. </summary>
		DPlan,
		///<summary>DRealisation. </summary>
		DRealisation,
		///<summary>CPic. </summary>
		CPic,
		///<summary>DConfirmRencana. </summary>
		DConfirmRencana,
		///<summary>CConfirmRencana. </summary>
		CConfirmRencana,
		///<summary>DConfirmRealisation. </summary>
		DConfirmRealisation,
		///<summary>CConfirmRealisation. </summary>
		CConfirmRealisation,
		///<summary>MKeterangan. </summary>
		MKeterangan,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : QDaftarInduk.
	/// </summary>
	public enum QDaftarIndukFieldIndex:int
	{
		///<summary>CIdAlat</summary>
		CIdAlat,
		///<summary>CNamaAlat</summary>
		CNamaAlat,
		///<summary>CBatasToleransi</summary>
		CBatasToleransi,
		///<summary>CNamaDept</summary>
		CNamaDept,
		///<summary>NInterval</summary>
		NInterval,
		///<summary>CNamaLokasi</summary>
		CNamaLokasi,
		///<summary>JenisKalibrasi</summary>
		JenisKalibrasi,
		///<summary>CPic</summary>
		CPic,
		///<summary>MKeterangan</summary>
		MKeterangan,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : QMjadwal.
	/// </summary>
	public enum QMjadwalFieldIndex:int
	{
		///<summary>CIdAlat</summary>
		CIdAlat,
		///<summary>CIdLokasi</summary>
		CIdLokasi,
		///<summary>CNamaLokasi</summary>
		CNamaLokasi,
		///<summary>CNamaDept</summary>
		CNamaDept,
		///<summary>CPic</summary>
		CPic,
		///<summary>MKeterangan</summary>
		MKeterangan,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : QTjadwalKalibrasi.
	/// </summary>
	public enum QTjadwalKalibrasiFieldIndex:int
	{
		///<summary>CIdAlat</summary>
		CIdAlat,
		///<summary>CNamaAlat</summary>
		CNamaAlat,
		///<summary>CNamaDept</summary>
		CNamaDept,
		///<summary>CNamaLokasi</summary>
		CNamaLokasi,
		///<summary>DPlan</summary>
		DPlan,
		///<summary>DConfirmRencana</summary>
		DConfirmRencana,
		///<summary>DRealisation</summary>
		DRealisation,
		///<summary>CPic</summary>
		CPic,
		///<summary>MKeterangan</summary>
		MKeterangan,
		///<summary>NInterval</summary>
		NInterval,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : QTreminder.
	/// </summary>
	public enum QTreminderFieldIndex:int
	{
		///<summary>CIdAlat</summary>
		CIdAlat,
		///<summary>CNamaAlat</summary>
		CNamaAlat,
		///<summary>CNamaDept</summary>
		CNamaDept,
		///<summary>CNamaLokasi</summary>
		CNamaLokasi,
		///<summary>DPlan</summary>
		DPlan,
		///<summary>DConfirmRencana</summary>
		DConfirmRencana,
		///<summary>DRealisation</summary>
		DRealisation,
		///<summary>CPic</summary>
		CPic,
		///<summary>MKeterangan</summary>
		MKeterangan,
		///<summary>NInterval</summary>
		NInterval,
		///<summary>CPeriode</summary>
		CPeriode,
		///<summary>Bulan</summary>
		Bulan,
		///<summary>Tahun</summary>
		Tahun,
		/// <summary></summary>
		AmountOfFields
	}




	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		///<summary>MAlat</summary>
		MAlatEntity,
		///<summary>MDepartement</summary>
		MDepartementEntity,
		///<summary>MHakAkses</summary>
		MHakAksesEntity,
		///<summary>MLokasi</summary>
		MLokasiEntity,
		///<summary>MPic</summary>
		MPicEntity,
		///<summary>MUser</summary>
		MUserEntity,
		///<summary>THistoryAlat</summary>
		THistoryAlatEntity,
		///<summary>THistoryJadwal</summary>
		THistoryJadwalEntity,
		///<summary>TJadwal</summary>
		TJadwalEntity
	}



	/// <summary>
	/// Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum TypedViewType:int
	{
		///<summary>QDaftarInduk</summary>
		QDaftarIndukTypedView,
		///<summary>QMjadwal</summary>
		QMjadwalTypedView,
		///<summary>QTjadwalKalibrasi</summary>
		QTjadwalKalibrasiTypedView,
		///<summary>QTreminder</summary>
		QTreminderTypedView
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	#endregion

	#region Included code

	#endregion
}


