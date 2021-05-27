using System.Text;

namespace Raindrops
{
    public static class Raindrops
    {
        public static string GetFactorResult(int n)
        {
            StringBuilder sb = new StringBuilder();
            if (n % 3 == 0) { sb.Append("Pling"); }
            if (n % 5 == 0) { sb.Append("Plang"); }
            if (n % 7 == 0) { sb.Append("Plong"); }


            return sb.ToString() == "" ? n.ToString() : sb.ToString();
        }
    }
}
