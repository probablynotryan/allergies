using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Model;

namespace Allergies.Test
{

  [TestClass]
  public class AllergenTest
  {
    [TestMethod]
    public void AllergenCheck_CheckIfAllergicToEggs_Eggs()
    {
      Assert.AreEqual("Eggs", Allergens.AllergenCheck(1));
    }

    [TestMethod]
    public void AllergenCheck_CheckIfAllergicToPeanutsAndEggs_PeanutsAndEggs()
    {
      Assert.AreEqual("Peanuts", Allergens.AllergenCheck(2));
      Assert.AreEqual("Peanuts and Eggs", Allergens.AllergenCheck(3));
    }

    [TestMethod]
    public void AllergenCheck_CheckIfAllergicToTheRest_AllTheStuff()
    {
      Assert.AreEqual("Cats and Pollen and Chocolate and Tomatoes and Strawberries and Shellfish and Peanuts and Eggs", Allergens.AllergenCheck(255));
    }
  }
}

