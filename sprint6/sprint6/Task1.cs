using System.Collections;
using System.Collections.Generic;

public class CircleOfChildren
{
    private List<string> childrenList;

    public CircleOfChildren(IEnumerable<string> ichildren)
    {
        childrenList = new List<string>(ichildren);
    }

    public IEnumerable GetChildrenInOrder(int syllables, int count = 0)
    {
        if (syllables <= 0)
        {
            yield break ;
        }
        else
        {


            int currentIndex = 0;
            for (int i = childrenList.Count; i > 0; i--)
            {
                currentIndex = (currentIndex + syllables - 1) % i;
                yield return childrenList[currentIndex];
                childrenList.RemoveAt(currentIndex);

                if (--count == 0) { break; }
            }
        }
    }
}

public class OutputUtils
{
    public static void ExitOutput(CircleOfChildren circle, int syllables, int count = 0)
    {
        foreach (var child in circle.GetChildrenInOrder(syllables, count))
        {
            Console.Write(child + " ");
        }
    }
}

class p
{
    static void Main(string[] args)
    {
        IEnumerable<string> children = new List<string> { "Halya1", "Olya2", "Ira3", "Andriy4", "Josh5" };
        CircleOfChildren circle = new CircleOfChildren(children);

        int syllables = 0;
        int count = 6;

        foreach (var child in circle.GetChildrenInOrder(syllables, count))
        {
            Console.WriteLine(child);
        }
    }
}