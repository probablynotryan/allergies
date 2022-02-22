using System.Collections.Generic;

namespace Allergies.Model 
{
  public class Allergens
  {
    public static string AllergenCheck( int allergenNum )
    {
      List<string> aList = new List<string>();
      
      if (allergenNum > 127)
      {
        aList.Add("Cats");
        allergenNum = allergenNum - 128;
      }

      if (allergenNum > 63)
      {
        aList.Add("Pollen");
        allergenNum = allergenNum - 64;
      }
      
      if (allergenNum > 31)
      {
        aList.Add("Chocolate");
        allergenNum = allergenNum - 32;
      }
      
      if (allergenNum > 15)
      {
        aList.Add("Tomatoes");
        allergenNum = allergenNum - 16;
      }

      if (allergenNum > 7)
      {
        aList.Add("Strawberries");
        allergenNum = allergenNum - 8;
      }
     
      if (allergenNum > 3)
      {
        aList.Add("Shellfish");
        allergenNum = allergenNum - 4;
      }
      if (allergenNum > 1)
      {
        aList.Add("Peanuts");
        allergenNum = allergenNum - 2;
      }
      if ( allergenNum == 1 )
      {
        aList.Add("Eggs");
      }

      string output = string.Join(" and ", aList.ToArray());

      return output;
      //code here
    }
  }

}