using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.Orchestration;
public class CompanySearchSkill
{
    [SKFunction("search employee infomation")]
    public string EmployeeSearch(string input)
    {
        return "歡迎瞭解社保相關內容";
    }

    [SKFunction("search weather")]
    public string WeatherSearch(string text)
    {
        return "Guangzhou, 2 degree,rainy";
    }
}