using System.ComponentModel.DataAnnotations;

namespace Service.WalletApi.EducationBehavioralApi.Controllers.Contracts
{
	public class TaskCaseRequest : TaskRequestBase
	{
		[Required]
		public int Value { get; set; }
	}
}