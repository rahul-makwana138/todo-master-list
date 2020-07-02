using System;

namespace TodoList.WebApi
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
