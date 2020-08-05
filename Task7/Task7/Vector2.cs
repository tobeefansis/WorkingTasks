using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public struct Vector2
    {
        public float x;
        public float y;

        public static Vector2 right => new Vector2(1, 0);
        public static Vector2 left => new Vector2(-1, 0);
        public static Vector2 down => new Vector2(0, -1);
        public static Vector2 up => new Vector2(0, 1);
        public static Vector2 one => new Vector2(1, 1);
        public static Vector2 zero => new Vector2(0, 0);

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator ++(Vector2 a)
        {
            return new Vector2(a.x + 1, a.y + 1);
        }
        public static Vector2 operator --(Vector2 a)
        {
            return new Vector2(a.x - 1, a.y - 1);
        }
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return b.x == a.x &&
                   b.y == a.y;
        }
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return b.x != a.x ||
                   b.y != a.y;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2 vector &&
                   x == vector.x &&
                   y == vector.y;
        }

        public override int GetHashCode()
        {
            int hashCode = 1502939027;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"(x={x},y={y})";
        }


    }
}
