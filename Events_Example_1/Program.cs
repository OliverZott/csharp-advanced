// Event Handler - Example
// LINK: https://learn.microsoft.com/en-us/dotnet/standard/events/#related-articles

using Events_Example_1;

var counterEvent = new CounterEvent();

// assign event handler to an event
counterEvent.ThresholdReached += ThresholdReachedEventHandler;

Console.WriteLine("Starting event sample - waiting 2 seconds and raise event");
Thread.Sleep(2000);
counterEvent.OnThresholdReached(new ThresholdReachedArgs { Threshold = 2, TimeReached = DateTime.Now });


static void ThresholdReachedEventHandler(object? sender, EventArgs e)
{
    Console.WriteLine($"Threshold reached - object: '{sender}', EventArgs: '{e}'");
}