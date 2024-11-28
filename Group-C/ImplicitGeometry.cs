using System.Drawing;

namespace Group_C;

public abstract class ImplicitGeometry
{
    public abstract bool IsInside(double x, double y);

    public void Visualize(int width, int height, double resolution)
    {
        var lines = new string[width];
        int lineIndex = 0;
        for (double i = 0; i < height; i += resolution)
        {
            var line = "";
            for (double j = 0; j < width; j++)
            {
                line += IsInside(i, j) ? "o" : " ";
            }

            lines[lineIndex] = line;
            lineIndex++;
        }

        File.WriteAllLines("output.txt", lines);

        Console.Write(File.ReadAllText("output.txt"));
    }
}