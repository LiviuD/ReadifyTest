namespace ReadifyTestServices
{
    public interface IReverseWordService : IReadifyTestService
    {
        /// <summary>
        /// Reverses the sentence.
        /// </summary>
        /// <param name="sentence">The sentence.</param>
        /// <returns>The sentenced with reverse words</returns>
        string ReverseSentence(string sentence);
    }
}