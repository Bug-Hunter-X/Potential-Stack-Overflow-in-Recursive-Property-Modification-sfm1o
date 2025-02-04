public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        int temp = Value; //store the value before manipulation
        // Some logic here...
        if (temp > 10)
        {
            // Another logic here
            _value = temp + 1; // Update the backing field directly
        }
    }
}
