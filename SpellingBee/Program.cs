var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

var words = new[]
{
    "abrupt", "accomplish", "accurate", "achieve", "acquire",
    "adequate", "adjacent", "admire", "adolescent", "advantage",
    "advocate", "aggravate", "algorithm", "allocate", "ambiguous",
    "ancient", "anonymous", "apparent", "appetite", "appreciate",
    "appropriate", "arithmetic", "assemble", "authority", "awkward",
    "balance", "beautiful", "beginning", "believe", "benefit",
    "boundary", "breathe", "brief", "brilliant", "burden",
    "calendar", "campaign", "capable", "category", "celebrate",
    "character", "circumstance", "collaborate", "colleague", "column",
    "commitment", "communicate", "community", "comparison", "competition",
    "confident", "conscience", "conscious", "consequence", "considerable",
    "continuous", "contribute", "convenience", "cooperate", "courageous",
    "criticize", "curriculum", "cylinder", "deceive", "decision",
    "dedicated", "democracy", "describe", "desperate", "determine",
    "develop", "different", "diligent", "disappear", "discipline",
    "discover", "distinguish", "dominant", "elaborate", "eloquent",
    "embarrass", "emphasize", "encourage", "enormous", "enthusiasm",
    "environment", "essential", "estimate", "evidence", "exceptional"
};

var random = new Random();

app.MapGet("/api/word", () =>
{
    var word = words[random.Next(words.Length)];
    return Results.Ok(new { word });
});

app.Run();
