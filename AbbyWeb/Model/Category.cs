namespace AbbyWeb.Model
{
    public class Category
    {

        /// <summary>
        /// Индентификатор
        /// </summary>
        public int Id { get; set; }

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
