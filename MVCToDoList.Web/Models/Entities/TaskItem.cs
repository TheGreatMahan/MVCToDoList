﻿using System.ComponentModel.DataAnnotations;

namespace MVCToDoList.Web.Models.Entities
{
    public class TaskItem
    {

        public Guid Id { get; set; }

        public string? Title { get; set; } = "";
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
