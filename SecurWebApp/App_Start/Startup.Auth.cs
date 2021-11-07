using System;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using SecurWebApp.Models;
using SecurWebApp.Providers;

namespace SecurWebApp
{
    public class AuthStartup
    {
        private static OAuthAuthorizationServerOptions OAuthOptions { get; set; }

        private static string PublicClientId { get; set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            // Enable the application to use a cookie to store information for the signed in user
            // and to use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseCookieAuthentication(options: new CookieAuthenticationOptions
            {
                AuthenticationType = null,
                AuthenticationMode = AuthenticationMode.Active,
                Description = null,
                CookieName = null,
                CookieDomain = null,
                CookiePath = null,
                CookieHttpOnly = false,
                CookieSameSite = null,
                CookieSecure = CookieSecureOption.SameAsRequest,
                ExpireTimeSpan = default,
                SlidingExpiration = false,
                LoginPath = default,
                LogoutPath = default,
                ReturnUrlParameter = null,
                Provider = null,
                TicketDataFormat = null,
                SystemClock = null,
                CookieManager = null,
                SessionStore = null
            });
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId)
                {
                    OnMatchEndpoint = null,
                    OnValidateClientRedirectUri = null,
                    OnValidateClientAuthentication = null,
                    OnValidateAuthorizeRequest = null,
                    OnValidateTokenRequest = null,
                    OnGrantAuthorizationCode = null,
                    OnGrantResourceOwnerCredentials = null,
                    OnGrantClientCredentials = null,
                    OnGrantRefreshToken = null,
                    OnGrantCustomExtension = null,
                    OnAuthorizeEndpoint = null,
                    OnTokenEndpoint = null,
                    OnAuthorizationEndpointResponse = null,
                    OnTokenEndpointResponse = null
                },
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                // In production mode set AllowInsecureHttp = false
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}