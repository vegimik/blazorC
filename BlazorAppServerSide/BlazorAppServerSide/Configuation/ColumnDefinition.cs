namespace BlazorAppServerSide.Configuation
{
    public class ColumnDefinition
    {
        public string DataField { get; set; }
        public string Caption { get; set; }
        public DataType DataType { get; set; }
        public string Format { get; set; }
        public Alignment Alignment { get; set; }
        public SortDirection SortDirection { get; set; }

        public ColumnDefinition()
        {
            this.DataType = DataType.NotSet;
            this.Alignment = Alignment.NotSet;
        }
    }
}
