using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;

public class Yokomoji : MonoBehaviour
{
    private const string A3RT_URL = "https://api.a3rt.recruit-tech.co.jp/text_summarization/v1?";
    private static readonly HttpClient _httpClient = new HttpClient();
    public string Yokomoji2(string sss)
    {
    const string apiKey = "AIzaSyBPxA1m448_aK5KfF839Us3hpwi53zy8Us";
        const string searchEngineId = "f231fdf9686d6bd30";
        string query = sss;
        CustomsearchService customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
        CseResource.ListRequest listRequest = customSearchService.Cse.List();
        listRequest.Cx = searchEngineId;
        listRequest.Q = query;
        List<string> linksReturned = new List<string>();
        IList<Result> paging = new List<Result>();
        paging = listRequest.Execute().Items;
        string str = "";
        foreach (var item in paging)
        {
            str = item.Snippet;
            break;
        }
        return str;
    }
}