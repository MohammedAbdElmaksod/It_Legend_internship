using Domains.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface ISuccessStoriesService
    {
        List<SuccessStories> GetAllSuccessStories();
        SuccessStories GetSuccessStoryById(int id);
        Task AddSuccessStory(SuccessStories story);
    }
}
