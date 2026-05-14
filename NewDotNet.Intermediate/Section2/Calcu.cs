namespace NewDotNet.Intermediate.Section2;


public interface IOperation
{
    string Symbol { get; }
    double Execute(double num1, double num2);
}
// public static class Calcu
// {
//     public static Add : IOperation
//     {
//         public static string Symbol => "+";
//
//         public static double Execute(double num1, double num2)
//         {
//             return num1 + num2;
//         }
//     }
// }