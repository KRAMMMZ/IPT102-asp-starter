using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Mark Gervic Arca", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Roronoa Zoro", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Uchiha Itachi", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
