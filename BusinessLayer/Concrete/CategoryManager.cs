﻿using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return efCategoryRepository.GetAllList();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}