﻿using Blazor.Diagrams.Core.Geometry;
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
                    Primary = true
                },
                new Column
                {
                    Name = "Number",
                    Type = ColumnType.Integer
                },
                new Column
                {
                    Name = "Name",
                    Type = ColumnType.String
                },
                new Column
                {
                    Name = "Description",
                    Type = ColumnType.String
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
