using System; 
using System.Text; 
using System.Collections.Generic;


namespace Allergies.Model 
{
  public class Allergens
  {
    public static string AllergenCheck( double allergenNum )
    {
      List<string> aList = new List<string>();

      List<string> allergens = new List<string>{"Eggs", "Peanuts", "Shellfish", "Strawberries", "Tomatoes", "Chocolate", "Pollen", "Cats"};


      for ( int i = 7; i >= 0; i-- ){
        if( allergenNum >= Math.Pow(2, i) ){
          aList.Add(allergens[i]);
          allergenNum -= Math.Pow(2, i);
        }
      }
      
      string output = string.Join(" and ", aList.ToArray());
      return output;
     
    }
  }

}