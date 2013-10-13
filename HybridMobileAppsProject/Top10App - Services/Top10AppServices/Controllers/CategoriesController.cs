using Top10AppServices.DataLayer;
using Top10AppServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Top10AppServices.Controllers
{
    public class CategoriesController : BaseApiController
    {
        [HttpGet]
        public IEnumerable<CategoryModel> GetAll()
        {
            return this.ExecuteOperationOrHandleExceptions(() =>
                {            
                var context = new Top10AppDbContext();                
                var categoriesEntities = context.Categories;

                var categories = (from categoryEntity in categoriesEntities
                                  select new CategoryModel()
                                  {
                                      id = categoryEntity.Id,
                                      name = categoryEntity.Name,
                                      subcategories = (from subcategoryEntity in categoryEntity.Subcategories
                                                       select new SubcategoryModel()
                                                       {
                                                           id = subcategoryEntity.Id,
                                                           name = subcategoryEntity.Name,
                                                           subcategories = (from storyEntity in subcategoryEntity.Stories
                                                                            select new StoryModel()
                                                                          {
                                                                              id = storyEntity.Id,
                                                                              name = storyEntity.Name,
                                                                              subcategories = (from articleEntity in storyEntity.Articles
                                                                                              select new ArticleModel()
                                                                                              {            
                                                                                                  id = articleEntity.Id,                                                                                             
                                                                                                  name = articleEntity.Name,
                                                                                                  info = articleEntity.Info,
                                                                                                  image = articleEntity.Image
                                                                                              })
                                                                          })
                                                       })                                                                            
                                  });

                return categories;
            });
        }

        [HttpGet]
        public IEnumerable<SubcategoryModel> GetSubcategories(string category)
        {
            return this.ExecuteOperationOrHandleExceptions(() =>
            {
                var context = new Top10AppDbContext();
                
                var categoriesEntities = context.Categories;

                IEnumerable<CategoryModel> currentCategory = (from categoryEntity in categoriesEntities
                                        where categoryEntity.Name == category
                                        select new CategoryModel()
                                        {
                                            id = categoryEntity.Id,
                                            name = categoryEntity.Name,
                                            subcategories = (from subcategoryEntity in categoryEntity.Subcategories
                                                            select new SubcategoryModel()
                                                            {
                                                                id = subcategoryEntity.Id,
                                                                name = subcategoryEntity.Name
                                                            })
                                        });

                return currentCategory.FirstOrDefault().subcategories;                
            });
        }

        [HttpGet]
        public ArticleModel GetStory(string category,string story)
        {
            return this.ExecuteOperationOrHandleExceptions(() =>
            {
                return new ArticleModel()
                {
                    image = "http://demos.kendoui.com/content/mobile/cities/220/sydney.jpg",
                    info = string.Format("That is category {0}",category),
                    name = story
                };                
            });
        }
    }
}