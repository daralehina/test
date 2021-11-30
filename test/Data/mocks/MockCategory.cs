using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Interfaces;
using test.Data.Models;

namespace test.Data.mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Подписки", desc = "Посты пользователей на которых ыв подписаны" },
                    new Category { categoryName = "Рекомендации", desc = "Посты подобранные под ваши интересы" }
                };
            }
        }
    }
}
