# Polymorfie met shapes

We willen dit kunnen doen:

```
public partial class MainWindow : Window
{
	List<Shape> shapes = new List<Shape>();

	public MainWindow()
	{
		InitializeComponent();

		shapes.Add(new Square(20, 20));
		shapes.Add(new Square(30, 50));
		shapes.Add(new Circle(40, 40));
		shapes.Add(new Circle(100, 100));
	}

	private void button_Click(object sender, RoutedEventArgs e)
	{ 
		foreach(var shape in shapes)
		{
			shape.DisplayOn(canvas);
		}
	}
}
```

Let vooral op de lijst van Shapes en de `foreach`-method die volledig
onafhankelijk zijn van de overervende classes : zij hebben geen kennis
nodig over de overervende classes.

## Abstract class Shape

De abstracte method `DisplayOn` maakt van `Shape` een abstracte class.
Het is aan de overervende classes om zichzelf te tekenen.

```
public abstract class Shape
{
	protected int x;
	protected int y;
	protected int size = 75;
	protected Brush brush = new SolidColorBrush(Colors.Black);

	public abstract void DisplayOn(Canvas drawArea);
}
```

## Class Square

```
public class Square : Shape
{
	private Rectangle rect;

	public Square(int initX, int initY)
	{
		x = initX;
		y = initY;
	}

	public override void DisplayOn(Canvas drawArea)
	{
		rect = new Rectangle();
		rect.Stroke = brush;
		rect.Width = size;
		rect.Height = size;
		rect.Margin = new Thickness(x, y, 0, 0);

		drawArea.Children.Add(rect);
	}
}
```

## Class Circle

Maak op gelijkaardige wijze een `Circle`-class

