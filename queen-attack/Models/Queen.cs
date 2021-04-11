namespace Chess.Models
{
  public class Queen
  {
    public int[] Position { get; set; }
    public bool Captured { get; set; }
    public string Color { get; set; }
    
    public Queen(int[] position, bool captured, string color)
    {
      Position = position;
      Captured = captured;
      Color = color;
    }
  }
}
