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
      Assert.AreEqual("Eggs and Peanuts", Allergens.AllergenCheck(3));
    }

    [TestMethod]
    public void AllergenCheck_CheckIfAllergicToTheRest_AllTheStuff()
    {
      Assert.AreEqual("Eggs and Peanuts and Shellfish and Strawberries and Tomatoes and Chocolate and Pollen and Cats", Allergens.AllergenCheck(255));
    }
  }
}

