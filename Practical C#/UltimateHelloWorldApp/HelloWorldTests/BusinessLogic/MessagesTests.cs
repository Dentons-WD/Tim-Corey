using HelloWorldLibrary.BusinessLogic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace HelloWorldTests.BusinessLogic;

public class MessagesTests
{
    [Fact]
    public void Greeting_InEnglish()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();
        Messages messages = new(logger);

        string expected = "Hello World";
        string actual = messages.Greeting("en");

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Greeting_InSpanish()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();
        Messages messages = new(logger);

        string expected = "Hola Mundo";
        string actual = messages.Greeting("es");

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Greeting_Invalid()
    {
        ILogger<Messages> logger = new NullLogger<Messages>();
        Messages messages = new(logger);

        Assert.Throws<InvalidOperationException>(
            () => messages.Greeting("test")
            );  
    }
}
