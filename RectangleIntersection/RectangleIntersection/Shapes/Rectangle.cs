
namespace Geometry.Shapes
{
	/// <summary>
	/// A rectangular shape
	/// </summary>
	public class Rectangle
	{
		#region Ctor

		/// <summary>
		/// Create a Rectangle
		/// </summary>
		/// <param name="x1">The first X-coord</param>
		/// <param name="y1">The first Y-coord</param>
		/// <param name="x2">The second X-coord</param>
		/// <param name="y2">The second Y-coord</param>
		public Rectangle(int x1, int y1, int x2, int y2)
		{
			X1 = x1;
			X2 = x2;
			Y1 = y1;
			Y2 = y2;
		}

		#endregion

		#region Properties

		/// <summary>
		/// Get / set the first X-coord
		/// </summary>
		public int X1 { get; set; }
		/// <summary>
		/// Get / set the first Y-coord
		/// </summary>
		public int Y1 { get; set; }
		/// <summary>
		/// Get / set the second X-coord
		/// </summary>
		public int X2 { get; set; }
		/// <summary>
		/// Get / set the second Y-coord
		/// </summary>
		public int Y2 { get; set; }

		#endregion
	}
}
