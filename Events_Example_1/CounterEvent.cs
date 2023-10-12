namespace Events_Example_1;

// An event is a message sent by an object to signal the occurrence of an action.
// The action can be caused by user interaction, such as a button click,
// or it can result from some other program logic, such as changing a property's value.
public class CounterEvent
{
    // The following example shows how to declare an event named ThresholdReached.
    // The event is associated with the EventHandler delegate and raised in a method named OnThresholdReached.
    public event EventHandler? ThresholdReached;

    public virtual void OnThresholdReached(ThresholdReachedArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }
}

// public delegate void ThresholdReached(object sender, ThresholdReachedArgs args);

public class ThresholdReachedArgs : EventArgs
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
}