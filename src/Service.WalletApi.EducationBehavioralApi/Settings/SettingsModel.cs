using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.WalletApi.EducationBehavioralApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationBehavioralApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationBehavioralApi.EnableApiTrace")]
		public bool EnableApiTrace { get; set; }

		[YamlProperty("EducationBehavioralApi.MyNoSqlReaderHostPort")]
		public string MyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationBehavioralApi.AuthMyNoSqlReaderHostPort")]
		public string AuthMyNoSqlReaderHostPort { get; set; }

		[YamlProperty("EducationBehavioralApi.SessionEncryptionKeyId")]
		public string SessionEncryptionKeyId { get; set; }

		[YamlProperty("EducationBehavioralApi.MyNoSqlWriterUrl")]
		public string MyNoSqlWriterUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.EducationFlowServiceUrl")]
		public string EducationFlowServiceUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }
	}
}