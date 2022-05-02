using System;
using SharedParametersTransfer.Core;
using SharedParametersTransfer.Models;

namespace ConstantsUses.TransferResult.ParameterGroups
{
    public partial class AllParametersSplitted
    {
       [GroupName("10 Размеры")]
        public static class Dimensions
        {
            /// <summary>
            /// ADSK_Размер_Высота
            /// </summary>
            public static readonly ConstantParameter Parameter0 =
                new ConstantParameter("ADSK_Размер_Высота", new Guid("da753fe3-ecfa-465b-9a2c-02f55d0c2ff1"));

            /// <summary>
            /// ADSK_Размер_Длина
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Размер_Длина", new Guid("748a2515-4cc9-4b74-9a69-339a8d65a212"));

            /// <summary>
            /// ADSK_Размер_Толщина
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Размер_Толщина", new Guid("293f055d-6939-4611-87b7-9a50d0c1f50e"));

            /// <summary>
            /// ADSK_Размер_Ширина
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Размер_Ширина", new Guid("8f2e4f93-9472-4941-a65d-0ac468fd6a5d"));

            /// <summary>
            /// ADSK_Размер_Диаметр
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Размер_Диаметр", new Guid("9b679ab7-ea2e-49ce-90ab-0549d5aa36ff"));

            /// <summary>
            /// ADSK_Размер_Толщина полки
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Размер_Толщина полки", new Guid("31881d64-b1c3-45d2-ab34-baf2ee3e74e4"));

            /// <summary>
            /// ADSK_Размер_Толщина стенки
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Размер_Толщина стенки", new Guid("de129aa9-dae8-430d-8de8-f7f08388fcaa"));

            /// <summary>
            /// ADSK_Размер_Глубина
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Размер_Глубина", new Guid("14e630a8-bc4f-4556-9094-647e8f323f08"));

            /// <summary>
            /// ADSK_Размер_ДиаметрИзделия
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Размер_ДиаметрИзделия", new Guid("d6888dc7-7a03-40c3-9ac2-ab300c4e2c0a"));

            /// <summary>
            /// ADSK_Размер_Толщина основы
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Размер_Толщина основы", new Guid("398ea174-e0ef-4619-8db9-0b2c598d5206"));

            /// <summary>
            /// ADSK_Размер_УголПоворота
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Размер_УголПоворота", new Guid("a7397d18-200b-4659-b34c-3d8ae1c54317"));

            /// <summary>
            /// ADSK_Размер_Радиус
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Размер_Радиус", new Guid("f49bf488-e8a4-4517-ac59-e5ea2093350d"));
        }
    }
}