// Толстопятов В.А 4 курс 9 группа ПММ
//  Лабораторная работа номер 4. Принцип подстановки Лисков.
// H. География, геология и метеорология, рекреационные ресурсы, туризм, полезные ископаемые

namespace Good
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GeographicalFeature> features = new List<GeographicalFeature>();

            Mountain mountain = new Mountain("Гималаи");
            OceanAbyss bezdna = new OceanAbyss("Марианская впадина");

            features.Add(bezdna);
            features.Add(mountain);

            foreach (var feature in features)
            {
                try
                {
                    feature.TourToTourist();
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}