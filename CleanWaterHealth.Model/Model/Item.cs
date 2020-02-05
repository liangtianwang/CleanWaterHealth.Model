using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("item")]
    public partial class Item
    {
        [Key]
        [Column("item_code")]
        [StringLength(16)]
        public string ItemCode { get; set; }
        [Column("division_code_rd")]
        [StringLength(12)]
        public string DivisionCodeRd { get; set; }
        [Column("department_code_rd")]
        [StringLength(12)]
        public string DepartmentCodeRd { get; set; }
        [Column("category_code")]
        [StringLength(12)]
        public string CategoryCode { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("extended_description")]
        [StringLength(255)]
        public string ExtendedDescription { get; set; }
        [Column("short_description")]
        [StringLength(16)]
        public string ShortDescription { get; set; }
        [Column("pos_description")]
        [StringLength(16)]
        public string PosDescription { get; set; }
        [Column("notes_nar")]
        [StringLength(255)]
        public string NotesNar { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("prepack_available_ind")]
        [StringLength(1)]
        public string PrepackAvailableInd { get; set; }
        [Column("status_ind")]
        [StringLength(1)]
        public string StatusInd { get; set; }
        [Column("brand_code")]
        [StringLength(12)]
        public string BrandCode { get; set; }
        [Column("seasonal_ind")]
        [StringLength(1)]
        public string SeasonalInd { get; set; }
        [Column("season_code")]
        [StringLength(12)]
        public string SeasonCode { get; set; }
        [Column("season_tradeyear_code")]
        [StringLength(12)]
        public string SeasonTradeyearCode { get; set; }
        [Column("start_month_code")]
        [StringLength(12)]
        public string StartMonthCode { get; set; }
        [Column("end_month_code")]
        [StringLength(12)]
        public string EndMonthCode { get; set; }
        [Column("primary_supplier_code")]
        [StringLength(12)]
        public string PrimarySupplierCode { get; set; }
        [Column("colour_size_ind")]
        [StringLength(1)]
        public string ColourSizeInd { get; set; }
        [Column("item_type_ind")]
        [StringLength(1)]
        public string ItemTypeInd { get; set; }
        [Column("allow_fraction_ind")]
        [StringLength(1)]
        public string AllowFractionInd { get; set; }
        [Column("bom_status_ind")]
        [StringLength(1)]
        public string BomStatusInd { get; set; }
        [Column("pos_send_date", TypeName = "datetime")]
        public DateTime? PosSendDate { get; set; }
        [Column("pos_remove_date", TypeName = "datetime")]
        public DateTime? PosRemoveDate { get; set; }
        [Column("core_one_off_ind")]
        [StringLength(1)]
        public string CoreOneOffInd { get; set; }
        [Column("insert_user")]
        [StringLength(32)]
        public string InsertUser { get; set; }
        [Column("insert_date_time", TypeName = "datetime")]
        public DateTime? InsertDateTime { get; set; }
        [Column("update_user")]
        [StringLength(32)]
        public string UpdateUser { get; set; }
        [Column("update_date_time", TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [Column("itemtype_ind")]
        [StringLength(1)]
        public string ItemtypeInd1 { get; set; }
        [Column("sellable_ind")]
        [StringLength(1)]
        public string SellableInd { get; set; }
        [Column("slstaxcat_code")]
        [StringLength(12)]
        public string SlstaxcatCode { get; set; }
        [Column("dutyclass_code")]
        [StringLength(12)]
        public string DutyclassCode { get; set; }
        [Column("sell_uom_code")]
        [StringLength(12)]
        public string SellUomCode { get; set; }
        [Column("purch_uom_code")]
        [StringLength(12)]
        public string PurchUomCode { get; set; }
        [Column("items_per_sell_unit", TypeName = "numeric(20, 4)")]
        public decimal? ItemsPerSellUnit { get; set; }
        [Column("sell_units_per_purch_unit", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerPurchUnit { get; set; }
        [Column("sell_units_per_layer", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerLayer { get; set; }
        [Column("sell_units_per_pallet", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerPallet { get; set; }
        [Column("avg_unit_weight_kg", TypeName = "numeric(20, 4)")]
        public decimal? AvgUnitWeightKg { get; set; }
        [Column("sell_units_per_prc_quote", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerPrcQuote { get; set; }
        [Column("itemglgroup_code")]
        [StringLength(12)]
        public string ItemglgroupCode { get; set; }
        [Column("ticket_print_usage_code")]
        [StringLength(16)]
        public string TicketPrintUsageCode { get; set; }
        [Column("printstyle_code")]
        [StringLength(12)]
        public string PrintstyleCode { get; set; }
        [Column("scale_ind")]
        [StringLength(1)]
        public string ScaleInd { get; set; }
        [Column("price_prompt_ind")]
        [StringLength(1)]
        public string PricePromptInd { get; set; }
        [Column("ro_forecast_ratio", TypeName = "numeric(10, 4)")]
        public decimal? RoForecastRatio { get; set; }
        [Column("ro_forecast_ratio_ind")]
        [StringLength(1)]
        public string RoForecastRatioInd { get; set; }
        [Column("ro_forecast_ratio_expiry", TypeName = "datetime")]
        public DateTime? RoForecastRatioExpiry { get; set; }
        [Column("sizeprofile_code")]
        [StringLength(12)]
        public string SizeprofileCode { get; set; }
        [Column("ticketed_at_source_ind")]
        [StringLength(1)]
        public string TicketedAtSourceInd { get; set; }
        [Column("manufacturer_code")]
        [StringLength(24)]
        public string ManufacturerCode { get; set; }
        [Column("published_work_ind")]
        [StringLength(1)]
        public string PublishedWorkInd { get; set; }
        [Column("language_code")]
        [StringLength(12)]
        public string LanguageCode { get; set; }
        [Column("release_date", TypeName = "datetime")]
        public DateTime? ReleaseDate { get; set; }
        [Column("coupon_ind")]
        [StringLength(1)]
        public string CouponInd { get; set; }
        [Column("sundry_item_ind")]
        [StringLength(1)]
        public string SundryItemInd { get; set; }
        [Column("external_benefit_ind")]
        [StringLength(1)]
        public string ExternalBenefitInd { get; set; }
        [Column("creation_method_ind")]
        [StringLength(1)]
        public string CreationMethodInd { get; set; }
        [Column("prescription_ind")]
        [StringLength(1)]
        public string PrescriptionInd { get; set; }
        [Column("itemtype_code")]
        [StringLength(12)]
        public string ItemtypeCode { get; set; }
        [Column("infocapture_code")]
        [StringLength(12)]
        public string InfocaptureCode { get; set; }
        [Column("hscode_code")]
        [StringLength(10)]
        public string HscodeCode { get; set; }
        [Column("suppress_size_ind")]
        [StringLength(1)]
        public string SuppressSizeInd { get; set; }
        [Column("specialstorage_code")]
        [StringLength(12)]
        public string SpecialstorageCode { get; set; }
        [Column("sizesegment_id")]
        [StringLength(6)]
        public string SizesegmentId { get; set; }
        [Column("shippinggroup_id")]
        [StringLength(12)]
        public string ShippinggroupId { get; set; }
        [Column("price_level_ind")]
        [StringLength(1)]
        public string PriceLevelInd { get; set; }
        [Column("variant_option")]
        [StringLength(2)]
        public string VariantOption { get; set; }
        [Column("item_segment_code")]
        [StringLength(12)]
        public string ItemSegmentCode { get; set; }
    }
}
