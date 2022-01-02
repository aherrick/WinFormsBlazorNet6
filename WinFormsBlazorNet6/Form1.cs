using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using WinFormsBlazorNet6.Pages;

namespace WinFormsBlazorNet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");

            blazorWebView1.Dock = DockStyle.Fill;
        }
    }
}