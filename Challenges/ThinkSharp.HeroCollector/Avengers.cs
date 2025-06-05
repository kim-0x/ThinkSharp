using System.Collections;

public class Avengers : IEnumerator<string>
{
    public string Current { get; private set; } = "";

    object IEnumerator.Current => Current;

    public IEnumerator<string> GetEnumerator()
    {
        return new Avengers();
    }

    private void SetString0()
    {
        Current = "Thor";
    }

    private void SetString1()
    {
        Current = "Iron Man";
    }

    private void SetString2()
    {
        Current = "Hulk";
    }

    private int _step = 0;
    public bool MoveNext()
    {
        switch (_step)
        {
            case 0:
                SetString0();
                ++_step;
                break;
            case 1:
                SetString1();
                ++_step;
                break;
            case 2:
                SetString2();
                ++_step;
                break;
            default:
                return false;
        }
        return true;
    }

    public void Reset()
    {
        _step = 0;
        Current = "";
    }

    public void Dispose()
    {
        // nothing to clean up
    }
}