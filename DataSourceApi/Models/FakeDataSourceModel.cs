namespace DataSourceApi.Models
{
    public class FakeDataSourceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public NestedObjectModel NestedObject { get; set; }
    }
}
