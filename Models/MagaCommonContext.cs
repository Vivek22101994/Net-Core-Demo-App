using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models;

public partial class MagaCommonContext : DbContext
{
    public MagaCommonContext()
    {
    }

    public MagaCommonContext(DbContextOptions<MagaCommonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminCompanyMap> AdminCompanyMaps { get; set; }

    public virtual DbSet<AgodaHotelRateplan> AgodaHotelRateplans { get; set; }

    public virtual DbSet<AgodaLog> AgodaLogs { get; set; }

    public virtual DbSet<AgodaRoomRatePlanMapping> AgodaRoomRatePlanMappings { get; set; }

    public virtual DbSet<AirbnbAlter> AirbnbAlters { get; set; }

    public virtual DbSet<AirbnbCompanyHost> AirbnbCompanyHosts { get; set; }

    public virtual DbSet<AirbnbConfig> AirbnbConfigs { get; set; }

    public virtual DbSet<AirbnbFailedRequest> AirbnbFailedRequests { get; set; }

    public virtual DbSet<AirbnbListingHost> AirbnbListingHosts { get; set; }

    public virtual DbSet<AlmatarLog> AlmatarLogs { get; set; }

    public virtual DbSet<AlmosaferLog> AlmosaferLogs { get; set; }

    public virtual DbSet<AmenitiesCategory> AmenitiesCategories { get; set; }

    public virtual DbSet<AmenitiesChannelMap> AmenitiesChannelMaps { get; set; }

    public virtual DbSet<AmenitiesList> AmenitiesLists { get; set; }

    public virtual DbSet<AmenitiesListing> AmenitiesListings { get; set; }

    public virtual DbSet<Amenity> Amenities { get; set; }

    public virtual DbSet<AmentiesMetaDetail> AmentiesMetaDetails { get; set; }

    public virtual DbSet<AmentiesMetum> AmentiesMeta { get; set; }

    public virtual DbSet<AmentiesOtum> AmentiesOta { get; set; }

    public virtual DbSet<ApplicationRecyleLog> ApplicationRecyleLogs { get; set; }

    public virtual DbSet<AuthBcomToken> AuthBcomTokens { get; set; }

    public virtual DbSet<AuthClientTbl> AuthClientTbls { get; set; }

    public virtual DbSet<AuthErrorLog> AuthErrorLogs { get; set; }

    public virtual DbSet<BcomDayPrice> BcomDayPrices { get; set; }

    public virtual DbSet<BcomHotelRateplan> BcomHotelRateplans { get; set; }

    public virtual DbSet<BcomMealPlanMaster> BcomMealPlanMasters { get; set; }

    public virtual DbSet<BcomPhtotoBatch> BcomPhtotoBatches { get; set; }

    public virtual DbSet<BcomProjectConnection> BcomProjectConnections { get; set; }

    public virtual DbSet<BcomPropertyMapping> BcomPropertyMappings { get; set; }

    public virtual DbSet<BcomReservationMessage> BcomReservationMessages { get; set; }

    public virtual DbSet<BookingMessage> BookingMessages { get; set; }

    public virtual DbSet<BookingPushLog> BookingPushLogs { get; set; }

    public virtual DbSet<BookingReview> BookingReviews { get; set; }

    public virtual DbSet<BookingReviewCategory> BookingReviewCategories { get; set; }

    public virtual DbSet<ChangeRecovery> ChangeRecoveries { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<CompanyDeleteLog> CompanyDeleteLogs { get; set; }

    public virtual DbSet<CompanyPmstoken> CompanyPmstokens { get; set; }

    public virtual DbSet<ContLabelTbl> ContLabelTbls { get; set; }

    public virtual DbSet<ContLangTbl> ContLangTbls { get; set; }

    public virtual DbSet<ContSysConfigTb> ContSysConfigTbs { get; set; }

    public virtual DbSet<CtripLog> CtripLogs { get; set; }

    public virtual DbSet<ExpediaLog> ExpediaLogs { get; set; }

    public virtual DbSet<GathrenCompanyMap> GathrenCompanyMaps { get; set; }

    public virtual DbSet<GetPriceDataNew> GetPriceDataNews { get; set; }

    public virtual DbSet<GetRoomProperty> GetRoomProperties { get; set; }

    public virtual DbSet<GetSalesDataNew> GetSalesDataNews { get; set; }

    public virtual DbSet<GetSalesDatum> GetSalesData { get; set; }

    public virtual DbSet<GoogleHotelLog> GoogleHotelLogs { get; set; }

    public virtual DbSet<GoogleHotelRateplan> GoogleHotelRateplans { get; set; }

    public virtual DbSet<GoogleHotelRoomRateplan> GoogleHotelRoomRateplans { get; set; }

    public virtual DbSet<GoogleUser> GoogleUsers { get; set; }

    public virtual DbSet<GuestyHotelRateplan> GuestyHotelRateplans { get; set; }

    public virtual DbSet<HomeAwayProjectPolicy> HomeAwayProjectPolicies { get; set; }

    public virtual DbSet<LocCityTb> LocCityTbs { get; set; }

    public virtual DbSet<LocLkCountry> LocLkCountries { get; set; }

    public virtual DbSet<MagaAlmatarMapping> MagaAlmatarMappings { get; set; }

    public virtual DbSet<MagaHomeAwayMapping> MagaHomeAwayMappings { get; set; }

    public virtual DbSet<MappingActivityLog> MappingActivityLogs { get; set; }

    public virtual DbSet<OtadateWisePrice> OtadateWisePrices { get; set; }

    public virtual DbSet<Otaerrorlog> Otaerrorlogs { get; set; }

    public virtual DbSet<Otafacility> Otafacilities { get; set; }

    public virtual DbSet<Otaprice> Otaprices { get; set; }

    public virtual DbSet<OtapriceAgent> OtapriceAgents { get; set; }

    public virtual DbSet<OtarequestLog> OtarequestLogs { get; set; }

    public virtual DbSet<PmsamenitySubLevel> PmsamenitySubLevels { get; set; }

    public virtual DbSet<Pmsavailability> Pmsavailabilities { get; set; }

    public virtual DbSet<Pmslog> Pmslogs { get; set; }

    public virtual DbSet<PmsotaamenitiesMapping> PmsotaamenitiesMappings { get; set; }

    public virtual DbSet<Pmsotamapping> Pmsotamappings { get; set; }

    public virtual DbSet<PmsotarateplanMapping> PmsotarateplanMappings { get; set; }

    public virtual DbSet<Pmsrequest> Pmsrequests { get; set; }

    public virtual DbSet<PmsroomDatewiseSell> PmsroomDatewiseSells { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectType> ProjectTypes { get; set; }

    public virtual DbSet<PropetyRoomRateplan> PropetyRoomRateplans { get; set; }

    public virtual DbSet<Rateplan> Rateplans { get; set; }

    public virtual DbSet<ReservationAcknowledge> ReservationAcknowledges { get; set; }

    public virtual DbSet<RntAgentTbl> RntAgentTbls { get; set; }

    public virtual DbSet<RntAgodaHotelTbl> RntAgodaHotelTbls { get; set; }

    public virtual DbSet<RntAirbnbRequestLog> RntAirbnbRequestLogs { get; set; }

    public virtual DbSet<RntBcomAmenity> RntBcomAmenities { get; set; }

    public virtual DbSet<RntBcomHotelTbl> RntBcomHotelTbls { get; set; }

    public virtual DbSet<RntBcomRequestLog> RntBcomRequestLogs { get; set; }

    public virtual DbSet<RntChnlAirbnbEstateStatusRl> RntChnlAirbnbEstateStatusRls { get; set; }

    public virtual DbSet<RntChnlAirbnbEstateTbl> RntChnlAirbnbEstateTbls { get; set; }

    public virtual DbSet<RntChnlAirbnbLkPropertyTypeTbl> RntChnlAirbnbLkPropertyTypeTbls { get; set; }

    public virtual DbSet<RntChnlCtripRoomTypeRatePlanTbl> RntChnlCtripRoomTypeRatePlanTbls { get; set; }

    public virtual DbSet<RntChnlExpediaBookingTbl> RntChnlExpediaBookingTbls { get; set; }

    public virtual DbSet<RntChnlExpediaEstateTbl> RntChnlExpediaEstateTbls { get; set; }

    public virtual DbSet<RntChnlExpediaHotelTbl> RntChnlExpediaHotelTbls { get; set; }

    public virtual DbSet<RntChnlExpediaPropertyTypeRl> RntChnlExpediaPropertyTypeRls { get; set; }

    public virtual DbSet<RntChnlExpediaRoomTypeRatePlanTbl> RntChnlExpediaRoomTypeRatePlanTbls { get; set; }

    public virtual DbSet<RntChnlExpediaRoomTypeTbl> RntChnlExpediaRoomTypeTbls { get; set; }

    public virtual DbSet<RntChnlGathernEstateTbl> RntChnlGathernEstateTbls { get; set; }

    public virtual DbSet<RntChnlHomeAwayAcceptedPaymentFormTbl> RntChnlHomeAwayAcceptedPaymentFormTbls { get; set; }

    public virtual DbSet<RntChnlHomeAwayEstateFeaturesRl> RntChnlHomeAwayEstateFeaturesRls { get; set; }

    public virtual DbSet<RntChnlHomeAwayLkFeatureValuesTbl> RntChnlHomeAwayLkFeatureValuesTbls { get; set; }

    public virtual DbSet<RntEmailRecipientLn> RntEmailRecipientLns { get; set; }

    public virtual DbSet<RntEmailRecipientTb> RntEmailRecipientTbs { get; set; }

    public virtual DbSet<RntEstateAvailabilityRl> RntEstateAvailabilityRls { get; set; }

    public virtual DbSet<RntEstateCategoryTb> RntEstateCategoryTbs { get; set; }

    public virtual DbSet<RntEstateExtrasLn> RntEstateExtrasLns { get; set; }

    public virtual DbSet<RntEstateExtrasView> RntEstateExtrasViews { get; set; }

    public virtual DbSet<RntEstatePriceV4datesTbl> RntEstatePriceV4datesTbls { get; set; }

    public virtual DbSet<RntEstatePriceV4datesTblchannel> RntEstatePriceV4datesTblchannels { get; set; }

    public virtual DbSet<RntEstatePriceV4tbl> RntEstatePriceV4tbls { get; set; }

    public virtual DbSet<RntExtrasCategoryTb> RntExtrasCategoryTbs { get; set; }

    public virtual DbSet<RntGathernRequestLog> RntGathernRequestLogs { get; set; }

    public virtual DbSet<RntGuestyHotelTbl> RntGuestyHotelTbls { get; set; }

    public virtual DbSet<RntLnEstate> RntLnEstates { get; set; }

    public virtual DbSet<RntRequestTemplateLn> RntRequestTemplateLns { get; set; }

    public virtual DbSet<RntRequestTemplateTb> RntRequestTemplateTbs { get; set; }

    public virtual DbSet<RntRequestTemplateView> RntRequestTemplateViews { get; set; }

    public virtual DbSet<RntRlEstateMedium> RntRlEstateMedia { get; set; }

    public virtual DbSet<RntSeasonDatesTbl> RntSeasonDatesTbls { get; set; }

    public virtual DbSet<RntTbEstate> RntTbEstates { get; set; }

    public virtual DbSet<RntTblExtraReservation> RntTblExtraReservations { get; set; }

    public virtual DbSet<RntTblReservation> RntTblReservations { get; set; }

    public virtual DbSet<RoomNoLog> RoomNoLogs { get; set; }

    public virtual DbSet<RoomRatePlanMapping> RoomRatePlanMappings { get; set; }

    public virtual DbSet<Roomavailability> Roomavailabilities { get; set; }

    public virtual DbSet<SiteContent> SiteContents { get; set; }

    public virtual DbSet<UsrAdmin> UsrAdmins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0AKCKQ;Initial Catalog=MagaCommon;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<AdminCompanyMap>(entity =>
        {
            entity.ToTable("AdminCompanyMap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<AgodaHotelRateplan>(entity =>
        {
            entity.ToTable("AgodaHotelRateplan");

            entity.Property(e => e.AgodaId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AgodaID");
            entity.Property(e => e.BenifitId).HasMaxLength(1000);
            entity.Property(e => e.BenifitName).HasMaxLength(2000);
            entity.Property(e => e.CancelationCode).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasColumnName("IS_Active");
            entity.Property(e => e.OfferTypeName).HasMaxLength(300);
            entity.Property(e => e.ParentRatePlan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePlan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RatePlanID");
            entity.Property(e => e.RateType).HasMaxLength(100);
            entity.Property(e => e.SellEnd).HasColumnType("datetime");
            entity.Property(e => e.SellStart).HasColumnType("datetime");
            entity.Property(e => e.StayEnd).HasColumnType("datetime");
            entity.Property(e => e.StayStart).HasColumnType("datetime");
        });

        modelBuilder.Entity<AgodaLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("AgodaLOG");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<AgodaRoomRatePlanMapping>(entity =>
        {
            entity.ToTable("AgodaRoomRatePlanMapping");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RoomId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AirbnbAlter>(entity =>
        {
            entity.ToTable("AirbnbAlter");

            entity.Property(e => e.AlternationId).HasColumnName("alternation_id");
            entity.Property(e => e.ConfirmationCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("confirmation_code");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ListingId).HasColumnName("listing_id");
            entity.Property(e => e.Request).IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<AirbnbCompanyHost>(entity =>
        {
            entity.ToTable("AirbnbCompanyHost");

            entity.Property(e => e.HostId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
        });

        modelBuilder.Entity<AirbnbConfig>(entity =>
        {
            entity.ToTable("AirbnbConfig");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ClientID");
            entity.Property(e => e.ClientSecrent)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        });

        modelBuilder.Entity<AirbnbFailedRequest>(entity =>
        {
            entity.ToTable("AirbnbFailedRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HostId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HostID");
            entity.Property(e => e.RequestContent).HasColumnName("requestContent");
            entity.Property(e => e.RequestUrl)
                .IsUnicode(false)
                .HasColumnName("requestUrl");
        });

        modelBuilder.Entity<AirbnbListingHost>(entity =>
        {
            entity.ToTable("AirbnbListingHost");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ListingID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<AlmatarLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("AlmatarLog");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<AlmosaferLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("AlmosaferLOG");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<AmenitiesCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("Amenities_Category");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmenitiesChannelMap>(entity =>
        {
            entity.ToTable("AmenitiesChannelMap");

            entity.Property(e => e.AmenityId).HasColumnName("AmenityID");
            entity.Property(e => e.ChanneId).HasColumnName("ChanneID");
            entity.Property(e => e.ListingId).HasColumnName("Listing_ID");
        });

        modelBuilder.Entity<AmenitiesList>(entity =>
        {
            entity.HasKey(e => e.AmenityId);

            entity.ToTable("Amenities_list");

            entity.Property(e => e.AmenityId).HasColumnName("AmenityID");
            entity.Property(e => e.ChanneId).HasColumnName("ChanneID");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmenitiesListing>(entity =>
        {
            entity.ToTable("Amenities_Listing");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmenityId).HasColumnName("AmenityID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ListingId).HasColumnName("Listing_ID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Amenity>(entity =>
        {
            entity.Property(e => e.AmenityId).HasColumnName("AmenityID");
            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Title)
                .HasMaxLength(5000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmentiesMetaDetail>(entity =>
        {
            entity.ToTable("AmentiesMetaDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmentiesMetaId).HasColumnName("AmentiesMetaID");
            entity.Property(e => e.MetaEnum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MetaEnumDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmentiesMetum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmentiesId).HasColumnName("AmentiesID");
            entity.Property(e => e.Meta)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AmentiesOtum>(entity =>
        {
            entity.ToTable("AmentiesOTA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EnumCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MetaCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTA");
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.Uid).HasColumnName("UID");
        });

        modelBuilder.Entity<ApplicationRecyleLog>(entity =>
        {
            entity.ToTable("ApplicationRecyleLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RecyleDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AuthBcomToken>(entity =>
        {
            entity.ToTable("AuthBcomToken");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientSecret)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("client_secret");
            entity.Property(e => e.LastRefreshDateTime)
                .HasColumnType("datetime")
                .HasColumnName("lastRefreshDateTime");
            entity.Property(e => e.Token).HasColumnName("token");
        });

        modelBuilder.Entity<AuthClientTbl>(entity =>
        {
            entity.ToTable("AuthClientTBL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthPwd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("authPwd");
            entity.Property(e => e.AuthUsr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("authUsr");
            entity.Property(e => e.BirthCity)
                .HasMaxLength(50)
                .HasColumnName("birthCity");
            entity.Property(e => e.BirthCountry).HasColumnName("birthCountry");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birthDate");
            entity.Property(e => e.BirthPlace).HasColumnName("birthPlace");
            entity.Property(e => e.BirthProvince)
                .HasMaxLength(50)
                .HasColumnName("birthProvince");
            entity.Property(e => e.BirthState).HasColumnName("birthState");
            entity.Property(e => e.Citizenship)
                .HasMaxLength(50)
                .HasColumnName("citizenship");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ContactEmail).HasColumnName("contactEmail");
            entity.Property(e => e.ContactFax).HasColumnName("contactFax");
            entity.Property(e => e.ContactPhone).HasColumnName("contactPhone");
            entity.Property(e => e.ContactPhoneMobile).HasColumnName("contactPhoneMobile");
            entity.Property(e => e.ContactPhoneOffice).HasColumnName("contactPhoneOffice");
            entity.Property(e => e.ContactPhoneTrip).HasColumnName("contactPhoneTrip");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreatedUserId).HasColumnName("createdUserID");
            entity.Property(e => e.CreatedUserNameFull).HasColumnName("createdUserNameFull");
            entity.Property(e => e.DocCf).HasColumnName("docCf");
            entity.Property(e => e.DocExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("docExpiryDate");
            entity.Property(e => e.DocIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("docIssueDate");
            entity.Property(e => e.DocIssuePlace).HasColumnName("docIssuePlace");
            entity.Property(e => e.DocIssuePlaceIt)
                .HasMaxLength(50)
                .HasColumnName("docIssuePlace_IT");
            entity.Property(e => e.DocNum).HasColumnName("docNum");
            entity.Property(e => e.DocType).HasColumnName("docType");
            entity.Property(e => e.DocTypeIt)
                .HasMaxLength(50)
                .HasColumnName("docType_IT");
            entity.Property(e => e.DocVat).HasColumnName("docVat");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.GuestType)
                .HasMaxLength(50)
                .HasColumnName("guestType");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LocAddress).HasColumnName("locAddress");
            entity.Property(e => e.LocCity).HasColumnName("locCity");
            entity.Property(e => e.LocCountry).HasColumnName("locCountry");
            entity.Property(e => e.LocState).HasColumnName("locState");
            entity.Property(e => e.LocZipCode).HasColumnName("locZipCode");
            entity.Property(e => e.NameFirst).HasColumnName("nameFirst");
            entity.Property(e => e.NameFull).HasColumnName("nameFull");
            entity.Property(e => e.NameHonorific).HasColumnName("nameHonorific");
            entity.Property(e => e.NameLast).HasColumnName("nameLast");
            entity.Property(e => e.NameMiddle).HasColumnName("nameMiddle");
            entity.Property(e => e.NotesInner)
                .HasColumnType("ntext")
                .HasColumnName("notesInner");
            entity.Property(e => e.NotesInvoice)
                .HasColumnType("ntext")
                .HasColumnName("notesInvoice");
            entity.Property(e => e.PidAgent).HasColumnName("pidAgent");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.PidRoomoramaClient).HasColumnName("pidRoomoramaClient");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(50)
                .HasColumnName("typeCode");
            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_AuthClientTBL_uid")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<AuthErrorLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("AuthErrorLOG");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<BcomDayPrice>(entity =>
        {
            entity.ToTable("BcomDayPrice");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceDate).HasColumnType("datetime");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
        });

        modelBuilder.Entity<BcomHotelRateplan>(entity =>
        {
            entity.ToTable("BcomHotelRateplan");

            entity.Property(e => e.BcomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BcomID");
            entity.Property(e => e.IsActive).HasColumnName("IS_Active");
            entity.Property(e => e.ParentRatePlan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePlan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RatePlanID");
        });

        modelBuilder.Entity<BcomMealPlanMaster>(entity =>
        {
            entity.ToTable("BcomMealPlanMaster");

            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BcomPhtotoBatch>(entity =>
        {
            entity.ToTable("BcomPhtotoBatch");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ParentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ParentID");
            entity.Property(e => e.PatentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhotoBatchId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PhotoBatchID");
            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoomTypeID");
        });

        modelBuilder.Entity<BcomProjectConnection>(entity =>
        {
            entity.ToTable("BcomProjectConnection");

            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
        });

        modelBuilder.Entity<BcomPropertyMapping>(entity =>
        {
            entity.ToTable("BcomPropertyMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Refid).HasColumnName("refid");
        });

        modelBuilder.Entity<BcomReservationMessage>(entity =>
        {
            entity.ToTable("BcomReservationMessage");

            entity.Property(e => e.BookingReservationid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bookingReservationid");
            entity.Property(e => e.Totalmessage).HasColumnName("totalmessage");
        });

        modelBuilder.Entity<BookingMessage>(entity =>
        {
            entity.ToTable("BookingMessage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AgnetId).HasColumnName("agnetID");
            entity.Property(e => e.AttchemntUrl).IsUnicode(false);
            entity.Property(e => e.ConversionId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ConversionID");
            entity.Property(e => e.CreeatedDate).HasColumnType("datetime");
            entity.Property(e => e.MessageId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MessageID");
            entity.Property(e => e.ReservationId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ReservationID");
            entity.Property(e => e.Sender)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BookingPushLog>(entity =>
        {
            entity.ToTable("BookingPushLog");

            entity.Property(e => e.PushDateTime).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BookingReview>(entity =>
        {
            entity.ToTable("BookingReview");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExprredDatetime).HasColumnType("datetime");
            entity.Property(e => e.OverallRating).HasColumnName("overall_rating");
            entity.Property(e => e.ReservationCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReviewId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ReviewID");
        });

        modelBuilder.Entity<BookingReviewCategory>(entity =>
        {
            entity.ToTable("BookingReviewCategory");

            entity.Property(e => e.BookiingReviewId).HasColumnName("BookiingReviewID");
            entity.Property(e => e.Category).HasMaxLength(100);
        });

        modelBuilder.Entity<ChangeRecovery>(entity =>
        {
            entity.ToTable("ChangeRecovery");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiredTime).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UniqueID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Client");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ClientName).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("unique_id");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ClientFilter).HasDefaultValue(0);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CompanyDeleteLog>(entity =>
        {
            entity.ToTable("CompanyDeleteLog");

            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(500);
        });

        modelBuilder.Entity<CompanyPmstoken>(entity =>
        {
            entity.ToTable("CompanyPMSToken");

            entity.Property(e => e.ApiToken).IsUnicode(false);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasColumnName("Is_Active");
            entity.Property(e => e.Title).HasMaxLength(1000);
        });

        modelBuilder.Entity<ContLabelTbl>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.PidLang }).HasName("PK_ContLabelTBL_1");

            entity.ToTable("ContLabelTBL");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<ContLangTbl>(entity =>
        {
            entity.ToTable("ContLangTBL");

            entity.Property(e => e.Id)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Abbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("abbr");
            entity.Property(e => e.CommonName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("commonName");
            entity.Property(e => e.ImgPreview)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgPreview");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgThumb");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsPublic).HasColumnName("isPublic");
            entity.Property(e => e.JsCalFile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("jsCalFile");
            entity.Property(e => e.LangTitle)
                .HasMaxLength(50)
                .HasColumnName("langTitle");
            entity.Property(e => e.PidCountry).HasColumnName("pidCountry");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ContSysConfigTb>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.ToTable("ContSysConfigTB");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CtripLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("CtripLOG");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<ExpediaLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("ExpediaLOG");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<GathrenCompanyMap>(entity =>
        {
            entity.ToTable("GathrenCompanyMap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Uuid).HasColumnName("UUID");
        });

        modelBuilder.Entity<GetPriceDataNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetPriceDataNew");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DtEnd)
                .HasColumnType("datetime")
                .HasColumnName("dtEnd");
            entity.Property(e => e.DtStart)
                .HasColumnType("datetime")
                .HasColumnName("dtStart");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PriceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceAmount");
        });

        modelBuilder.Entity<GetRoomProperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetRoomProperty");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.SignleRoomName).HasMaxLength(100);
        });

        modelBuilder.Entity<GetSalesDataNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetSalesDataNew");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.DtEnd)
                .HasColumnType("datetime")
                .HasColumnName("dtEnd");
            entity.Property(e => e.DtStart)
                .HasColumnType("datetime")
                .HasColumnName("dtStart");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PriceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceAmount");
        });

        modelBuilder.Entity<GetSalesDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GetSalesData");

            entity.Property(e => e.Name)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoogleHotelLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("GoogleHotelLog");

            entity.Property(e => e.Uid)
                .ValueGeneratedNever()
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<GoogleHotelRateplan>(entity =>
        {
            entity.ToTable("GoogleHotelRateplan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CheckInTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckOutTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GoogleHotelId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RateplanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RateplanID");
            entity.Property(e => e.RateplanName).HasMaxLength(100);
            entity.Property(e => e.RefundTime)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoogleHotelRoomRateplan>(entity =>
        {
            entity.ToTable("GoogleHotelRoomRateplan");
        });

        modelBuilder.Entity<GoogleUser>(entity =>
        {
            entity.ToTable("GoogleUser");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GuestyHotelRateplan>(entity =>
        {
            entity.ToTable("GuestyHotelRateplan");

            entity.Property(e => e.GuestyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GuestyID");
            entity.Property(e => e.IsActive).HasColumnName("IS_Active");
            entity.Property(e => e.ParentRatePlan)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePlan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RatePlanID");
        });

        modelBuilder.Entity<HomeAwayProjectPolicy>(entity =>
        {
            entity.ToTable("HomeAwayProjectPolicy");

            entity.Property(e => e.AdvertiserAssignedId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("advertiserAssignedId");
            entity.Property(e => e.AgrerementPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ca).HasColumnName("CA");
            entity.Property(e => e.CancelPolicy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ea).HasColumnName("EA");
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Locale)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pa).HasColumnName("PA");
            entity.Property(e => e.Sa).HasColumnName("SA");
        });

        modelBuilder.Entity<LocCityTb>(entity =>
        {
            entity.ToTable("LocCityTB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .HasColumnName("code");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.PidCountry).HasColumnName("pidCountry");
        });

        modelBuilder.Entity<LocLkCountry>(entity =>
        {
            entity.ToTable("LOC_LK_COUNTRY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryCode).HasColumnName("country_code");
            entity.Property(e => e.CountryPrefix)
                .HasMaxLength(10)
                .HasColumnName("countryPrefix");
            entity.Property(e => e.HasProvince).HasColumnName("has_province");
            entity.Property(e => e.HasRegion).HasColumnName("has_region");
            entity.Property(e => e.ImgBanner)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("img_banner");
            entity.Property(e => e.ImgFlag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_flag");
            entity.Property(e => e.ImgPreview)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_preview");
            entity.Property(e => e.InnerNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("inner_notes");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<MagaAlmatarMapping>(entity =>
        {
            entity.ToTable("MagaAlmatarMapping");

            entity.Property(e => e.IsActive).HasColumnName("is_Active");
            entity.Property(e => e.MagaRoomId).HasColumnName("MagaRoomID");
        });

        modelBuilder.Entity<MagaHomeAwayMapping>(entity =>
        {
            entity.ToTable("MagaHomeAwayMapping");

            entity.Property(e => e.IsActive).HasColumnName("is_Active");
            entity.Property(e => e.MagaRoomId).HasColumnName("MagaRoomID");
        });

        modelBuilder.Entity<MappingActivityLog>(entity =>
        {
            entity.ToTable("MappingActivityLog");

            entity.Property(e => e.AfterMapping).IsUnicode(false);
            entity.Property(e => e.BeforeMapping).IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.MapType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModifyIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ModifyIP");
        });

        modelBuilder.Entity<OtadateWisePrice>(entity =>
        {
            entity.ToTable("OTADateWisePrice");

            entity.HasIndex(e => new { e.OtapriceId, e.SellDate }, "IDX_OTADateWisePrice_OTAPriceID_SellDate");

            entity.HasIndex(e => new { e.OtapriceId, e.SellDate }, "IX_OTADateWisePrice_OTAPriceID_SellDate");

            entity.Property(e => e.ID).HasColumnName("iD");
            entity.Property(e => e.MaxSell).HasColumnName("max_sell");
            entity.Property(e => e.OtapriceId).HasColumnName("OTAPriceID");
            entity.Property(e => e.SellDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Otaerrorlog>(entity =>
        {
            entity.ToTable("OTAErrorlog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ListingId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ListingID");
        });

        modelBuilder.Entity<Otafacility>(entity =>
        {
            entity.ToTable("OTAFacilities");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Ota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTA");
            entity.Property(e => e.Otaid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTAID");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Otaprice>(entity =>
        {
            entity.ToTable("OTAPrice");

            entity.HasIndex(e => e.RoomTypeId, "IDX_OTAPrice_RoomTypeID");

            entity.HasIndex(e => e.RoomTypeId, "IX_OTAPrice_RoomTypeID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsAutomatic).HasColumnName("is_automatic");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<OtapriceAgent>(entity =>
        {
            entity.ToTable("OTAPriceAgent");

            entity.Property(e => e.DtCreation)
                .HasColumnType("datetime")
                .HasColumnName("dtCreation");
            entity.Property(e => e.Otacode).HasColumnName("OTACode");
            entity.Property(e => e.OtapriceId).HasColumnName("OTAPriceID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<OtarequestLog>(entity =>
        {
            entity.ToTable("OTARequestLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttemptDate).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.ListingId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ListingID");
            entity.Property(e => e.Otaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTAName");
            entity.Property(e => e.PmsrequestId).HasColumnName("PMSRequestID");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PmsamenitySubLevel>(entity =>
        {
            entity.ToTable("PMSAmenitySubLevel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmenityMappingId).HasColumnName("AmenityMappingID");
        });

        modelBuilder.Entity<Pmsavailability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_PMSavailability");

            entity.ToTable("PMSavailability");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PidSeasonDate).HasColumnName("pidSeasonDate");
        });

        modelBuilder.Entity<Pmslog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("PMSLOG");

            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_PMSLOG_uid")
                .HasColumnName("uid");
            entity.Property(e => e.ErrorContent)
                .HasColumnType("ntext")
                .HasColumnName("errorContent");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("errorType");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.LogIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("logIp");
            entity.Property(e => e.LogUrl)
                .HasMaxLength(500)
                .HasColumnName("logUrl");
        });

        modelBuilder.Entity<PmsotaamenitiesMapping>(entity =>
        {
            entity.ToTable("PMSOTAAmenitiesMapping");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmenityId).HasColumnName("AmenityID");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
        });

        modelBuilder.Entity<Pmsotamapping>(entity =>
        {
            entity.ToTable("PMSOTAMapping");

            entity.Property(e => e.BcmRoomId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MrId).HasColumnName("mr_id");
        });

        modelBuilder.Entity<PmsotarateplanMapping>(entity =>
        {
            entity.ToTable("PMSOTARateplanMapping");

            entity.Property(e => e.OtarateplanId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OTARateplanID");
            entity.Property(e => e.PmsratepmanId).HasColumnName("PMSRatepmanID");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
        });

        modelBuilder.Entity<Pmsrequest>(entity =>
        {
            entity.ToTable("PMSRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
        });

        modelBuilder.Entity<PmsroomDatewiseSell>(entity =>
        {
            entity.ToTable("PMSRoomDatewiseSell");

            entity.HasIndex(e => new { e.RoomId, e.SellDate }, "IDX_pmsroomdatewisesell_roomid_selldate");

            entity.HasIndex(e => new { e.RoomId, e.SellDate }, "IX_PMSRoomDatewiseSell_RoomId_SellDate");

            entity.Property(e => e.SellDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Project");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.UniqueId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("unique_id");
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity.ToTable("ProjectType");

            entity.Property(e => e.ProjectTypeTitle).HasMaxLength(100);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<PropetyRoomRateplan>(entity =>
        {
            entity.ToTable("PropetyRoomRateplan");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
        });

        modelBuilder.Entity<Rateplan>(entity =>
        {
            entity.ToTable("Rateplan");

            entity.Property(e => e.RatePlanId).HasColumnName("RatePlanID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Currancy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsPrimary).HasColumnName("is_Primary");
            entity.Property(e => e.MaxOcuupany).HasColumnName("Max_Ocuupany");
            entity.Property(e => e.ParentRateplanId).HasColumnName("ParentRateplanID");
            entity.Property(e => e.RateMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SellMode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ReservationAcknowledge>(entity =>
        {
            entity.ToTable("ReservationAcknowledge");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcknowledgeDatetime).HasColumnType("datetime");
            entity.Property(e => e.Isacknowledge).HasColumnName("ISAcknowledge");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
        });

        modelBuilder.Entity<RntAgentTbl>(entity =>
        {
            entity.ToTable("RntAgentTBL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthPwd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("authPwd");
            entity.Property(e => e.AuthUsr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("authUsr");
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("birthDate");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(100)
                .HasColumnName("birthPlace");
            entity.Property(e => e.CashDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cashDiscount");
            entity.Property(e => e.CashPayed)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cashPayed");
            entity.Property(e => e.CashPayedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("cashPayedDateTime");
            entity.Property(e => e.CashPayedTxnId)
                .HasMaxLength(500)
                .HasColumnName("cashPayedTxnID");
            entity.Property(e => e.CashTaxAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cashTaxAmount");
            entity.Property(e => e.CashTaxFree)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cashTaxFree");
            entity.Property(e => e.CashTotalAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cashTotalAmount");
            entity.Property(e => e.ChnlEstatePage)
                .HasMaxLength(100)
                .HasColumnName("chnlEstatePage");
            entity.Property(e => e.ChnlMgetAddress).HasColumnName("chnlMGetAddress");
            entity.Property(e => e.ChnlMgetAmenities).HasColumnName("chnlMGetAmenities");
            entity.Property(e => e.ChnlMgetPhotos).HasColumnName("chnlMGetPhotos");
            entity.Property(e => e.ChnlMgetPrices).HasColumnName("chnlMGetPrices");
            entity.Property(e => e.ChnlMgetTexts).HasColumnName("chnlMGetTexts");
            entity.Property(e => e.ClLocProvince)
                .HasMaxLength(50)
                .HasColumnName("cl_loc_province");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ContactComeFrom)
                .HasMaxLength(500)
                .HasColumnName("contactComeFrom");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactEmail");
            entity.Property(e => e.ContactEmailInvoice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactEmailInvoice");
            entity.Property(e => e.ContactFax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactFax");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactPhone");
            entity.Property(e => e.ContactPhoneMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactPhoneMobile");
            entity.Property(e => e.ContactWebSite)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contactWebSite");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.CreatedUserId).HasColumnName("createdUserID");
            entity.Property(e => e.CreatedUserNameFull)
                .HasMaxLength(200)
                .HasColumnName("createdUserNameFull");
            entity.Property(e => e.DeleteFromHere)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("deleteFromHere");
            entity.Property(e => e.DeleteToHere)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("deleteToHere");
            entity.Property(e => e.DocCf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docCf");
            entity.Property(e => e.DocExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("docExpiryDate");
            entity.Property(e => e.DocIssueDate)
                .HasColumnType("datetime")
                .HasColumnName("docIssueDate");
            entity.Property(e => e.DocIssuePlace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docIssuePlace");
            entity.Property(e => e.DocNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docNum");
            entity.Property(e => e.DocType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docType");
            entity.Property(e => e.DocVat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docVat");
            entity.Property(e => e.DocVatIsEuReg).HasColumnName("docVat_isEuReg");
            entity.Property(e => e.HaadvertiserAssignedId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAadvertiser_assignedId");
            entity.Property(e => e.HasAcceptedContract).HasColumnName("hasAcceptedContract");
            entity.Property(e => e.IdAdMedia).HasMaxLength(100);
            entity.Property(e => e.ImgLogo).HasColumnName("imgLogo");
            entity.Property(e => e.InvCompanyId).HasColumnName("invCompanyId");
            entity.Property(e => e.InvTaxId).HasColumnName("invTaxId");
            entity.Property(e => e.InvoicePercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsAgencyFeeApplied).HasColumnName("isAgencyFeeApplied");
            entity.Property(e => e.IsIntegrate).HasColumnName("is_integrate");
            entity.Property(e => e.IsInternalWebsite).HasColumnName("isInternalWebsite");
            entity.Property(e => e.IsMsgsEnabled).HasColumnName("isMsgsEnabled");
            entity.Property(e => e.IsSendNightWisePrice).HasColumnName("isSendNightWisePrice");
            entity.Property(e => e.LocAddress)
                .HasMaxLength(500)
                .HasColumnName("locAddress");
            entity.Property(e => e.LocCity)
                .HasMaxLength(50)
                .HasColumnName("locCity");
            entity.Property(e => e.LocCountry)
                .HasMaxLength(100)
                .HasColumnName("locCountry");
            entity.Property(e => e.LocState)
                .HasMaxLength(50)
                .HasColumnName("locState");
            entity.Property(e => e.LocZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("locZipCode");
            entity.Property(e => e.NameCompany)
                .HasMaxLength(200)
                .HasColumnName("nameCompany");
            entity.Property(e => e.NameFirst)
                .HasMaxLength(100)
                .HasColumnName("nameFirst");
            entity.Property(e => e.NameFull)
                .HasMaxLength(200)
                .HasColumnName("nameFull");
            entity.Property(e => e.NameHonor)
                .HasMaxLength(200)
                .HasColumnName("nameHonor");
            entity.Property(e => e.NameLast)
                .HasMaxLength(100)
                .HasColumnName("nameLast");
            entity.Property(e => e.NotesClient)
                .HasColumnType("ntext")
                .HasColumnName("notesClient");
            entity.Property(e => e.NotesInner)
                .HasColumnType("ntext")
                .HasColumnName("notesInner");
            entity.Property(e => e.NotesInvoice)
                .HasColumnType("ntext")
                .HasColumnName("notesInvoice");
            entity.Property(e => e.PartPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayDiscountNotPayed).HasColumnName("payDiscountNotPayed");
            entity.Property(e => e.PayFullPayment).HasColumnName("payFullPayment");
            entity.Property(e => e.PayToConfirm).HasColumnName("payToConfirm");
            entity.Property(e => e.PidDiscountType).HasColumnName("pidDiscountType");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.PidReferer).HasColumnName("pidReferer");
            entity.Property(e => e.SupportMultiUnit).HasColumnName("supportMultiUnit");
            entity.Property(e => e.TypeCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("typeCode");
            entity.Property(e => e.TypeTitle)
                .HasMaxLength(100)
                .HasColumnName("typeTitle");
            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_RntAgentTBL_uid")
                .HasColumnName("uid");
        });

        modelBuilder.Entity<RntAgodaHotelTbl>(entity =>
        {
            entity.ToTable("RntAgodaHotelTbl");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.GoogleMaps)
                .HasMaxLength(200)
                .HasColumnName("google_maps");
            entity.Property(e => e.HotelCategorycode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HotelCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HotelName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LocPhysicalAddress)
                .HasMaxLength(300)
                .HasColumnName("locPhysicalAddress");
            entity.Property(e => e.LocZipCode).HasMaxLength(200);
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PidEstateId).HasColumnName("pidEstateId");
            entity.Property(e => e.Ruid)
                .IsUnicode(false)
                .HasColumnName("RUID");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<RntAirbnbRequestLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("RntAirbnbRequestLOG");

            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_RntAirbnbRequestLOGuid")
                .HasColumnName("uid");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.RequesUrl).HasColumnName("requesUrl");
            entity.Property(e => e.RequestComments).HasColumnName("requestComments");
            entity.Property(e => e.RequestContent)
                .HasColumnType("ntext")
                .HasColumnName("requestContent");
            entity.Property(e => e.RequestType).HasColumnName("requestType");
            entity.Property(e => e.ResponseContent)
                .HasColumnType("ntext")
                .HasColumnName("responseContent");
        });

        modelBuilder.Entity<RntBcomAmenity>(entity =>
        {
            entity.ToTable("RntBcomAmenity");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AmenityDescription).HasMaxLength(200);
            entity.Property(e => e.AmenityName).HasMaxLength(100);
            entity.Property(e => e.AmenityType).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(200);
        });

        modelBuilder.Entity<RntBcomHotelTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RntBcomHotelTBL_1");

            entity.ToTable("RntBcomHotelTBL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CancellationPolicyCode).HasColumnName("cancellationPolicyCode");
            entity.Property(e => e.ClientId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("client_id");
            entity.Property(e => e.ClientSecret)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("client_secret");
            entity.Property(e => e.CompanyCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("companyCode");
            entity.Property(e => e.DefCheckIn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Def_CheckIn");
            entity.Property(e => e.DefCheckOut)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Def_CheckOut");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("extension");
            entity.Property(e => e.GeneralName)
                .HasMaxLength(100)
                .HasColumnName("generalName");
            entity.Property(e => e.GeneralSurName)
                .HasMaxLength(100)
                .HasColumnName("generalSurName");
            entity.Property(e => e.GeniusRateName).HasMaxLength(500);
            entity.Property(e => e.GoogleMaps)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("google_maps");
            entity.Property(e => e.HotelId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hotelId");
            entity.Property(e => e.HotelName).HasColumnName("hotelName");
            entity.Property(e => e.HotelierMessageLanguage).HasMaxLength(100);
            entity.Property(e => e.InvoiceExtension)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("invoiceExtension");
            entity.Property(e => e.InvoiceName)
                .HasMaxLength(100)
                .HasColumnName("invoiceName");
            entity.Property(e => e.InvoicePhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("invoicePhone");
            entity.Property(e => e.InvoicePhoneTechType).HasColumnName("invoicePhoneTechType");
            entity.Property(e => e.InvoiceSurName)
                .HasMaxLength(100)
                .HasColumnName("invoiceSurName");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsGeniusRateActive).HasColumnName("isGeniusRateActive");
            entity.Property(e => e.IsNotRefundRateActive).HasColumnName("isNotRefundRateActive");
            entity.Property(e => e.IsSpecialRateActive).HasColumnName("isSpecialRateActive");
            entity.Property(e => e.IsStandardRateActive).HasColumnName("isStandardRateActive");
            entity.Property(e => e.LocInvoiceAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("locInvoiceAddress");
            entity.Property(e => e.LocInvoiceCity).HasColumnName("locInvoiceCity");
            entity.Property(e => e.LocInvoiceCountry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("locInvoiceCountry");
            entity.Property(e => e.LocInvoiceState)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("locInvoiceState");
            entity.Property(e => e.LocInvoiceZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locInvoiceZipCode");
            entity.Property(e => e.LocPhysicalAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("locPhysicalAddress");
            entity.Property(e => e.LocPhysicalCountry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("locPhysicalCountry");
            entity.Property(e => e.LocPhysicalZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("locPhysicalZipCode");
            entity.Property(e => e.NotRefundRateName)
                .HasMaxLength(500)
                .HasColumnName("notRefundRateName");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.PetPolicyNonRefundableFee)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PetsAllowedCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PhoneTechType).HasColumnName("phoneTechType");
            entity.Property(e => e.PidEstateId).HasColumnName("pidEstateId");
            entity.Property(e => e.PidPhysicalCity).HasColumnName("pidPhysicalCity");
            entity.Property(e => e.RateIdGenius).HasColumnName("rateIdGenius");
            entity.Property(e => e.RateIdNotRefund).HasColumnName("rateIdNotRefund");
            entity.Property(e => e.RateIdSpecial).HasColumnName("rateIdSpecial");
            entity.Property(e => e.RateIdStandard).HasColumnName("rateIdStandard");
            entity.Property(e => e.Ruid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RUID");
            entity.Property(e => e.SpecialRateName)
                .HasMaxLength(500)
                .HasColumnName("specialRateName");
            entity.Property(e => e.StandardRateName)
                .HasMaxLength(500)
                .HasColumnName("standardRateName");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<RntBcomRequestLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("RntBcomRequestLOG");

            entity.HasIndex(e => e.LogDateTime, "IX_RntBcomRequestLOG_logDateTime");

            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_RntBcomRequestLOG_uid")
                .HasColumnName("uid");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.RequesUrl).HasColumnName("requesUrl");
            entity.Property(e => e.RequestComments).HasColumnName("requestComments");
            entity.Property(e => e.RequestContent)
                .HasColumnType("ntext")
                .HasColumnName("requestContent");
            entity.Property(e => e.RequestType).HasColumnName("requestType");
            entity.Property(e => e.ResponseContent)
                .HasColumnType("ntext")
                .HasColumnName("responseContent");
        });

        modelBuilder.Entity<RntChnlAirbnbEstateStatusRl>(entity =>
        {
            entity.ToTable("RntChnlAirbnbEstateStatusRL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AirbnbEstate)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("airbnbEstate");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
        });

        modelBuilder.Entity<RntChnlAirbnbEstateTbl>(entity =>
        {
            entity.HasKey(e => e.MrId);

            entity.ToTable("RntChnlAirbnbEstateTBL");

            entity.Property(e => e.MrId)
                .ValueGeneratedNever()
                .HasColumnName("mr_id");
            entity.Property(e => e.AirbnbId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("airbnb_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
            entity.Property(e => e.SyncCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("syncCategory");
            entity.Property(e => e.SyncDtae)
                .HasColumnType("datetime")
                .HasColumnName("syncDtae");
        });

        modelBuilder.Entity<RntChnlAirbnbLkPropertyTypeTbl>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("RntChnlAirbnbLkPropertyTypeTBL");

            entity.Property(e => e.Code)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.RefId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("refId");
        });

        modelBuilder.Entity<RntChnlCtripRoomTypeRatePlanTbl>(entity =>
        {
            entity.HasKey(e => new { e.RoomTypeId, e.RatePlanCode });

            entity.ToTable("RntChnlCtripRoomTypeRatePlanTBL");

            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MaxAdultOccupancy).HasColumnName("maxAdultOccupancy");
            entity.Property(e => e.MaxOccupancy).HasColumnName("maxOccupancy");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.RateCategory)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<RntChnlExpediaBookingTbl>(entity =>
        {
            entity.ToTable("RntChnlExpediaBookingTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ConfirmNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("confirmNumber");
            entity.Property(e => e.CreateDateTime)
                .HasColumnType("datetime")
                .HasColumnName("createDateTime");
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ratePlanID");
            entity.Property(e => e.ReservationId).HasColumnName("reservationId");
            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("roomTypeID");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("source");
            entity.Property(e => e.SpecialRequestCodes)
                .IsUnicode(false)
                .HasColumnName("specialRequestCodes");
            entity.Property(e => e.SpecialRequests).HasColumnName("specialRequests");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<RntChnlExpediaEstateTbl>(entity =>
        {
            entity.ToTable("RntChnlExpediaEstateTBL");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RntChnlExpediaHotelTbl>(entity =>
        {
            entity.HasKey(e => e.HotelId);

            entity.ToTable("RntChnlExpediaHotelTBL");

            entity.Property(e => e.HotelId).ValueGeneratedNever();
            entity.Property(e => e.City).HasColumnName("city");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(1, "DF_RntChnlExpediaHotelTBL_isActive")
                .HasColumnName("isActive");
            entity.Property(e => e.IsDemo).HasColumnName("isDemo");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password)
                .HasDefaultValue("", "DF_RntChnlExpediaHotelTBL_password")
                .HasColumnName("password");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.Status)
                .HasMaxLength(300)
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasDefaultValue("", "DF_RntChnlExpediaHotelTBL_username")
                .HasColumnName("username");
        });

        modelBuilder.Entity<RntChnlExpediaPropertyTypeRl>(entity =>
        {
            entity.HasKey(e => new { e.PidCategory, e.PidExpediaCategory });

            entity.ToTable("RntChnlExpediaPropertyTypeRL");

            entity.Property(e => e.PidCategory).HasColumnName("pidCategory");
            entity.Property(e => e.PidExpediaCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pidExpediaCategory");
        });

        modelBuilder.Entity<RntChnlExpediaRoomTypeRatePlanTbl>(entity =>
        {
            entity.HasKey(e => new { e.RoomTypeId, e.RatePlanId });

            entity.ToTable("RntChnlExpediaRoomTypeRatePlanTBL");

            entity.Property(e => e.RoomTypeId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AreMinMaxLoslinked).HasColumnName("areMinMaxLOSLinked");
            entity.Property(e => e.BookDateEnd)
                .HasColumnType("datetime")
                .HasColumnName("bookDateEnd");
            entity.Property(e => e.BookDateStart)
                .HasColumnType("datetime")
                .HasColumnName("bookDateStart");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CreateDateTime).HasColumnName("createDateTime");
            entity.Property(e => e.DepositRequired).HasColumnName("depositRequired");
            entity.Property(e => e.DistributionModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("distributionModel");
            entity.Property(e => e.IsAvailStatusLinked).HasColumnName("isAvailStatusLinked");
            entity.Property(e => e.IsCtalinked).HasColumnName("isCTALinked");
            entity.Property(e => e.IsCtdlinked).HasColumnName("isCTDLinked");
            entity.Property(e => e.MaxAdvBookDays).HasColumnName("maxAdvBookDays");
            entity.Property(e => e.MaxLosdefault).HasColumnName("maxLOSDefault");
            entity.Property(e => e.MinAdvBookDays).HasColumnName("minAdvBookDays");
            entity.Property(e => e.MinLosdefault).HasColumnName("minLOSDefault");
            entity.Property(e => e.MobileOnly).HasColumnName("mobileOnly");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.OccupantsForBaseRate).HasColumnName("occupantsForBaseRate");
            entity.Property(e => e.ParentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parentId");
            entity.Property(e => e.PricingModel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pricingModel");
            entity.Property(e => e.RateAcquisitionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rateAcquisitionType");
            entity.Property(e => e.RateChangeAmount).HasColumnName("rate_changeAmount");
            entity.Property(e => e.RateChangeIsDiscount).HasColumnName("rate_changeIsDiscount");
            entity.Property(e => e.RateChangeIsPercentage)
                .HasDefaultValue(1, "DF_RntChnlExpediaRoomTypeRatePlanTBL_rate_changeIsPercentage")
                .HasColumnName("rate_changeIsPercentage");
            entity.Property(e => e.RateLinkEnd)
                .HasColumnType("datetime")
                .HasColumnName("rateLinkEnd");
            entity.Property(e => e.RateLinkExceptions).HasColumnName("rateLinkExceptions");
            entity.Property(e => e.RateLinkStart)
                .HasColumnType("datetime")
                .HasColumnName("rateLinkStart");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TravelDateEnd)
                .HasColumnType("datetime")
                .HasColumnName("travelDateEnd");
            entity.Property(e => e.TravelDateStart)
                .HasColumnType("datetime")
                .HasColumnName("travelDateStart");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");
            entity.Property(e => e.ValueAddInclusions)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("valueAddInclusions");
        });

        modelBuilder.Entity<RntChnlExpediaRoomTypeTbl>(entity =>
        {
            entity.ToTable("RntChnlExpediaRoomTypeTBL");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.MaxOccupants).HasColumnName("maxOccupants");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SmokingPref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("smokingPref");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<RntChnlGathernEstateTbl>(entity =>
        {
            entity.HasKey(e => e.MrId);

            entity.ToTable("RntChnlGathernEstateTBL");

            entity.Property(e => e.MrId)
                .ValueGeneratedNever()
                .HasColumnName("mr_id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.GathernId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Gathern_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(500)
                .HasColumnName("status");
            entity.Property(e => e.SyncCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("syncCategory");
            entity.Property(e => e.SyncDtae)
                .HasColumnType("datetime")
                .HasColumnName("syncDtae");
        });

        modelBuilder.Entity<RntChnlHomeAwayAcceptedPaymentFormTbl>(entity =>
        {
            entity.HasKey(e => new { e.PaymentFormType, e.CardCode, e.CardType });

            entity.ToTable("RntChnlHomeAwayAcceptedPaymentFormTBL");

            entity.Property(e => e.PaymentFormType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paymentFormType");
            entity.Property(e => e.CardCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardCode");
            entity.Property(e => e.CardType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cardType");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<RntChnlHomeAwayEstateFeaturesRl>(entity =>
        {
            entity.HasKey(e => new { e.PidEstate, e.Type, e.Code });

            entity.ToTable("RntChnlHomeAwayEstateFeaturesRL");

            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Count).HasColumnName("count");
        });

        modelBuilder.Entity<RntChnlHomeAwayLkFeatureValuesTbl>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.Type });

            entity.ToTable("RntChnlHomeAwayLkFeatureValuesTBL");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.RefId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("refId");
            entity.Property(e => e.RefType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("refType");
            entity.Property(e => e.SubType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("subType");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<RntEmailRecipientLn>(entity =>
        {
            entity.HasKey(e => new { e.PidRecipient, e.PidLang });

            entity.ToTable("RntEmailRecipientLN");

            entity.Property(e => e.PidRecipient).HasColumnName("pidRecipient");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<RntEmailRecipientTb>(entity =>
        {
            entity.ToTable("RntEmailRecipientTB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
        });

        modelBuilder.Entity<RntEstateAvailabilityRl>(entity =>
        {
            entity.HasKey(e => new { e.PidEstate, e.AvailDate });

            entity.ToTable("RntEstateAvailabilityRL");

            entity.HasIndex(e => new { e.AvailDate, e.Availability, e.PidEstate }, "IX_RntEstateAvailabilityRL_availDate_availability_pidEstate");

            entity.HasIndex(e => new { e.PidEstate, e.AvailDate }, "IX_rntestateavailabilityrl_pidestate_availdate");

            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.AvailDate)
                .HasColumnType("datetime")
                .HasColumnName("availDate");
            entity.Property(e => e.Availability).HasColumnName("availability");
        });

        modelBuilder.Entity<RntEstateCategoryTb>(entity =>
        {
            entity.ToTable("RntEstateCategoryTB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ImgBanner)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgBanner");
            entity.Property(e => e.ImgPreview)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgPreview");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgThumb");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<RntEstateExtrasLn>(entity =>
        {
            entity.HasKey(e => new { e.PidEstateExtras, e.PidLang });

            entity.ToTable("RntEstateExtrasLN");

            entity.Property(e => e.PidEstateExtras).HasColumnName("pidEstateExtras");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.IdNew)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_new");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(500)
                .HasColumnName("metaDescription");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(100)
                .HasColumnName("metaTitle");
            entity.Property(e => e.PagePath)
                .HasMaxLength(500)
                .HasColumnName("pagePath");
            entity.Property(e => e.Sommario)
                .HasColumnType("ntext")
                .HasColumnName("sommario");
            entity.Property(e => e.SubTitle)
                .HasMaxLength(200)
                .HasColumnName("subTitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
        });

        modelBuilder.Entity<RntEstateExtrasView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RntEstateExtrasVIEW");

            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.HasDistance).HasColumnName("hasDistance");
            entity.Property(e => e.HasPeriodLimits).HasColumnName("hasPeriodLimits");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImgPreview)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgPreview");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgThumb");
            entity.Property(e => e.InnerCategory).HasColumnName("innerCategory");
            entity.Property(e => e.InnerNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("innerNotes");
            entity.Property(e => e.InnerType).HasColumnName("innerType");
            entity.Property(e => e.IsForAllApartment).HasColumnName("isForAllApartment");
            entity.Property(e => e.IsImportant).HasColumnName("isImportant");
            entity.Property(e => e.IsInFilters).HasColumnName("isInFilters");
            entity.Property(e => e.IsInInvoice).HasColumnName("isInInvoice");
            entity.Property(e => e.IsInResArea).HasColumnName("isInResArea");
            entity.Property(e => e.IsInstantPayment).HasColumnName("isInstantPayment");
            entity.Property(e => e.IsRequired).HasColumnName("isRequired");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(500)
                .HasColumnName("metaDescription");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(100)
                .HasColumnName("metaTitle");
            entity.Property(e => e.PagePath)
                .HasMaxLength(500)
                .HasColumnName("pagePath");
            entity.Property(e => e.PidCategory).HasColumnName("pidCategory");
            entity.Property(e => e.PidCity).HasColumnName("pidCity");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.PidMacroCategory).HasColumnName("pidMacroCategory");
            entity.Property(e => e.PidOwner).HasColumnName("pidOwner");
            entity.Property(e => e.PidSubCategory).HasColumnName("pidSubCategory");
            entity.Property(e => e.PriceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceAmount");
            entity.Property(e => e.PriceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("priceType");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Sommario)
                .HasColumnType("ntext")
                .HasColumnName("sommario");
            entity.Property(e => e.SubTitle)
                .HasMaxLength(200)
                .HasColumnName("subTitle");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<RntEstatePriceV4datesTbl>(entity =>
        {
            entity.HasKey(e => new { e.PidEstate, e.PidSeasonDate });

            entity.ToTable("RntEstatePriceV4DatesTBL");

            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PidSeasonDate).HasColumnName("pidSeasonDate");
            entity.Property(e => e.InDay1)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_1")
                .HasColumnName("inDay_1");
            entity.Property(e => e.InDay2)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_2")
                .HasColumnName("inDay_2");
            entity.Property(e => e.InDay3)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_3")
                .HasColumnName("inDay_3");
            entity.Property(e => e.InDay4)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_4")
                .HasColumnName("inDay_4");
            entity.Property(e => e.InDay5)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_5")
                .HasColumnName("inDay_5");
            entity.Property(e => e.InDay6)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_6")
                .HasColumnName("inDay_6");
            entity.Property(e => e.InDay7)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_7")
                .HasColumnName("inDay_7");
            entity.Property(e => e.NightsMax).HasColumnName("nightsMax");
            entity.Property(e => e.NightsMin).HasColumnName("nightsMin");
            entity.Property(e => e.OutDay1)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_11")
                .HasColumnName("outDay_1");
            entity.Property(e => e.OutDay2)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_21")
                .HasColumnName("outDay_2");
            entity.Property(e => e.OutDay3)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_31")
                .HasColumnName("outDay_3");
            entity.Property(e => e.OutDay4)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_41")
                .HasColumnName("outDay_4");
            entity.Property(e => e.OutDay5)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_51")
                .HasColumnName("outDay_5");
            entity.Property(e => e.OutDay6)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_61")
                .HasColumnName("outDay_6");
            entity.Property(e => e.OutDay7)
                .HasDefaultValue(true, "DF_RntEstatePriceV4DatesTBL_inDay_71")
                .HasColumnName("outDay_7");
            entity.Property(e => e.PrMargine)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prMargine");
            entity.Property(e => e.PrMargineVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prMargineVat");
            entity.Property(e => e.PriceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceAmount");
            entity.Property(e => e.PriceOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceOwner");
            entity.Property(e => e.PromoList)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_RntEstatePriceV4DatesTBL_promoList")
                .HasColumnName("promoList");
        });

        modelBuilder.Entity<RntEstatePriceV4datesTblchannel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RntEstatePriceV4DatesTBL_1");

            entity.ToTable("RntEstatePriceV4DatesTBLChannel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtEnd)
                .HasColumnType("datetime")
                .HasColumnName("dtEnd");
            entity.Property(e => e.DtStart)
                .HasColumnType("datetime")
                .HasColumnName("dtStart");
            entity.Property(e => e.IsClosed).HasDefaultValue(0);
            entity.Property(e => e.NightsMax).HasColumnName("nightsMax");
            entity.Property(e => e.NightsMin).HasColumnName("nightsMin");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PrMargine)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prMargine");
            entity.Property(e => e.PrMargineVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prMargineVat");
            entity.Property(e => e.PriceAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceAmount");
            entity.Property(e => e.PriceOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceOwner");
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RatePlanID");
        });

        modelBuilder.Entity<RntEstatePriceV4tbl>(entity =>
        {
            entity.ToTable("RntEstatePriceV4TBL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PidEstate).HasColumnName("pidEstate");
            entity.Property(e => e.PriceForExtraPerson)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("priceForExtraPerson");
        });

        modelBuilder.Entity<RntExtrasCategoryTb>(entity =>
        {
            entity.ToTable("RntExtrasCategoryTB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ImgPreview)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgPreview");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("imgThumb");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
        });

        modelBuilder.Entity<RntGathernRequestLog>(entity =>
        {
            entity.HasKey(e => e.Uid);

            entity.ToTable("RntGathernRequestLOG");

            entity.Property(e => e.Uid)
                .HasDefaultValueSql("(newid())", "DF_RntGathernRequestLOGuid")
                .HasColumnName("uid");
            entity.Property(e => e.LogDateTime)
                .HasColumnType("datetime")
                .HasColumnName("logDateTime");
            entity.Property(e => e.RequesUrl).HasColumnName("requesUrl");
            entity.Property(e => e.RequestComments).HasColumnName("requestComments");
            entity.Property(e => e.RequestContent)
                .HasColumnType("ntext")
                .HasColumnName("requestContent");
            entity.Property(e => e.RequestType).HasColumnName("requestType");
            entity.Property(e => e.ResponseContent)
                .HasColumnType("ntext")
                .HasColumnName("responseContent");
        });

        modelBuilder.Entity<RntGuestyHotelTbl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_[RntGuestyHotelTbl");

            entity.ToTable("RntGuestyHotelTbl");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.GoogleMaps)
                .HasMaxLength(200)
                .HasColumnName("google_maps");
            entity.Property(e => e.HotelCategorycode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HotelCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HotelName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.LocPhysicalAddress)
                .HasMaxLength(300)
                .HasColumnName("locPhysicalAddress");
            entity.Property(e => e.LocZipCode).HasMaxLength(200);
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PidEstateId).HasColumnName("pidEstateId");
            entity.Property(e => e.Ruid)
                .IsUnicode(false)
                .HasColumnName("RUID");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<RntLnEstate>(entity =>
        {
            entity.HasKey(e => new { e.PidEstate, e.PidLang });

            entity.ToTable("RNT_LN_ESTATE");

            entity.Property(e => e.PidEstate).HasColumnName("pid_estate");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pid_lang");
            entity.Property(e => e.AboutPropertyDescription).HasColumnName("aboutPropertyDescription");
            entity.Property(e => e.DependenceDescription).HasColumnName("dependenceDescription");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.FeaturesDescription)
                .HasMaxLength(500)
                .HasColumnName("featuresDescription");
            entity.Property(e => e.GardenDescription).HasColumnName("gardenDescription");
            entity.Property(e => e.LocationDescription).HasColumnName("locationDescription");
            entity.Property(e => e.MetaDescription).HasColumnName("meta_description");
            entity.Property(e => e.MetaKeywords).HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle).HasColumnName("meta_title");
            entity.Property(e => e.NbhDescription).HasColumnName("nbh_description");
            entity.Property(e => e.NbhMetaDescription).HasColumnName("nbh_meta_description");
            entity.Property(e => e.NbhMetaKeywords).HasColumnName("nbh_meta_keywords");
            entity.Property(e => e.NbhMetaTitle).HasColumnName("nbh_meta_title");
            entity.Property(e => e.NbhOldPagePath).HasColumnName("nbh_oldPagePath");
            entity.Property(e => e.NbhPagePath).HasColumnName("nbh_page_path");
            entity.Property(e => e.NotesVoucher).HasColumnName("notesVoucher");
            entity.Property(e => e.OldPagePath).HasColumnName("oldPagePath");
            entity.Property(e => e.PagePath).HasColumnName("page_path");
            entity.Property(e => e.ParkingDescription).HasColumnName("parkingDescription");
            entity.Property(e => e.SrsMeetinPointDesc).HasColumnName("srs_MeetinPointDesc");
            entity.Property(e => e.SubTitle).HasColumnName("sub_title");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.TerraceDescription).HasColumnName("terraceDescription");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.VillaDiretionsDescription).HasColumnName("villaDiretionsDescription");
        });

        modelBuilder.Entity<RntRequestTemplateLn>(entity =>
        {
            entity.HasKey(e => new { e.PidTemplate, e.PidLang });

            entity.ToTable("RntRequestTemplateLN");

            entity.Property(e => e.PidTemplate).HasColumnName("pidTemplate");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.Body)
                .HasColumnType("ntext")
                .HasColumnName("body");
            entity.Property(e => e.Subject)
                .HasColumnType("ntext")
                .HasColumnName("subject");
        });

        modelBuilder.Entity<RntRequestTemplateTb>(entity =>
        {
            entity.ToTable("RntRequestTemplateTB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Filename).HasColumnName("filename");
            entity.Property(e => e.InnerNotes)
                .HasMaxLength(100)
                .HasColumnName("inner_notes");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsAutomatic).HasColumnName("is_automatic");
            entity.Property(e => e.IsBefore).HasColumnName("is_before");
            entity.Property(e => e.IsForRequest).HasColumnName("is_for_request");
            entity.Property(e => e.IsForReservation).HasColumnName("is_for_reservation");
            entity.Property(e => e.NumTime).HasColumnName("num_time");
            entity.Property(e => e.PidEvent).HasColumnName("pidEvent");
            entity.Property(e => e.PidRecipient).HasColumnName("pidRecipient");
            entity.Property(e => e.PidUser).HasColumnName("pid_user");
            entity.Property(e => e.Recipient).HasColumnName("recipient");
            entity.Property(e => e.ReplaceNotes)
                .HasColumnType("ntext")
                .HasColumnName("replace_notes");
            entity.Property(e => e.TimeType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("timeType");
        });

        modelBuilder.Entity<RntRequestTemplateView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RntRequestTemplateVIEW");

            entity.Property(e => e.Body)
                .HasColumnType("ntext")
                .HasColumnName("body");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.Filename).HasColumnName("filename");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InnerNotes)
                .HasMaxLength(100)
                .HasColumnName("inner_notes");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsAutomatic).HasColumnName("is_automatic");
            entity.Property(e => e.IsBefore).HasColumnName("is_before");
            entity.Property(e => e.IsForRequest).HasColumnName("is_for_request");
            entity.Property(e => e.IsForReservation).HasColumnName("is_for_reservation");
            entity.Property(e => e.NumTime).HasColumnName("num_time");
            entity.Property(e => e.PidEvent).HasColumnName("pidEvent");
            entity.Property(e => e.PidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("pidLang");
            entity.Property(e => e.PidRecipient).HasColumnName("pidRecipient");
            entity.Property(e => e.PidUser).HasColumnName("pid_user");
            entity.Property(e => e.ReplaceNotes)
                .HasColumnType("ntext")
                .HasColumnName("replace_notes");
            entity.Property(e => e.Subject)
                .HasColumnType("ntext")
                .HasColumnName("subject");
            entity.Property(e => e.TimeType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("timeType");
        });

        modelBuilder.Entity<RntRlEstateMedium>(entity =>
        {
            entity.ToTable("RNT_RL_ESTATE_MEDIA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.ImageTitle).HasColumnName("image_title");
            entity.Property(e => e.ImgBanner)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_banner");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_thumb");
            entity.Property(e => e.PidCode).HasColumnName("pid_code");
            entity.Property(e => e.PidEstate).HasColumnName("pid_estate");
            entity.Property(e => e.PidRoomorama).HasColumnName("pid_roomorama");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.VideoEmbed)
                .HasColumnType("ntext")
                .HasColumnName("video_embed");
            entity.Property(e => e.VideoPath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("video_path");
        });

        modelBuilder.Entity<RntSeasonDatesTbl>(entity =>
        {
            entity.ToTable("RntSeasonDatesTBL");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DtEnd)
                .HasColumnType("datetime")
                .HasColumnName("dtEnd");
            entity.Property(e => e.DtStart)
                .HasColumnType("datetime")
                .HasColumnName("dtStart");
            entity.Property(e => e.Uid).HasColumnName("uid");
        });

        modelBuilder.Entity<RntTbEstate>(entity =>
        {
            entity.ToTable("RNT_TB_ESTATE");

            entity.HasIndex(e => new { e.ComplexId, e.IsSingleRoom }, "IDX_RNT_TB_ESTATE_ComplexId_IsSingleRoom");

            entity.HasIndex(e => new { e.ComplexId, e.PidAgent }, "IDX_RNT_TB_ESTATE_ComplexId_pid_agent");

            entity.HasIndex(e => new { e.ComplexId, e.PidAgent }, "IDX_RNT_TB_ESTATE_ComplexId_pid_agent_SignleRoomName");

            entity.HasIndex(e => new { e.Id, e.ComplexId }, "IDX_RNT_TB_ESTATE_id_ComplexId");

            entity.HasIndex(e => new { e.IsApt, e.ProjectId, e.Ispms }, "IDX_isApt_ProjectID_ISPMS");

            entity.HasIndex(e => new { e.Id, e.ComplexId }, "IDX_rntestateavailabilityrl_pidestate_availdate");

            entity.HasIndex(e => new { e.ComplexId, e.IsSingleRoom, e.Code }, "IX_RNT_TB_ESTATE_ComplexId_IsSingleRoom_Code");

            entity.HasIndex(e => new { e.ComplexId, e.PidAgent }, "IX_RNT_TB_ESTATE_ComplexId_pid_agent");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaseAvailability)
                .HasDefaultValue(1, "DF_RNT_TB_ESTATE_baseAvailability")
                .HasColumnName("baseAvailability");
            entity.Property(e => e.BasePrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("basePrice");
            entity.Property(e => e.BcomEnabled).HasColumnName("bcomEnabled");
            entity.Property(e => e.BcomHotelId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcomHotelId");
            entity.Property(e => e.BcomName).HasColumnName("bcomName");
            entity.Property(e => e.BcomRoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcomRoomId");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.ChangeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("changeAmount");
            entity.Property(e => e.ChangeIsDiscount).HasColumnName("changeIsDiscount");
            entity.Property(e => e.ChangeIsPercentage).HasColumnName("changeIsPercentage");
            entity.Property(e => e.ChnlMpropertyId)
                .HasMaxLength(100)
                .HasColumnName("chnlMPropertyId");
            entity.Property(e => e.ChnlMpropertyName).HasColumnName("chnlMPropertyName");
            entity.Property(e => e.ChnlMsourceId)
                .HasMaxLength(100)
                .HasColumnName("chnlMSourceId");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ComplexType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("", "DF_RNT_TB_ESTATE_ComplexType");
            entity.Property(e => e.DefCheckIn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Def_CheckIn");
            entity.Property(e => e.DefCheckOut)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Def_CheckOut");
            entity.Property(e => e.DtCreation)
                .HasColumnType("datetime")
                .HasColumnName("dtCreation");
            entity.Property(e => e.EcoExtClientPay).HasColumnName("eco_ext_clientPay");
            entity.Property(e => e.EcoExtEmail)
                .HasMaxLength(200)
                .HasColumnName("eco_ext_email");
            entity.Property(e => e.EcoExtNameFull)
                .HasMaxLength(200)
                .HasColumnName("eco_ext_name_full");
            entity.Property(e => e.EcoExtPayInDays).HasColumnName("eco_ext_payInDays");
            entity.Property(e => e.EcoExtPhone)
                .HasMaxLength(200)
                .HasColumnName("eco_ext_phone");
            entity.Property(e => e.EcoExtPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("eco_ext_price");
            entity.Property(e => e.Email1)
                .HasMaxLength(100)
                .HasColumnName("email1");
            entity.Property(e => e.Email2)
                .HasMaxLength(100)
                .HasColumnName("email2");
            entity.Property(e => e.ExtGpsId)
                .HasDefaultValue(0, "DF_RNT_TB_ESTATE_is_deleted1")
                .HasColumnName("ext_gps_id");
            entity.Property(e => e.ExtGpsPidMaga)
                .HasDefaultValue(0, "DF_RNT_TB_ESTATE_ext_id_gps1")
                .HasColumnName("ext_gps_pid_maga");
            entity.Property(e => e.ExtOwnerdaysinyear).HasColumnName("ext_ownerdaysinyear");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.FeatureNote)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("feature_note");
            entity.Property(e => e.FloorUs)
                .HasMaxLength(50)
                .HasColumnName("floorUS");
            entity.Property(e => e.GoogleMaps)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("google_maps");
            entity.Property(e => e.HasPool).HasColumnName("hasPool");
            entity.Property(e => e.ICalUrl).HasColumnName("iCalUrl");
            entity.Property(e => e.ImgBanner)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_banner");
            entity.Property(e => e.ImgPreview1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_preview_1");
            entity.Property(e => e.ImgPreview2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_preview_2");
            entity.Property(e => e.ImgPreview3)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_preview_3");
            entity.Property(e => e.ImgThumb)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_thumb");
            entity.Property(e => e.Importance).HasColumnName("importance");
            entity.Property(e => e.ImportanceCategory)
                .HasMaxLength(50)
                .HasColumnName("importance_category");
            entity.Property(e => e.ImportanceVote).HasColumnName("importance_vote");
            entity.Property(e => e.InAttention).HasColumnName("in_attention");
            entity.Property(e => e.InnerNotes)
                .HasColumnType("ntext")
                .HasColumnName("inner_notes");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsAirbnbImported).HasColumnName("isAirbnbImported");
            entity.Property(e => e.IsApt)
                .HasDefaultValue(0, "DF_RNT_TB_ESTATE_isApt")
                .HasColumnName("isApt");
            entity.Property(e => e.IsBroomUpdate).HasColumnName("is_broom_update");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsEcopulizie).HasColumnName("is_ecopulizie");
            entity.Property(e => e.IsExclusive).HasColumnName("is_exclusive");
            entity.Property(e => e.IsGoogleMaps).HasColumnName("is_google_maps");
            entity.Property(e => e.IsHomeaway).HasColumnName("is_homeaway");
            entity.Property(e => e.IsLoft).HasColumnName("is_loft");
            entity.Property(e => e.IsOnlineBooking).HasColumnName("is_online_booking");
            entity.Property(e => e.IsPercentage).HasColumnName("isPercentage");
            entity.Property(e => e.IsPriceVisible).HasColumnName("is_price_visible");
            entity.Property(e => e.IsPropertyFromOwner).HasColumnName("is_property_from_owner");
            entity.Property(e => e.IsSingleRoom).HasDefaultValue(0);
            entity.Property(e => e.IsSrs).HasColumnName("is_srs");
            entity.Property(e => e.IsStreetView).HasColumnName("is_street_view");
            entity.Property(e => e.IsSwimmingExclusive).HasColumnName("is_swimming_exclusive");
            entity.Property(e => e.Ispms)
                .HasDefaultValue(0)
                .HasColumnName("ISPMS");
            entity.Property(e => e.LmDiscount).HasColumnName("lm_discount");
            entity.Property(e => e.LmInhours).HasColumnName("lm_inhours");
            entity.Property(e => e.LmNightsMax).HasColumnName("lm_nights_max");
            entity.Property(e => e.LmNightsMin).HasColumnName("lm_nights_min");
            entity.Property(e => e.LocAddress)
                .HasMaxLength(500)
                .HasColumnName("loc_address");
            entity.Property(e => e.LocInnerBell)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("loc_inner_bell");
            entity.Property(e => e.LocPhone1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("loc_phone_1");
            entity.Property(e => e.LocPhone2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("loc_phone_2");
            entity.Property(e => e.LocReferer)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("loc_referer");
            entity.Property(e => e.LocZipCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loc_zip_code");
            entity.Property(e => e.LongTermPrMonthly)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("longTermPrMonthly");
            entity.Property(e => e.LongTermRent).HasColumnName("longTermRent");
            entity.Property(e => e.LpbAfterdays).HasColumnName("lpb_afterdays");
            entity.Property(e => e.LpbIs).HasColumnName("lpb_is");
            entity.Property(e => e.LpbNightsMin).HasColumnName("lpb_nights_min");
            entity.Property(e => e.LpbOnlyhighseason).HasColumnName("lpb_onlyhighseason");
            entity.Property(e => e.ManagerId).HasColumnName("managerId");
            entity.Property(e => e.ManagerType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("managerType");
            entity.Property(e => e.MediaFolder)
                .HasMaxLength(500)
                .HasColumnName("media_folder");
            entity.Property(e => e.MediaFolderOriginalPhotos)
                .HasMaxLength(500)
                .HasColumnName("mediaFolderOriginalPhotos");
            entity.Property(e => e.MinResDays).HasColumnName("Min_Res_days");
            entity.Property(e => e.MinResHours).HasColumnName("Min_Res_hours");
            entity.Property(e => e.MqInner)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("mq_inner");
            entity.Property(e => e.MqOuter)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("mq_outer");
            entity.Property(e => e.MqOuterCovered).HasColumnName("mq_outer_covered");
            entity.Property(e => e.MqTerrace)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("mq_terrace");
            entity.Property(e => e.NightsMax).HasColumnName("nights_max");
            entity.Property(e => e.NightsMin).HasColumnName("nights_min");
            entity.Property(e => e.NightsMinVhseason).HasColumnName("nights_minVHSeason");
            entity.Property(e => e.NumBedDouble).HasColumnName("num_bed_double");
            entity.Property(e => e.NumBedDouble2level).HasColumnName("num_bed_double_2level");
            entity.Property(e => e.NumBedDoubleDivisible).HasColumnName("num_bed_double_divisible");
            entity.Property(e => e.NumBedSingle).HasColumnName("num_bed_single");
            entity.Property(e => e.NumCabinets).HasColumnName("num_Cabinets");
            entity.Property(e => e.NumCompleteBath).HasColumnName("num_complete_bath");
            entity.Property(e => e.NumCompleteShower).HasColumnName("num_complete_shower");
            entity.Property(e => e.NumDiningRoom).HasColumnName("num_dining_room");
            entity.Property(e => e.NumKitchen).HasColumnName("num_kitchen");
            entity.Property(e => e.NumOutsideArea).HasColumnName("num_outside_area");
            entity.Property(e => e.NumParkingClosed).HasColumnName("num_parkingClosed");
            entity.Property(e => e.NumParkingOpen).HasColumnName("num_parkingOpen");
            entity.Property(e => e.NumPersonsAdult).HasColumnName("num_persons_adult");
            entity.Property(e => e.NumPersonsChild).HasColumnName("num_persons_child");
            entity.Property(e => e.NumPersonsMax).HasColumnName("num_persons_max");
            entity.Property(e => e.NumPersonsMin).HasColumnName("num_persons_min");
            entity.Property(e => e.NumPersonsOptional).HasColumnName("num_persons_optional");
            entity.Property(e => e.NumPetsMax).HasColumnName("num_pets_max");
            entity.Property(e => e.NumRoomBed120).HasColumnName("num_room_bed120");
            entity.Property(e => e.NumRoomBed140).HasColumnName("num_room_bed140");
            entity.Property(e => e.NumRoomsBath).HasColumnName("num_rooms_bath");
            entity.Property(e => e.NumRoomsBed).HasColumnName("num_rooms_bed");
            entity.Property(e => e.NumRoomsLiving).HasColumnName("num_rooms_living");
            entity.Property(e => e.NumRoomsTotal).HasColumnName("num_rooms_total");
            entity.Property(e => e.NumSalon).HasColumnName("num_Salon");
            entity.Property(e => e.NumServiceIncomplete).HasColumnName("num_service_incomplete");
            entity.Property(e => e.NumSofaDouble).HasColumnName("num_sofa_double");
            entity.Property(e => e.NumSofaSingle).HasColumnName("num_sofa_single");
            entity.Property(e => e.NumSwimmingMc).HasColumnName("num_swimming_mc");
            entity.Property(e => e.NumTerraces).HasColumnName("num_terraces");
            entity.Property(e => e.NumTripleRoom).HasColumnName("num_triple_room");
            entity.Property(e => e.OlDbId).HasColumnName("olDbId");
            entity.Property(e => e.OnFloor).HasColumnName("on_floor");
            entity.Property(e => e.OnFloorOfTotal).HasColumnName("on_floor_of_total");
            entity.Property(e => e.OnLevels).HasColumnName("on_levels");
            entity.Property(e => e.OptionsNote)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("options_note");
            entity.Property(e => e.OwnerContractContent)
                .HasColumnType("ntext")
                .HasColumnName("ownerContractContent");
            entity.Property(e => e.OwnerContractDate)
                .HasColumnType("datetime")
                .HasColumnName("ownerContractDate");
            entity.Property(e => e.OwnerContractDurationMonths).HasColumnName("ownerContractDurationMonths");
            entity.Property(e => e.OwnerContractExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("ownerContractExpiryDate");
            entity.Property(e => e.OwnerContractFile).HasColumnName("owner_contract_file");
            entity.Property(e => e.OwnerContractHasBiancheria).HasColumnName("ownerContract_hasBiancheria");
            entity.Property(e => e.OwnerContractHasFinalCleaning).HasColumnName("ownerContract_hasFinalCleaning");
            entity.Property(e => e.OwnerContractHasWelcomeService).HasColumnName("ownerContract_hasWelcomeService");
            entity.Property(e => e.OwnerContractOwnerPriceCalculatedOn).HasColumnName("ownerContract_ownerPriceCalculatedOn");
            entity.Property(e => e.OwnerContractPlace)
                .HasMaxLength(200)
                .HasColumnName("ownerContractPlace");
            entity.Property(e => e.OwnerContractPriceCommission)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ownerContractPrice_commission");
            entity.Property(e => e.OwnerContractPriceCommissionOnNet).HasColumnName("ownerContractPrice_commissionOnNet");
            entity.Property(e => e.OwnerContractPriceDaily)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ownerContractPrice_daily");
            entity.Property(e => e.OwnerContractPriceMonthlyCost)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ownerContractPrice_monthlyCost");
            entity.Property(e => e.OwnerContractPriceMonthlyFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ownerContractPrice_monthlyFee");
            entity.Property(e => e.OwnerContractStartDate)
                .HasColumnType("datetime")
                .HasColumnName("ownerContractStartDate");
            entity.Property(e => e.OwnerContractType).HasColumnName("ownerContractType");
            entity.Property(e => e.PidAgent).HasColumnName("pid_agent");
            entity.Property(e => e.PidCategory).HasColumnName("pid_category");
            entity.Property(e => e.PidCity).HasColumnName("pid_city");
            entity.Property(e => e.PidCountry).HasColumnName("pid_country");
            entity.Property(e => e.PidKitchentype).HasColumnName("pid_kitchentype");
            entity.Property(e => e.PidMacroarea).HasColumnName("pid_macroarea");
            entity.Property(e => e.PidOwner).HasColumnName("pid_owner");
            entity.Property(e => e.PidRegion).HasColumnName("pid_region");
            entity.Property(e => e.PidResidence).HasColumnName("pid_residence");
            entity.Property(e => e.PidSeasonGroup).HasColumnName("pidSeasonGroup");
            entity.Property(e => e.PidSetting).HasColumnName("pid_setting");
            entity.Property(e => e.PidStyle).HasColumnName("pid_style");
            entity.Property(e => e.PidType).HasColumnName("pid_type");
            entity.Property(e => e.PidZone).HasColumnName("pid_zone");
            entity.Property(e => e.PoliceRegId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PoliceRegID");
            entity.Property(e => e.PrAgencyFee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pr_agencyFee");
            entity.Property(e => e.PrDeposit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("pr_deposit");
            entity.Property(e => e.PrDepositDaysToCheck).HasColumnName("pr_deposit_days_to_check");
            entity.Property(e => e.PrDepositMax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_deposit_max");
            entity.Property(e => e.PrDepositWithCard).HasColumnName("pr_depositWithCard");
            entity.Property(e => e.PrHasOvernightTax).HasColumnName("pr_has_overnight_tax");
            entity.Property(e => e.PrPercentage).HasColumnName("pr_percentage");
            entity.Property(e => e.PrStartDate)
                .HasColumnType("datetime")
                .HasColumnName("pr_startDate");
            entity.Property(e => e.PrTableViewType).HasColumnName("pr_tableViewType");
            entity.Property(e => e.PriceVersion)
                .HasDefaultValue(4, "DF_RNT_TB_ESTATE_priceVersion")
                .HasColumnName("priceVersion");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(25)
                .HasColumnName("registrationNumber");
            entity.Property(e => e.Sequence)
                .HasDefaultValue(1, "DF_RNT_TB_ESTATE_sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.SignleRoomName).HasMaxLength(100);
            entity.Property(e => e.SqFeet).HasColumnName("sqFeet");
            entity.Property(e => e.SrsExtClientPay).HasColumnName("srs_ext_clientPay");
            entity.Property(e => e.SrsExtEmail)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_email");
            entity.Property(e => e.SrsExtMeetingPoint)
                .HasMaxLength(2000)
                .HasColumnName("srs_ext_meetingPoint");
            entity.Property(e => e.SrsExtNameFull)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_name_full");
            entity.Property(e => e.SrsExtPhone)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_phone");
            entity.Property(e => e.SrsExtPhone2)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_phone_2");
            entity.Property(e => e.SrsExtPhone3)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_phone_3");
            entity.Property(e => e.SrsExtPhone4)
                .HasMaxLength(200)
                .HasColumnName("srs_ext_phone_4");
            entity.Property(e => e.SrsExtPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("srs_ext_price");
            entity.Property(e => e.SvCoords)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("sv_coords");
            entity.Property(e => e.SvPitch)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("sv_pitch");
            entity.Property(e => e.SvYaw)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("sv_yaw");
            entity.Property(e => e.SvZoom)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("sv_zoom");
            entity.Property(e => e.TripadvisorRating).HasColumnName("tripadvisor_rating");
            entity.Property(e => e.UniqueId).HasColumnName("unique_id");
        });

        modelBuilder.Entity<RntTblExtraReservation>(entity =>
        {
            entity.HasKey(e => new { e.PidReservation, e.PidExtra });

            entity.ToTable("RNT_TBL_EXTRA_RESERVATION");

            entity.Property(e => e.PidReservation).HasColumnName("pidReservation");
            entity.Property(e => e.PidExtra).HasColumnName("pidExtra");
            entity.Property(e => e.IsIncluded).HasColumnName("isIncluded");
            entity.Property(e => e.IsPerNight).HasColumnName("IsPer_night");
            entity.Property(e => e.IsPerPerson).HasColumnName("IsPer_person");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<RntTblReservation>(entity =>
        {
            entity.ToTable("RNT_TBL_RESERVATION");

            entity.HasIndex(e => e.BcomResId, "IX_Reservation_bcomResId");

            entity.HasIndex(e => e.DtCreation, "IX_Reservation_dtCreation").IsDescending();

            entity.HasIndex(e => e.StateDate, "IX_Reservation_state_date").IsDescending();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgentClientId).HasColumnName("agentClientID");
            entity.Property(e => e.AgentCommissionNotInTotal).HasColumnName("agentCommissionNotInTotal");
            entity.Property(e => e.AgentCommissionPerc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("agentCommissionPerc");
            entity.Property(e => e.AgentCommissionPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("agentCommissionPrice");
            entity.Property(e => e.AgentId).HasColumnName("agentID");
            entity.Property(e => e.AirbnbPenaltyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("airbnbPenaltyFee");
            entity.Property(e => e.AirbnbReason)
                .HasMaxLength(500)
                .HasColumnName("airbnbReason");
            entity.Property(e => e.AirbnbSubReason)
                .HasMaxLength(500)
                .HasColumnName("airbnbSubReason");
            entity.Property(e => e.BcomCancel).HasColumnName("bcom_cancel");
            entity.Property(e => e.BcomCancelcharge)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bcom_cancelcharge");
            entity.Property(e => e.BcomCommissionamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bcom_commissionamount");
            entity.Property(e => e.BcomCountryCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bcom_country_code");
            entity.Property(e => e.BcomCurrencycode)
                .HasMaxLength(50)
                .HasColumnName("bcom_currencycode");
            entity.Property(e => e.BcomExtrainfo).HasColumnName("bcom_extrainfo");
            entity.Property(e => e.BcomFacilities).HasColumnName("bcom_facilities");
            entity.Property(e => e.BcomGuestName)
                .HasMaxLength(200)
                .HasColumnName("bcom_guest_name");
            entity.Property(e => e.BcomInfo).HasColumnName("bcom_info");
            entity.Property(e => e.BcomLoyalityid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcom_loyalityid");
            entity.Property(e => e.BcomMaxChidren).HasColumnName("bcom_maxChidren");
            entity.Property(e => e.BcomMealplan).HasColumnName("bcom_mealplan");
            entity.Property(e => e.BcomNote).HasColumnName("bcom_note");
            entity.Property(e => e.BcomPidParentBooking).HasColumnName("bcom_pid_parent_booking");
            entity.Property(e => e.BcomRateName)
                .HasMaxLength(200)
                .HasColumnName("bcom_rateName");
            entity.Property(e => e.BcomRateid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcom_rateid");
            entity.Property(e => e.BcomResId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcom_resId");
            entity.Property(e => e.BcomRoomPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bcom_room_price");
            entity.Property(e => e.BcomRoomRemarks).HasColumnName("bcom_room_remarks");
            entity.Property(e => e.BcomRoomResId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcom_roomResId");
            entity.Property(e => e.BcomSmoking)
                .HasMaxLength(50)
                .HasColumnName("bcom_smoking");
            entity.Property(e => e.BcomStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bcom_status");
            entity.Property(e => e.BcomTotalForOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bcom_totalForOwner");
            entity.Property(e => e.BedDouble).HasColumnName("bedDouble");
            entity.Property(e => e.BedDouble2level).HasColumnName("bedDouble2level");
            entity.Property(e => e.BedDouble2levelConfig)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bedDouble2levelConfig");
            entity.Property(e => e.BedDoubleD).HasColumnName("bedDoubleD");
            entity.Property(e => e.BedDoubleDconfig).HasColumnName("bedDoubleDConfig");
            entity.Property(e => e.BedSingle).HasColumnName("bedSingle");
            entity.Property(e => e.BedSofaDouble).HasColumnName("bedSofaDouble");
            entity.Property(e => e.BedSofaSingle).HasColumnName("bedSofaSingle");
            entity.Property(e => e.BlockComments)
                .HasColumnType("ntext")
                .HasColumnName("block_comments");
            entity.Property(e => e.BlockExpire)
                .HasColumnType("datetime")
                .HasColumnName("block_expire");
            entity.Property(e => e.BlockExpireHours).HasColumnName("block_expire_hours");
            entity.Property(e => e.BlockPidUser).HasColumnName("block_pid_user");
            entity.Property(e => e.CcFees)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ccFees");
            entity.Property(e => e.CcFeesPercent)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ccFeesPercent");
            entity.Property(e => e.CedolareSecca)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cedolareSecca");
            entity.Property(e => e.CheckInCheckOutNotes)
                .HasColumnType("ntext")
                .HasColumnName("checkInCheckOutNotes");
            entity.Property(e => e.ChnlKigoResId).HasColumnName("chnl_kigo_res_id");
            entity.Property(e => e.ChnlMpropertyId)
                .HasMaxLength(100)
                .HasColumnName("chnlMPropertyId");
            entity.Property(e => e.ChnlMreservationCode)
                .HasMaxLength(100)
                .HasColumnName("chnlMReservationCode");
            entity.Property(e => e.ChnlMreservationLoading)
                .HasColumnType("datetime")
                .HasColumnName("chnlMReservationLoading");
            entity.Property(e => e.ChnlMsourceId)
                .HasMaxLength(100)
                .HasColumnName("chnlMSourceId");
            entity.Property(e => e.ChnlRateData).HasColumnName("chnl_rateData");
            entity.Property(e => e.ChnlRemarks).HasColumnName("chnl_remarks");
            entity.Property(e => e.ChnlRoomoramaResId).HasColumnName("chnl_roomorama_res_id");
            entity.Property(e => e.ClBrowserInfo)
                .HasColumnType("ntext")
                .HasColumnName("cl_browserInfo");
            entity.Property(e => e.ClBrowserIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cl_browserIP");
            entity.Property(e => e.ClEmail)
                .HasMaxLength(100)
                .HasColumnName("cl_email");
            entity.Property(e => e.ClGuestdataCompleted).HasColumnName("cl_guestdata_completed");
            entity.Property(e => e.ClId).HasColumnName("cl_id");
            entity.Property(e => e.ClIsCompleted).HasColumnName("cl_isCompleted");
            entity.Property(e => e.ClLocCountry)
                .HasMaxLength(100)
                .HasColumnName("cl_loc_country");
            entity.Property(e => e.ClNameFull)
                .HasMaxLength(200)
                .HasColumnName("cl_name_full");
            entity.Property(e => e.ClNameHonorific)
                .HasMaxLength(50)
                .HasColumnName("cl_name_honorific");
            entity.Property(e => e.ClPidDiscount).HasColumnName("cl_pid_discount");
            entity.Property(e => e.ClPidLang)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cl_pid_lang");
            entity.Property(e => e.ClReminderCount).HasColumnName("cl_reminderCount");
            entity.Property(e => e.ClReminderFullPaymentCount).HasColumnName("cl_reminderFullPaymentCount");
            entity.Property(e => e.ClReminderFullPaymentLast)
                .HasColumnType("datetime")
                .HasColumnName("cl_reminderFullPaymentLast");
            entity.Property(e => e.ClReminderFullPaymentSent).HasColumnName("cl_reminderFullPaymentSent");
            entity.Property(e => e.ClReminderLast)
                .HasColumnType("datetime")
                .HasColumnName("cl_reminderLast");
            entity.Property(e => e.ClReminderNext)
                .HasColumnType("datetime")
                .HasColumnName("cl_reminderNext");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("code");
            entity.Property(e => e.ConversionRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("conversionRate");
            entity.Property(e => e.ConversionScriptsShown)
                .HasDefaultValue(1, "DF_RNT_TBL_RESERVATION_conversionScriptsShown")
                .HasColumnName("conversionScriptsShown");
            entity.Property(e => e.CreatorHost).HasColumnName("creatorHost");
            entity.Property(e => e.DeliveredDate).HasColumnType("datetime");
            entity.Property(e => e.DtCreation)
                .HasColumnType("datetime")
                .HasColumnName("dtCreation");
            entity.Property(e => e.DtEnd)
                .HasColumnType("datetime")
                .HasColumnName("dtEnd");
            entity.Property(e => e.DtEndTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((110000))", "DF_RNT_TBL_RESERVATION_dtEndTime")
                .HasColumnName("dtEndTime");
            entity.Property(e => e.DtIn)
                .HasColumnType("datetime")
                .HasColumnName("dtIn");
            entity.Property(e => e.DtOut)
                .HasColumnType("datetime")
                .HasColumnName("dtOut");
            entity.Property(e => e.DtStart)
                .HasColumnType("datetime")
                .HasColumnName("dtStart");
            entity.Property(e => e.DtStartTime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((140000))", "DF_RNT_TBL_RESERVATION_dtStartTime")
                .HasColumnName("dtStartTime");
            entity.Property(e => e.FloorUs)
                .HasMaxLength(50)
                .HasColumnName("floorUS");
            entity.Property(e => e.HastateCancelledBy).HasColumnName("HAstateCancelledBy");
            entity.Property(e => e.IcalName)
                .HasMaxLength(200)
                .HasColumnName("ical_name");
            entity.Property(e => e.IclUniqueId).HasColumnName("iclUniqueId");
            entity.Property(e => e.IdAdMedia).HasMaxLength(100);
            entity.Property(e => e.IdLastOperator).HasMaxLength(100);
            entity.Property(e => e.IdLink).HasMaxLength(100);
            entity.Property(e => e.InvDocCfNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inv_doc_cf_num");
            entity.Property(e => e.InvDocVatNum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("inv_doc_vat_num");
            entity.Property(e => e.InvIsDifferent).HasColumnName("inv_isDifferent");
            entity.Property(e => e.InvLocAddress)
                .HasMaxLength(500)
                .HasColumnName("inv_loc_address");
            entity.Property(e => e.InvLocCity)
                .HasMaxLength(50)
                .HasColumnName("inv_loc_city");
            entity.Property(e => e.InvLocCountry)
                .HasMaxLength(100)
                .HasColumnName("inv_loc_country");
            entity.Property(e => e.InvLocState)
                .HasMaxLength(50)
                .HasColumnName("inv_loc_state");
            entity.Property(e => e.InvLocZipCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("inv_loc_zip_code");
            entity.Property(e => e.InvNameFull)
                .HasMaxLength(200)
                .HasColumnName("inv_name_full");
            entity.Property(e => e.InvNameHonorific)
                .HasMaxLength(50)
                .HasColumnName("inv_name_honorific");
            entity.Property(e => e.InvToCreate)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_is_booking1")
                .HasColumnName("inv_toCreate");
            entity.Property(e => e.IsBooking)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_is_deleted1")
                .HasColumnName("is_booking");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_is_deleted")
                .HasColumnName("is_deleted");
            entity.Property(e => e.IsDtEndTimeChanged).HasColumnName("is_dtEndTimeChanged");
            entity.Property(e => e.IsDtStartTimeChanged).HasColumnName("is_dtStartTimeChanged");
            entity.Property(e => e.IsFeedComplate)
                .HasDefaultValue(0, "DF_RNT_TBL_isFeedComplate")
                .HasColumnName("isFeedComplate");
            entity.Property(e => e.IsFirstPaymentFail).HasColumnName("isFirstPaymentFail");
            entity.Property(e => e.IsFreeArrivalDay).HasColumnName("isFreeArrivalDay");
            entity.Property(e => e.IsFreeMinStay).HasColumnName("isFreeMinStay");
            entity.Property(e => e.IsFullpaid).HasColumnName("isFullpaid");
            entity.Property(e => e.IsImported).HasColumnName("isImported");
            entity.Property(e => e.IsPaidMaga).HasColumnName("isPaidMaga");
            entity.Property(e => e.IsRequest).HasColumnName("isRequest");
            entity.Property(e => e.IsRevenueOfferDiscount).HasColumnName("isRevenueOfferDiscount");
            entity.Property(e => e.IsRoomRamaConfirmed).HasColumnName("isRoomRamaConfirmed");
            entity.Property(e => e.LimoEasyShuttleId).HasColumnName("limo_easyShuttleID");
            entity.Property(e => e.LimoEasyShuttleInUid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("limo_easyShuttleInUID");
            entity.Property(e => e.LimoEasyShuttleOutUid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("limo_easyShuttleOutUID");
            entity.Property(e => e.LimoInDatetime)
                .HasColumnType("datetime")
                .HasColumnName("limo_in_datetime");
            entity.Property(e => e.LimoInIsRequested).HasColumnName("limo_in_isRequested");
            entity.Property(e => e.LimoInPointDetails)
                .HasMaxLength(500)
                .HasColumnName("limo_inPoint_details");
            entity.Property(e => e.LimoInPointDetailsType).HasColumnName("limo_inPoint_detailsType");
            entity.Property(e => e.LimoInPointPickupPlace).HasColumnName("limo_inPoint_pickupPlace");
            entity.Property(e => e.LimoInPointPickupPlaceName)
                .HasMaxLength(500)
                .HasColumnName("limo_inPoint_pickupPlaceName");
            entity.Property(e => e.LimoInPointTransportType)
                .HasMaxLength(500)
                .HasColumnName("limo_inPoint_transportType");
            entity.Property(e => e.LimoInPointType)
                .HasMaxLength(500)
                .HasColumnName("limo_inPoint_type");
            entity.Property(e => e.LimoIsCompleted).HasColumnName("limo_isCompleted");
            entity.Property(e => e.LimoNumCaseL).HasColumnName("limo_num_case_l");
            entity.Property(e => e.LimoNumCaseM).HasColumnName("limo_num_case_m");
            entity.Property(e => e.LimoNumCaseS).HasColumnName("limo_num_case_s");
            entity.Property(e => e.LimoOutDatetime)
                .HasColumnType("datetime")
                .HasColumnName("limo_out_datetime");
            entity.Property(e => e.LimoOutIsRequested).HasColumnName("limo_out_isRequested");
            entity.Property(e => e.LimoOutPointDetails)
                .HasMaxLength(500)
                .HasColumnName("limo_outPoint_details");
            entity.Property(e => e.LimoOutPointDetailsType).HasColumnName("limo_outPoint_detailsType");
            entity.Property(e => e.LimoOutPointPickupPlace).HasColumnName("limo_outPoint_pickupPlace");
            entity.Property(e => e.LimoOutPointPickupPlaceName)
                .HasMaxLength(500)
                .HasColumnName("limo_outPoint_pickupPlaceName");
            entity.Property(e => e.LimoOutPointTransportType)
                .HasMaxLength(500)
                .HasColumnName("limo_outPoint_transportType");
            entity.Property(e => e.LimoOutPointType)
                .HasMaxLength(500)
                .HasColumnName("limo_outPoint_type");
            entity.Property(e => e.LimoRequest)
                .HasColumnType("ntext")
                .HasColumnName("limo_request");
            entity.Property(e => e.ManagementFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("managementFee");
            entity.Property(e => e.ManualPaymentPart).HasColumnName("manualPaymentPart");
            entity.Property(e => e.MessageAirbnb).HasColumnName("messageAirbnb");
            entity.Property(e => e.MessageGuest).HasColumnName("messageGuest");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("modifiedDate");
            entity.Property(e => e.NotesClient)
                .HasColumnType("ntext")
                .HasColumnName("notesClient");
            entity.Property(e => e.NotesEco)
                .HasColumnType("ntext")
                .HasColumnName("notesEco");
            entity.Property(e => e.NotesInner)
                .HasColumnType("ntext")
                .HasColumnName("notesInner");
            entity.Property(e => e.NumAdult).HasColumnName("num_adult");
            entity.Property(e => e.NumChildMin).HasColumnName("num_child_min");
            entity.Property(e => e.NumChildOver).HasColumnName("num_child_over");
            entity.Property(e => e.OldAgentName)
                .HasMaxLength(100)
                .HasColumnName("oldAgentName");
            entity.Property(e => e.OldReservationId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OldReservationID");
            entity.Property(e => e.OperatorDate)
                .HasColumnType("datetime")
                .HasColumnName("operator_date");
            entity.Property(e => e.OwnerNotes)
                .HasColumnType("ntext")
                .HasColumnName("ownerNotes");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.PayedDate)
                .HasDefaultValueSql("((0))", "DF_RNT_TBL_RESERVATION_is_deleted1_1")
                .HasColumnType("datetime")
                .HasColumnName("payed_date");
            entity.Property(e => e.PayedMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))", "DF_RNT_TBL_RESERVATION_payed_date1")
                .HasColumnName("payed_mode");
            entity.Property(e => e.PayedTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("payed_total");
            entity.Property(e => e.PayedUser)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_payed_date2")
                .HasColumnName("payed_user");
            entity.Property(e => e.PidCreator).HasColumnName("pid_creator");
            entity.Property(e => e.PidEstate).HasColumnName("pid_estate");
            entity.Property(e => e.PidEstateCity).HasColumnName("pidEstateCity");
            entity.Property(e => e.PidEstateRoomNumber).HasColumnName("pidEstateRoomNumber");
            entity.Property(e => e.PidOperator).HasColumnName("pid_operator");
            entity.Property(e => e.PidParentEstateId).HasColumnName("pid_parentEstate_id");
            entity.Property(e => e.PidParentReservation).HasColumnName("pidParentReservation");
            entity.Property(e => e.PidRelatedRequest)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_pid_related_request")
                .HasColumnName("pid_related_request");
            entity.Property(e => e.PidWebsite).HasColumnName("pidWebsite");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(100)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.PrCityTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_cityTax");
            entity.Property(e => e.PrDeposit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_deposit");
            entity.Property(e => e.PrDepositNotes)
                .HasColumnType("ntext")
                .HasColumnName("pr_depositNotes");
            entity.Property(e => e.PrDepositWithCard).HasColumnName("pr_depositWithCard");
            entity.Property(e => e.PrDiscountCommission)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_discount_commission");
            entity.Property(e => e.PrDiscountCustom).HasColumnName("pr_discount_custom");
            entity.Property(e => e.PrDiscountDesc)
                .HasColumnType("ntext")
                .HasColumnName("pr_discount_desc");
            entity.Property(e => e.PrDiscountFullPay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountFullPay");
            entity.Property(e => e.PrDiscountFullPayDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prDiscountFullPayDesc");
            entity.Property(e => e.PrDiscountLastMinute)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountLastMinute");
            entity.Property(e => e.PrDiscountLastMinuteDesc).HasColumnName("prDiscountLastMinuteDesc");
            entity.Property(e => e.PrDiscountLongRange)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountLongRange");
            entity.Property(e => e.PrDiscountLongRangeDesc).HasColumnName("prDiscountLongRangeDesc");
            entity.Property(e => e.PrDiscountLongStay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountLongStay");
            entity.Property(e => e.PrDiscountLongStayDesc).HasColumnName("prDiscountLongStayDesc");
            entity.Property(e => e.PrDiscountOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_discount_owner");
            entity.Property(e => e.PrDiscountRevenueOffer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountRevenueOffer");
            entity.Property(e => e.PrDiscountSpecialOffer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prDiscountSpecialOffer");
            entity.Property(e => e.PrDiscountUser).HasColumnName("pr_discount_user");
            entity.Property(e => e.PrEcoCount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_ecoCount");
            entity.Property(e => e.PrEcoPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_ecoPrice");
            entity.Property(e => e.PrOptioniExtra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prOptioniExtra");
            entity.Property(e => e.PrOptioniFeeling)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_optioni_feeling");
            entity.Property(e => e.PrOptioniOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_optioni_owner");
            entity.Property(e => e.PrOwnerRefundExported).HasColumnName("prOwnerRefundExported");
            entity.Property(e => e.PrOwnerRefundRecDate)
                .HasColumnType("datetime")
                .HasColumnName("prOwnerRefundRecDate");
            entity.Property(e => e.PrPartAgencyFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_agency_fee");
            entity.Property(e => e.PrPartCommissionTf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_commission_tf");
            entity.Property(e => e.PrPartCommissionTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_commission_total");
            entity.Property(e => e.PrPartExtraServices)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_extraServices");
            entity.Property(e => e.PrPartForPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_forPayment");
            entity.Property(e => e.PrPartModified).HasColumnName("pr_part_modified");
            entity.Property(e => e.PrPartModifyNotes)
                .HasColumnType("ntext")
                .HasColumnName("pr_part_modify_notes");
            entity.Property(e => e.PrPartOptioniExtra)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_OptioniExtra");
            entity.Property(e => e.PrPartOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_owner");
            entity.Property(e => e.PrPartPaymentTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_payment_total");
            entity.Property(e => e.PrPartTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_part_tax");
            entity.Property(e => e.PrPaymentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pr_paymentType");
            entity.Property(e => e.PrRefundDate)
                .HasColumnType("datetime")
                .HasColumnName("prRefundDate");
            entity.Property(e => e.PrRefundPayMode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prRefundPayMode");
            entity.Property(e => e.PrRefundTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prRefundTotal");
            entity.Property(e => e.PrReservation)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_reservation");
            entity.Property(e => e.PrSrsPrice)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_srsPrice");
            entity.Property(e => e.PrTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_total");
            entity.Property(e => e.PrTotalCommission)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalCommission");
            entity.Property(e => e.PrTotalCommissionPer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalCommissionPer");
            entity.Property(e => e.PrTotalCommissionVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalCommissionVat");
            entity.Property(e => e.PrTotalCommissionVatPer)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalCommissionVatPer");
            entity.Property(e => e.PrTotalCommissionWithoutVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalCommissionWithoutVat");
            entity.Property(e => e.PrTotalNonRefundable)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pr_total_non_refundable");
            entity.Property(e => e.PrTotalOwner)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalOwner");
            entity.Property(e => e.PrTotalOwnerExported).HasColumnName("prTotalOwnerExported");
            entity.Property(e => e.PrTotalOwnerPayDate)
                .HasColumnType("datetime")
                .HasColumnName("prTotalOwnerPayDate");
            entity.Property(e => e.PrTotalRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalRate");
            entity.Property(e => e.PrTotalRateOnWeb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("prTotalRateOnWeb");
            entity.Property(e => e.PriceIsBlocked).HasColumnName("priceIsBlocked");
            entity.Property(e => e.ProblemDesc)
                .HasColumnType("ntext")
                .HasColumnName("problemDesc");
            entity.Property(e => e.ProblemId).HasColumnName("problemID");
            entity.Property(e => e.PushDate).HasColumnType("datetime");
            entity.Property(e => e.ReferredBy)
                .HasMaxLength(200)
                .HasColumnName("referredBy");
            entity.Property(e => e.RequestFullPay)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_requestRenewal1_1")
                .HasColumnName("requestFullPay");
            entity.Property(e => e.RequestFullPayAccepted)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_requestFullPay1")
                .HasColumnName("requestFullPayAccepted");
            entity.Property(e => e.RequestFullPayAcceptedDate)
                .HasDefaultValueSql("((0))", "DF_RNT_TBL_RESERVATION_requestFullPayDate1")
                .HasColumnType("datetime")
                .HasColumnName("requestFullPayAcceptedDate");
            entity.Property(e => e.RequestFullPayDate)
                .HasDefaultValueSql("((0))", "DF_RNT_TBL_RESERVATION_requestRenewalDate1")
                .HasColumnType("datetime")
                .HasColumnName("requestFullPayDate");
            entity.Property(e => e.RequestRenewal)
                .HasDefaultValue(0, "DF_RNT_TBL_RESERVATION_is_deleted1_2")
                .HasColumnName("requestRenewal");
            entity.Property(e => e.RequestRenewalDate)
                .HasDefaultValueSql("((0))", "DF_RNT_TBL_RESERVATION_requestRenewal1")
                .HasColumnType("datetime")
                .HasColumnName("requestRenewalDate");
            entity.Property(e => e.SelectedCurrency)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("selected_currency");
            entity.Property(e => e.SrsExtMeetingPoint)
                .HasMaxLength(2000)
                .HasColumnName("srs_ext_meetingPoint");
            entity.Property(e => e.StateBody)
                .HasColumnType("ntext")
                .HasColumnName("state_body");
            entity.Property(e => e.StateDate)
                .HasColumnType("datetime")
                .HasColumnName("state_date");
            entity.Property(e => e.StatePid).HasColumnName("state_pid");
            entity.Property(e => e.StatePidUser).HasColumnName("state_pid_user");
            entity.Property(e => e.StateSubject)
                .HasMaxLength(200)
                .HasColumnName("state_subject");
            entity.Property(e => e.Uid2).HasColumnName("uid_2");
            entity.Property(e => e.UniqueId).HasColumnName("unique_id");
            entity.Property(e => e.VisaIsRequested).HasColumnName("visa_isRequested");
            entity.Property(e => e.VisaPersons).HasColumnName("visa_persons");
        });

        modelBuilder.Entity<RoomNoLog>(entity =>
        {
            entity.ToTable("RoomNoLog");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
        });

        modelBuilder.Entity<RoomRatePlanMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RoomRatePlan");

            entity.ToTable("RoomRatePlanMapping");

            entity.Property(e => e.ActiveDays)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IsReadOnlyRate).HasDefaultValue(0);
            entity.Property(e => e.Policyname)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RatePlanId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoomId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoomID");
            entity.Property(e => e.WeekdayPricePer).HasDefaultValue(0);
        });

        modelBuilder.Entity<Roomavailability>(entity =>
        {
            entity.ToTable("Roomavailability");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SiteContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SiteCont__3214EC07BB86A97A");

            entity.ToTable("SiteContent");

            entity.Property(e => e.KeyName).HasMaxLength(100);
            entity.Property(e => e.Lang).HasMaxLength(10);
        });

        modelBuilder.Entity<UsrAdmin>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("USR_ADMIN");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Lang)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });
        modelBuilder.HasSequence("odd_negative_seq")
            .StartsAt(-1L)
            .IncrementsBy(-2)
            .HasMin(-999L)
            .HasMax(-1L)
            .IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
