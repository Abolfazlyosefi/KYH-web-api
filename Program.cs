var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");


app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));

app.MapGet("/subtract", (int num1, int num2) => SubtractNumbers(num1, num2));

string AddNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return $"Summan av {num1} och {num2} �r: {num1 + num2}";


}string SubtractNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return $"Differencen av {num1} och {num2} �r: {num1 - num2}";
}


app.Run();
