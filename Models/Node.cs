// using Blazor.Diagrams.Core.Geometry;
// using Blazor.Diagrams.Core.Models;
// using System.Collections.Generic;
// using System.Linq;

// public class Table : NodeModel
//     {
//         public Table(Point position = null) : base(position, RenderLayer.HTML)
//         {
//             Propss = new List<Props>
//             {
//                 new Props
//                 {
//                     Name = "Id",
//                     Type = PropsType.Integer,
//                     Primary = true
//                 },
//                 new Props
//                 {
//                     Name = "Test",
//                     Type = PropsType.Integer
//                 }
//             };

//             AddPort(Propss[0], PortAlignment.Right);
//             AddPort(Propss[1], PortAlignment.Left);
//         }

//         public string Name { get; set; } = "Table";
//         public List<Props> Propss { get; }
//         public bool HasPrimaryProps => Propss.Any(c => c.Primary);

//         public PropsPort GetPort(Props Props) => Ports.Cast<PropsPort>().FirstOrDefault(p => p.Props == Props);

//         public void AddPort(Props Props, PortAlignment alignment) => AddPort(new PropsPort(this, Props, alignment));
//     }