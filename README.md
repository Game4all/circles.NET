<div align="center">
<h1><code>circles.NET</code></h1>
An asynchronous <b>.NET Standard wrapper</b> for the <b>osu! api</b>
</div>

## Get Started
```csharp

using circles.NET;

class SampleProgram
    {
        static async Task Main(string[] args)
        {
            //Getting user information on Cookieizi
            var x = new CirclesAPIClient("<YOUR API KEY HERE>");
            var user = x.GetUsersAsync("Cookiezi");

            foreach (var field in typeof(APIUser).GetProperties())
            {
                Console.WriteLine($"{field.Name}: {field.GetValue(user[0])}");
            }
            Console.ReadLine();
        }
    }

```

## Documentation
[Markdown documentation avalaible](circles.NET/doc/API.md)

