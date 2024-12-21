namespace Classtask2._9;

public class swap
{
    public void MySwap<T>(ref T a, ref T b)
    {
        T ad = a;
        a = b;
        b = ad;
    }
}
