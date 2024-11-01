# BlazorWasmHoster

If you use Blazor WASM, there are option to host it using ASP.NET Core hosted, but it require the separate Server & Client directory inside the same solution. It is ok if you want to use the Server project to do the backend things directly (like query the database etc). If you have separate API that manages the backend (like me), it will be quite complex to create the `HttpClient` in the <b>Client</b> project, that connected it to the different `HttpClient` in <b>Server</b> project that connect to external API. Of course, you can host the standalone Blazor WASM using NGINX or Apache, but that's different story.

## To start
- Publish your Blazor WASM project, then put the content of published "wwwroot" folder to the project "wwwroot" folder.
- Set the desired port for the Blazor WebAssembly standalone app to run.
- Execute the .exe file, or run `dotnet BlazorWasmHoster`
