namespace MyNancy
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.Diagnostics;
    using Nancy.TinyIoc;
    //using Nancy.Authentication.Token;
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
     //   protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
    //    {
            //TokenAuthentication.Enable(pipelines, new TokenAuthenticationConfiguration(container.Resolve<Nancy.Authentication.Token.ITokenizer>()));
      //  }

        /// <summary>
        /// Don't know, just added it
        /// Used for diagnostic purposes
        /// </summary>
        protected override DiagnosticsConfiguration DiagnosticsConfiguration
        {
            get { return new DiagnosticsConfiguration { Password = @"A2\6mVtH/XRT\p,B" }; }
        }
    }
}