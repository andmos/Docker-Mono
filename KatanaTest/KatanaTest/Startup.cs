using Owin;

namespace KatanaTest
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseWelcomePage();
		}
	}
}
