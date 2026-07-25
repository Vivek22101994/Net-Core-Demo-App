using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntTbEstate
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public int? PidSeasonGroup { get; set; }

    public int? PidResidence { get; set; }

    public string? Category { get; set; }

    public int? PidType { get; set; }

    public int? PidCategory { get; set; }

    public int? PidOwner { get; set; }

    public int? PidAgent { get; set; }

    public int? PidCity { get; set; }

    public int? PidZone { get; set; }

    public int BaseAvailability { get; set; }

    public string? ComplexType { get; set; }

    public int ComplexId { get; set; }

    public string? ManagerType { get; set; }

    public int? ManagerId { get; set; }

    public string? LocZipCode { get; set; }

    public string? LocAddress { get; set; }

    public string? LocInnerBell { get; set; }

    public string? LocReferer { get; set; }

    public string? LocPhone1 { get; set; }

    public string? LocPhone2 { get; set; }

    public decimal? MqInner { get; set; }

    public decimal? MqOuter { get; set; }

    public decimal? MqTerrace { get; set; }

    public int? OnFloor { get; set; }

    public int? OnFloorOfTotal { get; set; }

    public int? OnLevels { get; set; }

    public int? NumBedSingle { get; set; }

    public int? NumBedDouble { get; set; }

    public int? NumBedDoubleDivisible { get; set; }

    public int? NumBedDouble2level { get; set; }

    public int? NumSofaSingle { get; set; }

    public int? NumSofaDouble { get; set; }

    public int? NumPersonsAdult { get; set; }

    public int? NumPersonsChild { get; set; }

    public int? NumPersonsOptional { get; set; }

    public int? NumPersonsMin { get; set; }

    public int? NumPersonsMax { get; set; }

    public int? NumPetsMax { get; set; }

    public int? NumRoomsBed { get; set; }

    public int? NumRoomsBath { get; set; }

    public int? NumRoomsTotal { get; set; }

    public int? NumTerraces { get; set; }

    public int? NumParkingOpen { get; set; }

    public int? NumParkingClosed { get; set; }

    public string? EcoExtNameFull { get; set; }

    public string? EcoExtEmail { get; set; }

    public string? EcoExtPhone { get; set; }

    public decimal? EcoExtPrice { get; set; }

    public int? EcoExtPayInDays { get; set; }

    public int? EcoExtClientPay { get; set; }

    public string? SrsExtNameFull { get; set; }

    public string? SrsExtEmail { get; set; }

    public string? SrsExtPhone { get; set; }

    public string? SrsExtPhone2 { get; set; }

    public string? SrsExtPhone3 { get; set; }

    public string? SrsExtPhone4 { get; set; }

    public decimal? SrsExtPrice { get; set; }

    public int? SrsExtClientPay { get; set; }

    public string? SrsExtMeetingPoint { get; set; }

    public int? PrTableViewType { get; set; }

    public DateTime? PrStartDate { get; set; }

    public int? PrPercentage { get; set; }

    public decimal? PrDeposit { get; set; }

    public int? PrDepositWithCard { get; set; }

    public int? PrHasOvernightTax { get; set; }

    public int? ExtOwnerdaysinyear { get; set; }

    public int? LmInhours { get; set; }

    public int? LmDiscount { get; set; }

    public int? LmNightsMin { get; set; }

    public int? LmNightsMax { get; set; }

    public int? LpbIs { get; set; }

    public int? LpbNightsMin { get; set; }

    public int? LpbAfterdays { get; set; }

    public int? LpbOnlyhighseason { get; set; }

    public int? NightsMinVhseason { get; set; }

    public int? NightsMin { get; set; }

    public int? NightsMax { get; set; }

    public int? LongTermRent { get; set; }

    public decimal? LongTermPrMonthly { get; set; }

    public int? Importance { get; set; }

    public int? ImportanceVote { get; set; }

    public string? ImportanceCategory { get; set; }

    public string? MediaFolder { get; set; }

    public string? MediaFolderOriginalPhotos { get; set; }

    public string? ImgThumb { get; set; }

    public string? ImgPreview1 { get; set; }

    public string? ImgPreview2 { get; set; }

    public string? ImgPreview3 { get; set; }

    public string? ImgBanner { get; set; }

    public string? InnerNotes { get; set; }

    public decimal? SvYaw { get; set; }

    public decimal? SvPitch { get; set; }

    public decimal? SvZoom { get; set; }

    public string? SvCoords { get; set; }

    public int? IsStreetView { get; set; }

    public string? GoogleMaps { get; set; }

    public int? IsGoogleMaps { get; set; }

    public int? IsLoft { get; set; }

    public int? IsExclusive { get; set; }

    public int? IsSrs { get; set; }

    public int? IsEcopulizie { get; set; }

    public int? IsOnlineBooking { get; set; }

    public int IsActive { get; set; }

    public int IsDeleted { get; set; }

    public int Sequence { get; set; }

    public int? ExtGpsId { get; set; }

    public int? ExtGpsPidMaga { get; set; }

    public int? InAttention { get; set; }

    public int? OwnerContractDurationMonths { get; set; }

    public DateTime? OwnerContractDate { get; set; }

    public string? OwnerContractPlace { get; set; }

    public int? OwnerContractType { get; set; }

    public int? OwnerContractHasWelcomeService { get; set; }

    public int? OwnerContractHasFinalCleaning { get; set; }

    public decimal? OwnerContractPriceCommission { get; set; }

    public int? OwnerContractPriceCommissionOnNet { get; set; }

    public decimal? OwnerContractPriceMonthlyCost { get; set; }

    public decimal? OwnerContractPriceDaily { get; set; }

    public decimal? OwnerContractPriceMonthlyFee { get; set; }

    public string? OwnerContractContent { get; set; }

    public decimal? PrAgencyFee { get; set; }

    public int? IsHomeaway { get; set; }

    public string? BcomHotelId { get; set; }

    public string? BcomRoomId { get; set; }

    public int? BcomEnabled { get; set; }

    public string? BcomName { get; set; }

    public int? OwnerContractHasBiancheria { get; set; }

    public string? ICalUrl { get; set; }

    public string? ChnlMsourceId { get; set; }

    public string? ChnlMpropertyId { get; set; }

    public string? ChnlMpropertyName { get; set; }

    public int? PriceVersion { get; set; }

    public int? NumCabinets { get; set; }

    public int? NumDiningRoom { get; set; }

    public int? NumSalon { get; set; }

    public int? NumKitchen { get; set; }

    public long? PidKitchentype { get; set; }

    public int? NumSwimmingMc { get; set; }

    public byte? IsSwimmingExclusive { get; set; }

    public int? NumTripleRoom { get; set; }

    public int? NumRoomBed120 { get; set; }

    public int? NumRoomBed140 { get; set; }

    public int? NumCompleteShower { get; set; }

    public int? NumCompleteBath { get; set; }

    public int? NumServiceIncomplete { get; set; }

    public int? NumOutsideArea { get; set; }

    public string? FeatureNote { get; set; }

    public string? OptionsNote { get; set; }

    public int? OlDbId { get; set; }

    public int? MqOuterCovered { get; set; }

    public int? PidMacroarea { get; set; }

    public int? PidCountry { get; set; }

    public int? PidRegion { get; set; }

    public int? IsHavingDependence { get; set; }

    public int? NumRoomsLiving { get; set; }

    public int? IsApt { get; set; }

    public string? DefCheckIn { get; set; }

    public string? DefCheckOut { get; set; }

    public DateTime? OwnerContractStartDate { get; set; }

    public DateTime? OwnerContractExpiryDate { get; set; }

    public int? HasPool { get; set; }

    public int? OwnerContractOwnerPriceCalculatedOn { get; set; }

    public bool? IsPercentage { get; set; }

    public decimal? PrDepositMax { get; set; }

    public int? PrDepositDaysToCheck { get; set; }

    public int? TripadvisorRating { get; set; }

    public string? Fax { get; set; }

    public string? Email1 { get; set; }

    public string? Email2 { get; set; }

    public int? PidStyle { get; set; }

    public int? PidSetting { get; set; }

    public int? IsPropertyFromOwner { get; set; }

    public string? PoliceRegId { get; set; }

    public string? FloorUs { get; set; }

    public DateTime? DtCreation { get; set; }

    public string? RegistrationNumber { get; set; }

    public int? SqFeet { get; set; }

    public int? IsPriceVisible { get; set; }

    public string? OwnerContractFile { get; set; }

    public int? IsBroomUpdate { get; set; }

    public decimal? BasePrice { get; set; }

    public int? IsAirbnbImported { get; set; }

    public decimal? ChangeAmount { get; set; }

    public int? ChangeIsPercentage { get; set; }

    public int? ChangeIsDiscount { get; set; }

    public int? CompanyId { get; set; }

    public Guid? UniqueId { get; set; }

    public int? ProjectId { get; set; }

    public int? Ispms { get; set; }

    public int? IsSingleRoom { get; set; }

    public string? SignleRoomName { get; set; }

    public int? MinResDays { get; set; }

    public int? MinResHours { get; set; }
}
