using Domains.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IBlogService
    {
        List<Blogs> GetAllBlogs();
        Blogs GetBlogById(int id);
    }
}
