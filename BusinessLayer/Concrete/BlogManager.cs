using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetAllList();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAllList(x => x.BlogID == id);
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
