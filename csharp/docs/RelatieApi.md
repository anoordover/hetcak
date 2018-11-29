# IO.Swagger.Api.RelatieApi

All URIs are relative to *https://hetcak.nl/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetRelatiesByPersoonId**](RelatieApi.md#getrelatiesbypersoonid) | **GET** /personen/persoon/relaties/{persoonId}/ | Relaties bij een persoon ophalen


<a name="getrelatiesbypersoonid"></a>
# **GetRelatiesByPersoonId**
> Persoon GetRelatiesByPersoonId (int? persoonId, DateTime? opdrachtdatum, string xCakOrigin, DateTime? xCakCreationdate, string xCakMessageid, string xCakRequestid, string xCakBusinessobject, string xCakBusinessid, string xCakUserid = null, string xCakCallbackurl = null, string xCakPreviousrequestid = null, string xCakAuthorization = null, string xCakInformation = null)

Relaties bij een persoon ophalen

Geeft de relaties bij een persoon terug

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRelatiesByPersoonIdExample
    {
        public void main()
        {
            var apiInstance = new RelatieApi();
            var persoonId = 56;  // int? | nummer van de persoon
            var opdrachtdatum = 2013-10-20;  // DateTime? | 
            var xCakOrigin = xCakOrigin_example;  // string | 
            var xCakCreationdate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var xCakMessageid = xCakMessageid_example;  // string | 
            var xCakRequestid = xCakRequestid_example;  // string | 
            var xCakBusinessobject = xCakBusinessobject_example;  // string | 
            var xCakBusinessid = xCakBusinessid_example;  // string | 
            var xCakUserid = xCakUserid_example;  // string |  (optional) 
            var xCakCallbackurl = xCakCallbackurl_example;  // string |  (optional) 
            var xCakPreviousrequestid = xCakPreviousrequestid_example;  // string |  (optional) 
            var xCakAuthorization = xCakAuthorization_example;  // string |  (optional) 
            var xCakInformation = xCakInformation_example;  // string |  (optional) 

            try
            {
                // Relaties bij een persoon ophalen
                Persoon result = apiInstance.GetRelatiesByPersoonId(persoonId, opdrachtdatum, xCakOrigin, xCakCreationdate, xCakMessageid, xCakRequestid, xCakBusinessobject, xCakBusinessid, xCakUserid, xCakCallbackurl, xCakPreviousrequestid, xCakAuthorization, xCakInformation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RelatieApi.GetRelatiesByPersoonId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **persoonId** | **int?**| nummer van de persoon | 
 **opdrachtdatum** | **DateTime?**|  | 
 **xCakOrigin** | **string**|  | 
 **xCakCreationdate** | **DateTime?**|  | 
 **xCakMessageid** | **string**|  | 
 **xCakRequestid** | **string**|  | 
 **xCakBusinessobject** | **string**|  | 
 **xCakBusinessid** | **string**|  | 
 **xCakUserid** | **string**|  | [optional] 
 **xCakCallbackurl** | **string**|  | [optional] 
 **xCakPreviousrequestid** | **string**|  | [optional] 
 **xCakAuthorization** | **string**|  | [optional] 
 **xCakInformation** | **string**|  | [optional] 

### Return type

[**Persoon**](Persoon.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

