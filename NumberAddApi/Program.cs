using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using NumberAddApi;


var builder = WebApplication.CreateBuilder(args);
//configure services
builder.Services.AddDbContext<NumberCalcDb>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();
//configure HTTP request pipeline
if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//Map post
app.MapPost("api/calcs", context =>
{
    //deserealise and read the incoming JSON request
    var request = context.Request.ReadFromJsonAsync<CalcRequest>().Result;
    //perform the correct calculation based on operator
    double result =DoCalc(request.Num1, request.Num2, request.Operater);
    using var scope= app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<NumberCalcDb>();
    //save the result to the db
    dbContext.CalcResults.Add(new CalcResult
    {
        Num1 = request.Num1, Num2 =request.Num2, Operater =request.Operater, Result= result
    });
    dbContext.SaveChanges();

    //return the result as a JSON response
    return context.Response.WriteAsJsonAsync(new {Result=result}); 
});

app.MapGet("/api/calcs", context =>
{
    using var scope = app.Services.CreateScope();
    var dbContext =scope.ServiceProvider.GetRequiredService<NumberCalcDb>();
    //Retrieve calc history from db
    var calcs = dbContext.CalcResults.ToList();
    //Return the history as a Json Response
    return context.Response.WriteAsJsonAsync(calcs);
});

app.Run();
//DoCalc function
double DoCalc(double num1, double num2, string operater)
{
    switch (operater)
    {
        case "+":
            return num1 + num2;
        case "-": 
            return num1 - num2;
        case "*": 
            return num1 * num2;
        case "/":
            if (num2!=0)
            {
                return num1 / num2;
            }
            else
            {
                throw new ArgumentException("Division by 0 is not possible");
            }
        default:
            throw new ArgumentException("Operator is not valid. Only use +,-,*,/");            
    }
}
//calcrequest class
public class CalcRequest
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public string Operater { get; set; }
}
//caclresult class
public class CalcResult
{
    public int Id { get; set; }
    public double Num1 { get; set; }
    public double Num2 { get; set; }
    public string Operater { get; set; }
    public double Result { get; set; }
}
