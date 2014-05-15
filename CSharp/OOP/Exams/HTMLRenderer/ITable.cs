namespace HTMLRenderer
{
    public interface ITable : IElement
    {
        int Cols { get; }

        int Rows { get; }

        IElement this[int row, int col] { get; set; }
    }
}