using RestSharp;
using SpecFlowProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProjectApi.Services
{
    public class AuthorService
    {
        private readonly string BaseUrl = "http://fakerestapi.azurewebsites.net/api";

        public IRestResponse GetAuthors()
        {
            var cliente = new RestClient(BaseUrl + "Authors");
            var restRequest = new RestRequest(Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            return cliente.Execute(restRequest);
        }

        public void GetAuthors(int id)
        {

        }

        public void PostAuthors(Author author)
        {

        }

        public void PutAuthors(Author author)
        {

        }

        public void DeleteAuthors(int id)
        {

        }
    }
}
