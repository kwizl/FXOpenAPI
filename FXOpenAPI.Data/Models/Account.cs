using System.Text.Json.Serialization;

namespace FXOpenAPI.Data.Models
{
    public class Account
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("AccountingType")]
        public required string AccountingType { get; set; }

        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("Email")]
        public required string Email { get; set; }

        [JsonPropertyName("Registered")]
        public long Registered { get; set; }

        [JsonPropertyName("Modified")]
        public long Modified { get; set; }

        [JsonPropertyName("IsArchived")]
        public bool IsArchived { get; set; }

        [JsonPropertyName("IsBlocked")]
        public bool IsBlocked { get; set; }

        [JsonPropertyName("IsReadonly")]
        public bool IsReadonly { get; set; }

        [JsonPropertyName("IsValid")]
        public bool IsValid { get; set; }

        [JsonPropertyName("IsWebApiEnabled")]
        public bool IsWebApiEnabled { get; set; }

        [JsonPropertyName("Leverage")]
        public int Leverage { get; set; }

        [JsonPropertyName("Balance")]
        public decimal Balance { get; set; }

        [JsonPropertyName("BalanceCurrency")]
        public required string BalanceCurrency { get; set; }

        [JsonPropertyName("Profit")]
        public decimal Profit { get; set; }

        [JsonPropertyName("Commission")]
        public decimal Commission { get; set; }

        [JsonPropertyName("AgentCommission")]
        public decimal AgentCommission { get; set; }

        [JsonPropertyName("Swap")]
        public decimal Swap { get; set; }

        [JsonPropertyName("Rebate")]
        public decimal Rebate { get; set; }

        [JsonPropertyName("Equity")]
        public decimal Equity { get; set; }

        [JsonPropertyName("Margin")]
        public decimal Margin { get; set; }

        [JsonPropertyName("MarginCallLevel")]
        public int MarginCallLevel { get; set; }

        [JsonPropertyName("StopOutLevel")]
        public int StopOutLevel { get; set; }

        [JsonPropertyName("ReportCurrency")]
        public required string ReportCurrency { get; set; }

        [JsonPropertyName("IsTokenCommissionEnabled")]
        public bool IsTokenCommissionEnabled { get; set; }

        [JsonPropertyName("Throttling")]
        public List<Throttling> Throttling { get; set; }

        [JsonPropertyName("IsLongOnly")]
        public bool IsLongOnly { get; set; }
    }
}
