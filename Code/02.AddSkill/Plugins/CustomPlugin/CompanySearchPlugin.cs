using Microsoft.SemanticKernel;
using System.ComponentModel;
using System.Globalization;


public class CompanySearchPlugin
{
    [SKFunction,Description("search employee infomation")]
    public string EmployeeSearch(string input)
    {
        return "歡迎瞭解社保相關內容";
    }

    [SKFunction,Description("search weather")]
    public string WeatherSearch(string text)
    {
        return "Guangzhou, 2 degree,rainy";
    }
}