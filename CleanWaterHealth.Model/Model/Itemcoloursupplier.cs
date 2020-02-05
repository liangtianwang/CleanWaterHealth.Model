using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanWaterHealth.Model.Model
{
    [Table("itemcoloursupplier")]
    public partial class Itemcoloursupplier
    {
        [Key]
        [Column("itemcoloursupplier_id")]
        [StringLength(12)]
        public string ItemcoloursupplierId { get; set; }
        [Column("itemcolour_id")]
        [StringLength(12)]
        public string ItemcolourId { get; set; }
        [Column("seq_in_itemcolour")]
        public int? SeqInItemcolour { get; set; }
        [Column("supplier_code")]
        [StringLength(12)]
        public string SupplierCode { get; set; }
        [Column("primary_ind")]
        [StringLength(1)]
        public string PrimaryInd { get; set; }
        [Column("supplier_itemcolour_ref")]
        [StringLength(32)]
        public string SupplierItemcolourRef { get; set; }
        [Column("supplier_ic_description")]
        [StringLength(50)]
        public string SupplierIcDescription { get; set; }
        [Column("active_ind")]
        [StringLength(1)]
        public string ActiveInd { get; set; }
        [Column("edi_ind")]
        [StringLength(1)]
        public string EdiInd { get; set; }
        [Column("currency_code")]
        [StringLength(12)]
        public string CurrencyCode { get; set; }
        [Column("frncur_purch_unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? FrncurPurchUnitCost { get; set; }
        [Column("units_per_price_quote", TypeName = "numeric(20, 4)")]
        public decimal? UnitsPerPriceQuote { get; set; }
        [Column("frncur_unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? FrncurUnitCost { get; set; }
        [Column("unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? UnitCost { get; set; }
        [Column("initial_frncur_unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? InitialFrncurUnitCost { get; set; }
        [Column("initial_unit_cost", TypeName = "numeric(20, 4)")]
        public decimal? InitialUnitCost { get; set; }
        [Column("exchange_rate", TypeName = "numeric(22, 6)")]
        public decimal? ExchangeRate { get; set; }
        [Column("exchange_rate_date", TypeName = "datetime")]
        public DateTime? ExchangeRateDate { get; set; }
        [Column("frncur_purch_eff_date", TypeName = "datetime")]
        public DateTime? FrncurPurchEffDate { get; set; }
        [Column("factory_agent_code")]
        [StringLength(12)]
        public string FactoryAgentCode { get; set; }
        [Column("inner_pack_uom_code")]
        [StringLength(12)]
        public string InnerPackUomCode { get; set; }
        [Column("sell_units_per_inner_pack", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerInnerPack { get; set; }
        [Column("outer_pack_uom_code")]
        [StringLength(12)]
        public string OuterPackUomCode { get; set; }
        [Column("inner_packs_per_outer_pck", TypeName = "numeric(20, 4)")]
        public decimal? InnerPacksPerOuterPck { get; set; }
        [Column("sell_units_per_outer_pack", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerOuterPack { get; set; }
        [Column("outer_packs_per_pallet", TypeName = "numeric(20, 4)")]
        public decimal? OuterPacksPerPallet { get; set; }
        [Column("sell_units_per_pallet", TypeName = "numeric(20, 4)")]
        public decimal? SellUnitsPerPallet { get; set; }
        [Column("delivery_leadtime_days", TypeName = "numeric(20, 4)")]
        public decimal? DeliveryLeadtimeDays { get; set; }
        [Column("minimum_units_order", TypeName = "numeric(20, 4)")]
        public decimal? MinimumUnitsOrder { get; set; }
        [Column("minimum_order_value", TypeName = "numeric(20, 4)")]
        public decimal? MinimumOrderValue { get; set; }
        [Column("origin_country_code")]
        [StringLength(12)]
        public string OriginCountryCode { get; set; }
        [Column("current_valuation_id")]
        [StringLength(12)]
        public string CurrentValuationId { get; set; }
    }
}
