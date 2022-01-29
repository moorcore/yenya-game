// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;
// using UnityEditor;

// public class PrefabVariantAutomationScript
// {
//     [MenuItem("Util/Create Variants")]
//     static void CreateVariants()
//     {
//         List<string> letters = new List<string>() {
//             "1 Общая моторика", "2 мелкая моторика", "3 Артикуляция (общий курс)", "4 Артикуляция- гласные буквы", 
//             "5 СЗЦ", "6 ШЧЩ", "7 Л", "8 Р"
//         };
//         letters.ForEach((letter) => {
//             string letterPath = "Assets/Images/" + letter + "/";

//             Object sourcePrefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Предмет.prefab", typeof(GameObject));
//             List<Sprite> inputSprites = new List<Sprite>();

//             var assets = AssetDatabase.FindAssets("t:Sprite", new[] {letterPath + "Sprites"});
//             foreach (var guid in assets) {
//                 inputSprites.Add(AssetDatabase.LoadAssetAtPath<Sprite>(AssetDatabase.GUIDToAssetPath(guid)));
//             }
            
//             inputSprites.ForEach((spr) => {
//                 Debug.Log(letter + " " + spr.name);
//                 string name = spr.name.Substring(spr.name.IndexOf(" ")).Trim();
//                 name = name.First().ToString().ToUpper() + name.Substring(1);

//                 GameObject variantToBe = (GameObject)PrefabUtility.InstantiatePrefab(sourcePrefab);

//                 variantToBe.name = name + " Variant";
//                 variantToBe.GetComponent<SpriteRenderer>().sprite = spr;
//                 ItemScript itemScript = variantToBe.GetComponent<ItemScript>();
//                 itemScript.letter = letter;
//                 itemScript.itemName = name;

//                 string localPath = letterPath + "Prefabs/" + variantToBe.name + ".prefab";
//                 localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

//                 GameObject obj = PrefabUtility.SaveAsPrefabAsset(variantToBe, localPath);
//                 GameObject.DestroyImmediate(variantToBe);
//             });
//         });
//     }
// }