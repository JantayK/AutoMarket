using AutoMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Models
{
    /// <summary>
    /// Класс Модели Изображений для Объявления
    /// </summary>
    public class ImageModel : IEntity<int>
    {
        public int Id { get; set; }

        [ForeignKey("Advert")]
        public int AdvertId { get; set; }
        /// <summary>
        /// Название Файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path { get; set; }
        public virtual Advert Advert { get; set; }
    }
}
