using Microsoft.AspNetCore.Builder;
using ERP;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ERPWebTestModule>();

public partial class Program
{
}
