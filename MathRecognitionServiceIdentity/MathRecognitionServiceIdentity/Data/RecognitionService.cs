using MathRecognitionServiceIdentityDB.Data.MathRecognitionServiceIdentity;
using Microsoft.EntityFrameworkCore;

namespace MathRecognitionServiceIdentity.Data
{
	public class RecognitionService
	{
		private readonly MathRecognitionServiceIdentityContext _context;
		public RecognitionService(MathRecognitionServiceIdentityContext context)
		{
			_context = context;
		}
		public async Task<List<Recognition>> GetRecognitionAsync(string strCurrentUserId)
		{
			// Get Weather Forecasts  
			return await _context.Recognitions
				 // Only get entries for the current logged in user
				 .Where(x => x.UserName == strCurrentUserId)
				 // Use AsNoTracking to disable EF change tracking
				 // Use ToListAsync to avoid blocking a thread
				 .AsNoTracking().ToListAsync();

		}

		public Task<Recognition> CreateRecogntionAsync(Recognition objRecognition)
		{
			_context.Recognitions.Add(objRecognition);
			_context.SaveChanges();
			return Task.FromResult(objRecognition);
		}
	}
}
