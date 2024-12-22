# NetCode_3up
411630014
For Network Programming 113_1
# 環境建置
1. 伺服器總管->資料連接->建立新的sql server資料庫->(localdb)\mssqllocaldb
2. 建立專案(ASP.Net Core Web應用程式(MVC架構), https關掉)
3. 工具->NuGet套件管理員->管理方案的NuGet套件->瀏覽->安裝Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer.
# 建立資料庫: 
使用 MS SQL Express Localdb 建立一個名為 Task 的資料表，其中包含四個欄位:
TaskId (int)，Title (varchar(20))，Description (varchar(50))，Budget (int)，DueDate
(DateTime)。並新增至少 3 筆資料至資料表。
```
CREATE TABLE [dbo].[Task] (
    [TaskId]      INT identity(0,1) NOT NULL,
    [Title]       VARCHAR (20) NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Budget]      INT          NOT NULL,
    [DueDate]     DATETIME     NOT NULL, 
    CONSTRAINT [PK_Task] PRIMARY KEY ([TaskId]),
);
```
# 建立任務模型：
建立一個名為 Task 的模型，其中包含屬性：TaskId (int)，Title
(string)，Description (string)，Budget (int) DueDate (DateTime)。
## Models/Task.cs
```
namespace Web1.Models
{
    public class Task
    {
        public int TaskId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public DateTime DueDate { get; set; }
    }
}

```
# 建立 DBContext：
建立一個名為 TaskContext 的資料庫上下文，用來與資料庫進行交互。
## How
1. 先新增資料夾"Data"在專案下, 新增一個類別叫做"TaskContext".cs
## TaskContext.cs
```
using Microsoft.EntityFrameworkCore; //導入相關套件
using YourProjectName.Models; //導入專案下的Models資料夾的內容
namespace YourProjectName.Data
{
    public class TaskContext : DbContext // 繼承DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { } // Entity Framework Core DbContext 子類別的建構子
        
        public DbSet<Models.Task> Task { get; set; } // 表示與資料庫中某個資料表 (table) 的映射
    }
}
```
# 建立控制器：
建立一個名為 TaskController 的控制器，並實作以下動作：
Index：顯示所有任務。
Create：提供新增任務的表單。
Create (POST)：處理新增任務的表單提交。
Edit：提供編輯任務的表單。
Edit (POST)：處理編輯任務的表單提交。
Details：顯示特定任務的詳細資訊。
Delete：提供刪除任務的確認頁面。
Delete (POST)：處理刪除任務的確認頁面提交。
Search : 提供對預算範圍的搜尋 (可輸入最小值與最大值)
Search (POST) : 顯示具符合預算範圍的任務。
## 提醒
這邊很容易建置失敗，請確保上面Data跟Model的內容外, 下面的設定都要對才會成功。
## How
### 編輯appsettings.json
第八行是要加入的資料,用於連線資料庫的連線字串, 其中的Encrypt=True要改成False
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "mygoConnectionStrings": "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=im;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=False",
  "AllowedHosts": "*"
}
```
### VS 2022版本: Program.cs
在開頭加入
```
using YourProjectName.Data;
using Microsoft.EntityFrameworkCore;
```
並在"builder.Services.AddControllersWithViews();"下面加入這段代碼
```
builder.Services.AddDbContext<TaskContext>(options=>options.UseSqlServer("mygoConnectionStrings")); //用於將資料庫上下文 (DbContext) 與 SQL Server 連接起來
```
所以開頭看起來會像這樣
```
using YourProjectName.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TaskContext>(options=>options.UseSqlServer("mygoConnectionStrings"));
var app = builder.Build();
```
### VS 2017版本: StartUp.cs
1. 先在開頭導入library
```
using YourProjectName.Data;
using Microsoft.EntityFrameworkCore;
```
2. 在public void ConfigureServices(IServiceCollection services){}裡面打上:
```
services.AddDbContext<TastContext>(options=>options.UseSqlServer(Configuration.GetConnectionString("mygoConnectionStrings")));
```
### 建立TaskController
1. 在Controllers資料夾按右鍵加入控制器->使用Entity Framework執行檢視的MVC控制器
* 模型類別選擇Task(YourProjectName.Models)
* DbContext類別選擇TaskContext(YourProjectName.Data)
* 檢視下面選項全勾
* 控制器名稱TaskController
2. 新增，失敗往上看步驟有沒有都對
## 建立Search功能
1. 在TaskController.cs裡面新增一個Function: Search, 用非同步方式
```
public async Task<IActionResult> Search() // 搜尋功能
{
    return View(await _context.Task.ToListAsync());
}
```
2. 對這個Function按右鍵新增檢視->Razor檢視
* 檢視名稱: Search
* 範本: Empty(沒有模型)
* 選項
  * 建立成局部顯示打勾->新增
3. 在Search.cshtml打上
```
@model IEnumerable<MVC_HW.Models.Task>

<form asp-action="Search">
    Min:<input type="number" id="Budget" name="minBudget" />
    Max:<input type="number" id="Budget" name="maxBudget" />
    <button type="submit">Search</button>
</form>
<hr />
@if(Model is not null){
    <table class="table">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(model => model.Title)
                </th>
                <th>
                    @Html.DisplayNameFor(model => model.Description)
                </th>
                <th>
                    @Html.DisplayNameFor(model => model.Budget)
                </th>
                <th>
                    @Html.DisplayNameFor(model => model.DueDate)
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @foreach (var item in Model)
            {
                <tr>
                    <td>
                        @Html.DisplayFor(modelItem => item.Title)
                    </td>
                    <td>
                        @Html.DisplayFor(modelItem => item.Description)
                    </td>
                    <td>
                        @Html.DisplayFor(modelItem => item.Budget)
                    </td>
                    <td>
                        @Html.DisplayFor(modelItem => item.DueDate)
                    </td>
                    <td>
                        <a asp-action="Edit" asp-route-id="@item.TaskId">Edit</a> |
                        <a asp-action="Details" asp-route-id="@item.TaskId">Details</a> |
                        <a asp-action="Delete" asp-route-id="@item.TaskId">Delete</a>
                    </td>
                </tr>
            }
        </tbody>
    </table>
}
```
4. 回到TaskController.cs剛剛Search的地方下面打上
```
[HttpPost]
public async Task<IActionResult> Search(int Min_Budget, int Max_Budget)
{
    var Search_Task = await _context.Task.Where(m => m.Budget.CompareTo(Min_Budget) >= 0 && m.Budget.CompareTo(Max_Budget) <= 0).ToListAsync();
    return View(Search_Task);
}
```
# 上方工具欄建立連結(Index/Create/Search)
1. 打開YourProject/Views/Shared/_Layout.cshtml
2. 找到```<div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">```把裡面改成下面這樣
```
<div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
    <ul class="navbar-nav flex-grow-1">
        <li class="nav-item">
            <a class="nav-link text-dark" asp-area="" asp-controller="Task" asp-action="Index">Home</a>
        </li>
        <li class="nav-item">
            <a class="nav-link text-dark" asp-area="" asp-controller="Task" asp-action="Search">Create</a>
        </li>
        <li class="nav-item">
            <a class="nav-link text-dark" asp-area="" asp-controller="Task" asp-action="Create">Search</a>
        </li>
    </ul>
</div>
```
# 更改路由
在Program.cs的app.MapControllerRoute改成如下所示:
```
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");
```
