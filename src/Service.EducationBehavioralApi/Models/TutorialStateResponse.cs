﻿using System.Collections.Generic;

namespace Service.EducationBehavioralApi.Models
{
	public class TutorialStateResponse
	{
		public bool Available { get; set; }

		public IEnumerable<TutorialStateUnit> Units { get; set; }

		public TotalProgressResponse TotalProgress { get; set; }
	}
}