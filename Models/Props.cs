// using System;

// public class Props
// {
//     public event Action Changed;

//     public string Name { get; set; }
//     public PropsType Type { get; set; }
//     public bool Primary { get; set; }

//     public void Refresh() => Changed?.Invoke();
// }

// public enum PropsType
// {
//     Boolean,
//     Char,
//     String,
//     SByte,
//     Short,
//     Integer,
//     Long
// }