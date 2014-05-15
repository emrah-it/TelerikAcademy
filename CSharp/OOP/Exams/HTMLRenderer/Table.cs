namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Table : Element, ITable
    {
        private const string CloseCellTag = "</td>";
        private const string CloseRowTag = "</tr>";
        private const string OpenCellTag = "<td>";
        private const string OpenRowTag = "<tr>";
        private const string TableTag = "table";

        private int cols;
        private int rows;
        private IElement[,] table;

        public Table(int rows, int cols)
            : base(TableTag)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.table = new IElement[this.Rows, this.Cols];
        }

        public IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new NotSupportedException("This is not Supported in HTML table");
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Index must be possitive", "cols");
                }

                this.cols = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Index must be possitive", "cols");
                }

                this.rows = value;
            }
        }
        
        public override string TextContent
        {
            get
            {
                throw new NotSupportedException();
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateRowAndCol(row, col);

                return this.table[row, col];
            }

            set
            {
                this.ValidateRowAndCol(row, col);

                this.table[row, col] = value;
            }
        }

        public override void AddElement(IElement element)
        {
            throw new NotSupportedException();
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", TableTag);

            for (int i = 0; i < this.Rows; i++)
            {
                output.AppendFormat(OpenRowTag);

                for (int j = 0; j < this.Cols; j++)
                {
                    output.AppendFormat(OpenCellTag);

                    output.Append(this[i, j].ToString());

                    output.AppendFormat(CloseCellTag);
                }

                output.AppendFormat(CloseRowTag);
            }

            output.AppendFormat("</{0}>", TableTag);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }

        private void ValidateRowAndCol(int row, int col)
        {
            if (row < 0)
            {
                throw new ArgumentException("Index must be possitive number", "row");
            }

            if (col < 0)
            {
                throw new ArgumentException("Index must be possitive number", "col");
            }
        }
    }
}