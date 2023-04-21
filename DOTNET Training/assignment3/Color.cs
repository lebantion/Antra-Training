public class Color {
    private int red;
    private int green;
    private int blue;
    private int alpha;

    public Color(int red, int green, int blue, int alpha = 255) {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }

   public int Red
    {
        get { return red; }
        set 
        {
            if (value >= 0 && value <= 255)
            {
                red = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Red value must be between 0 and 255");
            }
        }
    }

    public int Green
    {
        get { return green; }
        set 
        {
            if (value >= 0 && value <= 255)
            {
                green = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Green value must be between 0 and 255");
            }
        }
    }

    public int Blue
    {
        get { return blue; }
        set 
        {
            if (value >= 0 && value <= 255)
            {
                blue = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Blue value must be between 0 and 255");
            }
        }
    }

    public int Alpha
    {
        get { return alpha; }
        set 
        {
            if (value >= 0 && value <= 255)
            {
                alpha = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Alpha value must be between 0 and 255");
            }
        }
    }

    public int GetGrayscaleValue() {
        return (red + green + blue) / 3;
    }
}