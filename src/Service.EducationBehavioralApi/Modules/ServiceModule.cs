﻿using Autofac;
using Service.Core.Client.Services;
using Service.TutorialBehavioral.Client;
using Service.UserReward.Client;

namespace Service.EducationBehavioralApi.Modules
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterTutorialBehavioralClient(Program.Settings.EducationFlowServiceUrl);
			builder.RegisterUserRewardClient(Program.Settings.UserRewardServiceUrl);

			builder.RegisterType<SystemClock>().AsImplementedInterfaces().SingleInstance();

			builder.Register(context => new EncoderDecoder(Program.EncodingKey))
				.As<IEncoderDecoder>()
				.SingleInstance();
		}
	}
}