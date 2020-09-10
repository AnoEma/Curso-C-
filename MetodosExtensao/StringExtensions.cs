namespace MetodosExtensao
{
    public static class StringExtensions
    {
        public static string InverterCaixas(this string frase)
        {
            bool isUpperCase = true;
            string resultado = "";

            for (int i = 0; i < frase.Length; i++)
            {
                resultado += isUpperCase ? frase[i].ToString().ToUpper() : frase[i].ToString().ToLower();
                isUpperCase = !isUpperCase;
            }
            return resultado;
        }
    }
}