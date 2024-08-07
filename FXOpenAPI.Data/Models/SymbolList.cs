using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class SymbolInfo
    {
        [JsonPropertyName("Symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("Precision")]
        public int Precision { get; set; }

        [JsonPropertyName("MarginMode")]
        public required string MarginMode { get; set; }

        [JsonPropertyName("ProfitMode")]
        public required string ProfitMode { get; set; }

        [JsonPropertyName("ContractSize")]
        public int ContractSize { get; set; }

        [JsonPropertyName("MarginHedged")]
        public int MarginHedged { get; set; }

        [JsonPropertyName("MarginFactor")]
        public int MarginFactor { get; set; }

        [JsonPropertyName("MarginCurrency")]
        public required string MarginCurrency { get; set; }

        [JsonPropertyName("MarginCurrencyPrecision")]
        public int MarginCurrencyPrecision { get; set; }

        [JsonPropertyName("ProfitCurrency")]
        public required string ProfitCurrency { get; set; }

        [JsonPropertyName("ProfitCurrencyPrecision")]
        public int ProfitCurrencyPrecision { get; set; }

        [JsonPropertyName("Description")]
        public required string Description { get; set; }

        [JsonPropertyName("Schedule")]
        public required string Schedule { get; set; }

        [JsonPropertyName("Color")]
        public int Color { get; set; }

        [JsonPropertyName("SwapEnabled")]
        public bool SwapEnabled { get; set; }

        [JsonPropertyName("SwapType")]
        public required string SwapType { get; set; }

        [JsonPropertyName("SwapSizeShort")]
        public int SwapSizeShort { get; set; }

        [JsonPropertyName("SwapSizeint")]
        public int SwapSizeint { get; set; }

        [JsonPropertyName("TripleSwapDay")]
        public int TripleSwapDay { get; set; }

        [JsonPropertyName("MinTradeAmount")]
        public int MinTradeAmount { get; set; }

        [JsonPropertyName("MaxTradeAmount")]
        public int MaxTradeAmount { get; set; }

        [JsonPropertyName("TradeAmountStep")]
        public int TradeAmountStep { get; set; }

        [JsonPropertyName("CommissionType")]
        public required string CommissionType { get; set; }

        [JsonPropertyName("CommissionChargeType")]
        public required string CommissionChargeType { get; set; }

        [JsonPropertyName("Commission")]
        public int Commission { get; set; }

        [JsonPropertyName("LimitsCommission")]
        public int LimitsCommission { get; set; }

        [JsonPropertyName("MinCommission")]
        public int MinCommission { get; set; }

        [JsonPropertyName("MinCommissionCurrency")]
        public required string MinCommissionCurrency { get; set; }

        [JsonPropertyName("DefaultSlippage")]
        public int DefaultSlippage { get; set; }

        [JsonPropertyName("StatusGroupId")]
        public required string StatusGroupId { get; set; }

        [JsonPropertyName("SecurityName")]
        public required string SecurityName { get; set; }

        [JsonPropertyName("SecurityDescription")]
        public required string SecurityDescription { get; set; }

        [JsonPropertyName("StopOrderMarginReduction")]
        public int StopOrderMarginReduction { get; set; }

        [JsonPropertyName("HiddenLimitOrderMarginReduction")]
        public int HiddenLimitOrderMarginReduction { get; set; }

        [JsonPropertyName("ISIN")]
        public required string Isin { get; set; }

        [JsonPropertyName("SlippageType")]
        public required string SlippageType { get; set; }

        [JsonPropertyName("ExtendedName")]
        public required string ExtendedName { get; set; }

        [JsonPropertyName("TradingMode")]
        public required string TradingMode { get; set; }
    }

    public class SymbolList
    {
        public static List<SymbolInfo>? Symbols { get; set; }
    }
}
