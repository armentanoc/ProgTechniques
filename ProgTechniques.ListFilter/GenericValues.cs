
namespace ProgTechniques.ListFilter
{
    internal class GenericValues<T>
    {
        // Vejo uma boa implementação dos conceito de lista de parâmetros e generics,
        // Entretando o papel dessa classe é dispensável, pois ela não faz nada além de 
        // delegar a ação para outra classe.
        // Há alguns poucos casos em que há benefício em se usar essa estratégia, mas esse 
        // não é um deles.
        // Isso é um code smell chamado Middle Man. dá uma pesquisada sobre o tema =)
        // https://www.devmedia.com.br/code-smells-conheca-antes-que-seja-tarde/39636
        //public static List<T> GenerateList(params T[] values)
        //{
        //    return new List<T>(values);
        //}
    }
}
