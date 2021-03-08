using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddFiltrsInMagazine.EfContex
{
    public static class Seeder
    {
        public static void SeedDatabase(EFContext context)
        {


            SeedFilter(context);
        }


        #region Фільтри
        private static void SeedFilter(EFContext context)
        {
            #region tblFilterNames - Назви фільтрів
            string[] filterNames = { "Виробник", "Діагональ екрана", "Процесор" };
            foreach (var type in filterNames)
            {
                if (context.FilterNames.SingleOrDefault(f => f.Name == type) == null)
                {
                    context.FilterNames.Add(
                        new FilterName
                        {
                            Name = type
                        });
                    context.SaveChanges();
                }
            }
            #endregion

            #region tblFilterValues - Значення фільтрів
            List<string[]> filterValues = new List<string[]> {
                new string [] { "HP", "Dell", "Apple" },
                new string [] { "13\"", "14\"", "15\"-15.6\"", "16\"-17\"" },
                new string [] { "Intel Core i5", "Intel Core i7", "AMD Ryzen 9" }
            };

            foreach (var items in filterValues)
            {
                foreach (var value in items)
                {
                    if (context.FilterValues
                        .SingleOrDefault(f => f.Name == value) == null)
                    {
                        context.FilterValues.Add(
                            new FilterValue
                            {
                                Name = value
                            });
                        context.SaveChanges();
                    }
                }
            }
            #endregion

            #region Групування фільтрів

            for (int i = 0; i < filterNames.Length; i++)
            {
                foreach (var value in filterValues[i])
                {
                    var nId = context.FilterNames // пошук Id назви фільтра(filterNames)
                        .SingleOrDefault(ben => ben.Name == filterNames[i]).Id;
                    var vId = context.FilterValues // пошук по valueId 
                        .SingleOrDefault(f => f.Name == value).Id;
                    if (context.FilterNameGroups
                        .SingleOrDefault(f => f.FilterValueId == vId &&
                        f.FilterNameId == nId) == null)
                    {
                        context.FilterNameGroups.Add(
                            new FilterNameGroup
                            {
                                FilterNameId = nId,
                                FilterValueId = vId
                            });
                        context.SaveChanges();
                    }
                }
            }

            #endregion


        }


        #endregion
    }
}

