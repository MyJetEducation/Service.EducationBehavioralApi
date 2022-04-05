using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationBehavioralApi.Controllers.Contracts
{
	public class TaskAnswer
	{
		[Required]
		public int Number { get; set; }

		[Required]
		public int[] Value { get; set; }
	}
}