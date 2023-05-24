using TestLibrary;

var internalClass = new InternalClass();
internalClass.PrivateMethod();
Console.WriteLine(internalClass.PrivateProperty);
internalClass.PrivateAutoProperty = 123;
Console.WriteLine(internalClass.PrivateAutoProperty);

var thirdClass = new ThirdClass();
thirdClass.Methods();

class ThirdClass : SecondClass
{
    public void Methods()
    {
        ProtectedVirtualMethod();
        ProtectedAbstractMethod();
    }

    protected override void ProtectedVirtualMethod()
    {
        Console.WriteLine("ThirdClass.ProtectedVirtualMethod");
        base.ProtectedVirtualMethod();
    }

    protected override void ProtectedAbstractMethod()
    {
        Console.WriteLine("ThirdClass.ProtectedAbstractMethod");
    }
}