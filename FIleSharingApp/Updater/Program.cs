using LibGit2Sharp;
using LibGit2Sharp.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Killing FileSharingApp");
            Process.Start("cmd", "/C Taskkill /IM FileSharingAppClient.exe /F").WaitForExit();
            Process.Start("cmd", "/C Taskkill /IM FileSharingAppServer.exe /F").WaitForExit();
            Console.WriteLine("Updating FileSharingApp");
            gitPull();

        }

        private static void gitPull()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;

            using (var repo = new Repository(path))
            {
                LibGit2Sharp.PullOptions options = new LibGit2Sharp.PullOptions();
                options.FetchOptions = new FetchOptions();
                string mypass = Console.ReadLine();
                options.FetchOptions.CredentialsProvider = new CredentialsHandler(
                    (url, usernameFromUrl, types) =>
                        new UsernamePasswordCredentials()
                        {
                            Username = "gigglesbw4",
                            Password = mypass
                        });
                repo.Network.Pull(new Signature("gigglesbw4", "blakewrege1@gmail.com", new DateTimeOffset(DateTime.Now)), options);
            }
        }
    }
}