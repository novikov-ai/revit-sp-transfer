using System;
using SharedParametersTransfer.Core;
using SharedParametersTransfer.Models;
using SharedParametersTransfer.Models;

namespace ConstantsUses.TransferResult.ParameterGroups
{
    public partial class AllParametersSplitted
    {
        [GroupName("01 Обязательные ОБЩИЕ")]
        public static class Common
        {
            /// <summary>
            /// ADSK_Единица измерения
            /// </summary>
            public static readonly ConstantParameter AdskUnit =
                new ConstantParameter("ADSK_Единица измерения", new Guid("4289cb19-9517-45de-9c02-5a74ebf5c86d"));

            /// <summary>
            /// ADSK_Завод-изготовитель
            /// </summary>
            public static readonly ConstantParameter Parameter1 =
                new ConstantParameter("ADSK_Завод-изготовитель", new Guid("a8cdbf7b-d60a-485e-a520-447d2055f351"));

            /// <summary>
            /// ADSK_Зона
            /// </summary>
            public static readonly ConstantParameter Parameter2 =
                new ConstantParameter("ADSK_Зона", new Guid("c78f0a7d-b68b-4d21-a247-1c8c6ced8bc5"));

            /// <summary>
            /// ADSK_Код изделия
            /// </summary>
            public static readonly ConstantParameter Parameter3 =
                new ConstantParameter("ADSK_Код изделия", new Guid("2fd9e8cb-84f3-4297-b8b8-75f444e124ed"));

            /// <summary>
            /// ADSK_Марка
            /// </summary>
            public static readonly ConstantParameter Parameter4 =
                new ConstantParameter("ADSK_Марка", new Guid("2204049c-d557-4dfc-8d70-13f19715e46d"));

            /// <summary>
            /// ADSK_Масса
            /// </summary>
            public static readonly ConstantParameter Parameter5 =
                new ConstantParameter("ADSK_Масса", new Guid("32989501-0d17-4916-8777-da950841c6d7"));

            /// <summary>
            /// ADSK_Масса_Текст
            /// </summary>
            public static readonly ConstantParameter Parameter6 =
                new ConstantParameter("ADSK_Масса_Текст", new Guid("a8832df7-0302-4a63-a6e1-47a01632b987"));

            /// <summary>
            /// ADSK_Материал обозначение
            /// </summary>
            public static readonly ConstantParameter Parameter7 =
                new ConstantParameter("ADSK_Материал обозначение", new Guid("dbe7f282-3606-44cf-ac51-0f274c34c07b"));

            /// <summary>
            /// ADSK_Материал наименование
            /// </summary>
            public static readonly ConstantParameter Parameter8 =
                new ConstantParameter("ADSK_Материал наименование", new Guid("87ce1509-068e-400f-afab-75df889463c7"));

            /// <summary>
            /// ADSK_Наименование
            /// </summary>
            public static readonly ConstantParameter Parameter9 =
                new ConstantParameter("ADSK_Наименование", new Guid("e6e0f5cd-3e26-485b-9342-23882b20eb43"));

            /// <summary>
            /// ADSK_Наименование краткое
            /// </summary>
            public static readonly ConstantParameter Parameter10 =
                new ConstantParameter("ADSK_Наименование краткое", new Guid("f194bf60-b880-4217-b793-1e0c30dda5e9"));

            /// <summary>
            /// ADSK_Обозначение
            /// </summary>
            public static readonly ConstantParameter Parameter11 =
                new ConstantParameter("ADSK_Обозначение", new Guid("9c98831b-9450-412d-b072-7d69b39f4029"));

            /// <summary>
            /// ADSK_Позиция
            /// </summary>
            public static readonly ConstantParameter Parameter12 =
                new ConstantParameter("ADSK_Позиция", new Guid("ae8ff999-1f22-4ed7-ad33-61503d85f0f4"));

            /// <summary>
            /// ADSK_Предел огнестойкости
            /// </summary>
            public static readonly ConstantParameter Parameter13 =
                new ConstantParameter("ADSK_Предел огнестойкости", new Guid("4d902dad-86e1-4713-841a-a196798dbdf9"));

            /// <summary>
            /// ADSK_Примечание
            /// </summary>
            public static readonly ConstantParameter Parameter14 =
                new ConstantParameter("ADSK_Примечание", new Guid("a85b7661-26b0-412f-979c-66af80b4b2c3"));

            /// <summary>
            /// ADSK_Этаж
            /// </summary>
            public static readonly ConstantParameter Parameter15 =
                new ConstantParameter("ADSK_Этаж", new Guid("9eabf56c-a6cd-4b5c-a9d0-e9223e19ea3f"));

            /// <summary>
            /// ADSK_URL документации изделия
            /// </summary>
            public static readonly ConstantParameter Parameter16 =
                new ConstantParameter("ADSK_URL документации изделия",
                    new Guid("bddc75f4-8e27-4afc-add0-de7358bbf6d3"));

            /// <summary>
            /// ADSK_URL страницы изделия
            /// </summary>
            public static readonly ConstantParameter Parameter17 =
                new ConstantParameter("ADSK_URL страницы изделия", new Guid("c5f25d97-91ad-48c8-96e2-99eac6fbb3f1"));

            /// <summary>
            /// ADSK_Количество
            /// </summary>
            public static readonly ConstantParameter Parameter18 =
                new ConstantParameter("ADSK_Количество", new Guid("8d057bb3-6ccd-4655-9165-55526691fe3a"));
        }
    }
}