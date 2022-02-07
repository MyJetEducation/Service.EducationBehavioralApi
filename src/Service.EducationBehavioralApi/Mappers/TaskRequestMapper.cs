﻿using System;
using System.Linq;
using Service.EducationBehavioralApi.Models;
using Service.TutorialPersonal.Grpc.Models;

namespace Service.EducationBehavioralApi.Mappers
{
	public static class TaskRequestMapper
	{
		public static PersonalTaskTextGrpcRequest ToGrpcModel(this TaskTextRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskTextGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static PersonalTaskTestGrpcRequest ToGrpcModel(this TaskTestRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskTestGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new PersonalTaskTestAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static PersonalTaskVideoGrpcRequest ToGrpcModel(this TaskVideoRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskVideoGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration
		};

		public static PersonalTaskCaseGrpcRequest ToGrpcModel(this TaskCaseRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskCaseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Value = model.Value
		};

		public static PersonalTaskTrueFalseGrpcRequest ToGrpcModel(this TaskTrueFalseRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskTrueFalseGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Answers = model.Answers.Select(answer => new PersonalTaskTrueFalseAnswerGrpcModel
			{
				Number = answer.Number,
				Value = answer.Value
			}).ToArray()
		};

		public static PersonalTaskGameGrpcRequest ToGrpcModel(this TaskGameRequest model, Guid? userId, TimeSpan duration) => new PersonalTaskGameGrpcRequest
		{
			UserId = userId,
			IsRetry = model.IsRetry,
			Duration = duration,
			Passed = model.Passed
		};
	}
}