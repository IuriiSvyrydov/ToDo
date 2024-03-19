using Todo.Domain.Aggregate.TodoGroupRoot;

namespace Todo.Domain.Entities;

public class TodoGroup
{
    public TodoGroupId Id { get; set; }
    public string GroupName { get; set; }
    public DateTime CreateOn { get; set; }

}