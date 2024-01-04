using Blazor.Diagrams.Core.Geometry;
using Blazor.Diagrams.Core.Models;

namespace Blazorwasm.Models
{
    public class Table : NodeModel
    {
        public Table(Point position = null) : base(position)
        {
            Columns = new List<Column>
            {
                new Column
                {
                    Name = "Id",
                    Type = ColumnType.Integer,
                    Primary = true,
                    Value = "1"
                },
                new Column
                {
                    Name = "Type",
                    Type = ColumnType.String,
                    Value = "CDG"
                },
                new Column
                {
                    Name = "Value",
                    Type = ColumnType.String,
                    Value = "156"
                },
                new Column
                {
                    Name = "Description",
                    Type = ColumnType.String,
                    Value = "Blazor Diagrams Core"
                }
            };

            AddPort(Columns[0], PortAlignment.Right);
            AddPort(Columns[1], PortAlignment.Left);
        }

        public string Name { get; set; } = "Table";
        public List<Column> Columns { get; }
        public bool HasPrimaryColumn => Columns.Any(c => c.Primary);

        public ColumnPort GetPort(Column column) => Ports.Cast<ColumnPort>().FirstOrDefault(p => p.Column == column);

        public void AddPort(Column column, PortAlignment alignment)
        {
            var port = new ColumnPort(this, column, alignment);
            AddPort(port);
        }
    }
}
