# BraveFish.Framework

This is technically not designed for public use, it's just a Nuget package source repository for the author to setup default handlers like exception handler responses, model state validation, logging, etc. basically to speed up initial setup for webapi development.

## Response Wrapper

A static class for wrapping Controller response in a standardized format. The response format is as follows:
```json
{
    "data": "generic",
    "status": "string"
}
```

Wrap success response like so:
```c#
[HttpPost]
[Route("create")]
public BaseResponseModel<Book> CreateBook([FromBody] BookCreateRequestModel createRequest)
{
    var createdBook = new Book
    {
        Id = Guid.NewGuid(),
        Title = createRequest.Title,
        Author = createRequest.Author,
        Genres = createRequest.Genres,
        Rating = createRequest.Rating
    };
    return ResponseWrapper.WrapSuccess(createdBook);
}
```

Wrap failed response like so:
```c#
return ResponseWrapper.WrapFailure(status)
```


## Controller Model State Validator

When model state is invalid, it will not reach the controller and will instead respond with a format described above using a customizable `status`. An example in .NET6 webapi is shown below:

```c#
builder.Services.AddControllers().ConfigureApiToBaseBehaviour(
    new ApiBaseBehaviourConfigBuilder()
        .SetInvalidModelStateResponseStatus("BadRequest")
        .Build());
```

## Console Logger using Serilog

A default console logger can be setup using the example code below:

```c#
builder.Logging.AddBaseConsoleLogger();
```