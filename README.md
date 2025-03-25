---
title: Blazor Razden charts and dependency injection demo
author: Risto
---
# Razden charts and dependency injection demo

Uses Radzen version 6.3.2 library for Blazor
NuGet: Radzen.Blazor 


## Configure Razden


```csharp
...
builder.Services.AddRadzenComponents();
builder.Services.AddRadzenQueryStringThemeService();
...
```

> Note: Add following to every razor page using Razden 

```csharp
@rendermode InteractiveServer 

```



## Configure services

Simulates API data fetch using injected Singleton service; IndexService.

> Note: Add interface to enable unit testing!

```csharp
...
builder.Services.AddSingleton<IndexService>();
...
```


