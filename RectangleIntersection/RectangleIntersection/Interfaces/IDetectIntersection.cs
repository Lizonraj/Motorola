using Geometry.Shapes;

namespace Geometry.Interfaces
{
	/// <summary>
	/// Contract for all classes which are able to detect intersection between geometric shapes
	/// </summary>
	public interface IDetectIntersection
	{
		/// <summary>
		/// Determines whether two rectangles intersect
		/// </summary>
		/// <param name="rectangle1">The first rectangle</param>
		/// <param name="rectangle2">The second rectangle</param>
		/// <returns>True if the rectangles intersect, else, false.</returns>
		/// <exception cref="ArgumentException">Thrown if either rectangle is null</exception>
		bool DoesIntersect(Rectangle rectangle1, Rectangle rectangle2);
	}
}
