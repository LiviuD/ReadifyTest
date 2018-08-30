namespace ReadifyTestServices
{
    public interface ITriangleService : IReadifyTestService
    {
        /// <summary>
        /// Gets the type of the triangle.
        /// </summary>
        /// <param name="a">The lenght a.</param>
        /// <param name="b">The length b.</param>
        /// <param name="c">The the length c.</param>
        /// <returns>The type of triangle or Error</returns>
        string GetTriangleType(int a, int b, int c);
    }
}