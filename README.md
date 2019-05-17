<div align="center">
<h1><code>circles.NET</code></h1>
An asynchronous <b>.NET Standard wrapper</b> for the <b>osu! api</b>
<br/>
<img alt="Nuget" src="https://img.shields.io/nuget/dt/circles.NET.svg?color=lightblue&label=Downloads&logo=nuget&logoColor=lightblue&link=https://www.nuget.org/packages/circles.NET/"/>
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

