namespace ToDoAppWebAPI.Api.Models
{
    public class ToDoItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public uint CategoryId {  get; set; }
    }
}
