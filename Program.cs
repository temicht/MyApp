var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", timestamp = DateTime.UtcNow }));
app.MapGet("/version", () => Results.Ok(new { appName = "MyApp", version = "1.0.2-lab12" }));
app.MapGet("/api/notes", () => Results.Ok(new List<object>()));
app.MapGet("/db/ping", () => Results.Ok(new { connected = false, message = "not configured" }));

app.Run();