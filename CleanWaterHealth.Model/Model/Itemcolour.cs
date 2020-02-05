using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcolour")]
    public partial class Itemcolour
    {
        [Key]
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("item_code")]
        [StringLength(16)]
        public string ItemCode { get; set; }
        [Column("colour_code")]
        [StringLength(8)]
        public string ColourCode { get; set; }
        [Column("itemcolour_ref")]
        [StringLength(32)]
        public string ItemcolourRef { get; set; }
        [Column("seq_in_item")]
        public int? SeqInItem { get; set; }
        [Column("override_colour_descripti")]
        [StringLength(50)]
        public string OverrideColourDescripti { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("itemtype_code")]
        [StringLength(12)]
        public string ItemtypeCode { get; set; }
        [Column("status_ind")]
        [StringLength(1)]
        public string StatusInd { get; set; }
        [Column("abc_class_ind")]
        [StringLength(1)]
        public string AbcClassInd { get; set; }
        [Column("otb_retail_price", TypeName = "numeric(20, 4)")]
        public decimal? OtbRetailPrice { get; set; }
        [Column("otb_gp_pct", TypeName = "numeric(20, 4)")]
        public decimal? OtbGpPct { get; set; }
        [Column("std_unit_cost", TypeName = "numeric(22, 6)")]
        public decimal? StdUnitCost { get; set; }
        [Column("initial_otb_retail_price", TypeName = "numeric(20, 4)")]
        public decimal? InitialOtbRetailPrice { get; set; }
        [Column("initial_otb_gp_pct", TypeName = "numeric(20, 4)")]
        public decimal? InitialOtbGpPct { get; set; }
        [Column("initial_std_unit_cost", TypeName = "numeric(22, 6)")]
        public decimal? InitialStdUnitCost { get; set; }
        [Column("sku_prefix")]
        [StringLength(32)]
        public string SkuPrefix { get; set; }
        [Column("similar_itemcolour_id")]
        [StringLength(12)]
        public string SimilarItemcolourId { get; set; }
        [Column("first_ordered_date", TypeName = "datetime")]
        public DateTime? FirstOrderedDate { get; set; }
        [Column("initial_fob_cost", TypeName = "numeric(20, 4)")]
        public decimal? InitialFobCost { get; set; }
        [Column("last_fob_cost", TypeName = "numeric(20, 4)")]
        public decimal? LastFobCost { get; set; }
        [Column("last_po_code")]
        [StringLength(12)]
        public string LastPoCode { get; set; }
        [Column("last_po_order_date", TypeName = "datetime")]
        public DateTime? LastPoOrderDate { get; set; }
        [Column("itemcolourwash")]
        [StringLength(50)]
        public string Itemcolourwash { get; set; }
        [Column("itemcolourcontent")]
        [StringLength(50)]
        public string Itemcolourcontent { get; set; }
        [Column("itemcolourconstruction")]
        [StringLength(50)]
        public string Itemcolourconstruction { get; set; }
        [Column("short_description")]
        [StringLength(30)]
        public string ShortDescription { get; set; }
        [Column("category_code")]
        [StringLength(12)]
        public string CategoryCode { get; set; }
        [Column("division_code_rd")]
        [StringLength(12)]
        public string DivisionCodeRd { get; set; }
        [Column("department_code_rd")]
        [StringLength(12)]
        public string DepartmentCodeRd { get; set; }
        [Column("description")]
        [StringLength(50)]
        public string Description { get; set; }
        [Column("short_colour_description")]
        [StringLength(16)]
        public string ShortColourDescription { get; set; }
        [Column("last_delivery_date", TypeName = "datetime")]
        public DateTime? LastDeliveryDate { get; set; }
        [Column("store_order_allowed_ind")]
        [StringLength(1)]
        public string StoreOrderAllowedInd { get; set; }
        [Column("fastmenu_code")]
        [StringLength(12)]
        public string FastmenuCode { get; set; }
        [Column("pick_list_position")]
        public int? PickListPosition { get; set; }
        [Column("refill_allowed_ind")]
        [StringLength(1)]
        public string RefillAllowedInd { get; set; }
        [Column("replacement_allowed_ind")]
        [StringLength(1)]
        public string ReplacementAllowedInd { get; set; }
        [Column("discount_allowed_ind")]
        [StringLength(1)]
        public string DiscountAllowedInd { get; set; }
        [Column("discountitem_code")]
        [StringLength(12)]
        public string DiscountitemCode { get; set; }
        [Column("backroom_scale_ref")]
        [StringLength(4)]
        public string BackroomScaleRef { get; set; }
        [Column("backroom_scale_ind")]
        [StringLength(1)]
        public string BackroomScaleInd { get; set; }
        [Column("backroom_scale_desc")]
        [StringLength(50)]
        public string BackroomScaleDesc { get; set; }
        [Column("fast_menu_description_1")]
        [StringLength(12)]
        public string FastMenuDescription1 { get; set; }
        [Column("fast_menu_description_2")]
        [StringLength(12)]
        public string FastMenuDescription2 { get; set; }
        [Column("fast_image_code")]
        [StringLength(12)]
        public string FastImageCode { get; set; }
        [Column("suppress_ind")]
        [StringLength(1)]
        public string SuppressInd { get; set; }
        [Column("bottlereturntype_code")]
        [StringLength(12)]
        public string BottlereturntypeCode { get; set; }
        [Column("specialstorage_code")]
        [StringLength(12)]
        public string SpecialstorageCode { get; set; }
        [Column("dangerousgoods_code")]
        [StringLength(12)]
        public string DangerousgoodsCode { get; set; }
        [Column("securitylevel_code")]
        [StringLength(12)]
        public string SecuritylevelCode { get; set; }
        [Column("import_tariff_code")]
        [StringLength(12)]
        public string ImportTariffCode { get; set; }
        [Column("invoice_description")]
        [StringLength(50)]
        public string InvoiceDescription { get; set; }
        [Column("import_freight_code")]
        [StringLength(12)]
        public string ImportFreightCode { get; set; }
        [Column("feature_colour_code")]
        [StringLength(16)]
        public string FeatureColourCode { get; set; }
        [Column("override_feature_clr_desc")]
        [StringLength(50)]
        public string OverrideFeatureClrDesc { get; set; }
        [Column("abc_class_a_percent")]
        public int? AbcClassAPercent { get; set; }
        [Column("abc_class_b_percent")]
        public int? AbcClassBPercent { get; set; }
        [Column("abc_class_c_percent")]
        public int? AbcClassCPercent { get; set; }
        [Column("abc_class_last_computed", TypeName = "datetime")]
        public DateTime? AbcClassLastComputed { get; set; }
        [Column("finished_unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? FinishedUnitCost { get; set; }
        [Column("local_retail_buy_price", TypeName = "numeric(20, 4)")]
        public decimal? LocalRetailBuyPrice { get; set; }
        [Column("sell_uom_code")]
        [StringLength(12)]
        public string SellUomCode { get; set; }
        [Column("items_per_sell_unit", TypeName = "numeric(20, 4)")]
        public decimal? ItemsPerSellUnit { get; set; }
        [Column("wholesale_uom_code")]
        [StringLength(12)]
        public string WholesaleUomCode { get; set; }
        [Column("wholesale_unit_qty", TypeName = "numeric(20, 4)")]
        public decimal? WholesaleUnitQty { get; set; }
        [Column("weight_volume_length_ind")]
        [StringLength(1)]
        public string WeightVolumeLengthInd { get; set; }
        [Column("weight_volume_length_amt", TypeName = "numeric(20, 4)")]
        public decimal? WeightVolumeLengthAmt { get; set; }
        [Column("shape_type_ind")]
        [StringLength(1)]
        public string ShapeTypeInd { get; set; }
        [Column("width_cm", TypeName = "numeric(20, 4)")]
        public decimal? WidthCm { get; set; }
        [Column("height_cm", TypeName = "numeric(20, 4)")]
        public decimal? HeightCm { get; set; }
        [Column("depth_cm", TypeName = "numeric(20, 4)")]
        public decimal? DepthCm { get; set; }
        [Column("radius_cm", TypeName = "numeric(20, 4)")]
        public decimal? RadiusCm { get; set; }
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
        [Column("irregular_shape_ind")]
        [StringLength(1)]
        public string IrregularShapeInd { get; set; }
        [Column("itemglgroup_code")]
        [StringLength(12)]
        public string ItemglgroupCode { get; set; }
        [Column("notes_nar")]
        [StringLength(255)]
        public string NotesNar { get; set; }
        [Column("country_of_origin_code")]
        [StringLength(12)]
        public string CountryOfOriginCode { get; set; }
        [Column("offprice_ind")]
        [StringLength(1)]
        public string OffpriceInd { get; set; }
        [Column("price_source_ind")]
        [StringLength(1)]
        public string PriceSourceInd { get; set; }
        [Column("primary_supplier_code")]
        [StringLength(12)]
        public string PrimarySupplierCode { get; set; }
        [Column("current_valuation_id")]
        [StringLength(12)]
        public string CurrentValuationId { get; set; }
        [Column("initial_valuation_id")]
        [StringLength(12)]
        public string InitialValuationId { get; set; }
        [Column("store_order_review_ind")]
        [StringLength(1)]
        public string StoreOrderReviewInd { get; set; }
        [Column("office_order_review_ind")]
        [StringLength(1)]
        public string OfficeOrderReviewInd { get; set; }
        [Column("pick_roundup")]
        public int? PickRoundup { get; set; }
        [Column("sub_for_itemcolour_id")]
        [StringLength(12)]
        public string SubForItemcolourId { get; set; }
        [Column("max_qty_per_picking_bin", TypeName = "numeric(20, 4)")]
        public decimal? MaxQtyPerPickingBin { get; set; }
        [Column("scale_ind")]
        [StringLength(1)]
        public string ScaleInd { get; set; }
        [Column("buffer_qty_oh", TypeName = "numeric(20, 4)")]
        public decimal? BufferQtyOh { get; set; }
        [Column("price_prompt_ind")]
        [StringLength(1)]
        public string PricePromptInd { get; set; }
        [Column("loyalty_exclusion_ind")]
        [StringLength(1)]
        public string LoyaltyExclusionInd { get; set; }
        [Column("loyalty_point_ratio", TypeName = "numeric(20, 4)")]
        public decimal? LoyaltyPointRatio { get; set; }
        [Column("max_redemption_perc", TypeName = "numeric(20, 4)")]
        public decimal? MaxRedemptionPerc { get; set; }
        [Column("redeem_points_ind")]
        [StringLength(1)]
        public string RedeemPointsInd { get; set; }
        [Column("similar_itemcolour_ind")]
        [StringLength(1)]
        public string SimilarItemcolourInd { get; set; }
        [Column("similar_itemcolour_expiry", TypeName = "datetime")]
        public DateTime? SimilarItemcolourExpiry { get; set; }
        [Column("fit_code")]
        [StringLength(12)]
        public string FitCode { get; set; }
        [Column("instore_manuf_ind")]
        [StringLength(1)]
        public string InstoreManufInd { get; set; }
        [Column("deplete_from_ics_id")]
        [StringLength(12)]
        public string DepleteFromIcsId { get; set; }
        [Column("first_published_date", TypeName = "datetime")]
        public DateTime? FirstPublishedDate { get; set; }
        [Column("stock_ic_multiplier")]
        public int? StockIcMultiplier { get; set; }
        [Column("order_ic_divisor")]
        public int? OrderIcDivisor { get; set; }
        [Column("picklist_shelf_label")]
        [StringLength(16)]
        public string PicklistShelfLabel { get; set; }
        [Column("defaultgradelist_code")]
        [StringLength(12)]
        public string DefaultgradelistCode { get; set; }
        [Column("weight", TypeName = "numeric(19, 6)")]
        public decimal? Weight { get; set; }
        [Column("weight_uom_code")]
        [StringLength(12)]
        public string WeightUomCode { get; set; }
        [Column("compliance_enabled_ind")]
        [StringLength(1)]
        public string ComplianceEnabledInd { get; set; }
    }
}
