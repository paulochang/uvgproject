using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System.Threading;


namespace UVGProject.Calendar
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
               new ClientSecrets
               {
                   ClientId = "836857798906-v62gcavjo521p4jjulhtnal4q9iqop0g.apps.googleusercontent.com",
                   ClientSecret = "x47KLrfujdF7KQymyFfcNLg8",
               },
               new[] { CalendarService.Scope.Calendar },
               "user",
               CancellationToken.None).Result;

            // Create the service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Calendar Test",
            });


        }


        protected void onClickB(object sender, EventArgs e)
        {
            Response.Redirect("nuevaTarea.aspx", false);
        }

    }
}