using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create_WORD : MonoBehaviour
{
    public Text afisare;
    public Text cuvant_ascuns;

    string[] cuvinte_easy = new string[] {"cat" , "room" , "hotel" , "dog" , "mom" 
        , "dance" , "today" , "tonight" , "hello" , "bye" , "white" , "yellow" , "smart" , "blue" ,
        "green" , "elevator" , "success" , "useful" , "beautiful"};
    string[] cuvinte_medii = new string[] { "rural" , "phenomenon" , "despicable" , "delightful" , "sixth" ,
        "accost" , "ambivalent", "assiduous" , "calumny" , "affix" , "awkward" , "cycle" , "staff",
        "arcade" , "happiness"};
    string[] cuvinte_grele = new string[] {"supercalifragilisticexpialidocious" , "onomatopoeia" , "jazz" , 
        "worcestershire" , "blandishment" ,  "thumbscrew" , "walkway" , "avenue" , "beekeeper" , "pneumonia" ,
        "lymph" , "pshaw" };
    string[] cuvinte_fun = new string[] { "cox", "nigeria" , "bombastic" ,  "part" , "hanga" , "bobarnac" ,
        "banana" , "spelunca" , "mataranga" , "mamata" , "balls" , "tudor" , "sex" , "cuc" , "penis" , "13lei",
        "super" , "cartofiserie" , "pulete" , "pulentiu" , "pulalau" , "pularau" , "sculament" ,
        "amongus" , "coiota" , "nuatatat" , "manaleindiene" , "basina" , "catelandru" , "puloi" , "potlogar",
        "mascarici" , "cal" , "bulangiu" , "pleonasm" , "cataclism" , "orfani" , "balustrada" , "picior" ,
        "pastarnac" , "natang" , "balerin" , "samachis" , "coiota" , "amogus" , "vaca" , "kashmir" , "ornitorinc",
        "fofoloanca" , "mangdal(mung-daal)" , "mihaita!=slab" , "caimac" , "miha" , "protopopitoricescovici" , 
        "papusoi" , "mici" , "lusia" , "bubuiala"};

    void Start()
    {
        string dificultate = PlayerPrefs.GetString("dificultate");
        string cuvant_cautat = "secs";
        int x;
        
        switch (dificultate)
        {
            case "easy":
                x = Random.Range(0, cuvinte_easy.Length - 1);
                cuvant_cautat = cuvinte_easy[x];
                break;
            case "medium":
                x = Random.Range(0, cuvinte_medii.Length - 1);
                cuvant_cautat = cuvinte_medii[x];
                break;
            case "hard":
                x = Random.Range(0, cuvinte_grele.Length - 1);
                cuvant_cautat = cuvinte_grele[x];
                break;
            case "fun":
                x = Random.Range(0, cuvinte_fun.Length - 1);
                cuvant_cautat = cuvinte_fun[x];
                break;
        }
        
        PlayerPrefs.SetString("cuvant", cuvant_cautat);
        afisare.text = cuvant_cautat;
        string s = "";
        for (int i = 0; i < cuvant_cautat.Length; i++)
            s += "_ ";
        PlayerPrefs.SetString("cuvant_ascuns", s);
        cuvant_ascuns.text = s;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
