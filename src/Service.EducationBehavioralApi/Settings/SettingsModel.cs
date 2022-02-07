using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.EducationBehavioralApi.Settings
{
	public class SettingsModel
	{
		[YamlProperty("EducationBehavioralApi.SeqServiceUrl")]
		public string SeqServiceUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.ZipkinUrl")]
		public string ZipkinUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.ElkLogs")]
		public LogElkSettings ElkLogs { get; set; }

		[YamlProperty("EducationBehavioralApi.UserInfoCrudServiceUrl")]
		public string UserInfoCrudServiceUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.TutorialBehavioralServiceUrl")]
		public string TutorialBehavioralServiceUrl { get; set; }

		[YamlProperty("EducationBehavioralApi.JwtAudience")]
		public string JwtAudience { get; set; }

		[YamlProperty("EducationBehavioralApi.UserRewardServiceUrl")]
		public string UserRewardServiceUrl { get; set; }
	}
}