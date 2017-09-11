# Animated ASCII art

bron: http://stackoverflow.com/questions/2725529/how-to-create-ascii-animation-in-windows-console-application-using-c

- De `Image`-class ondersteund animated gifs.
- Een `StringBuilder` wordt gebruikt om elk frame tijdeljk op te slaan.
- De RGB-kleur-waardes worden omgezet naar een grijstint en
- vervolgens omgezet naar 1 v.d. 11 gedefinieerde ASCII-karakters.
- Elk frame wordt 100 ms getoond.

```
class Program
{
    static void Main(string[] args)
    {
        Image image = Image.FromFile(@"C:\some_animated_gif.gif");
        FrameDimension dimension = new FrameDimension(
                           image.FrameDimensionsList[0]);
        int frameCount = image.GetFrameCount(dimension);
        StringBuilder sb;

        // Remember cursor position
        int left = Console.WindowLeft, top = Console.WindowTop;

        char[] chars = { '#', '#', '@', '%', '=', '+', 
                         '*', ':', '-', '.', ' ' };
        for (int i = 0; ; i = (i + 1) % frameCount)
        {
            sb = new StringBuilder();
            image.SelectActiveFrame(dimension, i);

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color cl = ((Bitmap)image).GetPixel(w, h);
                    int gray = (cl.R + cl.G + cl.B) / 3;
                    int index = (gray * (chars.Length - 1)) / 255;

                    sb.Append(chars[index]);
                }
                sb.Append('\n');
            }

            Console.SetCursorPosition(left, top);
            Console.Write(sb.ToString());

            System.Threading.Thread.Sleep(100);
        }
    }
}
```

