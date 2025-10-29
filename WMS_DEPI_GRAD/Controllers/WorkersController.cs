using Microsoft.AspNetCore.Mvc;
using WMS_DEPI_GRAD.Models;

namespace WMS_DEPI_GRAD.Controllers;
public class WorkersController : Controller
{
    private static List<Worker> _workers = new()
        {
            new Worker { Id = "W001", Name = "John Doe", Email = "john.doe@warehouse.com", Role = "Picker", Shift = "Morning", TasksCompleted = 45, Status = "active" },
            new Worker { Id = "W002", Name = "Jane Smith", Email = "jane.smith@warehouse.com", Role = "Packer", Shift = "Afternoon", TasksCompleted = 38, Status = "active" },
            new Worker { Id = "W003", Name = "Bob Wilson", Email = "bob.wilson@warehouse.com", Role = "Forklift Operator", Shift = "Morning", TasksCompleted = 52, Status = "offline" }
        };

    public IActionResult Index()
    {
        return View(_workers);
    }

    [HttpPost]
    public IActionResult Create(string name, string email, string role, string shift)
    {
        var newWorker = new Worker
        {
            Id = $"W{(_workers.Count + 1).ToString("D3")}",
            Name = name,
            Email = email,
            Role = role,
            Shift = shift,
            TasksCompleted = 0,
            Status = "active"
        };

        _workers.Add(newWorker);
        TempData["Success"] = $"{newWorker.Name} added successfully!";
        return RedirectToAction(nameof(Index));
    }
}
