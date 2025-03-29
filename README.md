---
title: Blazor Razden charts, HTTP client and dependency injection demo
author: Risto
---
# Razden charts, HTTP client and dependency injection demo

Uses Radzen version 6.3.x charting library for Blazor

NuGet: Radzen.Blazor


## Configure Razden


```csharp
...
builder.Services.AddRadzenComponents();
builder.Services.AddRadzenQueryStringThemeService();
...
```

> Note: Add following to every Razor page using Razden 

```csharp
@rendermode InteractiveServer 
```



## Configure services

Simulates API data fetch using injected Singleton service; IndexService.

> Note: Add interface to enable unit testing!

```csharp
builder.Services.AddSingleton<IndexService>();
```

## Use HttpClientFactory 

Add client to services


```csharp
builder.Services.AddHttpClient("HttpGenericClient", client => {
    client.Timeout = TimeSpan.FromMinutes(1);
});
```

Inject IHttpClientFactory to Razor page


```csharp
@inject IHttpClientFactory _httpClientFactory
```

Pass factory created HTTP client to generic HTTP data service class


```csharp
var _httpClient = _httpClientFactory.CreateClient("HttpGenericClient");
HttpGenericClient<CoinModel[]> client = new HttpGenericClient<CoinModel[]>(_httpClient);
```
