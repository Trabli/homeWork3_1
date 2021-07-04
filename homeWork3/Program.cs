using System;

namespace homeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int images_inOneRow = 3;
            int images_InAlbum = 52;

            int row_WithImages = images_InAlbum / images_inOneRow;
            int imagesLeft = images_InAlbum % images_inOneRow;

            Console.WriteLine("У пользователя альбом с " + images_InAlbum + "-мя картинками.");
            Console.WriteLine("Их нужно вывести на экран по " + images_inOneRow + " в ряд, и узнать остаток картинок.");
            Console.WriteLine("Картинки можно вывести в " + row_WithImages + " рядов");
            Console.WriteLine(imagesLeft + " картинка не влезет в ряды и будет в остатке");
        }
    }
}
