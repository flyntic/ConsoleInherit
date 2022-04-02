using System;
using System.Runtime.InteropServices;

namespace ConsoleInherit
{
    public abstract class Figur
    {
        public string Name;
        public abstract float Square();
        public abstract float Perimetr();

        public Figur(string name)
        {
            this.Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Фигура - "+Name+" Площадь "+Square()+" Периметр "+Perimetr());
        }

    }

    public class FTriangle : Figur
    {
        public int[] Sides;

        public FTriangle(string name, int[] sides) : base(name)
        {
            this.Sides=new int[3];
            this.Sides= (int[]) sides.Clone();
        }

        public override float Perimetr()
        {
            return (Sides[0] + Sides[1] + Sides[2]);
        }

        public override float Square()
        {
            float p = Perimetr()/2;
            return (float) ( Math.Sqrt(p*(p-Sides[0])*(p- Sides[1])*(p- Sides[2]))) ;
        }
    }
    public class FRectangle : Figur
    {
        public int[] Sides;

        public FRectangle(string name, int[] sides) : base(name)
        {
            this.Sides=new int[2];
            this.Sides= (int[]) sides.Clone();
        }

        public override float Perimetr()
        {
            return (Sides[0] + Sides[1])*2;
        }

        public override float Square()
        {
           
            return ( Sides[0]*Sides[1]) ;
        }
        
    }

    public class FSquare : Figur
    {
        public int Side;

        public FSquare(string name, int side) : base(name)
        {

            this.Side = side;
        }

        public override float Perimetr()
        {
            return (Side * 4);
        }

        public override float Square()
        {

            return (Side * Side);
        }
    }
    
    public class FComposite 
    {
        public List<Figur> figures;

        public FComposite(params Figur[] F)
        {
            figures = new List<Figur>();
            foreach (var item in F)
            {
                figures.Add(item);
            }
        }

        public float Square()
        {
            float s = 0;
            foreach (var item in figures)
            {
                s += item.Square();
            }

            return s;
        }

        public void Print()
        {
            Console.WriteLine("площадь всех фигур = "+Square());
            
        }
    }
}
