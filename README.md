# BlazorWasmHoster
A simple ASP.NET Core Kestrel server app that can host Blazor WASM standalone app! 

## Tech
- .NET 8 LTS
- Minimal API

## To start
- Clone this repo.
- Publish this Minimal API project.
- Publish your Blazor WASM project, then:
  - Put the content of published "wwwroot" (in Blazor WASM) folder to the Minimal API's "wwwroot".
  - The `web.config` file can be ignored.
- Set the desired port to for the Blazor WASM standalone app to run.
- Execute the .exe file, or run `dotnet BlazorWasmHoster.dll`.

## Why?
Blazor WASM standalone app can be hosted as static page using NGINX, or can also hosted using ASP.NET Core. Choosing ASP.NET Core hosted will create separate Server & Client projects inside the same solution. It is ok if you want to use the <b>Server</b> project to do the backend things directly (like query the database etc). Blazor WASM standalone is using `HttpClient` to communicate to the backend.

I have a separate API that used by this Blazor WASM as backend, so need to maintain 2 separate `HttpClient`, one in <b>Client</b> project and one in <b>Server</b> project. The `HttpClient` in <b>Server</b> is used to connect to the external API. To minimize the complexity, I can create single `HttpClient` in <b>Shared</b> project then use it in <b>Client</b> & <b>Server</b> project respectively, but things like authentication for different project is quite hard to handle.

As a different solution, i created this project that is purely by very basic ASP.NET Core Minimal API that can serve Blazor WASM standalone static files, at the same time able to configure which port my web app run. I can now only maintain 1 `HttpClient`, and leave the internal hosting to the Minimal API's Kestrel server. NGINX can also used as reverse proxy later.


