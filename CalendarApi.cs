﻿using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace InTheDeep
{
    internal static class CalendarApi
    {



        //Moon Phases Calendar ☾🌕☽📅
        public static void MoonCalendar()
        {
            //Place API Key here...\/
            const string ApiKey = "";
            const string CalenderId = "ht3jlfaac5lfd6263ulfh4tql8@group.calendar.google.com";

            async Task Calender(string[] args)
            {
                Console.WriteLine();

                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    ApiKey = ApiKey,
                    ApplicationName = "API key"
                });

                var request = service.Events.List(CalenderId);
                request.Fields = "items(summary, start,end)";
                var response = await request.ExecuteAsync();

                Console.ReadLine();
            }
        }
    }
}