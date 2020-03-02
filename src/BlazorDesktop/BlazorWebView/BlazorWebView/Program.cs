using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Desktop;
using System;

namespace BlazorWebView
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("index.html", form =>
            {
                form.Text = "MyDesktopApp";
            });
        }
    }
}
