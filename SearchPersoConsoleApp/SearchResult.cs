
public class SearchResult
{
    public Responseheader responseHeader { get; set; }
    public Response response { get; set; }
    public Facet_Counts facet_counts { get; set; }
    public Highlighting highlighting { get; set; }
    public Metadata metadata { get; set; }
}

public class Responseheader
{
    public bool zkConnected { get; set; }
    public int status { get; set; }
    public int QTime { get; set; }
    public Params _params { get; set; }
}

public class Params
{
    public string spellcheckdictionary { get; set; }
    public string hl { get; set; }
    public string echoParams { get; set; }
    public string fl { get; set; }
    public string fauthor_namefacetsort { get; set; }
    public string defType { get; set; }
    public string qf { get; set; }
    public string fcontent_type_facetfacetsort { get; set; }
    public string model { get; set; }
    public string wt { get; set; }
    public string[] facetfield { get; set; }
    public string fcontent_type_facetfacetlimit { get; set; }
    public string fauthor_namefacetmincount { get; set; }
    public string rows { get; set; }
    public string fcontent_type_facetfacetmincount { get; set; }
    public string spellcheckextendedResults { get; set; }
    public string hlsnippets { get; set; }
    public string q { get; set; }
    public string fmeta_keywordsfacetmincount { get; set; }
    public string spellcheck { get; set; }
    public string spellcheckaccuracy { get; set; }
    public string fmeta_keywordsfacetsort { get; set; }
    public string fmeta_keywordsfacetlimit { get; set; }
    public string spellcheckcount { get; set; }
    public string fauthor_namefacetlimit { get; set; }
    public string facet { get; set; }
    public string uniqueId { get; set; }
}

public class Response
{
    public int numFound { get; set; }
    public int start { get; set; }
    public Doc[] docs { get; set; }
}

public class Doc
{
    public string[] content_type { get; set; }
    public string url { get; set; }
    public string[] title { get; set; }
    public string[] paths { get; set; }
    public string[] content { get; set; }
}

public class Facet_Counts
{
    public Facet_Queries facet_queries { get; set; }
    public Facet_Fields facet_fields { get; set; }
    public Facet_Ranges facet_ranges { get; set; }
    public Facet_Intervals facet_intervals { get; set; }
    public Facet_Heatmaps facet_heatmaps { get; set; }
}

public class Facet_Queries
{
}

public class Facet_Fields
{
    public object[] meta_keywords { get; set; }
    public object[] content_type_facet { get; set; }
    public object[] author_name { get; set; }
}

public class Facet_Ranges
{
}

public class Facet_Intervals
{
}

public class Facet_Heatmaps
{
}

public class Highlighting
{
    public HttpsWwwSearchstaxComDocsSearchstudioSitecoreSxa2 httpswwwsearchstaxcomdocssearchstudiositecoresxa2 { get; set; }
    public HttpsWwwSearchstaxComDocsSearchstudioThemeEditor httpswwwsearchstaxcomdocssearchstudiothemeeditor { get; set; }
    public HttpsWwwSearchstaxComDocsSearchstudioMultiSiteCrawling httpswwwsearchstaxcomdocssearchstudiomultisitecrawling { get; set; }
    public HttpsSupportSearchstaxComHcEnUsRestrictedReturn_ToHttps3A2F2FsupportSearchstaxCom2Fhc2FenUs httpssupportsearchstaxcomhcenusrestrictedreturn_tohttps3A2F2Fsupportsearchstaxcom2Fhc2Fenus { get; set; }
    public HttpsWwwSearchstaxComSitecoreAzureToSolrMigrationHsctatrackingD3c82a0c4D014Cd690991A63f0ddcb567C88478411Dca4448DB88b429A393a2a81 httpswwwsearchstaxcomsitecoreazuretosolrmigrationhsCtaTrackingd3c82a0c4d014cd690991a63f0ddcb567C88478411dca4448db88b429a393a2a81 { get; set; }
    public HttpsWwwSearchstaxComDocsSearchstudioSearchExperience httpswwwsearchstaxcomdocssearchstudiosearchexperience { get; set; }
    public HttpsAppSearchstaxComLoginNextAdminSsoConfigureSaml2 httpsappsearchstaxcomloginnextadminssoconfiguresaml2 { get; set; }
    public HttpsWwwSearchstaxComDocsSearchstudioSearchjs httpswwwsearchstaxcomdocssearchstudiosearchjs { get; set; }
    public HttpsWwwSearchstaxComDocsHccategorySolrTopics httpswwwsearchstaxcomdocshccategorysolrtopics { get; set; }
    public HttpsWwwSearchstaxComDocsHccategoryIntegrations httpswwwsearchstaxcomdocshccategoryintegrations { get; set; }
    public HttpsWwwSearchstaxComDocsHccategoryApis httpswwwsearchstaxcomdocshccategoryapis { get; set; }
    public HttpsWwwSearchstaxComDocsHccategoryUsersAndRoles httpswwwsearchstaxcomdocshccategoryusersandroles { get; set; }
}

public class HttpsWwwSearchstaxComDocsSearchstudioSitecoreSxa2
{
}

public class HttpsWwwSearchstaxComDocsSearchstudioThemeEditor
{
}

public class HttpsWwwSearchstaxComDocsSearchstudioMultiSiteCrawling
{
}

public class HttpsSupportSearchstaxComHcEnUsRestrictedReturn_ToHttps3A2F2FsupportSearchstaxCom2Fhc2FenUs
{
}

public class HttpsWwwSearchstaxComSitecoreAzureToSolrMigrationHsctatrackingD3c82a0c4D014Cd690991A63f0ddcb567C88478411Dca4448DB88b429A393a2a81
{
}

public class HttpsWwwSearchstaxComDocsSearchstudioSearchExperience
{
}

public class HttpsAppSearchstaxComLoginNextAdminSsoConfigureSaml2
{
}

public class HttpsWwwSearchstaxComDocsSearchstudioSearchjs
{
}

public class HttpsWwwSearchstaxComDocsHccategorySolrTopics
{
}

public class HttpsWwwSearchstaxComDocsHccategoryIntegrations
{
}

public class HttpsWwwSearchstaxComDocsHccategoryApis
{
}

public class HttpsWwwSearchstaxComDocsHccategoryUsersAndRoles
{
}

public class Metadata
{
    public Facet[] facets { get; set; }
    public Result[] results { get; set; }
    public Sort[] sorts { get; set; }
}

public class Facet
{
    public string name { get; set; }
    public string label { get; set; }
}

public class Result
{
    public string name { get; set; }
    public string title { get; set; }
    public string result_card { get; set; }
}

public class Sort
{
    public int id { get; set; }
    public string name { get; set; }
    public string order { get; set; }
    public string label { get; set; }
}
