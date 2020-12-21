using RA.Net;
using System.Collections.Generic;
using System;

namespace myhelloworld.main.api
{
    public class Api
    {
        
        private RA.RestAssured _ra = new RA.RestAssured();
        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        private string _host, _uri, _body;
        private int _code;

        public Api(string Endpoint, string Uri) {
            SetDefaults();
            SetHost(Endpoint);
            setUri(Uri);            
        }

        public Api(string Endpoint) {
            SetDefaults();
            SetHost(Endpoint);
        }

        public Api() {
            SetDefaults();
            SetHost("http://127.0.0.1:8080/");
        }

        private Api SetDefaults() {
            AddHeader("Content-Type", "application/json");
            AddHeader("Accept-Encoding", "gzip, deflate");
            SetCode(200);
            return this;
        }

        public Api AddHeader(string header, string type) {
            try 
            {
            _headers.Add(header, type);
            } catch (Exception) {}
            return this;
        }

        public Api ClearHeaders() {
            _headers.Clear();
            return this;
        }

        public Api SetHost(string host) {
            _host = host;
            return this;
        }

        public Api setUri(string uri) {
            _uri = uri;
            return this;
        }

        public Api SetUri(string baseUri, string queryUri) {
            _uri = baseUri + queryUri;
            return this;
        }

        public Api SetCode(int code) {
            _code = code;
            return this;
        }

        public Api setBody(string body) {
            _body = body;
            return this;
        }

        private void buildHeaders(ref RA.SetupContext context) {
            foreach(var header in _headers)
            {
                context.Header(header.Key, header.Value);
            }
        
        }

        public void Post() {
            var builder = _ra.Given();
            buildHeaders(ref builder);
            builder = builder.Host(_host)
                             .Uri(_uri)
                             //.Query("apikey", "ca7f6e91ee8134de9717707d86b29100")
                             .Body(_body);

            var request = builder.When()
                                 .Post()
                                 .Then()
                                    .TestStatus("codResponse", x => x == _code);
                                    //.TestBody("msg", y => y.result.msg == "Your response message");

            //request.AssertAll();
        }

        public RA.ResponseContext Get() {
            var builder = _ra.Given();
            buildHeaders(ref builder);
            builder = builder.Host(_host)
                             .Uri(_uri)
                             //.Query("apikey", "ca7f6e91ee8134de9717707d86b29100")
                             .Body(_body);
            var request = builder.When()
                                 .Get()
                                 .Then();
            return request;
                                    //.TestStatus("codResponse", x => x == _code);
        }

    }
}