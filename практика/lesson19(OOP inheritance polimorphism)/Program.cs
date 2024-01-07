B b = new();
b.Foo();
C c = new();
c.Foo();
public abstract class A
{
    public virtual void Foo()
    {
        Console.WriteLine("A.Foo()");
    }
}

public sealed class B : A
{
    public new void Foo()
    {
    }
}

public class C : A
{
    public override void Foo()
    {
        Console.WriteLine("C.Foo()");
    }
}

