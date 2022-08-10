using AutoMarket.BLL.Dtos.Advert;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.BLL.Dtos.ImageModel
{
    /// <summary>
    /// Dto модель для Изображений
    /// </summary>
    public class ImageModelDto
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
        public virtual AdvertDto Advert { get; set; }
    }
}
