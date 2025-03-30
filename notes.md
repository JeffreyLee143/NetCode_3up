# 免責聲明:
**此筆記僅為複習使用，任何違法行為一概不負責**
# 資料庫建立
1. 伺服器總管->資料連接->建立新的SQL Server資料庫
* 伺服器名稱
  * (localdb)\mssqllocaldb
* 登入伺服器
  * 使用Windows驗證
* 新資料庫名稱
  * im
2. 資料表右鍵->加入新的資料表->更新->更新資料庫
```
CREATE TABLE [dbo] [Employee]
{
  [Id] INT NOT NULL PRIMARY KEY,
  [Name] VARCHAR(50) NOT NULL
}
```
```
CREATE TABLE [dbo] [Employee]
{
  [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  [Name] VARCHAR(50) NOT NULL
}
```
3. /資料表/Employee右鍵->顯示資料表資料

|Id|Name|
|-|-|
|1|AAA|
|2|BBB|
|3|CCC|
# 建立專案環境
1. 檔案->新增->專案->Web->ASP.NET Core Web應用程式->確定->Web應用程式(模型-檢視-控制器)->取消"設定HTTPS"->確定
2. 檢視->方案總管(方便操作)
3. 工具->NuGet套件管理員->管理方案的NuGet套件
4. 瀏覽後安裝下面兩個套件
  * Microsoft.EntityFrameworkCore(2.1.1)
  * Microsoft.EntityFrameworkCore.SqlServer(2.1.1)
# 製作專案
1. 方案總管下的Models右鍵->加入->類別
  * 名稱: Employee.cs
2. Employee.cs
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
  public class Employee
  {
    public int Id{get;set;}
    public string Name{get;set;}
  }
}
```
3. 方案總管下的Models右鍵->加入->類別
  * 名稱: imContext.cs
4. imContext.cs
```
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
  public class imContext:DbContext
  {
    public imContext(DbContextOptions<imContext> options) : base(options) { }
    public DbSet<Employee> Employee { get; set; }
  }
}
```
5. appsettings.json
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
    }
  },
  "ConnectionStrings": {
    "imConnectionStrings": "去伺服器總管->資料連接->名字一大串->屬性->連接字串複製起來"
  },
  "AllowedHosts": "*"
}
```
6. Startup.cs
開頭
```
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
```
services.AddMvc()下面一行:
```
services.AddDbContext<imContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("imConnectionStrings")));
```
7. Controllers右鍵->加入->控制器->使用Entity Framework 執行檢視的MVC 控制器->新增
* 模型類別: Employee(WebApplication1.Models)
* 資料內容類別: imContext(WebApplication1.Models)
* 檢視
  * 勾 產生檢視
  * 不要勾 參考指令碼程式庫
  * 勾 使用版面配置頁
* 控制器名稱: EmployeesController->新增
8. StartUp.cs
```
template: "{controller=Employees}/{action=Index}/{id?}");
```
9. /Views/Employees/Create.cshtml
```
<div class="form-group">
    <label asp-for="Id" class="control-label"></label>
    <input asp-for="Id" class="form-control" />
    <span asp-validation-for="Id" class="text-danger"></span>
    <label asp-for="Name" class="control-label"></label>
    <input asp-for="Name" class="form-control" />
    <span asp-validation-for="Name" class="text-danger"></span>
</div>
```
10. /Views/Employees/Index.cshtml
```
<p>
    <a asp-action="Create">Create</a>
    <a asp-action="Search">Search</a>
</p>
```
11. /Controllers/EmployeesControllers.cs
```
public IActionResult Search()
{
    return View();
}

[HttpPost]
public IActionResult Search(string Name)
{
    var results = _context.Employee.Where(m=>m.Name.Contains(Name)).ToList();
    return View(results);
}
```
12. Search裡面的View()右鍵->新增檢視
  * 檢視名稱: Search
  * 範本: Entity
  * 選項
    * 勾建立成局部檢視->新稱
13.  Search.cshtml
```
@model IEnumerable<Employee>
<h1>Search</h1>
<br />
<div>
<form asp-action="Search">
Name: <input type="text" id="Name" name="Name" />
      <button type="submit">Search</button>
</form>
</div>
@if(Model != null){
    <table class="table">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(model => model.Name)
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @foreach (var item in Model)
            {
                <tr>
                    <td>
                        @Html.DisplayFor(modelItem => item.Name)
                    </td>
                    <td>
                        <a asp-action="Edit" asp-route-id="@item.Id">Edit</a> |
                        <a asp-action="Details" asp-route-id="@item.Id">Details</a> |
                        <a asp-action="Delete" asp-route-id="@item.Id">Delete</a>
                    </td>
                </tr>
            }
        </tbody>
    </table>
}
```
