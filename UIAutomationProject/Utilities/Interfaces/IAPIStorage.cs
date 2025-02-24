
public interface IAPIStorage
{
    public string BaseUrl { get; set; }
    public HttpClient httpClient { get; set; }
    public HttpResponseMessage response { get; set; }

    public HttpResponseMessage GetResponse(string baseURL);
}

