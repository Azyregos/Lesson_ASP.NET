using Lessons.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lessons.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if(!content.Car.Any())
            {
                content.Car.AddRange(Cars.Select(c => c.Value));
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Электромобили", desc = "Машины с электрическим двигателем" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с ДВС" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach(var i in list)
                    {
                        category.Add(i.categoryName, i);
                    }
                }

                return category;

            }
        }

        private static Dictionary<string, Car> car;

        public static Dictionary<string, Car> Cars
        {
            get
            {
                if (car == null)
                {
                    var list = new Car[]
                    {
                        new Car
                    {
                        name = "Tesla 3",
                        shortDesc ="Быстрый и современный",
                        longDesc = "По своим размерам Tesla Model 3 сопоставима с седаном Mercedes-Benz C-Class: длина 4694 мм, ширина 1933 мм (с учетом боковых зеркал), высота 1443 мм, колесная база 2875 мм. " +
                        "Стандартная модель снаряженной массой 1609 кг обладает запасом хода 354 км, разгоном до 97 км/ч за 5,6 секунды и максимальной скоростью 209 км/ч. Ее батарея имеет емкость 60 кВт·ч. " +
                        "Более «долгоиграющая» и быстрая Tesla Model 3 (499 км пробега на одной зарядке, разгон до 97 км/ч за 5,1 секунды, максимальная скорость 225 км/ч, масса 1730 кг) имеет батарею емкостью 75 кВт·ч. " +
                        "Производство модели началось именно с этой — более дорогой версии. Самый доступный вариант Model 3 встанет на конвейер только в ноябре.",
                        img = "/img/Tesla model 3.png",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Mercedes-Benz A-Class",
                        shortDesc = "Представительный",
                        longDesc = "Презентация нового поколения премиального хэтчбека Mercedes-Benz A-класса состоялась в первых числах февраля 2018 года на специальном мероприятии в столице Голландии – Амстердаме. " +
                        "Новая серия включает большое число модернизаций, затронувших как внешний вид, так и технологическую составляющую автомобиля. " +
                        "Обновлённая модель с заводским индексом W177 обзавелась более прочным силовым каркасом, слегка увеличилась в габаритах, " +
                        "а также обрела абсолютно новый дизайн кузова в фирменной стилистике компании под названием «Sensual Purity». " +
                        "Внутри новый A-класс получил полностью обновлённый салон с продвинутой медиасистемой Mercedes-Benz User Experience.",
                        img = "/img/Mersedes-Benz A-Class.jpg",
                        price = 60000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Audi A4",
                        shortDesc= "Немецкий стиль",
                        longDesc = "Выразительная динамичная передняя часть, идеальные пропорции кузова и запоминающийся силуэт подчеркивают главную, спортивную составляющую характера нового Audi A4. " +
                        "Выполненный в лучших традициях марки, тщательно продуманный, функциональный и высококачественный, автомобиль оснащен новейшими информационно-развлекательными и ассистирующими системами, " +
                        "созданными с применением инновационных технологий. Дополняет этот быстрый «портрет» модели безупречно оформленный стильный интерьер и линейка мощных современных двигателей.",
                        img = "/img/Audi A4.jpg",
                        price = 55000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    };

                    car = new Dictionary<string, Car>();

                    foreach (var i in list)
                    {
                        car.Add(i.name, i);
                    }
                }

                return car;

            }
        }
    }
}
