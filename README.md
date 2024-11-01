# BlazorWasmHoster

If you use Blazor WASM for front-end web app, there are options to host it independently using NGINX/Apache, or using ASP.NET Core hosted. Choosing ASP.NET Core hosted will create separate Server & Client directory inside the same solution. It is ok if you want to use the <b>Server</b> project to do the backend things directly (like query the database etc). 

If you have separate API that manages the backend that used by this Blazor WASM (like me), it will be quite complex to create a `HttpClient` in the <b>Client</b> project that connected it to the different `HttpClient` in <b>Server</b> project that connect to external API. Of course, you can host the standalone Blazor WASM using NGINX or Apache, but that's different story.

## To start
- Publish this Minimal API project.
- Publish your Blazor WASM project, then put the content of published "wwwroot" (in Blazor WASM) folder to the project "wwwroot" (in Minimal API) folder. The `web.config` file can be ignored.
- Set the desired port to for the Blazor WebAssembly standalone app to run.
- Execute the .exe file, or run `dotnet BlazorWasmHoster`.
