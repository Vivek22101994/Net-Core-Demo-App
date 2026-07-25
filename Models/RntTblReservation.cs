using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class RntTblReservation
{
    public long Id { get; set; }

    public Guid? UniqueId { get; set; }

    public Guid? Uid2 { get; set; }

    public string? Code { get; set; }

    public string? Password { get; set; }

    public int? PidRelatedRequest { get; set; }

    public int? PidCreator { get; set; }

    public int? PidOperator { get; set; }

    public DateTime? OperatorDate { get; set; }

    public int? PidEstate { get; set; }

    public int? PidEstateRoomNumber { get; set; }

    public int? PidEstateCity { get; set; }

    public int? ClId { get; set; }

    public int? ClPidDiscount { get; set; }

    public string? ClPidLang { get; set; }

    public string? ClEmail { get; set; }

    public string? ClNameHonorific { get; set; }

    public string? ClNameFull { get; set; }

    public string? ClLocCountry { get; set; }

    public int? ClIsCompleted { get; set; }

    public DateTime? ClReminderLast { get; set; }

    public DateTime? ClReminderNext { get; set; }

    public int? ClReminderCount { get; set; }

    public DateTime? ClReminderFullPaymentLast { get; set; }

    public int? ClReminderFullPaymentCount { get; set; }

    public int? ClReminderFullPaymentSent { get; set; }

    public string? ClBrowserInfo { get; set; }

    public string? ClBrowserIp { get; set; }

    public int? NumAdult { get; set; }

    public int? NumChildOver { get; set; }

    public int? NumChildMin { get; set; }

    public int? VisaIsRequested { get; set; }

    public int? VisaPersons { get; set; }

    public DateTime? DtStart { get; set; }

    public DateTime? DtEnd { get; set; }

    public DateTime? DtIn { get; set; }

    public DateTime? DtOut { get; set; }

    public string DtStartTime { get; set; } = null!;

    public string DtEndTime { get; set; } = null!;

    public int? IsDtStartTimeChanged { get; set; }

    public int? IsDtEndTimeChanged { get; set; }

    public long? LimoEasyShuttleId { get; set; }

    public string? LimoEasyShuttleInUid { get; set; }

    public string? LimoEasyShuttleOutUid { get; set; }

    public DateTime? LimoInDatetime { get; set; }

    public int? LimoInIsRequested { get; set; }

    public string? LimoInPointType { get; set; }

    public string? LimoInPointTransportType { get; set; }

    public int? LimoInPointPickupPlace { get; set; }

    public string? LimoInPointPickupPlaceName { get; set; }

    public string? LimoInPointDetails { get; set; }

    public int? LimoInPointDetailsType { get; set; }

    public DateTime? LimoOutDatetime { get; set; }

    public int? LimoOutIsRequested { get; set; }

    public string? LimoOutPointType { get; set; }

    public string? LimoOutPointTransportType { get; set; }

    public int? LimoOutPointPickupPlace { get; set; }

    public string? LimoOutPointPickupPlaceName { get; set; }

    public string? LimoOutPointDetails { get; set; }

    public int? LimoOutPointDetailsType { get; set; }

    public int? LimoNumCaseS { get; set; }

    public int? LimoNumCaseM { get; set; }

    public int? LimoNumCaseL { get; set; }

    public string? LimoRequest { get; set; }

    public int? LimoIsCompleted { get; set; }

    public int? StatePid { get; set; }

    public DateTime? StateDate { get; set; }

    public int? StatePidUser { get; set; }

    public string? StateSubject { get; set; }

    public string? StateBody { get; set; }

    public DateTime? DtCreation { get; set; }

    public string? NotesInner { get; set; }

    public string? NotesClient { get; set; }

    public string? NotesEco { get; set; }

    public DateTime? BlockExpire { get; set; }

    public int? BlockExpireHours { get; set; }

    public int? BlockPidUser { get; set; }

    public string? BlockComments { get; set; }

    public string? SrsExtMeetingPoint { get; set; }

    public int? RequestRenewal { get; set; }

    public DateTime? RequestRenewalDate { get; set; }

    public int? RequestFullPay { get; set; }

    public DateTime? RequestFullPayDate { get; set; }

    public int? RequestFullPayAccepted { get; set; }

    public DateTime? RequestFullPayAcceptedDate { get; set; }

    public int? IsDeleted { get; set; }

    public int? IsBooking { get; set; }

    public int? InvToCreate { get; set; }

    public int? BedSingle { get; set; }

    public int? BedDouble { get; set; }

    public int? BedDoubleD { get; set; }

    public int? BedDoubleDconfig { get; set; }

    public int? BedDouble2level { get; set; }

    public string? BedDouble2levelConfig { get; set; }

    public int? BedSofaSingle { get; set; }

    public int? BedSofaDouble { get; set; }

    public int? InvIsDifferent { get; set; }

    public string? InvNameHonorific { get; set; }

    public string? InvNameFull { get; set; }

    public string? InvLocCountry { get; set; }

    public string? InvLocState { get; set; }

    public string? InvLocCity { get; set; }

    public string? InvLocAddress { get; set; }

    public string? InvLocZipCode { get; set; }

    public string? InvDocVatNum { get; set; }

    public string? InvDocCfNum { get; set; }

    public int? ProblemId { get; set; }

    public string? ProblemDesc { get; set; }

    public long? AgentId { get; set; }

    public decimal? AgentCommissionPerc { get; set; }

    public decimal? AgentCommissionPrice { get; set; }

    public long? AgentClientId { get; set; }

    public decimal? PayedTotal { get; set; }

    public DateTime? PayedDate { get; set; }

    public int? PayedUser { get; set; }

    public string? PayedMode { get; set; }

    public decimal? PrDeposit { get; set; }

    public string? PrDepositNotes { get; set; }

    public int? PrDepositWithCard { get; set; }

    public decimal? PrTotal { get; set; }

    public decimal? PrDiscountOwner { get; set; }

    public decimal? PrDiscountCommission { get; set; }

    public string? PrDiscountDesc { get; set; }

    public int? PrDiscountUser { get; set; }

    public int? PrDiscountCustom { get; set; }

    public decimal? PrReservation { get; set; }

    public int? PrPartModified { get; set; }

    public string? PrPartModifyNotes { get; set; }

    public decimal? PrPartCommissionTf { get; set; }

    public decimal? PrPartCommissionTotal { get; set; }

    public decimal? PrPartAgencyFee { get; set; }

    public decimal? PrPartPaymentTotal { get; set; }

    public decimal? PrPartForPayment { get; set; }

    public decimal? PrPartOwner { get; set; }

    public decimal? PrCityTax { get; set; }

    public decimal? PrEcoPrice { get; set; }

    public decimal? PrEcoCount { get; set; }

    public decimal? PrSrsPrice { get; set; }

    public string? PrPaymentType { get; set; }

    public decimal? PrPartExtraServices { get; set; }

    public decimal? PrPartTax { get; set; }

    public decimal? PrTotalRate { get; set; }

    public decimal? PrTotalOwner { get; set; }

    public decimal? PrTotalCommission { get; set; }

    public decimal? PrTotalRateOnWeb { get; set; }

    public decimal? PrDiscountSpecialOffer { get; set; }

    public decimal? PrDiscountLongStay { get; set; }

    public string? PrDiscountLongStayDesc { get; set; }

    public decimal? PrDiscountLongRange { get; set; }

    public string? PrDiscountLongRangeDesc { get; set; }

    public decimal? PrDiscountLastMinute { get; set; }

    public string? PrDiscountLastMinuteDesc { get; set; }

    public decimal? PrOptioniExtra { get; set; }

    public decimal? PrPartOptioniExtra { get; set; }

    public decimal? PrOptioniFeeling { get; set; }

    public decimal? PrOptioniOwner { get; set; }

    public int? AgentCommissionNotInTotal { get; set; }

    public DateTime? PrTotalOwnerPayDate { get; set; }

    public int? PrTotalOwnerExported { get; set; }

    public DateTime? PrRefundDate { get; set; }

    public decimal? PrRefundTotal { get; set; }

    public string? PrRefundPayMode { get; set; }

    public string? BcomResId { get; set; }

    public string? BcomRoomResId { get; set; }

    public string? BcomLoyalityid { get; set; }

    public decimal? BcomCommissionamount { get; set; }

    public string? BcomCurrencycode { get; set; }

    public string? BcomExtrainfo { get; set; }

    public string? BcomFacilities { get; set; }

    public string? BcomInfo { get; set; }

    public string? BcomMealplan { get; set; }

    public string? BcomRateid { get; set; }

    public string? BcomSmoking { get; set; }

    public string? BcomNote { get; set; }

    public int? BcomCancel { get; set; }

    public decimal? BcomCancelcharge { get; set; }

    public string? BcomGuestName { get; set; }

    public string? BcomRoomRemarks { get; set; }

    public decimal? BcomRoomPrice { get; set; }

    public string? BcomStatus { get; set; }

    public string? BcomCountryCode { get; set; }

    public int? BcomPidParentBooking { get; set; }

    public int? BcomMaxChidren { get; set; }

    public decimal? BcomTotalForOwner { get; set; }

    public string? CreatorHost { get; set; }

    public string? IdAdMedia { get; set; }

    public string? IdLink { get; set; }

    public string? IdLastOperator { get; set; }

    public string? ChnlMsourceId { get; set; }

    public string? ChnlMpropertyId { get; set; }

    public string? ChnlMreservationCode { get; set; }

    public DateTime? ChnlMreservationLoading { get; set; }

    public int? ConversionScriptsShown { get; set; }

    public int? IsFreeMinStay { get; set; }

    public int? IsFreeArrivalDay { get; set; }

    public int? PriceIsBlocked { get; set; }

    public long? PidParentReservation { get; set; }

    public long? ChnlKigoResId { get; set; }

    public int? ChnlRoomoramaResId { get; set; }

    public int? IsFullpaid { get; set; }

    public decimal? PrDiscountFullPay { get; set; }

    public string? PrDiscountFullPayDesc { get; set; }

    public decimal? PrDiscountRevenueOffer { get; set; }

    public int? IsRevenueOfferDiscount { get; set; }

    public DateTime? PrOwnerRefundRecDate { get; set; }

    public int? PrOwnerRefundExported { get; set; }

    public int? IsRoomRamaConfirmed { get; set; }

    public string? OldReservationId { get; set; }

    public string? OwnerNotes { get; set; }

    public string? CheckInCheckOutNotes { get; set; }

    public string? OldAgentName { get; set; }

    public string? ReferredBy { get; set; }

    public int? IsImported { get; set; }

    public int? ManualPaymentPart { get; set; }

    public string? IcalName { get; set; }

    public int? PidWebsite { get; set; }

    public int? IsFirstPaymentFail { get; set; }

    public int? IsRequest { get; set; }

    public int? PidParentEstateId { get; set; }

    public string? PoNumber { get; set; }

    public int? ClGuestdataCompleted { get; set; }

    public decimal? CcFeesPercent { get; set; }

    public decimal? CcFees { get; set; }

    public string? FloorUs { get; set; }

    public string? BcomRateName { get; set; }

    public int? IsPaidMaga { get; set; }

    public int? HastateCancelledBy { get; set; }

    public string? SelectedCurrency { get; set; }

    public decimal? ConversionRate { get; set; }

    public decimal? PrTotalNonRefundable { get; set; }

    public string? ChnlRemarks { get; set; }

    public string? ChnlRateData { get; set; }

    public decimal? CedolareSecca { get; set; }

    public decimal? ManagementFee { get; set; }

    public decimal? PrTotalCommissionVat { get; set; }

    public decimal? PrTotalCommissionPer { get; set; }

    public decimal? PrTotalCommissionVatPer { get; set; }

    public decimal? PrTotalCommissionWithoutVat { get; set; }

    public string? IclUniqueId { get; set; }

    public string? AirbnbSubReason { get; set; }

    public string? AirbnbReason { get; set; }

    public string? MessageAirbnb { get; set; }

    public string? MessageGuest { get; set; }

    public decimal? AirbnbPenaltyFee { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? IsFeedComplate { get; set; }

    public DateTime? DeliveredDate { get; set; }

    public DateTime? PushDate { get; set; }
}
