using SharedPackage;

namespace Package2;
public class ClassPackage2
{
    public void UseSharedPackageMethod()
    {
        Class1 test = new Class1();
        test.PrintHelloWorld();
    }
}
