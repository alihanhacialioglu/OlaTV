namespace OlaTvUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
            app.UseStatusCodePagesWithReExecute("/error/{0}");
            app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

            
            

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=CastTitle}/{action=CastTitle_Index}/{id?}");

			app.Run();
		}
	}
}