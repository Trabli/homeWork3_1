using System;

namespace homeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int imagesQuantity = 52;
            int rowOfImages;
            int extraImages;

            rowOfImages = imagesQuantity / 3;
            extraImages = imagesQuantity % 3;

            Console.WriteLine("У пользователя альбом с 52-мя картинками.");
            Console.WriteLine("Их нужно вывести на экран по 3 в ряд, и узнать остаток картинок.");
            Console.WriteLine("Картинки можно вывести в " + rowOfImages + " рядов");
            Console.WriteLine(extraImages + " картинка не влезет в ряды и будет в остатке");

        }
    }
}
