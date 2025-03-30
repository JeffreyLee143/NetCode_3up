namespace MVC_HW.Models
{
    public class Task
    {
        public int TaskId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public DateTime DueDate { get; set; }
    }
}
