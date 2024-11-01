# BlazorWasmHoster

If you use Blazor WASM, there are option to host it using ASP.NET Core hosted, but it require the separate Server & Client directory inside the same solution. It is ok if you want to use the Server project to directly query database (for example). I have a separate REST API project (different solution) that serve this Blazor WebAssembly app, so the communication is happened through HTTP API.

## To start
- Publish your Blazor WASM project, then put the content of published "wwwroot" folder to the project "wwwroot" folder.
- Set the desired port for the Blazor WebAssembly standalone app to run.
- Execute the .exe file, or run `dotnet BlazorWasmHoster`
