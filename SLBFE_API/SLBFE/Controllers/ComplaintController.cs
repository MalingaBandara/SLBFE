﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLBFE.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ComplaintController : ApiController
    {
        /// <summary>
        /// This function will return all the complaints 
        /// </summary>
        /// <returns>Complaints List</returns>
        // GET: api/Complaint
        public List<Models.Complaint> GetAllComplaints()
        {
            return Models.DataStore.GetComplaints();
        }

        /// <summary>
        /// Gets complaint as 10 for a page
        /// </summary>
        /// <param name="page">Page Number</param>
        /// <returns>10 objects that bel;ongs to that page</returns>
        [Route("api/Complaint/Page/{page:int}")]
        [HttpGet]
        public List<Models.Complaint> GetComplaints(int page)
        {
            var complaintList = Models.DataStore.GetComplaints();

            if (complaintList.Count < page * 10)
            {
                // if it is no values on the page
                // send an empty list
                // this can be detected by the client and show no complaintas left
                return new List<Models.Complaint>();
            }
            else if (complaintList.Count < page * 10 + 10)
            {
                // this means there are no values for 10 from this page
                // to avoid the index out of range error, 
                // we will get how many values left fitst

                var listCount = complaintList.Count;
                var index = page * 10;
                var valuesLeft = listCount - index; //count 56/ Requested page 5 = 50 / 56-50 = 50

                return complaintList.GetRange(page * 10, valuesLeft);
            }
            else
            {
                return complaintList.GetRange(page * 10, 10);
            }

        }

        /// <summary>
        /// This will return the complaints as a list
        /// where the email is equal
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <returns></returns>
        // GET: api/Complaint/email.sample.com
        public List<Models.Complaint> GetComplaintsFor(string email)
        {
            var complaints = Models.DataStore.GetComplaints();
            return complaints.Where(c => c.Email == email).ToList();
        }

        /// <summary>
        /// This will return the complaints as a list
        /// where the email is equal
        /// And 10 for a page
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <param name="page">Page Number</param>
        /// <returns></returns>
        // GET: api/Complaint/email.sample.com
        [Route("api/Complaints/{email}/{page}")]
        [HttpGet]
        public List<Models.Complaint> GetComplaintsFor(string email, int page)
        {
            var complaints = Models.DataStore.GetComplaints();

            if (complaints.Count < page * 10)
            {
                // if it is no values on the page
                // send an empty list
                // this can be detected by the client and show no complaintas left
                return new List<Models.Complaint>();
            }
            else if (complaints.Count < page * 10 + 10)
            {
                // this means there are no values for 10 from this page
                // to avoid the index out of range error, 
                // we will get how many values left fitst

                var listCount = complaints.Count;
                var index = page*10;
                var valuesLeft = listCount - index; //count 56/ Requested page 5 = 50 / 56-50 = 50

                return complaints.Where(c => c.Email == email).ToList().GetRange(page * 10, valuesLeft);
            }
            else
            {
                return complaints.Where(c => c.Email == email).ToList().GetRange(page * 10, 10);
            }
        }

        /// <summary>
        /// This will return the complaints as a list
        /// where the email is equal
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <returns></returns>
        // GET: api/Complaint/email.sample.com
        [Route("api/Company/Complaints")]
        [HttpGet]
        public List<Models.Complaint> GetComplaintsForCompany(string email)
        {
            var complaints = Models.DataStore.GetComplaints();
            return complaints.Where(c => c.CompanyID == email).ToList();
        }

        /// <summary>
        /// This will return the complaints as a list
        /// where the email is equal
        /// And 10 for a page
        /// </summary>
        /// <param name="email">Email of the User</param>
        /// <param name="page">Page Number</param>
        /// <returns></returns>
        // GET: api/Complaint/email.sample.com
        [Route("api/Company/Complaints/{email}/{page}")]
        [HttpGet]
        public List<Models.Complaint> GetComplaintsForCompany(string email, int page)
        {
            var complaints = Models.DataStore.GetComplaints();

            if (complaints.Count < page * 10)
            {
                // if it is no values on the page
                // send an empty list
                // this can be detected by the client and show no complaintas left
                return new List<Models.Complaint>();
            }
            else if (complaints.Count < page * 10 + 10)
            {
                // this means there are no values for 10 from this page
                // to avoid the index out of range error, 
                // we will get how many values left fitst

                var listCount = complaints.Count;
                var index = page * 10;
                var valuesLeft = listCount - index; //count 56/ Requested page 5 = 50 / 56-50 = 50

                return complaints.Where(c => c.CompanyID == email).ToList().GetRange(page * 10, valuesLeft);
            }
            else
            {
                return complaints.Where(c => c.CompanyID == email).ToList().GetRange(page * 10, 10);
            }
        }

        /// <summary>
        /// Add a new Complaint
        /// </summary>
        /// <param name="value">Complaint Object</param>
        /// <returns>Status 1 for success 0 for failed</returns>
        // POST: api/Complaint
        public int NewComplaint([FromBody]Models.Complaint value)
        {
            return Models.DataStore.NewComplaint(value);
        }

        /// <summary>
        /// Reply for the complaint
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns>0 - Failed, 1 - Success, -1 - Failed due to DB Error, -2 Failed due to input data or db connection error</returns>
        // PUT: api/Complaint/5
        public int NewReply(string id, [FromBody]Models.ComplaintReply value)
        {
            return Models.DataStore.ReplyComplaint(id, value);
        }

        /// <summary>
        /// Deletes the complaints from the database
        /// </summary>
        /// <param name="id">Complaint ID</param>
        /// <returns>0 - Failed, 1 - Success, -1 - Failed due to DB Error, -2 Failed due to input data or db connection error</returns>
        // DELETE: api/Complaint/5
        public int DeleteComplaint(string id)
        {
            return Models.DataStore.DeleteComplaint(id);
        }

        /// <summary>
        /// Deletes the Reply from th3 database
        /// </summary>
        /// <param name="complaintID">Unique ID of the complaint</param>
        /// <param name="replyID">Unique ID of the Reply</param>
        /// <returns>0 - Failed, 1 - Success, -1 - Failed due to DB Error, -2 Failed due to input data or db connection error</returns>
        // DELETE: api/Complaint/5
        public int DeleteReply(string complaintID, string replyID)
        {
            return Models.DataStore.DeleteComplaintReply(complaintID, replyID);
        }
    }
}
