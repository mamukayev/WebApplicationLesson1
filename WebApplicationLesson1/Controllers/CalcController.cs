using Microsoft.AspNetCore.Mvc;

namespace WebApplicationLesson1.Controllers
{
    public class CalcController : Controller
    {
        public string Index(double a, double b, string c)
        {
            switch (c)
            {
                case null:
                case "+": return $"{a} + {b} = {a + b}";
                case "-": return $"{a} - {b} = {a - b}";
                case "*": return $"{a} * {b} = {a * b}";
                case "/": return b != 0 ? $"{a} / {b} = {a / b}" : "На ноль делить нельзя";
                default:
                    return "Только операции +,-,*";
            }

        }
    }
}
