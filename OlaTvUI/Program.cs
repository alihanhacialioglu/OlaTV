using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Newtonsoft.Json;
using NToastNotify;


namespace OlaTvUI
{
	public class Program
	{
        
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
               AddCookie(options =>
               {
                   options.LoginPath = "/Login/Login_Index";
               });

            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            //Add services to the container.
            builder.Services.AddRazorPages().AddNToastNotifyNoty(new NotyOptions
            {
                ProgressBar = true,
                Timeout = 5000
            });
            builder.Services.AddMvc();

            //Set Session Timeout.Default is 20 minutes.
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(1);
            });



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

            app.UseAuthentication();
            app.UseAuthorization();
            app.MapRazorPages();
            //toastNotify packects
            app.UseNToastNotify();



            app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Login}/{action=Login_Index}/{id?}");

			app.Run();
		}
	}
}