// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp.ViewModel.Common;

namespace Calculator.Tests
{
    [TestClass]
    public class NavCategoryTests
    {
        [TestMethod]
        public void OnlyGeneralCalculatorIsAvailable()
        {
            var menuOptions = NavCategoryStates.CreateMenuOptions();

            Assert.AreEqual(1, menuOptions.Count);

            var calculatorGroup = (NavCategoryGroup)menuOptions[0];
            Assert.AreEqual(CategoryGroupType.Calculator, calculatorGroup.GroupType);
            Assert.AreEqual(1, calculatorGroup.Categories.Count);
            Assert.AreEqual(ViewMode.Standard, calculatorGroup.Categories[0].ViewMode);

            Assert.IsTrue(NavCategoryStates.IsValidViewMode(ViewMode.Standard));
            Assert.IsTrue(NavCategory.IsCalculatorViewMode(ViewMode.Standard));
            Assert.IsFalse(NavCategoryStates.IsValidViewMode(ViewMode.Scientific));
            Assert.IsFalse(NavCategoryStates.IsValidViewMode(ViewMode.Programmer));
            Assert.IsFalse(NavCategoryStates.IsValidViewMode(ViewMode.Graphing));
            Assert.IsFalse(NavCategoryStates.IsValidViewMode(ViewMode.Date));
            Assert.IsFalse(NavCategoryStates.IsValidViewMode(ViewMode.Currency));
        }
    }
}
