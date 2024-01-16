﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace BlazingPizza.Server.CompiledModels
{
    internal partial class PizzaToppingEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "BlazingPizza.PizzaTopping",
                typeof(PizzaTopping),
                baseEntityType);

            var pizzaId = runtimeEntityType.AddProperty(
                "PizzaId",
                typeof(int),
                propertyInfo: typeof(PizzaTopping).GetProperty("PizzaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PizzaTopping).GetField("<PizzaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            pizzaId.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var toppingId = runtimeEntityType.AddProperty(
                "ToppingId",
                typeof(int),
                propertyInfo: typeof(PizzaTopping).GetProperty("ToppingId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PizzaTopping).GetField("<ToppingId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            toppingId.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));

            var key = runtimeEntityType.AddKey(
                new[] { pizzaId, toppingId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { toppingId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PizzaId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var toppings = principalEntityType.AddNavigation("Toppings",
                runtimeForeignKey,
                onDependent: false,
                typeof(List<PizzaTopping>),
                propertyInfo: typeof(Pizza).GetProperty("Toppings", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Pizza).GetField("<Toppings>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ToppingId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var topping = declaringEntityType.AddNavigation("Topping",
                runtimeForeignKey,
                onDependent: true,
                typeof(Topping),
                propertyInfo: typeof(PizzaTopping).GetProperty("Topping", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PizzaTopping).GetField("<Topping>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PizzaTopping");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
