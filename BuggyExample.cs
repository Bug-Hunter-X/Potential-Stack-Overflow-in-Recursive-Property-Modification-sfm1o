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
        // Some logic here...
        if (Value > 10) 
        {
            // Another logic here
            Value = Value + 1;
        }
    }
}