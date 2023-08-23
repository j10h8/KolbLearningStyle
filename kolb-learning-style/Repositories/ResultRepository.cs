﻿using kolb_learning_style.Data;
using kolb_learning_style.Models;

namespace kolb_learning_style.Repositories
{
	public class ResultRepository : IResultRepository
	{
		private readonly MainDbContext mainDbContext;

		public ResultRepository(MainDbContext mainDbContext)
		{
			this.mainDbContext = mainDbContext;
		}

		public async Task<bool> AddResultAsync(ResultModel result)
		{
			await mainDbContext.Results.AddAsync(result);

			if (await mainDbContext.SaveChangesAsync() > 0)
			{
				return true;
			}

			return false;
		}
	}
}