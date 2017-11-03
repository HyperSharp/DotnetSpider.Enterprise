﻿using DotnetSpider.Enterprise.Application.Project.Dtos;
using DotnetSpider.Enterprise.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSpider.Enterprise.Application.Task.Dtos
{
	public class QueryTaskOutputDto : PagingQueryOutputDto
	{
		public virtual List<ProjectDto> Projects { get; set; }
	}
}