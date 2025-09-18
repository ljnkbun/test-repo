using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts;

public partial class DBReadDbContext : DbContext
{
    public DBReadDbContext()
    {
    }

    public DBReadDbContext(DbContextOptions<DBReadDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppBinaryObject> AppBinaryObjects { get; set; }

    public virtual DbSet<AppChatMessage> AppChatMessages { get; set; }

    public virtual DbSet<AppFileStorage> AppFileStorages { get; set; }

    public virtual DbSet<AppFriendship> AppFriendships { get; set; }

    public virtual DbSet<AppInvoice> AppInvoices { get; set; }

    public virtual DbSet<AppSubscriptionPayment> AppSubscriptionPayments { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BackgroundJob> BackgroundJobs { get; set; }

    public virtual DbSet<CampaignmanagementCampaignCondition> CampaignmanagementCampaignConditions { get; set; }

    public virtual DbSet<CampaignmanagementCampaignInfo> CampaignmanagementCampaignInfos { get; set; }

    public virtual DbSet<CampaignmanagementCampaignWorkshiftInfo> CampaignmanagementCampaignWorkshiftInfos { get; set; }

    public virtual DbSet<CmsAlbum> CmsAlbums { get; set; }

    public virtual DbSet<CmsArticle> CmsArticles { get; set; }

    public virtual DbSet<CmsArticleTargetAudience> CmsArticleTargetAudiences { get; set; }

    public virtual DbSet<CmsArticleTargetAudienceDetail> CmsArticleTargetAudienceDetails { get; set; }

    public virtual DbSet<CmsArticleTranslation> CmsArticleTranslations { get; set; }

    public virtual DbSet<CmsArticleUser> CmsArticleUsers { get; set; }

    public virtual DbSet<CmsCategory> CmsCategories { get; set; }

    public virtual DbSet<CmsCategoryDetail> CmsCategoryDetails { get; set; }

    public virtual DbSet<CmsFaq> CmsFaqs { get; set; }

    public virtual DbSet<CmsFaqtranslation> CmsFaqtranslations { get; set; }

    public virtual DbSet<CmsImageLink> CmsImageLinks { get; set; }

    public virtual DbSet<CmsVideo> CmsVideos { get; set; }

    public virtual DbSet<CodeGeneratorGeneratorDetail> CodeGeneratorGeneratorDetails { get; set; }

    public virtual DbSet<CodeGeneratorGeneratorHeader> CodeGeneratorGeneratorHeaders { get; set; }

    public virtual DbSet<CommunicationCommunication> CommunicationCommunications { get; set; }

    public virtual DbSet<CommunicationCommunicationTargetAudience> CommunicationCommunicationTargetAudiences { get; set; }

    public virtual DbSet<CommunicationCommunicationTransaction> CommunicationCommunicationTransactions { get; set; }

    public virtual DbSet<CommunicationCommunicationUser> CommunicationCommunicationUsers { get; set; }

    public virtual DbSet<ConsumerdbAppBehaviorLog> ConsumerdbAppBehaviorLogs { get; set; }

    public virtual DbSet<ConsumerdbCompanyInfo> ConsumerdbCompanyInfos { get; set; }

    public virtual DbSet<ConsumerdbConsumerActivity> ConsumerdbConsumerActivities { get; set; }

    public virtual DbSet<ConsumerdbConsumerLogin> ConsumerdbConsumerLogins { get; set; }

    public virtual DbSet<ConsumerdbConsumerProfile> ConsumerdbConsumerProfiles { get; set; }

    public virtual DbSet<ConsumerdbConsumerProfileArch> ConsumerdbConsumerProfileArches { get; set; }

    public virtual DbSet<ConsumerdbDeleteProfileRequest> ConsumerdbDeleteProfileRequests { get; set; }

    public virtual DbSet<ConsumerdbMasterDetail> ConsumerdbMasterDetails { get; set; }

    public virtual DbSet<ConsumerdbMasterDetail20230622> ConsumerdbMasterDetail20230622s { get; set; }

    public virtual DbSet<ConsumerdbMasterHeader> ConsumerdbMasterHeaders { get; set; }

    public virtual DbSet<ConsumerdbPaymentTransaction> ConsumerdbPaymentTransactions { get; set; }

    public virtual DbSet<ConsumerdbProduct> ConsumerdbProducts { get; set; }

    public virtual DbSet<ConsumerdbQaticket> ConsumerdbQatickets { get; set; }

    public virtual DbSet<ConsumerdbRatingTicket> ConsumerdbRatingTickets { get; set; }

    public virtual DbSet<ConsumerdbRelatedProduct> ConsumerdbRelatedProducts { get; set; }

    public virtual DbSet<ConsumerdbSalesInvoiceDetail> ConsumerdbSalesInvoiceDetails { get; set; }

    public virtual DbSet<ConsumerdbSalesInvoiceHeader> ConsumerdbSalesInvoiceHeaders { get; set; }

    public virtual DbSet<ConsumerdbSurveySetting> ConsumerdbSurveySettings { get; set; }

    public virtual DbSet<ConsumerdbSurveyTicketDetail> ConsumerdbSurveyTicketDetails { get; set; }

    public virtual DbSet<ConsumerdbSurveyTicketHeader> ConsumerdbSurveyTicketHeaders { get; set; }

    public virtual DbSet<ConsumerdbTargetAudienceDetail> ConsumerdbTargetAudienceDetails { get; set; }

    public virtual DbSet<ConsumerdbTargetAudienceHeader> ConsumerdbTargetAudienceHeaders { get; set; }

    public virtual DbSet<ConsumerdbTargetAudienceUser> ConsumerdbTargetAudienceUsers { get; set; }

    public virtual DbSet<ConsumerdbUserLogin> ConsumerdbUserLogins { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Edition> Editions { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EntityChange> EntityChanges { get; set; }

    public virtual DbSet<EntityChangeSet> EntityChangeSets { get; set; }

    public virtual DbSet<EntityPropertyChange> EntityPropertyChanges { get; set; }

    public virtual DbSet<ExtendActiveSerial> ExtendActiveSerials { get; set; }

    public virtual DbSet<Feature> Features { get; set; }

    public virtual DbSet<GamificationClaimMission> GamificationClaimMissions { get; set; }

    public virtual DbSet<GamificationEgiftGame> GamificationEgiftGames { get; set; }

    public virtual DbSet<GamificationGameInfo> GamificationGameInfos { get; set; }

    public virtual DbSet<GamificationGamePlayHistory> GamificationGamePlayHistories { get; set; }

    public virtual DbSet<GamificationGameReward> GamificationGameRewards { get; set; }

    public virtual DbSet<GamificationGameTargetAudience> GamificationGameTargetAudiences { get; set; }

    public virtual DbSet<GamificationGameTargetAudienceDetail> GamificationGameTargetAudienceDetails { get; set; }

    public virtual DbSet<GamificationJoinQuest> GamificationJoinQuests { get; set; }

    public virtual DbSet<GamificationMission> GamificationMissions { get; set; }

    public virtual DbSet<GamificationPlayerTicket> GamificationPlayerTickets { get; set; }

    public virtual DbSet<GamificationQuest> GamificationQuests { get; set; }

    public virtual DbSet<GamificationQuestGroup> GamificationQuestGroups { get; set; }

    public virtual DbSet<GamificationQuestGroupDetail> GamificationQuestGroupDetails { get; set; }

    public virtual DbSet<GamificationTransferTransaction> GamificationTransferTransactions { get; set; }

    public virtual DbSet<GiftGiftCampaign> GiftGiftCampaigns { get; set; }

    public virtual DbSet<GiftGiftCampaignTargetAudience> GiftGiftCampaignTargetAudiences { get; set; }

    public virtual DbSet<GiftGiftCampaignTargetAudienceDetail> GiftGiftCampaignTargetAudienceDetails { get; set; }

    public virtual DbSet<GiftGiftMaster> GiftGiftMasters { get; set; }

    public virtual DbSet<GiftGiftTransaction> GiftGiftTransactions { get; set; }

    public virtual DbSet<GiftUnavailableGift> GiftUnavailableGifts { get; set; }

    public virtual DbSet<L2Tracer> L2Tracers { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LanguageText> LanguageTexts { get; set; }

    public virtual DbSet<LogMt> LogMts { get; set; }

    public virtual DbSet<LogSpGetFileExcelSummaryProductExport> LogSpGetFileExcelSummaryProductExports { get; set; }

    public virtual DbSet<MemberWarehouseValidateLog> MemberWarehouseValidateLogs { get; set; }

    public virtual DbSet<MigrationSerial> MigrationSerials { get; set; }

    public virtual DbSet<NewCustomer2> NewCustomer2s { get; set; }

    public virtual DbSet<Newcusomer> Newcusomers { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationAppPushTransaction> NotificationAppPushTransactions { get; set; }

    public virtual DbSet<NotificationChannel> NotificationChannels { get; set; }

    public virtual DbSet<NotificationChannelConfig> NotificationChannelConfigs { get; set; }

    public virtual DbSet<NotificationLog> NotificationLogs { get; set; }

    public virtual DbSet<NotificationNotificationUser> NotificationNotificationUsers { get; set; }

    public virtual DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

    public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }

    public virtual DbSet<Nv> Nvs { get; set; }

    public virtual DbSet<OneTimePassword> OneTimePasswords { get; set; }

    public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }

    public virtual DbSet<Outlet> Outlets { get; set; }

    public virtual DbSet<OutletDepartment> OutletDepartments { get; set; }

    public virtual DbSet<PaymentHistoryLog> PaymentHistoryLogs { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PersistedGrant> PersistedGrants { get; set; }

    public virtual DbSet<PointAction> PointActions { get; set; }

    public virtual DbSet<PointActionRuleSetting> PointActionRuleSettings { get; set; }

    public virtual DbSet<PointActionTransaction> PointActionTransactions { get; set; }

    public virtual DbSet<PointActiveMemberByMonth> PointActiveMemberByMonths { get; set; }

    public virtual DbSet<PointActiveMemberYearToDate> PointActiveMemberYearToDates { get; set; }

    public virtual DbSet<PointAdjustmentFileStatus> PointAdjustmentFileStatuses { get; set; }

    public virtual DbSet<PointBaseSetting> PointBaseSettings { get; set; }

    public virtual DbSet<PointButtonInteractionOverview> PointButtonInteractionOverviews { get; set; }

    public virtual DbSet<PointCampaign> PointCampaigns { get; set; }

    public virtual DbSet<PointCampaignOverview> PointCampaignOverviews { get; set; }

    public virtual DbSet<PointCampaignPerformanceOverview> PointCampaignPerformanceOverviews { get; set; }

    public virtual DbSet<PointChannelType> PointChannelTypes { get; set; }

    public virtual DbSet<PointClass> PointClasses { get; set; }

    public virtual DbSet<PointCoinBaseline> PointCoinBaselines { get; set; }

    public virtual DbSet<PointCoinExpirationSetting> PointCoinExpirationSettings { get; set; }

    public virtual DbSet<PointCoinOverview> PointCoinOverviews { get; set; }

    public virtual DbSet<PointCoinUsageHistory> PointCoinUsageHistories { get; set; }

    public virtual DbSet<PointCost> PointCosts { get; set; }

    public virtual DbSet<PointCusLevelGeo> PointCusLevelGeos { get; set; }

    public virtual DbSet<PointDeparment> PointDeparments { get; set; }

    public virtual DbSet<PointDistributor> PointDistributors { get; set; }

    public virtual DbSet<PointEgift> PointEgifts { get; set; }

    public virtual DbSet<PointEventSetting> PointEventSettings { get; set; }

    public virtual DbSet<PointEventSettingAmount> PointEventSettingAmounts { get; set; }

    public virtual DbSet<PointEventSubscriptionDetail> PointEventSubscriptionDetails { get; set; }

    public virtual DbSet<PointEventSubscriptionHeader> PointEventSubscriptionHeaders { get; set; }

    public virtual DbSet<PointFormulaSetting> PointFormulaSettings { get; set; }

    public virtual DbSet<PointGift> PointGifts { get; set; }

    public virtual DbSet<PointGiftCategory> PointGiftCategories { get; set; }

    public virtual DbSet<PointGiftGroup> PointGiftGroups { get; set; }

    public virtual DbSet<PointGiftGroupDetail> PointGiftGroupDetails { get; set; }

    public virtual DbSet<PointGiftRedeemLog> PointGiftRedeemLogs { get; set; }

    public virtual DbSet<PointGiftRedeemTransaction> PointGiftRedeemTransactions { get; set; }

    public virtual DbSet<PointGiftTargetAudience> PointGiftTargetAudiences { get; set; }

    public virtual DbSet<PointGiftTargetAudienceDetail> PointGiftTargetAudienceDetails { get; set; }

    public virtual DbSet<PointImageLink> PointImageLinks { get; set; }

    public virtual DbSet<PointInteractiveTimeRange> PointInteractiveTimeRanges { get; set; }

    public virtual DbSet<PointMember> PointMembers { get; set; }

    public virtual DbSet<PointMemberActivityRule> PointMemberActivityRules { get; set; }

    public virtual DbSet<PointMemberArch> PointMemberArches { get; set; }

    public virtual DbSet<PointMemberLoyaltyInfo> PointMemberLoyaltyInfos { get; set; }

    public virtual DbSet<PointMemberRankOverview> PointMemberRankOverviews { get; set; }

    public virtual DbSet<PointMemberType> PointMemberTypes { get; set; }

    public virtual DbSet<PointNonPurchaseSetting> PointNonPurchaseSettings { get; set; }

    public virtual DbSet<PointNumberRoundingSetting> PointNumberRoundingSettings { get; set; }

    public virtual DbSet<PointOrderMappingSm> PointOrderMappingSms { get; set; }

    public virtual DbSet<PointPeriodHistory> PointPeriodHistories { get; set; }

    public virtual DbSet<PointProduct> PointProducts { get; set; }

    public virtual DbSet<PointProductCategorySetting> PointProductCategorySettings { get; set; }

    public virtual DbSet<PointProductCategorySettingDetail> PointProductCategorySettingDetails { get; set; }

    public virtual DbSet<PointProductSetting> PointProductSettings { get; set; }

    public virtual DbSet<PointProductSettingDetail> PointProductSettingDetails { get; set; }

    public virtual DbSet<PointProductSettingDetailByRank> PointProductSettingDetailByRanks { get; set; }

    public virtual DbSet<PointProductUommapping> PointProductUommappings { get; set; }

    public virtual DbSet<PointRank> PointRanks { get; set; }

    public virtual DbSet<PointRankCalculationSetting> PointRankCalculationSettings { get; set; }

    public virtual DbSet<PointRankHistory> PointRankHistories { get; set; }

    public virtual DbSet<PointRankSetting> PointRankSettings { get; set; }

    public virtual DbSet<PointRankTarget> PointRankTargets { get; set; }

    public virtual DbSet<PointRankType> PointRankTypes { get; set; }

    public virtual DbSet<PointReason> PointReasons { get; set; }

    public virtual DbSet<PointRedemptionOverview> PointRedemptionOverviews { get; set; }

    public virtual DbSet<PointReferralSetting> PointReferralSettings { get; set; }

    public virtual DbSet<PointReferralTransaction> PointReferralTransactions { get; set; }

    public virtual DbSet<PointRegion> PointRegions { get; set; }

    public virtual DbSet<PointRegion20230224> PointRegion20230224s { get; set; }

    public virtual DbSet<PointReportSetting> PointReportSettings { get; set; }

    public virtual DbSet<PointRevenue> PointRevenues { get; set; }

    public virtual DbSet<PointSalesRegion> PointSalesRegions { get; set; }

    public virtual DbSet<PointSenioritySetting> PointSenioritySettings { get; set; }

    public virtual DbSet<PointSenioritySettingHistory> PointSenioritySettingHistories { get; set; }

    public virtual DbSet<PointSenioritySettingMilestone> PointSenioritySettingMilestones { get; set; }

    public virtual DbSet<PointSpecialSettingHistory> PointSpecialSettingHistories { get; set; }

    public virtual DbSet<PointSuspendTransaction> PointSuspendTransactions { get; set; }

    public virtual DbSet<PointTag> PointTags { get; set; }

    public virtual DbSet<PointTargetAudience> PointTargetAudiences { get; set; }

    public virtual DbSet<PointTargetAudienceDetail> PointTargetAudienceDetails { get; set; }

    public virtual DbSet<PointTempCoinBaseline> PointTempCoinBaselines { get; set; }

    public virtual DbSet<PointTempInvoiceTransaction> PointTempInvoiceTransactions { get; set; }

    public virtual DbSet<PointTempMappingGeo> PointTempMappingGeos { get; set; }

    public virtual DbSet<PointTransaction> PointTransactions { get; set; }

    public virtual DbSet<PointTransactionCoinBaseLine> PointTransactionCoinBaseLines { get; set; }

    public virtual DbSet<PointTransactionDetail> PointTransactionDetails { get; set; }

    public virtual DbSet<PointTransactionPointBaseLine> PointTransactionPointBaseLines { get; set; }

    public virtual DbSet<PointVendorSetting> PointVendorSettings { get; set; }

    public virtual DbSet<PosmResult> PosmResults { get; set; }

    public virtual DbSet<PromoCampaign> PromoCampaigns { get; set; }

    public virtual DbSet<PromoCampaignMemberPoint> PromoCampaignMemberPoints { get; set; }

    public virtual DbSet<PromoCampaignReward> PromoCampaignRewards { get; set; }

    public virtual DbSet<PromoRewardItem> PromoRewardItems { get; set; }

    public virtual DbSet<PromoRewardRedemptionItem> PromoRewardRedemptionItems { get; set; }

    public virtual DbSet<PromoRewardRedemptionRequest> PromoRewardRedemptionRequests { get; set; }

    public virtual DbSet<PromoRewardUsedTransaction> PromoRewardUsedTransactions { get; set; }

    public virtual DbSet<PublishEventLog> PublishEventLogs { get; set; }

    public virtual DbSet<QuartzHistory> QuartzHistories { get; set; }

    public virtual DbSet<QuartzJob> QuartzJobs { get; set; }

    public virtual DbSet<RewardsGameInfor> RewardsGameInfors { get; set; }

    public virtual DbSet<RewardsGeneratedVoucher> RewardsGeneratedVouchers { get; set; }

    public virtual DbSet<RewardsPublisherMaster> RewardsPublisherMasters { get; set; }

    public virtual DbSet<RewardsReferralTransaction> RewardsReferralTransactions { get; set; }

    public virtual DbSet<RewardsRewardTargetAudience> RewardsRewardTargetAudiences { get; set; }

    public virtual DbSet<RewardsSalesInvoiceBaseline> RewardsSalesInvoiceBaselines { get; set; }

    public virtual DbSet<RewardsTerminalMaster> RewardsTerminalMasters { get; set; }

    public virtual DbSet<RewardsUnavailableVoucher> RewardsUnavailableVouchers { get; set; }

    public virtual DbSet<RewardsUserSessionTracking> RewardsUserSessionTrackings { get; set; }

    public virtual DbSet<RewardsVoucherBudget> RewardsVoucherBudgets { get; set; }

    public virtual DbSet<RewardsVoucherGroup> RewardsVoucherGroups { get; set; }

    public virtual DbSet<RewardsVoucherPattern> RewardsVoucherPatterns { get; set; }

    public virtual DbSet<RewardsVoucherTransaction> RewardsVoucherTransactions { get; set; }

    public virtual DbSet<RewardsVoucherTransactionLog> RewardsVoucherTransactionLogs { get; set; }

    public virtual DbSet<RewardsVoucherUser> RewardsVoucherUsers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<RwActionLog> RwActionLogs { get; set; }

    public virtual DbSet<RwComboDepartment> RwComboDepartments { get; set; }

    public virtual DbSet<RwComboDetail> RwComboDetails { get; set; }

    public virtual DbSet<RwComboHeader> RwComboHeaders { get; set; }

    public virtual DbSet<RwComboProduct> RwComboProducts { get; set; }

    public virtual DbSet<RwFormulaDetail> RwFormulaDetails { get; set; }

    public virtual DbSet<RwFormulaHeader> RwFormulaHeaders { get; set; }

    public virtual DbSet<RwWarrantyAdjustmentFileStatus> RwWarrantyAdjustmentFileStatuses { get; set; }

    public virtual DbSet<RwWarrantyAdjustmentLog> RwWarrantyAdjustmentLogs { get; set; }

    public virtual DbSet<RwWarrantySerial> RwWarrantySerials { get; set; }

    public virtual DbSet<ScanSerialRequestTransaction> ScanSerialRequestTransactions { get; set; }

    public virtual DbSet<SellIn1221> SellIn1221s { get; set; }

    public virtual DbSet<Sellinfull> Sellinfulls { get; set; }

    public virtual DbSet<Sellout1221> Sellout1221s { get; set; }

    public virtual DbSet<Sellout3112> Sellout3112s { get; set; }

    public virtual DbSet<Selloutfull> Selloutfulls { get; set; }

    public virtual DbSet<SelltoDistributor> SelltoDistributors { get; set; }

    public virtual DbSet<Seria1111> Seria1111s { get; set; }

    public virtual DbSet<Serial> Serials { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<SocialretailerActivationCode> SocialretailerActivationCodes { get; set; }

    public virtual DbSet<SocialretailerActivationCode20230530> SocialretailerActivationCode20230530s { get; set; }

    public virtual DbSet<SocialretailerActivationCodeDelete25042023> SocialretailerActivationCodeDelete25042023s { get; set; }

    public virtual DbSet<SocialretailerActivationCodeDeleted> SocialretailerActivationCodeDeleteds { get; set; }

    public virtual DbSet<SocialretailerAging> SocialretailerAgings { get; set; }

    public virtual DbSet<SocialretailerAutoReplySetting> SocialretailerAutoReplySettings { get; set; }

    public virtual DbSet<SocialretailerBeatPlanDetail> SocialretailerBeatPlanDetails { get; set; }

    public virtual DbSet<SocialretailerBeatPlanHeader> SocialretailerBeatPlanHeaders { get; set; }

    public virtual DbSet<SocialretailerBeatPlanResult> SocialretailerBeatPlanResults { get; set; }

    public virtual DbSet<SocialretailerChallengeFollow> SocialretailerChallengeFollows { get; set; }

    public virtual DbSet<SocialretailerChallengeHeader> SocialretailerChallengeHeaders { get; set; }

    public virtual DbSet<SocialretailerChallengePhotoDetail> SocialretailerChallengePhotoDetails { get; set; }

    public virtual DbSet<SocialretailerChallengeResult> SocialretailerChallengeResults { get; set; }

    public virtual DbSet<SocialretailerChallengeResultBk20221011> SocialretailerChallengeResultBk20221011s { get; set; }

    public virtual DbSet<SocialretailerChallengeTargetAudience> SocialretailerChallengeTargetAudiences { get; set; }

    public virtual DbSet<SocialretailerChallengeTargetAudienceDetail> SocialretailerChallengeTargetAudienceDetails { get; set; }

    public virtual DbSet<SocialretailerComponentRuler> SocialretailerComponentRulers { get; set; }

    public virtual DbSet<SocialretailerConsentReport> SocialretailerConsentReports { get; set; }

    public virtual DbSet<SocialretailerConversationStatus> SocialretailerConversationStatuses { get; set; }

    public virtual DbSet<SocialretailerExtendActiveSerial> SocialretailerExtendActiveSerials { get; set; }

    public virtual DbSet<SocialretailerGameSetting> SocialretailerGameSettings { get; set; }

    public virtual DbSet<SocialretailerMemberWareHouse> SocialretailerMemberWareHouses { get; set; }

    public virtual DbSet<SocialretailerOrder> SocialretailerOrders { get; set; }

    public virtual DbSet<SocialretailerOrderItem> SocialretailerOrderItems { get; set; }

    public virtual DbSet<SocialretailerOutletCheckHistory> SocialretailerOutletCheckHistories { get; set; }

    public virtual DbSet<SocialretailerOutletInfo> SocialretailerOutletInfos { get; set; }

    public virtual DbSet<SocialretailerOutletInfoArch> SocialretailerOutletInfoArches { get; set; }

    public virtual DbSet<SocialretailerOutletInfoDetail> SocialretailerOutletInfoDetails { get; set; }

    public virtual DbSet<SocialretailerOutletInfoUpdateHistory> SocialretailerOutletInfoUpdateHistories { get; set; }

    public virtual DbSet<SocialretailerOutletRevenueBaseline> SocialretailerOutletRevenueBaselines { get; set; }

    public virtual DbSet<SocialretailerOutletUpdateHistory> SocialretailerOutletUpdateHistories { get; set; }

    public virtual DbSet<SocialretailerPayBonu> SocialretailerPayBonus { get; set; }

    public virtual DbSet<SocialretailerPosm> SocialretailerPosms { get; set; }

    public virtual DbSet<SocialretailerPublisher> SocialretailerPublishers { get; set; }

    public virtual DbSet<SocialretailerRequest> SocialretailerRequests { get; set; }

    public virtual DbSet<SocialretailerRequestAssign> SocialretailerRequestAssigns { get; set; }

    public virtual DbSet<SocialretailerRequestAssignConfig> SocialretailerRequestAssignConfigs { get; set; }

    public virtual DbSet<SocialretailerRequestComment> SocialretailerRequestComments { get; set; }

    public virtual DbSet<SocialretailerRuleGenerator> SocialretailerRuleGenerators { get; set; }

    public virtual DbSet<SocialretailerSale> SocialretailerSales { get; set; }

    public virtual DbSet<SocialretailerSaleHistory> SocialretailerSaleHistories { get; set; }

    public virtual DbSet<SocialretailerSaleOrder> SocialretailerSaleOrders { get; set; }

    public virtual DbSet<SocialretailerSaleOrderDetail> SocialretailerSaleOrderDetails { get; set; }

    public virtual DbSet<SocialretailerSalesDataBaseline> SocialretailerSalesDataBaselines { get; set; }

    public virtual DbSet<SocialretailerSalesDatum> SocialretailerSalesData { get; set; }

    public virtual DbSet<SocialretailerSalesman> SocialretailerSalesmen { get; set; }

    public virtual DbSet<SocialretailerSapproduct> SocialretailerSapproducts { get; set; }

    public virtual DbSet<SocialretailerSapserial> SocialretailerSapserials { get; set; }

    public virtual DbSet<SocialretailerSapserialBk> SocialretailerSapserialBks { get; set; }

    public virtual DbSet<SocialretailerSerialOutSap> SocialretailerSerialOutSaps { get; set; }

    public virtual DbSet<SocialretailerSerialOutSaphistory> SocialretailerSerialOutSaphistories { get; set; }

    public virtual DbSet<SocialretailerSerialProducer> SocialretailerSerialProducers { get; set; }

    public virtual DbSet<SocialretailerSerialProducer2> SocialretailerSerialProducer2s { get; set; }

    public virtual DbSet<SocialretailerSerialProducerScanLog> SocialretailerSerialProducerScanLogs { get; set; }

    public virtual DbSet<SocialretailerSerialTypeChangeHistory> SocialretailerSerialTypeChangeHistories { get; set; }

    public virtual DbSet<SocialretailerSocialMessage> SocialretailerSocialMessages { get; set; }

    public virtual DbSet<SocialretailerSurvey> SocialretailerSurveys { get; set; }

    public virtual DbSet<SocialretailerSurveyQuestion> SocialretailerSurveyQuestions { get; set; }

    public virtual DbSet<SocialretailerSurveyResult> SocialretailerSurveyResults { get; set; }

    public virtual DbSet<SocialretailerSurveyResultDetail> SocialretailerSurveyResultDetails { get; set; }

    public virtual DbSet<SocialretailerUpdateProfileRequestHistory> SocialretailerUpdateProfileRequestHistories { get; set; }

    public virtual DbSet<SocialretailerUserImporting> SocialretailerUserImportings { get; set; }

    public virtual DbSet<SocialretailerVisitPlanDetail> SocialretailerVisitPlanDetails { get; set; }

    public virtual DbSet<SocialshopperShopperInfo> SocialshopperShopperInfos { get; set; }

    public virtual DbSet<SocialshopperSubmittedSo> SocialshopperSubmittedSos { get; set; }

    public virtual DbSet<SocialshopperUploadedInvoice> SocialshopperUploadedInvoices { get; set; }

    public virtual DbSet<SpparasLog> SpparasLogs { get; set; }

    public virtual DbSet<SurveysSurveyAnswer> SurveysSurveyAnswers { get; set; }

    public virtual DbSet<SurveysSurveyInfo> SurveysSurveyInfos { get; set; }

    public virtual DbSet<SurveysSurveyQuestion> SurveysSurveyQuestions { get; set; }

    public virtual DbSet<SurveysSurveyResponse> SurveysSurveyResponses { get; set; }

    public virtual DbSet<SurveysSurveyTargetAudience> SurveysSurveyTargetAudiences { get; set; }

    public virtual DbSet<SurveysSurveyTargetAudienceDetail> SurveysSurveyTargetAudienceDetails { get; set; }

    public virtual DbSet<TaskAnswer> TaskAnswers { get; set; }

    public virtual DbSet<TaskInfo> TaskInfos { get; set; }

    public virtual DbSet<TaskQuestion> TaskQuestions { get; set; }

    public virtual DbSet<TaskResult> TaskResults { get; set; }

    public virtual DbSet<TaskResultDetail> TaskResultDetails { get; set; }

    public virtual DbSet<TaskTargetaudience> TaskTargetaudiences { get; set; }

    public virtual DbSet<TaskTargetaudienceDetail> TaskTargetaudienceDetails { get; set; }

    public virtual DbSet<TblBaslineSalesByCurrentYear> TblBaslineSalesByCurrentYears { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<TenantNotification> TenantNotifications { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<TmpActivecode> TmpActivecodes { get; set; }

    public virtual DbSet<Tmpdi022022> Tmpdi022022s { get; set; }

    public virtual DbSet<Tmpdis02202202> Tmpdis02202202s { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserLoginAttempt> UserLoginAttempts { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<UserOrganizationUnit> UserOrganizationUnits { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<Users000290> Users000290s { get; set; }

    public virtual DbSet<UsersArch> UsersArches { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<WebHookNotificationInfo> WebHookNotificationInfos { get; set; }

    public virtual DbSet<WebHookSubscriptionInfo> WebHookSubscriptionInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.1.2.170;Database=cp-sales;Uid=sa;Password=jrmEXVbSeJaAh6Uy;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppBinaryObject>(entity =>
        {
            entity.HasIndex(e => e.TenantId, "IX_AppBinaryObjects_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AppChatMessage>(entity =>
        {
            entity.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_TargetUserId_ReadState");

            entity.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TargetTenantId_UserId_ReadState");

            entity.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState }, "IX_AppChatMessages_TenantId_TargetUserId_ReadState");

            entity.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState }, "IX_AppChatMessages_TenantId_UserId_ReadState");
        });

        modelBuilder.Entity<AppFileStorage>(entity =>
        {
            entity.HasIndex(e => e.FileName, "IX_AppFileStorages_FileName");
        });

        modelBuilder.Entity<AppFriendship>(entity =>
        {
            entity.HasIndex(e => new { e.FriendTenantId, e.FriendUserId }, "IX_AppFriendships_FriendTenantId_FriendUserId");

            entity.HasIndex(e => new { e.FriendTenantId, e.UserId }, "IX_AppFriendships_FriendTenantId_UserId");

            entity.HasIndex(e => new { e.TenantId, e.FriendUserId }, "IX_AppFriendships_TenantId_FriendUserId");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AppFriendships_TenantId_UserId");

            entity.Property(e => e.FriendUserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AppSubscriptionPayment>(entity =>
        {
            entity.HasIndex(e => e.EditionId, "IX_AppSubscriptionPayments_EditionId");

            entity.HasIndex(e => new { e.PaymentId, e.Gateway }, "IX_AppSubscriptionPayments_PaymentId_Gateway");

            entity.HasIndex(e => new { e.Status, e.CreationTime }, "IX_AppSubscriptionPayments_Status_CreationTime");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Edition).WithMany(p => p.AppSubscriptionPayments).HasForeignKey(d => d.EditionId);
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.ExecutionDuration }, "IX_AuditLogs_TenantId_ExecutionDuration");

            entity.HasIndex(e => new { e.TenantId, e.ExecutionTime }, "IX_AuditLogs_TenantId_ExecutionTime");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_AuditLogs_TenantId_UserId");

            entity.Property(e => e.BrowserInfo).HasMaxLength(512);
            entity.Property(e => e.ClientIpAddress).HasMaxLength(64);
            entity.Property(e => e.ClientName).HasMaxLength(128);
            entity.Property(e => e.CustomData).HasMaxLength(2000);
            entity.Property(e => e.Exception).HasMaxLength(2000);
            entity.Property(e => e.MethodName).HasMaxLength(256);
            entity.Property(e => e.Parameters).HasMaxLength(1024);
            entity.Property(e => e.ServiceName).HasMaxLength(256);
        });

        modelBuilder.Entity<BackgroundJob>(entity =>
        {
            entity.HasIndex(e => new { e.IsAbandoned, e.NextTryTime }, "IX_BackgroundJobs_IsAbandoned_NextTryTime");

            entity.Property(e => e.JobType).HasMaxLength(512);
        });

        modelBuilder.Entity<CampaignmanagementCampaignCondition>(entity =>
        {
            entity.ToTable("campaignmanagement_CampaignCondition");

            entity.HasIndex(e => e.TenantId, "IX_campaignmanagement_CampaignCondition_TenantId");

            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RequireAmo).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RequireQty).HasColumnType("decimal(12, 3)");
        });

        modelBuilder.Entity<CampaignmanagementCampaignInfo>(entity =>
        {
            entity.ToTable("campaignmanagement_CampaignInfo");

            entity.HasIndex(e => e.TenantId, "IX_campaignmanagement_CampaignInfo_TenantId");

            entity.Property(e => e.Address).HasMaxLength(4000);
            entity.Property(e => e.Budget).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CampaignCode).HasMaxLength(40);
            entity.Property(e => e.CampaignName).HasMaxLength(255);
            entity.Property(e => e.CampaignNameUnSign).HasMaxLength(255);
            entity.Property(e => e.CampaignType).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Lat)
                .HasMaxLength(40)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(40)
                .HasColumnName("LNG");
            entity.Property(e => e.NumberOfLead).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<CampaignmanagementCampaignWorkshiftInfo>(entity =>
        {
            entity.ToTable("campaignmanagement_CampaignWorkshiftInfo");

            entity.HasIndex(e => e.TenantId, "IX_campaignmanagement_CampaignWorkshiftInfo_TenantId");

            entity.Property(e => e.CampaignId).HasColumnName("CampaignID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.WorkshiftName).HasMaxLength(2000);
        });

        modelBuilder.Entity<CmsAlbum>(entity =>
        {
            entity.ToTable("cms_Album");

            entity.HasIndex(e => e.TenantId, "IX_cms_Album_TenantId");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<CmsArticle>(entity =>
        {
            entity.ToTable("cms_Article");

            entity.HasIndex(e => e.ToDate, "IX_cms_Article_ToDate");

            entity.Property(e => e.Avatar).HasMaxLength(1000);
            entity.Property(e => e.Category).HasMaxLength(80);
            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
        });

        modelBuilder.Entity<CmsArticleTargetAudience>(entity =>
        {
            entity.ToTable("cms_ArticleTargetAudience");

            entity.HasIndex(e => e.Status, "IX_cms_ArticleTargetAudience_Status");

            entity.HasIndex(e => e.TenantId, "IX_cms_ArticleTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<CmsArticleTargetAudienceDetail>(entity =>
        {
            entity.ToTable("cms_ArticleTargetAudienceDetail");

            entity.HasIndex(e => e.ArticleTargetAudienceId, "IX_cms_ArticleTargetAudienceDetail_ArticleTargetAudienceID");

            entity.HasIndex(e => e.MemberCode, "IX_cms_ArticleTargetAudienceDetail_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_cms_ArticleTargetAudienceDetail_TenantId");

            entity.Property(e => e.ArticleTargetAudienceId).HasColumnName("ArticleTargetAudienceID");
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<CmsArticleTranslation>(entity =>
        {
            entity.ToTable("cms_ArticleTranslation");

            entity.HasIndex(e => e.CoreId, "IX_cms_ArticleTranslation_CoreId");

            entity.Property(e => e.Description).HasMaxLength(1000);
        });

        modelBuilder.Entity<CmsArticleUser>(entity =>
        {
            entity.ToTable("cms_ArticleUser");

            entity.HasIndex(e => e.TenantId, "IX_cms_ArticleUser_TenantId");

            entity.Property(e => e.ArticleCode).HasMaxLength(80);
            entity.Property(e => e.CategoryCode).HasMaxLength(80);
            entity.Property(e => e.MemberCode).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<CmsCategory>(entity =>
        {
            entity.ToTable("cms_Category");

            entity.HasIndex(e => e.Code, "IX_cms_Category_Code");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(510);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<CmsCategoryDetail>(entity =>
        {
            entity.ToTable("cms_CategoryDetail");

            entity.Property(e => e.CategoryCode).HasMaxLength(80);
        });

        modelBuilder.Entity<CmsFaq>(entity =>
        {
            entity.ToTable("cms_FAQ");

            entity.HasIndex(e => e.TenantId, "IX_cms_FAQ_TenantId");

            entity.Property(e => e.Code).HasMaxLength(80);
        });

        modelBuilder.Entity<CmsFaqtranslation>(entity =>
        {
            entity.ToTable("cms_FAQTranslation");

            entity.HasIndex(e => e.CoreId, "IX_cms_FAQTranslation_CoreId");

            entity.HasIndex(e => e.TenantId, "IX_cms_FAQTranslation_TenantId");

            entity.Property(e => e.Language).HasMaxLength(40);

            entity.HasOne(d => d.Core).WithMany(p => p.CmsFaqtranslations).HasForeignKey(d => d.CoreId);
        });

        modelBuilder.Entity<CmsImageLink>(entity =>
        {
            entity.ToTable("cms_ImageLink");

            entity.HasIndex(e => new { e.Code, e.Type, e.Status }, "missing_index_1292");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Link).HasMaxLength(512);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<CmsVideo>(entity =>
        {
            entity.ToTable("cms_Video");

            entity.HasIndex(e => e.TenantId, "IX_cms_Video_TenantId");

            entity.Property(e => e.Avatar).HasMaxLength(1000);
            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.DescriptionEn).HasColumnName("DescriptionEN");
            entity.Property(e => e.DescriptionVn).HasColumnName("DescriptionVN");
            entity.Property(e => e.NameEn)
                .HasMaxLength(255)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameVn)
                .HasMaxLength(255)
                .HasColumnName("NameVN");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<CodeGeneratorGeneratorDetail>(entity =>
        {
            entity.ToTable("CodeGenerator_GeneratorDetail");

            entity.HasIndex(e => e.TenantId, "IX_CodeGenerator_GeneratorDetail_TenantId");

            entity.Property(e => e.GeneratorCode).HasMaxLength(40);
            entity.Property(e => e.GeneratorDetailId)
                .HasMaxLength(100)
                .HasColumnName("GeneratorDetailID");
            entity.Property(e => e.LastValue).HasMaxLength(255);
            entity.Property(e => e.ParameterValue1).HasMaxLength(80);
            entity.Property(e => e.ParameterValue2).HasMaxLength(80);
            entity.Property(e => e.SyntaxCode).HasMaxLength(40);
        });

        modelBuilder.Entity<CodeGeneratorGeneratorHeader>(entity =>
        {
            entity.ToTable("CodeGenerator_GeneratorHeader");

            entity.HasIndex(e => e.TenantId, "IX_CodeGenerator_GeneratorHeader_TenantId");

            entity.Property(e => e.Delimiter).HasMaxLength(5);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GeneratorCode).HasMaxLength(40);
            entity.Property(e => e.GeneratorName).HasMaxLength(80);
        });

        modelBuilder.Entity<CommunicationCommunication>(entity =>
        {
            entity.ToTable("communication_Communication");

            entity.Property(e => e.BroadcastCategory).HasMaxLength(40);
            entity.Property(e => e.Channel).HasMaxLength(40);
            entity.Property(e => e.CommunicationTargetAudienceId).HasColumnName("CommunicationTargetAudienceID");
            entity.Property(e => e.ContentEn).HasColumnName("ContentEN");
            entity.Property(e => e.ContentType).HasMaxLength(20);
            entity.Property(e => e.ContentVn).HasColumnName("ContentVN");
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EventType).HasMaxLength(40);
            entity.Property(e => e.ExtraUrl)
                .HasMaxLength(2000)
                .HasColumnName("ExtraURL");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(2000)
                .HasColumnName("ImageURL");
            entity.Property(e => e.LanguageDefault).HasMaxLength(40);
            entity.Property(e => e.MessageAction).HasMaxLength(20);
            entity.Property(e => e.MessageType).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnsign).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SubjectEn)
                .HasMaxLength(255)
                .HasColumnName("SubjectEN");
            entity.Property(e => e.SubjectVn)
                .HasMaxLength(255)
                .HasColumnName("SubjectVN");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
            entity.Property(e => e.TargetScreen).HasMaxLength(40);
        });

        modelBuilder.Entity<CommunicationCommunicationTargetAudience>(entity =>
        {
            entity.ToTable("communication_CommunicationTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_communication_CommunicationTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceLinkId).HasColumnName("TargetAudienceLinkID");
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<CommunicationCommunicationTransaction>(entity =>
        {
            entity.ToTable("communication_CommunicationTransaction");

            entity.Property(e => e.Channel).HasMaxLength(40);
            entity.Property(e => e.CommunicationId)
                .HasMaxLength(40)
                .HasColumnName("CommunicationID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<CommunicationCommunicationUser>(entity =>
        {
            entity.ToTable("communication_CommunicationUser");

            entity.HasIndex(e => e.TenantId, "IX_communication_CommunicationUser_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.CommunicationTargetAudienceId).HasColumnName("CommunicationTargetAudienceID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Param1).HasMaxLength(255);
            entity.Property(e => e.Param2).HasMaxLength(255);
            entity.Property(e => e.Param3).HasMaxLength(255);
            entity.Property(e => e.Param4).HasMaxLength(255);
            entity.Property(e => e.Param5).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceLinkId).HasColumnName("TargetAudienceLinkID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<ConsumerdbAppBehaviorLog>(entity =>
        {
            entity.ToTable("consumerdb_AppBehaviorLog");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_AppBehaviorLog_TenantId");

            entity.Property(e => e.ActionName).HasMaxLength(50);
            entity.Property(e => e.AppArea).HasMaxLength(50);
            entity.Property(e => e.AppName).HasMaxLength(40);
            entity.Property(e => e.AppVersion).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DeviceImei).HasMaxLength(40);
            entity.Property(e => e.DeviceManufacturer).HasMaxLength(50);
            entity.Property(e => e.DeviceName).HasMaxLength(50);
            entity.Property(e => e.DeviceOs)
                .HasMaxLength(50)
                .HasColumnName("DeviceOS");
            entity.Property(e => e.DeviceOsversion)
                .HasMaxLength(20)
                .HasColumnName("DeviceOSVersion");
            entity.Property(e => e.DeviceSerial).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbCompanyInfo>(entity =>
        {
            entity.ToTable("consumerdb_CompanyInfo");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_CompanyInfo_TenantId");

            entity.Property(e => e.Type).HasMaxLength(80);
        });

        modelBuilder.Entity<ConsumerdbConsumerActivity>(entity =>
        {
            entity.ToTable("consumerdb_ConsumerActivity");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_ConsumerActivity_TenantId");

            entity.Property(e => e.ActivityType).HasMaxLength(40);
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.ReferrenceCode).HasMaxLength(255);
        });

        modelBuilder.Entity<ConsumerdbConsumerLogin>(entity =>
        {
            entity.ToTable("consumerdb_ConsumerLogin");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_ConsumerLogin_TenantId");

            entity.Property(e => e.DeviceId)
                .HasMaxLength(40)
                .HasColumnName("DeviceID");
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GoogleId)
                .HasMaxLength(40)
                .HasColumnName("GoogleID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbConsumerProfile>(entity =>
        {
            entity.ToTable("consumerdb_ConsumerProfile");

            entity.HasIndex(e => e.MemberCode, "IX_consumerdb_ConsumerProfile_MemberCode");

            entity.HasIndex(e => new { e.Province, e.Status }, "IX_dea92_consumerdb_ConsumerProfile_Province_Status");

            entity.HasIndex(e => new { e.Province, e.Status }, "missing_index_659");

            entity.Property(e => e.AccumulationPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DistributorCode).HasMaxLength(40);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.InterestOf).HasMaxLength(255);
            entity.Property(e => e.IsInterestCobrand).HasColumnName("isInterestCobrand");
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MissingRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.Note1).HasMaxLength(255);
            entity.Property(e => e.Note2).HasMaxLength(255);
            entity.Property(e => e.Note3).HasMaxLength(255);
            entity.Property(e => e.Note4).HasMaxLength(255);
            entity.Property(e => e.Note5).HasMaxLength(255);
            entity.Property(e => e.OccupationCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pid)
                .HasMaxLength(20)
                .HasColumnName("PID");
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.ReferralCode).HasMaxLength(40);
            entity.Property(e => e.RegionCode).HasMaxLength(40);
            entity.Property(e => e.SalesManCode).HasMaxLength(40);
            entity.Property(e => e.SourceId)
                .HasMaxLength(20)
                .HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ward).HasMaxLength(50);
            entity.Property(e => e.ZaloName).HasMaxLength(255);
        });

        modelBuilder.Entity<ConsumerdbConsumerProfileArch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("consumerdb_ConsumerProfile_arch");

            entity.Property(e => e.AccumulationPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DistributorCode).HasMaxLength(40);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InterestOf).HasMaxLength(255);
            entity.Property(e => e.IsInterestCobrand).HasColumnName("isInterestCobrand");
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MissingRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.Note1).HasMaxLength(255);
            entity.Property(e => e.Note2).HasMaxLength(255);
            entity.Property(e => e.Note3).HasMaxLength(255);
            entity.Property(e => e.Note4).HasMaxLength(255);
            entity.Property(e => e.Note5).HasMaxLength(255);
            entity.Property(e => e.OccupationCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pid)
                .HasMaxLength(20)
                .HasColumnName("PID");
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.ReferralCode).HasMaxLength(40);
            entity.Property(e => e.RegionCode).HasMaxLength(40);
            entity.Property(e => e.SalesManCode).HasMaxLength(40);
            entity.Property(e => e.SourceId)
                .HasMaxLength(20)
                .HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ward).HasMaxLength(50);
            entity.Property(e => e.ZaloName).HasMaxLength(255);
        });

        modelBuilder.Entity<ConsumerdbDeleteProfileRequest>(entity =>
        {
            entity.ToTable("consumerdb_DeleteProfileRequest");

            entity.Property(e => e.ApproveBy).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.ReasonCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<ConsumerdbMasterDetail>(entity =>
        {
            entity.ToTable("consumerdb_MasterDetail", tb => tb.HasTrigger("tg_change_ProductHierarchy"));

            entity.HasIndex(e => e.DetailCode, "IX_consumerdb_MasterDetail_DetailCode");

            entity.HasIndex(e => new { e.Level, e.MasterCode, e.DetailCode }, "IX_consumerdb_MasterDetail_Level_MasterCode_DetailCode");

            entity.HasIndex(e => e.MasterCode, "IX_consumerdb_MasterDetail_MasterCode");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_MasterDetail_TenantId");

            entity.HasIndex(e => new { e.MasterCode, e.Level }, "missing_index_250");

            entity.HasIndex(e => new { e.MasterCode, e.Level }, "missing_index_41");

            entity.HasIndex(e => e.Level, "missing_index_5");

            entity.HasIndex(e => new { e.IsDeleted, e.MasterCode, e.Level }, "missing_index_75");

            entity.HasIndex(e => e.Level, "missing_index_912");

            entity.Property(e => e.DetailCode).HasMaxLength(40);
            entity.Property(e => e.DetailValue).HasMaxLength(255);
            entity.Property(e => e.DetailValueNumber).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.DetailValueUnSign).HasMaxLength(255);
            entity.Property(e => e.MasterCode).HasMaxLength(40);
            entity.Property(e => e.NodePath).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<ConsumerdbMasterDetail20230622>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("consumerdb_MasterDetail_20230622");

            entity.Property(e => e.DetailCodeL1).HasMaxLength(40);
            entity.Property(e => e.DetailCodeL2).HasMaxLength(40);
            entity.Property(e => e.DetailCodeL3).HasMaxLength(40);
            entity.Property(e => e.DetailCodeL4).HasMaxLength(40);
            entity.Property(e => e.DetailCodeL5).HasMaxLength(40);
            entity.Property(e => e.DetailValueL1).HasMaxLength(255);
            entity.Property(e => e.DetailValueL2).HasMaxLength(255);
            entity.Property(e => e.DetailValueL3).HasMaxLength(255);
            entity.Property(e => e.DetailValueL4).HasMaxLength(255);
            entity.Property(e => e.DetailValueL5).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<ConsumerdbMasterHeader>(entity =>
        {
            entity.ToTable("consumerdb_MasterHeader");

            entity.Property(e => e.MasterCode).HasMaxLength(40);
            entity.Property(e => e.MasterName).HasMaxLength(255);
            entity.Property(e => e.MasterNameUnSign).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<ConsumerdbPaymentTransaction>(entity =>
        {
            entity.ToTable("consumerdb_PaymentTransaction");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_PaymentTransaction_TenantId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PaymentMethod).HasMaxLength(10);
            entity.Property(e => e.SalesInvoiceCode).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbProduct>(entity =>
        {
            entity.ToTable("consumerdb_Product");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_Product_TenantId");

            entity.HasIndex(e => e.ProductCode, "missing_index_25");

            entity.HasIndex(e => new { e.IsNew, e.IsFeature }, "missing_index_33");

            entity.HasIndex(e => e.IsDeleted, "missing_index_430");

            entity.Property(e => e.BackupProductName1).HasMaxLength(250);
            entity.Property(e => e.BackupProductName1UnSign).HasMaxLength(250);
            entity.Property(e => e.ContentEn).HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn).HasColumnName("ContentVN");
            entity.Property(e => e.HierarchyL1).HasMaxLength(40);
            entity.Property(e => e.HierarchyL2).HasMaxLength(40);
            entity.Property(e => e.HierarchyL3).HasMaxLength(40);
            entity.Property(e => e.HierarchyL4).HasMaxLength(40);
            entity.Property(e => e.HierarchyL5).HasMaxLength(40);
            entity.Property(e => e.NewPrice).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.ProductCode).HasMaxLength(40);
            entity.Property(e => e.ProductName1).HasMaxLength(255);
            entity.Property(e => e.ProductName1UnSign).HasMaxLength(255);
            entity.Property(e => e.ProductName2).HasMaxLength(255);
            entity.Property(e => e.ProductName2UnSign).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Tag).HasMaxLength(255);
            entity.Property(e => e.Uomcode)
                .HasMaxLength(255)
                .HasColumnName("UOMCode");
        });

        modelBuilder.Entity<ConsumerdbQaticket>(entity =>
        {
            entity.ToTable("consumerdb_QATicket");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_QATicket_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.MemberNameUnsign).HasMaxLength(255);
            entity.Property(e => e.TicketCode).HasMaxLength(40);
            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<ConsumerdbRatingTicket>(entity =>
        {
            entity.ToTable("consumerdb_RatingTicket");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_RatingTicket_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberMobileNumber).HasMaxLength(20);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.OrderAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.OrderCode).HasMaxLength(40);
            entity.Property(e => e.Point).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.TicketCode).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbRelatedProduct>(entity =>
        {
            entity.ToTable("consumerdb_RelatedProduct");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_RelatedProduct_TenantId");
        });

        modelBuilder.Entity<ConsumerdbSalesInvoiceDetail>(entity =>
        {
            entity.ToTable("consumerdb_SalesInvoiceDetail");

            entity.HasIndex(e => e.MemberCode, "IX_consumerdb_SalesInvoiceDetail_MemberCode");

            entity.HasIndex(e => e.SalesInvoiceCode, "IX_consumerdb_SalesInvoiceDetail_SalesInvoiceCode");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_SalesInvoiceDetail_TenantId");

            entity.Property(e => e.Amount).HasColumnType("decimal(21, 3)");
            entity.Property(e => e.BrandCode).HasMaxLength(40);
            entity.Property(e => e.CategoryCode).HasMaxLength(40);
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DeptCode).HasMaxLength(40);
            entity.Property(e => e.Discount).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.DivCode).HasMaxLength(40);
            entity.Property(e => e.ItemCode).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.SalesInvoiceCode).HasMaxLength(40);
            entity.Property(e => e.Sellingprice).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.TerminalNo).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbSalesInvoiceHeader>(entity =>
        {
            entity.ToTable("consumerdb_SalesInvoiceHeader");

            entity.HasIndex(e => e.MemberCode, "IX_consumerdb_SalesInvoiceHeader_MemberCode");

            entity.HasIndex(e => e.SalesInvoiceCode, "IX_consumerdb_SalesInvoiceHeader_SalesInvoiceCode");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_SalesInvoiceHeader_TenantId");

            entity.Property(e => e.Allowance).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Point).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.SalesInvoiceCode).HasMaxLength(40);
            entity.Property(e => e.TerminalNo).HasMaxLength(40);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.TransactionType).HasMaxLength(50);
        });

        modelBuilder.Entity<ConsumerdbSurveySetting>(entity =>
        {
            entity.ToTable("consumerdb_SurveySetting");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_SurveySetting_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SurveyMonkeyCode).HasMaxLength(50);
            entity.Property(e => e.SurveyName).HasMaxLength(255);
            entity.Property(e => e.SurveyNameUnsign).HasMaxLength(255);
        });

        modelBuilder.Entity<ConsumerdbSurveyTicketDetail>(entity =>
        {
            entity.ToTable("consumerdb_SurveyTicketDetail");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_SurveyTicketDetail_TenantId");

            entity.Property(e => e.AnswerId)
                .HasMaxLength(40)
                .HasColumnName("AnswerID");
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.SurveyTransactionCode).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbSurveyTicketHeader>(entity =>
        {
            entity.ToTable("consumerdb_SurveyTicketHeader");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_SurveyTicketHeader_TenantId");

            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SurveyMonkeyCode).HasMaxLength(255);
            entity.Property(e => e.SurveyTransactionCode).HasMaxLength(40);
            entity.Property(e => e.SurveyUser).HasMaxLength(40);
        });

        modelBuilder.Entity<ConsumerdbTargetAudienceDetail>(entity =>
        {
            entity.ToTable("consumerdb_TargetAudienceDetail");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_TargetAudienceDetail_TenantId");

            entity.Property(e => e.ConditionName).HasMaxLength(40);
            entity.Property(e => e.ConditionType).HasMaxLength(20);
            entity.Property(e => e.Operator).HasMaxLength(50);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.ValueFromNumber).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValueToNumber).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ConsumerdbTargetAudienceHeader>(entity =>
        {
            entity.ToTable("consumerdb_TargetAudienceHeader");

            entity.Property(e => e.ConditionTopsorting)
                .HasMaxLength(40)
                .HasColumnName("ConditionTOPSorting");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.NumberOfMember).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.QuantityTopgroup)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("QuantityTOPGroup");
            entity.Property(e => e.ScheduleTime).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SelectTop).HasColumnName("SelectTOP");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
            entity.Property(e => e.TargetAudienceNameUnsign).HasMaxLength(255);
        });

        modelBuilder.Entity<ConsumerdbTargetAudienceUser>(entity =>
        {
            entity.ToTable("consumerdb_TargetAudienceUser");

            entity.HasIndex(e => e.MemberCode, "missing_index_5");

            entity.HasIndex(e => e.TargetAudienceId, "missing_index_910");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<ConsumerdbUserLogin>(entity =>
        {
            entity.ToTable("consumerdb_UserLogin");

            entity.HasIndex(e => e.TenantId, "IX_consumerdb_UserLogin_TenantId");

            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GoogleId)
                .HasMaxLength(40)
                .HasColumnName("GoogleID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(40);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer$");

            entity.Property(e => e.ChiNhánhNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Chi nhánh ngân hàng");
            entity.Property(e => e.Cmnd).HasColumnName("CMND");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.GhiChú)
                .HasMaxLength(255)
                .HasColumnName("Ghi chú");
            entity.Property(e => e.HệThống)
                .HasMaxLength(255)
                .HasColumnName("Hệ Thống");
            entity.Property(e => e.HọVàTênNgườiThụHưởng)
                .HasMaxLength(255)
                .HasColumnName("Họ và tên người thụ hưởng");
            entity.Property(e => e.Kênh).HasMaxLength(255);
            entity.Property(e => e.Loại).HasMaxLength(255);
            entity.Property(e => e.LoạiHìnhKinhDoanh)
                .HasMaxLength(255)
                .HasColumnName("Loại hình kinh doanh");
            entity.Property(e => e.MãCũ)
                .HasMaxLength(255)
                .HasColumnName("Mã cũ");
            entity.Property(e => e.MãMembercode)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode");
            entity.Property(e => e.MãMembercodeCha)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode cha");
            entity.Property(e => e.MãSốThuế)
                .HasMaxLength(255)
                .HasColumnName("Mã số thuế");
            entity.Property(e => e.MãTừSap)
                .HasMaxLength(255)
                .HasColumnName("Mã từ SAP");
            entity.Property(e => e.NgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Ngân hàng");
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/ Xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/ Huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốNhàTênĐườngXómẤp)
                .HasMaxLength(255)
                .HasColumnName("Số nhà, tên đường, xóm, ấp…");
            entity.Property(e => e.SốTàiKhoảnNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Số tài khoản ngân hàng");
            entity.Property(e => e.SốĐiệnThoại)
                .HasMaxLength(255)
                .HasColumnName("Số điện thoại");
            entity.Property(e => e.TrạngTháiHoạtĐộng)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái hoạt động");
            entity.Property(e => e.TênChủCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên chủ cửa hàng");
            entity.Property(e => e.TênCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên cửa hàng");
            entity.Property(e => e.TỉnhThành)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/ Thành");
            entity.Property(e => e.Vùng).HasMaxLength(255);
        });

        modelBuilder.Entity<Edition>(entity =>
        {
            entity.Property(e => e.AnnualPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DisplayName).HasMaxLength(64);
            entity.Property(e => e.MonthlyPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(32);
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.ToTable("EmailLog");

            entity.Property(e => e.EmailCc)
                .HasMaxLength(500)
                .HasColumnName("EmailCC");
            entity.Property(e => e.EmailFrom).HasMaxLength(250);
            entity.Property(e => e.EmailTo).HasMaxLength(250);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.ObjectId).HasMaxLength(50);
            entity.Property(e => e.ObjectType).HasMaxLength(100);
            entity.Property(e => e.Subject).HasMaxLength(500);
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasIndex(e => e.CommunicationId, "IX_EmailTemplates_CommunicationID");

            entity.HasIndex(e => e.TenantId, "IX_EmailTemplates_TenantId");

            entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.Communication).WithMany(p => p.EmailTemplates).HasForeignKey(d => d.CommunicationId);
        });

        modelBuilder.Entity<EntityChange>(entity =>
        {
            entity.HasIndex(e => e.EntityChangeSetId, "IX_EntityChanges_EntityChangeSetId");

            entity.HasIndex(e => new { e.EntityTypeFullName, e.EntityId }, "IX_EntityChanges_EntityTypeFullName_EntityId");

            entity.Property(e => e.EntityId).HasMaxLength(48);
            entity.Property(e => e.EntityTypeFullName).HasMaxLength(192);

            entity.HasOne(d => d.EntityChangeSet).WithMany(p => p.EntityChanges).HasForeignKey(d => d.EntityChangeSetId);
        });

        modelBuilder.Entity<EntityChangeSet>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.CreationTime }, "IX_EntityChangeSets_TenantId_CreationTime");

            entity.HasIndex(e => new { e.TenantId, e.Reason }, "IX_EntityChangeSets_TenantId_Reason");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_EntityChangeSets_TenantId_UserId");

            entity.Property(e => e.BrowserInfo).HasMaxLength(512);
            entity.Property(e => e.ClientIpAddress).HasMaxLength(64);
            entity.Property(e => e.ClientName).HasMaxLength(128);
            entity.Property(e => e.Reason).HasMaxLength(256);
        });

        modelBuilder.Entity<EntityPropertyChange>(entity =>
        {
            entity.HasIndex(e => e.EntityChangeId, "IX_EntityPropertyChanges_EntityChangeId");

            entity.Property(e => e.NewValue).HasMaxLength(512);
            entity.Property(e => e.OriginalValue).HasMaxLength(512);
            entity.Property(e => e.PropertyName).HasMaxLength(96);
            entity.Property(e => e.PropertyTypeFullName).HasMaxLength(192);

            entity.HasOne(d => d.EntityChange).WithMany(p => p.EntityPropertyChanges).HasForeignKey(d => d.EntityChangeId);
        });

        modelBuilder.Entity<ExtendActiveSerial>(entity =>
        {
            entity.Property(e => e.DeadlineSellMbs).HasColumnName("DeadlineSellMBS");
            entity.Property(e => e.DeadlineSellNpp).HasColumnName("DeadlineSellNPP");
        });

        modelBuilder.Entity<Feature>(entity =>
        {
            entity.HasIndex(e => new { e.EditionId, e.Name }, "IX_Features_EditionId_Name");

            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Features_TenantId_Name");

            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.Edition).WithMany(p => p.Features)
                .HasForeignKey(d => d.EditionId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<GamificationClaimMission>(entity =>
        {
            entity.HasKey(e => new { e.MemberCode, e.MissionCode });

            entity.ToTable("gamification_ClaimMission");

            entity.HasIndex(e => e.TenantId, "IX_gamification_ClaimMission_TenantId");

            entity.HasIndex(e => e.TransactionCode, "IX_gamification_ClaimMission_TransactionCode");
        });

        modelBuilder.Entity<GamificationEgiftGame>(entity =>
        {
            entity.ToTable("gamification_EgiftGame");

            entity.HasIndex(e => e.TenantId, "IX_gamification_EgiftGame_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.RewardCode).HasMaxLength(40);
            entity.Property(e => e.SerialCode).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UsedStatus).HasMaxLength(20);
        });

        modelBuilder.Entity<GamificationGameInfo>(entity =>
        {
            entity.ToTable("gamification_GameInfo");

            entity.HasIndex(e => e.TenantId, "IX_gamification_GameInfo_TenantId");

            entity.Property(e => e.ActionFilter).HasMaxLength(255);
            entity.Property(e => e.BackgroundImage).HasMaxLength(255);
            entity.Property(e => e.Event).HasMaxLength(40);
            entity.Property(e => e.GameCode).HasMaxLength(40);
            entity.Property(e => e.GameNameEn)
                .HasMaxLength(255)
                .HasColumnName("GameNameEN");
            entity.Property(e => e.GameNameVn)
                .HasMaxLength(255)
                .HasColumnName("GameNameVN");
            entity.Property(e => e.GameRuleImage).HasMaxLength(255);
            entity.Property(e => e.GameType).HasMaxLength(255);
            entity.Property(e => e.MaxRewardPerPlayer).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
            entity.Property(e => e.TimeToExpiredTicket).HasColumnType("decimal(12, 3)");
        });

        modelBuilder.Entity<GamificationGamePlayHistory>(entity =>
        {
            entity.ToTable("gamification_GamePlayHistory");

            entity.HasIndex(e => e.TenantId, "IX_gamification_GamePlayHistory_TenantId");

            entity.Property(e => e.GameCode).HasMaxLength(40);
            entity.Property(e => e.PlayerCode).HasMaxLength(40);
            entity.Property(e => e.RewardCode).HasMaxLength(40);
            entity.Property(e => e.RewardQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.TicketCode).HasMaxLength(40);
        });

        modelBuilder.Entity<GamificationGameReward>(entity =>
        {
            entity.ToTable("gamification_GameReward");

            entity.HasIndex(e => e.TenantId, "IX_gamification_GameReward_TenantId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Budget).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.GameCode).HasMaxLength(40);
            entity.Property(e => e.ImageLink).HasMaxLength(255);
            entity.Property(e => e.ItemCode).HasMaxLength(255);
            entity.Property(e => e.MaxPerPlayer).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Order).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RewardCode).HasMaxLength(40);
            entity.Property(e => e.RewardNameEn)
                .HasMaxLength(255)
                .HasColumnName("RewardNameEN");
            entity.Property(e => e.RewardNameVn)
                .HasMaxLength(255)
                .HasColumnName("RewardNameVN");
            entity.Property(e => e.RewardPartner).HasMaxLength(255);
            entity.Property(e => e.RewardType).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.VendorCode).HasMaxLength(40);
            entity.Property(e => e.WeightRatio).HasColumnType("decimal(12, 3)");
        });

        modelBuilder.Entity<GamificationGameTargetAudience>(entity =>
        {
            entity.ToTable("gamification_GameTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_gamification_GameTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<GamificationGameTargetAudienceDetail>(entity =>
        {
            entity.ToTable("gamification_GameTargetAudienceDetail");

            entity.HasIndex(e => e.TenantId, "IX_gamification_GameTargetAudienceDetail_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GameTargetAudienceId).HasColumnName("GameTargetAudienceID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<GamificationJoinQuest>(entity =>
        {
            entity.HasKey(e => new { e.MemberCode, e.QuestCode });

            entity.ToTable("gamification_JoinQuest");

            entity.HasIndex(e => e.TenantId, "IX_gamification_JoinQuest_TenantId");
        });

        modelBuilder.Entity<GamificationMission>(entity =>
        {
            entity.ToTable("gamification_Mission");

            entity.HasIndex(e => e.Code, "IX_gamification_Mission_Code");

            entity.HasIndex(e => e.QuestId, "IX_gamification_Mission_QuestId");

            entity.HasIndex(e => e.TenantId, "IX_gamification_Mission_TenantId");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.QuestCode).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(2);
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Quest).WithMany(p => p.GamificationMissions).HasForeignKey(d => d.QuestId);
        });

        modelBuilder.Entity<GamificationPlayerTicket>(entity =>
        {
            entity.ToTable("gamification_PlayerTicket");

            entity.HasIndex(e => e.TenantId, "IX_gamification_PlayerTicket_TenantId");

            entity.Property(e => e.GameCode).HasMaxLength(255);
            entity.Property(e => e.PlayerCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<GamificationQuest>(entity =>
        {
            entity.ToTable("gamification_Quest");

            entity.HasIndex(e => e.Code, "IX_gamification_Quest_Code");

            entity.HasIndex(e => e.TenantId, "IX_gamification_Quest_TenantId");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Rewarding).HasMaxLength(80);
            entity.Property(e => e.Status).HasMaxLength(2);
            entity.Property(e => e.Tag).HasMaxLength(80);
        });

        modelBuilder.Entity<GamificationQuestGroup>(entity =>
        {
            entity.ToTable("gamification_QuestGroup");

            entity.HasIndex(e => e.Code, "IX_gamification_QuestGroup_Code");

            entity.HasIndex(e => e.TenantId, "IX_gamification_QuestGroup_TenantId");

            entity.Property(e => e.Code).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(2);
        });

        modelBuilder.Entity<GamificationQuestGroupDetail>(entity =>
        {
            entity.HasKey(e => new { e.QuestGroupId, e.QuestId });

            entity.ToTable("gamification_QuestGroupDetail");

            entity.HasIndex(e => e.QuestId, "IX_gamification_QuestGroupDetail_QuestId");

            entity.HasIndex(e => e.TenantId, "IX_gamification_QuestGroupDetail_TenantId");

            entity.HasOne(d => d.QuestGroup).WithMany(p => p.GamificationQuestGroupDetails).HasForeignKey(d => d.QuestGroupId);

            entity.HasOne(d => d.Quest).WithMany(p => p.GamificationQuestGroupDetails).HasForeignKey(d => d.QuestId);
        });

        modelBuilder.Entity<GamificationTransferTransaction>(entity =>
        {
            entity.ToTable("gamification_TransferTransaction");

            entity.HasIndex(e => new { e.TenantId, e.FromMemberCode }, "IX_gamification_TransferTransaction_TenantId_FromMemberCode");

            entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<GiftGiftCampaign>(entity =>
        {
            entity.ToTable("gift_GiftCampaign");

            entity.HasIndex(e => e.TenantId, "IX_gift_GiftCampaign_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Cron).HasMaxLength(20);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.GiftMasterCode).HasMaxLength(40);
            entity.Property(e => e.GiftMasterName).HasMaxLength(50);
            entity.Property(e => e.GiftMasterValue).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NameUnsign).HasMaxLength(50);
            entity.Property(e => e.PublisherCode).HasMaxLength(40);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RemainingQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
        });

        modelBuilder.Entity<GiftGiftCampaignTargetAudience>(entity =>
        {
            entity.ToTable("gift_GiftCampaignTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_gift_GiftCampaignTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<GiftGiftCampaignTargetAudienceDetail>(entity =>
        {
            entity.ToTable("gift_GiftCampaignTargetAudienceDetail");

            entity.HasIndex(e => e.TenantId, "IX_gift_GiftCampaignTargetAudienceDetail_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GiftTargetAudienceId).HasColumnName("GiftTargetAudienceID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<GiftGiftMaster>(entity =>
        {
            entity.ToTable("gift_GiftMaster");

            entity.HasIndex(e => e.TenantId, "IX_gift_GiftMaster_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnsign).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.ProductType).HasMaxLength(20);
            entity.Property(e => e.Publisher).HasMaxLength(20);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<GiftGiftTransaction>(entity =>
        {
            entity.ToTable("gift_GiftTransaction");

            entity.HasIndex(e => e.TenantId, "IX_gift_GiftTransaction_TenantId");

            entity.Property(e => e.GiftCampaignCode).HasMaxLength(40);
            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.GiftMasterCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletName).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(40)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<GiftUnavailableGift>(entity =>
        {
            entity.ToTable("gift_UnavailableGift");

            entity.HasIndex(e => e.TenantId, "IX_gift_UnavailableGift_TenantId");

            entity.Property(e => e.GiftCampaignCode).HasMaxLength(40);
            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.GiftMasterCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletName).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TransactionId)
                .HasMaxLength(40)
                .HasColumnName("TransactionID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<L2Tracer>(entity =>
        {
            entity.HasKey(e => e.RowNumber).HasName("PK__L2_Trace__AAAC09D8FD6ADDCF");

            entity.ToTable("L2_Tracer");

            entity.Property(e => e.ApplicationName).HasMaxLength(128);
            entity.Property(e => e.BinaryData).HasColumnType("image");
            entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");
            entity.Property(e => e.Cpu).HasColumnName("CPU");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.LoginName).HasMaxLength(128);
            entity.Property(e => e.NtuserName)
                .HasMaxLength(128)
                .HasColumnName("NTUserName");
            entity.Property(e => e.Spid).HasColumnName("SPID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TextData).HasColumnType("ntext");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Languages_TenantId_Name");

            entity.Property(e => e.DisplayName).HasMaxLength(64);
            entity.Property(e => e.Icon).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(10);
        });

        modelBuilder.Entity<LanguageText>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Source, e.LanguageName, e.Key }, "IX_LanguageTexts_TenantId_Source_LanguageName_Key");

            entity.Property(e => e.Key).HasMaxLength(256);
            entity.Property(e => e.LanguageName).HasMaxLength(10);
            entity.Property(e => e.Source).HasMaxLength(128);
        });

        modelBuilder.Entity<LogMt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Log_MT");

            entity.Property(e => e.IsMt).HasColumnName("IsMT");
            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<LogSpGetFileExcelSummaryProductExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("log_sp_GetFileExcelSummaryProduct_Export");

            entity.Property(e => e.Params).HasMaxLength(255);
        });

        modelBuilder.Entity<MemberWarehouseValidateLog>(entity =>
        {
            entity.ToTable("MemberWarehouseValidateLog");

            entity.Property(e => e.CompareLat)
                .HasMaxLength(40)
                .HasColumnName("CompareLAT");
            entity.Property(e => e.CompareLng)
                .HasMaxLength(40)
                .HasColumnName("CompareLNG");
            entity.Property(e => e.CurrentLat)
                .HasMaxLength(40)
                .HasColumnName("CurrentLAT");
            entity.Property(e => e.CurrentLng)
                .HasMaxLength(40)
                .HasColumnName("CurrentLNG");
            entity.Property(e => e.IsMockGps).HasColumnName("IsMockGPS");
            entity.Property(e => e.MemberCode).HasMaxLength(64);
            entity.Property(e => e.MemberWarehouseName).HasMaxLength(255);
            entity.Property(e => e.Message).HasMaxLength(1000);
        });

        modelBuilder.Entity<MigrationSerial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MigrationSerial");

            entity.Property(e => e.Productcode).HasMaxLength(255);
            entity.Property(e => e.Serial).HasMaxLength(255);
        });

        modelBuilder.Entity<NewCustomer2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NewCustomer2$");

            entity.Property(e => e.ChiNhánhNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Chi nhánh ngân hàng");
            entity.Property(e => e.Cmnd).HasColumnName("CMND");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.GhiChú)
                .HasMaxLength(255)
                .HasColumnName("Ghi chú");
            entity.Property(e => e.HệThống)
                .HasMaxLength(255)
                .HasColumnName("Hệ Thống");
            entity.Property(e => e.HọVàTênNgườiThụHưởng)
                .HasMaxLength(255)
                .HasColumnName("Họ và tên người thụ hưởng");
            entity.Property(e => e.Kênh).HasMaxLength(255);
            entity.Property(e => e.Loại).HasMaxLength(255);
            entity.Property(e => e.LoạiHìnhKinhDoanh)
                .HasMaxLength(255)
                .HasColumnName("Loại hình kinh doanh");
            entity.Property(e => e.MãCũ)
                .HasMaxLength(255)
                .HasColumnName("Mã cũ");
            entity.Property(e => e.MãMembercode)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode");
            entity.Property(e => e.MãMembercodeCha)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode cha");
            entity.Property(e => e.MãSốThuế)
                .HasMaxLength(255)
                .HasColumnName("Mã số thuế");
            entity.Property(e => e.MãTừSap)
                .HasMaxLength(255)
                .HasColumnName("Mã từ SAP");
            entity.Property(e => e.NgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Ngân hàng");
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/ Xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/ Huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốNhàTênĐườngXómẤp)
                .HasMaxLength(255)
                .HasColumnName("Số nhà, tên đường, xóm, ấp…");
            entity.Property(e => e.SốTàiKhoảnNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Số tài khoản ngân hàng");
            entity.Property(e => e.SốĐiệnThoại)
                .HasMaxLength(255)
                .HasColumnName("Số điện thoại");
            entity.Property(e => e.TrạngTháiHoạtĐộng)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái hoạt động");
            entity.Property(e => e.TênChủCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên chủ cửa hàng");
            entity.Property(e => e.TênCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên cửa hàng");
            entity.Property(e => e.TỉnhThành)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/ Thành");
            entity.Property(e => e.Vùng).HasMaxLength(255);
        });

        modelBuilder.Entity<Newcusomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Newcusomer$");

            entity.Property(e => e.ChiNhánhNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Chi nhánh ngân hàng");
            entity.Property(e => e.Cmnd).HasColumnName("CMND");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.GhiChú)
                .HasMaxLength(255)
                .HasColumnName("Ghi chú");
            entity.Property(e => e.HệThống)
                .HasMaxLength(255)
                .HasColumnName("Hệ Thống");
            entity.Property(e => e.HọVàTênNgườiThụHưởng)
                .HasMaxLength(255)
                .HasColumnName("Họ và tên người thụ hưởng");
            entity.Property(e => e.Kênh).HasMaxLength(255);
            entity.Property(e => e.Loại).HasMaxLength(255);
            entity.Property(e => e.LoạiHìnhKinhDoanh)
                .HasMaxLength(255)
                .HasColumnName("Loại hình kinh doanh");
            entity.Property(e => e.MãCũ)
                .HasMaxLength(255)
                .HasColumnName("Mã cũ");
            entity.Property(e => e.MãMembercode)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode");
            entity.Property(e => e.MãMembercodeCha)
                .HasMaxLength(255)
                .HasColumnName("Mã Membercode cha");
            entity.Property(e => e.MãSốThuế)
                .HasMaxLength(255)
                .HasColumnName("Mã số thuế");
            entity.Property(e => e.MãTừSap)
                .HasMaxLength(255)
                .HasColumnName("Mã từ SAP");
            entity.Property(e => e.NgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Ngân hàng");
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/ Xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/ Huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốNhàTênĐườngXómẤp)
                .HasMaxLength(255)
                .HasColumnName("Số nhà, tên đường, xóm, ấp…");
            entity.Property(e => e.SốTàiKhoảnNgânHàng)
                .HasMaxLength(255)
                .HasColumnName("Số tài khoản ngân hàng");
            entity.Property(e => e.SốĐiệnThoại)
                .HasMaxLength(255)
                .HasColumnName("Số điện thoại");
            entity.Property(e => e.TrạngTháiHoạtĐộng)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái hoạt động");
            entity.Property(e => e.TênChủCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên chủ cửa hàng");
            entity.Property(e => e.TênCửaHàng)
                .HasMaxLength(255)
                .HasColumnName("Tên cửa hàng");
            entity.Property(e => e.TỉnhThành)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/ Thành");
            entity.Property(e => e.Vùng).HasMaxLength(255);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataTypeName).HasMaxLength(512);
            entity.Property(e => e.EntityId).HasMaxLength(96);
            entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);
            entity.Property(e => e.EntityTypeName).HasMaxLength(250);
            entity.Property(e => e.NotificationName).HasMaxLength(96);
        });

        modelBuilder.Entity<NotificationAppPushTransaction>(entity =>
        {
            entity.ToTable("notification_AppPushTransaction");

            entity.HasIndex(e => new { e.Receiver, e.Title, e.Status, e.CreationTime }, "missing_index_119");

            entity.HasIndex(e => new { e.Receiver, e.Status }, "missing_index_15");

            entity.HasIndex(e => e.Receiver, "missing_index_699");

            entity.Property(e => e.Receiver).HasMaxLength(40);
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.Sender).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<NotificationChannel>(entity =>
        {
            entity.ToTable("notification_Channel");

            entity.HasIndex(e => e.TenantId, "IX_notification_Channel_TenantId");

            entity.Property(e => e.ChannelCode).HasMaxLength(40);
            entity.Property(e => e.ChannelDescription).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<NotificationChannelConfig>(entity =>
        {
            entity.ToTable("notification_ChannelConfig");

            entity.HasIndex(e => e.ChannelId, "IX_notification_ChannelConfig_ChannelId");

            entity.HasIndex(e => e.TenantId, "IX_notification_ChannelConfig_TenantId");

            entity.Property(e => e.ChannelCode).HasMaxLength(40);
            entity.Property(e => e.ChannelType).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.Channel).WithMany(p => p.NotificationChannelConfigs).HasForeignKey(d => d.ChannelId);
        });

        modelBuilder.Entity<NotificationLog>(entity =>
        {
            entity.ToTable("notification_Log");

            entity.Property(e => e.ChannelCode).HasMaxLength(40);
            entity.Property(e => e.ChannelMemberId)
                .HasMaxLength(1000)
                .HasColumnName("ChannelMemberID");
            entity.Property(e => e.ChannelTransactionId)
                .HasMaxLength(40)
                .HasColumnName("ChannelTransactionID");
            entity.Property(e => e.Receiver).HasMaxLength(40);
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.Sender).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.TriggerBy).HasMaxLength(40);
            entity.Property(e => e.TriggerName).HasMaxLength(40);
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<NotificationNotificationUser>(entity =>
        {
            entity.ToTable("notification_NotificationUser");

            entity.HasIndex(e => e.TenantId, "IX_notification_NotificationUser_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(10);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.MemberNameUnsign).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(15);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<NotificationSubscription>(entity =>
        {
            entity.HasIndex(e => new { e.NotificationName, e.EntityTypeName, e.EntityId, e.UserId }, "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EntityId).HasMaxLength(96);
            entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);
            entity.Property(e => e.EntityTypeName).HasMaxLength(250);
            entity.Property(e => e.NotificationName).HasMaxLength(96);
        });

        modelBuilder.Entity<NotificationTemplate>(entity =>
        {
            entity.ToTable("notification_Template");

            entity.HasIndex(e => e.TenantId, "IX_notification_Template_TenantId");

            entity.Property(e => e.ChannelCode).HasMaxLength(40);
            entity.Property(e => e.ContentEn).HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn).HasColumnName("ContentVN");
            entity.Property(e => e.Sender).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TemplateName).HasMaxLength(255);
            entity.Property(e => e.TemplateNameUnSign).HasMaxLength(255);
            entity.Property(e => e.TitleEn)
                .HasMaxLength(255)
                .HasColumnName("TitleEN");
            entity.Property(e => e.TitleVn)
                .HasMaxLength(255)
                .HasColumnName("TitleVN");
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<Nv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NV$");

            entity.Property(e => e.ChứcDanh)
                .HasMaxLength(255)
                .HasColumnName("Chức danh");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.MậtKhẩu)
                .HasMaxLength(255)
                .HasColumnName("Mật khẩu");
            entity.Property(e => e.NhânSựQuảnLý)
                .HasMaxLength(255)
                .HasColumnName("Nhân sự quản lý");
            entity.Property(e => e.PhạmViPhụTrách)
                .HasMaxLength(255)
                .HasColumnName("Phạm vi phụ trách");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốĐiệnThoại)
                .HasMaxLength(255)
                .HasColumnName("Số điện thoại");
            entity.Property(e => e.TrạngThái)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái");
            entity.Property(e => e.TênNhânViên)
                .HasMaxLength(255)
                .HasColumnName("Tên nhân viên");
            entity.Property(e => e.XácThựcOffice365)
                .HasMaxLength(255)
                .HasColumnName("Xác thực Office 365");
        });

        modelBuilder.Entity<OneTimePassword>(entity =>
        {
            entity.ToTable("OneTimePassword");

            entity.HasIndex(e => new { e.PhoneNumer, e.Type, e.CreationTime }, "missing_index_77");

            entity.HasIndex(e => new { e.Otp, e.PhoneNumer, e.Type }, "missing_index_90");

            entity.Property(e => e.AuthenOtpdateTime).HasColumnName("AuthenOTPDateTime");
            entity.Property(e => e.Otp)
                .HasMaxLength(8)
                .HasColumnName("OTP");
            entity.Property(e => e.PhoneNumer).HasMaxLength(40);
            entity.Property(e => e.Smscontent).HasColumnName("SMSContent");
            entity.Property(e => e.Type).HasMaxLength(40);
            entity.Property(e => e.UtcexpiredTime).HasColumnName("UTCExpiredTime");
        });

        modelBuilder.Entity<OrganizationUnit>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_OrganizationUnits_ParentId");

            entity.HasIndex(e => new { e.TenantId, e.Code }, "IX_OrganizationUnits_TenantId_Code");

            entity.Property(e => e.Code).HasMaxLength(95);
            entity.Property(e => e.DisplayName).HasMaxLength(128);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<Outlet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Outlet");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.AreaCode).HasMaxLength(40);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(40);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.BossName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.DistrictCode).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletType).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Province).HasMaxLength(255);
            entity.Property(e => e.ProvinceCode).HasMaxLength(40);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.RegionCode).HasMaxLength(40);
        });

        modelBuilder.Entity<OutletDepartment>(entity =>
        {
            entity.HasIndex(e => e.MemberCode, "IX_OutletDepartments_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_OutletDepartments_TenantId");

            entity.Property(e => e.DeptCode).HasMaxLength(200);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
        });

        modelBuilder.Entity<PaymentHistoryLog>(entity =>
        {
            entity.HasIndex(e => e.SaleId, "IX_PaymentHistoryLogs_SaleID");

            entity.Property(e => e.PaymentNotes).HasMaxLength(512);
            entity.Property(e => e.SaleId).HasColumnName("SaleID");
            entity.Property(e => e.SystemCoin).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_Permissions_RoleId");

            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Permissions_TenantId_Name");

            entity.HasIndex(e => e.UserId, "IX_Permissions_UserId");

            entity.HasIndex(e => e.RoleId, "missing_index_31");

            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.Role).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.User).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<PersistedGrant>(entity =>
        {
            entity.HasIndex(e => new { e.SubjectId, e.ClientId, e.Type }, "IX_PersistedGrants_SubjectId_ClientId_Type");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.ClientId).HasMaxLength(200);
            entity.Property(e => e.SubjectId).HasMaxLength(200);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<PointAction>(entity =>
        {
            entity.ToTable("point_Action");

            entity.HasIndex(e => e.Code, "IX_point_Action_Code");

            entity.HasIndex(e => e.TenantId, "IX_point_Action_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointActionRuleSetting>(entity =>
        {
            entity.ToTable("point_ActionRuleSetting");

            entity.HasIndex(e => e.ActionId, "IX_point_ActionRuleSetting_ActionId");

            entity.HasIndex(e => e.CampaignId, "IX_point_ActionRuleSetting_CampaignId");

            entity.HasIndex(e => e.Code, "IX_point_ActionRuleSetting_Code").IsUnique();

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_ActionRuleSetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_ActionRuleSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EndTime).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.StartTime).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);

            entity.HasOne(d => d.Action).WithMany(p => p.PointActionRuleSettings).HasForeignKey(d => d.ActionId);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointActionRuleSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointActionRuleSettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointActionTransaction>(entity =>
        {
            entity.ToTable("point_ActionTransaction");

            entity.HasIndex(e => e.ActionCode, "IX_point_ActionTransaction_ActionCode");

            entity.HasIndex(e => e.ActionId, "IX_point_ActionTransaction_ActionId");

            entity.HasIndex(e => e.MemberCode, "IX_point_ActionTransaction_MemberCode");

            entity.HasIndex(e => e.MemberId, "IX_point_ActionTransaction_MemberId");

            entity.HasIndex(e => e.TenantId, "IX_point_ActionTransaction_TenantId");

            entity.HasIndex(e => e.TransactionCode, "IX_point_ActionTransaction_TransactionCode");

            entity.HasIndex(e => e.TransactionId1, "IX_point_ActionTransaction_TransactionId1");

            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TransactionCode).HasMaxLength(255);

            entity.HasOne(d => d.Action).WithMany(p => p.PointActionTransactions).HasForeignKey(d => d.ActionId);

            entity.HasOne(d => d.Member).WithMany(p => p.PointActionTransactions).HasForeignKey(d => d.MemberId);

            entity.HasOne(d => d.TransactionId1Navigation).WithMany(p => p.PointActionTransactions).HasForeignKey(d => d.TransactionId1);
        });

        modelBuilder.Entity<PointActiveMemberByMonth>(entity =>
        {
            entity.ToTable("point_ActiveMemberByMonth");

            entity.HasIndex(e => e.TenantId, "IX_point_ActiveMemberByMonth_TenantId");
        });

        modelBuilder.Entity<PointActiveMemberYearToDate>(entity =>
        {
            entity.ToTable("point_ActiveMemberYearToDate");

            entity.HasIndex(e => e.TenantId, "IX_point_ActiveMemberYearToDate_TenantId");
        });

        modelBuilder.Entity<PointAdjustmentFileStatus>(entity =>
        {
            entity.ToTable("point_AdjustmentFileStatus");

            entity.HasIndex(e => e.TenantId, "IX_point_AdjustmentFileStatus_TenantId");

            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<PointBaseSetting>(entity =>
        {
            entity.ToTable("point_BaseSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_BaseSetting_CampaignId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_BaseSetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_BaseSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointBaseSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointBaseSettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointButtonInteractionOverview>(entity =>
        {
            entity.ToTable("point_ButtonInteractionOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_ButtonInteractionOverview_TenantId");

            entity.Property(e => e.ButtonEvent).HasMaxLength(100);
            entity.Property(e => e.TotalCountInteraction).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<PointCampaign>(entity =>
        {
            entity.ToTable("point_Campaign");

            entity.Property(e => e.CampaignType).HasMaxLength(40);
            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EstimatedBudget).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstimatedMembers).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstimatedRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointCampaignOverview>(entity =>
        {
            entity.ToTable("point_CampaignOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_CampaignOverview_TenantId");

            entity.Property(e => e.Revenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalMember).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointCampaignPerformanceOverview>(entity =>
        {
            entity.ToTable("point_CampaignPerformanceOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_CampaignPerformanceOverview_TenantId");

            entity.Property(e => e.NumberOfFail).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.NumberOfReceived).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.NumberOfSeen).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.NumberOfSent).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<PointChannelType>(entity =>
        {
            entity.ToTable("point_ChannelType");

            entity.HasIndex(e => e.TenantId, "IX_point_ChannelType_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointClass>(entity =>
        {
            entity.ToTable("point_Class");

            entity.HasIndex(e => e.TenantId, "IX_point_Class_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointCoinBaseline>(entity =>
        {
            entity.ToTable("point_CoinBaseline");

            entity.HasIndex(e => e.TenantId, "IX_point_CoinBaseline_TenantId");

            entity.Property(e => e.CoinAvailable).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoinGranted).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoinRedeemed).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
        });

        modelBuilder.Entity<PointCoinExpirationSetting>(entity =>
        {
            entity.ToTable("point_CoinExpirationSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_CoinExpirationSetting_TenantId");

            entity.Property(e => e.CalculationType).HasMaxLength(20);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(10);
            entity.Property(e => e.ValidCoinType).HasMaxLength(20);
        });

        modelBuilder.Entity<PointCoinOverview>(entity =>
        {
            entity.ToTable("point_CoinOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_CoinOverview_TenantId");

            entity.Property(e => e.CoinGrant).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoinRedeem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExpiredCoin).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointCoinUsageHistory>(entity =>
        {
            entity.ToTable("point_CoinUsageHistory");

            entity.HasIndex(e => e.TenantId, "IX_point_CoinUsageHistory_TenantId");

            entity.Property(e => e.CoinUsed).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.LastCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TransactionCode).HasMaxLength(255);
            entity.Property(e => e.TransactionCoinBaselineId).HasColumnName("TransactionCoinBaselineID");
        });

        modelBuilder.Entity<PointCost>(entity =>
        {
            entity.ToTable("point_Cost");

            entity.HasIndex(e => e.TenantId, "IX_point_Cost_TenantId");

            entity.Property(e => e.CoinAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EstimateCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointCusLevelGeo>(entity =>
        {
            entity.ToTable("point_CusLevelGEO");

            entity.HasIndex(e => e.CustCd, "IX_point_CusLevelGEO_CUST_CD");

            entity.HasIndex(e => e.TenantId, "IX_point_CusLevelGEO_TenantId");

            entity.Property(e => e.CustCd)
                .HasMaxLength(255)
                .HasColumnName("CUST_CD");
            entity.Property(e => e.NameLevel1)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_1");
            entity.Property(e => e.NameLevel2)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_2");
            entity.Property(e => e.NameLevel3)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_3");
            entity.Property(e => e.NameLevel4)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_4");
            entity.Property(e => e.NameLevel5)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_5");
            entity.Property(e => e.NameLevel6)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_6");
            entity.Property(e => e.NameLevel7)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_7");
            entity.Property(e => e.NameLevel8)
                .HasMaxLength(255)
                .HasColumnName("Name_Level_8");
            entity.Property(e => e.SlsRegionLevel1)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_1");
            entity.Property(e => e.SlsRegionLevel2)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_2");
            entity.Property(e => e.SlsRegionLevel3)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_3");
            entity.Property(e => e.SlsRegionLevel4)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_4");
            entity.Property(e => e.SlsRegionLevel5)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_5");
            entity.Property(e => e.SlsRegionLevel6)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_6");
            entity.Property(e => e.SlsRegionLevel7)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_7");
            entity.Property(e => e.SlsRegionLevel8)
                .HasMaxLength(50)
                .HasColumnName("SlsRegion_Level_8");
        });

        modelBuilder.Entity<PointDeparment>(entity =>
        {
            entity.ToTable("point_Deparment");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointDistributor>(entity =>
        {
            entity.ToTable("point_Distributor");

            entity.HasIndex(e => e.TenantId, "IX_point_Distributor_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointEgift>(entity =>
        {
            entity.ToTable("point_EGift");

            entity.HasIndex(e => e.GiftId, "IX_point_EGift_GiftId");

            entity.HasIndex(e => e.TenantId, "IX_point_EGift_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.SerialCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(40);
            entity.Property(e => e.UsedStatus).HasMaxLength(255);

            entity.HasOne(d => d.Gift).WithMany(p => p.PointEgifts).HasForeignKey(d => d.GiftId);
        });

        modelBuilder.Entity<PointEventSetting>(entity =>
        {
            entity.ToTable("point_EventSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_EventSetting_CampaignId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_EventSetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_EventSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointEventSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointEventSettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointEventSettingAmount>(entity =>
        {
            entity.ToTable("point_EventSettingAmount");

            entity.HasIndex(e => e.EventSettingId, "IX_point_EventSettingAmount_EventSettingId");

            entity.HasIndex(e => e.TenantId, "IX_point_EventSettingAmount_TenantId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.EventSetting).WithMany(p => p.PointEventSettingAmounts).HasForeignKey(d => d.EventSettingId);
        });

        modelBuilder.Entity<PointEventSubscriptionDetail>(entity =>
        {
            entity.ToTable("point_EventSubscriptionDetail");

            entity.HasIndex(e => e.TenantId, "IX_point_EventSubscriptionDetail_TenantId");

            entity.Property(e => e.EventTemplateGroup).HasMaxLength(100);
            entity.Property(e => e.EventTemplateId)
                .HasMaxLength(450)
                .HasColumnName("EventTemplateID");
        });

        modelBuilder.Entity<PointEventSubscriptionHeader>(entity =>
        {
            entity.ToTable("point_EventSubscriptionHeader");

            entity.HasIndex(e => e.SettingParamId, "IX_point_EventSubscriptionHeader_SettingParamId");

            entity.HasIndex(e => e.TenantId, "IX_point_EventSubscriptionHeader_TenantId")
                .IsUnique()
                .HasFilter("([TenantId] IS NOT NULL)");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.SecretKey).HasMaxLength(100);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("URL");

            entity.HasOne(d => d.SettingParam).WithMany(p => p.PointEventSubscriptionHeaders).HasForeignKey(d => d.SettingParamId);
        });

        modelBuilder.Entity<PointFormulaSetting>(entity =>
        {
            entity.ToTable("point_FormulaSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_FormulaSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.DefaultBaseCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultBasePoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultEventCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultEventPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProductCategoryCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProductCategoryPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProductCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultProductPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultRankCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultRankPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultReturnBaseCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultReturnBasePoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultSpecialCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultSpecialPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointGift>(entity =>
        {
            entity.ToTable("point_Gift");

            entity.HasIndex(e => e.GiftGroupId, "IX_point_Gift_GiftGroupId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_Gift_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_Gift_TenantId");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullGiftCategoryCode).HasMaxLength(512);
            entity.Property(e => e.GiftTargetAudienceId).HasColumnName("GiftTargetAudienceID");
            entity.Property(e => e.GiftType).HasMaxLength(255);
            entity.Property(e => e.IsEgift).HasColumnName("IsEGift");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Producer).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.RemainingQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RequiredCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(1);
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
            entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsedQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vendor).HasMaxLength(255);

            entity.HasOne(d => d.GiftGroup).WithMany(p => p.PointGifts).HasForeignKey(d => d.GiftGroupId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointGifts).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointGiftCategory>(entity =>
        {
            entity.ToTable("point_GiftCategory");

            entity.HasIndex(e => e.ParentId, "IX_point_GiftCategory_ParentId");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftCategory_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(40);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);
        });

        modelBuilder.Entity<PointGiftGroup>(entity =>
        {
            entity.ToTable("point_GiftGroup");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftGroup_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);
        });

        modelBuilder.Entity<PointGiftGroupDetail>(entity =>
        {
            entity.ToTable("point_GiftGroupDetail");

            entity.HasIndex(e => e.GiftGroupId, "IX_point_GiftGroupDetail_GiftGroupId");

            entity.HasIndex(e => e.GiftId, "IX_point_GiftGroupDetail_GiftId");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftGroupDetail_TenantId");

            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.GiftGroupCode).HasMaxLength(40);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);

            entity.HasOne(d => d.GiftGroup).WithMany(p => p.PointGiftGroupDetails).HasForeignKey(d => d.GiftGroupId);

            entity.HasOne(d => d.Gift).WithMany(p => p.PointGiftGroupDetails).HasForeignKey(d => d.GiftId);
        });

        modelBuilder.Entity<PointGiftRedeemLog>(entity =>
        {
            entity.ToTable("point_GiftRedeemLog");

            entity.Property(e => e.GiftCode).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.TransactionCode).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<PointGiftRedeemTransaction>(entity =>
        {
            entity.ToTable("point_GiftRedeemTransaction");

            entity.HasIndex(e => e.GiftId, "IX_point_GiftRedeemTransaction_GiftId");

            entity.HasIndex(e => e.MemberId, "IX_point_GiftRedeemTransaction_MemberId");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftRedeemTransaction_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EgiftCode)
                .HasMaxLength(1000)
                .HasColumnName("EGiftCode");
            entity.Property(e => e.EgiftStatus)
                .HasMaxLength(40)
                .HasColumnName("EGiftStatus");
            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.GiftName).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(40);

            entity.HasOne(d => d.Gift).WithMany(p => p.PointGiftRedeemTransactions).HasForeignKey(d => d.GiftId);

            entity.HasOne(d => d.Member).WithMany(p => p.PointGiftRedeemTransactions).HasForeignKey(d => d.MemberId);
        });

        modelBuilder.Entity<PointGiftTargetAudience>(entity =>
        {
            entity.ToTable("point_GiftTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<PointGiftTargetAudienceDetail>(entity =>
        {
            entity.ToTable("point_GiftTargetAudienceDetail");

            entity.HasIndex(e => e.TenantId, "IX_point_GiftTargetAudienceDetail_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GiftTargetAudienceId).HasColumnName("GiftTargetAudienceID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<PointImageLink>(entity =>
        {
            entity.ToTable("point_ImageLink");

            entity.HasIndex(e => e.TenantId, "IX_point_ImageLink_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.FullLink).HasMaxLength(512);
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Link).HasMaxLength(512);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<PointInteractiveTimeRange>(entity =>
        {
            entity.ToTable("point_InteractiveTimeRange");

            entity.HasIndex(e => e.TenantId, "IX_point_InteractiveTimeRange_TenantId");

            entity.Property(e => e.TimeRange).HasMaxLength(100);
            entity.Property(e => e.TotalCountInteraction).HasColumnType("decimal(10, 0)");
        });

        modelBuilder.Entity<PointMember>(entity =>
        {
            entity.ToTable("point_Member");

            entity.HasIndex(e => e.MemberCode, "IX_point_Member_MemberCode").IsUnique();

            entity.HasIndex(e => e.MemberLoyaltyInfoId, "IX_point_Member_MemberLoyaltyInfoId");

            entity.Property(e => e.Cards).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.FullChannelTypeCode).HasMaxLength(1000);
            entity.Property(e => e.FullMemberTypeCode).HasMaxLength(1000);
            entity.Property(e => e.FullRegionCode).HasMaxLength(1000);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdCard).HasMaxLength(30);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(500);
            entity.Property(e => e.MemberTypeCode).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.RankTypeCode).HasMaxLength(255);
            entity.Property(e => e.ReferenceInfo).HasMaxLength(2000);
            entity.Property(e => e.ReferralCode).HasMaxLength(500);
            entity.Property(e => e.RegionCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);

            entity.HasOne(d => d.MemberLoyaltyInfo).WithMany(p => p.PointMembers).HasForeignKey(d => d.MemberLoyaltyInfoId);
        });

        modelBuilder.Entity<PointMemberActivityRule>(entity =>
        {
            entity.ToTable("point_MemberActivityRule");

            entity.HasIndex(e => new { e.MemberStatus, e.Type, e.TenantId }, "IX_point_MemberActivityRule_MemberStatus_Type_TenantId")
                .IsUnique()
                .HasFilter("([MemberStatus] IS NOT NULL AND [Type] IS NOT NULL AND [TenantId] IS NOT NULL)");

            entity.HasIndex(e => e.TenantId, "IX_point_MemberActivityRule_TenantId");

            entity.Property(e => e.MemberStatus).HasMaxLength(1);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<PointMemberArch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("point_Member_arch");

            entity.Property(e => e.Cards).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.ContractCode).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.FullChannelTypeCode).HasMaxLength(1000);
            entity.Property(e => e.FullMemberTypeCode).HasMaxLength(1000);
            entity.Property(e => e.FullRegionCode).HasMaxLength(1000);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdCard).HasMaxLength(30);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(500);
            entity.Property(e => e.MemberTypeCode).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.RankTypeCode).HasMaxLength(255);
            entity.Property(e => e.ReferenceInfo).HasMaxLength(2000);
            entity.Property(e => e.ReferralCode).HasMaxLength(500);
            entity.Property(e => e.RegionCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);
        });

        modelBuilder.Entity<PointMemberLoyaltyInfo>(entity =>
        {
            entity.ToTable("point_MemberLoyaltyInfo");

            entity.HasIndex(e => e.RankId, "IX_point_MemberLoyaltyInfo_RankId");

            entity.HasIndex(e => e.MemberCode, "missing_index_13");

            entity.HasIndex(e => new { e.MemberCode, e.DepartmentLevel1, e.SaleType }, "missing_index_23");

            entity.HasIndex(e => e.SaleType, "missing_index_381");

            entity.HasIndex(e => e.SaleType, "missing_index_384");

            entity.HasIndex(e => new { e.SaleType, e.DepartmentLevel1 }, "missing_index_386");

            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepartmentLevel1).HasMaxLength(95);
            entity.Property(e => e.ExpiringCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointToKeepRank).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointToNextTempRank).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SaleType)
                .HasMaxLength(40)
                .HasDefaultValue("");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TempPoint).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Rank).WithMany(p => p.PointMemberLoyaltyInfoRanks).HasForeignKey(d => d.RankId);

            entity.HasOne(d => d.TempRank).WithMany(p => p.PointMemberLoyaltyInfoTempRanks).HasForeignKey(d => d.TempRankId);
        });

        modelBuilder.Entity<PointMemberRankOverview>(entity =>
        {
            entity.ToTable("point_MemberRankOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_MemberRankOverview_TenantId");

            entity.Property(e => e.ExpiringCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RankId).HasColumnName("RankID");
        });

        modelBuilder.Entity<PointMemberType>(entity =>
        {
            entity.ToTable("point_MemberType");

            entity.HasIndex(e => e.TenantId, "IX_point_MemberType_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointNonPurchaseSetting>(entity =>
        {
            entity.ToTable("point_NonPurchaseSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_NonPurchaseSetting_CampaignId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_NonPurchaseSetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_NonPurchaseSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointNonPurchaseSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointNonPurchaseSettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointNumberRoundingSetting>(entity =>
        {
            entity.ToTable("point_NumberRoundingSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_NumberRoundingSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointOrderMappingSm>(entity =>
        {
            entity.ToTable("point_OrderMappingSM");

            entity.HasIndex(e => new { e.OrderCode, e.Smcode }, "IX_point_OrderMappingSM_OrderCode_SMCode");

            entity.HasIndex(e => e.TenantId, "IX_point_OrderMappingSM_TenantId");

            entity.Property(e => e.OrderCode).HasMaxLength(255);
            entity.Property(e => e.Smcode)
                .HasMaxLength(40)
                .HasColumnName("SMCode");
        });

        modelBuilder.Entity<PointPeriodHistory>(entity =>
        {
            entity.ToTable("point_PeriodHistory");

            entity.HasIndex(e => e.TenantId, "IX_point_PeriodHistory_TenantId");

            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointProduct>(entity =>
        {
            entity.ToTable("point_Product");

            entity.HasIndex(e => e.Code, "IX_point_Product_Code");

            entity.HasIndex(e => e.TenantId, "IX_point_Product_TenantId");

            entity.HasIndex(e => e.IsActive, "missing_index_49");

            entity.Property(e => e.BackupDescription).HasMaxLength(250);
            entity.Property(e => e.BackupName).HasMaxLength(250);
            entity.Property(e => e.ClassCode).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.DeptCode).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.FullClassCode).HasMaxLength(1000);
            entity.Property(e => e.FullDeptCode).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointProductCategorySetting>(entity =>
        {
            entity.ToTable("point_ProductCategorySetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_ProductCategorySetting_CampaignId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_ProductCategorySetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_ProductCategorySetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointProductCategorySettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointProductCategorySettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointProductCategorySettingDetail>(entity =>
        {
            entity.ToTable("point_ProductCategorySettingDetail");

            entity.HasIndex(e => e.ProductCategorySettingId, "IX_point_ProductCategorySettingDetail_ProductCategorySettingId");

            entity.HasIndex(e => e.TenantId, "IX_point_ProductCategorySettingDetail_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.ProductCategorySetting).WithMany(p => p.PointProductCategorySettingDetails).HasForeignKey(d => d.ProductCategorySettingId);
        });

        modelBuilder.Entity<PointProductSetting>(entity =>
        {
            entity.ToTable("point_ProductSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_ProductSetting_CampaignId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointProductSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointProductSettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointProductSettingDetail>(entity =>
        {
            entity.ToTable("point_ProductSettingDetail");

            entity.HasIndex(e => e.ProductId, "IX_point_ProductSettingDetail_ProductId");

            entity.HasIndex(e => e.ProductSettingId, "IX_point_ProductSettingDetail_ProductSettingId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DepartmentCode).HasMaxLength(512);
            entity.Property(e => e.DetailType).HasMaxLength(40);
            entity.Property(e => e.MaxSet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.Product).WithMany(p => p.PointProductSettingDetails).HasForeignKey(d => d.ProductId);

            entity.HasOne(d => d.ProductSetting).WithMany(p => p.PointProductSettingDetails).HasForeignKey(d => d.ProductSettingId);
        });

        modelBuilder.Entity<PointProductSettingDetailByRank>(entity =>
        {
            entity.ToTable("point_ProductSettingDetailByRank");

            entity.HasIndex(e => e.ProductSettingDetailId, "IX_point_ProductSettingDetailByRank_ProductSettingDetailId");

            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FromQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.ToQuantity).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ProductSettingDetail).WithMany(p => p.PointProductSettingDetailByRanks).HasForeignKey(d => d.ProductSettingDetailId);
        });

        modelBuilder.Entity<PointProductUommapping>(entity =>
        {
            entity.ToTable("point_ProductUOMMapping");

            entity.HasIndex(e => e.TenantId, "IX_point_ProductUOMMapping_TenantId");

            entity.Property(e => e.BaseuomCd)
                .HasMaxLength(50)
                .HasColumnName("BASEUOM_CD");
            entity.Property(e => e.ConvFactor).HasColumnName("CONV_FACTOR");
            entity.Property(e => e.ConvFactorSml).HasColumnName("CONV_FACTOR_SML");
            entity.Property(e => e.DimensionUnit)
                .HasMaxLength(50)
                .HasColumnName("DIMENSION_UNIT");
            entity.Property(e => e.GrossWeight).HasColumnName("GROSS_WEIGHT");
            entity.Property(e => e.NetWeight).HasColumnName("NET_WEIGHT");
            entity.Property(e => e.PackHeight).HasColumnName("PACK_HEIGHT");
            entity.Property(e => e.PackLength).HasColumnName("PACK_LENGTH");
            entity.Property(e => e.PackWidth).HasColumnName("PACK_WIDTH");
            entity.Property(e => e.PrdCd)
                .HasMaxLength(50)
                .HasColumnName("PRD_CD");
            entity.Property(e => e.UomCd)
                .HasMaxLength(50)
                .HasColumnName("UOM_CD");
            entity.Property(e => e.UomLevel).HasColumnName("UOM_LEVEL");
            entity.Property(e => e.WeightUnit)
                .HasMaxLength(50)
                .HasColumnName("WEIGHT_UNIT");
        });

        modelBuilder.Entity<PointRank>(entity =>
        {
            entity.ToTable("point_Rank");

            entity.HasIndex(e => e.TenantId, "IX_point_Rank_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointRankCalculationSetting>(entity =>
        {
            entity.ToTable("point_RankCalculationSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_RankCalculationSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);
        });

        modelBuilder.Entity<PointRankHistory>(entity =>
        {
            entity.ToTable("point_RankHistory");

            entity.HasIndex(e => e.TenantId, "IX_point_RankHistory_TenantId");

            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.CurrentRankId).HasColumnName("CurrentRankID");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.LastRankId).HasColumnName("LastRankID");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Reason).HasMaxLength(40);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointRankSetting>(entity =>
        {
            entity.ToTable("point_RankSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_RankSetting_CampaignId");

            entity.HasIndex(e => e.RankId, "IX_point_RankSetting_RankId");

            entity.HasIndex(e => e.TenantId, "IX_point_RankSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointRankSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.Rank).WithMany(p => p.PointRankSettings).HasForeignKey(d => d.RankId);
        });

        modelBuilder.Entity<PointRankTarget>(entity =>
        {
            entity.ToTable("point_RankTarget");

            entity.HasIndex(e => e.RankId, "IX_point_RankTarget_RankId");

            entity.HasIndex(e => e.RankTypeId, "IX_point_RankTarget_RankTypeId");

            entity.HasIndex(e => e.TenantId, "IX_point_RankTarget_TenantId");

            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TargetToKeepRank).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointRankType>(entity =>
        {
            entity.ToTable("point_RankType");

            entity.HasIndex(e => e.TenantId, "IX_point_RankType_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.DepartmentLevel1).HasMaxLength(95);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.SaleType).HasMaxLength(95);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointReason>(entity =>
        {
            entity.ToTable("point_Reason");

            entity.HasIndex(e => e.TenantId, "IX_point_Reason_TenantId");

            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.DefaultCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DefaultPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointRedemptionOverview>(entity =>
        {
            entity.ToTable("point_RedemptionOverview");

            entity.HasIndex(e => e.TenantId, "IX_point_RedemptionOverview_TenantId");

            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointReferralSetting>(entity =>
        {
            entity.ToTable("point_ReferralSetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_ReferralSetting_CampaignId");

            entity.HasIndex(e => e.RefereeTargetAudienceId, "IX_point_ReferralSetting_RefereeTargetAudienceId");

            entity.HasIndex(e => e.ReferrerTargetAudienceId, "IX_point_ReferralSetting_ReferrerTargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_ReferralSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ExpiredDays).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaxSet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OrderAmountRequired).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefereeCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefereePoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferrerCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferrerPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(1);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointReferralSettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.RefereeTargetAudience).WithMany(p => p.PointReferralSettingRefereeTargetAudiences).HasForeignKey(d => d.RefereeTargetAudienceId);

            entity.HasOne(d => d.ReferrerTargetAudience).WithMany(p => p.PointReferralSettingReferrerTargetAudiences).HasForeignKey(d => d.ReferrerTargetAudienceId);
        });

        modelBuilder.Entity<PointReferralTransaction>(entity =>
        {
            entity.ToTable("point_ReferralTransaction");

            entity.HasIndex(e => e.CampaignId, "IX_point_ReferralTransaction_CampaignId");

            entity.HasIndex(e => e.TenantId, "IX_point_ReferralTransaction_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.RefMemberCode).HasMaxLength(40);
            entity.Property(e => e.ReferralSettingCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TempCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TempPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(40);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointReferralTransactions).HasForeignKey(d => d.CampaignId);
        });

        modelBuilder.Entity<PointRegion>(entity =>
        {
            entity.ToTable("point_Region");

            entity.HasIndex(e => e.Code, "IX_point_Region_Code");

            entity.HasIndex(e => e.TenantId, "IX_point_Region_TenantId");

            entity.HasIndex(e => new { e.IsActive, e.Level }, "missing_index_44");

            entity.HasIndex(e => e.IsActive, "missing_index_57");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointRegion20230224>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("point_Region_20230224");

            entity.Property(e => e.CodeL1).HasMaxLength(500);
            entity.Property(e => e.CodeL2).HasMaxLength(500);
            entity.Property(e => e.CodeL3).HasMaxLength(500);
            entity.Property(e => e.CodeL4).HasMaxLength(500);
            entity.Property(e => e.CodeL5).HasMaxLength(500);
            entity.Property(e => e.NameL1).HasMaxLength(255);
            entity.Property(e => e.NameL2).HasMaxLength(255);
            entity.Property(e => e.NameL3).HasMaxLength(255);
            entity.Property(e => e.NameL4).HasMaxLength(255);
            entity.Property(e => e.NameL5).HasMaxLength(255);
        });

        modelBuilder.Entity<PointReportSetting>(entity =>
        {
            entity.ToTable("point_ReportSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_ReportSetting_TenantId");

            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalEstimateCost).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointRevenue>(entity =>
        {
            entity.ToTable("point_Revenue");

            entity.HasIndex(e => e.TenantId, "IX_point_Revenue_TenantId");

            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointSalesRegion>(entity =>
        {
            entity.ToTable("point_SalesRegion");

            entity.HasIndex(e => e.Code, "IX_point_SalesRegion_Code");

            entity.HasIndex(e => e.TenantId, "IX_point_SalesRegion_TenantId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ParentCode).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointSenioritySetting>(entity =>
        {
            entity.ToTable("point_SenioritySetting");

            entity.HasIndex(e => e.CampaignId, "IX_point_SenioritySetting_CampaignId");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_SenioritySetting_TargetAudienceId");

            entity.HasIndex(e => e.TenantId, "IX_point_SenioritySetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.Cron).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.MinMonthRequired).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TimeZone).HasMaxLength(255);

            entity.HasOne(d => d.Campaign).WithMany(p => p.PointSenioritySettings).HasForeignKey(d => d.CampaignId);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointSenioritySettings).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointSenioritySettingHistory>(entity =>
        {
            entity.ToTable("point_SenioritySettingHistory");

            entity.HasIndex(e => e.TenantId, "IX_point_SenioritySettingHistory_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(500);
            entity.Property(e => e.SeniorityFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SenioritySettingCode).HasMaxLength(500);
        });

        modelBuilder.Entity<PointSenioritySettingMilestone>(entity =>
        {
            entity.ToTable("point_SenioritySettingMilestone");

            entity.HasIndex(e => e.SenioritySettingId, "IX_point_SenioritySettingMilestone_SenioritySettingId");

            entity.HasIndex(e => e.TenantId, "IX_point_SenioritySettingMilestone_TenantId");

            entity.Property(e => e.Code).HasMaxLength(100);
            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SeniorityFrom).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SenioritySettingCode).HasMaxLength(100);
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.SenioritySetting).WithMany(p => p.PointSenioritySettingMilestones).HasForeignKey(d => d.SenioritySettingId);
        });

        modelBuilder.Entity<PointSpecialSettingHistory>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.SpecialSettingCode, e.Date });

            entity.ToTable("point_SpecialSettingHistory");

            entity.HasIndex(e => e.TenantId, "IX_point_SpecialSettingHistory_TenantId");

            entity.Property(e => e.CoinValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PointValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.Member).WithMany(p => p.PointSpecialSettingHistories).HasForeignKey(d => d.MemberId);
        });

        modelBuilder.Entity<PointSuspendTransaction>(entity =>
        {
            entity.ToTable("point_SuspendTransaction");

            entity.HasIndex(e => e.TenantId, "IX_point_SuspendTransaction_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(500);
        });

        modelBuilder.Entity<PointTag>(entity =>
        {
            entity.ToTable("point_Tag");

            entity.HasIndex(e => e.TenantId, "IX_point_Tag_TenantId");

            entity.Property(e => e.Value).HasMaxLength(40);
        });

        modelBuilder.Entity<PointTargetAudience>(entity =>
        {
            entity.ToTable("point_TargetAudience");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<PointTargetAudienceDetail>(entity =>
        {
            entity.ToTable("point_TargetAudienceDetail");

            entity.HasIndex(e => e.TargetAudienceId, "IX_point_TargetAudienceDetail_TargetAudienceId");

            entity.Property(e => e.Code).HasMaxLength(500);
            entity.Property(e => e.Source).HasMaxLength(255);

            entity.HasOne(d => d.TargetAudience).WithMany(p => p.PointTargetAudienceDetails).HasForeignKey(d => d.TargetAudienceId);
        });

        modelBuilder.Entity<PointTempCoinBaseline>(entity =>
        {
            entity.ToTable("point_TempCoinBaseline");

            entity.HasIndex(e => e.BaselineData, "IX_point_TempCoinBaseline_BaselineData");

            entity.HasIndex(e => e.MemberCode, "IX_point_TempCoinBaseline_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_point_TempCoinBaseline_TenantId");

            entity.Property(e => e.BaselineData).HasMaxLength(255);
            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointTempInvoiceTransaction>(entity =>
        {
            entity.ToTable("point_TempInvoiceTransaction");

            entity.HasIndex(e => e.TenantId, "IX_point_TempInvoiceTransaction_TenantId");

            entity.Property(e => e.AddTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADD_TAX_AMT");
            entity.Property(e => e.AddTaxAmtDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADD_TAX_AMT_DTL");
            entity.Property(e => e.AddTaxPerc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADD_TAX_PERC");
            entity.Property(e => e.AdjAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ADJ_AMT");
            entity.Property(e => e.AgentCd)
                .HasMaxLength(20)
                .HasColumnName("AGENT_CD");
            entity.Property(e => e.BilltoCd)
                .HasMaxLength(20)
                .HasColumnName("BILLTO_CD");
            entity.Property(e => e.BuCd)
                .HasMaxLength(20)
                .HasColumnName("BU_CD");
            entity.Property(e => e.CashDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CASH_DISC");
            entity.Property(e => e.CashDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CASH_DISC_DTL");
            entity.Property(e => e.CashDiscPerc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CASH_DISC_PERC");
            entity.Property(e => e.ClaimDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CLAIM_DISC");
            entity.Property(e => e.Cp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CP");
            entity.Property(e => e.CreateDt).HasColumnName("CREATE_DT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(20)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CustCd)
                .HasMaxLength(20)
                .HasColumnName("CUST_CD");
            entity.Property(e => e.CustDiscAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUST_DISC_AMT");
            entity.Property(e => e.CustDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUST_DISC_DTL");
            entity.Property(e => e.CustDiscPerc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUST_DISC_PERC");
            entity.Property(e => e.CustGrpDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUST_GRP_DISC");
            entity.Property(e => e.CustGrpDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CUST_GRP_DISC_DTL");
            entity.Property(e => e.CustMunicipalno)
                .HasMaxLength(30)
                .HasColumnName("CUST_MUNICIPALNO");
            entity.Property(e => e.CustTaxregno)
                .HasMaxLength(50)
                .HasColumnName("CUST_TAXREGNO");
            entity.Property(e => e.CustType)
                .HasMaxLength(50)
                .HasColumnName("CUST_TYPE");
            entity.Property(e => e.DeDt).HasColumnName("DE_DT");
            entity.Property(e => e.DeInd)
                .HasMaxLength(50)
                .HasColumnName("DE_IND");
            entity.Property(e => e.DefUomCd)
                .HasMaxLength(20)
                .HasColumnName("DEF_UOM_CD");
            entity.Property(e => e.DeliveryDt).HasColumnName("DELIVERY_DT");
            entity.Property(e => e.DistCd)
                .HasMaxLength(20)
                .HasColumnName("DIST_CD");
            entity.Property(e => e.DistDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIST_DISC");
            entity.Property(e => e.DistDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIST_DISC_DTL");
            entity.Property(e => e.DistPromoDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIST_PROMO_DISC");
            entity.Property(e => e.DistTaxId)
                .HasMaxLength(50)
                .HasColumnName("DIST_TAX_ID");
            entity.Property(e => e.DwDt).HasColumnName("DW_DT");
            entity.Property(e => e.ErpInd).HasColumnName("ERP_IND");
            entity.Property(e => e.ExtInd)
                .HasMaxLength(20)
                .HasColumnName("EXT_IND");
            entity.Property(e => e.FullReversalInd)
                .HasMaxLength(50)
                .HasColumnName("FULL_REVERSAL_IND");
            entity.Property(e => e.GrossAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GROSS_AMT");
            entity.Property(e => e.GrossTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GROSS_TTL");
            entity.Property(e => e.HhtSubmitDt).HasColumnName("HHT_SUBMIT_DT");
            entity.Property(e => e.HqPromoDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_PROMO_DISC");
            entity.Property(e => e.Ind)
                .HasMaxLength(5)
                .HasColumnName("IND");
            entity.Property(e => e.IndDtl)
                .HasMaxLength(10)
                .HasColumnName("IND_DTL");
            entity.Property(e => e.InvDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INV_DISC");
            entity.Property(e => e.InvDiscTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INV_DISC_TTL");
            entity.Property(e => e.InvDt).HasColumnName("INV_DT");
            entity.Property(e => e.InvInd)
                .HasMaxLength(50)
                .HasColumnName("INV_IND");
            entity.Property(e => e.InvKey)
                .HasMaxLength(50)
                .HasColumnName("INV_KEY");
            entity.Property(e => e.InvNo)
                .HasMaxLength(30)
                .HasColumnName("INV_NO");
            entity.Property(e => e.InvStatus)
                .HasMaxLength(50)
                .HasColumnName("INV_STATUS");
            entity.Property(e => e.InvType)
                .HasMaxLength(50)
                .HasColumnName("INV_TYPE");
            entity.Property(e => e.InvtermCd)
                .HasMaxLength(20)
                .HasColumnName("INVTERM_CD");
            entity.Property(e => e.Mrp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MRP");
            entity.Property(e => e.MslInd)
                .HasMaxLength(10)
                .HasColumnName("MSL_IND");
            entity.Property(e => e.MyTaxCd)
                .HasMaxLength(50)
                .HasColumnName("MY_TAX_CD");
            entity.Property(e => e.NetAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NET_AMT");
            entity.Property(e => e.NetAmtFoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NET_AMT_FOC");
            entity.Property(e => e.NetAmtTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NET_AMT_TAX");
            entity.Property(e => e.NetTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NET_TTL");
            entity.Property(e => e.NetTtlTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NET_TTL_TAX");
            entity.Property(e => e.NontaxableAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NONTAXABLE_AMT");
            entity.Property(e => e.NpclaimInd).HasColumnName("NPCLAIM_IND");
            entity.Property(e => e.ParentPrd)
                .HasMaxLength(20)
                .HasColumnName("PARENT_PRD");
            entity.Property(e => e.ParentUom)
                .HasMaxLength(20)
                .HasColumnName("PARENT_UOM");
            entity.Property(e => e.PicklistInd).HasColumnName("PICKLIST_IND");
            entity.Property(e => e.PoNo)
                .HasMaxLength(50)
                .HasColumnName("PO_NO");
            entity.Property(e => e.PrcTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_AMT");
            entity.Property(e => e.PrcTaxAmt1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_AMT1");
            entity.Property(e => e.PrcTaxAmt2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_AMT2");
            entity.Property(e => e.PrcTaxAmt3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_AMT3");
            entity.Property(e => e.PrcTaxInd)
                .HasMaxLength(50)
                .HasColumnName("PRC_TAX_IND");
            entity.Property(e => e.PrcTaxPerc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_PERC1");
            entity.Property(e => e.PrcTaxPerc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_PERC2");
            entity.Property(e => e.PrcTaxPerc3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_PERC3");
            entity.Property(e => e.PrcTaxTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_TTL");
            entity.Property(e => e.PrcTaxTtl1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_TTL1");
            entity.Property(e => e.PrcTaxTtl2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_TTL2");
            entity.Property(e => e.PrcTaxTtl3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRC_TAX_TTL3");
            entity.Property(e => e.PrdCd)
                .HasMaxLength(20)
                .HasColumnName("PRD_CD");
            entity.Property(e => e.PrdDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_DISC");
            entity.Property(e => e.PrdDiscTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_DISC_TTL");
            entity.Property(e => e.PrdIndex).HasColumnName("PRD_INDEX");
            entity.Property(e => e.PrdListprc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_LISTPRC");
            entity.Property(e => e.PrdQty1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_QTY1");
            entity.Property(e => e.PrdQty2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_QTY2");
            entity.Property(e => e.PrdQty3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRD_QTY3");
            entity.Property(e => e.PrdSlstype)
                .HasMaxLength(50)
                .HasColumnName("PRD_SLSTYPE");
            entity.Property(e => e.PriceError)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRICE_ERROR");
            entity.Property(e => e.PrnDoNo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRN_DO_NO");
            entity.Property(e => e.PrnNo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRN_NO");
            entity.Property(e => e.PrnNoTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PRN_NO_TAX");
            entity.Property(e => e.PromoDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROMO_DISC");
            entity.Property(e => e.PromoDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PROMO_DISC_DTL");
            entity.Property(e => e.PurchaseRate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PURCHASE_RATE");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .HasColumnName("REF_NO");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasColumnName("REMARK");
            entity.Property(e => e.ShiptoCd)
                .HasMaxLength(20)
                .HasColumnName("SHIPTO_CD");
            entity.Property(e => e.SlsDisc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SLS_DISC");
            entity.Property(e => e.SlsDiscDtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SLS_DISC_DTL");
            entity.Property(e => e.SlsmanCd)
                .HasMaxLength(20)
                .HasColumnName("SLSMAN_CD");
            entity.Property(e => e.SoDt).HasColumnName("SO_DT");
            entity.Property(e => e.SoKey)
                .HasMaxLength(50)
                .HasColumnName("SO_KEY");
            entity.Property(e => e.SoNo)
                .HasMaxLength(30)
                .HasColumnName("SO_NO");
            entity.Property(e => e.SpclaimInd).HasColumnName("SPCLAIM_IND");
            entity.Property(e => e.SubdistInd)
                .HasMaxLength(30)
                .HasColumnName("SUBDIST_IND");
            entity.Property(e => e.SvrClient)
                .HasMaxLength(50)
                .HasColumnName("SVR_CLIENT");
            entity.Property(e => e.SvrUpldwDt).HasColumnName("SVR_UPLDW_DT");
            entity.Property(e => e.Syncversion).HasColumnName("SYNCVERSION");
            entity.Property(e => e.TaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_AMT");
            entity.Property(e => e.TaxAmt1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_AMT1");
            entity.Property(e => e.TaxAmt2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_AMT2");
            entity.Property(e => e.TaxAmt3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_AMT3");
            entity.Property(e => e.TaxInd).HasColumnName("TAX_IND");
            entity.Property(e => e.TaxInvNo)
                .HasMaxLength(30)
                .HasColumnName("TAX_INV_NO");
            entity.Property(e => e.TaxPerc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC1");
            entity.Property(e => e.TaxPerc1Dtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC1_DTL");
            entity.Property(e => e.TaxPerc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC2");
            entity.Property(e => e.TaxPerc2Dtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC2_DTL");
            entity.Property(e => e.TaxPerc3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC3");
            entity.Property(e => e.TaxPerc3Dtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_PERC3_DTL");
            entity.Property(e => e.TaxTtl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_TTL");
            entity.Property(e => e.TaxTtl1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_TTL1");
            entity.Property(e => e.TaxTtl2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_TTL2");
            entity.Property(e => e.TaxTtl3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAX_TTL3");
            entity.Property(e => e.TaxableAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAXABLE_AMT");
            entity.Property(e => e.TaxableAmtFoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TAXABLE_AMT_FOC");
            entity.Property(e => e.TinvNo)
                .HasMaxLength(30)
                .HasColumnName("TINV_NO");
            entity.Property(e => e.UnitTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UNIT_TAX");
            entity.Property(e => e.UomCd1)
                .HasMaxLength(20)
                .HasColumnName("UOM_CD1");
            entity.Property(e => e.UomCd2)
                .HasMaxLength(20)
                .HasColumnName("UOM_CD2");
            entity.Property(e => e.UomCd3)
                .HasMaxLength(20)
                .HasColumnName("UOM_CD3");
            entity.Property(e => e.UomConvFactorSml1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_CONV_FACTOR_SML1");
            entity.Property(e => e.UomConvFactorSml2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_CONV_FACTOR_SML2");
            entity.Property(e => e.UomConvFactorSml3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_CONV_FACTOR_SML3");
            entity.Property(e => e.UomListprc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_LISTPRC1");
            entity.Property(e => e.UomListprc2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_LISTPRC2");
            entity.Property(e => e.UomListprc3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("UOM_LISTPRC3");
            entity.Property(e => e.UpldwStatus)
                .HasMaxLength(50)
                .HasColumnName("UPLDW_STATUS");
            entity.Property(e => e.Version)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VERSION");
            entity.Property(e => e.VisitKey)
                .HasMaxLength(50)
                .HasColumnName("VISIT_KEY");
            entity.Property(e => e.WhsCd)
                .HasMaxLength(20)
                .HasColumnName("WHS_CD");
        });

        modelBuilder.Entity<PointTempMappingGeo>(entity =>
        {
            entity.ToTable("point_TempMappingGEO");

            entity.HasIndex(e => e.NodeId, "IX_point_TempMappingGEO_NODE_ID");

            entity.HasIndex(e => e.PosId, "IX_point_TempMappingGEO_POS_ID");

            entity.HasIndex(e => e.TenantId, "IX_point_TempMappingGEO_TenantId");

            entity.Property(e => e.NodeId)
                .HasMaxLength(255)
                .HasColumnName("NODE_ID");
            entity.Property(e => e.Note1).HasMaxLength(255);
            entity.Property(e => e.Note2).HasMaxLength(255);
            entity.Property(e => e.PosId)
                .HasMaxLength(255)
                .HasColumnName("POS_ID");
        });

        modelBuilder.Entity<PointTransaction>(entity =>
        {
            entity.ToTable("point_Transaction");

            entity.HasIndex(e => e.Code, "IX_point_Transaction_Code").IsUnique();

            entity.HasIndex(e => e.MemberCode, "IX_point_Transaction_MemberCode");

            entity.HasIndex(e => e.OriginalOrders, "IX_point_Transaction_OriginalOrders");

            entity.HasIndex(e => e.TenantId, "IX_point_Transaction_TenantId");

            entity.Property(e => e.ActionRuleCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActionRulePoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Approver).HasMaxLength(255);
            entity.Property(e => e.BaseCoinRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BasePointRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BaseSettingCode).HasMaxLength(255);
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DistributorCode).HasMaxLength(255);
            entity.Property(e => e.EventCoinRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EventPointRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EventSettingCode).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.OriginalOrders).HasMaxLength(255);
            entity.Property(e => e.PlusCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PlusPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RankCoinRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RankPointRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RankSettingCode).HasMaxLength(255);
            entity.Property(e => e.RankTypeCode).HasMaxLength(255);
            entity.Property(e => e.RatioCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RatioPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferralSettingCode).HasMaxLength(255);
            entity.Property(e => e.SenioritySettingCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.SpecialSettingCode).HasMaxLength(255);
            entity.Property(e => e.StandardMemberCode).HasMaxLength(255);
            entity.Property(e => e.TotalAmountBeforeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountIncludeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountIssueCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmountIssuePoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCalcAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalTaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsedCoin).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointTransactionCoinBaseLine>(entity =>
        {
            entity.ToTable("point_TransactionCoinBaseLine");

            entity.HasIndex(e => e.BaselineData, "IX_point_TransactionCoinBaseLine_BaselineData");

            entity.HasIndex(e => e.MemberCode, "IX_point_TransactionCoinBaseLine_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_point_TransactionCoinBaseLine_TenantId");

            entity.Property(e => e.BaselineData).HasMaxLength(255);
            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointTransactionDetail>(entity =>
        {
            entity.ToTable("point_TransactionDetail");

            entity.HasIndex(e => e.ProductCode, "IX_point_TransactionDetail_ProductCode");

            entity.HasIndex(e => e.TenantId, "IX_point_TransactionDetail_TenantId");

            entity.HasIndex(e => e.TransactionCode, "IX_point_TransactionDetail_TransactionCode");

            entity.Property(e => e.AmountBeforeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountIncludeTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CalcAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Coin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCategorySettingCode).HasMaxLength(255);
            entity.Property(e => e.ProductCategorySettingCoinRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCategorySettingPointRatio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(255);
            entity.Property(e => e.ProductSettingCode).HasMaxLength(255);
            entity.Property(e => e.ProductSettingCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductSettingPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionCode).HasMaxLength(255);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PointTransactionPointBaseLine>(entity =>
        {
            entity.ToTable("point_TransactionPointBaseLine");

            entity.HasIndex(e => e.MemberCode, "IX_point_TransactionPointBaseLine_MemberCode");

            entity.HasIndex(e => e.Month, "IX_point_TransactionPointBaseLine_Month");

            entity.HasIndex(e => e.TenantId, "IX_point_TransactionPointBaseLine_TenantId");

            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Point).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<PointVendorSetting>(entity =>
        {
            entity.ToTable("point_VendorSetting");

            entity.HasIndex(e => e.TenantId, "IX_point_VendorSetting_TenantId");

            entity.Property(e => e.ApiVersion).HasMaxLength(255);
            entity.Property(e => e.Apilink)
                .HasMaxLength(2000)
                .HasColumnName("APILink");
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TokenKey).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(40);
        });

        modelBuilder.Entity<PosmResult>(entity =>
        {
            entity.ToTable("PosmResult");

            entity.HasIndex(e => e.CreationTime, "missing_index_37");

            entity.Property(e => e.CheckInDistance).HasMaxLength(40);
            entity.Property(e => e.CheckInImageLink).HasMaxLength(512);
            entity.Property(e => e.CheckInLatitude).HasMaxLength(40);
            entity.Property(e => e.CheckInLongitude).HasMaxLength(40);
            entity.Property(e => e.CheckOutDistance).HasMaxLength(40);
            entity.Property(e => e.CheckOutImageLink).HasMaxLength(512);
            entity.Property(e => e.CheckOutLatitude).HasMaxLength(40);
            entity.Property(e => e.CheckOutLongitude).HasMaxLength(40);
            entity.Property(e => e.CreatorName).HasMaxLength(64);
            entity.Property(e => e.LastModifierName).HasMaxLength(64);
            entity.Property(e => e.OutletCode).HasMaxLength(64);
            entity.Property(e => e.SalemanCode).HasMaxLength(64);
        });

        modelBuilder.Entity<PromoCampaign>(entity =>
        {
            entity.ToTable("promo_Campaign");

            entity.HasIndex(e => e.Code, "IX_promo_Campaign_Code");

            entity.HasIndex(e => new { e.FromDate, e.ToDate }, "IX_promo_Campaign_FromDate_ToDate");

            entity.HasIndex(e => e.IsActive, "IX_promo_Campaign_IsActive");

            entity.HasIndex(e => e.Name, "IX_promo_Campaign_Name");

            entity.HasIndex(e => e.TenantId, "IX_promo_Campaign_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.MemberSegment).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<PromoCampaignMemberPoint>(entity =>
        {
            entity.ToTable("promo_CampaignMemberPoint");

            entity.HasIndex(e => e.CampaignId, "IX_promo_CampaignMemberPoint_CampaignId");

            entity.HasIndex(e => e.ExpiredDate, "IX_promo_CampaignMemberPoint_ExpiredDate");

            entity.HasIndex(e => e.MemberCode, "IX_promo_CampaignMemberPoint_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_promo_CampaignMemberPoint_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.PointHold).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.PointUsed).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalCoin).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalPoint).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<PromoCampaignReward>(entity =>
        {
            entity.ToTable("promo_CampaignReward");

            entity.HasIndex(e => e.CampaignId, "IX_promo_CampaignReward_CampaignId");

            entity.HasIndex(e => new { e.EffectFrom, e.EffectTo }, "IX_promo_CampaignReward_EffectFrom_EffectTo");

            entity.HasIndex(e => e.RewardId, "IX_promo_CampaignReward_RewardId");

            entity.HasIndex(e => e.TenantId, "IX_promo_CampaignReward_TenantId");
        });

        modelBuilder.Entity<PromoRewardItem>(entity =>
        {
            entity.ToTable("promo_RewardItem");

            entity.HasIndex(e => e.Code, "IX_promo_RewardItem_Code");

            entity.HasIndex(e => e.IsActive, "IX_promo_RewardItem_IsActive");

            entity.HasIndex(e => e.Name, "IX_promo_RewardItem_Name");

            entity.HasIndex(e => e.RewardType, "IX_promo_RewardItem_RewardType");

            entity.HasIndex(e => e.TenantId, "IX_promo_RewardItem_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.MonetaryValue).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PointCost).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RewardType).HasMaxLength(30);
        });

        modelBuilder.Entity<PromoRewardRedemptionItem>(entity =>
        {
            entity.ToTable("promo_RewardRedemptionItem");

            entity.HasIndex(e => e.RedemptionRequestId, "IX_promo_RewardRedemptionItem_RedemptionRequestId");

            entity.HasIndex(e => e.RewardItemId, "IX_promo_RewardRedemptionItem_RewardItemId");

            entity.HasIndex(e => e.Status, "IX_promo_RewardRedemptionItem_Status");

            entity.HasIndex(e => e.TenantId, "IX_promo_RewardRedemptionItem_TenantId");

            entity.Property(e => e.RewardItemCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(40);
            entity.Property(e => e.Uom)
                .HasMaxLength(40)
                .HasColumnName("UOM");
        });

        modelBuilder.Entity<PromoRewardRedemptionRequest>(entity =>
        {
            entity.ToTable("promo_RewardRedemptionRequest");

            entity.HasIndex(e => e.ApprovedDate, "IX_promo_RewardRedemptionRequest_ApprovedDate");

            entity.HasIndex(e => e.CampaignId, "IX_promo_RewardRedemptionRequest_CampaignId");

            entity.HasIndex(e => e.MemberCode, "IX_promo_RewardRedemptionRequest_MemberCode");

            entity.HasIndex(e => e.RequestDate, "IX_promo_RewardRedemptionRequest_RequestDate");

            entity.HasIndex(e => e.Status, "IX_promo_RewardRedemptionRequest_Status");

            entity.HasIndex(e => e.TenantId, "IX_promo_RewardRedemptionRequest_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(40);
            entity.Property(e => e.TotalPoint).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<PromoRewardUsedTransaction>(entity =>
        {
            entity.ToTable("promo_RewardUsedTransaction");

            entity.HasIndex(e => e.MemberCode, "IX_promo_RewardUsedTransaction_MemberCode");

            entity.HasIndex(e => e.RedemptionItemId, "IX_promo_RewardUsedTransaction_RedemptionItemId");

            entity.HasIndex(e => e.TenantId, "IX_promo_RewardUsedTransaction_TenantId");

            entity.HasIndex(e => e.UsedDate, "IX_promo_RewardUsedTransaction_UsedDate");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Note).HasMaxLength(500);
        });

        modelBuilder.Entity<PublishEventLog>(entity =>
        {
            entity.HasIndex(e => e.CreationTime, "IX_PublishEventLogs_CreationTime");

            entity.HasIndex(e => e.EventDataKey, "IX_PublishEventLogs_EventDataKey");

            entity.Property(e => e.EventDataKey).HasMaxLength(64);
            entity.Property(e => e.EventName).HasMaxLength(64);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<QuartzHistory>(entity =>
        {
            entity.ToTable("QuartzHistory");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FireInstanceId).HasMaxLength(100);
            entity.Property(e => e.Group).HasMaxLength(250);
            entity.Property(e => e.JobName).HasMaxLength(250);
        });

        modelBuilder.Entity<QuartzJob>(entity =>
        {
            entity.ToTable("QuartzJob");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Group).HasMaxLength(250);
            entity.Property(e => e.JobInfo).HasMaxLength(500);
            entity.Property(e => e.JobName).HasMaxLength(250);
        });

        modelBuilder.Entity<RewardsGameInfor>(entity =>
        {
            entity.ToTable("rewards_GameInfor");

            entity.HasIndex(e => e.TenantId, "IX_rewards_GameInfor_TenantId");

            entity.Property(e => e.CampaignId)
                .HasMaxLength(255)
                .HasColumnName("CampaignID");
            entity.Property(e => e.CampaignName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Link).HasMaxLength(2000);
            entity.Property(e => e.MemberCode).HasMaxLength(20);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.PromotionCode).HasMaxLength(40);
            entity.Property(e => e.PromotionMasterCode).HasMaxLength(40);
            entity.Property(e => e.Quantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Remain).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Used).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<RewardsGeneratedVoucher>(entity =>
        {
            entity.ToTable("rewards_GeneratedVoucher");

            entity.HasIndex(e => e.TenantId, "IX_rewards_GeneratedVoucher_TenantId");

            entity.Property(e => e.PatternCode).HasMaxLength(40);
            entity.Property(e => e.VoucherCode).HasMaxLength(50);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RewardsPublisherMaster>(entity =>
        {
            entity.ToTable("rewards_PublisherMaster");

            entity.HasIndex(e => e.TenantId, "IX_rewards_PublisherMaster_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.PublisherCode).HasMaxLength(40);
            entity.Property(e => e.PublisherName).HasMaxLength(50);
            entity.Property(e => e.PulisherNameUnsign).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<RewardsReferralTransaction>(entity =>
        {
            entity.ToTable("rewards_ReferralTransaction");

            entity.HasIndex(e => e.TenantId, "IX_rewards_ReferralTransaction_TenantId");

            entity.Property(e => e.ReferalCode).HasMaxLength(40);
            entity.Property(e => e.ReferralUser).HasMaxLength(40);
            entity.Property(e => e.TransactionCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RewardsRewardTargetAudience>(entity =>
        {
            entity.ToTable("rewards_RewardTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_rewards_RewardTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceLinkId).HasColumnName("TargetAudienceLinkID");
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<RewardsSalesInvoiceBaseline>(entity =>
        {
            entity.ToTable("rewards_SalesInvoiceBaseline");

            entity.HasIndex(e => e.TenantId, "IX_rewards_SalesInvoiceBaseline_TenantId");

            entity.Property(e => e.Incremental).HasColumnType("decimal(27, 3)");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.SalesInvoiceCode).HasMaxLength(40);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RewardsTerminalMaster>(entity =>
        {
            entity.ToTable("rewards_TerminalMaster");

            entity.HasIndex(e => e.TenantId, "IX_rewards_TerminalMaster_TenantId");

            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.ProductHierarchyLv1)
                .HasMaxLength(255)
                .HasColumnName("ProductHierarchyLV1");
            entity.Property(e => e.ProductHierarchyLv2)
                .HasMaxLength(255)
                .HasColumnName("ProductHierarchyLV2");
            entity.Property(e => e.ProductHierarchyLv3).HasColumnName("ProductHierarchyLV3");
            entity.Property(e => e.ProductHierarchyLv4).HasColumnName("ProductHierarchyLV4");
            entity.Property(e => e.ProductHierarchyLv5).HasColumnName("ProductHierarchyLV5");
            entity.Property(e => e.ReferenceCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TerminalCode).HasMaxLength(40);
            entity.Property(e => e.TerminalName).HasMaxLength(255);
            entity.Property(e => e.TerminalNameUnsign).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<RewardsUnavailableVoucher>(entity =>
        {
            entity.ToTable("rewards_UnavailableVoucher");

            entity.HasIndex(e => e.TenantId, "IX_rewards_UnavailableVoucher_TenantId");

            entity.Property(e => e.EventFilter).HasMaxLength(50);
            entity.Property(e => e.RedemptionUser).HasMaxLength(50);
            entity.Property(e => e.ReferenceCode).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TriggerEvent).HasMaxLength(40);
            entity.Property(e => e.VoucherCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
            entity.Property(e => e.VoucherUser).HasMaxLength(50);
        });

        modelBuilder.Entity<RewardsUserSessionTracking>(entity =>
        {
            entity.ToTable("rewards_UserSessionTracking");

            entity.HasIndex(e => e.TenantId, "IX_rewards_UserSessionTracking_TenantId");

            entity.Property(e => e.TerminalCode).HasMaxLength(40);
            entity.Property(e => e.TerminalName).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<RewardsVoucherBudget>(entity =>
        {
            entity.ToTable("rewards_VoucherBudget");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherBudget_TenantId");

            entity.Property(e => e.GrantedQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.MaxGrantQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.MaxRedeemQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RedeemedQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RemainGrantQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RemainRedeemQuantity).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupName).HasMaxLength(255);
        });

        modelBuilder.Entity<RewardsVoucherGroup>(entity =>
        {
            entity.ToTable("rewards_VoucherGroup");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherGroup_TenantId");

            entity.Property(e => e.AcceptedEvent).HasMaxLength(40);
            entity.Property(e => e.ApplyFor).HasMaxLength(20);
            entity.Property(e => e.BillCalculationType).HasMaxLength(50);
            entity.Property(e => e.BillTotal).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.Cron).HasMaxLength(20);
            entity.Property(e => e.CurrencyPrice).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionEN");
            entity.Property(e => e.DescriptionVn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionVN");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.DiscountRate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.EventFilter).HasMaxLength(50);
            entity.Property(e => e.GiftCode).HasMaxLength(40);
            entity.Property(e => e.GrantAppliedLocation).HasMaxLength(255);
            entity.Property(e => e.GrantAppliedProdLv1)
                .HasMaxLength(255)
                .HasColumnName("GrantAppliedProdLV1");
            entity.Property(e => e.GrantAppliedProdLv2)
                .HasMaxLength(255)
                .HasColumnName("GrantAppliedProdLV2");
            entity.Property(e => e.GrantAppliedProdLv3).HasColumnName("GrantAppliedProdLV3");
            entity.Property(e => e.GrantAppliedProdLv4).HasColumnName("GrantAppliedProdLV4");
            entity.Property(e => e.GrantAppliedProdLv5).HasColumnName("GrantAppliedProdLV5");
            entity.Property(e => e.GrantAppliedStore).HasMaxLength(255);
            entity.Property(e => e.GrantMsgTemplateContentEn).HasColumnName("GrantMsgTemplateContentEN");
            entity.Property(e => e.GrantMsgTemplateContentVn).HasColumnName("GrantMsgTemplateContentVN");
            entity.Property(e => e.GrantMsgTemplateId)
                .HasMaxLength(40)
                .HasColumnName("GrantMsgTemplateID");
            entity.Property(e => e.GrantMsgTemplateType).HasMaxLength(50);
            entity.Property(e => e.GrantNotificationChannel).HasMaxLength(40);
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.MaxDayForPo).HasColumnName("MaxDayForPO");
            entity.Property(e => e.MaxDiscountAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.MinBillAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.MinPurchaseAmount).HasColumnType("decimal(24, 3)");
            entity.Property(e => e.PointPrice).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.PublisherCode).HasMaxLength(40);
            entity.Property(e => e.QtyGrantPerPerson).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.QtyRedeemPerPerson).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.RedemptionAppliedProdLv1)
                .HasMaxLength(255)
                .HasColumnName("RedemptionAppliedProdLV1");
            entity.Property(e => e.RedemptionAppliedProdLv2)
                .HasMaxLength(255)
                .HasColumnName("RedemptionAppliedProdLV2");
            entity.Property(e => e.RedemptionAppliedProdLv3).HasColumnName("RedemptionAppliedProdLV3");
            entity.Property(e => e.RedemptionAppliedProdLv4).HasColumnName("RedemptionAppliedProdLV4");
            entity.Property(e => e.RedemptionAppliedProdLv5).HasColumnName("RedemptionAppliedProdLV5");
            entity.Property(e => e.RedemptionApplyLocation).HasMaxLength(255);
            entity.Property(e => e.RedemptionApplyStore).HasMaxLength(255);
            entity.Property(e => e.RedemptionEndTime).HasColumnName("RedemptionEndTIme");
            entity.Property(e => e.RedemptionMsgTemplateContentEn).HasColumnName("RedemptionMsgTemplateContentEN");
            entity.Property(e => e.RedemptionMsgTemplateContentVn).HasColumnName("RedemptionMsgTemplateContentVN");
            entity.Property(e => e.RedemptionMsgTemplateId)
                .HasMaxLength(40)
                .HasColumnName("RedemptionMsgTemplateID");
            entity.Property(e => e.RedemptionMsgTemplateType).HasMaxLength(50);
            entity.Property(e => e.RedemptionNotificationChannel).HasMaxLength(40);
            entity.Property(e => e.RedemptionType).HasMaxLength(50);
            entity.Property(e => e.ReferralRewardReceiver).HasMaxLength(40);
            entity.Property(e => e.RewardTargetAudienceId).HasColumnName("RewardTargetAudienceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
            entity.Property(e => e.Template).HasMaxLength(2000);
            entity.Property(e => e.TitleEn)
                .HasMaxLength(255)
                .HasColumnName("TitleEN");
            entity.Property(e => e.TitleVn)
                .HasMaxLength(255)
                .HasColumnName("TitleVN");
            entity.Property(e => e.TriggerEvent).HasMaxLength(40);
            entity.Property(e => e.TriggerType).HasMaxLength(20);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupName).HasMaxLength(255);
            entity.Property(e => e.VoucherGroupNameUnsign).HasMaxLength(255);
        });

        modelBuilder.Entity<RewardsVoucherPattern>(entity =>
        {
            entity.ToTable("rewards_VoucherPattern");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherPattern_TenantId");

            entity.Property(e => e.CharSet).HasMaxLength(50);
            entity.Property(e => e.LengthAutoGenString).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.PatternCode).HasMaxLength(40);
            entity.Property(e => e.PatternName).HasMaxLength(255);
            entity.Property(e => e.PatternNameUnsign).HasMaxLength(255);
            entity.Property(e => e.Postfix).HasMaxLength(50);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RewardsVoucherTransaction>(entity =>
        {
            entity.ToTable("rewards_VoucherTransaction");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherTransaction_TenantId");

            entity.Property(e => e.EventFilter).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(50);
            entity.Property(e => e.PatternCode).HasMaxLength(40);
            entity.Property(e => e.PublisherCode).HasMaxLength(40);
            entity.Property(e => e.ReferenceCode).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TriggerEvent).HasMaxLength(40);
            entity.Property(e => e.VoucherCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
            entity.Property(e => e.VoucherUser).HasMaxLength(50);
        });

        modelBuilder.Entity<RewardsVoucherTransactionLog>(entity =>
        {
            entity.ToTable("rewards_VoucherTransactionLog");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherTransactionLog_TenantId");

            entity.Property(e => e.EventFilter).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(50);
            entity.Property(e => e.PatternCode).HasMaxLength(40);
            entity.Property(e => e.PublisherCode).HasMaxLength(40);
            entity.Property(e => e.ReferenceCode).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TerminalId).HasColumnName("TerminalID");
            entity.Property(e => e.TransactionStatus).HasMaxLength(20);
            entity.Property(e => e.TransactionType).HasMaxLength(20);
            entity.Property(e => e.TriggerEvent).HasMaxLength(40);
            entity.Property(e => e.VoucherCode).HasMaxLength(40);
            entity.Property(e => e.VoucherGroupCode).HasMaxLength(40);
            entity.Property(e => e.VoucherUser).HasMaxLength(50);
        });

        modelBuilder.Entity<RewardsVoucherUser>(entity =>
        {
            entity.ToTable("rewards_VoucherUser");

            entity.HasIndex(e => e.RewardTargetAudienceId, "IX_rewards_VoucherUser_RewardTargetAudienceID");

            entity.HasIndex(e => e.TenantId, "IX_rewards_VoucherUser_TenantId");

            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.RewardTargetAudienceId).HasColumnName("RewardTargetAudienceID");
            entity.Property(e => e.TargetAudienceLinkId).HasColumnName("TargetAudienceLinkID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");

            entity.HasOne(d => d.RewardTargetAudience).WithMany(p => p.RewardsVoucherUsers).HasForeignKey(d => d.RewardTargetAudienceId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => e.CreatorUserId, "IX_Roles_CreatorUserId");

            entity.HasIndex(e => e.DeleterUserId, "IX_Roles_DeleterUserId");

            entity.HasIndex(e => e.LastModifierUserId, "IX_Roles_LastModifierUserId");

            entity.HasIndex(e => new { e.TenantId, e.NormalizedName }, "IX_Roles_TenantId_NormalizedName");

            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);
            entity.Property(e => e.DisplayName).HasMaxLength(64);
            entity.Property(e => e.Name).HasMaxLength(32);
            entity.Property(e => e.NormalizedName).HasMaxLength(32);
            entity.Property(e => e.OrganazationUnitDefault).HasMaxLength(95);
        });

        modelBuilder.Entity<RoleClaim>(entity =>
        {
            entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

            entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_RoleClaims_TenantId_ClaimType");

            entity.Property(e => e.ClaimType).HasMaxLength(256);

            entity.HasOne(d => d.Role).WithMany(p => p.RoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<RwActionLog>(entity =>
        {
            entity.ToTable("RW_ActionLog");

            entity.HasIndex(e => e.ActionDate, "IX_RW_ActionLog_ActionDate");

            entity.HasIndex(e => e.TableName, "IX_RW_ActionLog_TableName");

            entity.Property(e => e.ActionType).HasMaxLength(20);
            entity.Property(e => e.ColumnName).HasMaxLength(100);
            entity.Property(e => e.NewValue).HasMaxLength(500);
            entity.Property(e => e.OldValue).HasMaxLength(500);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<RwComboDepartment>(entity =>
        {
            entity.ToTable("RW_ComboDepartment");

            entity.Property(e => e.ComboDepartmentCode).HasMaxLength(40);
            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.FullDeptCode).HasMaxLength(100);
        });

        modelBuilder.Entity<RwComboDetail>(entity =>
        {
            entity.ToTable("RW_ComboDetail");

            entity.HasIndex(e => e.ComboHeaderCode, "IX_RW_ComboDetail_ComboHeaderCode");

            entity.Property(e => e.AccessoryName).HasMaxLength(255);
            entity.Property(e => e.ColdDeviceName).HasMaxLength(255);
            entity.Property(e => e.ComboDetailCode).HasMaxLength(40);
            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.ComboType).HasMaxLength(40);
            entity.Property(e => e.HotDeviceName).HasMaxLength(255);
            entity.Property(e => e.MainDeviceName).HasMaxLength(255);
        });

        modelBuilder.Entity<RwComboHeader>(entity =>
        {
            entity.ToTable("RW_ComboHeader");

            entity.HasIndex(e => e.ComboHeaderCode, "IX_RW_ComboHeader_ComboHeaderCode");

            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.ComboHeaderName).HasMaxLength(255);
            entity.Property(e => e.FormulaHeaderCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RwComboProduct>(entity =>
        {
            entity.ToTable("RW_ComboProduct");

            entity.HasIndex(e => e.ComboHeaderCode, "IX_RW_ComboProduct_ComboHeaderCode");

            entity.HasIndex(e => e.ProductCode, "IX_RW_ComboProduct_ProductCode");

            entity.Property(e => e.ComboDepartmentCode).HasMaxLength(40);
            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
        });

        modelBuilder.Entity<RwFormulaDetail>(entity =>
        {
            entity.ToTable("RW_FormulaDetail");

            entity.HasIndex(e => e.FormulaDetailCode, "IX_RW_FormulaDetail_FormulaDetailCode");

            entity.HasIndex(e => e.FormulaHeaderCode, "IX_RW_FormulaDetail_FormulaHeaderCode");

            entity.Property(e => e.FormulaDetailCode).HasMaxLength(40);
            entity.Property(e => e.FormulaDetailName).HasMaxLength(255);
            entity.Property(e => e.FormulaHeaderCode).HasMaxLength(40);
        });

        modelBuilder.Entity<RwFormulaHeader>(entity =>
        {
            entity.ToTable("RW_FormulaHeader");

            entity.HasIndex(e => e.ComboHeaderCode, "IX_RW_FormulaHeader_ComboHeaderCode");

            entity.HasIndex(e => e.FormulaHeaderCode, "IX_RW_FormulaHeader_FormulaHeaderCode");

            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FormulaHeaderCode).HasMaxLength(40);
            entity.Property(e => e.FormulaHeaderName).HasMaxLength(255);
        });

        modelBuilder.Entity<RwWarrantyAdjustmentFileStatus>(entity =>
        {
            entity.ToTable("RW_WarrantyAdjustmentFileStatus");

            entity.HasIndex(e => e.Code, "IX_RW_WarrantyAdjustmentFileStatus_Code");

            entity.HasIndex(e => e.FileName, "IX_RW_WarrantyAdjustmentFileStatus_FileName");

            entity.HasIndex(e => e.TenantId, "IX_RW_WarrantyAdjustmentFileStatus_TenantId");

            entity.Property(e => e.Reason).HasMaxLength(100);
        });

        modelBuilder.Entity<RwWarrantyAdjustmentLog>(entity =>
        {
            entity.ToTable("RW_WarrantyAdjustmentLog");

            entity.HasIndex(e => e.Serial, "IX_RW_WarrantyAdjustmentLog_Serial");

            entity.HasIndex(e => e.TenantId, "IX_RW_WarrantyAdjustmentLog_TenantId");

            entity.Property(e => e.Approver).HasMaxLength(100);
            entity.Property(e => e.NewAddress)
                .HasMaxLength(255)
                .HasColumnName("New_Address");
            entity.Property(e => e.NewCustomerName)
                .HasMaxLength(255)
                .HasColumnName("New_CustomerName");
            entity.Property(e => e.NewDistrictCode)
                .HasMaxLength(40)
                .HasColumnName("New_DistrictCode");
            entity.Property(e => e.NewDistrictName)
                .HasMaxLength(255)
                .HasColumnName("New_DistrictName");
            entity.Property(e => e.NewEffectRegistration).HasColumnName("New_EffectRegistration");
            entity.Property(e => e.NewEmail)
                .HasMaxLength(100)
                .HasColumnName("New_Email");
            entity.Property(e => e.NewInternalExpiredDateAccessory).HasColumnName("New_InternalExpiredDate_Accessory");
            entity.Property(e => e.NewInternalExpiredDateMainDevice).HasColumnName("New_InternalExpiredDate_MainDevice");
            entity.Property(e => e.NewPhone)
                .HasMaxLength(40)
                .HasColumnName("New_Phone");
            entity.Property(e => e.NewProvinceCode)
                .HasMaxLength(40)
                .HasColumnName("New_ProvinceCode");
            entity.Property(e => e.NewProvinceName)
                .HasMaxLength(255)
                .HasColumnName("New_ProvinceName");
            entity.Property(e => e.NewPublicExpiredDateAccessory).HasColumnName("New_PublicExpiredDate_Accessory");
            entity.Property(e => e.NewPublicExpiredDateMainDevice).HasColumnName("New_PublicExpiredDate_MainDevice");
            entity.Property(e => e.OldAddress)
                .HasMaxLength(255)
                .HasColumnName("Old_Address");
            entity.Property(e => e.OldCustomerName)
                .HasMaxLength(255)
                .HasColumnName("Old_CustomerName");
            entity.Property(e => e.OldDistrictCode)
                .HasMaxLength(40)
                .HasColumnName("Old_DistrictCode");
            entity.Property(e => e.OldDistrictName)
                .HasMaxLength(255)
                .HasColumnName("Old_DistrictName");
            entity.Property(e => e.OldEffectRegistration).HasColumnName("Old_EffectRegistration");
            entity.Property(e => e.OldEmail)
                .HasMaxLength(100)
                .HasColumnName("Old_Email");
            entity.Property(e => e.OldInternalExpiredDateAccessory).HasColumnName("Old_InternalExpiredDate_Accessory");
            entity.Property(e => e.OldInternalExpiredDateMainDevice).HasColumnName("Old_InternalExpiredDate_MainDevice");
            entity.Property(e => e.OldPhone)
                .HasMaxLength(40)
                .HasColumnName("Old_Phone");
            entity.Property(e => e.OldProvinceCode)
                .HasMaxLength(40)
                .HasColumnName("Old_ProvinceCode");
            entity.Property(e => e.OldProvinceName)
                .HasMaxLength(255)
                .HasColumnName("Old_ProvinceName");
            entity.Property(e => e.OldPublicExpiredDateAccessory).HasColumnName("Old_PublicExpiredDate_Accessory");
            entity.Property(e => e.OldPublicExpiredDateMainDevice).HasColumnName("Old_PublicExpiredDate_MainDevice");
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.Source).HasMaxLength(100);
        });

        modelBuilder.Entity<RwWarrantySerial>(entity =>
        {
            entity.ToTable("RW_WarrantySerial");

            entity.HasIndex(e => e.CustomerName, "IX_RW_WarrantySerial_CustomerName");

            entity.HasIndex(e => e.Email, "IX_RW_WarrantySerial_Email");

            entity.HasIndex(e => e.RegisterDate, "IX_RW_WarrantySerial_RegisterDate");

            entity.HasIndex(e => e.Serial, "IX_RW_WarrantySerial_Serial");

            entity.HasIndex(e => e.SerialRefCode, "IX_RW_WarrantySerial_SerialRefCode");

            entity.Property(e => e.AccessoryName).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BaseSerial).HasMaxLength(100);
            entity.Property(e => e.ComboHeaderCode).HasMaxLength(40);
            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.DistrictCode).HasMaxLength(40);
            entity.Property(e => e.DistrictName).HasMaxLength(255);
            entity.Property(e => e.EffectRegistration).HasDefaultValue(12);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FormulaHeaderCode).HasMaxLength(40);
            entity.Property(e => e.FullDeptCode).HasMaxLength(100);
            entity.Property(e => e.FullDeptName).HasMaxLength(255);
            entity.Property(e => e.InternalExpiredDateAccessory).HasColumnName("InternalExpiredDate_Accessory");
            entity.Property(e => e.InternalExpiredDateMainDevice).HasColumnName("InternalExpiredDate_MainDevice");
            entity.Property(e => e.MainDeviceName).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Notes).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ProvinceCode).HasMaxLength(40);
            entity.Property(e => e.ProvinceName).HasMaxLength(255);
            entity.Property(e => e.PublicExpiredDateAccessory).HasColumnName("PublicExpiredDate_Accessory");
            entity.Property(e => e.PublicExpiredDateMainDevice).HasColumnName("PublicExpiredDate_MainDevice");
            entity.Property(e => e.PurchaseInvoice).HasMaxLength(64);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.SerialRefCode).HasMaxLength(100);
            entity.Property(e => e.SerialType).HasMaxLength(30);
            entity.Property(e => e.WardCode).HasMaxLength(40);
            entity.Property(e => e.WardName).HasMaxLength(255);
            entity.Property(e => e.WarrantyCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ScanSerialRequestTransaction>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_ScanSerialRequestTransactions_Id");

            entity.HasIndex(e => e.TenantId, "IX_ScanSerialRequestTransactions_TenantId");
        });

        modelBuilder.Entity<SellIn1221>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SellIn1221");

            entity.Property(e => e.MãNppNhậpSảnPhẩm)
                .HasMaxLength(255)
                .HasColumnName("Mã NPP nhập sản phẩm");
            entity.Property(e => e.MãSerial)
                .HasMaxLength(255)
                .HasColumnName("Mã serial");
            entity.Property(e => e.MãĐạiLý)
                .HasMaxLength(255)
                .HasColumnName("Mã đại lý");
            entity.Property(e => e.NgàyTíchĐiểm)
                .HasMaxLength(255)
                .HasColumnName("Ngày tích điểm");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốĐiểmĐạtĐược).HasColumnName("Số điểm đạt được");
            entity.Property(e => e.TrạngTháiKíchHoạt)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái kích hoạt");
            entity.Property(e => e.TênThiếtBị)
                .HasMaxLength(255)
                .HasColumnName("Tên thiết bị");
            entity.Property(e => e.TênĐạiLý)
                .HasMaxLength(255)
                .HasColumnName("Tên đại lý");
        });

        modelBuilder.Entity<Sellinfull>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sellinfull");

            entity.Property(e => e.Membercode).HasMaxLength(255);
            entity.Property(e => e.Model).HasMaxLength(255);
            entity.Property(e => e.MãNppNhậpSảnPhẩm)
                .HasMaxLength(255)
                .HasColumnName("Mã NPP nhập sản phẩm");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NgàyTíchĐiểm)
                .HasMaxLength(255)
                .HasColumnName("Ngày tích điểm");
            entity.Property(e => e.Serial).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốĐiểmĐạtĐược).HasColumnName("Số điểm đạt được");
        });

        modelBuilder.Entity<Sellout1221>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sellout1221");

            entity.Property(e => e.Họtênkháchhàng).HasMaxLength(255);
            entity.Property(e => e.Mãkíchhoạt).HasMaxLength(255);
            entity.Property(e => e.Mãserial).HasMaxLength(255);
            entity.Property(e => e.Mãđạilý).HasMaxLength(255);
            entity.Property(e => e.Ngàykíchhoạt).HasMaxLength(255);
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.Sốđiệnthoạidiđộng).HasMaxLength(255);
            entity.Property(e => e.TrạngThái)
                .HasMaxLength(255)
                .HasColumnName("trạng thái");
            entity.Property(e => e.Tênthiếtbị).HasMaxLength(255);
            entity.Property(e => e.Tênđạilý).HasMaxLength(255);
            entity.Property(e => e.TỉnhThànhphố)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/thànhphố");
            entity.Property(e => e.Địachỉ).HasMaxLength(255);
        });

        modelBuilder.Entity<Sellout3112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sellout3112");

            entity.Property(e => e.Họtênkháchhàng).HasMaxLength(255);
            entity.Property(e => e.Mãkíchhoạt).HasMaxLength(255);
            entity.Property(e => e.Mãserial).HasMaxLength(255);
            entity.Property(e => e.Mãđạilý).HasMaxLength(255);
            entity.Property(e => e.Ngàykíchhoạt).HasMaxLength(255);
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.Sốđiệnthoạidiđộng).HasMaxLength(255);
            entity.Property(e => e.TrạngThái)
                .HasMaxLength(255)
                .HasColumnName("trạng thái");
            entity.Property(e => e.Tênthiếtbị).HasMaxLength(255);
            entity.Property(e => e.Tênđạilý).HasMaxLength(255);
            entity.Property(e => e.TỉnhThànhphố)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/thànhphố");
            entity.Property(e => e.Địachỉ).HasMaxLength(255);
        });

        modelBuilder.Entity<Selloutfull>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("selloutfull");

            entity.Property(e => e.HọTênKháchHàng)
                .HasMaxLength(255)
                .HasColumnName("Họ tên khách hàng");
            entity.Property(e => e.MãKíchHoạt)
                .HasMaxLength(255)
                .HasColumnName("Mã kích hoạt");
            entity.Property(e => e.MãSerial)
                .HasMaxLength(255)
                .HasColumnName("Mã serial");
            entity.Property(e => e.MãĐạiLý)
                .HasMaxLength(255)
                .HasColumnName("Mã đại lý");
            entity.Property(e => e.NgàyKíchHoạt)
                .HasMaxLength(255)
                .HasColumnName("Ngày kích hoạt");
            entity.Property(e => e.PhườngXã)
                .HasMaxLength(255)
                .HasColumnName("Phường/ xã");
            entity.Property(e => e.QuậnHuyện)
                .HasMaxLength(255)
                .HasColumnName("Quận/ huyện");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.SốĐiểmĐạtĐược).HasColumnName("Số điểm đạt được");
            entity.Property(e => e.SốĐiệnThoạiDiĐộng)
                .HasMaxLength(255)
                .HasColumnName("Số điện thoại di động");
            entity.Property(e => e.TrạngTháiThanhToán)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái thanh toán");
            entity.Property(e => e.TênThiếtBị)
                .HasMaxLength(255)
                .HasColumnName("Tên thiết bị");
            entity.Property(e => e.TênĐạiLý)
                .HasMaxLength(255)
                .HasColumnName("Tên đại lý");
            entity.Property(e => e.TỉnhThànhPhố)
                .HasMaxLength(255)
                .HasColumnName("Tỉnh/ thành phố");
            entity.Property(e => e.ĐịaChỉ)
                .HasMaxLength(255)
                .HasColumnName("Địa chỉ");
        });

        modelBuilder.Entity<SelltoDistributor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SelltoDistributor");

            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("date");
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.ItemDetailCode).HasMaxLength(255);
            entity.Property(e => e.ItemSerialNo).HasMaxLength(255);
            entity.Property(e => e.Npp)
                .HasMaxLength(255)
                .HasColumnName("NPP");
            entity.Property(e => e.Reformat)
                .HasMaxLength(255)
                .HasColumnName("reformat");
            entity.Property(e => e.SoldToParty)
                .HasMaxLength(255)
                .HasColumnName("Sold to party");
        });

        modelBuilder.Entity<Seria1111>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'seria1111$'");

            entity.Property(e => e.MãSerial)
                .HasMaxLength(255)
                .HasColumnName("Mã serial");
            entity.Property(e => e.MãSảnPhẩm)
                .HasMaxLength(255)
                .HasColumnName("Mã sản phẩm");
            entity.Property(e => e.NgàySellIn)
                .HasMaxLength(255)
                .HasColumnName("Ngày sell-in");
            entity.Property(e => e.NgàySellOut)
                .HasMaxLength(255)
                .HasColumnName("Ngày sell-out");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TrạngTháiSellIn)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái sell-in");
            entity.Property(e => e.TrạngTháiSellOut)
                .HasMaxLength(255)
                .HasColumnName("Trạng thái sell-out");
        });

        modelBuilder.Entity<Serial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Serial");

            entity.Property(e => e.HierarchyL1).HasMaxLength(40);
            entity.Property(e => e.HierarchyL2).HasMaxLength(40);
            entity.Property(e => e.HierarchyL3).HasMaxLength(40);
            entity.Property(e => e.HierarchyL4).HasMaxLength(40);
            entity.Property(e => e.HierarchyL5).HasMaxLength(40);
            entity.Property(e => e.ProductCode).HasMaxLength(40);
            entity.Property(e => e.ProductName1).HasMaxLength(255);
            entity.Property(e => e.ProductName2).HasMaxLength(255);
            entity.Property(e => e.Serial1)
                .HasMaxLength(100)
                .HasColumnName("Serial");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.Name }, "IX_Settings_TenantId_Name");

            entity.HasIndex(e => e.UserId, "IX_Settings_UserId");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.Value).HasMaxLength(2000);

            entity.HasOne(d => d.User).WithMany(p => p.Settings).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<SocialretailerActivationCode>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("socialretailer_ActivationCode");

            entity.HasIndex(e => e.CreationTime, "IX_ActivationCode_partitioncol").IsClustered();

            entity.HasIndex(e => e.Code, "IX_socialretailer_ActivationCode_Code");

            entity.HasIndex(e => new { e.Code, e.IsCancel }, "IX_socialretailer_ActivationCode_Code_IsCancel");

            entity.HasIndex(e => new { e.CreationTime, e.Serial }, "IX_socialretailer_ActivationCode_Serial");

            entity.HasIndex(e => new { e.CreationTime, e.Serial, e.IsCancel }, "IX_socialretailer_ActivationCode_Serial_IsCancel");

            entity.HasIndex(e => new { e.CreationTime, e.Serial }, "NonClusteredIndex-20230905-170756");

            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.MassOrder).HasMaxLength(100);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerActivationCode20230530>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_ActivationCode_20230530");

            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerActivationCodeDelete25042023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_ActivationCode_delete_25042023");

            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerActivationCodeDeleted>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("socialretailer_ActivationCode_deleted");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(64);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerAging>(entity =>
        {
            entity.HasKey(e => e.Serial).HasName("PK__socialre__1A00E092A56E0912");

            entity.ToTable("socialretailer_Aging");

            entity.Property(e => e.Serial).HasMaxLength(255);
            entity.Property(e => e.DeptName1).HasMaxLength(255);
            entity.Property(e => e.DeptName2).HasMaxLength(255);
            entity.Property(e => e.DeptName3).HasMaxLength(255);
            entity.Property(e => e.InStockAt).HasMaxLength(255);
            entity.Property(e => e.LastTransType).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(255);
            entity.Property(e => e.ProductionStatus).HasMaxLength(255);
            entity.Property(e => e.WareHouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerAutoReplySetting>(entity =>
        {
            entity.ToTable("socialretailer_AutoReplySetting");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_AutoReplySetting_TenantId");

            entity.Property(e => e.Content).HasMaxLength(2000);
            entity.Property(e => e.Keywords).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerBeatPlanDetail>(entity =>
        {
            entity.ToTable("socialretailer_BeatPlanDetail");

            entity.HasIndex(e => new { e.BeatPlanCode, e.OutletCode, e.SalesmanCode }, "IX_socialretailer_BeatPlanDetail_BeatPlanCode_OutletCode_SalesmanCode")
                .IsUnique()
                .HasFilter("([BeatPlanCode] IS NOT NULL AND [OutletCode] IS NOT NULL AND [SalesmanCode] IS NOT NULL)");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_BeatPlanDetail_TenantId");

            entity.HasIndex(e => new { e.OutletCode, e.Status, e.SalesmanCode }, "missing_index_11");

            entity.HasIndex(e => new { e.BeatPlanCode, e.OutletCode, e.Status, e.SalesmanCode }, "missing_index_7");

            entity.Property(e => e.BeatPlanCode).HasMaxLength(40);
            entity.Property(e => e.Frequency).HasMaxLength(40);
            entity.Property(e => e.MasterNameUnSign).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerBeatPlanHeader>(entity =>
        {
            entity.ToTable("socialretailer_BeatPlanHeader");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_BeatPlanHeader_TenantId");

            entity.HasIndex(e => new { e.SalesmanCode, e.Status, e.FromDate, e.ToDate }, "missing_index_488");

            entity.HasIndex(e => e.SalesmanCode, "missing_index_9");

            entity.Property(e => e.BeatPlanCode).HasMaxLength(40);
            entity.Property(e => e.BeatPlanName).HasMaxLength(255);
            entity.Property(e => e.MasterNameUnSign).HasMaxLength(255);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerBeatPlanResult>(entity =>
        {
            entity.ToTable("socialretailer_BeatPlanResult", tb => tb.HasTrigger("socialretailer_BeatPlanResult_insert"));

            entity.HasIndex(e => e.BeatPlanCode, "IX_socialretailer_BeatPlanResult_BeatPlanCode");

            entity.HasIndex(e => e.CheckInTime, "IX_socialretailer_BeatPlanResult_CheckInTime");

            entity.HasIndex(e => e.CheckOutTime, "IX_socialretailer_BeatPlanResult_CheckOutTime");

            entity.HasIndex(e => e.SalemanCode, "IX_socialretailer_BeatPlanResult_SalemanCode");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_BeatPlanResult_TenantId");

            entity.HasIndex(e => new { e.OutletCode, e.SalemanCode }, "missing_index_705");

            entity.Property(e => e.BeatPlanCode).HasMaxLength(40);
            entity.Property(e => e.BeatPlanName).HasMaxLength(255);
            entity.Property(e => e.CheckInDistant).HasMaxLength(40);
            entity.Property(e => e.CheckInImageLink).HasMaxLength(500);
            entity.Property(e => e.CheckInLastitude).HasMaxLength(40);
            entity.Property(e => e.CheckInLongitude).HasMaxLength(40);
            entity.Property(e => e.CheckOutDistant).HasMaxLength(40);
            entity.Property(e => e.CheckOutImageLink).HasMaxLength(500);
            entity.Property(e => e.CheckOutLastitude).HasMaxLength(40);
            entity.Property(e => e.CheckOutLongitude).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.SalemanCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerChallengeFollow>(entity =>
        {
            entity.ToTable("socialretailer_ChallengeFollow");

            entity.HasIndex(e => e.ChallengeId, "IX_socialretailer_ChallengeFollow_ChallengeId");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_ChallengeFollow_MemberCode");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerChallengeHeader>(entity =>
        {
            entity.ToTable("socialretailer_ChallengeHeader");

            entity.HasIndex(e => e.Code, "IX_socialretailer_ChallengeHeader_Code");

            entity.HasIndex(e => e.EffectFrom, "IX_socialretailer_ChallengeHeader_EffectFrom");

            entity.HasIndex(e => e.EffectTo, "IX_socialretailer_ChallengeHeader_EffectTo");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(500);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceType).HasMaxLength(40);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerChallengePhotoDetail>(entity =>
        {
            entity.ToTable("socialretailer_ChallengePhotoDetail");

            entity.HasIndex(e => e.ChallengeId, "IX_socialretailer_ChallengePhotoDetail_ChallengeId");

            entity.Property(e => e.NameOfPhoto).HasMaxLength(500);
        });

        modelBuilder.Entity<SocialretailerChallengeResult>(entity =>
        {
            entity.ToTable("socialretailer_ChallengeResult");

            entity.HasIndex(e => e.ChallengeId, "IX_socialretailer_ChallengeResult_ChallengeId");

            entity.HasIndex(e => e.ChallengePhotoDetailId, "IX_socialretailer_ChallengeResult_ChallengePhotoDetailId");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_ChallengeResult_MemberCode");

            entity.Property(e => e.MemberCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerChallengeResultBk20221011>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_ChallengeResult_bk20221011");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MemberCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerChallengeTargetAudience>(entity =>
        {
            entity.ToTable("socialretailer_ChallengeTargetAudience");

            entity.HasIndex(e => e.Status, "IX_socialretailer_ChallengeTargetAudience_Status");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerChallengeTargetAudienceDetail>(entity =>
        {
            entity.ToTable("socialretailer_ChallengeTargetAudienceDetail");

            entity.HasIndex(e => e.ChallengeTargetAudienceId, "IX_socialretailer_ChallengeTargetAudienceDetail_ChallengeTargetAudienceID");

            entity.HasIndex(e => e.Email, "IX_socialretailer_ChallengeTargetAudienceDetail_Email");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_ChallengeTargetAudienceDetail_MemberCode");

            entity.HasIndex(e => e.Phone, "IX_socialretailer_ChallengeTargetAudienceDetail_Phone");

            entity.Property(e => e.ChallengeTargetAudienceId).HasColumnName("ChallengeTargetAudienceID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<SocialretailerComponentRuler>(entity =>
        {
            entity.ToTable("socialretailer_ComponentRuler");

            entity.HasIndex(e => e.RuleGeneratorId, "IX_socialretailer_ComponentRuler_RuleGeneratorId");

            entity.HasOne(d => d.RuleGenerator).WithMany(p => p.SocialretailerComponentRulers).HasForeignKey(d => d.RuleGeneratorId);
        });

        modelBuilder.Entity<SocialretailerConsentReport>(entity =>
        {
            entity.ToTable("socialretailer_ConsentReport");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_ConsentReport_TenantId");

            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.Otp)
                .HasMaxLength(20)
                .HasColumnName("OTP");
            entity.Property(e => e.PhoneNumber).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerConversationStatus>(entity =>
        {
            entity.ToTable("socialretailer_ConversationStatus");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_ConversationStatus_TenantId");

            entity.Property(e => e.RetailerCode).HasMaxLength(40);
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<SocialretailerExtendActiveSerial>(entity =>
        {
            entity.ToTable("socialretailer_ExtendActiveSerial");

            entity.Property(e => e.EffectSellMbs).HasColumnName("EffectSellMBS");
            entity.Property(e => e.EffectSellNpp).HasColumnName("EffectSellNPP");
        });

        modelBuilder.Entity<SocialretailerGameSetting>(entity =>
        {
            entity.ToTable("socialretailer_GameSetting");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_GameSetting_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FullLink).HasMaxLength(2000);
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.LotteryCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerMemberWareHouse>(entity =>
        {
            entity.ToTable("socialretailer_MemberWareHouses");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_MemberWareHouses_MemberCode");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_MemberWareHouses_TenantId");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(2048);
            entity.Property(e => e.Lat)
                .HasMaxLength(40)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(40)
                .HasColumnName("LNG");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.VerifyStatus).HasMaxLength(20);
            entity.Property(e => e.Ward).HasMaxLength(50);
        });

        modelBuilder.Entity<SocialretailerOrder>(entity =>
        {
            entity.ToTable("socialretailer_Order");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_Order_TenantId");
        });

        modelBuilder.Entity<SocialretailerOrderItem>(entity =>
        {
            entity.ToTable("socialretailer_OrderItem");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_OrderItem_TenantId");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SocialretailerOutletCheckHistory>(entity =>
        {
            entity.ToTable("socialretailer_OutletCheckHistory");

            entity.Property(e => e.ActivationCode).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Serial).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerOutletInfo>(entity =>
        {
            entity.ToTable("socialretailer_OutletInfo");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_OutletInfo_MemberCode");

            entity.HasIndex(e => e.Name, "IX_socialretailer_OutletInfo_Name");

            entity.HasIndex(e => e.NameUnSign, "IX_socialretailer_OutletInfo_NameUnSign");

            entity.HasIndex(e => e.OutletCode, "IX_socialretailer_OutletInfo_OutletCode")
                .IsUnique()
                .HasFilter("([OutletCode] IS NOT NULL)");

            entity.HasIndex(e => e.OutletType, "IX_socialretailer_OutletInfo_OutletType");

            entity.HasIndex(e => e.Phone, "IX_socialretailer_OutletInfo_Phone");

            entity.HasIndex(e => e.RegionCode, "IX_socialretailer_OutletInfo_RegionCode");

            entity.HasIndex(e => e.SalesChannel, "IX_socialretailer_OutletInfo_SalesChannel");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_OutletInfo_TenantId");

            entity.HasIndex(e => e.VerifyStatus, "IX_socialretailer_OutletInfo_VerifyStatus");

            entity.HasIndex(e => e.IdentificationCardNumber, "missing_index_111");

            entity.HasIndex(e => e.TaxCode, "missing_index_117");

            entity.HasIndex(e => e.Email, "missing_index_163");

            entity.HasIndex(e => e.OutletType, "missing_index_252");

            entity.HasIndex(e => new { e.IsDeleted, e.Status }, "missing_index_92");

            entity.Property(e => e.AccountCode).HasMaxLength(40);
            entity.Property(e => e.AccumulationPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellIn).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellOut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(40);
            entity.Property(e => e.BankBranchName).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BossName).HasMaxLength(255);
            entity.Property(e => e.BusinessType).HasMaxLength(255);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DeviceNameCode).HasMaxLength(40);
            entity.Property(e => e.DistributorCode).HasMaxLength(40);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.ExpiringCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.IdentificationCardBackImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardFrontImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardNumber).HasMaxLength(40);
            entity.Property(e => e.InterestOf).HasMaxLength(255);
            entity.Property(e => e.IsInterestCobrand).HasColumnName("isInterestCobrand");
            entity.Property(e => e.Lat)
                .HasMaxLength(40)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(40)
                .HasColumnName("LNG");
            entity.Property(e => e.LockUpdateChatId).HasColumnName("LockUpdateChatID");
            entity.Property(e => e.LockedType).HasMaxLength(4);
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MissingRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletType).HasMaxLength(40);
            entity.Property(e => e.Password).HasMaxLength(32);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.PointToKeepRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.PointToNextRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.ReferralCode).HasMaxLength(40);
            entity.Property(e => e.RegionCode).HasMaxLength(255);
            entity.Property(e => e.SalesChannel).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.Sapcode)
                .HasMaxLength(40)
                .HasColumnName("SAPCode");
            entity.Property(e => e.SourceId)
                .HasMaxLength(20)
                .HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SupervisorCode).HasMaxLength(40);
            entity.Property(e => e.SupervisorName).HasMaxLength(255);
            entity.Property(e => e.TargetRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxCode).HasMaxLength(40);
            entity.Property(e => e.TypeOfDeviceCode).HasMaxLength(40);
            entity.Property(e => e.VerifyStatus).HasMaxLength(40);
            entity.Property(e => e.Ward).HasMaxLength(50);
            entity.Property(e => e.WarehouseAddress).HasMaxLength(255);
            entity.Property(e => e.ZaloName).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerOutletInfoArch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_OutletInfo_arch");

            entity.Property(e => e.AccountCode).HasMaxLength(40);
            entity.Property(e => e.AccumulationPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellIn).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellOut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(40);
            entity.Property(e => e.BankBranchName).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BossName).HasMaxLength(255);
            entity.Property(e => e.BrowserCode).HasMaxLength(40);
            entity.Property(e => e.BusinessType).HasMaxLength(255);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DeviceNameCode).HasMaxLength(40);
            entity.Property(e => e.DistributorCode).HasMaxLength(40);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.ExpiringCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IdentificationCardBackImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardFrontImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardNumber).HasMaxLength(40);
            entity.Property(e => e.InterestOf).HasMaxLength(255);
            entity.Property(e => e.IsInterestCobrand).HasColumnName("isInterestCobrand");
            entity.Property(e => e.Lat)
                .HasMaxLength(40)
                .HasColumnName("LAT");
            entity.Property(e => e.Lng)
                .HasMaxLength(40)
                .HasColumnName("LNG");
            entity.Property(e => e.LockUpdateChatId).HasColumnName("LockUpdateChatID");
            entity.Property(e => e.LockedType).HasMaxLength(4);
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MissingRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.Note1).HasMaxLength(255);
            entity.Property(e => e.Note2).HasMaxLength(255);
            entity.Property(e => e.Note3).HasMaxLength(255);
            entity.Property(e => e.Note4).HasMaxLength(255);
            entity.Property(e => e.Note5).HasMaxLength(255);
            entity.Property(e => e.OccupationCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletType).HasMaxLength(40);
            entity.Property(e => e.Password).HasMaxLength(32);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pid)
                .HasMaxLength(20)
                .HasColumnName("PID");
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.PointToKeepRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.PointToNextRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.ReferralCode).HasMaxLength(40);
            entity.Property(e => e.RegionCode).HasMaxLength(255);
            entity.Property(e => e.SalesChannel).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.Sapcode)
                .HasMaxLength(40)
                .HasColumnName("SAPCode");
            entity.Property(e => e.SourceId)
                .HasMaxLength(20)
                .HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.SupervisorCode).HasMaxLength(40);
            entity.Property(e => e.SupervisorName).HasMaxLength(255);
            entity.Property(e => e.TargetRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxCode).HasMaxLength(40);
            entity.Property(e => e.TypeOfDeviceCode).HasMaxLength(40);
            entity.Property(e => e.Ward).HasMaxLength(50);
            entity.Property(e => e.WarehouseAddress).HasMaxLength(255);
            entity.Property(e => e.ZaloName).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerOutletInfoDetail>(entity =>
        {
            entity.ToTable("socialretailer_OutletInfoDetail");

            entity.HasIndex(e => e.OutletCode, "IX_socialretailer_OutletInfoDetail_OutletCode");

            entity.HasIndex(e => e.PhoneUpdated, "IX_socialretailer_OutletInfoDetail_PhoneUpdated");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_OutletInfoDetail_TenantId");

            entity.Property(e => e.AuthenOtpdate).HasColumnName("AuthenOTPDate");
            entity.Property(e => e.Gapdistance).HasColumnName("GAPDistance");
            entity.Property(e => e.HomePhone).HasMaxLength(40);
            entity.Property(e => e.Latupdated)
                .HasMaxLength(40)
                .HasColumnName("LATUpdated");
            entity.Property(e => e.Lngupdated)
                .HasMaxLength(40)
                .HasColumnName("LNGUpdated");
            entity.Property(e => e.Otp)
                .HasMaxLength(20)
                .HasColumnName("OTP");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.PhoneUpdateStatus).HasMaxLength(20);
            entity.Property(e => e.PhoneUpdated).HasMaxLength(40);
            entity.Property(e => e.ReasonPhone).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.TimeSendOtp).HasColumnName("TimeSendOTP");
            entity.Property(e => e.UpdateType).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerOutletInfoUpdateHistory>(entity =>
        {
            entity.ToTable("socialretailer_OutletInfoUpdateHistory");

            entity.HasIndex(e => e.OutletId, "IX_socialretailer_OutletInfoUpdateHistory_OutletId");

            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Type).HasMaxLength(40);
            entity.Property(e => e.TypeDescription).HasMaxLength(256);
        });

        modelBuilder.Entity<SocialretailerOutletRevenueBaseline>(entity =>
        {
            entity.ToTable("socialretailer_OutletRevenueBaseline");

            entity.HasIndex(e => new { e.OutletCode, e.CumulatedMonth }, "IX_socialretailer_OutletRevenueBaseline_OutletCode_CumulatedMonth")
                .IsUnique()
                .HasFilter("([OutletCode] IS NOT NULL AND [CumulatedMonth] IS NOT NULL)");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_OutletRevenueBaseline_TenantId");

            entity.Property(e => e.Actual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletName).HasMaxLength(255);
            entity.Property(e => e.Target).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SocialretailerOutletUpdateHistory>(entity =>
        {
            entity.ToTable("socialretailer_OutletUpdateHistory");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_OutletUpdateHistory_TenantId");

            entity.Property(e => e.AuthenOtpdate).HasColumnName("AuthenOTPDate");
            entity.Property(e => e.Gapdistance).HasColumnName("GAPDistance");
            entity.Property(e => e.HomePhone).HasMaxLength(40);
            entity.Property(e => e.Latupdated)
                .HasMaxLength(40)
                .HasColumnName("LATUpdated");
            entity.Property(e => e.Lngupdated)
                .HasMaxLength(40)
                .HasColumnName("LNGUpdated");
            entity.Property(e => e.Otp)
                .HasMaxLength(20)
                .HasColumnName("OTP");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.PhoneUpdateStatus).HasMaxLength(20);
            entity.Property(e => e.PhoneUpdated).HasMaxLength(40);
            entity.Property(e => e.ReasonPhone).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.TimeSendOtp).HasColumnName("TimeSendOTP");
            entity.Property(e => e.UpdateType).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerPayBonu>(entity =>
        {
            entity.ToTable("socialretailer_PayBonus");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_PayBonus_TenantId");

            entity.Property(e => e.BonusAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BonusCoin).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BonusPoint).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Revenue).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<SocialretailerPosm>(entity =>
        {
            entity.ToTable("socialretailer_Posm");

            entity.HasIndex(e => e.MemberCode, "missing_index_46");

            entity.Property(e => e.CreatorName).HasMaxLength(64);
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.DetailCode).HasMaxLength(40);
            entity.Property(e => e.ImagePath).HasMaxLength(1024);
            entity.Property(e => e.LastModifierName).HasMaxLength(64);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.PosmresultId).HasColumnName("POSMResultID");
            entity.Property(e => e.Posmtype)
                .HasMaxLength(64)
                .HasColumnName("POSMType");
        });

        modelBuilder.Entity<SocialretailerPublisher>(entity =>
        {
            entity.ToTable("socialretailer_Publisher");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_Publisher_TenantId");

            entity.Property(e => e.Apilink)
                .HasMaxLength(2000)
                .HasColumnName("APILink");
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TokenKey).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerRequest>(entity =>
        {
            entity.ToTable("socialretailer_Request");

            entity.HasIndex(e => e.Unsign, "IX_socialretailer_Request_Unsign");

            entity.HasIndex(e => e.MemberCode, "missing_index_95");

            entity.Property(e => e.AssignerName).HasMaxLength(255);
            entity.Property(e => e.BeatPlanCode).HasMaxLength(40);
            entity.Property(e => e.CreatorName).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.LastModifierName).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(64);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.RejectMessage).HasMaxLength(500);
            entity.Property(e => e.RequestCode).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerRequestAssign>(entity =>
        {
            entity.ToTable("socialretailer_RequestAssign");

            entity.HasIndex(e => new { e.RequestId, e.UserId, e.Step }, "missing_index_1783");
        });

        modelBuilder.Entity<SocialretailerRequestAssignConfig>(entity =>
        {
            entity.ToTable("socialretailer_RequestAssignConfig");

            entity.Property(e => e.Assigner).HasMaxLength(255);
            entity.Property(e => e.CreatorName).HasMaxLength(255);
            entity.Property(e => e.LastModifierName).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(40);
        });

        modelBuilder.Entity<SocialretailerRequestComment>(entity =>
        {
            entity.ToTable("socialretailer_RequestComment");

            entity.Property(e => e.Content).HasMaxLength(512);
            entity.Property(e => e.CreatorName).HasMaxLength(255);
            entity.Property(e => e.FilePath).HasMaxLength(1024);
        });

        modelBuilder.Entity<SocialretailerRuleGenerator>(entity =>
        {
            entity.ToTable("socialretailer_RuleGenerator");
        });

        modelBuilder.Entity<SocialretailerSale>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("socialretailer_Sale");

            entity.HasIndex(e => new { e.CreationTime, e.Serial }, "IX_Sale_Serial_Filter");

            entity.HasIndex(e => e.CreationTime, "IX_Sale_partitioncol").IsClustered();

            entity.HasIndex(e => e.CreationTime, "IX_socialretailer_Sale_CreationTime");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_Sale_MemberCode");

            entity.HasIndex(e => new { e.CreationTime, e.PhoneNumber }, "IX_socialretailer_Sale_PhoneNumber");

            entity.HasIndex(e => e.ReferenceId, "IX_socialretailer_Sale_ReferenceId");

            entity.HasIndex(e => new { e.CreationTime, e.ReturnType }, "IX_socialretailer_Sale_ReturnType");

            entity.HasIndex(e => e.RollBackFrom, "IX_socialretailer_Sale_RollBackFrom");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_Sale_Serial");

            entity.HasIndex(e => new { e.CreationTime, e.SerialType }, "IX_socialretailer_Sale_SerialType");

            entity.HasIndex(e => e.Status, "IX_socialretailer_Sale_Status");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_Sale_TenantId");

            entity.HasIndex(e => new { e.CreationTime, e.SaleType }, "missing_index_372");

            entity.HasIndex(e => new { e.CreationTime, e.SaleType }, "missing_index_441");

            entity.HasIndex(e => new { e.CreationTime, e.IsDeleted, e.SaleType, e.SystemPoint }, "missing_index_62");

            entity.Property(e => e.CampaignCodes).HasMaxLength(512);
            entity.Property(e => e.CampaignNames).HasMaxLength(512);
            entity.Property(e => e.IsNameUnsign).HasColumnName("isNameUnsign");
            entity.Property(e => e.Lat).HasColumnName("LAT");
            entity.Property(e => e.Lng).HasColumnName("LNG");
            entity.Property(e => e.Model).HasMaxLength(450);
            entity.Property(e => e.PaymentNotes).HasMaxLength(512);
            entity.Property(e => e.PhoneNumberBk).HasColumnName("PhoneNumber_BK");
            entity.Property(e => e.ProductCode).HasMaxLength(450);
            entity.Property(e => e.ProductName).HasMaxLength(450);
            entity.Property(e => e.ReferenceId).HasMaxLength(64);
            entity.Property(e => e.ReturnType).HasMaxLength(40);
            entity.Property(e => e.Sapcode)
                .HasMaxLength(450)
                .HasColumnName("SAPCode");
            entity.Property(e => e.SyncSap).HasColumnName("SyncSAP");
            entity.Property(e => e.SystemCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SystemPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleNumber).HasMaxLength(450);
        });

        modelBuilder.Entity<SocialretailerSaleHistory>(entity =>
        {
            entity.ToTable("socialretailer_SaleHistory");

            entity.HasIndex(e => e.CreationTime, "IX_socialretailer_SaleHistory_CreationTime");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SaleHistory_Serial");

            entity.Property(e => e.MemberCode).HasMaxLength(450);
            entity.Property(e => e.ProductCode).HasMaxLength(450);
            entity.Property(e => e.ReferenceId).HasMaxLength(450);
            entity.Property(e => e.SaleType).HasMaxLength(450);
            entity.Property(e => e.VehicleNumber).HasMaxLength(450);
        });

        modelBuilder.Entity<SocialretailerSaleOrder>(entity =>
        {
            entity.ToTable("socialretailer_SaleOrder");

            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<SocialretailerSaleOrderDetail>(entity =>
        {
            entity.ToTable("socialretailer_SaleOrderDetail");

            entity.Property(e => e.DiscountDesc).HasColumnName("Discount_Desc");
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<SocialretailerSalesDataBaseline>(entity =>
        {
            entity.HasKey(e => e.Serial).HasName("PK__socialre__1A00E092951C2AFB");

            entity.ToTable("socialretailer_SalesDataBaseline");

            entity.Property(e => e.Serial).HasMaxLength(255);
            entity.Property(e => e.DeptName1).HasMaxLength(255);
            entity.Property(e => e.DeptName2).HasMaxLength(255);
            entity.Property(e => e.DeptName3).HasMaxLength(255);
            entity.Property(e => e.DistributorCode).HasMaxLength(255);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.DistributorPhoneNumber).HasMaxLength(255);
            entity.Property(e => e.DistributorProvinceCode).HasMaxLength(255);
            entity.Property(e => e.DistributorProvinceName).HasMaxLength(255);
            entity.Property(e => e.DistributorSellthruDate).HasColumnType("datetime");
            entity.Property(e => e.ExportDate).HasColumnType("datetime");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.MemberPhoneNumber).HasMaxLength(255);
            entity.Property(e => e.MemberProvinceCode).HasMaxLength(255);
            entity.Property(e => e.MemberProvinceName).HasMaxLength(255);
            entity.Property(e => e.PaymentName).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(255);
            entity.Property(e => e.SalesmanCode).HasMaxLength(255);
            entity.Property(e => e.SalesmanName).HasMaxLength(255);
            entity.Property(e => e.SalesmanPhoneNumber).HasMaxLength(255);
            entity.Property(e => e.SalesmanProvinceCode).HasMaxLength(255);
            entity.Property(e => e.SalesmanProvinceName).HasMaxLength(255);
            entity.Property(e => e.SellInDate).HasColumnType("datetime");
            entity.Property(e => e.SellOutDate).HasColumnType("datetime");
            entity.Property(e => e.VipShopCode).HasMaxLength(255);
            entity.Property(e => e.VipShopName).HasMaxLength(255);
            entity.Property(e => e.VipShopPhoneNumber).HasMaxLength(255);
            entity.Property(e => e.VipShopProvinceCode).HasMaxLength(255);
            entity.Property(e => e.VipShopProvinceName).HasMaxLength(255);
            entity.Property(e => e.VipShopSellthruDate).HasColumnType("datetime");
            entity.Property(e => e.WarrantyRegisterDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<SocialretailerSalesDatum>(entity =>
        {
            entity.ToTable("socialretailer_SalesData");

            entity.HasIndex(e => e.CreationTime, "IX_socialretailer_SalesData_CreationTime");

            entity.HasIndex(e => e.DeptCodeL6, "IX_socialretailer_SalesData_DeptCodeL6");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SalesData_Serial");

            entity.Property(e => e.CampaignCodes).HasMaxLength(512);
            entity.Property(e => e.CampaignNames).HasMaxLength(512);
            entity.Property(e => e.DeptCodeL1).HasMaxLength(450);
            entity.Property(e => e.DeptCodeL2).HasMaxLength(450);
            entity.Property(e => e.DeptCodeL3).HasMaxLength(450);
            entity.Property(e => e.DeptCodeL4).HasMaxLength(450);
            entity.Property(e => e.DeptCodeL5).HasMaxLength(450);
            entity.Property(e => e.DistributorCode).HasMaxLength(450);
            entity.Property(e => e.DistributorProvinceCode).HasMaxLength(450);
            entity.Property(e => e.DistrictName).HasMaxLength(450);
            entity.Property(e => e.Mbsmembercode)
                .HasMaxLength(20)
                .HasColumnName("MBSMembercode");
            entity.Property(e => e.Mbsphone)
                .HasMaxLength(20)
                .HasColumnName("MBSPhone");
            entity.Property(e => e.Mbsprovince)
                .HasMaxLength(20)
                .HasColumnName("MBSProvince");
            entity.Property(e => e.MbsprovinceName)
                .HasMaxLength(500)
                .HasColumnName("MBSProvinceName");
            entity.Property(e => e.MemberCode).HasMaxLength(450);
            entity.Property(e => e.MemberProvinceCode).HasMaxLength(450);
            entity.Property(e => e.Msbname)
                .HasMaxLength(500)
                .HasColumnName("MSBName");
            entity.Property(e => e.ProductCode).HasMaxLength(450);
            entity.Property(e => e.RetailerCode).HasMaxLength(450);
            entity.Property(e => e.SaleType).HasMaxLength(450);
            entity.Property(e => e.SalesmanCode).HasMaxLength(450);
            entity.Property(e => e.SalesmanProvinceCode).HasMaxLength(450);
            entity.Property(e => e.SellInCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SellOutCoin).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SellOutPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WardCode).HasMaxLength(450);
        });

        modelBuilder.Entity<SocialretailerSalesman>(entity =>
        {
            entity.ToTable("socialretailer_Salesman");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_Salesman_TenantId");

            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.MasterNameUnSign).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Password).HasMaxLength(32);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.SalesmanName).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerSapproduct>(entity =>
        {
            entity.ToTable("socialretailer_SAPProduct");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SAPProduct_TenantId");
        });

        modelBuilder.Entity<SocialretailerSapserial>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.ToTable("socialretailer_SAPSerial", tb =>
                {
                    tb.HasTrigger("trigger_test_createSellIn");
                    tb.HasTrigger("trigger_test_isMt");
                });

            entity.HasIndex(e => e.CreationTime, "IX_SAPSerial_partitioncol").IsClustered();

            entity.HasIndex(e => e.ItemCode, "IX_socialretailer_SAPSerial_ItemCode");

            entity.HasIndex(e => new { e.CreationTime, e.ReturnType }, "IX_socialretailer_SAPSerial_ReturnType");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SAPSerial_Serial");

            entity.HasIndex(e => new { e.SerialType, e.RegionLevel1 }, "IX_socialretailer_SAPSerial_SerialType_RegionLevel1");

            entity.HasIndex(e => new { e.CreationTime, e.Year }, "missing_index_79");

            entity.Property(e => e.IsMt).HasColumnName("IsMT");
            entity.Property(e => e.IsSellInStatus).HasMaxLength(1);
            entity.Property(e => e.IsSellOutStatus).HasMaxLength(1);
            entity.Property(e => e.IsVssellThru).HasColumnName("IsVSSellThru");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.RegionLevel1).HasMaxLength(255);
            entity.Property(e => e.ReturnType).HasMaxLength(40);
            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<SocialretailerSapserialBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_SAPSerial_BK");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsMt).HasColumnName("IsMT");
            entity.Property(e => e.IsSellInStatus).HasMaxLength(1);
            entity.Property(e => e.IsSellOutStatus).HasMaxLength(1);
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.RegionLevel1).HasMaxLength(255);
            entity.Property(e => e.ReturnType).HasMaxLength(40);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.SerialType).HasMaxLength(450);
        });

        modelBuilder.Entity<SocialretailerSerialOutSap>(entity =>
        {
            entity.ToTable("socialretailer_SerialOutSAP");

            entity.HasIndex(e => e.ProductCode, "IX_socialretailer_SerialOutSAP_ProductCode");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SerialOutSAP_Serial");

            entity.HasIndex(e => e.SerialType, "IX_socialretailer_SerialOutSAP_SerialType");

            entity.HasIndex(e => e.Year, "IX_socialretailer_SerialOutSAP_Year");

            entity.HasIndex(e => e.IsScanOut, "missing_index_280");

            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<SocialretailerSerialOutSaphistory>(entity =>
        {
            entity.ToTable("socialretailer_SerialOutSAPHistory");

            entity.HasIndex(e => e.CreationTime, "IX_socialretailer_SerialOutSAPHistory_CreationTime");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SerialOutSAPHistory_Serial");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SerialOutSAPHistory_TenantId");

            entity.Property(e => e.Serial).HasMaxLength(100);
        });

        modelBuilder.Entity<SocialretailerSerialProducer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_SerialProducer");

            entity.HasIndex(e => e.MonthYear, "IX_socialretailer_SerialProducer_MonthYear");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MassOrderPo).HasColumnName("MassOrderPO");
            entity.Property(e => e.Serial).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerSerialProducer2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socialretailer_SerialProducer2");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SerialProducer_Serial");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MassOrderPo).HasColumnName("MassOrderPO");
            entity.Property(e => e.Serial).HasMaxLength(64);
        });

        modelBuilder.Entity<SocialretailerSerialProducerScanLog>(entity =>
        {
            entity.ToTable("socialretailer_SerialProducerScanLog");

            entity.HasIndex(e => e.ActivationCode, "IX_socialretailer_SerialProducerScanLog_ActivationCode");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SerialProducerScanLog_Serial");
        });

        modelBuilder.Entity<SocialretailerSerialTypeChangeHistory>(entity =>
        {
            entity.ToTable("socialretailer_SerialTypeChangeHistory");

            entity.HasIndex(e => e.Serial, "IX_socialretailer_SerialTypeChangeHistory_Serial");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SerialTypeChangeHistory_TenantId");

            entity.Property(e => e.CreatorName).HasMaxLength(255);
            entity.Property(e => e.DocNum).HasMaxLength(255);
            entity.Property(e => e.Plant).HasMaxLength(40);
            entity.Property(e => e.ProductCode).HasMaxLength(450);
            entity.Property(e => e.ReferFrom).HasMaxLength(255);
            entity.Property(e => e.SerialType).HasMaxLength(450);
        });

        modelBuilder.Entity<SocialretailerSocialMessage>(entity =>
        {
            entity.ToTable("socialretailer_SocialMessage");

            entity.HasIndex(e => e.Id, "IX_socialretailer_SocialMessage_Id");

            entity.HasIndex(e => e.RetailerCode, "IX_socialretailer_SocialMessage_RetailerCode");

            entity.HasIndex(e => e.Status, "IX_socialretailer_SocialMessage_Status");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SocialMessage_TenantId");

            entity.Property(e => e.Content).HasMaxLength(2000);
            entity.Property(e => e.FromUserId)
                .HasMaxLength(255)
                .HasColumnName("FromUserID");
            entity.Property(e => e.MessageType).HasMaxLength(20);
            entity.Property(e => e.RetailerCode).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SocialretailerSurvey>(entity =>
        {
            entity.ToTable("socialretailer_Survey");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_Survey_TenantId");
        });

        modelBuilder.Entity<SocialretailerSurveyQuestion>(entity =>
        {
            entity.ToTable("socialretailer_SurveyQuestion");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SurveyQuestion_TenantId");
        });

        modelBuilder.Entity<SocialretailerSurveyResult>(entity =>
        {
            entity.ToTable("socialretailer_SurveyResult");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SurveyResult_TenantId");
        });

        modelBuilder.Entity<SocialretailerSurveyResultDetail>(entity =>
        {
            entity.ToTable("socialretailer_SurveyResultDetail");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_SurveyResultDetail_TenantId");
        });

        modelBuilder.Entity<SocialretailerUpdateProfileRequestHistory>(entity =>
        {
            entity.ToTable("socialretailer_UpdateProfileRequestHistory");

            entity.HasIndex(e => e.MemberCode, "IX_socialretailer_UpdateProfileRequestHistory_MemberCode");

            entity.Property(e => e.AccountCode).HasMaxLength(40);
            entity.Property(e => e.AccumulationPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellIn).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccumulationPointSellOut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.BankAccountNumber).HasMaxLength(40);
            entity.Property(e => e.BankBranchName).HasMaxLength(255);
            entity.Property(e => e.BankName).HasMaxLength(255);
            entity.Property(e => e.Bonus).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BossName).HasMaxLength(255);
            entity.Property(e => e.BrowserCode).HasMaxLength(40);
            entity.Property(e => e.BusinessType).HasMaxLength(255);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(15, 3)");
            entity.Property(e => e.CustomerCode).HasMaxLength(40);
            entity.Property(e => e.DeptCode).HasMaxLength(200);
            entity.Property(e => e.DeviceNameCode).HasMaxLength(40);
            entity.Property(e => e.DistributorCode).HasMaxLength(40);
            entity.Property(e => e.DistributorName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.ExpiringCoin).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.IdentificationCardBackImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardFrontImage).HasMaxLength(225);
            entity.Property(e => e.IdentificationCardNumber).HasMaxLength(40);
            entity.Property(e => e.InterestOf).HasMaxLength(255);
            entity.Property(e => e.IsInterestCobrand).HasColumnName("isInterestCobrand");
            entity.Property(e => e.Lat)
                .HasMaxLength(40)
                .HasColumnName("LAT");
            entity.Property(e => e.LegalPersonal).HasMaxLength(100);
            entity.Property(e => e.LegalPersonalName).HasMaxLength(100);
            entity.Property(e => e.Lng)
                .HasMaxLength(40)
                .HasColumnName("LNG");
            entity.Property(e => e.LockUpdateChatId).HasColumnName("LockUpdateChatID");
            entity.Property(e => e.LockedType).HasMaxLength(4);
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MissingRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.Note1).HasMaxLength(255);
            entity.Property(e => e.Note2).HasMaxLength(255);
            entity.Property(e => e.Note3).HasMaxLength(255);
            entity.Property(e => e.Note4).HasMaxLength(255);
            entity.Property(e => e.Note5).HasMaxLength(255);
            entity.Property(e => e.OccupationCode).HasMaxLength(40);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.OutletType).HasMaxLength(40);
            entity.Property(e => e.Password).HasMaxLength(32);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pid)
                .HasMaxLength(20)
                .HasColumnName("PID");
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.PointToKeepRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.PointToNextRank).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.ReferralCode).HasMaxLength(40);
            entity.Property(e => e.RegionCode).HasMaxLength(255);
            entity.Property(e => e.RequestCode).HasMaxLength(64);
            entity.Property(e => e.SalesChannel).HasMaxLength(40);
            entity.Property(e => e.SalesmanCode).HasMaxLength(40);
            entity.Property(e => e.Sapcode)
                .HasMaxLength(40)
                .HasColumnName("SAPCode");
            entity.Property(e => e.SourceId)
                .HasMaxLength(20)
                .HasColumnName("SourceID");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.StoreType).HasMaxLength(30);
            entity.Property(e => e.SupervisorCode).HasMaxLength(40);
            entity.Property(e => e.SupervisorName).HasMaxLength(255);
            entity.Property(e => e.TargetRevenue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxCode).HasMaxLength(40);
            entity.Property(e => e.TypeOfDeviceCode).HasMaxLength(40);
            entity.Property(e => e.Ward).HasMaxLength(50);
            entity.Property(e => e.WarehouseAddress).HasMaxLength(255);
            entity.Property(e => e.ZaloName).HasMaxLength(255);
        });

        modelBuilder.Entity<SocialretailerUserImporting>(entity =>
        {
            entity.ToTable("socialretailer_UserImporting");

            entity.HasIndex(e => e.UserId, "IX_socialretailer_UserImporting_UserId");
        });

        modelBuilder.Entity<SocialretailerVisitPlanDetail>(entity =>
        {
            entity.ToTable("socialretailer_VisitPlanDetail");

            entity.HasIndex(e => e.CustCd, "IX_socialretailer_VisitPlanDetail_CUST_CD");

            entity.HasIndex(e => e.CycleCd, "IX_socialretailer_VisitPlanDetail_CYCLE_CD");

            entity.HasIndex(e => e.SlsmanCd, "IX_socialretailer_VisitPlanDetail_SLSMAN_CD");

            entity.HasIndex(e => e.TenantId, "IX_socialretailer_VisitPlanDetail_TenantId");

            entity.HasIndex(e => e.VisitDt, "IX_socialretailer_VisitPlanDetail_VISIT_DT");

            entity.Property(e => e.ActualSeq).HasColumnName("ACTUAL_SEQ");
            entity.Property(e => e.CustCd)
                .HasMaxLength(50)
                .HasColumnName("CUST_CD");
            entity.Property(e => e.CycleCd)
                .HasMaxLength(50)
                .HasColumnName("CYCLE_CD");
            entity.Property(e => e.DistCd)
                .HasMaxLength(50)
                .HasColumnName("DIST_CD");
            entity.Property(e => e.DuplicateInd)
                .HasMaxLength(10)
                .HasColumnName("DUPLICATE_IND");
            entity.Property(e => e.RouteCustSeq).HasColumnName("ROUTE_CUST_SEQ");
            entity.Property(e => e.RsInd)
                .HasMaxLength(10)
                .HasColumnName("RS_IND");
            entity.Property(e => e.SlsmanCd)
                .HasMaxLength(50)
                .HasColumnName("SLSMAN_CD");
            entity.Property(e => e.SvrUpldwDt).HasColumnName("SVR_UPLDW_DT");
            entity.Property(e => e.Syncflag)
                .HasMaxLength(10)
                .HasColumnName("SYNCFLAG");
            entity.Property(e => e.Syncoperation)
                .HasMaxLength(10)
                .HasColumnName("SYNCOPERATION");
            entity.Property(e => e.Syncversion).HasColumnName("SYNCVERSION");
            entity.Property(e => e.UpldwStatus)
                .HasMaxLength(10)
                .HasColumnName("UPLDW_STATUS");
            entity.Property(e => e.Version).HasColumnName("VERSION");
            entity.Property(e => e.VisitDt).HasColumnName("VISIT_DT");
            entity.Property(e => e.VisitWeek).HasColumnName("VISIT_WEEK");
        });

        modelBuilder.Entity<SocialshopperShopperInfo>(entity =>
        {
            entity.ToTable("socialshopper_ShopperInfo");

            entity.HasIndex(e => e.TenantId, "IX_socialshopper_ShopperInfo_TenantId");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(2000);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CurrentPoint).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.MemberCard).HasMaxLength(40);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NameUnSign).HasMaxLength(255);
            entity.Property(e => e.NationalityCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.Pid)
                .HasMaxLength(20)
                .HasColumnName("PID");
            entity.Property(e => e.Pincode)
                .HasMaxLength(200)
                .HasColumnName("PINCode");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RankCode).HasMaxLength(40);
            entity.Property(e => e.RankPropose).HasMaxLength(40);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.Ward).HasMaxLength(50);
        });

        modelBuilder.Entity<SocialshopperSubmittedSo>(entity =>
        {
            entity.ToTable("socialshopper_SubmittedSO");

            entity.HasIndex(e => e.TenantId, "IX_socialshopper_SubmittedSO_TenantId");

            entity.Property(e => e.ChatId)
                .HasMaxLength(40)
                .HasColumnName("ChatID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Socode)
                .HasMaxLength(40)
                .HasColumnName("SOCode");
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TopupAmount).HasColumnType("decimal(12, 3)");
        });

        modelBuilder.Entity<SocialshopperUploadedInvoice>(entity =>
        {
            entity.ToTable("socialshopper_UploadedInvoice");

            entity.HasIndex(e => e.TenantId, "IX_socialshopper_UploadedInvoice_TenantId");

            entity.Property(e => e.ChatId)
                .HasMaxLength(40)
                .HasColumnName("ChatID");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.ImageThumbnailLink).HasMaxLength(2000);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Ocrdata).HasColumnName("OCRData");
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(40)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<SpparasLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SPParasLog");

            entity.Property(e => e.CreatedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("created_date_time");
            entity.Property(e => e.ParameterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("parameter_id");
            entity.Property(e => e.StoreProcedureName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("store_procedure_name");
            entity.Property(e => e.StoreProcedureParameterLog).HasColumnName("store_procedure_parameter_log");
        });

        modelBuilder.Entity<SurveysSurveyAnswer>(entity =>
        {
            entity.ToTable("surveys_SurveyAnswer");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyAnswer_TenantId");

            entity.Property(e => e.AnswerCode).HasMaxLength(40);
            entity.Property(e => e.ContentEn)
                .HasMaxLength(1000)
                .HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn)
                .HasMaxLength(1000)
                .HasColumnName("ContentVN");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.SurveyCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SurveysSurveyInfo>(entity =>
        {
            entity.ToTable("surveys_SurveyInfo");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyInfo_TenantId");

            entity.Property(e => e.Channel).HasMaxLength(20);
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Cron).HasMaxLength(20);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionEN");
            entity.Property(e => e.DescriptionVn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionVN");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OccurType).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
        });

        modelBuilder.Entity<SurveysSurveyQuestion>(entity =>
        {
            entity.ToTable("surveys_SurveyQuestion");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyQuestion_TenantId");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.ContentEn)
                .HasMaxLength(4000)
                .HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn)
                .HasMaxLength(4000)
                .HasColumnName("ContentVN");
            entity.Property(e => e.ImageFullLink)
                .HasMaxLength(4000)
                .HasColumnName("Image_Full_Link");
            entity.Property(e => e.ImageHaftLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageHaft_Link");
            entity.Property(e => e.ImageNoneLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageNone_Link");
            entity.Property(e => e.QuestionType).HasMaxLength(20);
            entity.Property(e => e.SurveyCode).HasMaxLength(40);
        });

        modelBuilder.Entity<SurveysSurveyResponse>(entity =>
        {
            entity.ToTable("surveys_SurveyResponse");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyResponse_TenantId");

            entity.Property(e => e.AnswerCode).HasMaxLength(40);
            entity.Property(e => e.AnswerContent).HasMaxLength(1000);
            entity.Property(e => e.Channel).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MessageID");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.QuestionContent).HasMaxLength(4000);
            entity.Property(e => e.QuestionType).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.SurveyCode).HasMaxLength(40);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<SurveysSurveyTargetAudience>(entity =>
        {
            entity.ToTable("surveys_SurveyTargetAudience");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyTargetAudience_TenantId");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<SurveysSurveyTargetAudienceDetail>(entity =>
        {
            entity.ToTable("surveys_SurveyTargetAudienceDetail");

            entity.HasIndex(e => e.TenantId, "IX_surveys_SurveyTargetAudienceDetail_TenantId");

            entity.Property(e => e.CommunicationChannel).HasMaxLength(4000);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.SurveyTargetAudienceId).HasColumnName("SurveyTargetAudienceID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<TaskAnswer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaskAnswer");

            entity.Property(e => e.AnswerCode).HasMaxLength(40);
            entity.Property(e => e.ContentEn)
                .HasMaxLength(1000)
                .HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn)
                .HasMaxLength(1000)
                .HasColumnName("ContentVN");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.TaskCode).HasMaxLength(40);
        });

        modelBuilder.Entity<TaskInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaskInfo");

            entity.Property(e => e.Channel).HasMaxLength(20);
            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.Cron).HasMaxLength(20);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionEN");
            entity.Property(e => e.DescriptionVn)
                .HasMaxLength(1000)
                .HasColumnName("DescriptionVN");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OccurType).HasMaxLength(10);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceId).HasColumnName("TargetAudienceID");
            entity.Property(e => e.TargetAudienceType).HasMaxLength(20);
        });

        modelBuilder.Entity<TaskQuestion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaskQuestion");

            entity.Property(e => e.Code).HasMaxLength(40);
            entity.Property(e => e.ContentEn)
                .HasMaxLength(4000)
                .HasColumnName("ContentEN");
            entity.Property(e => e.ContentVn)
                .HasMaxLength(4000)
                .HasColumnName("ContentVN");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImageFullLink)
                .HasMaxLength(4000)
                .HasColumnName("Image_Full_Link");
            entity.Property(e => e.ImageHaftLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageHaft_Link");
            entity.Property(e => e.ImageNoneLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageNone_Link");
            entity.Property(e => e.QuestionType).HasMaxLength(20);
            entity.Property(e => e.TaskCode).HasMaxLength(40);
        });

        modelBuilder.Entity<TaskResult>(entity =>
        {
            entity.ToTable("TaskResult");

            entity.Property(e => e.AnswerCode).HasMaxLength(40);
            entity.Property(e => e.AnswerContent).HasMaxLength(1000);
            entity.Property(e => e.Channel).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.ImageLink).HasMaxLength(2000);
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.MemberName).HasMaxLength(255);
            entity.Property(e => e.MessageId)
                .HasMaxLength(50)
                .HasColumnName("MessageID");
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.QuestionContent).HasMaxLength(4000);
            entity.Property(e => e.QuestionType).HasMaxLength(20);
            entity.Property(e => e.Subject).HasMaxLength(255);
            entity.Property(e => e.TaskCode).HasMaxLength(40);
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<TaskResultDetail>(entity =>
        {
            entity.ToTable("TaskResultDetail");

            entity.HasIndex(e => e.TaskResultId, "missing_index_35");

            entity.Property(e => e.AnswerCode).HasMaxLength(40);
            entity.Property(e => e.AnswerContent).HasMaxLength(4000);
            entity.Property(e => e.ImageFullLink)
                .HasMaxLength(4000)
                .HasColumnName("Image_Full_Link");
            entity.Property(e => e.ImageHaftLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageHaft_Link");
            entity.Property(e => e.ImageNoneLink)
                .HasMaxLength(4000)
                .HasColumnName("ImageNone_Link");
            entity.Property(e => e.QuestionCode).HasMaxLength(40);
            entity.Property(e => e.QuestionContent).HasMaxLength(4000);
            entity.Property(e => e.QuestionType).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(1000);
            entity.Property(e => e.ResultContent).HasMaxLength(4000);
            entity.Property(e => e.Status).HasMaxLength(40);
        });

        modelBuilder.Entity<TaskTargetaudience>(entity =>
        {
            entity.ToTable("TaskTargetaudience");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.TargetAudienceName).HasMaxLength(255);
        });

        modelBuilder.Entity<TaskTargetaudienceDetail>(entity =>
        {
            entity.ToTable("TaskTargetaudienceDetail");

            entity.Property(e => e.CommunicationChannel).HasMaxLength(4000);
            entity.Property(e => e.CommunicationLanguage).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(40)
                .HasColumnName("FacebookID");
            entity.Property(e => e.MemberCode).HasMaxLength(40);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.OutletCode).HasMaxLength(40);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.TaskTargetAudienceId).HasColumnName("TaskTargetAudienceID");
            entity.Property(e => e.ZaloChatId)
                .HasMaxLength(20)
                .HasColumnName("ZaloChatID");
        });

        modelBuilder.Entity<TblBaslineSalesByCurrentYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_Basline_Sales_byCurrentYear");

            entity.Property(e => e.Coin).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.DepartmentLevel1).HasMaxLength(255);
            entity.Property(e => e.MemberCode).HasMaxLength(450);
            entity.Property(e => e.Point).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SaleType).HasMaxLength(450);
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasIndex(e => e.CreationTime, "IX_Tenants_CreationTime");

            entity.HasIndex(e => e.CreatorUserId, "IX_Tenants_CreatorUserId");

            entity.HasIndex(e => e.DeleterUserId, "IX_Tenants_DeleterUserId");

            entity.HasIndex(e => e.EditionId, "IX_Tenants_EditionId");

            entity.HasIndex(e => e.LastModifierUserId, "IX_Tenants_LastModifierUserId");

            entity.HasIndex(e => e.SubscriptionEndDateUtc, "IX_Tenants_SubscriptionEndDateUtc");

            entity.HasIndex(e => e.TenancyName, "IX_Tenants_TenancyName");

            entity.Property(e => e.ConnectionString).HasMaxLength(1024);
            entity.Property(e => e.LogoFileType).HasMaxLength(64);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.TenancyName).HasMaxLength(64);

            entity.HasOne(d => d.CreatorUser).WithMany(p => p.TenantCreatorUsers).HasForeignKey(d => d.CreatorUserId);

            entity.HasOne(d => d.DeleterUser).WithMany(p => p.TenantDeleterUsers).HasForeignKey(d => d.DeleterUserId);

            entity.HasOne(d => d.Edition).WithMany(p => p.Tenants).HasForeignKey(d => d.EditionId);

            entity.HasOne(d => d.LastModifierUser).WithMany(p => p.TenantLastModifierUsers).HasForeignKey(d => d.LastModifierUserId);
        });

        modelBuilder.Entity<TenantNotification>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataTypeName).HasMaxLength(512);
            entity.Property(e => e.EntityId).HasMaxLength(96);
            entity.Property(e => e.EntityTypeAssemblyQualifiedName).HasMaxLength(512);
            entity.Property(e => e.EntityTypeName).HasMaxLength(250);
            entity.Property(e => e.NotificationName).HasMaxLength(96);
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("test");

            entity.Property(e => e.Test1).HasColumnName("test");
        });

        modelBuilder.Entity<TmpActivecode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmp_activecode");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tmpdi022022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpdi022022");

            entity.Property(e => e.Mgs).HasColumnName("mgs");
            entity.Property(e => e.Mien).HasMaxLength(255);
            entity.Property(e => e.MãNpp)
                .HasMaxLength(255)
                .HasColumnName("Mã NPP");
            entity.Property(e => e.NgàyXuấtKho)
                .HasMaxLength(255)
                .HasColumnName("Ngày xuất kho");
            entity.Property(e => e.Serial).HasMaxLength(255);
            entity.Property(e => e.Stt)
                .HasMaxLength(255)
                .HasColumnName("STT");
            entity.Property(e => e.SốDo)
                .HasMaxLength(255)
                .HasColumnName("Số DO");
            entity.Property(e => e.SốXe)
                .HasMaxLength(255)
                .HasColumnName("Số XE");
        });

        modelBuilder.Entity<Tmpdis02202202>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpdis02202202");

            entity.Property(e => e.Mgs).HasColumnName("mgs");
            entity.Property(e => e.MãNpp)
                .HasMaxLength(255)
                .HasColumnName("Mã NPP");
            entity.Property(e => e.NgàyXuấtKho)
                .HasMaxLength(255)
                .HasColumnName("Ngày xuất kho");
            entity.Property(e => e.Serial).HasMaxLength(255);
            entity.Property(e => e.Stt)
                .HasMaxLength(255)
                .HasColumnName("STT");
            entity.Property(e => e.SốDo)
                .HasMaxLength(255)
                .HasColumnName("Số DO");
            entity.Property(e => e.SốXe)
                .HasMaxLength(255)
                .HasColumnName("Số XE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.DeleterUserId, "IX_Users_DeleterUserId");

            entity.HasIndex(e => new { e.UserName, e.TenantId }, "missing_index_29");

            entity.HasIndex(e => e.NormalizedUserName, "missing_index_55");

            entity.HasIndex(e => e.NormalizedEmailAddress, "missing_index_57");

            entity.HasIndex(e => e.PhoneNumber, "missing_index_75");

            entity.Property(e => e.AuthenticationSource).HasMaxLength(64);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);
            entity.Property(e => e.EmailAddress).HasMaxLength(256);
            entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NormalizedEmailAddress).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordResetCode).HasMaxLength(328);
            entity.Property(e => e.PhoneNumber).HasMaxLength(32);
            entity.Property(e => e.SecurityStamp).HasMaxLength(128);
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.DeleterUser).WithMany(p => p.InverseDeleterUser).HasForeignKey(d => d.DeleterUserId);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasIndex(e => e.EmailAddress, "IX_UserAccounts_EmailAddress");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_UserAccounts_TenantId_UserId");

            entity.HasIndex(e => e.UserName, "IX_UserAccounts_UserName");

            entity.Property(e => e.EmailAddress).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.ClaimType }, "IX_UserClaims_TenantId_ClaimType");

            entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

            entity.Property(e => e.ClaimType).HasMaxLength(256);

            entity.HasOne(d => d.User).WithMany(p => p.UserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.LoginProvider, e.ProviderKey }, "IX_UserLogins_TenantId_LoginProvider_ProviderKey");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_UserLogins_TenantId_UserId");

            entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(256);

            entity.HasOne(d => d.User).WithMany(p => p.UserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserLoginAttempt>(entity =>
        {
            entity.HasIndex(e => new { e.TenancyName, e.UserNameOrEmailAddress, e.Result }, "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            entity.HasIndex(e => new { e.UserId, e.TenantId }, "IX_UserLoginAttempts_UserId_TenantId");

            entity.Property(e => e.BrowserInfo).HasMaxLength(512);
            entity.Property(e => e.ClientIpAddress).HasMaxLength(64);
            entity.Property(e => e.ClientName).HasMaxLength(128);
            entity.Property(e => e.TenancyName).HasMaxLength(64);
            entity.Property(e => e.UserNameOrEmailAddress).HasMaxLength(255);
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.State, e.CreationTime }, "IX_UserNotifications_UserId_State_CreationTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserOrganizationUnit>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.OrganizationUnitId }, "IX_UserOrganizationUnits_TenantId_OrganizationUnitId");

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_UserOrganizationUnits_TenantId_UserId");

            entity.HasIndex(e => e.UserId, "missing_index_106");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_UserRoles_UserId");

            entity.HasIndex(e => e.RoleId, "missing_index_67");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasIndex(e => new { e.TenantId, e.UserId }, "IX_UserTokens_TenantId_UserId");

            entity.HasIndex(e => e.UserId, "IX_UserTokens_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(512);

            entity.HasOne(d => d.User).WithMany(p => p.UserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Users000290>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Users_000290");

            entity.Property(e => e.AuthenticationSource).HasMaxLength(64);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);
            entity.Property(e => e.EmailAddress).HasMaxLength(256);
            entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NormalizedEmailAddress).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordResetCode).HasMaxLength(328);
            entity.Property(e => e.PhoneNumber).HasMaxLength(32);
            entity.Property(e => e.SecurityStamp).HasMaxLength(128);
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<UsersArch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Users_arch");

            entity.Property(e => e.AuthenticationSource).HasMaxLength(64);
            entity.Property(e => e.ConcurrencyStamp).HasMaxLength(128);
            entity.Property(e => e.EmailAddress).HasMaxLength(256);
            entity.Property(e => e.EmailConfirmationCode).HasMaxLength(328);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.NormalizedEmailAddress).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordResetCode).HasMaxLength(328);
            entity.Property(e => e.PhoneNumber).HasMaxLength(32);
            entity.Property(e => e.SecurityStamp).HasMaxLength(128);
            entity.Property(e => e.Surname).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ward");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.AreaCode).HasMaxLength(40);
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.DistrictCode).HasMaxLength(40);
            entity.Property(e => e.Province).HasMaxLength(255);
            entity.Property(e => e.ProvinceCode).HasMaxLength(40);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.RegionCode).HasMaxLength(40);
            entity.Property(e => e.Ward1)
                .HasMaxLength(255)
                .HasColumnName("Ward");
            entity.Property(e => e.WardCode).HasMaxLength(40);
        });

        modelBuilder.Entity<WebHookNotificationInfo>(entity =>
        {
            entity.ToTable("WebHookNotificationInfo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DataTypeName).HasMaxLength(512);
            entity.Property(e => e.EventName).HasMaxLength(200);
            entity.Property(e => e.WebHookUri).HasMaxLength(1000);
        });

        modelBuilder.Entity<WebHookSubscriptionInfo>(entity =>
        {
            entity.ToTable("WebHookSubscriptionInfo");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Secret).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(10);
            entity.Property(e => e.WebHookUri).HasMaxLength(1000);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
