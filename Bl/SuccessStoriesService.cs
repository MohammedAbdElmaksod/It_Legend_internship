using Bl.Data;
using Domains.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class SuccessStoriesService : ISuccessStoriesService
    {
        private readonly ApplicationDbContext _context;

        public SuccessStoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddSuccessStory(SuccessStories story)
        {
            if (story is not null)
            {
                await _context.TbSuccessStories.AddAsync(story);
                _context.SaveChanges();
            }
        }

        public List<SuccessStories> GetAllSuccessStories()
        {
            return _context.TbSuccessStories.ToList();
        }

        public SuccessStories GetSuccessStoryById(int id)
        {
            if(id>0)
            {
                return _context.TbSuccessStories.Find(id);
            }
            return new SuccessStories();
        }
    }
}
