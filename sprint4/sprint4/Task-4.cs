interface IShape : ICloneable
{
    double Area() => 0f;
}

class Rectangle : IShape
{
    double Length { get; set; }
    double Width { get; set; }

    double Area() => Length * Width;
    public Object Clone() => this.MemberwiseClone();
}

class Trapezoid : IShape
{
    double Length1 { get; set; }
    double Length2 { get; set; }
    double Width { get; set; }
    double Area () => 0.5 * (Length1 + Length2) * Width;
    public Object Clone() => this.MemberwiseClone();
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

//class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
//{
//    public int Compare(Room<T> x, Room<T> y)
//    {
//        if (x.Volume() > y.Volume())
//            return 1;
//        else if (x.Volume() > y.Volume())
//            return -1;
//        else return 0;
//    }
//}