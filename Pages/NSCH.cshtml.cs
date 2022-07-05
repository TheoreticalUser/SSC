using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SSC.Models;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace SSC.Pages {

    public class NSCHModel : PageModel {
        private readonly Campus6Context _context;

        public NSCHModel(Campus6Context context) {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        public IActionResult OnGet() {
            if (Request.Cookies["SelfService"] == null) {
                return new RedirectToPageResult("/Error");
            }
            return Page();
        }

        public ActionResult OnPost() {
            return NSCHRedirect();
        }

        private string GetGID(string id) {
            string gid =
                 (from Person in _context.People where Person.PeopleCodeId.Equals(id) select Person.GovernmentId)
                 .SingleOrDefault();
            return gid;
        }

        private ActionResult NSCHRedirect() {
            string GID = GetGID(Id);
            const string user_id = "USER_ID";
            const string password = "PASSWORD";
            const string url = "https://secureapi.studentclearinghouse.org/sssportalui/authenticate";
            const string referer = "SERVER_ADDRESS";

            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = true;
                request.MaximumAutomaticRedirections = 5;
                request.ContentType = "application/x-www-form-urlencoded";
                request.Referer = referer;
                request.UserAgent = "msie 5.5";
                request.Method = "POST";

                Stream requestStream = request.GetRequestStream();
                StreamWriter requestWriter = new StreamWriter(requestStream);
                string requestMessage = "user_id=" + user_id + "&password=" + password + "&qu=" + GID;
                requestWriter.Write(requestMessage);
                requestWriter.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader responseReader = new StreamReader(responseStream);
                string responseMessage = responseReader.ReadToEnd();
                Response.WriteAsync(responseMessage);
                responseReader.Close();

                return Redirect(response.ResponseUri.AbsoluteUri);
            } 
            catch (Exception e) {
                return Redirect(e.StackTrace);
            }
        }
    }
}