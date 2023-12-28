// using Blazor.Diagrams.Core.Models;
// using System.Text.Json.Serialization;

// public class PropsPort : PortModel
// {
//     public PropsPort(NodeModel parent, Props Props, PortAlignment alignment = PortAlignment.Bottom)
//         : base(parent, alignment, null, null)
//     {
//         Props = Props;
//     }

//     [JsonIgnore]
//     public Props Props { get; }

//     public override bool CanAttachTo(PortModel port)
//     {
//         // Avoid attaching to self port/node
//         if (!base.CanAttachTo(port))
//             return false;

//         var targetPort = port as PropsPort;
//         var targetProps = targetPort.Props;

//         if (Props.Type != targetProps.Type)
//             return false;

//         if (Props.Primary && targetProps.Primary)
//             return false;

//         if (Props.Primary && targetPort.Links.Count > 0 ||
//             targetProps.Primary && Links.Count > 1) // Ongoing link
//             return false;

//         return true;
//     }
// }