namespace WMS_DEPI_GRAD.Models;

public class Worker
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Shift { get; set; } = string.Empty;
    public int TasksCompleted { get; set; }
    public string Status { get; set; } = "active";
}