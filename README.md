# BlazorWasmHoster

If you use Blazor WASM for front-end web app, there are options to host it independently using NGINX/Apache, or using ASP.NET Core hosted. Choosing ASP.NET Core hosted will create separate Server & Client directory inside the same solution. It is ok if you want to use the <b>Server</b> project to do the backend things directly (like query the database etc). 

If you have separate API that manages the backend that used by this Blazor WASM (like me), it will be quite complex to create a `HttpClient` in the <b>Client</b> project that connected it to the different `HttpClient` in <b>Server</b> project that connect to external API. It's 2 different `HttpClient` that i need to maintain. Of course, i can create single `HttpClient` that used by <b>Client</b> and <b>Server</b> inside <b>Shared</b> project, but it is also not quite easy to maintain.

By using this solution, i can continue to create Blazor WASM standalone with only 1 `HttpClient`, and leave the internal hosting to the Minimal API's Kestrel server.

## To start
- Publish this Minimal API project.
- Publish your Blazor WASM project, then put the content of published "wwwroot" (in Blazor WASM) folder to the project "wwwroot" (in Minimal API) folder. The `web.config` file can be ignored.
- Set the desired port to for the Blazor WebAssembly standalone app to run.
- Execute the .exe file, or run `dotnet BlazorWasmHoster`.
