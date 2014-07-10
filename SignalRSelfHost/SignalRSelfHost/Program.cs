using System;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;

namespace SignalRSelfHost
{
   public class Program
    {
       private static ManualResetEvent m_quitEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            const string url = "http://localhost:9999";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on " + url);
                m_quitEvent.WaitOne();
            }
        }
    }
    
    public class Startup
        {
            public void Configuration(IAppBuilder app)
            {
                app.UseCors(CorsOptions.AllowAll);
                app.MapSignalR();
                app.UseWelcomePage(); 
            }
        }

        public class MyHub : Hub
        {
            public void Send(string name, string message)
            {
                Clients.All.addMessage(name, message); 
            }
        }
    }
