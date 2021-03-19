using Lessons.Data.Interfaces;
using Lessons.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lessons.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Машины с электрическим двигателем"},
                    new Category {categoryName = "Классические автомобили", desc = "Машины с ДВС"}
                };
            }
        }
    }
}
