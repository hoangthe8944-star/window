using System.Drawing;

namespace blockblast
{
    public class Egg
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Speed { get; set; }
        public Color EggColor { get; set; }
        public int Radius { get; set; } = 15;

        public Egg(float x, float speed, Color color)
        {
            X = x;
            Y = -30; // Bắt đầu ở ngoài màn hình phía trên
            Speed = speed;
            EggColor = color;
        }

        public void Fall() => Y += Speed;
    }
}