using ABI.System;
using PdfSplitter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PdfSplitter.ViewModels
{
    public class AboutViewModel
    {
        public AboutViewModel()
        {
            LinkCommand = new Command<string>(async (url) => await LinkClicked(url));
        }

        public ICommand LinkCommand { get; private set; }
        public string Title => $"PDF Splitter v{((AssemblyInformationalVersionAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false).FirstOrDefault()).InformationalVersion}";

        public string Author => "Written by David Kirkham";

        public string Website => "https://davek.dev";

        public string Email => "hello@davek.dev";

        public string Github => "https://github.com/davek-dev/PdfSplitter";

        private async Task LinkClicked(string url)
        {
            await Launcher.OpenAsync(url);
        }
            
    }
}
