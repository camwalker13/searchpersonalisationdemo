using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchPersoConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Parameter validation
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass an email address parameter");
                return;
            }

            var email = args[0];
            const string EMAIL_REGEX = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (!Regex.IsMatch(email, EMAIL_REGEX))
            {
                Console.WriteLine("Passed parameter should be a valid email address");
                return;
            }

            string term = null;
            if(args.Length > 1)
                term = args[1];
            #endregion

            Console.WriteLine("Getting search model for user " + email);
            var searchModel = await GetModelForUserAsync(email);
            Console.WriteLine("Search Model calculated: " + searchModel);

            Console.WriteLine("Getting search results");
            var searchResults = await GetSearchResultsAsync(searchModel, term);

            if (!(searchResults is null))
                RenderResult(searchResults);

        }

        private static async Task<string> GetModelForUserAsync(string email)
        {
            #region secrets values
            const string CLIENT_KEY = "psfu6uh05hsr9c34rptlr06dn864cqrx";
            #endregion
            const string BASE_URL = "https://api.boxever.com/v2/callFlows";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // client key a string like "psfu6uh...................4cqrx"
            var REQUEST_BODY = @"{
                    ""clientKey"": """ + CLIENT_KEY + @""",
                    ""channel"": ""WEB"",
                    ""language"": ""EN"",
                    ""currencyCode"": ""AUD"",
                    ""email"": """ + email + @""",
                    ""friendlyId"": ""search_segment""
                }";

            var requestBody = new StringContent(REQUEST_BODY, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(BASE_URL, requestBody);

            result.EnsureSuccessStatusCode();

            var raw = await result.Content.ReadAsStringAsync();

            Console.WriteLine("Result from " + BASE_URL);
            Console.WriteLine(raw);

            var parsedResult =
                JsonSerializer.Deserialize<DecisionResult>(raw);

            return parsedResult.SearchModel;
        }
        
        private static async Task<IEnumerable<Doc>> GetSearchResultsAsync(string searchModel, string term)
        {
            var username = "app40-api";
            #region secrets
            var password = "8BbY^@tA96av";
            #endregion
            var requestUrl = "https://ss849763-cvrfzabx-us-east-1-aws.searchstax.com/solr/ss849763-SearchStudioCorpSite/emselect?q=" + (string.IsNullOrWhiteSpace(term) ? "*" : term);

            var client = new HttpClient();

            var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            if (!string.IsNullOrWhiteSpace(searchModel))
                requestUrl = $"{requestUrl}&model={searchModel}";

            var streamTask = client.GetStreamAsync(requestUrl);

            var results = await JsonSerializer.DeserializeAsync<SearchResult>(await streamTask);

            if (results != null && results.response != null && results.response.docs != null)
                return results.response.docs;
            else return null;

        }

        private static void RenderResult(IEnumerable<Doc> results, int maxToDisplay=10)
        {
            int i = 1; 
            
            foreach(var d in results)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Result {i}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Title: {d.title[0]}");
                Console.ResetColor();
                Console.WriteLine($"Type: {d.content_type[0]}");
                Console.WriteLine($"Paths: {d.paths[0]}");
                Console.WriteLine();
                
                i++;
                if (i > maxToDisplay) break;
            }

        }

    }
}

// 