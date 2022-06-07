namespace RequestTask;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;

public class RequestMethod{
    
    private static readonly HttpClient client = new HttpClient();
    
    public static async Task<List<Repository>> ProcessRepositories()
    {
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

    //GetStreamAsync Send a GET request to the specified Uri and return the response body as a stream in an asynchronous operation
    var streamTask = client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
    // in this case as the DeserializeAsync is a generic method, we need to pass a type to know which kind of objet will be created from the JSON Text
    var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(await streamTask);

    return repositories;
    
    }

}
