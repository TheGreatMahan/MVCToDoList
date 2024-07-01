namespace MVCToDoList.Web.Models
{
    public class AddTaskItemViewModel
    {
        public string? Title { get; set; } = "";
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
