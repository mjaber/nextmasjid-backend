using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace IbnMasjjed.DomainView.Models
{
    public class ReturnResult<T>
    {
        public T Data { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public bool IsSuccess
        {
            get { return this.HttpStatusCode == HttpStatusCode.OK; }
        }
        public List<string> Errors { get; set; } = new List<string>();

    }
}
