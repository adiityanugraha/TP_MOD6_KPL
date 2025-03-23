// See https://aka.ms/new-console-template for more information
using System;
public class Program {
    public static void Main() {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Anak Agung Aryadipa Aditya Nugraha");

        video.IncreasePlayCount(100);

        video.PrintVideoDetails();
    }
}

