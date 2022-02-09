using System;
using System.Linq;
using Service.EducationBehavioralApi.Models;
using Service.TutorialBehavioral.Grpc.Models;

namespace Service.EducationBehavioralApi.Mappers
{
	public static class TaskRequestMapper
	{
		public static BehavioralTaskTextGrpcRequest ToGrpcModel(this TaskTextRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskTextGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static BehavioralTaskTestGrpcRequest ToGrpcModel(this TaskTestRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskTestGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new BehavioralTaskTestAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static BehavioralTaskVideoGrpcRequest ToGrpcModel(this TaskVideoRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskVideoGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static BehavioralTaskCaseGrpcRequest ToGrpcModel(this TaskCaseRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskCaseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Value = model.Value
		};

		public static BehavioralTaskTrueFalseGrpcRequest ToGrpcModel(this TaskTrueFalseRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskTrueFalseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new BehavioralTaskTrueFalseAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static BehavioralTaskGameGrpcRequest ToGrpcModel(this TaskGameRequest model, Guid? userId, TimeSpan duration) => new BehavioralTaskGameGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Passed = model.Passed
		};
	}
}