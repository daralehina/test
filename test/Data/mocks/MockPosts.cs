using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Data.Interfaces;
using test.Data.Models;

namespace test.Data.mocks
{
    public class MockPosts : IPosts
    {
        private readonly ICategory _categoryPosts = new MockCategory();
        public IEnumerable<Post> Posts {

            get
            {
                return new List<Post> {
                    new Post { 
                        name = "Cats", 
                        shortDesc = "Не следует путать с лесной кошкой — диким представителем семейства кошачьих, несмотря на высокое внешнее сходство, а также родство.", 
                        longDesc = "С точки зрения научной систематики, домашняя кошка — млекопитающее семейства кошачьих отряда хищных. Нередко домашнюю кошку рассматривают как подвид лесной кошки (Felis silvestris) — Felis s. catus[5], однако, с точки зрения современной биологической систематики (2017 год), домашняя кошка является отдельным биологическим видом[6].", 
                        img = "/img/img_cat.jpg", 
                        isFavourite = true,
                        Category = _categoryPosts.AllCategories.First()
                    },

                    new Post {
                        name = "Программирование",
                        shortDesc = "Программи́рование — процесс создания компьютерных программ.",
                        longDesc = "По выражению одного из основателей языков программирования Никлауса Вирта, «Программы = алгоритмы + структуры данных»[1][2].Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.",
                        img = "/img/img_prog.jpg",
                        isFavourite = true,
                        Category = _categoryPosts.AllCategories.First()
                    },

                    new Post {
                        name = "Юморэээээ",
                        shortDesc = "Ю́мор — интеллектуальная способность подмечать в явлениях их комичные, смешные стороны. Чувство юмора связано с умением субъекта обнаруживать противоречия в окружающем мире[1].",
                        longDesc = "В философии и науке XVIII века противоречивость юмора рассматривалась в русле поиска логики построения юмористического образа. Так, шотландский философ Дж. Битти в эссе о смехе обозначил объект своего труда как «результат наблюдения двух или более нелогичных, несоответствующих или нелепых частей или обстоятельств, рассматривающихся как объединённые в одном сложном объекте или группе»[2]. А. Шопенгауэр в работе «Мир как воля и представление» указывал, что два несовпадающих элемента, из которых возникает смешное — это усвоенные нами понятие и реальный объект, который «мыслился в этом понятии» (но в действительности оказался отличным от него)[3].",
                        img = "/img/img_humor.jpg",
                        isFavourite = true,
                        Category = _categoryPosts.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Post> FavPosts { get; set; }

        public Post GetObjectPost(int PostID)
        {
            throw new NotImplementedException();
        }
    }
}
