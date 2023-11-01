interface IShape
{
    double Area() => 0;
}

interface ICloneable
{
    object Clone();
}

interface IComparable<T>
{
    int CompareTo(T other);
}

interface IComparer<T>
{
    int Compare(T obj1, T obj2);
}

class Rectangle : IShape
{
    double Length { get; set; }
    double Width { get; set; }

    double Area() => Length * Width;
}

class Trapezoid : IShape
{
    double Length1 { get; set; }
    double Length2 { get; set; }
    double Width { get; set; }
    double Area () => 0.5 * (Length1 + Length2) * Width;
    
}

class Room<T> where T : IShape, ICloneable, IComparable
{
    double Heigth { get; set; }
    T Floor{ get; set;}

    public double Volume() => Floor.Area() * Heigth;

    public object Clone()
    {
        return new Room<T>
        {
            Heigth = this.Heigth,
            Floor = this.Floor
        };
    }

    public int CompareTo(object obj)
    {
        Room<T> room = obj as Room<T>;
        if (obj != null) return this.Floor.Area().CompareTo(room.Floor.Area());
        else throw new Exception("Error");
    }
}

class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
{
    public int Compare(Room<T> x, Room<T> y)
    {
        if (x == null || y == null)
        {
            throw new ArgumentNullException("One or both of the rooms to compare are null.");
        }

        return x.Volume().CompareTo(y.Volume());
    }
}
//class RoomComparerByVolume<T> : IComparer<Room> where T : IShape
//{
//    public int Compare(T room1, T room2)
//    {
//        if (room1 == null || room2 == null)
//        {
//            throw new ArgumentNullException("One or both of the rooms to compare are null.");
//        }

//        if(room1.)
//    }
//}