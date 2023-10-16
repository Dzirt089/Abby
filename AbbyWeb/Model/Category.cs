using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    /// <summary>
    /// Таблица в БД
    /// </summary>
    public class Category
    {
        [Key] //Первичный ключ.
        /// <summary>
        /// Индентификатор
        /// </summary>
        public int Id { get; set; }

        [Required] //Обязательный параметр
        /// <summary>
        /// Наименование категории
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Порядок отображения столбца таблицы
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
