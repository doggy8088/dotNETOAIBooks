using Microsoft.SemanticKernel;
using System.ComponentModel;
using System.Globalization;


public class CompanySearchPlugin
{
    [SKFunction,Description("search employee infomation")]
    public string EmployeeSearch(string input)
    {
        return "欢迎了解社保相关内容";
    }

    [SKFunction,Description("search weather")]
    public string WeatherSearch(string text)
    {
        return "Guangzhou, 2 degree,rainy";
    }
}