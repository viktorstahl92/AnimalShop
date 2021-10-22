using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShop
{
    public enum DogBreed
    {
        German_Shepard,
        Labrador_Retriever,
        Airedale_Terrier,
        Siberian_Husky,
        Golden_Retriever,
        Chihuahua,
        Rottweiler,
        Dobermann,
        American_Pit_Bull_Terrier
    }

    public enum CatBreed
    {
        Persian_cat,
        Bengal_cat,
        Norwegian_Forest_cat,
        Maine_Coon,
        Siamese_cat,
        Sphynx_cat
    }

    public static class Utilities
    {
        public static string ReplaceeUnderlineWithSpaceString(string inString) => inString.ToString().Replace('_', ' ');
    }

}