using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVGProject.Calendar
{
    public partial class nuevaTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        private async Task Run()
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

            Event newEvent = new Event();

            newEvent.Summary = 
            newEvent.Description = "Need to meet my Uncle";

            IList<EventReminder> reminders = new List<EventReminder>();
            reminders.Add(new EventReminder { Method = "sms", Minutes = 10 });
            newEvent.Reminders = new Event.RemindersData { UseDefault = false, Overrides = reminders };

            newEvent.Recurrence = new String[] { "DTSTART;TZID=Bangladesh Standard Time:20140124T163000;RRULE:FREQ=DAILY" };

            IList<EventAttendee> attendees = new List<EventAttendee>();
            attendees.Add(new EventAttendee { Email = "hannan.cse.m@gmail.com", Organizer = true, DisplayName = "Hannan" });
            newEvent.Attendees = attendees;

            newEvent.GuestsCanInviteOthers = false;
            newEvent.GuestsCanModify = false;
            newEvent.GuestsCanSeeOtherGuests = false;
            newEvent.Location = "Dhaka, Bangladesh";
            newEvent.Start = new EventDateTime { DateTime = DateTime.Now, TimeZone = "Bangladesh Standard Time" };

            Event recurringEvent = service.Events.Insert(newEvent, "primary").Execute();

            var list = await service.CalendarList.List().ExecuteAsync();
        
        }

        protected void clickSave(object sender, EventArgs e) 
        {
            try
            {
                new nuevaTarea().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var el in ex.InnerExceptions)
                {
                    Console.WriteLine("ERROR: " + el.Message);
                }
            }
        }
    }
}